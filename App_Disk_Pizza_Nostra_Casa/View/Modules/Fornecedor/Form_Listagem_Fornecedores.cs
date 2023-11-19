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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{

    public partial class form_listagem_fornecedores : Form
    {

        public form_listagem_fornecedores()
        {

            InitializeComponent();

        }

        private void Form_Listagem_Fornecedor_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_condicao_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_condicao_fornecedor.DataSource = new string[] { "Não Ativos", "Ativos" };

                DataGridView_Configuration();

                cbbox_condicao_fornecedor.SelectedIndex = 1;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_pesquisar_fornecedor_Click(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrWhiteSpace(txt_pesquisar_fornecedor.Text))
                {

                    throw new Exception("Preencha o campo de pesquisa para prosseguir.");

                }

                else
                {

                    string texto = txt_pesquisar_fornecedor.Text;

                    txt_pesquisar_fornecedor.Clear();

                    List<Model.Fornecedor> lista_fornecedores_encontrados = await Model.Fornecedor.Search(texto);

                    if (lista_fornecedores_encontrados.Count > 0)
                    {

                        dgv_listagem_fornecedores.Rows.Clear();

                        ValuesAssociation(lista_fornecedores_encontrados, cbbox_condicao_fornecedor.SelectedIndex);

                        if (dgv_listagem_fornecedores.RowCount > 0)
                        {

                            btn_resetar.Enabled = true;

                        }

                        else
                        {

                            DataGridView_Fill();

                            throw new Exception("Nenhum fornecedor encontrado.");

                        }

                    }

                    else
                    {

                        throw new Exception("Nenhum fornecedor encontrado.");

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbbox_condicao_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
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

                dgv_listagem_fornecedores.Font = new Font(new FontFamily("Arial"), 12f);

                dgv_listagem_fornecedores.ForeColor = Color.Black;

                dgv_listagem_fornecedores.Columns.Clear();

                dgv_listagem_fornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dgv_listagem_fornecedores.SelectionMode = DataGridViewSelectionMode.CellSelect;

                dgv_listagem_fornecedores.ReadOnly = true;

                // Permissões do usuário.

                dgv_listagem_fornecedores.AllowUserToAddRows = false;

                dgv_listagem_fornecedores.AllowUserToDeleteRows = false;

                dgv_listagem_fornecedores.AllowUserToOrderColumns = true;

                dgv_listagem_fornecedores.AllowUserToResizeRows = true;

                // Colunas.

                dgv_listagem_fornecedores.Columns.Insert(0, new DataGridViewTextBoxColumn());

                dgv_listagem_fornecedores.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_listagem_fornecedores.Columns.Insert(2, new DataGridViewTextBoxColumn());

                dgv_listagem_fornecedores.Columns.Insert(3, new DataGridViewTextBoxColumn());

                dgv_listagem_fornecedores.Columns.Insert(4, new DataGridViewTextBoxColumn());

                dgv_listagem_fornecedores.Columns.Insert(5, new DataGridViewTextBoxColumn());

                dgv_listagem_fornecedores.Columns.Insert(6, new DataGridViewTextBoxColumn());

                dgv_listagem_fornecedores.Columns.Insert(7, new DataGridViewTextBoxColumn());

                // Dados das colunas.

                dgv_listagem_fornecedores.Columns[0].HeaderText = "ID:";
                dgv_listagem_fornecedores.Columns[0].Name = "dgv_listagem_fornecedores_id";
                dgv_listagem_fornecedores.Columns[0].Visible = false;

                dgv_listagem_fornecedores.Columns[1].HeaderText = "Nome:";
                dgv_listagem_fornecedores.Columns[1].Name = "dgv_listagem_fornecedores_nome";
                dgv_listagem_fornecedores.Columns[1].Visible = true;

                dgv_listagem_fornecedores.Columns[2].HeaderText = "CNPJ:";
                dgv_listagem_fornecedores.Columns[2].Name = "dgv_listagem_fornecedores_cnpj";
                dgv_listagem_fornecedores.Columns[2].Visible = true;

                dgv_listagem_fornecedores.Columns[3].HeaderText = "E-mail:";
                dgv_listagem_fornecedores.Columns[3].Name = "dgv_listagem_fornecedores_email";
                dgv_listagem_fornecedores.Columns[3].Visible = true;

                dgv_listagem_fornecedores.Columns[4].HeaderText = "Telefone:";
                dgv_listagem_fornecedores.Columns[4].Name = "dgv_listagem_fornecedores_telefone";
                dgv_listagem_fornecedores.Columns[4].Visible = true;

                dgv_listagem_fornecedores.Columns[5].HeaderText = "Observações:";
                dgv_listagem_fornecedores.Columns[5].Name = "dgv_listagem_fornecedores_observacoes";
                dgv_listagem_fornecedores.Columns[5].Visible = true;

                dgv_listagem_fornecedores.Columns[6].HeaderText = "Última modificação:";
                dgv_listagem_fornecedores.Columns[6].Name = "dgv_listagem_fornecedores_data_modificacao";
                dgv_listagem_fornecedores.Columns[6].Visible = true;

                dgv_listagem_fornecedores.Columns[7].HeaderText = "Editar:";
                dgv_listagem_fornecedores.Columns[7].Name = "dgv_listagem_fornecedores_editar";
                dgv_listagem_fornecedores.Columns[7].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ValuesAssociation(List<Model.Fornecedor> lista, int condicao)
        {

            try
            {

                dgv_listagem_fornecedores.Rows.Clear();

                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].ativo == condicao)
                    {

                        int id = lista[i].id;

                        string nome = lista[i].nome;

                        string cnpj = lista[i].cnpj;

                        string? email = lista[i].email;

                        string telefone = lista[i].telefone;

                        string? observacoes = lista[i].observacoes;

                        string data_modificacao = DateTime.Parse(lista[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                        dgv_listagem_fornecedores.Rows.Add(id, nome, cnpj, email, telefone, observacoes, data_modificacao, "Clique aqui.");

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

                Global.fornecedores_cadastrados = await Model.Fornecedor.GetList();

                if (Global.fornecedores_cadastrados.Count > 0)
                {

                    ValuesAssociation(Global.fornecedores_cadastrados, cbbox_condicao_fornecedor.SelectedIndex);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgv_listagem_fornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgv_listagem_fornecedores.RowCount > 0 && dgv_listagem_fornecedores.CurrentCell.ColumnIndex == 7)
                {

                    if (!Global.administrador)
                    {

                        throw new Exception("O usuário atual não tem a permissão necessária para executar essa ação.");

                    }

                    else
                    {

                        if (MessageBox.Show("Deseja editar os dados do fornecedor selecionado?", "Atenção",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            Modules.Fornecedor.form_cadastro_fornecedores form_fornecedor = new form_cadastro_fornecedores();

                            Model.Fornecedor? fornecedor_selecionado = null;

                            for (int i = 0; i < Global.fornecedores_cadastrados.Count; i++)
                            {

                                if (Global.fornecedores_cadastrados[i].id == Convert.ToInt32(dgv_listagem_fornecedores.CurrentRow.Cells[0].Value))
                                {

                                    fornecedor_selecionado = Global.fornecedores_cadastrados[i];

                                    break;

                                }

                            }

                            form_fornecedor.fornecedor_selecionado = fornecedor_selecionado;

                            if (Global.formulario_global != null)
                            {

                                Global.formulario_global.External_Form_Association(form_fornecedor);

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

        private void dgv_listagem_fornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgv_listagem_fornecedores.RowCount > 0)
                {

                    if (!Global.administrador)
                    {

                        throw new Exception("O usuário atual não tem a permissão necessária para executar essa ação.");

                    }

                    else
                    {

                        switch (cbbox_condicao_fornecedor.SelectedIndex)
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

        private async void Provider_Manipulation()
        {

            try
            {

                if (MessageBox.Show("Realmente deseja modificar a ativação desse fornecedor?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id_fornecedor = Convert.ToInt32(dgv_listagem_fornecedores.CurrentRow.Cells[0].Value);

                    switch (cbbox_condicao_fornecedor.SelectedIndex)
                    {

                        case 0:

                            if (Convert.ToBoolean(await Model.Fornecedor.Enable(id_fornecedor)))
                            {

                                DataGridView_Fill();

                            }

                            break;

                        case 1:

                            if (Convert.ToBoolean(await Model.Fornecedor.Disable(id_fornecedor)))
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

                Provider_Manipulation();

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

                Provider_Manipulation();

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

                if (MessageBox.Show("Realmente deseja resetar a tabela de fornecedores?", "Atenção!",
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