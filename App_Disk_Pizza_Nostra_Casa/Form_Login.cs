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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Login
{

    public partial class form_login : Form
    {

        public form_login()
        {

            InitializeComponent();

        }

        private void form_login_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(1045, 579);

                this.MaximumSize = new Size(1045, 579);

                this.Size = new Size(1045, 579);

                txt_usuario.BackColor = this.BackColor;

                txt_senha.BackColor = this.BackColor;

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_entrar_Click(object sender, EventArgs e)
        {

            try
            {

                // Condição destinada para testes da aplicação.
                if(txt_usuario.Text == "root_testes" && txt_senha.Text == "etecjau")
                {

                    MessageBox.Show("Iniciando sessão de testes.", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Hide();

                    new form_inicio().Show();

                }

                else
                {

                    string[] dados_login = { txt_usuario.Text, txt_senha.Text };

                    List<Model.Funcionario> usuario_encontrado = await Data_Service_Funcionario.LoginAsyncFuncionario(dados_login);

                    if (usuario_encontrado.Count == 0)
                    {

                        throw new Exception("Nenhum usuário encontrado! Verifique seu usuário e senha.");

                    }

                    else
                    {

                        MessageBox.Show("Login efetuado com sucesso.", "Atenção!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.Hide();

                        new form_inicio().Show();

                    }

                }

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
