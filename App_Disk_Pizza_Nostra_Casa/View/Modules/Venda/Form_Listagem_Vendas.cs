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

        private void form_listagem_vendas_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_condicao_venda.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_condicao_venda.DataSource = new string[] { "Não ativos", "Ativos" };

                cbbox_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_cliente.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_funcionario.DisplayMember = "nome";

                cbbox_funcionario.ValueMember = "id";

                cbbox_cliente.DisplayMember = "nome";

                cbbox_cliente.ValueMember = "id";

                Sales_DataGridView_Configuration();

                Items_DataGridView_Configuration();

                cbbox_condicao_venda.SelectedIndex = 1;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Sales_DataGridView_Configuration()
        {

            try
            {

                // Configurações iniciais.

                dgv_listagem_vendas.Font = new Font(new FontFamily("Arial"), 12f);

                dgv_listagem_vendas.ForeColor = Color.Black;

                dgv_listagem_vendas.Columns.Clear();

                dgv_listagem_vendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dgv_listagem_produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;

                dgv_listagem_vendas.ReadOnly = true;

                // Permissões do usuário.

                dgv_listagem_vendas.AllowUserToAddRows = false;

                dgv_listagem_vendas.AllowUserToDeleteRows = false;

                dgv_listagem_vendas.AllowUserToOrderColumns = true;

                dgv_listagem_vendas.AllowUserToResizeRows = true;

                // Colunas.

                dgv_listagem_vendas.Columns.Insert(0, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(2, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(3, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(4, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(5, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(6, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(7, new DataGridViewTextBoxColumn());

                dgv_listagem_vendas.Columns.Insert(8, new DataGridViewTextBoxColumn());

                // Dados das colunas.

                dgv_listagem_vendas.Columns[0].HeaderText = "ID:";
                dgv_listagem_vendas.Columns[0].Name = "dgv_listagem_vendas_id";
                dgv_listagem_vendas.Columns[0].Visible = false;

                dgv_listagem_vendas.Columns[1].HeaderText = "ID_funcionario:";
                dgv_listagem_vendas.Columns[1].Name = "dgv_listagem_vendas_id_funcionario";
                dgv_listagem_vendas.Columns[1].Visible = false;

                dgv_listagem_vendas.Columns[2].HeaderText = "Funcionário:";
                dgv_listagem_vendas.Columns[2].Name = "dgv_listagem_vendas_funcionario";
                dgv_listagem_vendas.Columns[2].Visible = true;

                dgv_listagem_vendas.Columns[3].HeaderText = "ID_cliente:";
                dgv_listagem_vendas.Columns[3].Name = "dgv_listagem_vendas_id_cliente";
                dgv_listagem_vendas.Columns[3].Visible = false;

                dgv_listagem_vendas.Columns[4].HeaderText = "Cliente:";
                dgv_listagem_vendas.Columns[4].Name = "dgv_listagem_vendas_cliente";
                dgv_listagem_vendas.Columns[4].Visible = true;

                dgv_listagem_vendas.Columns[5].HeaderText = "Delivery:";
                dgv_listagem_vendas.Columns[5].Name = "dgv_listagem_vendas_delivery";
                dgv_listagem_vendas.Columns[5].Visible = true;

                dgv_listagem_vendas.Columns[6].HeaderText = "Valor Total:";
                dgv_listagem_vendas.Columns[6].Name = "dgv_listagem_vendas_valor_total";
                dgv_listagem_vendas.Columns[6].Visible = true;

                dgv_listagem_vendas.Columns[7].HeaderText = "Observações:";
                dgv_listagem_vendas.Columns[7].Name = "dgv_listagem_vendas_observacoes";
                dgv_listagem_vendas.Columns[7].Visible = true;

                dgv_listagem_vendas.Columns[8].HeaderText = "Data de Efetuação:";
                dgv_listagem_vendas.Columns[8].Name = "dgv_listagem_vendas_data_efetuacao";
                dgv_listagem_vendas.Columns[8].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Items_DataGridView_Configuration()
        {

            try
            {

                // Configurações iniciais.

                dgv_listagem_itens_venda.Font = new Font(new FontFamily("Arial"), 12f);

                dgv_listagem_itens_venda.ForeColor = Color.Black;

                dgv_listagem_itens_venda.Columns.Clear();

                dgv_listagem_itens_venda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dgv_listagem_produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;

                dgv_listagem_itens_venda.ReadOnly = true;

                // Permissões do usuário.

                dgv_listagem_itens_venda.AllowUserToAddRows = false;

                dgv_listagem_itens_venda.AllowUserToDeleteRows = false;

                dgv_listagem_itens_venda.AllowUserToOrderColumns = true;

                dgv_listagem_itens_venda.AllowUserToResizeRows = true;

                // Colunas.

                dgv_listagem_itens_venda.Columns.Insert(0, new DataGridViewTextBoxColumn());

                dgv_listagem_itens_venda.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_listagem_itens_venda.Columns.Insert(2, new DataGridViewTextBoxColumn());

                dgv_listagem_itens_venda.Columns.Insert(3, new DataGridViewTextBoxColumn());

                dgv_listagem_itens_venda.Columns.Insert(4, new DataGridViewTextBoxColumn());

                dgv_listagem_itens_venda.Columns.Insert(5, new DataGridViewTextBoxColumn());

                dgv_listagem_itens_venda.Columns.Insert(6, new DataGridViewTextBoxColumn());

                dgv_listagem_itens_venda.Columns.Insert(7, new DataGridViewTextBoxColumn());

                // Dados das colunas.

                dgv_listagem_itens_venda.Columns[0].HeaderText = "ID_venda:";
                dgv_listagem_itens_venda.Columns[0].Name = "dgv_listagem_itens_venda_id_venda";
                dgv_listagem_itens_venda.Columns[0].Visible = false;

                dgv_listagem_itens_venda.Columns[1].HeaderText = "ID_produto:";
                dgv_listagem_itens_venda.Columns[1].Name = "dgv_listagem_itens_venda_id_produto";
                dgv_listagem_itens_venda.Columns[1].Visible = false;

                dgv_listagem_itens_venda.Columns[2].HeaderText = "Produto:";
                dgv_listagem_itens_venda.Columns[2].Name = "dgv_listagem_itens_venda_nome";
                dgv_listagem_itens_venda.Columns[2].Visible = true;

                dgv_listagem_itens_venda.Columns[3].HeaderText = "Tamanho";
                dgv_listagem_itens_venda.Columns[3].Name = "dgv_listagem_itens_venda_tamanho";
                dgv_listagem_itens_venda.Columns[3].Visible = true;

                dgv_listagem_itens_venda.Columns[4].HeaderText = "Categoria:";
                dgv_listagem_itens_venda.Columns[4].Name = "dgv_listagem_itens_venda_categoria";
                dgv_listagem_itens_venda.Columns[4].Visible = true;

                dgv_listagem_itens_venda.Columns[5].HeaderText = "Quantidade:";
                dgv_listagem_itens_venda.Columns[5].Name = "dgv_listagem_itens_venda_quantidade";
                dgv_listagem_itens_venda.Columns[5].Visible = true;

                dgv_listagem_itens_venda.Columns[6].HeaderText = "Preço:";
                dgv_listagem_itens_venda.Columns[6].Name = "dgv_listagem_itens_venda_preco";
                dgv_listagem_itens_venda.Columns[6].Visible = true;

                dgv_listagem_itens_venda.Columns[7].HeaderText = "Valor:";
                dgv_listagem_itens_venda.Columns[7].Name = "dgv_listagem_itens_venda_valor";
                dgv_listagem_itens_venda.Columns[7].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
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

        private void btn_reativar_Click(object sender, EventArgs e)
        {

            try
            {

                

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {

            try
            {



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {

            try
            {



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}