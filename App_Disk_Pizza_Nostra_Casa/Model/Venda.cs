using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Venda
    {

        public int id { get; set; }

        public int delivery { get; set; } = 0;

        public double valor_total { get; set; }

        public string? observacoes { get; set; } = null;

        public string data_venda { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo = 1;

        public int fk_funcionario { get; set; }

        public int fk_cliente { get; set; }

        public async Task<bool>? Save()
        {

            if (this.fk_funcionario < 1 || this.fk_cliente < 1)
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else
            {

                if (MessageBox.Show("Realmente deseja salvar esses dados?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Model.Venda venda_retornada = await Data_Service_Venda.SaveAsyncVenda(this);

                    if (venda_retornada.id != null)
                    {

                        MessageBox.Show("Dados salvos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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

            bool exito = await Data_Service_Venda.EnableAsyncVenda(id);

            if (exito)
            {

                MessageBox.Show("Venda reativada com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível reativar a venda selecionada! Tente novamente mais tarde.");

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito = await Data_Service_Venda.DisableAsyncVenda(id);

            if (exito)
            {

                MessageBox.Show("Venda desativada com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível desativar a venda selecionada! Tente novamente mais tarde.");

            }

        }

        public static async Task<List<Venda>>? GetList()
        {

            return await Data_Service_Venda.GetListAsyncVenda();

        }

        public static async Task<List<Venda>>? Search(int[] dados_pesquisa)
        {

            return await Data_Service_Venda.SearchAsyncVenda(dados_pesquisa);

        }

    }

}