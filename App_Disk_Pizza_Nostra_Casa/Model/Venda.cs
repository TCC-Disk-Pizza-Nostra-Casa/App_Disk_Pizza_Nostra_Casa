using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Venda
    {

        public int id { get; set; }

        public int delivery { get; set; } = 0;

        public double valor_total { get; set; }

        public int fk_funcionario { get; set; }

        public int fk_cliente { get; set; }

        public string data_venda { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    }

    /*public async Task<bool>? Save()
    {



    }

    public static async Task<bool>? Enable(int id)
    {



    }

    public static async Task<bool>? Disable(int id)
    {



    }

    public static async Task<List<Venda>>? GetList()
    {



    }

    public static async Task<List<Venda>>? Search(string filtro)
    {



    }*/

}