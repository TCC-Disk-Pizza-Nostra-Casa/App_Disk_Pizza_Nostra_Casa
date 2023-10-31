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

            List<Model.Produto>? produtoList = await Model.Produto.GetList();
            List<Model.Cliente>? clienteList = await Model.Cliente.GetList();

            /** Items do cbx de Produto */
            //cbx_produtos_addvenda.Items.Add(produtoList[0].nome);
            //cbx_produtos_addvenda.Items.Add(produtoList[1].nome);


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
            List<Model.Produto>? produtoList = await Model.Produto.GetList();
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