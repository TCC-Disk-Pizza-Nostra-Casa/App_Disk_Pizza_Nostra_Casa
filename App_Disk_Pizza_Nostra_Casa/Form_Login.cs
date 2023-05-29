using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Login
{

    public partial class form_login : Form
    {

        public form_login()
        {

            InitializeComponent();

        }

        private void form_login_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(1045, 579);

            this.MaximumSize = new Size(1045, 579);

            txt_usuario.BackColor = this.BackColor;

            txt_senha.BackColor = this.BackColor;

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            this.Hide();

            new form_inicio().Show();

        }

    }

}
