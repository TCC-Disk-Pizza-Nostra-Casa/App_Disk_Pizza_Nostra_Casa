﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Produto
    {

        public int id { get; set; }

        public string nome { get; set; }

        public int estoque { get; set; }

        public double preco { get; set; }

        public string? observacoes { get; set; }

    }

}
