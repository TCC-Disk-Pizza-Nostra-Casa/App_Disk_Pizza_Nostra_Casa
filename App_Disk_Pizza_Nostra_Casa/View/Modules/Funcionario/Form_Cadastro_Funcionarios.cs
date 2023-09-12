using System;
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

        public Model.Funcionario usuario_sessao;

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

                /*cbbox_genero.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_cargo.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_genero.DataSource = new string[] { "Selecione uma opção", "Masculino", "Feminino", "Não informar" };

                cbbox_cargo.DataSource = new string[] { "Selecione uma opção", "Balconista" };

                if (this.usuario_sessao != null)
                {

                    Preencher_Formulario(this.usuario_sessao);

                }*/

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /*private void Preencher_Formulario(Model.Funcionario dados)
        {

            txt_nome.Text = dados.nome;

            cbbox_genero.Text = dados.genero;

            mtxt_cpf.Text = dados.cpf;

            mtxt_rg.Text = dados.rg;

            cbbox_cargo.Text = dados.cargo;

            mtxt_cep.Text = dados.cep;

            txt_email.Text = dados.email;

            mtxt_telefone.Text = dados.telefone;

            txt_observacoes.Text = dados.observacoes;

            ckbox_administrador.Checked = Convert.ToBoolean(dados.administrador);

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {

                Model.Funcionario dados = new Model.Funcionario()
                {

                    nome = txt_nome.Text,

                    indice_genero = cbbox_genero.SelectedIndex,

                    genero = cbbox_genero.Text,

                    cpf = mtxt_cpf.Text.Replace(".", "").Replace("-", ""),

                    rg = mtxt_rg.Text.Replace(".", "").Replace("-", ""),

                    indice_cargo = cbbox_cargo.SelectedIndex,

                    cargo = cbbox_cargo.Text,

                    cep = mtxt_cep.Text.Replace("-", ""),

                    email = txt_email.Text,

                    telefone = mtxt_telefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""),

                    senha = txt_senha.Text,

                    observacoes = txt_observacoes.Text,

                    administrador = (ckbox_administrador.Checked) ? 1 : 0

                };

                Model.Funcionario usuario_retornado = await dados.Save();

                if (usuario_retornado.id != null)
                {

                    MessageBox.Show("Dados salvos com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Close();

                }

                else
                {

                    throw new Exception("Não foi possível salvar estes dados! Revise-os e tente novamente.");

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

        }*/

    }

}