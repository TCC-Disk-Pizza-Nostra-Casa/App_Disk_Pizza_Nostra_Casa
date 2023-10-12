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
            List<Model.Cliente>? clienteList = await Data_Service_Cliente.GetListAsyncCliente();

            /** Items do cbx de Produto */
            //cbx_produtos_addvenda.Items.Add(produtoList[0].nome);
            //cbx_produtos_addvenda.Items.Add(produtoList[1].nome);

            /** Preenchendo os combo boxs */

            /**
            if (produtoList.Count > 0)
            {
                //Bebidas
                for (int i = 0; i <= 11; i++)
                {

                    cbx_bebidas_add_venda.Items.Add(produtoList[i].nome);

                }

                //Pizzas 1) Grande
                for (int i = 12; i <= 23; i++)
                {

                    cbx_pizza1_grande_addvenda.Items.Add(produtoList[i].nome);

                }

                //Pizzas 1) Broto
                for (int i = 24; i <= 35; i++)
                {

                    cbx_pizza1_broto_addvenda.Items.Add(produtoList[i].nome);

                }

                //Pizzas 2) Grande
                for (int i = 36; i <= 42; i++)
                {

                    cbx_pizza2_grande_addvenda.Items.Add(produtoList[i].nome);

                }

                //Pizzas 2) Broto
                for (int i = 43; i <= 49; i++)
                {

                    cbx_pizza2_broto_addvenda.Items.Add(produtoList[i].nome);

                }

                //Especiais Grande
                for (int i = 50; i <= 79; i++)
                {

                    cbx_especiais_grande_addvenda.Items.Add(produtoList[i].nome);

                }

                //Especiais Broto
                for (int i = 79; i <= 98; i++)
                {

                    cbx_especiais_broto_addvenda.Items.Add(produtoList[i].nome);

                }

                //Doces Grande
                for (int i = 99; i <= 105; i++)
                {

                    cbx_doces_grande_addvenda.Items.Add(produtoList[i].nome);

                }

                //Doces Broto
                for (int i = 106; i <= 112; i++)
                {

                    cbx_doces_broto_addvenda.Items.Add(produtoList[i].nome);

                }

            }

            */


            /** Selecionando pizzas grandes */
            if (cbox_grande.Checked)
            {



            }

            /** Selecionando pizzas broto */
            if (cbox_broto.Checked)
            {



            }

            /** Bebidas */

        }

        /**
         * Ira calcular os produtos e mostrar na lbl_valortotal
         */
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            // valor pizza(s) + valor bebida(s) = lbltalortotal
            //List<Model.Produto>? produtoList = await Data_Service_Produto.GetListAsyncProduto();

            //cbx_produtos_addvenda.Items.Add(produtoList[0].preco);

            //lbl_valortotal = 


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
        private async void btn_Salvar_Click(object sender, EventArgs e)
        {

            Model.Venda venda = new Model.Venda()
            {
                /**
                data_venda = // data_atual
                delivery = cbox_delivery.checked,
                valor_total = // soma
                funcionario = // funcionario atual
                cliente = cbx_clientes_addvenda,
                produto = // dgv_adicionar_vendas.produtoList[];
                quantidade_produto = dgv_adicionar_vendas.RowCount,
                valor_total_item_venda = // produtoList[].preco + [...].preco;
                */

            };

            Model.Venda venda_model = await Data_Service_Venda.SaveAsyncVenda(venda);

            if (venda_model != null)
            {

                MessageBox.Show("Venda feita com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


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
            string itemSelecionado = cbx_produtos_addvenda.Text;
            dgv_adicionar_vendas.Rows.Add(itemSelecionado, produtoList[0].preco);


        }

        private void btnInserir_dgv_Click(object sender, EventArgs e)
        {
            //Adicionando ao dgv os dados do cbx
            dgv_adicionar_vendas.Rows.Add("");
            cbx_produtos_addvenda.Text = "";



        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {

            if (dgv_adicionar_vendas.RowCount > 0)
            {

                if ((MessageBox.Show("Tem certeza?", "Venda será excluída!", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    dgv_adicionar_vendas.Rows.RemoveAt(dgv_adicionar_vendas.CurrentRow.Index);
                }

            }
            else if (dgv_adicionar_vendas.RowCount == 0)
            {
                MessageBox.Show("Não existem registros a serem removidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}