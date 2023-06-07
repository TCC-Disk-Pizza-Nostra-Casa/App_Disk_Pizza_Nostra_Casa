using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using Newtonsoft.Json;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public class Data_Service_Funcionario : Data_Service
    {

        public static async Task<Funcionario> SaveAsyncFuncionario(Funcionario model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/save");

            Funcionario model_retornada = JsonConvert.DeserializeObject<Funcionario>(json);

            return model_retornada;

        }

        public static async Task<bool> DeleteAsyncFuncionario(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "funcionario/delete");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Funcionario>> GetListAsyncFuncionario()
        {

            string json = await Data_Service.GetDataApi("/funcionario/list");

            List<Funcionario> lista_funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(json);

            return lista_funcionarios;

        }

        public static async Task<List<Funcionario>> SearchAsyncFuncionario(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(parametro, "/funcionario/search");

            List<Funcionario> lista_funcionarios_encontrados = JsonConvert.DeserializeObject<List<Funcionario>>(json);

            return lista_funcionarios_encontrados;

        }

        public static async Task<List<Funcionario>> LoginAsyncFuncionario(string usuario, string senha)
        {



        }

    }

}
