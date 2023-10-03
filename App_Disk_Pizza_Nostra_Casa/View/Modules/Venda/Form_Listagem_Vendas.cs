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

    public partial class form_listagem_vendas : Form
    {

        public form_listagem_vendas()
        {

            InitializeComponent();

        }

        private async void form_listagem_vendas_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                List<Model.Venda>? lista_vendas = await Model.Venda.GetList();

                this.fillDgvVenda(lista_vendas);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private async void btn_pesquisar_vendas_Click(object sender, EventArgs e)
        {
            try
            {

                this.MinimumSize = new Size(800, 500);
                this.Size = new Size(800, 500);

                dgv_listagem_vendas.Rows.Clear();
                string parametro = txt_pesquisar_vendas.Text.ToString();
                List<Model.Venda> lista_vendas = await Data_Service_Venda.SearchAsyncVenda(parametro);

                this.fillDgvVenda(lista_vendas);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Venda será excluída!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgv_listagem_vendas.CurrentRow.Cells["id"].Value);

                await Data_Service_Venda.DeleteAsyncVenda(id);

                dgv_listagem_vendas.Rows.RemoveAt(dgv_listagem_vendas.CurrentRow.Index);
            }
        }

        public void fillDgvVenda(List<Model.Venda> lista_vendas)
        {
            if (lista_vendas.Count > 0)
            {
                for (int i = 0; i < lista_vendas.Count; i++)
                {

                    string id = lista_vendas[i].id.ToString();
                    string data_venda = lista_vendas[i].data_venda.ToString();

                    string delivery = (Convert.ToBoolean(lista_vendas[i].delivery)) ? "Sim" : "Não";

                    string cliente = lista_vendas[i].cliente.ToString();

                    string funcionario = lista_vendas[i].funcionario.ToString();

                    string valor_total = lista_vendas[i].valor_total.ToString();

                    dgv_listagem_vendas.Rows.Add(id, i + 1, data_venda, cliente, delivery, funcionario, valor_total);

                }

            }
        }
    }

}