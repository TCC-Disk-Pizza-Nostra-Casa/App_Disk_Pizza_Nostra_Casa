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

                List<Model.Produto> lista_produtos = await Data_Service_Produto.GetListAsyncProduto();
                
                if (lista_produtos.Count > 0)
                {

                    for (int i = 0; i < lista_produtos.Count; i++)
                    {

                        string nome = lista_produtos[i].nome;

                        string estoque = lista_produtos[i].estoque.ToString();

                        string preco = lista_produtos[i].preco.ToString();

                        string observacoes = lista_produtos[i].observacoes.ToString();

                        dgv_listagem_produtos.Rows.Add(nome, estoque, preco, observacoes);

                    }

                }
                

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_pesquisar_produtos_Click(object sender, EventArgs e)
        {

            try
            {

                dgv_listagem_produtos.Rows.Clear();

                List<Model.Produto> lista_produtos = await Data_Service_Produto.SearchAsyncProduto(txt_pesquisar_produtos.Text);

                if (lista_produtos.Count > 0)
                {

                    for (int i = 0; i < lista_produtos.Count; i++)
                    {

                        string nome = lista_produtos[i].nome;

                        string estoque = lista_produtos[i].estoque.ToString();

                        string preco = lista_produtos[i].preco.ToString();

                        string observacoes = lista_produtos[i].observacoes.ToString();

                        dgv_listagem_produtos.Rows.Add(nome, estoque, preco, observacoes);

                    }

                }

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
