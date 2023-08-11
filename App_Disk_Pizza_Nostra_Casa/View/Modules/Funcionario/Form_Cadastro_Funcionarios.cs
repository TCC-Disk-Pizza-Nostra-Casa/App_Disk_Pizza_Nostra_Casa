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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Funcionario
{

    public partial class form_cadastro_funcionarios : Form
    {

        public form_cadastro_funcionarios()
        {

            InitializeComponent();

        }

        private void form_cadastro_funcionarios_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_genero.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_cargo.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_genero.DataSource = new string[] { "Selecione uma opção", "Masculino", "Feminino", "Não informar" };

                cbbox_cargo.DataSource = new string[] { "Selecione uma opção", "Balconista" };

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_cadastrar_Click(object sender, EventArgs e)
        {

            try
            {

                if(String.IsNullOrEmpty(mtxt_cpf.Text.Replace(".", "").Replace("-", "")) ||
                   String.IsNullOrEmpty(mtxt_rg.Text.Replace(".", "").Replace("-", "")) ||
                   String.IsNullOrEmpty(txt_nome.Text) || String.IsNullOrEmpty(txt_senha.Text) ||
                   cbbox_genero.SelectedIndex == 0 || cbbox_cargo.SelectedIndex == 0)
                {

                    MessageBox.Show("Preencha todos os campos necessários antes de prosseguir.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {

                    if(MessageBox.Show("Realmente deseja confirmar este cadastro?", "Atenção!",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Model.Funcionario objeto_retornado = await Data_Service_Funcionario.SaveAsyncFuncionario(new Model.Funcionario()
                        {

                            nome = txt_nome.Text,

                            genero = cbbox_genero.Text,

                            cpf = mtxt_cpf.Text.Replace(".", "").Replace("-", ""),

                            rg = mtxt_rg.Text.Replace(".", "").Replace("-", ""),

                            cargo = cbbox_cargo.Text,

                            cep = mtxt_cep.Text.Replace(".", "").Replace("-", ""),

                            email = txt_email.Text,

                            telefone = mtxt_telefone.Text.Replace("(", "").Replace(")", "").Replace("-", ""),

                            senha = txt_senha.Text,

                            observacoes = txt_observacoes.Text,

                            administrador = ckbox_administrador.Checked

                        });

                        if(objeto_retornado.id != null)
                        {

                            MessageBox.Show("Cadastro efetuado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            this.Close();

                        }

                        else
                        {

                            throw new Exception("Ocorreu um erro ao tentar efetuar o cadastro! Revise os dados inseridos e tente novamente.");

                        }

                    }

                }

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            try
            {

                if(MessageBox.Show("Realmente deseja cancelar este cadastro?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.Close();

                }

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}