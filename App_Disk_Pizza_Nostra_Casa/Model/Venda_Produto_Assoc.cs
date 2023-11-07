using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Venda_Produto_Assoc
    {

        public int fk_venda { get; set; }

        public int fk_produto { get; set; }

        public int quantidade_produto { get; set; }

        public double valor_total_item_venda { get; set; }

        public int ativo { get; set; } = 1;

        public async Task<bool>? Save()
        {

            if (this.fk_venda < 1 || this.fk_produto < 1 ||
                this.quantidade_produto < 1 || this.valor_total_item_venda < 0)
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else
            {

                Model.Venda_Produto_Assoc item_retornado = await Data_Service_Venda_Produto_Assoc.SaveAsyncVendaProdutoAssoc(this);

                if (item_retornado != null)
                {

                    return true;

                }

                else
                {

                    return false;

                }

            }

        }

        public static async Task<bool>? Enable(int id)
        {

            bool exito = await Data_Service_Venda_Produto_Assoc.EnableAsyncVendaProdutoAssoc(id);

            return exito;

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito = await Data_Service_Venda_Produto_Assoc.DisableAsyncVendaProdutoAssoc(id);

            return exito;

        }

        public static async Task<List<Venda_Produto_Assoc>>? Search(int id_venda)
        {

            return await Data_Service_Venda_Produto_Assoc.SearchAsyncVendaProdutoAssoc(id_venda);

        }

    }

}
