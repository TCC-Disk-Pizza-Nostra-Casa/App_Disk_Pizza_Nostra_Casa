using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa
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

                this.MinimumSize = new Size(700, 400);

                this.MaximumSize = new Size(700, 400);

                this.Size = new Size(700, 400);

                txt_cpf.BackColor = this.BackColor;

                txt_senha.BackColor = this.BackColor;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_entrar_Click(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrEmpty(txt_cpf.Text) || String.IsNullOrEmpty(txt_senha.Text))
                {

                    throw new Exception("Preencha todos os campos antes de prosseguir.");

                }

                else
                {

                    // Condição destinada para testes da aplicação.

                    if (txt_cpf.Text == "12345678909" && txt_senha.Text == "etecjau")
                    {

                        MessageBox.Show("Iniciando sessão de testes.", "Atenção!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.Hide();

                        View.Modules.Inicio.form_inicio tela_inical = new View.Modules.Inicio.form_inicio();

                        tela_inical.usuario_sessao = new Model.Funcionario()
                        {

                            nome = "Root",

                            genero = "Não informado.",

                            cpf = "12345678909",

                            rg = "123456789",

                            cargo = "Balconista",

                            cep = "17212646",

                            email = "root@etec.sp.gov.br",

                            telefone = "14991116468",

                            senha = "1234",

                            observacoes = "Usuário de testes",

                            administrador = true

                        };

                        tela_inical.Show();

                    }

                    else
                    {

                        string[] dados_login = { txt_cpf.Text, txt_senha.Text };

                        List<Model.Funcionario> usuario_encontrado = await Service.Data_Service_Funcionario.LoginAsyncFuncionario(dados_login);

                        if (usuario_encontrado.Count > 0)
                        {

                            MessageBox.Show("Login efetuado com sucesso.", "Atenção!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            this.Hide();

                            View.Modules.Inicio.form_inicio tela_inical = new View.Modules.Inicio.form_inicio();

                            tela_inical.usuario_sessao = usuario_encontrado[0];

                            tela_inical.Show();

                        }

                        else
                        {

                            txt_cpf.Clear();

                            txt_senha.Clear();

                            throw new Exception("Nenhum usuário encontrado! Verifique seu usuário e senha.");

                        }

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}