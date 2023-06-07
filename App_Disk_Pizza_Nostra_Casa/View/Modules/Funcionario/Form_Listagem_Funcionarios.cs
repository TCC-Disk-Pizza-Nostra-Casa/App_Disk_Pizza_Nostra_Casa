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

    public partial class form_listagem_funcionarios : Form
    {

        public form_listagem_funcionarios()
        {

            InitializeComponent();

        }

        private async void form_listagem_funcionarios_Load(object sender, EventArgs e)
        {

            try
            {

                this.MinimumSize = new Size(800, 500);

                this.Size = new Size(800, 500);

                List<Model.Funcionario> lista_funcionarios = await Data_Service_Funcionario.GetListAsyncFuncionario();

                if(lista_funcionarios.Count > 0)
                {

                    for(int i = 0; i < lista_funcionarios.Count; i++)
                    {

                        string nome = lista_funcionarios[i].nome;

                        string email = lista_funcionarios[i].email;

                        string data_contratacao = lista_funcionarios[i].data_cadastro.ToString();

                        dgv_listagem_funcionarios.Rows.Add(i + 1, nome, email, data_contratacao);

                    }

                }

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_pesquisar_funcionario_Click(object sender, EventArgs e)
        {

            try
            {



            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
