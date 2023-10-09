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

            

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            Model.Cliente cliente = new Model.Cliente()
            {

                

            };

            Model.Cliente cliente_model = await Data_Service_Cliente.SaveAsyncCliente(cliente);

            if (cliente_model.id != null)
            {

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        void Preencher_Formulario(Model.Cliente cliente)
        {

            

        }

    }

}