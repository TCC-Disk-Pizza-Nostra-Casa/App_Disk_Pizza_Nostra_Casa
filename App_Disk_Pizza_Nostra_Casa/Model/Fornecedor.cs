using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj {  get; set; }
        public string telefone { get; set; }
        public DateTime data_cadastro { get; set; }
        public DateTime data_modificacao { get; set; }
        public bool ativo{ get;  set; }
    }
}
