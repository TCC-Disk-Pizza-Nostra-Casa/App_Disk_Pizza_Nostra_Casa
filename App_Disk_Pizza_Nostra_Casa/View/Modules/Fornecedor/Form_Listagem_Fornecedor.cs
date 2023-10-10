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
    public partial class Form_Listagem_Fornecedor : Form
    {
        public Form_Listagem_Fornecedor()
        {
            InitializeComponent();
        }

        private async void Form_Listagem_Fornecedor_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbx_ativo.DropDownStyle = ComboBoxStyle.DropDownList;

                cbx_ativo.DataSource = new string[] { "Não Ativos", "Ativos" };

                cbx_ativo.SelectedIndex = 1;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void PreencherDGV(int condicao)
        {
            try
            {


                btn_limpar.Enabled = false;
                btn_desativar.Enabled = false;
                btn_reativar.Enabled = false;

                List<Model.Fornecedor> lista_fornecedor = await Data_Service_Fornecedor.GetListAsyncFornecedor();

                if (lista_fornecedor.Count > 0)
                {
                    dgv_listagem_fornecedor.Rows.Clear();

                    for (int i = 0; i < lista_fornecedor.Count; i++)
                    {

                        if (lista_fornecedor[i].ativo == condicao)
                        {
                            int id = lista_fornecedor[i].id;

                            string nome = lista_fornecedor[i].nome;

                            string cnpj = lista_fornecedor[i].cnpj;

                            string telefone = lista_fornecedor[i].telefone;

                            string data_modificacao = DateTime.Parse(lista_fornecedor[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                            string? observacoes = lista_fornecedor[i].observacoes;

                            if (observacoes == "") observacoes = "Nenhuma observação.";

                            string ativo = lista_fornecedor[i].ativo.ToString();

                            dgv_listagem_fornecedor.Rows.Add(id, nome, cnpj, telefone, data_modificacao, observacoes, ativo);
                        }

                    }

                }

                if (cbx_ativo.SelectedIndex == 0)
                    btn_limpar.Enabled = true;
                else
                    btn_limpar.Enabled = false;
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

                dgv_listagem_fornecedor.Rows.Clear();

                List<Model.Fornecedor> lista_fornecedor = await Data_Service_Fornecedor.SearchAsyncFornecedor(txt_pesquisar_fornecedor.Text);

                if (lista_fornecedor.Count > 0)
                {

                    for (int i = 0; i < lista_fornecedor.Count; i++)
                    {

                        int id = lista_fornecedor[i].id;

                        string nome = lista_fornecedor[i].nome;

                        string cnpj = lista_fornecedor[i].cnpj;

                        string telefone = lista_fornecedor[i].telefone;

                        string data_cadastro = DateTime.Parse(lista_fornecedor[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                        string? observacoes = lista_fornecedor[i].observacoes;

                        if (observacoes == "") observacoes = "Nenhuma observação.";

                        string ativo = lista_fornecedor[i].ativo.ToString();

                        dgv_listagem_fornecedor.Rows.Add(id, nome, cnpj, telefone, data_cadastro, observacoes, ativo);

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void cbx_ativo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                PreencherDGV(this.cbx_ativo.SelectedIndex);
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

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            try
            {
                cbx_ativo.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        int id_fornecedor = 0;
        int fornecedor_ativo = 0;
        private void dgv_listagem_fornecedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_fornecedor = int.Parse(dgv_listagem_fornecedor.CurrentRow.Cells[0].Value.ToString());
                fornecedor_ativo = int.Parse(dgv_listagem_fornecedor.CurrentRow.Cells[6].Value.ToString());

                switch (cbx_ativo.SelectedIndex)
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

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulacaoUsuario(id_fornecedor, fornecedor_ativo);
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
                ManipulacaoUsuario(id_fornecedor, fornecedor_ativo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ManipulacaoUsuario(int id, int ativar_desativar)
        {
            try
            {
                if (MessageBox.Show("Realmente deseja modificar a ativação desse funcionário?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool exito;

                    switch (ativar_desativar)
                    {
                        case 0:
                            exito = await Data_Service_Fornecedor.EnableAsyncFornecedor(id);

                            if (exito)
                            {
                                cbx_ativo.SelectedIndex = 1;
                            }
                            break;

                        case 1:
                            exito = await Data_Service_Fornecedor.DisableAsyncFornecedor(id);

                            if (exito)
                            {
                                cbx_ativo.SelectedIndex = 0;
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

    }

}