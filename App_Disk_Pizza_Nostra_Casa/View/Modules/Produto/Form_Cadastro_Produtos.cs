﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Produto
{

    public partial class form_cadastro_produtos : Form
    {

        public form_cadastro_produtos()
        {

            InitializeComponent();

        }

        private void Form_Cadastro_Produtos_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(800, 500);

            this.Size = new Size(800, 500);

        }
    }

}
