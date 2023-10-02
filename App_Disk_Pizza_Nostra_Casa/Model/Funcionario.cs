using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Funcionario
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string sexo { get; set; }

        public string estado_civil { get; set; }

        public string cpf { get; set; }

        public string cep { get; set; }

        public string email { get; set; } = null;

        public string telefone { get; set; }

        public string senha { get; set; }

        public string confirmacao_senha { get; set; }

        public string observacoes { get; set; } = null;

        public int administrador { get; set; } = 0;

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string data_modificacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo { get; set; } = 1;

        public async Task<Funcionario>? Save()
        {

            if (String.IsNullOrEmpty(this.nome) || String.IsNullOrEmpty(this.sexo) ||
                String.IsNullOrEmpty(this.estado_civil) || String.IsNullOrEmpty(this.cpf) ||
                String.IsNullOrEmpty(this.cep) || String.IsNullOrEmpty(this.telefone) ||
                String.IsNullOrEmpty(this.senha))
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else if (!Model.Funcoes_Globais.CPFValidation(this.cpf))
            {

                throw new Exception("CPF inválido! Revise-o e tente novamente.");

            }

            else if (!Model.Funcoes_Globais.CEPValidation(this.cep))
            {

                throw new Exception("Um CEP possui 8 dígitos! Revise-o e tente novamente.");

            }

            else if(senha != confirmacao_senha)
            {

                throw new Exception("As senhas fornecidas divergem! Revise-as e tente novamente.");

            }

            else
            {

                return await Data_Service_Funcionario.SaveAsyncFuncionario(this);

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            return await Data_Service_Funcionario.DisableAsyncFuncionario(id);

        }

        public static async Task<bool>? Enable(int id)
        {

            return await Data_Service_Funcionario.EnableAsyncFuncionario(id);

        }

        public static async Task<List<Funcionario>>? GetList()
        {

            return await Data_Service_Funcionario.GetListAsyncFuncionario();

        }

        public static async Task<List<Funcionario>>? Search(string filtro)
        {

            return await Data_Service_Funcionario.SearchAsyncFuncionario(filtro);

        }

        public static async Task<Funcionario>? Login(string[] dados_login)
        {

            return await Data_Service_Funcionario.LoginAsyncFuncionario(dados_login);

        }

    }

}