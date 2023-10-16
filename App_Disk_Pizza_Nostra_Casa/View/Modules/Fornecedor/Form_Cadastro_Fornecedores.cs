﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{

    public partial class form_cadastro_fornecedores : Form
    {

        public Model.Fornecedor? fornecedor_selecionado = null;

        public form_cadastro_fornecedores()
        {

            InitializeComponent();

        }

        private void Form_Cadastro_Fornecedor_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(800, 500);

            this.Size = new Size(800, 500);

            Form_Fill();

        }

        private void Form_Fill()
        {

            if (this.fornecedor_selecionado != null)
            {

                txt_nome.Text = this.fornecedor_selecionado.nome;

                mtxt_cnpj.Text = this.fornecedor_selecionado.cnpj;

                mtxt_telefone.Text = this.fornecedor_selecionado.telefone;

                txt_observacoes.Text = this.fornecedor_selecionado.observacoes;

            }

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {

                Model.Fornecedor dados = new Model.Fornecedor()
                {

                    id = (this.fornecedor_selecionado != null) ? this.fornecedor_selecionado.id : 0,

                    nome = txt_nome.Text,

                    cnpj = mtxt_cnpj.Text,

                    telefone = mtxt_telefone.Text,

                    observacoes = txt_observacoes.Text

                };

                if (await dados.Save())
                {

                    this.Close();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Deseja fechar este formulário?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.Close();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}