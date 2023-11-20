using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Venda
{

    public partial class form_confirmacao_venda : Form
    {

        public int[]? ids_envolvidos = null;

        public List<int>? ids_itens_venda = null;

        public List<int>? quantidades_itens_venda = null;

        public List<double>? valores_itens_venda = null;

        private double valor_total = 0;

        public form_adicionar_venda? form_venda_atual = null;

        public form_confirmacao_venda()
        {

            InitializeComponent();

        }

        private void form_confirmacao_venda_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(400, 400);

                this.MaximumSize = new Size(400, 400);

                this.Size = new Size(400, 400);

                Calculate_Total_Value();

                lbl_valor_total.Text = "Valor Total: " + this.valor_total.ToString("C2");

                cbbox_tipo_consumo.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_tipo_consumo.DataSource = new string[] { "Presencial (No local)", "Delivery (Entrega)" };

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Calculate_Total_Value()
        {

            try
            {

                for (int i = 0; i < this.valores_itens_venda.Count; i++)
                {

                    this.valor_total += this.valores_itens_venda[i];

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

                Model.Venda dados = new Model.Venda()
                {

                    id = 0,

                    delivery = cbbox_tipo_consumo.SelectedIndex,

                    valor_total = this.valor_total,

                    observacoes = (String.IsNullOrWhiteSpace(txt_observacoes.Text)) ? "Nenhuma observação" : txt_observacoes.Text,

                    fk_funcionario = this.ids_envolvidos[0],

                    fk_cliente = this.ids_envolvidos[1]

                };

                Model.Venda retorno = await dados.Save();

                if (retorno != null && retorno.id != null)
                {

                    int itens_cadastrados_sucesso = 0;

                    for (int i = 0; i < this.ids_itens_venda.Count; i++)
                    {

                        Model.Venda_Produto_Assoc item_venda = new Model.Venda_Produto_Assoc()
                        {

                            fk_venda = retorno.id,

                            fk_produto = this.ids_itens_venda[i],

                            quantidade_produto = this.quantidades_itens_venda[i],

                            valor_total_item_venda = this.valores_itens_venda[i]

                        };

                        if (await item_venda.Save())
                        {

                            itens_cadastrados_sucesso++;

                        }

                    }

                    if (itens_cadastrados_sucesso == this.ids_itens_venda.Count)
                    {

                        this.form_venda_atual.Close();

                        this.Close();

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}