﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class Produto
    {

        public int id { get; set; }

        public string nome { get; set; }

        public int estoque { get; set; }

        public double preco { get; set; }

        public string tamanho { get; set; }

        public string categoria { get; set; }

        public string? observacoes { get; set; } = null;

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string data_modificacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public int ativo = 1;

        public int fk_fornecedor { get; set; } = 0;

        public async Task<bool>? Save()
        {

            if (String.IsNullOrEmpty(this.nome) || this.estoque < 1 ||
                String.IsNullOrEmpty(this.preco.ToString()) || String.IsNullOrEmpty(this.tamanho) ||
                String.IsNullOrEmpty(this.categoria) || this.fk_fornecedor < 1)
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else
            {

                if (MessageBox.Show("Realmente deseja salvar esses dados?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Model.Produto produto_retornado = await Data_Service_Produto.SaveAsyncProduto(this);

                    if (produto_retornado != null)
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

            bool exito = await Data_Service_Produto.EnableAsyncProduto(id);

            if (exito)
            {

                MessageBox.Show("Produto reativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível reativar o produto selecionado! Tente novamente mais tarde.");

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito = await Data_Service_Produto.DisableAsyncProduto(id);

            if (exito)
            {

                MessageBox.Show("Produto desativado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;

            }

            else
            {

                throw new Exception("Não foi possível desativar o produto selecionado! Tente novamente mais tarde.");

            }

        }

        public static async Task<List<Produto>>? GetList()
        {

            return await Data_Service_Produto.GetListAsyncProduto();

        }

        public static async Task<List<Produto>>? Search(string filtro)
        {

            return await Data_Service_Produto.SearchAsyncProduto(filtro);

        }

    }

}