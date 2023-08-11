using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using Newtonsoft.Json;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public class Data_Service_Venda : Data_Service
    {

        /**
         * model é o parametro JSON.
         * Função que salva dados JSON na api.
         * post_json é o um JSON serializado pra ser 
         * enviado para /venda/save.
         * 
         * json é a var que recebe esse envio.
         * model_retornada é um objeto que recebe o json desserialisado.
         */

        public static async Task<Venda>? SaveAsyncVenda(Venda model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/venda/save");

            Venda model_retornada = JsonConvert.DeserializeObject<Venda>(json);

            return model_retornada;

        }

        /**
         * Deleta venda na api
         * post_json é o um JSON serializado pra ser 
         * deletado para /venda/save.
         * 
         * json é a var que recebe esse envio.
         * exito é gravado um valor que descreve se foi 
         * bem sucedido a deserialização e deleção.
         */

        public static async Task<bool>? DeleteAsyncVenda(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "venda/delete");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        /**
         * Pega lista de vendas.
         * json é os dados da api.
         * lista_vendas é a lista de JSON.
         */

        public static async Task<List<Venda>>? GetListAsyncVenda()
        {

            string json = await Data_Service.GetDataApi("/venda/list");

            List<Venda> lista_vendas = JsonConvert.DeserializeObject<List<Venda>>(json);

            return lista_vendas;

        }

        /**
         * Procura uma Venda.
         * post_json é o parametro que será buscado, só que serializado.
         * json é o envio para api, para a rota.
         * lista_vendas_encontradas é os dados json sendo deserializados como uma
         * lista pro c#.
         */

        public static async Task<List<Venda>>? SearchAsyncVenda(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/venda/search");

            List<Venda> lista_vendas_encontradas = JsonConvert.DeserializeObject<List<Venda>>(json);

            return lista_vendas_encontradas;

        }

    }

}