using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Fornecedor
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string cnpj {  get; set; }

        public string? email { get; set; } = null;

        public string telefone { get; set; }

        public string? observacoes { get; set; }

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string data_modificacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo { get; set; } = 1;

        private async Task<string> VerifyExistence()
        {

            List<Fornecedor>? fornecedores = await GetList();

            foreach (Fornecedor fornecedor in fornecedores)
            {

                if (this.id != 0 && this.id == fornecedor.id)
                {

                    fornecedores.Remove(fornecedor);

                    break;

                }

            }

            string mensagem = "";

            string nome = this.nome;

            string cnpj = this.cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            string? email = this.email;

            string telefone = this.telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            foreach (Fornecedor fornecedor in fornecedores)
            {

                if (fornecedor.nome == nome)
                {

                    mensagem = "Já existe um(a) fornecedor(a) com esse nome! Altere-o e tente novamente.";

                    break;

                }

                else if (fornecedor.cnpj == cnpj)
                {

                    mensagem = "Já existe um(a) fornecedor(a) com esse CNPJ! Altere-o e tente novamente.";

                    break;

                }

                else if (fornecedor.email == email)
                {

                    mensagem = "Já existe um(a) fornecedor(a) com esse E-mail! Altere-o e tente novamente.";

                    break;

                }

                else if (fornecedor.telefone == telefone)
                {

                    mensagem = "Já existe um(a) fornecedor(a) com esse telefone! Altere-o e tente novamente.";

                    break;

                }

            }

            return mensagem;

        }

        public async Task<bool>? Save()
        {

            string verificacao_repeticao = await VerifyExistence();

            if (String.IsNullOrWhiteSpace(this.nome) || String.IsNullOrWhiteSpace(this.cnpj) ||
                String.IsNullOrWhiteSpace(this.telefone))
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else if (!Global.CNPJ_Validation(this.cnpj))
            {

                throw new Exception("CNPJ inválido! Revise-o e tente novamente.");

            }

            else if (!Global.Telephone_Validation(this.telefone))
            {

                throw new Exception("Um telefone possui de 10 a 11 dígitos! Revise-o e tente novamente.");

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

                    Model.Fornecedor fornecedor_retornado = await Data_Service_Fornecedor.SaveAsyncFornecedor(this);

                    if (fornecedor_retornado != null)
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

            bool exito = await Data_Service_Fornecedor.EnableAsyncFornecedor(id);

            if (exito)
            {

                MessageBox.Show("Fornecedor(a) reativado(a) com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível reativar o(a) fornecedor(a) selecionado(a)! Tente novamente mais tarde.");

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito = await Data_Service_Fornecedor.DisableAsyncFornecedor(id);

            if (exito)
            {

                MessageBox.Show("Fornecedor(a) desativado(a) com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível desativar o(a) fornecedor(a) selecionado(a)! Tente novamente mais tarde.");

            }

        }

        public static async Task<List<Fornecedor>>? GetList()
        {

            return await Data_Service_Fornecedor.GetListAsyncFornecedor();

        }

        public static async Task<List<Fornecedor>>? Search(string filtro)
        {

            return await Data_Service_Fornecedor.SearchAsyncFornecedor(filtro);

        }

    }

}