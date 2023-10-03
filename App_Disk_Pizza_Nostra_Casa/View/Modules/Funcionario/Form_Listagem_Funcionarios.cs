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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Funcionario
{

    public partial class form_listagem_funcionarios : Form
    {

        public form_listagem_funcionarios()
        {

            InitializeComponent();

        }

        private async void form_listagem_funcionarios_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_condicao_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_condicao_funcionario.DataSource = new string[] { "Não ativos", "Ativos" };

                DataGridView_Configuration();

                if (dgv_listagem_funcionarios.Rows.Count == 0)
                {

                    dgv_listagem_funcionarios.Rows.Clear();

                    cbbox_condicao_funcionario.SelectedIndex = 1;

                }

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

                dgv_listagem_funcionarios.Font = new Font(new FontFamily("Arial"), 10f);

                dgv_listagem_funcionarios.ForeColor = Color.Black;

                dgv_listagem_funcionarios.Columns.Clear();

                dgv_listagem_funcionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_listagem_funcionarios.ReadOnly = true;

                // Permissões do usuário.

                dgv_listagem_funcionarios.AllowUserToAddRows = false;

                dgv_listagem_funcionarios.AllowUserToDeleteRows = false;

                dgv_listagem_funcionarios.AllowUserToOrderColumns = true;

                dgv_listagem_funcionarios.AllowUserToResizeRows = true;

                // Colunas.

                dgv_listagem_funcionarios.Columns.Insert(0, new DataGridViewTextBoxColumn());

                dgv_listagem_funcionarios.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_listagem_funcionarios.Columns.Insert(2, new DataGridViewTextBoxColumn());

                dgv_listagem_funcionarios.Columns.Insert(3, new DataGridViewTextBoxColumn());

                dgv_listagem_funcionarios.Columns.Insert(4, new DataGridViewTextBoxColumn());

                dgv_listagem_funcionarios.Columns.Insert(5, new DataGridViewTextBoxColumn());

                dgv_listagem_funcionarios.Columns.Insert(6, new DataGridViewCheckBoxColumn());

                // Dados das colunas.

                dgv_listagem_funcionarios.Columns[0].HeaderText = "ID:";
                dgv_listagem_funcionarios.Columns[0].Name = "dgv_listagem_funcionarios_id";
                dgv_listagem_funcionarios.Columns[0].Visible = false;

                dgv_listagem_funcionarios.Columns[1].HeaderText = "Índice:";
                dgv_listagem_funcionarios.Columns[1].Name = "dgv_listagem_funcionarios_indice_linha";
                dgv_listagem_funcionarios.Columns[1].Visible = true;

                dgv_listagem_funcionarios.Columns[2].HeaderText = "Nome do funcionário(a):";
                dgv_listagem_funcionarios.Columns[2].Name = "dgv_listagem_funcionarios_nome";
                dgv_listagem_funcionarios.Columns[2].Visible = true;

                dgv_listagem_funcionarios.Columns[3].HeaderText = "CPF:";
                dgv_listagem_funcionarios.Columns[3].Name = "dgv_listagem_funcionarios_cpf";
                dgv_listagem_funcionarios.Columns[3].Visible = true;

                dgv_listagem_funcionarios.Columns[4].HeaderText = "Última modificação:";
                dgv_listagem_funcionarios.Columns[4].Name = "dgv_listagem_funcionarios_data_modificacao";
                dgv_listagem_funcionarios.Columns[4].Visible = true;

                dgv_listagem_funcionarios.Columns[5].HeaderText = "Observações:";
                dgv_listagem_funcionarios.Columns[5].Name = "dgv_listagem_funcionarios_observacoes";
                dgv_listagem_funcionarios.Columns[5].Visible = true;

                dgv_listagem_funcionarios.Columns[6].HeaderText = "Administrador:";
                dgv_listagem_funcionarios.Columns[6].Name = "dgv_listagem_funcionarios_administrador";
                dgv_listagem_funcionarios.Columns[6].Visible = true;

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

                dgv_listagem_funcionarios.Rows.Clear();

                btn_limpar.Enabled = false;

                btn_reativar.Enabled = false;

                btn_desativar.Enabled = false;

                List<Model.Funcionario> lista_funcionarios = await Model.Funcionario.GetList();

                if (lista_funcionarios.Count > 0)
                {

                    int indice_linha = 0;

                    for (int i = 0; i < lista_funcionarios.Count; i++)
                    {

                        if (lista_funcionarios[i].ativo == condicao)
                        {

                            indice_linha++;

                            int id = lista_funcionarios[i].id;

                            string nome = lista_funcionarios[i].nome;

                            string cpf = lista_funcionarios[i].cpf;

                            string data_modificacao = DateTime.Parse(lista_funcionarios[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                            string observacoes = lista_funcionarios[i].observacoes;

                            bool administrador = Convert.ToBoolean(lista_funcionarios[i].administrador);

                            dgv_listagem_funcionarios.Rows.Add(id, indice_linha, nome, cpf, data_modificacao, observacoes, administrador);

                        }

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_pesquisar_funcionario_Click(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrEmpty(txt_pesquisar_funcionario.Text))
                {

                    throw new Exception("Preencha o campo de pesquisa para prosseguir.");

                }

                else
                {

                    string texto = txt_pesquisar_funcionario.Text;

                    txt_pesquisar_funcionario.Clear();

                    List<Model.Funcionario> lista_funcionarios_encontrado = await Model.Funcionario.Search(texto);

                    if (lista_funcionarios_encontrado.Count > 0)
                    {

                        dgv_listagem_funcionarios.Rows.Clear();

                        int indice_linha = 0;

                        for (int i = 0; i < lista_funcionarios_encontrado.Count; i++)
                        {

                            if (lista_funcionarios_encontrado[i].ativo == cbbox_condicao_funcionario.SelectedIndex)
                            {

                                indice_linha++;

                                int id = lista_funcionarios_encontrado[i].id;

                                string nome = lista_funcionarios_encontrado[i].nome;

                                string cpf = lista_funcionarios_encontrado[i].cpf;

                                string data_modificacao = DateTime.Parse(lista_funcionarios_encontrado[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                                dgv_listagem_funcionarios.Rows.Add(id, indice_linha, nome, cpf, data_modificacao);

                            }

                        }

                        if (dgv_listagem_funcionarios.RowCount > 0)
                        {

                            btn_limpar.Enabled = true;

                        }

                        else
                        {

                            DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

                            throw new Exception("Nenhum usuário encontrado.");

                        }

                    }

                    else
                    {

                        throw new Exception("Nenhum usuário encontrado.");

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbbox_condicao_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgv_listagem_funcionarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                switch (cbbox_condicao_funcionario.SelectedIndex)
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

        private async void dgv_listagem_funcionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if(dgv_listagem_funcionarios.CurrentCell.ColumnIndex == 6)
                {

                    if(MessageBox.Show("Realmente deseja alterar a permissão de administrador desse usuário?",
                       "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        bool exito;

                        if(Convert.ToBoolean(dgv_listagem_funcionarios.CurrentCell.Value) == true)
                        {

                            dgv_listagem_funcionarios.CurrentCell.Value = false;

                            exito = await Model.Funcionario.Demote(Convert.ToInt32(dgv_listagem_funcionarios.CurrentRow.Cells[0].Value));

                            if (exito)
                            {

                                MessageBox.Show("Usuário rebaixado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

                            }

                            else
                            {

                                throw new Exception("Não foi possível reativar o funcionário selecionado! Tente novamente mais tarde.");

                            }

                        }

                        else
                        {

                            dgv_listagem_funcionarios.CurrentCell.Value = true;

                            exito = await Model.Funcionario.Promote(Convert.ToInt32(dgv_listagem_funcionarios.CurrentRow.Cells[0].Value));

                            if (exito)
                            {

                                MessageBox.Show("Usuário promovido com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

                            }

                            else
                            {

                                throw new Exception("Não foi possível reativar o funcionário selecionado! Tente novamente mais tarde.");

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

        private async void User_Manipulation()
        {

            try
            {

                bool exito;

                switch (cbbox_condicao_funcionario.SelectedIndex)
                {

                    case 0:

                        exito = await Model.Funcionario.Enable(Convert.ToInt32(dgv_listagem_funcionarios.CurrentRow.Cells[0].Value));

                        if (exito)
                        {

                            MessageBox.Show("Usuário reativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

                        }

                        else
                        {

                            throw new Exception("Não foi possível reativar o funcionário selecionado! Tente novamente mais tarde.");

                        }

                        break;

                    case 1:

                        exito = await Model.Funcionario.Disable(Convert.ToInt32(dgv_listagem_funcionarios.CurrentRow.Cells[0].Value));

                        if (exito)
                        {

                            MessageBox.Show("Usuário desativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

                        }

                        else
                        {

                            throw new Exception("Não foi possível desativar o funcionário selecionado! Tente novamente mais tarde.");

                        }

                        break;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_reativar_Click(object sender, EventArgs e)
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

        private async void btn_desativar_Click(object sender, EventArgs e)
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

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            try
            {

                DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

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