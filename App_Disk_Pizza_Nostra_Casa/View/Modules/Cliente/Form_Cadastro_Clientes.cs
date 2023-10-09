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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Cliente
{

    public partial class form_cadastro_clientes : Form
    {

        private Model.Cliente cliente_edicao;

        public form_cadastro_clientes()
        {

            InitializeComponent();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            txt_nome_cliente.Clear();
            txt_email_cliente.Clear();
            txt_telefone_cliente.Clear();
            txt_observacoes_cliente.Clear();

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            Model.Cliente cliente = new Model.Cliente()
            {

                nome = txt_nome_cliente.Text,
                email = txt_email_cliente.Text,
                telefone = txt_telefone_cliente.Text,
                observacoes = txt_observacoes_cliente.Text

            };

            Model.Cliente cliente_model = await Data_Service_Cliente.SaveAsyncCliente(cliente);

            if (cliente_model.id != null)
            {

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        void Preencher_Formulario(Model.Cliente cliente)
        {

            txt_nome_cliente.Text = cliente.nome;
            txt_email_cliente.Text = cliente.email;
            txt_telefone_cliente.Text = cliente.telefone;
            txt_observacoes_cliente.Text = cliente.observacoes;

        }

    }

}