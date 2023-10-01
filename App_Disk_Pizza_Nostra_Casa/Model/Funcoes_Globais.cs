using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Funcoes_Globais
    {

        public static bool CPFValidation(string value)
        {

            // Removendo símbolos especiais, caso exista, do CPF.

            string cpf = value.ToString().Replace(".", "").Replace("-", "");

            // Verificando quantidade de algarismos do CPF.

            if (cpf.Length < 11 || cpf.Length > 11)
            {

                return false;

            }

            else
            {

                // Verificando o CPF.

                string [] cpfs_automaticamente_invalidos = { "00000000000", "11111111111", "22222222222",
                                                             "33333333333", "44444444444", "55555555555",
                                                             "66666666666", "77777777777", "88888888888",
                                                             "99999999999" };

                bool condicao = true;

                foreach (string cpf_automaticamente_invalido in cpfs_automaticamente_invalidos)
                {

                    if (cpf == cpf_automaticamente_invalido)
                    {

                        condicao = false;

                        break;

                    }

                }

                if (!condicao)
                {

                    return false;

                }

                else
                {

                    int[] pesos = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                    // Calculando o primeiro dígito verificador.

                    int [] resultados_primeira_verificacao = new int[9];

                    for (int i = 0; i < 9; i++)
                    {

                        resultados_primeira_verificacao[i] = int.Parse(cpf[i].ToString()) * pesos[i + 1];

                    }

                    int soma_resultados_primeira_verificacao = 0;

                    foreach (int resultado in resultados_primeira_verificacao)
                    {

                        soma_resultados_primeira_verificacao += resultado;

                    }

                    int primeiro_digito_verificador = 11 - (soma_resultados_primeira_verificacao % 11);

                    if (primeiro_digito_verificador >= 10)
                    {

                        primeiro_digito_verificador = 0;

                    }

                    // Calculando o segundo dígito verificador.

                    int [] resultados_segunda_verificacao = new int[10];

                    for (int i = 0; i < 10; i++)
                    {

                        resultados_segunda_verificacao[i] = int.Parse(cpf[i].ToString()) * pesos[i];

                    }

                    int soma_resultados_segunda_verificacao = 0;

                    foreach (int resultado in resultados_segunda_verificacao)
                    {

                        soma_resultados_segunda_verificacao += resultado;

                    }

                    int segundo_digito_verificador = 11 - (soma_resultados_segunda_verificacao % 11);

                    if (segundo_digito_verificador >= 10)
                    {

                        segundo_digito_verificador = 0;

                    }

                    // Validando o CPF.

                    if (primeiro_digito_verificador == int.Parse(cpf[9].ToString()) &&
                        segundo_digito_verificador == int.Parse(cpf[10].ToString()))
                    {

                        return true;

                    }

                    else
                    {

                        return false;

                    }

                }

            }

        }

        public static bool CEPValidation(string value)
        {

            string cep = value.Replace("-", "");

            if(cep.Length < 8 || cep.Length > 8)
            {

                return false;

            }

            else
            {

                return true;

            }

            /* Esta função é relativamente simples, pois o único orgão que detém o método de
             * validação de um cep, caso exista, são os Correios. */

        }

        public static bool CNPJValidation()
        {

            return false;

        }

        public static bool PasswordVerification()
        {

            return false;

        }

    }

}