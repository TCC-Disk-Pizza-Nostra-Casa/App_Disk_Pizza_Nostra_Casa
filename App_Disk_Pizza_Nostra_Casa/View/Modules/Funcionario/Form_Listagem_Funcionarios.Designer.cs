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
            dgv_listagem_funcionarios_numero_linha = new DataGridViewTextBoxColumn();
            dgv_listagem_funcionarios_nome = new DataGridViewTextBoxColumn();
            dgv_listagem_funcionarios_email = new DataGridViewTextBoxColumn();
            dgv_listagem_funcionarios_contratacao = new DataGridViewTextBoxColumn();
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
            btn_pesquisar_funcionario.Location = new Point(749, 11);
            btn_pesquisar_funcionario.Name = "btn_pesquisar_funcionario";
            btn_pesquisar_funcionario.Size = new Size(23, 23);
            btn_pesquisar_funcionario.TabIndex = 5;
            btn_pesquisar_funcionario.UseVisualStyleBackColor = false;
            btn_pesquisar_funcionario.Click += btn_pesquisar_funcionario_Click;
            // 
            // txt_pesquisar_funcionario
            // 
            txt_pesquisar_funcionario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_funcionario.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_funcionario.Cursor = Cursors.IBeam;
            txt_pesquisar_funcionario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_funcionario.Location = new Point(118, 12);
            txt_pesquisar_funcionario.Name = "txt_pesquisar_funcionario";
            txt_pesquisar_funcionario.PlaceholderText = "Digite o nome do funcionário...";
            txt_pesquisar_funcionario.Size = new Size(625, 22);
            txt_pesquisar_funcionario.TabIndex = 4;
            // 
            // lbl_pesquisar_funcionario
            // 
            lbl_pesquisar_funcionario.AutoSize = true;
            lbl_pesquisar_funcionario.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pesquisar_funcionario.Location = new Point(12, 12);
            lbl_pesquisar_funcionario.Name = "lbl_pesquisar_funcionario";
            lbl_pesquisar_funcionario.Size = new Size(100, 22);
            lbl_pesquisar_funcionario.TabIndex = 6;
            lbl_pesquisar_funcionario.Text = "Pesquisar:";
            // 
            // dgv_listagem_funcionarios
            // 
            dgv_listagem_funcionarios.AllowUserToAddRows = false;
            dgv_listagem_funcionarios.AllowUserToDeleteRows = false;
            dgv_listagem_funcionarios.AllowUserToOrderColumns = true;
            dgv_listagem_funcionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_funcionarios.BackgroundColor = Color.Gray;
            dgv_listagem_funcionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_funcionarios.Columns.AddRange(new DataGridViewColumn[] { dgv_listagem_funcionarios_numero_linha, dgv_listagem_funcionarios_nome, dgv_listagem_funcionarios_email, dgv_listagem_funcionarios_contratacao });
            dgv_listagem_funcionarios.Location = new Point(12, 48);
            dgv_listagem_funcionarios.MultiSelect = false;
            dgv_listagem_funcionarios.Name = "dgv_listagem_funcionarios";
            dgv_listagem_funcionarios.ReadOnly = true;
            dgv_listagem_funcionarios.RowTemplate.Height = 25;
            dgv_listagem_funcionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_funcionarios.Size = new Size(760, 400);
            dgv_listagem_funcionarios.TabIndex = 3;
            dgv_listagem_funcionarios.CellContentClick += dgv_listagem_funcionarios_CellContentClick;
            // 
            // dgv_listagem_funcionarios_numero_linha
            // 
            dgv_listagem_funcionarios_numero_linha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_funcionarios_numero_linha.DividerWidth = 2;
            dgv_listagem_funcionarios_numero_linha.FillWeight = 44.31297F;
            dgv_listagem_funcionarios_numero_linha.HeaderText = "Nº:";
            dgv_listagem_funcionarios_numero_linha.Name = "dgv_listagem_funcionarios_numero_linha";
            dgv_listagem_funcionarios_numero_linha.ReadOnly = true;
            dgv_listagem_funcionarios_numero_linha.ToolTipText = "Numeração das linhas da tabela.";
            // 
            // dgv_listagem_funcionarios_nome
            // 
            dgv_listagem_funcionarios_nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_funcionarios_nome.DividerWidth = 2;
            dgv_listagem_funcionarios_nome.FillWeight = 187.9669F;
            dgv_listagem_funcionarios_nome.HeaderText = "Nome Completo:";
            dgv_listagem_funcionarios_nome.Name = "dgv_listagem_funcionarios_nome";
            dgv_listagem_funcionarios_nome.ReadOnly = true;
            dgv_listagem_funcionarios_nome.Resizable = DataGridViewTriState.True;
            dgv_listagem_funcionarios_nome.ToolTipText = "Nome completo do funcionário.";
            // 
            // dgv_listagem_funcionarios_email
            // 
            dgv_listagem_funcionarios_email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_funcionarios_email.DividerWidth = 2;
            dgv_listagem_funcionarios_email.FillWeight = 101.5229F;
            dgv_listagem_funcionarios_email.HeaderText = "E-Mail:";
            dgv_listagem_funcionarios_email.Name = "dgv_listagem_funcionarios_email";
            dgv_listagem_funcionarios_email.ReadOnly = true;
            dgv_listagem_funcionarios_email.ToolTipText = "E-Mail do funcionário.";
            // 
            // dgv_listagem_funcionarios_contratacao
            // 
            dgv_listagem_funcionarios_contratacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_funcionarios_contratacao.FillWeight = 66.19731F;
            dgv_listagem_funcionarios_contratacao.HeaderText = "Contratado em:";
            dgv_listagem_funcionarios_contratacao.Name = "dgv_listagem_funcionarios_contratacao";
            dgv_listagem_funcionarios_contratacao.ReadOnly = true;
            dgv_listagem_funcionarios_contratacao.ToolTipText = "Data de contratação do funcionário";
            // 
            // form_listagem_funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
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
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_numero_linha;
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_nome;
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_email;
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_contratacao;
    }
}