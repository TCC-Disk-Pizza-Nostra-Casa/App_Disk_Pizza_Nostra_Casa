using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Produto
{

    public partial class form_cadastro_produtos : Form
    {

        public Model.Produto? produto_selecionado = null;

        public form_cadastro_produtos()
        {

            InitializeComponent();

        }

        private async void form_cadastro_produtos_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_tamanho.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_categoria.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_tamanho.DataSource = new string[] { "Grande", "Broto" };

                cbbox_categoria.DataSource = new string[] { "Pizza comum", "Pizza especial", "Pizza doce", "Bebida", "Doce" };

                cbbox_fornecedor.DisplayMember = "nome";

                cbbox_fornecedor.ValueMember = "id";

                List<Model.Fornecedor> fornecedores_cadastrados = await Data_Service_Fornecedor.GetListAsyncFornecedor();

                if (fornecedores_cadastrados.Count > 0)
                {

                    List<Model.Fornecedor> fornecedores_ativos = new List<Model.Fornecedor>();

                    for (int i = 0; i < fornecedores_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(fornecedores_cadastrados[i].ativo))
                        {

                            fornecedores_ativos.Add(fornecedores_cadastrados[i]);

                        }

                    }

                    cbbox_fornecedor.DataSource = fornecedores_ativos;

                }

                Form_Fill();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Form_Fill()
        {

            try
            {

                if (this.produto_selecionado != null)
                {

                    txt_nome.Text = this.produto_selecionado.nome;

                    txt_preco.Text = this.produto_selecionado.preco.ToString();

                    cbbox_tamanho.Text = this.produto_selecionado.tamanho;

                    cbbox_categoria.Text = this.produto_selecionado.categoria;

                    cbbox_fornecedor.SelectedValue = this.produto_selecionado.fk_fornecedor;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txt_preco_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {

                if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                {

                    e.Handled = false;

                }

                else
                {

                    e.Handled = true;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbbox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                if (cbbox_categoria.SelectedIndex == 3 || cbbox_categoria.SelectedIndex == 4)
                {

                    cbbox_tamanho.DataSource = new string[] { "Único" };

                }

                else
                {

                    cbbox_tamanho.DataSource = new string[] { "Grande", "Broto" };

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {

                Model.Produto dados = new Model.Produto()
                {

                    id = (this.produto_selecionado != null) ? this.produto_selecionado.id : 0,

                    nome = txt_nome.Text,

                    preco = double.Parse(txt_preco.Text),

                    tamanho = cbbox_tamanho.Text,

                    categoria = cbbox_categoria.Text,

                    observacoes = txt_observacoes.Text,

                    fk_fornecedor = Convert.ToInt32(cbbox_fornecedor.SelectedValue)

                };

                if (await dados.Save())
                {

                    this.Close();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Deseja fechar este formulário?", "Atenção!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.Close();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}