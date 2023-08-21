﻿                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;
using Newtonsoft.Json;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public class Data_Service_Produto : Data_Service
    {

        public static async Task<Produto>? SaveAsyncProduto(Produto model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/produto/save");

            Produto model_retornada = JsonConvert.DeserializeObject<Produto>(json);

            return model_retornada;

        }

        /*
        public static async Task<bool>? DeleteAsyncProduto(int id)
        {



        }*/

        public static async Task<List<Produto>>? GetListAsyncProduto()
        {

            string json = await Data_Service.GetDataApi("/produto/list");

            List<Produto> model_retornada = JsonConvert.DeserializeObject<List<Produto>>(json);

            return model_retornada;

        }

        public static async Task<List<Produto>>? SearchAsyncProduto(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/produto/search");

            List<Produto> model_retornada = JsonConvert.DeserializeObject<List<Produto>>(json);

            return model_retornada;

        }

    }

}