using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private List<Model.Funcionario>? funcionarios_ativos = null;

        private List<Model.Cliente>? clientes_ativos = null;

        private List<Model.Fornecedor>? fornecedores_ativos = null;

        private List<Model.Produto>? produtos_ativos = null;

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

                dtpck_data_venda.MinDate = new DateTime(1950, 1, 1);

                dtpck_data_venda.MaxDate = DateTime.Now.Date;

                Global.fornecedores_cadastrados = await Model.Fornecedor.GetList();

                if (Global.fornecedores_cadastrados.Count > 0)
                {

                    List<Model.Fornecedor> fornecedores_ativos = new List<Model.Fornecedor>();

                    for (int i = 0; i < Global.fornecedores_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(Global.fornecedores_cadastrados[i].ativo))
                        {

                            fornecedores_ativos.Add(Global.fornecedores_cadastrados[i]);

                        }

                    }

                    this.fornecedores_ativos = fornecedores_ativos;

                }

                ComboBoxes_Fill();

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

                Global.funcionarios_cadastrados = await Model.Funcionario.GetList();

                if (Global.funcionarios_cadastrados.Count > 0)
                {

                    List<Model.Funcionario> funcionarios_ativos = new List<Model.Funcionario>();

                    for (int i = 0; i < Global.funcionarios_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(Global.funcionarios_cadastrados[i].ativo))
                        {

                            funcionarios_ativos.Add(Global.funcionarios_cadastrados[i]);

                        }

                    }

                    this.funcionarios_ativos = funcionarios_ativos;

                    cbbox_funcionario.DataSource = this.funcionarios_ativos;

                }

                Global.clientes_cadastrados = await Model.Cliente.GetList();

                if (Global.clientes_cadastrados.Count > 0)
                {

                    List<Model.Cliente> clientes_ativos = new List<Model.Cliente>();

                    for (int i = 0; i < Global.clientes_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(Global.clientes_cadastrados[i].ativo))
                        {

                            clientes_ativos.Add(Global.clientes_cadastrados[i]);

                        }

                    }

                    this.clientes_ativos = clientes_ativos;

                    cbbox_cliente.DataSource = this.clientes_ativos;

                }

                Global.produtos_cadastrados = await Model.Produto.GetList();

                if (Global.produtos_cadastrados.Count > 0)
                {

                    List<Model.Produto> produtos_ativos = new List<Model.Produto>();

                    for (int i = 0; i < Global.produtos_cadastrados.Count; i++)
                    {

                        if (Convert.ToBoolean(Global.produtos_cadastrados[i].ativo))
                        {

                            produtos_ativos.Add(Global.produtos_cadastrados[i]);

                        }

                    }

                    this.produtos_ativos = produtos_ativos;

                }

                cbbox_condicao_venda.SelectedIndex = 1;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_pesquisar_venda_Click(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrWhiteSpace(cbbox_funcionario.Text) ||
                    String.IsNullOrWhiteSpace(cbbox_cliente.Text) ||
                    String.IsNullOrWhiteSpace(dtpck_data_venda.Text))
                {

                    throw new Exception("Preencha os campos de pesquisa para prosseguir.");

                }

                else
                {

                    string[] dados_pesquisa = { cbbox_funcionario.SelectedValue.ToString(),
                                                cbbox_cliente.SelectedValue.ToString(),
                                                dtpck_data_venda.Value.ToString("yyyy-MM-dd") };

                    cbbox_funcionario.SelectedIndex = 0;

                    cbbox_cliente.SelectedIndex = 0;

                    dtpck_data_venda.Value = DateTime.Now.Date;

                    List<Model.Venda> lista_vendas_encontradas = await Model.Venda.Search(dados_pesquisa);

                    if (lista_vendas_encontradas.Count > 0)
                    {

                        dgv_listagem_vendas.Rows.Clear();

                        dgv_listagem_itens_venda.Rows.Clear();

                        SaleValuesAssociation(lista_vendas_encontradas, cbbox_condicao_venda.SelectedIndex);

                        if (dgv_listagem_vendas.RowCount > 0)
                        {

                            btn_resetar.Enabled = true;

                        }

                        else
                        {

                            Sales_DataGridView_Fill();

                            throw new Exception("Nenhuma venda encontrada que corresponda a esses parâmetros.");

                        }

                    }

                    else
                    {

                        throw new Exception("Nenhuma venda encontrada que corresponda a esses parâmetros.");

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbbox_condicao_venda_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                Sales_DataGridView_Fill();

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

                dgv_listagem_vendas.Columns[2].HeaderText = "Funcionário(a):";
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

                dgv_listagem_itens_venda.Columns.Insert(8, new DataGridViewTextBoxColumn());

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

                dgv_listagem_itens_venda.Columns[5].HeaderText = "Fornecedor:";
                dgv_listagem_itens_venda.Columns[5].Name = "dgv_listagem_itens_venda_fornecedor";
                dgv_listagem_itens_venda.Columns[5].Visible = true;

                dgv_listagem_itens_venda.Columns[6].HeaderText = "Quantidade:";
                dgv_listagem_itens_venda.Columns[6].Name = "dgv_listagem_itens_venda_quantidade";
                dgv_listagem_itens_venda.Columns[6].Visible = true;

                dgv_listagem_itens_venda.Columns[7].HeaderText = "Preço:";
                dgv_listagem_itens_venda.Columns[7].Name = "dgv_listagem_itens_venda_preco";
                dgv_listagem_itens_venda.Columns[7].Visible = true;

                dgv_listagem_itens_venda.Columns[8].HeaderText = "Valor:";
                dgv_listagem_itens_venda.Columns[8].Name = "dgv_listagem_itens_venda_valor";
                dgv_listagem_itens_venda.Columns[8].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private Model.Funcionario? ReturnEmployeeObject(int id)
        {

            try
            {

                if (this.funcionarios_ativos != null)
                {

                    Model.Funcionario? retorno = null;

                    for (int i = 0; i < this.funcionarios_ativos.Count; i++)
                    {

                        if (this.funcionarios_ativos[i].id == id)
                        {

                            retorno = this.funcionarios_ativos[i];

                        }

                    }

                    return retorno;

                }

                else
                {

                    return null;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

        private Model.Cliente? ReturnClientObject(int id)
        {

            try
            {

                if (this.clientes_ativos != null)
                {

                    Model.Cliente? retorno = null;

                    for (int i = 0; i < this.clientes_ativos.Count; i++)
                    {

                        if (this.clientes_ativos[i].id == id)
                        {

                            retorno = this.clientes_ativos[i];

                        }

                    }

                    return retorno;

                }

                else
                {

                    return null;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

        private Model.Fornecedor? ReturnProviderObject(int id)
        {

            try
            {

                if (this.fornecedores_ativos != null)
                {

                    Model.Fornecedor? retorno = null;

                    for (int i = 0; i < this.fornecedores_ativos.Count; i++)
                    {

                        if (this.fornecedores_ativos[i].id == id)
                        {

                            retorno = this.fornecedores_ativos[i];

                        }

                    }

                    return retorno;

                }

                else
                {

                    return null;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

        private Model.Produto? ReturnProductObject(int id)
        {

            try
            {

                if (this.produtos_ativos != null)
                {

                    Model.Produto? retorno = null;

                    for (int i = 0; i < this.produtos_ativos.Count; i++)
                    {

                        if (this.produtos_ativos[i].id == id)
                        {

                            retorno = this.produtos_ativos[i];

                        }

                    }

                    return retorno;

                }

                else
                {

                    return null;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

        private void SaleValuesAssociation(List<Model.Venda> lista, int condicao)
        {

            try
            {

                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].ativo == condicao)
                    {

                        int id = lista[i].id;

                        int id_funcionario = lista[i].fk_funcionario;

                        string funcionario = (ReturnEmployeeObject(id_funcionario) != null) ? ReturnEmployeeObject(id_funcionario).nome : "Não encontrado(a).";

                        int id_cliente = lista[i].fk_cliente;

                        string cliente = (ReturnClientObject(id_cliente) != null) ? ReturnClientObject(id_cliente).nome : "Não encontrado(a).";

                        string delivery = (lista[i].delivery == 1) ? "Sim" : "Não";

                        string valor_total = lista[i].valor_total.ToString("C2");

                        string? observacoes = lista[i].observacoes;

                        string data_efetuacao = DateTime.Parse(lista[i].data_venda).ToString("dd/MM/yyyy HH:mm:ss");

                        dgv_listagem_vendas.Rows.Add(id, id_funcionario, funcionario, id_cliente, cliente, delivery, valor_total, observacoes, data_efetuacao);

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ItemsValuesAssociation(List<Model.Venda_Produto_Assoc> lista, int condicao)
        {

            try
            {

                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].ativo == condicao)
                    {

                        int id_venda = lista[i].fk_venda;

                        int id_produto = lista[i].fk_produto;

                        string produto = (ReturnProductObject(id_produto) != null) ? ReturnProductObject(id_produto).nome : "Não encontrado(a).";

                        string tamanho = (ReturnProductObject(id_produto) != null) ? ReturnProductObject(id_produto).tamanho : "Não encontrado(a).";

                        string categoria = (ReturnProductObject(id_produto) != null) ? ReturnProductObject(id_produto).categoria : "Não encontrado(a).";

                        string fornecedor = (ReturnProductObject(id_produto) != null) ? ReturnProviderObject(ReturnProductObject(id_produto).fk_fornecedor).nome : "Não encontrado(a).";

                        int quantidade_produto = lista[i].quantidade_produto;

                        string preco_produto = ReturnProductObject(id_produto).preco.ToString("C2");

                        string valor_total_item_venda = lista[i].valor_total_item_venda.ToString("C2");

                        dgv_listagem_itens_venda.Rows.Add(id_venda, id_produto, produto, tamanho, categoria, fornecedor, quantidade_produto, preco_produto, valor_total_item_venda);

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void Sales_DataGridView_Fill()
        {

            try
            {

                btn_resetar.Enabled = false;

                btn_reativar.Enabled = false;

                btn_desativar.Enabled = false;

                dgv_listagem_itens_venda.Rows.Clear();

                Global.vendas_cadastradas = await Model.Venda.GetList();

                if (Global.vendas_cadastradas.Count > 0)
                {

                    dgv_listagem_vendas.Rows.Clear();

                    SaleValuesAssociation(Global.vendas_cadastradas, cbbox_condicao_venda.SelectedIndex);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void Items_DataGridView_Fill(int id_venda)
        {

            try
            {

                List<Model.Venda_Produto_Assoc>? itens_venda = await Model.Venda_Produto_Assoc.Search(id_venda);

                if (itens_venda.Count > 0)
                {

                    dgv_listagem_itens_venda.Rows.Clear();

                    ItemsValuesAssociation(itens_venda, cbbox_condicao_venda.SelectedIndex);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgv_listagem_vendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgv_listagem_vendas.RowCount > 0)
                {

                    Items_DataGridView_Fill(Convert.ToInt32(dgv_listagem_vendas.CurrentRow.Cells[0].Value));

                    switch (cbbox_condicao_venda.SelectedIndex)
                    {

                        case 0:

                            btn_reativar.Enabled = true;

                            break;

                        case 1:

                            btn_desativar.Enabled = true;

                            break;

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void Sale_Manipulation()
        {

            try
            {

                if (MessageBox.Show("Realmente deseja modificar a ativação dessa venda?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id_venda = Convert.ToInt32(dgv_listagem_vendas.CurrentRow.Cells[0].Value);

                    switch (cbbox_condicao_venda.SelectedIndex)
                    {

                        case 0:

                            if (Convert.ToBoolean(await Model.Venda.Enable(id_venda)))
                            {

                                await Model.Venda_Produto_Assoc.Enable(id_venda);

                                Sales_DataGridView_Fill();

                            }

                            break;

                        case 1:

                            if (Convert.ToBoolean(await Model.Venda.Disable(id_venda)))
                            {

                                await Model.Venda_Produto_Assoc.Disable(id_venda);

                                Sales_DataGridView_Fill();

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

                Sale_Manipulation();

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

                Sale_Manipulation();

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

                if (MessageBox.Show("Realmente deseja resetar a tabela de vendas?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Sales_DataGridView_Fill();

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