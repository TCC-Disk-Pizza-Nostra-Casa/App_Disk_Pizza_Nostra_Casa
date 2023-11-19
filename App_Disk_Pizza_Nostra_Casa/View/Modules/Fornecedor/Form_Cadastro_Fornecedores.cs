using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{

    public partial class form_cadastro_fornecedores : Form
    {

        public Model.Fornecedor? fornecedor_selecionado = null;

        public form_cadastro_fornecedores()
        {

            InitializeComponent();

        }

        private void Form_Cadastro_Fornecedor_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

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

                if (this.fornecedor_selecionado != null)
                {

                    txt_nome.Text = this.fornecedor_selecionado.nome;

                    mtxt_cnpj.Text = this.fornecedor_selecionado.cnpj;

                    txt_email.Text = this.fornecedor_selecionado.email;

                    mtxt_telefone.Text = this.fornecedor_selecionado.telefone;

                    txt_observacoes.Text = this.fornecedor_selecionado.observacoes;

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

                if (!Global.administrador)
                {

                    throw new Exception("O usuário atual não tem a permissão necessária para executar essa ação.");

                }

                else
                {

                    string[] masks = { mtxt_cnpj.Mask, mtxt_telefone.Mask };

                    mtxt_cnpj.Mask = "";

                    mtxt_telefone.Mask = "";

                    Model.Fornecedor dados = new Model.Fornecedor()
                    {

                        id = (this.fornecedor_selecionado != null) ? this.fornecedor_selecionado.id : 0,

                        nome = txt_nome.Text,

                        cnpj = mtxt_cnpj.Text,

                        email = (String.IsNullOrWhiteSpace(txt_email.Text)) ? "Não informado" : txt_email.Text,

                        telefone = mtxt_telefone.Text,

                        observacoes = (String.IsNullOrWhiteSpace(txt_observacoes.Text)) ? "Nenhuma observação" : txt_observacoes.Text,

                    };

                    mtxt_cnpj.Mask = masks[0];

                    mtxt_telefone.Mask = masks[1];

                    if (await dados.Save())
                    {

                        this.Close();

                    }

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