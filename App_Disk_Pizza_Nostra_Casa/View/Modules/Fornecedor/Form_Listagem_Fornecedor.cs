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

                List<Model.Fornecedor> lista_fornecedor = await Data_Service_Fornecedor.GetListAsyncFornecedor();

                if (lista_fornecedor.Count > 0)
                {

                    for (int i = 0; i < lista_fornecedor.Count; i++)
                    {

                        string nome = lista_fornecedor[i].nome;

                        string cnpj = lista_fornecedor[i].cnpj.ToString();

                        string telefone = lista_fornecedor[i].telefone.ToString();

                        string data_cadastro = lista_fornecedor[i].data_modificacao.ToString();

                        string observacoes = lista_fornecedor[i].observacoes.ToString();

                        if (observacoes == "") observacoes = "Nenhuma observação.";

                        dgv_listagem_fornecedor.Rows.Add(nome, cnpj, telefone, data_cadastro, observacoes);

                    }

                }

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

                        string nome = lista_fornecedor[i].nome;

                        string cnpj = lista_fornecedor[i].cnpj.ToString();

                        string telefone = lista_fornecedor[i].telefone.ToString();

                        string data_cadastro = lista_fornecedor[i].data_modificacao.ToString();

                        string observacoes = lista_fornecedor[i].observacoes.ToString();

                        if (observacoes == "") observacoes = "Nenhuma observação.";

                        dgv_listagem_fornecedor.Rows.Add(nome, cnpj, telefone, data_cadastro, observacoes);

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
