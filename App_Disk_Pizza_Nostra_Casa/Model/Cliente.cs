using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Cliente
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string sexo { get; set; }

        public string estado_civil { get; set; }

        public string cpf { get; set; }

        public string cep { get; set; }

        public string? email { get; set; }

        public string telefone { get; set; }

        public string data_nascimento { get; set; }

        public string? observacoes { get; set; }

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string data_modificacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo { get; set; } = 1;

        public async Task<bool>? Save()
        {

            if (String.IsNullOrEmpty(this.nome) || String.IsNullOrEmpty(this.sexo) ||
                String.IsNullOrEmpty(this.cpf) || String.IsNullOrEmpty(this.cep) ||
                String.IsNullOrEmpty(this.telefone) || String.IsNullOrEmpty(data_nascimento))
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

            else
            {

                if (MessageBox.Show("Realmente deseja salvar esses dados?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Model.Cliente cliente_retornado = await Data_Service_Cliente.SaveAsyncCliente(this);

                    if (cliente_retornado != null)
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

            bool exito = await Data_Service_Cliente.EnableAsyncCliente(id);

            if (exito)
            {

                MessageBox.Show("Cliente reativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível reativar o cliente selecionado! Tente novamente mais tarde.");

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito = await Data_Service_Cliente.DisableAsyncCliente(id);

            if (exito)
            {

                MessageBox.Show("Cliente desativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível desativar o cliente selecionado! Tente novamente mais tarde.");

            }

        }

        public static async Task<List<Cliente>>? GetList()
        {

            return await Data_Service_Cliente.GetListAsyncCliente();

        }

        public static async Task<List<Cliente>>? Search(string filtro)
        {

            return await Data_Service_Cliente.SearchAsyncCliente(filtro);

        }

    }

}