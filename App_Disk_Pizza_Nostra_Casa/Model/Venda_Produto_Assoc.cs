using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Venda_Produto_Assoc
    {

        int id_produto { get; set; }

        int id_venda { get; set; }

        int quantidade_produto { get; set; }

        double valor_item_venda { get; set; }

    }

}
