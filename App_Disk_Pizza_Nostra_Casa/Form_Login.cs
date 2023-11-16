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

                if (String.IsNullOrEmpty(mtxt_cpf.Text.Trim()) || String.IsNullOrEmpty(txt_senha.Text.Trim()))
                {

                    throw new Exception("Preencha todos os campos antes de prosseguir.");

                }

                else
                {

                    string[] dados_login = { mtxt_cpf.Text, txt_senha.Text };

                    Model.Funcionario usuario_encontrado = await Model.Funcionario.Login(dados_login);

                    if (usuario_encontrado != null && usuario_encontrado.ativo == 1)
                    {

                        MessageBox.Show("Login efetuado com sucesso! Seja bem-vindo(a), " + usuario_encontrado.nome + ".",
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

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}