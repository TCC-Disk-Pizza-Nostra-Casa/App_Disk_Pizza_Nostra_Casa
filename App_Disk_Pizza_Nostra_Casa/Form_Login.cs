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

                this.MinimumSize = new Size(600, 400);

                this.MaximumSize = new Size(600, 400);

                this.Size = new Size(600, 400);

                mtxt_cpf.BackColor = this.BackColor;

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

                if (String.IsNullOrEmpty(mtxt_cpf.Text) || String.IsNullOrEmpty(txt_senha.Text))
                {

                    throw new Exception("Preencha todos os campos antes de prosseguir.");

                }

                else
                {

                    // Condição destinada para testes da aplicação.

                    if (mtxt_cpf.Text == "123.456.789-09" && txt_senha.Text == "etecjau")
                    {

                        MessageBox.Show("Iniciando sessão de testes.", "Atenção!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.Hide();

                        View.Modules.Inicio.form_inicio tela_inicial = new View.Modules.Inicio.form_inicio();

                        Global.usuario_sessao = new Model.Funcionario()
                        {

                            nome = "Root",

                            sexo = "Não informado.",

                            estado_civil = "Solteiro",

                            cpf = "12345678909",

                            cep = "17212646",

                            email = "root@etec.sp.gov.br",

                            telefone = "14991116468",

                            senha = "1234",

                            observacoes = "Usuário de testes",

                            administrador = 1

                        };

                        Global.formulario_global = tela_inicial;

                        Global.administrador = Convert.ToBoolean(Global.usuario_sessao.administrador);

                        tela_inicial.Show();

                    }

                    else
                    {

                        string[] dados_login = { mtxt_cpf.Text, txt_senha.Text };

                        Model.Funcionario usuario_encontrado = await Model.Funcionario.Login(dados_login);

                        if (usuario_encontrado != null)
                        {

                            MessageBox.Show("Login efetuado com sucesso! Seja bem-vindo(a) " + usuario_encontrado.nome + ".",
                                            "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            this.Hide();

                            View.Modules.Inicio.form_inicio tela_inicial = new View.Modules.Inicio.form_inicio();

                            Global.usuario_sessao = usuario_encontrado;

                            Global.formulario_global = tela_inicial;

                            Global.administrador = Convert.ToBoolean(Global.usuario_sessao.administrador);

                            tela_inicial.Show();

                        }

                        else
                        {

                            mtxt_cpf.Clear();

                            txt_senha.Clear();

                            throw new Exception("Nenhum usuário encontrado! Verifique seu CPF e senha.");

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