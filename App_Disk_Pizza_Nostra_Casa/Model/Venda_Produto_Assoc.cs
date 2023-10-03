using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Venda_Produto_Assoc
    {

        public int fk_venda {  get; set; }

        public int fk_produto { get; set; }

        public int quantidade_produto { get; set; }

        public double valor_total_item_venda { get; set; }

    }

}
