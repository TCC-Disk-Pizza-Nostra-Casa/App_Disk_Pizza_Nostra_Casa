using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;
using Newtonsoft.Json;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public class Data_Service_Cliente : Data_Service
    {

        public static async Task<Cliente>? SaveAsyncCliente(Cliente model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/cliente/save");

            Cliente model_retornada = JsonConvert.DeserializeObject<Cliente>(json);

            return model_retornada;

        }

        public static async Task<bool>? EnableAsyncCliente(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/cliente/enable");

            bool resultado = JsonConvert.DeserializeObject<bool>(json);

            return resultado;

        }

        public static async Task<bool>? DisableAsyncCliente(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/cliente/disable");

            bool resultado = JsonConvert.DeserializeObject<bool>(json);

            return resultado;

        }

        public static async Task<List<Cliente>>? GetListAsyncCliente()
        {

            string json = await Data_Service.GetDataApi("/cliente/list");

            List<Cliente> list_clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);

            return list_clientes;

        }

        public static async Task<List<Cliente>>? SearchAsyncCliente(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/cliente/search");

            List<Cliente> list_clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);

            return list_clientes;

        }

    }

}