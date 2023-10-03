using App_Disk_Pizza_Nostra_Casa.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Service
{
    public class Data_Service_Fornecedor : Data_Service
    {
        public static async Task<Fornecedor>? SaveAsyncFornecedor(Fornecedor model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/fornecedor/save");

            Fornecedor model_retornada = JsonConvert.DeserializeObject<Fornecedor>(json);

            return model_retornada;

        }

        public static async Task<bool>? DeleteAsyncFornecedor(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/fornecedor/delete");

            bool resultado = JsonConvert.DeserializeObject<bool>(json);

            return resultado;

        }

        public static async Task<List<Fornecedor>>? GetListAsyncFornecedor()
        {

            string json = await Data_Service.GetDataApi("/fornecedor/list");

            List<Fornecedor> model_retornada = JsonConvert.DeserializeObject<List<Fornecedor>>(json);

            return model_retornada;

        }

        public static async Task<List<Fornecedor>>? SearchAsyncFornecedor(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/fornecedor/search");

            List<Fornecedor> model_retornada = JsonConvert.DeserializeObject<List<Fornecedor>>(json);

            return model_retornada;

        }

        public static async Task<bool> EnableAsyncFornecedor(int id)
        {
            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/fornecedor/enable");

            bool resultado = JsonConvert.DeserializeObject<bool>(json);

            return resultado;
        }

        public static async Task<bool> DisableAsyncFornecedor(int id)
        {
            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/fornecedor/disable");

            bool resultado = JsonConvert.DeserializeObject<bool>(json);

            return resultado;
        }
    }
}
