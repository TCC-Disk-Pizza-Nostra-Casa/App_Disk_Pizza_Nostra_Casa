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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Produto
{

    public partial class form_listagem_produtos : Form
    {

        public form_listagem_produtos()
        {

            InitializeComponent();

        }

        private async void form_listagem_produtos_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_condicao_produto.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_condicao_produto.DataSource = new string[] { "Não ativos", "Ativos" };

                DataGridView_Configuration();

                if (dgv_listagem_produtos.Rows.Count == 0)
                {

                    dgv_listagem_produtos.Rows.Clear();

                    cbbox_condicao_produto.SelectedIndex = 1;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_pesquisar_produto_Click(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrEmpty(txt_pesquisar_produto.Text))
                {

                    throw new Exception("Preencha o campo de pesquisa para prosseguir.");

                }

                else
                {

                    string texto = txt_pesquisar_produto.Text;

                    txt_pesquisar_produto.Clear();

                    List<Model.Produto> lista_produtos_encontrados = await Data_Service_Produto.SearchAsyncProduto(texto);

                    if (lista_produtos_encontrados.Count > 0)
                    {

                        dgv_listagem_produtos.Rows.Clear();

                        int indice_linha = 0;

                        for (int i = 0; i < lista_produtos_encontrados.Count; i++)
                        {

                            if (lista_produtos_encontrados[i].ativo == cbbox_condicao_produto.SelectedIndex)
                            {

                                indice_linha++;

                                int id = lista_produtos_encontrados[i].id;

                                string nome = lista_produtos_encontrados[i].nome;

                                string estoque = lista_produtos_encontrados[i].estoque.ToString();

                                string preco = double.Parse(lista_produtos_encontrados[i].preco).ToString("C2");

                                string data_modificacao = DateTime.Parse(lista_produtos_encontrados[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                                string? observacoes = lista_produtos_encontrados[i].observacoes;

                                dgv_listagem_produtos.Rows.Add(id, indice_linha, nome, estoque, preco, data_modificacao, observacoes);

                            }

                        }

                        if (dgv_listagem_produtos.RowCount > 0)
                        {

                            btn_resetar.Enabled = true;

                        }

                        else
                        {

                            DataGridView_Fill(cbbox_condicao_produto.SelectedIndex);

                            throw new Exception("Nenhum produto encontrado.");

                        }

                    }

                    else
                    {

                        throw new Exception("Nenhum produto encontrado.");

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbbox_condicao_produto_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                DataGridView_Fill(cbbox_condicao_produto.SelectedIndex);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void DataGridView_Configuration()
        {

            try
            {

                // Configurações iniciais.

                dgv_listagem_produtos.Font = new Font(new FontFamily("Arial"), 12f);

                dgv_listagem_produtos.ForeColor = Color.Black;

                dgv_listagem_produtos.Columns.Clear();

                dgv_listagem_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_listagem_produtos.ReadOnly = true;

                // Permissões do usuário.

                dgv_listagem_produtos.AllowUserToAddRows = false;

                dgv_listagem_produtos.AllowUserToDeleteRows = false;

                dgv_listagem_produtos.AllowUserToOrderColumns = true;

                dgv_listagem_produtos.AllowUserToResizeRows = true;

                // Colunas.

                dgv_listagem_produtos.Columns.Insert(0, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(2, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(3, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(4, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(5, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(6, new DataGridViewTextBoxColumn());

                // Dados das colunas.

                dgv_listagem_produtos.Columns[0].HeaderText = "ID:";
                dgv_listagem_produtos.Columns[0].Name = "dgv_listagem_produtos_id";
                dgv_listagem_produtos.Columns[0].Visible = false;

                dgv_listagem_produtos.Columns[1].HeaderText = "Índice:";
                dgv_listagem_produtos.Columns[1].Name = "dgv_listagem_produtos_indice_linha";
                dgv_listagem_produtos.Columns[1].Visible = true;

                dgv_listagem_produtos.Columns[2].HeaderText = "Nome do produto:";
                dgv_listagem_produtos.Columns[2].Name = "dgv_listagem_produtos_nome";
                dgv_listagem_produtos.Columns[2].Visible = true;

                dgv_listagem_produtos.Columns[3].HeaderText = "Estoque:";
                dgv_listagem_produtos.Columns[3].Name = "dgv_listagem_produtos_estoque";
                dgv_listagem_produtos.Columns[3].Visible = true;

                dgv_listagem_produtos.Columns[4].HeaderText = "Preço";
                dgv_listagem_produtos.Columns[4].Name = "dgv_listagem_produtos_preco";
                dgv_listagem_produtos.Columns[4].Visible = true;

                dgv_listagem_produtos.Columns[5].HeaderText = "Última modificação:";
                dgv_listagem_produtos.Columns[5].Name = "dgv_listagem_produtos_data_modificacao";
                dgv_listagem_produtos.Columns[5].Visible = true;

                dgv_listagem_produtos.Columns[6].HeaderText = "Observações:";
                dgv_listagem_produtos.Columns[6].Name = "dgv_listagem_produtos_observacoes";
                dgv_listagem_produtos.Columns[6].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void DataGridView_Fill(int condicao)
        {

            try
            {

                dgv_listagem_produtos.Rows.Clear();

                btn_resetar.Enabled = false;

                btn_reativar.Enabled = false;

                btn_desativar.Enabled = false;

                List<Model.Produto> lista_produtos = await Model.Produto.GetList();

                if (lista_produtos.Count > 0)
                {

                    int indice_linha = 0;

                    for (int i = 0; i < lista_produtos.Count; i++)
                    {

                        if (lista_produtos[i].ativo == condicao)
                        {

                            indice_linha++;

                            int id = lista_produtos[i].id;

                            string nome = lista_produtos[i].nome;

                            string estoque = lista_produtos[i].estoque.ToString();

                            string preco = double.Parse(lista_produtos[i].preco).ToString("C2");

                            string data_modificacao = DateTime.Parse(lista_produtos[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                            string? observacoes = lista_produtos[i].observacoes;

                            dgv_listagem_produtos.Rows.Add(id, indice_linha, nome, estoque, preco, data_modificacao, observacoes);

                        }

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgv_listagem_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                switch (cbbox_condicao_produto.SelectedIndex)
                {

                    case 0:

                        btn_reativar.Enabled = true;

                        break;

                    case 1:

                        btn_desativar.Enabled = true;

                        break;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void User_Manipulation()
        {

            try
            {

                if (MessageBox.Show("Realmente deseja modificar a ativação desse produto?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bool exito;

                    switch (cbbox_condicao_produto.SelectedIndex)
                    {

                        case 0:

                            if (Convert.ToBoolean(await Model.Produto.Enable(Convert.ToInt32(dgv_listagem_produtos.CurrentRow.Cells[0].Value))))
                            {

                                DataGridView_Fill(cbbox_condicao_produto.SelectedIndex);

                            }

                            break;

                        case 1:

                            if (Convert.ToBoolean(await Model.Produto.Disable(Convert.ToInt32(dgv_listagem_produtos.CurrentRow.Cells[0].Value))))
                            {

                                DataGridView_Fill(cbbox_condicao_produto.SelectedIndex);

                            }

                            break;

                    }

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

                User_Manipulation();

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

                User_Manipulation();

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

                if (MessageBox.Show("Realmente deseja resetar a tabela de produtos?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DataGridView_Fill(cbbox_condicao_produto.SelectedIndex);

                }

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

    }

}