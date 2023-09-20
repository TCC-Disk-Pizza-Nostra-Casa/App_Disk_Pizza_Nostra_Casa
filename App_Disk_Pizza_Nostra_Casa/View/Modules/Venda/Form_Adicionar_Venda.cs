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

        private async void form_adicionar_venda_Load(object sender, EventArgs e)
        {

            List<Model.Produto>? produtoList = await Data_Service_Produto.GetListAsyncProduto();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(produtoList[0].nome);
            Console.WriteLine("--------------------------------------------");


            cbx_produtos_addvenda.Items.Add("");

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            /**
             * Limpa todos os campos
             */

            if (MessageBox.Show("Realmente deseja limpar todos os campos?", "Atenção!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cbx_cliente_addvenda.Text = "";
                cbx_produtos_addvenda.Text = "";

                lbl_valortotal.Text = "0";
                rdbtn_nao.Checked = false;
                rdbtn_sim.Checked = false;

                txt_observacoes.Text = "";

            }

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            // valor pizza(s) + valor bebida(s) = lblValorTotal



        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {



        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void lbl_valortotal_Click(object sender, EventArgs e)
        {

        }

        private void cbx_cliente_addvenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_produtos_addvenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}