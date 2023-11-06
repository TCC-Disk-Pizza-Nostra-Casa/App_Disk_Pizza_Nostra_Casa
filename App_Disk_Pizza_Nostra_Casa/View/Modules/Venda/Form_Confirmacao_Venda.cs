using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Venda
{

    public partial class form_confirmacao_venda : Form
    {

        public List<int> ids_itens_venda;

        private double valor_total = 0;

        public form_adicionar_venda? form_venda_atual = null;

        public form_confirmacao_venda()
        {

            InitializeComponent();

        }

        private void form_confirmacao_venda_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(400, 400);

                this.MaximumSize = new Size(400, 400);

                this.Size = new Size(400, 400);

                lbl_valor_total.Text = "Valor Total: " + valor_total.ToString("C2");

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}