using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View
{

    public partial class form_inicio : Form
    {

        private Form form_associado = null;

        public form_inicio()
        {

            InitializeComponent();

        }

        private void form_inicio_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(1045, 579);

            esconder_submenus();

        }

        private void esconder_submenus()
        {

            pnl_submenu_funcionarios.Visible = false;

            pnl_submenu_produtos.Visible = false;

            pnl_submenu_vendas.Visible = false;

        }

        private void visibilidade_submenus(Panel painel)
        {

            if(painel.Visible)
            {

                painel.Visible = false;

            }

            else
            {

                esconder_submenus();

                painel.Visible = true;

            }

        }

        private void associar_form_externo(Form form_externo)
        {

            if(form_associado != null)
            {

                form_associado.Close();

            }

            form_associado = form_externo;

            form_externo.TopLevel = false;

            form_externo.FormBorderStyle = FormBorderStyle.None;

            form_externo.Dock = DockStyle.Fill;

            pnl_formulario_externo.Controls.Add(form_externo);

            pnl_formulario_externo.Tag = form_externo;

            form_externo.BringToFront();

            form_externo.Show();

        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

            visibilidade_submenus(pnl_submenu_funcionarios);

        }

        private void btn_listagem_funcionario_Click(object sender, EventArgs e)
        {

            associar_form_externo(new Modules.Funcionario.form_listagem_funcionarios());

        }

        private void btn_cadastro_funcionario_Click(object sender, EventArgs e)
        {

            associar_form_externo(new Modules.Funcionario.form_cadastro_funcionarios());

        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {

            visibilidade_submenus(pnl_submenu_produtos);

        }

        private void btn_cadastro_produto_Click(object sender, EventArgs e)
        {

            associar_form_externo(new Modules.Produto.Form_Cadastro_Produtos());

        }

        private void btn_listagem_produtos_Click(object sender, EventArgs e)
        {

            associar_form_externo(new Modules.Produto.form_listagem_produtos());

        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {

            visibilidade_submenus(pnl_submenu_vendas);

        }

        private void btn_adicionar_venda_Click(object sender, EventArgs e)
        {

            associar_form_externo(new Modules.Venda.form_adicionar_venda());

        }

        private void btn_listagem_vendas_Click(object sender, EventArgs e)
        {

            associar_form_externo(new Modules.Venda.form_listagem_vendas());

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Realmente deseja fechar a aplicação?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }

        }

    }

}
