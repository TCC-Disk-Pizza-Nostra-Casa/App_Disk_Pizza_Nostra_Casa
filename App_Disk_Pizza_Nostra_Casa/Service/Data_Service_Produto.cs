using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public class Data_Service_Produto : Data_Service
    {

        public static async Task<Produto>? SaveAsyncProduto(Produto model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/produto/save");

            Produto? model_retornada = JsonConvert.DeserializeObject<Produto>(json);

            return model_retornada;

        }

        public static async Task<bool>? EnableAsyncProduto(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/produto/enable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool>? DisableAsyncProduto(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/produto/disable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Produto>>? GetListAsyncProduto()
        {

            string json = await Data_Service.GetDataApi("/produto/list");

            List<Produto>? lista_produtos = JsonConvert.DeserializeObject<List<Produto>>(json);

            return lista_produtos;

        }

        public static async Task<List<Produto>>? SearchAsyncProduto(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/produto/search");

            List<Produto>? lista_produtos_encontrados = JsonConvert.DeserializeObject<List<Produto>>(json);

            return lista_produtos_encontrados;

        }

    }

}