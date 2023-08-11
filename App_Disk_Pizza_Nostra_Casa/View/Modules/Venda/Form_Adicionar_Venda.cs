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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Venda
{

    public partial class form_adicionar_venda : Form
    {

        public form_adicionar_venda()
        {

            InitializeComponent();

        }

        private void form_adicionar_venda_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            /**
             * if
             * se sim, limpar
             */

            if(MessageBox.Show("Realmente deseja limpar todos os campos?", "Atenção!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cbx_cliente_addvenda.Text = "";
                cbx_pizzas_addvenda.Text = "";
                cbx_bebidas_addvenda.Text = "";

                lbl_valortotal.Text = "";

            }

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {



        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {



        }

    }

}