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

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Cliente
{

    public partial class form_cadastro_clientes : Form
    {

        public Model.Cliente? cliente_selecionado = null;

        public form_cadastro_clientes()
        {

            InitializeComponent();

        }

        private void form_cadastro_clientes_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                cbbox_sexo.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_estado_civil.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_sexo.DataSource = new string[] { "Masculino", "Feminino", "Não informar" };

                cbbox_estado_civil.DataSource = new string[] { "Solteiro(a)", "Casado(a)", "Separado(a)", "Divorciado(a)", "Viúvo(a)", };

                Form_Fill();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Form_Fill()
        {

            if (this.cliente_selecionado != null)
            {

                txt_nome.Text = this.cliente_selecionado.nome;

                cbbox_sexo.Text = this.cliente_selecionado.sexo;

                cbbox_estado_civil.Text = this.cliente_selecionado.estado_civil;

                mtxt_cpf.Text = this.cliente_selecionado.cpf;

                mtxt_cep.Text = this.cliente_selecionado.cep;

                txt_email.Text = this.cliente_selecionado.email;

                mtxt_telefone.Text = this.cliente_selecionado.telefone;

                dtpck_data_nascimento.Value = DateTime.Parse(this.cliente_selecionado.data_nascimento);

                txt_observacoes.Text = this.cliente_selecionado.observacoes;

            }

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {

                string[] masks = { mtxt_cpf.Mask, mtxt_cep.Mask, mtxt_telefone.Mask };

                mtxt_cpf.Mask = "";

                mtxt_cep.Mask = "";

                mtxt_telefone.Mask = "";

                Model.Cliente dados = new Model.Cliente()
                {

                    id = (this.cliente_selecionado != null) ? this.cliente_selecionado.id : 0,

                    nome = txt_nome.Text,

                    sexo = (cbbox_sexo.Text == "Não informar") ? "Não informado" : cbbox_sexo.Text,

                    estado_civil = cbbox_estado_civil.Text,

                    cpf = mtxt_cpf.Text,

                    cep = mtxt_cep.Text,

                    email = (String.IsNullOrEmpty(txt_email.Text)) ? "Não informado" : txt_email.Text,

                    telefone = mtxt_telefone.Text,

                    data_nascimento = dtpck_data_nascimento.Value.ToString("yyyy-MM-dd"),

                    observacoes = (String.IsNullOrEmpty(txt_observacoes.Text)) ? "Nenhuma observação" : txt_observacoes.Text

                };

                mtxt_cpf.Mask = masks[0];

                mtxt_cep.Mask = masks[1];

                mtxt_telefone.Mask = masks[2];

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