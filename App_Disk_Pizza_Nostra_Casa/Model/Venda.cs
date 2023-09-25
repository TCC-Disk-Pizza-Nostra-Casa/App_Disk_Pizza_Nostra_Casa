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

        public string data_venda { get; set; }

        public bool delivery { get; set; }

        public double valor_total { get; set; }

        public string funcionario { get; set; }

        public string cliente { get; set; }

        public List<string> produto { get; set; }

        public List<int> quantidade_produto { get; set; }

        public List<double> valor_total_item_venda { get; set; }

        public int id_cliente { get; set; }

    }

}