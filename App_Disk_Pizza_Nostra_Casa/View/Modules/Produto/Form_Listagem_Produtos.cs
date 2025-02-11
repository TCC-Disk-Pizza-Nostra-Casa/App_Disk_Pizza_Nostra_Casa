﻿using System;
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

        private List<Model.Fornecedor>? fornecedores_ativos = null;

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

                cbbox_condicao_produto.SelectedIndex = 1;

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

                if (String.IsNullOrWhiteSpace(txt_pesquisar_produto.Text))
                {

                    throw new Exception("Preencha o campo de pesquisa para prosseguir.");

                }

                else
                {

                    string texto = txt_pesquisar_produto.Text;

                    txt_pesquisar_produto.Clear();

                    List<Model.Produto> lista_produtos_encontrados = await Model.Produto.Search(texto);

                    if (lista_produtos_encontrados.Count > 0)
                    {

                        ValuesAssociation(lista_produtos_encontrados, cbbox_condicao_produto.SelectedIndex);

                        if (dgv_listagem_produtos.RowCount > 0)
                        {

                            btn_resetar.Enabled = true;

                        }

                        else
                        {

                            DataGridView_Fill();

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

                DataGridView_Fill();

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

                //dgv_listagem_produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;

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

                dgv_listagem_produtos.Columns.Insert(7, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(8, new DataGridViewTextBoxColumn());

                dgv_listagem_produtos.Columns.Insert(9, new DataGridViewTextBoxColumn());

                // Dados das colunas.

                dgv_listagem_produtos.Columns[0].HeaderText = "ID:";
                dgv_listagem_produtos.Columns[0].Name = "dgv_listagem_produtos_id";
                dgv_listagem_produtos.Columns[0].Visible = false;

                dgv_listagem_produtos.Columns[1].HeaderText = "Nome:";
                dgv_listagem_produtos.Columns[1].Name = "dgv_listagem_produtos_nome";
                dgv_listagem_produtos.Columns[1].Visible = true;

                dgv_listagem_produtos.Columns[2].HeaderText = "Preço:";
                dgv_listagem_produtos.Columns[2].Name = "dgv_listagem_produtos_preco";
                dgv_listagem_produtos.Columns[2].Visible = true;

                dgv_listagem_produtos.Columns[3].HeaderText = "Tamanho:";
                dgv_listagem_produtos.Columns[3].Name = "dgv_listagem_produtos_tamanho";
                dgv_listagem_produtos.Columns[3].Visible = true;

                dgv_listagem_produtos.Columns[4].HeaderText = "Categoria:";
                dgv_listagem_produtos.Columns[4].Name = "dgv_listagem_produtos_categoria";
                dgv_listagem_produtos.Columns[4].Visible = true;

                dgv_listagem_produtos.Columns[5].HeaderText = "ID_fornecedor:";
                dgv_listagem_produtos.Columns[5].Name = "dgv_listagem_produtos_id_fornecedor";
                dgv_listagem_produtos.Columns[5].Visible = false;

                dgv_listagem_produtos.Columns[6].HeaderText = "Fornecedor:";
                dgv_listagem_produtos.Columns[6].Name = "dgv_listagem_produtos_fornecedor";
                dgv_listagem_produtos.Columns[6].Visible = true;

                dgv_listagem_produtos.Columns[7].HeaderText = "Observações:";
                dgv_listagem_produtos.Columns[7].Name = "dgv_listagem_produtos_observacoes";
                dgv_listagem_produtos.Columns[7].Visible = true;

                dgv_listagem_produtos.Columns[8].HeaderText = "Última modificação:";
                dgv_listagem_produtos.Columns[8].Name = "dgv_listagem_produtos_data_modificacao";
                dgv_listagem_produtos.Columns[8].Visible = true;

                dgv_listagem_produtos.Columns[9].HeaderText = "Editar:";
                dgv_listagem_produtos.Columns[9].Name = "dgv_listagem_produtos_editar";
                dgv_listagem_produtos.Columns[9].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void ValuesAssociation(List<Model.Produto> lista, int condicao)
        {

            try
            {

                dgv_listagem_produtos.Rows.Clear();

                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].ativo == condicao)
                    {

                        int id = lista[i].id;

                        string nome = lista[i].nome;

                        string preco = lista[i].preco.ToString("C2");

                        string tamanho = lista[i].tamanho;

                        string categoria = lista[i].categoria;

                        int id_fornecedor = lista[i].fk_fornecedor;

                        string fornecedor = (ReturnProviderObject(id_fornecedor) != null) ? ReturnProviderObject(id_fornecedor).nome : "Não encontrado(a).";

                        string? observacoes = lista[i].observacoes;

                        string data_modificacao = DateTime.Parse(lista[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                        dgv_listagem_produtos.Rows.Add(id, nome, preco, tamanho, categoria, id_fornecedor, fornecedor, observacoes, data_modificacao, "Clique aqui.");

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void DataGridView_Fill()
        {

            try
            {

                btn_resetar.Enabled = false;

                btn_reativar.Enabled = false;

                btn_desativar.Enabled = false;

                Global.produtos_cadastrados = await Model.Produto.GetList();

                if (Global.produtos_cadastrados.Count > 0)
                {

                    ValuesAssociation(Global.produtos_cadastrados, cbbox_condicao_produto.SelectedIndex);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgv_listagem_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgv_listagem_produtos.RowCount > 0 && dgv_listagem_produtos.CurrentCell.ColumnIndex == 9)
                {

                    if (!Global.administrador)
                    {

                        throw new Exception("O usuário atual não tem a permissão necessária para executar essa ação.");

                    }

                    else
                    {

                        if (MessageBox.Show("Deseja editar os dados do produto selecionado?", "Atenção",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            Modules.Produto.form_cadastro_produtos form_produto = new form_cadastro_produtos();

                            Model.Produto? produto_selecionado = null;

                            for (int i = 0; i < Global.produtos_cadastrados.Count; i++)
                            {

                                if (Global.produtos_cadastrados[i].id == Convert.ToInt32(dgv_listagem_produtos.CurrentRow.Cells[0].Value))
                                {

                                    produto_selecionado = Global.produtos_cadastrados[i];

                                    break;

                                }

                            }

                            form_produto.produto_selecionado = produto_selecionado;

                            if (Global.formulario_global != null)
                            {

                                Global.formulario_global.External_Form_Association(form_produto);

                            }

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

                if (dgv_listagem_produtos.RowCount > 0)
                {

                    if (!Global.administrador)
                    {

                        throw new Exception("O usuário atual não tem a permissão necessária para executar essa ação.");

                    }

                    else
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

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void Product_Manipulation()
        {

            try
            {

                if (MessageBox.Show("Realmente deseja modificar a ativação desse produto?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id_produto = Convert.ToInt32(dgv_listagem_produtos.CurrentRow.Cells[0].Value);

                    switch (cbbox_condicao_produto.SelectedIndex)
                    {

                        case 0:

                            if (Convert.ToBoolean(await Model.Produto.Enable(id_produto)))
                            {

                                DataGridView_Fill();

                            }

                            break;

                        case 1:

                            if (Convert.ToBoolean(await Model.Produto.Disable(id_produto)))
                            {

                                DataGridView_Fill();

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

                Product_Manipulation();

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

                Product_Manipulation();

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

                    DataGridView_Fill();

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