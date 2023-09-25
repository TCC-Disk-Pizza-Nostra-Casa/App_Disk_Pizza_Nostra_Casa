using App_Disk_Pizza_Nostra_Casa.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{

    public partial class Form_Cadastro_Fornecedor : Form
    {

        public Form_Cadastro_Fornecedor()
        {

            InitializeComponent();

        }

        private void Form_Cadastro_Fornecedor_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(800, 500);

            this.Size = new Size(800, 500);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            txt_nome_fornecedor.Clear();
            txt_cnpj_fornecedor.Clear();
            txt_telefone_fornecedor.Clear();
            txt_observacoes_fornecedor.Clear();

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            Model.Fornecedor fornecedor = new Model.Fornecedor()
            {
                nome = txt_nome_fornecedor.Text,
                cnpj = txt_cnpj_fornecedor.Text,
                telefone = txt_telefone_fornecedor.Text,
                observacoes = txt_observacoes_fornecedor.Text
            };

            Model.Fornecedor fornecedor2 = await Data_Service_Fornecedor.SaveAsyncFornecedor(fornecedor);

            if (fornecedor2.id != null)
                MessageBox.Show("Dados salvos com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }

}