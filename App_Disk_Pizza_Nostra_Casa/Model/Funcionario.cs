﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Funcionario
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string genero { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string cargo { get; set; }

        public string cep { get; set; }

        public string email { get; set; } = null;

        public string telefone { get; set; }

        public string senha { get; set; }

        public string observacoes { get; set; } = null;

        public bool administrador { get; set; } = false;

        public DateTime data_cadastro { get; set; } = DateTime.Now;

        public bool ativo { get; set; } = true;

    }

}