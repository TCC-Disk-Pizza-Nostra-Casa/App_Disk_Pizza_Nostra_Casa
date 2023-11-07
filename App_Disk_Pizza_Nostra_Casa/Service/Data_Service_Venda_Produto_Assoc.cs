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

    public class Data_Service_Venda_Produto_Assoc : Data_Service
    {

        public static async Task<Venda_Produto_Assoc>? SaveAsyncVendaProdutoAssoc(Venda_Produto_Assoc model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/venda_produto/save");

            Venda_Produto_Assoc model_retornada = JsonConvert.DeserializeObject<Venda_Produto_Assoc>(json);

            return model_retornada;

        }

        public static async Task<bool>? EnableAsyncVendaProdutoAssoc(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/venda_produto/enable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool>? DisableAsyncVendaProdutoAssoc(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/venda_produto/disable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Venda_Produto_Assoc>>? SearchAsyncVendaProdutoAssoc(int id_venda)
        {

            var post_json = JsonConvert.SerializeObject(id_venda);

            string json = await Data_Service.SendDataApi(post_json, "/venda_produto/search");

            List<Venda_Produto_Assoc> lista_itens_encontrados = JsonConvert.DeserializeObject<List<Venda_Produto_Assoc>>(json);

            return lista_itens_encontrados;

        }

    }

}