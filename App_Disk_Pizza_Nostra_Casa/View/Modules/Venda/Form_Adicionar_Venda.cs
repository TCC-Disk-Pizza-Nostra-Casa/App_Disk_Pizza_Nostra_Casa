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

                cbbox_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_cliente.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_categoria_produto.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_tamanho_produto.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_categoria_produto.DataSource = new string[] { "Pizza comum", "Pizza especial", "Pizza doce", "Bebida", "Doce" };

                cbbox_tamanho_produto.DataSource = new string[] { "Grande", "Broto" };

                cbbox_funcionario.DisplayMember = "nome";

                cbbox_funcionario.ValueMember = "id";

                cbbox_cliente.DisplayMember = "nome";

                cbbox_cliente.ValueMember = "id";

                cbbox_nome_produto.DisplayMember = "nome";

                cbbox_nome_produto.ValueMember = "id";

                ComboBoxes_Fill();

                DataGridView_Configuration();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void ComboBoxes_Fill()
        {

            try
            {

                List<Model.Funcionario> funcionarios_cadastrados = await Model.Funcionario.GetList();

                if (funcionarios_cadastrados.Count > 0)
                {

                    List<Model.Funcionario> funcionarios_ativos = new List<Model.Funcionario>();

                    for (int i = 0; i < funcionarios_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(funcionarios_cadastrados[i].ativo))
                        {

                            funcionarios_ativos.Add(funcionarios_cadastrados[i]);

                        }

                    }

                    cbbox_funcionario.DataSource = funcionarios_ativos;

                }

                List<Model.Cliente> clientes_cadastrados = await Model.Cliente.GetList();

                if (clientes_cadastrados.Count > 0)
                {

                    List<Model.Cliente> clientes_ativos = new List<Model.Cliente>();

                    for (int i = 0; i < clientes_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(clientes_cadastrados[i].ativo))
                        {

                            clientes_ativos.Add(clientes_cadastrados[i]);

                        }

                    }

                    cbbox_cliente.DataSource = clientes_ativos;

                }

                List<Model.Produto> produtos_cadastrados = await Model.Produto.GetList();

                if (produtos_cadastrados.Count > 0)
                {

                    List<Model.Produto> produtos_ativos = new List<Model.Produto>();

                    for (int i = 0; i < produtos_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(produtos_cadastrados[i].ativo))
                        {

                            produtos_ativos.Add(produtos_cadastrados[i]);

                        }

                    }

                    cbbox_nome_produto.DataSource = produtos_ativos;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbbox_categoria_produto_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                if (cbbox_categoria_produto.SelectedIndex == 3 || cbbox_categoria_produto.SelectedIndex == 4)
                {

                    cbbox_tamanho_produto.DataSource = new string[] { "Único" };

                }

                else
                {

                    cbbox_tamanho_produto.DataSource = new string[] { "Grande", "Broto" };

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txt_quantidade_produto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }

            else
            {

                e.Handled = true;

            }

        }

        private void DataGridView_Configuration()
        {

            try
            {

                // Configurações iniciais.

                dgv_carrinho_produtos.Font = new Font(new FontFamily("Arial"), 12f);

                dgv_carrinho_produtos.ForeColor = Color.Black;

                dgv_carrinho_produtos.Columns.Clear();

                dgv_carrinho_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dgv_listagem_produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;

                dgv_carrinho_produtos.ReadOnly = true;

                // Permissões do usuário.

                dgv_carrinho_produtos.AllowUserToAddRows = false;

                dgv_carrinho_produtos.AllowUserToDeleteRows = false;

                dgv_carrinho_produtos.AllowUserToOrderColumns = true;

                dgv_carrinho_produtos.AllowUserToResizeRows = true;

                // Colunas.

                dgv_carrinho_produtos.Columns.Insert(0, new DataGridViewTextBoxColumn());

                dgv_carrinho_produtos.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_carrinho_produtos.Columns.Insert(2, new DataGridViewTextBoxColumn());

                dgv_carrinho_produtos.Columns.Insert(3, new DataGridViewTextBoxColumn());

                dgv_carrinho_produtos.Columns.Insert(4, new DataGridViewTextBoxColumn());

                dgv_carrinho_produtos.Columns.Insert(5, new DataGridViewTextBoxColumn());

                dgv_carrinho_produtos.Columns.Insert(6, new DataGridViewTextBoxColumn());

                // Dados das colunas.

                dgv_carrinho_produtos.Columns[0].HeaderText = "ID_produto:";
                dgv_carrinho_produtos.Columns[0].Name = "dgv_carrinho_produtos_id_produto";
                dgv_carrinho_produtos.Columns[0].Visible = false;

                dgv_carrinho_produtos.Columns[1].HeaderText = "Produto:";
                dgv_carrinho_produtos.Columns[1].Name = "dgv_carrinho_produtos_nome";
                dgv_carrinho_produtos.Columns[1].Visible = true;

                dgv_carrinho_produtos.Columns[2].HeaderText = "Tamanho";
                dgv_carrinho_produtos.Columns[2].Name = "dgv_carrinho_produtos_tamanho";
                dgv_carrinho_produtos.Columns[2].Visible = true;

                dgv_carrinho_produtos.Columns[3].HeaderText = "Categoria:";
                dgv_carrinho_produtos.Columns[3].Name = "dgv_carrinho_produtos_categoria";
                dgv_carrinho_produtos.Columns[3].Visible = true;

                dgv_carrinho_produtos.Columns[4].HeaderText = "Quantidade:";
                dgv_carrinho_produtos.Columns[4].Name = "dgv_carrinho_produtos_quantidade";
                dgv_carrinho_produtos.Columns[4].Visible = true;

                dgv_carrinho_produtos.Columns[5].HeaderText = "Preço:";
                dgv_carrinho_produtos.Columns[5].Name = "dgv_carrinho_produtos_preco";
                dgv_carrinho_produtos.Columns[5].Visible = true;

                dgv_carrinho_produtos.Columns[6].HeaderText = "Valor:";
                dgv_carrinho_produtos.Columns[6].Name = "dgv_carrinho_produtos_valor";
                dgv_carrinho_produtos.Columns[6].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_adicionar_produto_Click(object sender, EventArgs e)
        {

            try
            {



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_remover_produto_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgv_carrinho_produtos.RowCount > 0)
                {



                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_salvar_pedido_Click(object sender, EventArgs e)
        {

            try
            {

                Modules.Venda.form_confirmacao_venda formulario_confirmacao = new Modules.Venda.form_confirmacao_venda();

                formulario_confirmacao.valor_total = 100;

                formulario_confirmacao.Show();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cancelar_pedido_Click(object sender, EventArgs e)
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

    }

}