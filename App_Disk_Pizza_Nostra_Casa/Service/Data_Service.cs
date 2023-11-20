using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using System.Net;
using System.Net.Http;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Service
{

    public abstract class Data_Service
    {

        private static readonly string host = "http://localhost:8000";

        private static void ShowContentInOutput(string mensagem)
        {

            Debug.WriteLine("\n______________________________________________\n");

            Debug.WriteLine(mensagem + "\n");

            Debug.WriteLine("______________________________________________\n");

        }

        protected static async Task<string> GetDataApi(string rota)
        {

            string json;

            string uri = host + rota;

            using(HttpClient cliente = new HttpClient())
            {

                HttpResponseMessage requisicao_api = await cliente.GetAsync(uri);

                ShowContentInOutput(requisicao_api.Content.ReadAsStringAsync().Result);

                if(requisicao_api.IsSuccessStatusCode)
                {

                    json = requisicao_api.Content.ReadAsStringAsync().Result;

                }

                else
                {

                    throw new Exception(ServerErrorValidation(requisicao_api.StatusCode));

                }

            }

            return json;

        }

        protected static async Task<string> SendDataApi(string objeto_json, string rota)
        {

            string json;

            string uri = host + rota;

            using (HttpClient cliente = new HttpClient())
            {

                HttpResponseMessage requisicao_api = await cliente.PostAsync(uri, new StringContent(objeto_json, Encoding.UTF8, "application/json"));

                ShowContentInOutput(requisicao_api.Content.ReadAsStringAsync().Result);

                if(requisicao_api.IsSuccessStatusCode)
                {

                    json = requisicao_api.Content.ReadAsStringAsync().Result;

                }

                else
                {

                    throw new Exception(ServerErrorValidation(requisicao_api.StatusCode));

                }

            }

            return json;

        }

        private static string ServerErrorValidation(HttpStatusCode status_code)
        {

            string mensagem_erro;

            switch(status_code)
            {

                case HttpStatusCode.BadRequest:
                    mensagem_erro = "A requisição não pode ser atendida agora! Tente novamente mais tarde.";
                break;

                case HttpStatusCode.NotFound:
                    mensagem_erro = "Recurso indisponível no momento! Tente novamente mais tarde.";
                break;

                case HttpStatusCode.InternalServerError:
                    mensagem_erro = "Nosso banco de dados está indisponível no momento! Tente novamente mais tarde.";
                break;

                case HttpStatusCode.RequestTimeout:
                    mensagem_erro = "O servidor não está respondendo! Tente novamente mais tarde";
                break;

                case HttpStatusCode.Forbidden:
                    mensagem_erro = "Recurso temporariamente indisponível! Tente novamente mais tarde.";
                break;

                default:
                    mensagem_erro = "Estamos com dificuldades para acessar nosso servidor! Tente novamente mais tarde.";
                break;

            }

            return mensagem_erro;

        }

    }

}