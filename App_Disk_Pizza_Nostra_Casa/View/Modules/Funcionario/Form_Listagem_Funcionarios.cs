using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Funcionario
{

    public partial class form_listagem_funcionarios : Form
    {

        public form_listagem_funcionarios()
        {

            InitializeComponent();

        }

        private void form_listagem_funcionarios_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(800, 500);

            this.Size = new Size(800, 500);

        }

    }

}
