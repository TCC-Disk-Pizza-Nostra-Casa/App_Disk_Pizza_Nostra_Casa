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

        public string? email { get; set; } = null;

        public string telefone { get; set; }

        public string senha { get; set; }

        public string confirmacao_senha { get; set; }

        public string? observacoes { get; set; } = null;

        public int administrador { get; set; } = 0;

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string data_modificacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo { get; set; } = 1;

        public async Task<bool>? Save()
        {

            if (String.IsNullOrEmpty(this.nome) || String.IsNullOrEmpty(this.sexo) ||
                String.IsNullOrEmpty(this.estado_civil) || String.IsNullOrEmpty(this.cpf) ||
                String.IsNullOrEmpty(this.cep) || String.IsNullOrEmpty(this.telefone) ||
                String.IsNullOrEmpty(this.senha))
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else if (!Global.CPFValidation(this.cpf))
            {

                throw new Exception("CPF inválido! Revise-o e tente novamente.");

            }

            else if (!Global.CEPValidation(this.cep))
            {

                throw new Exception("Um CEP possui 8 dígitos! Revise-o e tente novamente.");

            }

            else if (!Global.TelephoneValidation(this.telefone))
            {

                throw new Exception("Um telefone possui de 10 a 11 dígitos! Revise-o e tente novamente.");

            }

            else if(senha != confirmacao_senha)
            {

                throw new Exception("As senhas fornecidas divergem! Revise-as e tente novamente.");

            }

            else
            {

                if (MessageBox.Show("Realmente deseja salvar esses dados?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Model.Funcionario funcionario_retornado = await Data_Service_Funcionario.SaveAsyncFuncionario(this);

                    if (funcionario_retornado != null)
                    {

                        MessageBox.Show("Dados salvos com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        return true;

                    }

                    else
                    {

                        throw new Exception("Não foi possível salvar estes dados! Revise-os e tente novamente.");

                    }

                }

                else
                {

                    return false;

                }

            }

        }

        public static async Task<bool>? Enable(int id)
        {

            bool exito = await Data_Service_Funcionario.EnableAsyncFuncionario(id);

            if (exito)
            {

                MessageBox.Show("Funcionário reativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível reativar o funcionário selecionado! Tente novamente mais tarde.");

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito =  await Data_Service_Funcionario.DisableAsyncFuncionario(id);

            if (exito)
            {

                MessageBox.Show("Funcionário desativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível desativar o funcionário selecionado! Tente novamente mais tarde.");

            }

        }

        public static async void Promote(int id)
        {

            bool exito = await Data_Service_Funcionario.PromoteAsyncFuncionario(id);

            if (exito)
            {

                MessageBox.Show("Funcionário promovido com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            else
            {

                throw new Exception("Não foi possível promover o funcionário selecionado! Tente novamente mais tarde.");

            }

        }

        public static async void Demote(int id)
        {

            bool exito = await Data_Service_Funcionario.DemoteAsyncFuncionario(id);

            if (exito)
            {

                MessageBox.Show("Funcionário rebaixado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            else
            {

                throw new Exception("Não foi possível rebaixar o funcionário selecionado! Tente novamente mais tarde.");

            }

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