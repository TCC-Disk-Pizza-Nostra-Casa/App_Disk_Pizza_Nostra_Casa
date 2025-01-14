﻿using System;
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

        private async Task<string> VerifyExistence()
        {

            List<Funcionario>? funcionarios = await GetList();

            foreach (Funcionario funcionario in funcionarios)
            {

                if (this.id != 0 && this.id == funcionario.id)
                {

                    funcionarios.Remove(funcionario);

                    break;

                }

            }

            string mensagem = "";

            string nome = this.nome;

            string cpf = this.cpf.Replace(".", "").Replace("-", "");

            string? email = this.email;

            string telefone = this.telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            foreach (Funcionario funcionario in funcionarios)
            {

                if (funcionario.nome == nome)
                {

                    mensagem = "Já existe um(a) funcionário(a) com esse nome! Altere-o e tente novamente.";

                    break;

                }

                else if (funcionario.cpf == cpf)
                {

                    mensagem = "Já existe um(a) funcionário(a) com esse CPF! Altere-o e tente novamente.";

                    break;

                }

                else if (funcionario.email == email)
                {

                    mensagem = "Já existe um(a) funcionário(a) com esse E-mail! Altere-o e tente novamente.";

                    break;

                }

                else if (funcionario.telefone == telefone)
                {

                    mensagem = "Já existe um(a) funcionário(a) com esse telefone! Altere-o e tente novamente.";

                    break;

                }

            }

            return mensagem;

        }

        public async Task<bool>? Save()
        {

            string verificacao_repeticao = await VerifyExistence();

            if (String.IsNullOrWhiteSpace(this.nome) || String.IsNullOrWhiteSpace(this.sexo) ||
                String.IsNullOrWhiteSpace(this.estado_civil) || String.IsNullOrWhiteSpace(this.cpf) ||
                String.IsNullOrWhiteSpace(this.cep) || String.IsNullOrWhiteSpace(this.telefone) ||
                String.IsNullOrWhiteSpace(this.senha))
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else if (!Global.CPF_Validation(this.cpf))
            {

                throw new Exception("CPF inválido! Revise-o e tente novamente.");

            }

            else if (!Global.CEP_Validation(this.cep))
            {

                throw new Exception("Um CEP possui 8 dígitos! Revise-o e tente novamente.");

            }

            else if (!Global.Telephone_Validation(this.telefone))
            {

                throw new Exception("Um telefone possui de 10 a 11 dígitos! Revise-o e tente novamente.");

            }

            else if(senha != confirmacao_senha)
            {

                throw new Exception("As senhas fornecidas divergem! Revise-as e tente novamente.");

            }

            else if (verificacao_repeticao != "")
            {

                throw new Exception(verificacao_repeticao);

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

                MessageBox.Show("Funcionário(a) reativado(a) com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível reativar o(a) funcionário(a) selecionado(a)! Tente novamente mais tarde.");

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito =  await Data_Service_Funcionario.DisableAsyncFuncionario(id);

            if (exito)
            {

                MessageBox.Show("Funcionário(a) desativado(a) com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível desativar o(a) funcionário(a) selecionado(a)! Tente novamente mais tarde.");

            }

        }

        public static async void Promote(int id)
        {

            bool exito = await Data_Service_Funcionario.PromoteAsyncFuncionario(id);

            if (exito)
            {

                MessageBox.Show("Funcionário(a) promovido(a) com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            else
            {

                throw new Exception("Não foi possível promover o(a) funcionário(a) selecionado(a)! Tente novamente mais tarde.");

            }

        }

        public static async void Demote(int id)
        {

            bool exito = await Data_Service_Funcionario.DemoteAsyncFuncionario(id);

            if (exito)
            {

                MessageBox.Show("Funcionário(a) rebaixado(a) com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            else
            {

                throw new Exception("Não foi possível rebaixar o(a) funcionário(a) selecionado(a)! Tente novamente mais tarde.");

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