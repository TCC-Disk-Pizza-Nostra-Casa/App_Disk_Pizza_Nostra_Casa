using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.View;
using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa
{

    public class Global
    {

        // Formulário responsável pela interface.

        public static View.Modules.Inicio.form_inicio? formulario_global = null;

        // Variáveis globais.

        public static Model.Funcionario? usuario_sessao = null;

        public static bool administrador = false;

        // Registros do banco de dados.

        public static List<Model.Funcionario>? funcionarios_cadastrados = null;

        public static List<Model.Cliente>? clientes_cadastrados = null;

        public static List<Model.Fornecedor>? fornecedores_cadastrados = null;

        public static List<Model.Produto>? produtos_cadastrados = null;

        public static List<Model.Venda>? vendas_cadastradas = null;

        // Métodos de validação.

        public static bool CPF_Validation(string value)
        {

            // Removendo símbolos especiais, caso exista, do CPF.

            string cpf = value.ToString().Replace(".", "").Replace("-", "");

            // Verificando a quantidade de algarismos do CPF.

            if (cpf.Length < 11 || cpf.Length > 11)
            {

                return false;

            }

            else
            {

                // Verificando o CPF.

                string[] cpfs_automaticamente_invalidos = { "00000000000", "11111111111", "22222222222",
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

                    int[] resultados_primeira_verificacao = new int[9];

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

                    int[] resultados_segunda_verificacao = new int[10];

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

        public static bool CNPJ_Validation(string value)
        {

            // Removendo símbolos especiais, caso exista, do CNPJ.

            string cnpj = value.Replace(".", "").Replace("/", "").Replace("-", "");

            // Verificando a quantidade de algarismos do CNPJ.

            if (cnpj.Length < 14 || cnpj.Length > 14)
            {

                return false;

            }

            else
            {

                // Verificando o CNPJ.

                string[] cnpjs_automaticamente_invalidos = { "00000000000000", "11111111111111", "22222222222222",
                                                             "33333333333333", "44444444444444", "55555555555555",
                                                             "66666666666666", "77777777777777", "88888888888888",
                                                             "99999999999999" };

                bool condicao = true;

                foreach (string cnpj_automaticamente_invalido in cnpjs_automaticamente_invalidos)
                {

                    if (cnpj == cnpj_automaticamente_invalido)
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

                    int[] pesos = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                    // Calculando o primeiro dígito verificador.

                    int[] resultados_primeira_verificacao = new int[12];

                    for (int i = 0; i < 12; i++)
                    {

                        resultados_primeira_verificacao[i] = int.Parse(cnpj[i].ToString()) * pesos[i + 1];

                    }

                    int soma_resultados_primeira_verificacao = 0;

                    foreach (int resultado in resultados_primeira_verificacao)
                    {

                        soma_resultados_primeira_verificacao += resultado;

                    }

                    int primeiro_digito_verificador;

                    if (soma_resultados_primeira_verificacao % 11 < 2)
                    {

                        primeiro_digito_verificador = 0;

                    }

                    else
                    {

                        primeiro_digito_verificador = 11 - (soma_resultados_primeira_verificacao % 11);

                    }

                    // Calculando o segundo dígito verificador.

                    int[] resultados_segunda_verificacao = new int[13];

                    for (int i = 0; i < 13; i++)
                    {

                        resultados_segunda_verificacao[i] = int.Parse(cnpj[i].ToString()) * pesos[i];

                    }

                    int soma_resultados_segunda_verificacao = 0;

                    foreach (int resultado in resultados_segunda_verificacao)
                    {

                        soma_resultados_segunda_verificacao += resultado;

                    }

                    int segundo_digito_verificador;

                    if (soma_resultados_segunda_verificacao % 11 < 2)
                    {

                        segundo_digito_verificador = 0;

                    }

                    else
                    {

                        segundo_digito_verificador = 11 - (soma_resultados_segunda_verificacao % 11);

                    }

                    // Validando o CNPJ.

                    if (primeiro_digito_verificador == int.Parse(cnpj[12].ToString()) &&
                        segundo_digito_verificador == int.Parse(cnpj[13].ToString()))
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

        public static bool CEP_Validation(string value)
        {

            string cep = value.Replace("-", "");

            return (cep.Length < 8 || cep.Length > 8) ? false : true;

            /* Esta função é relativamente simples, pois o único orgão que detém o método de
             * validação de um cep, caso exista, são os Correios. */

        }

        public static bool Telephone_Validation(string value)
        {

            string telefone = value.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            return (telefone.Length < 10 || telefone.Length > 11) ? false : true;

        }

        public static string CPF_Mask_Generation(string value)
        {

            string cpf_formatado = "";

            for (int i = 0; i < value.Length; i++)
            {

                if (i == 3 || i == 6)
                {

                    cpf_formatado += "." + value[i];

                }

                else if (i == 9)
                {

                    cpf_formatado += "-" + value[i];

                }

                else
                {

                    cpf_formatado += value[i];

                }

            }

            return cpf_formatado;

        }

        public static string CNPJ_Mask_Generation(string value)
        {

            string cnpj_formatado = "";

            for (int i = 0; i < value.Length; i++)
            {

                if (i == 2 || i == 5)
                {

                    cnpj_formatado += "." + value[i];

                }

                else if (i == 8)
                {

                    cnpj_formatado += "/" + value[i];

                }

                else if (i == 12)
                {

                    cnpj_formatado += "-" + value[i];

                }

                else
                {

                    cnpj_formatado += value[i];

                }

            }

            return cnpj_formatado;

        }

        public static string CEP_Mask_Generation(string value)
        {

            string cep_formatado = "";

            for (int i = 0; i < value.Length; i++)
            {

                if (i == 5)
                {

                    cep_formatado += "-" + value[i];

                }

                else
                {

                    cep_formatado += value[i];

                }

            }

            return cep_formatado;

        }

        public static string Telephone_Mask_Generation(string value)
        {

            string telefone_formatado = "";

            if (value.Substring(0, 4) == "0800")
            {

                for (int i = 0; i < value.Length; i++)
                {

                    if (i == 4 || i == 7)
                    {

                        telefone_formatado += " " + value[i];

                    }

                    else
                    {

                        telefone_formatado += value[i];

                    }

                }

            }

            else
            {

                for (int i = 0; i < value.Length; i++)
                {

                    if (i == 0)
                    {

                        telefone_formatado += "(" + value[i];

                    }

                    else if (i == 1)
                    {

                        telefone_formatado += value[i] + ") ";

                    }

                    else if (value.Length == 11 && i == 7)
                    {

                        telefone_formatado += "-" + value[i];

                    }

                    else if (value.Length == 10 && i == 6)
                    {

                        telefone_formatado += "-" + value[i];

                    }

                    else
                    {

                        telefone_formatado += value[i];

                    }

                }

            }

            return telefone_formatado;

        }

    }

}