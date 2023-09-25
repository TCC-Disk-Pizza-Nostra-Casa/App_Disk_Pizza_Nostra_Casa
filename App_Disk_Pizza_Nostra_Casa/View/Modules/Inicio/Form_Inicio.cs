using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Inicio
{

    public partial class form_inicio : Form
    {

        private Form formulario_associado = null;

        public Model.Funcionario usuario_sessao;

        public form_inicio()
        {

            InitializeComponent();

        }

        private void form_inicio_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(1200, 700);

                this.Size = new Size(1200, 800);

                Hide_Submenus();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Hide_Submenus()
        {

            try
            {

                pnl_submenu_funcionarios.Visible = false;

                pnl_submenu_produtos.Visible = false;

                pnl_submenu_vendas.Visible = false;

                pnl_submenu_clientes.Visible = false;

                pnl_submenu_fornecedores.Visible = false;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Submenu_Visibility(Panel painel)
        {

            try
            {

                if (painel.Visible)
                {

                    painel.Visible = false;

                }

                else
                {

                    Hide_Submenus();

                    painel.Visible = true;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void External_Form_Association(Form formulario_externo)
        {

            try
            {

                if (MessageBox.Show("Caso haja algum formulário aberto, ele será fechado! Prosseguir?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (this.formulario_associado != null)
                    {

                        this.formulario_associado.Close();

                    }

                    this.formulario_associado = formulario_externo;

                    formulario_externo.TopLevel = false;

                    formulario_externo.FormBorderStyle = FormBorderStyle.None;

                    formulario_externo.Dock = DockStyle.Fill;

                    pnl_formulario_externo.Controls.Add(formulario_externo);

                    pnl_formulario_externo.Tag = formulario_externo;

                    formulario_externo.BringToFront();

                    formulario_externo.Show();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

            try
            {

                Submenu_Visibility(pnl_submenu_funcionarios);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_listagem_funcionario_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Funcionario.form_listagem_funcionarios());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cadastro_funcionario_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Funcionario.form_cadastro_funcionarios());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {

            try
            {

                Submenu_Visibility(pnl_submenu_produtos);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cadastro_produto_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Produto.form_cadastro_produtos());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_listagem_produtos_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Produto.form_listagem_produtos());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {

            try
            {

                Submenu_Visibility(pnl_submenu_vendas);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_adicionar_venda_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Venda.form_adicionar_venda());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_listagem_vendas_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Venda.form_listagem_vendas());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_perfil_Click(object sender, EventArgs e)
        {

            try
            {

                if (this.usuario_sessao != null)
                {

                    // Fonte de Pesquisa: https://www.macoratti.net/10/10/c_inbox.htm

                    string senha = Microsoft.VisualBasic.Interaction.InputBox("Insira sua senha:", "Confirmação de Usuário");

                    if (senha != "")
                    {

                        string[] dados_confirmacao = { this.usuario_sessao.cpf, senha };

                        List<Model.Funcionario> usuario_encontrado = await Service.Data_Service_Funcionario.LoginAsyncFuncionario(dados_confirmacao);

                        if (usuario_encontrado.Count > 0 && usuario_encontrado[0].senha == this.usuario_sessao.senha)
                        {

                            Modules.Funcionario.form_cadastro_funcionarios form_funcionario = new Modules.Funcionario.form_cadastro_funcionarios();

                            //form_funcionario.usuario_sessao = this.usuario_sessao;

                            External_Form_Association(form_funcionario);

                        }

                        else
                        {

                            throw new Exception("Senha incorreta! Tente novamente.");

                        }

                    }

                }

                else
                {

                    MessageBox.Show("Para acessar essa guia, utilize um perfil que esteja registrado no banco de dados!", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Realmente deseja fechar a aplicação?", "Atenção!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Application.Exit();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {

            try
            {

                Submenu_Visibility(pnl_submenu_clientes);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cadastro_cliente_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Cliente.Form_Cadastro_Clientes());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_listagem_clientes_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Cliente.Form_Listagem_Clientes());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_fornecedores_Click(object sender, EventArgs e)
        {

            try
            {

                Submenu_Visibility(pnl_submenu_fornecedores);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cadastro_fornecedor_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Fornecedor.Form_Cadastro_Fornecedor());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_listagem_fornecedores_Click(object sender, EventArgs e)
        {

            try
            {

                External_Form_Association(new Modules.Fornecedor.Form_Listagem_Fornecedor());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}