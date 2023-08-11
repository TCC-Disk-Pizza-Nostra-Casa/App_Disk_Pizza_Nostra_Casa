using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Venda
    {

        public int id { get; set; }

        public DateTime data_venda { get; set; }

        public bool delivery { get; set; }

        public double valor_total { get; set; }

        public int id_funcionario { get; set; }

    }

}