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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Funcionario
{

    public partial class form_cadastro_funcionarios : Form
    {

        public bool condicao_administrador = true;

        public bool cadastro = true;

        public form_cadastro_funcionarios()
        {

            InitializeComponent();

        }

        private void form_cadastro_funcionarios_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_sexo.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_estado_civil.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_sexo.DataSource = new string[] { "Masculino", "Feminino", "Não informar" };

                cbbox_estado_civil.DataSource = new string[] { "Solteiro(a)", "Casado(a)", "Separado(a)", "Divorciado(a)", "Viúvo(a)", };

                ckbox_administrador.Visible = this.condicao_administrador;

                Form_Fill();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Form_Fill()
        {

            try
            {

                if (!this.cadastro && Global.usuario_sessao != null)
                {

                    txt_nome.Text = Global.usuario_sessao.nome;

                    cbbox_sexo.Text = Global.usuario_sessao.sexo;

                    cbbox_estado_civil.Text = Global.usuario_sessao.estado_civil;

                    mtxt_cpf.Text = Global.usuario_sessao.cpf;

                    mtxt_cep.Text = Global.usuario_sessao.cep;

                    txt_email.Text = Global.usuario_sessao.email;

                    mtxt_telefone.Text = Global.usuario_sessao.telefone;

                    txt_observacoes.Text = Global.usuario_sessao.observacoes;

                    ckbox_administrador.Checked = Convert.ToBoolean(Global.usuario_sessao.administrador);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {

                if (this.cadastro && !Global.administrador)
                {

                    throw new Exception("O usuário atual não tem a permissão necessária para executar essa ação.");

                }

                else
                {

                    string[] masks = { mtxt_cpf.Mask, mtxt_cep.Mask, mtxt_telefone.Mask };

                    mtxt_cpf.Mask = "";

                    mtxt_cep.Mask = "";

                    mtxt_telefone.Mask = "";

                    Model.Funcionario dados = new Model.Funcionario()
                    {

                        id = (!this.cadastro && Global.usuario_sessao != null) ? Global.usuario_sessao.id : 0,

                        nome = txt_nome.Text,

                        sexo = (cbbox_sexo.SelectedIndex == 2) ? "Não informado" : cbbox_sexo.Text,

                        estado_civil = cbbox_estado_civil.Text,

                        cpf = mtxt_cpf.Text,

                        cep = mtxt_cep.Text,

                        email = (String.IsNullOrWhiteSpace(txt_email.Text)) ? "Não informado" : txt_email.Text,

                        telefone = mtxt_telefone.Text,

                        senha = txt_senha.Text,

                        confirmacao_senha = txt_confirmar_senha.Text,

                        observacoes = (String.IsNullOrWhiteSpace(txt_observacoes.Text)) ? "Nenhuma observação" : txt_observacoes.Text,

                        administrador = (ckbox_administrador.Checked) ? 1 : 0

                    };

                    mtxt_cpf.Mask = masks[0];

                    mtxt_cep.Mask = masks[1];

                    mtxt_telefone.Mask = masks[2];

                    if (await dados.Save())
                    {

                        if (!this.cadastro && Global.usuario_sessao != null)
                        {

                            Global.usuario_sessao = (await Model.Funcionario.Search(txt_nome.Text))[0];

                        }

                        this.Close();

                    }

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