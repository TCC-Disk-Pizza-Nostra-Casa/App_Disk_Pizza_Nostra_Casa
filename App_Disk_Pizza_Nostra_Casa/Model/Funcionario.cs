using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Funcionario
    {

        int id { get; set; }

        bool administrador { get; set; }

        string nome { get; set; }

        string email { get; set; }

        string senha { get; set; }

        DateTime data_cadastro { get; set; }

    }

}
