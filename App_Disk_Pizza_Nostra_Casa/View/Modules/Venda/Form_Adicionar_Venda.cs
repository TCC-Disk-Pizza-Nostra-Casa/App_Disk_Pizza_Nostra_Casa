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

            /** Items do cbx */
            cbx_produtos_addvenda.Items.Add(produtoList[0].nome);

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

        /**
         * Ira calcular os produtos e mostrar na lbl_valortotal
         */
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            // valor pizza(s) + valor bebida(s) = lbltalortotal



        }

        /**
         * 
         * Irá salvar as informações da venda, enviar pra API.
         * Na listagem recuperaremos esses dados.
         * 
         * Esse botão só deve ser acionado quando o Funcionário for 
         * adicionar a venda, somente quando tiver certeza.
         * 
         * O Funcionário ira pedir ao cliente se pode concluir a venda,
         * se a resposta for afirmativa, a venda é feita, sendo cadastrada.
         * 
         */
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //dgv_adicionar_vendas.Rows.Add();


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

        /**
         * ComboBox que ira recuperar uma lista de clientes cadastrados para selecioná-los
         */
        private void cbx_cliente_addvenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /**
         * ComboBox que ira recuperar uma lista de produtos cadastrados para selecioná-los
         */
        private async void cbx_produtos_addvenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Model.Produto>? produtoList = await Data_Service_Produto.GetListAsyncProduto();
            /** Adicionando o que selecionou */
            string itemSelecionado = cbx_produtos_addvenda.SelectedItem.ToString();
            dgv_adicionar_vendas.Rows.Add(itemSelecionado, produtoList[0].preco);

          
        }

        private void btnInserir_dgv_Click(object sender, EventArgs e)
        {
            //Adicionando ao dgv os dados do cbx
            dgv_adicionar_vendas.Rows.Add("");
            cbx_produtos_addvenda.Text = "";



        }
    }

}