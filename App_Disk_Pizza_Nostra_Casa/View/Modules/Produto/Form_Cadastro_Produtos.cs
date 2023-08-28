using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Produto
{

    public partial class form_cadastro_produtos : Form
    {

        public form_cadastro_produtos()
        {

            InitializeComponent();

        }

        private void form_cadastro_produtos_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            txt_nome_produto.Clear();
            txt_estoque_produto.Clear();
            txt_preco_produto.Clear();
            txt_observacoes_produto.Clear();

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            if (txt_nome_produto.Text == "" || txt_estoque_produto.Text == "" || txt_preco_produto.Text == "")
            {

                MessageBox.Show("Preencha os campos obrigatórios.", "Cadastro incompleto!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {

                Model.Produto produto = new Model.Produto()
                {
                    nome = txt_nome_produto.Text,
                    estoque = int.Parse(txt_estoque_produto.Text),
                    preco = double.Parse(txt_preco_produto.Text),
                    observacoes = txt_observacoes_produto.Text
                };

                Model.Produto produto2 = await Data_Service_Produto.SaveAsyncProduto(produto);

                if (produto2.id != null)
                {

                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }
    }

}