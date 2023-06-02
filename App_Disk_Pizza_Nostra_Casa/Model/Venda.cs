using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Venda
    {

        int id { get; set; }

        DateTime data_venda { get; set; }

        bool delivery { get; set; }

        double valor_total { get; set; }

        int id_funcionario { get; set; }

    }

}
