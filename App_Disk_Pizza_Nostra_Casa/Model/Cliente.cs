using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Cliente
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string sexo { get; set; }

        public string cpf { get; set; }

        public string cep { get; set; }

        public string? email { get; set; }

        public string telefone { get; set; }

        public string? observacoes { get; set; }

        public DateTime? data_nascimento { get; set; }

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string data_modificacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo { get; set; } = 1;

    }

}