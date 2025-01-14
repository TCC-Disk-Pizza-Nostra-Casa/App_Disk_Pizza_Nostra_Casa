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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Cliente
{

    public partial class form_listagem_clientes : Form
    {

        public form_listagem_clientes()
        {

            InitializeComponent();

        }

        private void form_listagem_clientes_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_condicao_cliente.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_condicao_cliente.DataSource = new string[] { "Não ativos", "Ativos" };

                DataGridView_Configuration();

                cbbox_condicao_cliente.SelectedIndex = 1;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_pesquisar_cliente_Click(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrWhiteSpace(txt_pesquisar_cliente.Text))
                {

                    throw new Exception("Preencha o campo de pesquisa para prosseguir.");

                }

                else
                {

                    string texto = txt_pesquisar_cliente.Text;

                    txt_pesquisar_cliente.Clear();

                    List<Model.Cliente> lista_clientes_encontrados = await Model.Cliente.Search(texto);

                    if (lista_clientes_encontrados.Count > 0)
                    {

                        dgv_listagem_clientes.Rows.Clear();

                        ValuesAssociation(lista_clientes_encontrados, cbbox_condicao_cliente.SelectedIndex);

                        if (dgv_listagem_clientes.RowCount > 0)
                        {

                            btn_resetar.Enabled = true;

                        }

                        else
                        {

                            DataGridView_Fill();

                            throw new Exception("Nenhum cliente encontrado.");

                        }

                    }

                    else
                    {

                        throw new Exception("Nenhum cliente encontrado.");

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbbox_condicao_cliente_SelectedIndexChanged(object sender, EventArgs e)
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

                dgv_listagem_clientes.Font = new Font(new FontFamily("Arial"), 12f);

                dgv_listagem_clientes.ForeColor = Color.Black;

                dgv_listagem_clientes.Columns.Clear();

                dgv_listagem_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dgv_listagem_clientes.SelectionMode = DataGridViewSelectionMode.CellSelect;

                dgv_listagem_clientes.ReadOnly = true;

                // Permissões do usuário.

                dgv_listagem_clientes.AllowUserToAddRows = false;

                dgv_listagem_clientes.AllowUserToDeleteRows = false;

                dgv_listagem_clientes.AllowUserToOrderColumns = true;

                dgv_listagem_clientes.AllowUserToResizeRows = true;

                // Colunas.

                dgv_listagem_clientes.Columns.Insert(0, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(2, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(3, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(4, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(5, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(6, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(7, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(8, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(9, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(10, new DataGridViewTextBoxColumn());

                dgv_listagem_clientes.Columns.Insert(11, new DataGridViewTextBoxColumn());

                // Dados das colunas.

                dgv_listagem_clientes.Columns[0].HeaderText = "ID:";
                dgv_listagem_clientes.Columns[0].Name = "dgv_listagem_clientes_id";
                dgv_listagem_clientes.Columns[0].Visible = false;

                dgv_listagem_clientes.Columns[1].HeaderText = "Nome:";
                dgv_listagem_clientes.Columns[1].Name = "dgv_listagem_clientes_nome";
                dgv_listagem_clientes.Columns[1].Visible = true;

                dgv_listagem_clientes.Columns[2].HeaderText = "Sexo:";
                dgv_listagem_clientes.Columns[2].Name = "dgv_listagem_clientes_sexo";
                dgv_listagem_clientes.Columns[2].Visible = true;

                dgv_listagem_clientes.Columns[3].HeaderText = "Estado civil:";
                dgv_listagem_clientes.Columns[3].Name = "dgv_listagem_clientes_estado_civil";
                dgv_listagem_clientes.Columns[3].Visible = true;

                dgv_listagem_clientes.Columns[4].HeaderText = "CPF:";
                dgv_listagem_clientes.Columns[4].Name = "dgv_listagem_clientes_cpf";
                dgv_listagem_clientes.Columns[4].Visible = false;

                dgv_listagem_clientes.Columns[5].HeaderText = "CEP:";
                dgv_listagem_clientes.Columns[5].Name = "dgv_listagem_clientes_cep";
                dgv_listagem_clientes.Columns[5].Visible = true;

                dgv_listagem_clientes.Columns[6].HeaderText = "E-mail:";
                dgv_listagem_clientes.Columns[6].Name = "dgv_listagem_clientes_email";
                dgv_listagem_clientes.Columns[6].Visible = false;

                dgv_listagem_clientes.Columns[7].HeaderText = "Telefone:";
                dgv_listagem_clientes.Columns[7].Name = "dgv_listagem_clientes_telefone";
                dgv_listagem_clientes.Columns[7].Visible = true;

                dgv_listagem_clientes.Columns[8].HeaderText = "Data de nascimento:";
                dgv_listagem_clientes.Columns[8].Name = "dgv_listagem_clientes_data_nascimento";
                dgv_listagem_clientes.Columns[8].Visible = true;

                dgv_listagem_clientes.Columns[9].HeaderText = "Observações:";
                dgv_listagem_clientes.Columns[9].Name = "dgv_listagem_clientes_observacoes";
                dgv_listagem_clientes.Columns[9].Visible = true;

                dgv_listagem_clientes.Columns[10].HeaderText = "Última modificação:";
                dgv_listagem_clientes.Columns[10].Name = "dgv_listagem_clientes_data_modificacao";
                dgv_listagem_clientes.Columns[10].Visible = true;

                dgv_listagem_clientes.Columns[11].HeaderText = "Editar:";
                dgv_listagem_clientes.Columns[11].Name = "dgv_listagem_clientes_editar";
                dgv_listagem_clientes.Columns[11].Visible = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ValuesAssociation(List<Model.Cliente> lista, int condicao)
        {

            try
            {

                dgv_listagem_clientes.Rows.Clear();

                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].ativo == condicao)
                    {

                        int id = lista[i].id;

                        string nome = lista[i].nome;

                        string sexo = lista[i].sexo;

                        string estado_civil = lista[i].estado_civil;

                        string cpf = lista[i].cpf;

                        string cep = lista[i].cep;

                        string? email = lista[i].email;

                        string telefone = lista[i].telefone;

                        string data_nascimento = DateTime.Parse(lista[i].data_nascimento).ToString("dd/MM/yyyy");

                        string? observacoes = lista[i].observacoes;

                        string data_modificacao = DateTime.Parse(lista[i].data_modificacao).ToString("dd/MM/yyyy HH:mm:ss");

                        dgv_listagem_clientes.Rows.Add(id, nome, sexo, estado_civil, Global.CPF_Mask_Generation(cpf), Global.CEP_Mask_Generation(cep), email, Global.Telephone_Mask_Generation(telefone), data_nascimento, observacoes, data_modificacao, "Clique aqui");

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

                Global.clientes_cadastrados = await Model.Cliente.GetList();

                if (Global.clientes_cadastrados.Count > 0)
                {

                    ValuesAssociation(Global.clientes_cadastrados, cbbox_condicao_cliente.SelectedIndex);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgv_listagem_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgv_listagem_clientes.RowCount > 0 && dgv_listagem_clientes.CurrentCell.ColumnIndex == 11)
                {

                    if (MessageBox.Show("Deseja editar os dados do cliente selecionado?", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Modules.Cliente.form_cadastro_clientes form_cliente = new form_cadastro_clientes();

                        Model.Cliente? cliente_selecionado = null;

                        for (int i = 0; i < Global.clientes_cadastrados.Count; i++)
                        {

                            if (Global.clientes_cadastrados[i].id == Convert.ToInt32(dgv_listagem_clientes.CurrentRow.Cells[0].Value))
                            {

                                cliente_selecionado = Global.clientes_cadastrados[i];

                                break;

                            }

                        }

                        form_cliente.cliente_selecionado = cliente_selecionado;

                        if (Global.formulario_global != null)
                        {

                            Global.formulario_global.External_Form_Association(form_cliente);

                        }

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgv_listagem_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgv_listagem_clientes.RowCount > 0)
                {

                    switch (cbbox_condicao_cliente.SelectedIndex)
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

        private async void Client_Manipulation()
        {

            try
            {

                if (MessageBox.Show("Realmente deseja modificar a ativação desse cliente?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id_cliente = Convert.ToInt32(dgv_listagem_clientes.CurrentRow.Cells[0].Value);

                    switch (cbbox_condicao_cliente.SelectedIndex)
                    {

                        case 0:

                            if (Convert.ToBoolean(await Model.Cliente.Enable(id_cliente)))
                            {

                                DataGridView_Fill();

                            }

                            break;

                        case 1:

                            if (Convert.ToBoolean(await Model.Cliente.Disable(id_cliente)))
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

                Client_Manipulation();

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

                Client_Manipulation();

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

                if (MessageBox.Show("Realmente deseja resetar a tabela de clientes?", "Atenção!",
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