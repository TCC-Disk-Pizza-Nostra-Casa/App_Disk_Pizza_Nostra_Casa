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

                cbbox_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;

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

                if(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
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

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {

                Model.Produto dados = new Model.Produto()
                {

                    nome = txt_nome.Text,

                    estoque = Convert.ToInt32(nud_estoque.Value),

                    preco = double.Parse(txt_preco.Text),

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