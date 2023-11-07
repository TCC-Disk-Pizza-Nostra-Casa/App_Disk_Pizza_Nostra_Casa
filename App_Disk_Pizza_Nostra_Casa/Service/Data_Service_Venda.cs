using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;
using Newtonsoft.Json;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public class Data_Service_Venda : Data_Service
    {

        public static async Task<Venda>? SaveAsyncVenda(Venda model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/venda/save");

            Venda model_retornada = JsonConvert.DeserializeObject<Venda>(json);

            return model_retornada;

        }

        public static async Task<bool>? EnableAsyncVenda(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/venda/enable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool>? DisableAsyncVenda(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/venda/disable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Venda>>? GetListAsyncVenda()
        {

            string json = await Data_Service.GetDataApi("/venda/list");

            List<Venda> lista_vendas = JsonConvert.DeserializeObject<List<Venda>>(json);

            return lista_vendas;

        }

        public static async Task<List<Venda>>? SearchAsyncVenda(int[] filtros)
        {

            var post_json = JsonConvert.SerializeObject(filtros);

            string json = await Data_Service.SendDataApi(post_json, "/venda/search");

            List<Venda> lista_vendas_encontradas = JsonConvert.DeserializeObject<List<Venda>>(json);

            return lista_vendas_encontradas;

        }

        /*public static async Task<List<Venda>>? SearchByClientAsyncVenda(string nome)
        {
            var post_json = JsonConvert.SerializeObject(nome);

            string json = await Data_Service.SendDataApi(post_json, "/venda/searchByClient");

            List<Venda> lista_vendas_encontradas = JsonConvert.DeserializeObject<List<Venda>>(json);

            return lista_vendas_encontradas;

        }

        public static async Task<List<Venda>>? SearchByDateAsyncVenda(string date)
        {
            var post_json = JsonConvert.SerializeObject(date);

            string json = await Data_Service.SendDataApi(post_json, "/venda/searchByDate");

            List<Venda> lista_vendas_encontradas = JsonConvert.DeserializeObject<List<Venda>>(json);

            return lista_vendas_encontradas;

        }*/

    }

}