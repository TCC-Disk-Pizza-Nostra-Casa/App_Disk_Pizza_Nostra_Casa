namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Funcionario
{
    partial class form_listagem_funcionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listagem_funcionarios));
            btn_pesquisar_funcionario = new Button();
            txt_pesquisar_funcionario = new TextBox();
            lbl_pesquisar_funcionario = new Label();
            dgv_listagem_funcionarios = new DataGridView();
            btn_desativar = new Button();
            btn_reativar = new Button();
            btn_voltar = new Button();
            cbbox_condicao_funcionario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_funcionarios).BeginInit();
            SuspendLayout();
            // 
            // btn_pesquisar_funcionario
            // 
            btn_pesquisar_funcionario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_funcionario.BackColor = Color.Transparent;
            btn_pesquisar_funcionario.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_funcionario.BackgroundImage");
            btn_pesquisar_funcionario.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_funcionario.FlatAppearance.BorderSize = 0;
            btn_pesquisar_funcionario.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_funcionario.Location = new Point(749, 13);
            btn_pesquisar_funcionario.Name = "btn_pesquisar_funcionario";
            btn_pesquisar_funcionario.Size = new Size(23, 23);
            btn_pesquisar_funcionario.TabIndex = 5;
            btn_pesquisar_funcionario.UseVisualStyleBackColor = false;
            // 
            // txt_pesquisar_funcionario
            // 
            txt_pesquisar_funcionario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_funcionario.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_funcionario.Cursor = Cursors.IBeam;
            txt_pesquisar_funcionario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_funcionario.Location = new Point(110, 12);
            txt_pesquisar_funcionario.Name = "txt_pesquisar_funcionario";
            txt_pesquisar_funcionario.PlaceholderText = "Digite o nome do funcionário...";
            txt_pesquisar_funcionario.Size = new Size(633, 26);
            txt_pesquisar_funcionario.TabIndex = 4;
            // 
            // lbl_pesquisar_funcionario
            // 
            lbl_pesquisar_funcionario.AutoSize = true;
            lbl_pesquisar_funcionario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pesquisar_funcionario.Location = new Point(12, 14);
            lbl_pesquisar_funcionario.Name = "lbl_pesquisar_funcionario";
            lbl_pesquisar_funcionario.Size = new Size(92, 19);
            lbl_pesquisar_funcionario.TabIndex = 6;
            lbl_pesquisar_funcionario.Text = "Pesquisar:";
            // 
            // dgv_listagem_funcionarios
            // 
            dgv_listagem_funcionarios.AllowUserToAddRows = false;
            dgv_listagem_funcionarios.AllowUserToDeleteRows = false;
            dgv_listagem_funcionarios.AllowUserToOrderColumns = true;
            dgv_listagem_funcionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_funcionarios.BackgroundColor = Color.White;
            dgv_listagem_funcionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_funcionarios.Location = new Point(12, 92);
            dgv_listagem_funcionarios.MultiSelect = false;
            dgv_listagem_funcionarios.Name = "dgv_listagem_funcionarios";
            dgv_listagem_funcionarios.ReadOnly = true;
            dgv_listagem_funcionarios.RowHeadersWidth = 51;
            dgv_listagem_funcionarios.RowTemplate.Height = 25;
            dgv_listagem_funcionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_funcionarios.Size = new Size(760, 299);
            dgv_listagem_funcionarios.TabIndex = 3;
            // 
            // btn_desativar
            // 
            btn_desativar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_desativar.BackColor = Color.Transparent;
            btn_desativar.FlatAppearance.BorderColor = Color.Black;
            btn_desativar.FlatAppearance.BorderSize = 2;
            btn_desativar.FlatStyle = FlatStyle.Flat;
            btn_desativar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_desativar.Location = new Point(534, 410);
            btn_desativar.Name = "btn_desativar";
            btn_desativar.Size = new Size(116, 39);
            btn_desativar.TabIndex = 36;
            btn_desativar.Text = "Desativar";
            btn_desativar.UseVisualStyleBackColor = false;
            // 
            // btn_reativar
            // 
            btn_reativar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reativar.BackColor = Color.Transparent;
            btn_reativar.FlatAppearance.BorderColor = Color.Black;
            btn_reativar.FlatAppearance.BorderSize = 2;
            btn_reativar.FlatStyle = FlatStyle.Flat;
            btn_reativar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reativar.Location = new Point(656, 410);
            btn_reativar.Name = "btn_reativar";
            btn_reativar.Size = new Size(116, 39);
            btn_reativar.TabIndex = 35;
            btn_reativar.Text = "Reativar";
            btn_reativar.UseVisualStyleBackColor = false;
            // 
            // btn_voltar
            // 
            btn_voltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_voltar.BackColor = Color.Transparent;
            btn_voltar.FlatAppearance.BorderColor = Color.Black;
            btn_voltar.FlatAppearance.BorderSize = 2;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_voltar.Location = new Point(12, 410);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(116, 39);
            btn_voltar.TabIndex = 37;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // cbbox_condicao_funcionario
            // 
            cbbox_condicao_funcionario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbox_condicao_funcionario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_condicao_funcionario.FormattingEnabled = true;
            cbbox_condicao_funcionario.Location = new Point(613, 53);
            cbbox_condicao_funcionario.Name = "cbbox_condicao_funcionario";
            cbbox_condicao_funcionario.Size = new Size(159, 26);
            cbbox_condicao_funcionario.TabIndex = 38;
            // 
            // form_listagem_funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(cbbox_condicao_funcionario);
            Controls.Add(btn_voltar);
            Controls.Add(btn_desativar);
            Controls.Add(btn_reativar);
            Controls.Add(btn_pesquisar_funcionario);
            Controls.Add(txt_pesquisar_funcionario);
            Controls.Add(lbl_pesquisar_funcionario);
            Controls.Add(dgv_listagem_funcionarios);
            MinimumSize = new Size(800, 500);
            Name = "form_listagem_funcionarios";
            Text = "Listagem de Funcionários";
            Load += form_listagem_funcionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_funcionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pesquisar_funcionario;
        private TextBox txt_pesquisar_funcionario;
        private Label lbl_pesquisar_funcionario;
        private DataGridView dgv_listagem_funcionarios;
        private Button btn_desativar;
        private Button btn_reativar;
        private Button btn_voltar;
        private ComboBox cbbox_condicao_funcionario;
    }
}