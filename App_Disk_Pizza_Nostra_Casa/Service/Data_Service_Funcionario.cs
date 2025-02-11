﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public class Data_Service_Funcionario : Data_Service
    {

        public static async Task<Funcionario>? SaveAsyncFuncionario(Funcionario model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/save");

            Funcionario? model_retornada = JsonConvert.DeserializeObject<Funcionario>(json);

            return model_retornada;

        }

        public static async Task<bool>? EnableAsyncFuncionario(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/enable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool>? DisableAsyncFuncionario(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/disable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool>? PromoteAsyncFuncionario(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/promote");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool>? DemoteAsyncFuncionario(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/demote");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Funcionario>>? GetListAsyncFuncionario()
        {

            string json = await Data_Service.GetDataApi("/funcionario/list");

            List<Funcionario>? lista_funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(json);

            return lista_funcionarios;

        }

        public static async Task<List<Funcionario>>? SearchAsyncFuncionario(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/search");

            List<Funcionario>? lista_funcionarios_encontrados = JsonConvert.DeserializeObject<List<Funcionario>>(json);

            return lista_funcionarios_encontrados;

        }

        public static async Task<Funcionario>? LoginAsyncFuncionario(string[] dados_login)
        {

            var post_json = JsonConvert.SerializeObject(dados_login);

            string json = await Data_Service.SendDataApi(post_json, "/funcionario/login");

            Funcionario? usuario_correspondente = JsonConvert.DeserializeObject<Funcionario>(json);

            return usuario_correspondente;

        }

    }

}