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

        public string telefone { get; set; }

        public string? observacoes { get; set; }

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string data_modificacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo { get; set; } = 1;

        public async Task<bool>? Save()
        {

            if (String.IsNullOrEmpty(this.nome) || String.IsNullOrEmpty(this.cnpj) ||
                String.IsNullOrEmpty(this.telefone))
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else if (!Global.CNPJValidation(this.cnpj))
            {

                throw new Exception("CNPJ inválido! Revise-o e tente novamente.");

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

                MessageBox.Show("Fornecedor reativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível reativar o fornecedor selecionado! Tente novamente mais tarde.");

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito = await Data_Service_Fornecedor.DisableAsyncFornecedor(id);

            if (exito)
            {

                MessageBox.Show("Fornecedor desativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível desativar o fornecedor selecionado! Tente novamente mais tarde.");

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