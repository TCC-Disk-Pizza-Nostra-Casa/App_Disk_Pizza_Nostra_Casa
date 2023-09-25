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

        string[] condicoes_funcionario = { "Não Ativos", "Ativos" };

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

                cbbox_condicao_funcionario.DataSource = this.condicoes_funcionario;

                cbbox_condicao_funcionario.SelectedIndex = 1;

                btn_reativar.Enabled = false;

                DataGridView_Configuration();

                DataGridView_Fill(cbbox_condicao_funcionario.SelectedIndex);

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

                            string data_modificacao = lista_funcionarios[i].data_modificacao.ToString();

                            dgv_listagem_funcionarios.Rows.Add(id, indice_linha, nome, cpf, data_modificacao);

                        }

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_pesquisar_funcionario_Click(object sender, EventArgs e)
        {

            try
            {



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