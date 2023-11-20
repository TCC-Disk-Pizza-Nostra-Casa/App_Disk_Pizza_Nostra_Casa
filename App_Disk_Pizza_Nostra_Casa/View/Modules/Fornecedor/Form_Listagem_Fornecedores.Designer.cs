namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{
    partial class form_listagem_fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listagem_fornecedores));
            btn_resetar = new Button();
            cbbox_condicao_fornecedor = new ComboBox();
            btn_voltar = new Button();
            btn_desativar = new Button();
            btn_reativar = new Button();
            btn_pesquisar_fornecedor = new Button();
            txt_pesquisar_fornecedor = new TextBox();
            lbl_pesquisar_fornecedor = new Label();
            dgv_listagem_fornecedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_fornecedores).BeginInit();
            SuspendLayout();
            // 
            // btn_resetar
            // 
            btn_resetar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_resetar.BackColor = Color.Transparent;
            btn_resetar.Cursor = Cursors.Hand;
            btn_resetar.FlatAppearance.BorderColor = Color.Black;
            btn_resetar.FlatAppearance.BorderSize = 2;
            btn_resetar.FlatStyle = FlatStyle.Flat;
            btn_resetar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_resetar.Location = new Point(134, 410);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(116, 39);
            btn_resetar.TabIndex = 6;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = false;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // cbbox_condicao_fornecedor
            // 
            cbbox_condicao_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbox_condicao_fornecedor.Cursor = Cursors.Hand;
            cbbox_condicao_fornecedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_condicao_fornecedor.FormattingEnabled = true;
            cbbox_condicao_fornecedor.Location = new Point(613, 53);
            cbbox_condicao_fornecedor.MaxLength = 9;
            cbbox_condicao_fornecedor.Name = "cbbox_condicao_fornecedor";
            cbbox_condicao_fornecedor.Size = new Size(159, 26);
            cbbox_condicao_fornecedor.TabIndex = 3;
            cbbox_condicao_fornecedor.SelectedIndexChanged += cbbox_condicao_fornecedor_SelectedIndexChanged;
            // 
            // btn_voltar
            // 
            btn_voltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_voltar.BackColor = Color.Transparent;
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.FlatAppearance.BorderColor = Color.Black;
            btn_voltar.FlatAppearance.BorderSize = 2;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_voltar.Location = new Point(12, 410);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(116, 39);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_desativar
            // 
            btn_desativar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_desativar.BackColor = Color.Transparent;
            btn_desativar.Cursor = Cursors.Hand;
            btn_desativar.FlatAppearance.BorderColor = Color.Black;
            btn_desativar.FlatAppearance.BorderSize = 2;
            btn_desativar.FlatStyle = FlatStyle.Flat;
            btn_desativar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_desativar.Location = new Point(534, 410);
            btn_desativar.Name = "btn_desativar";
            btn_desativar.Size = new Size(116, 39);
            btn_desativar.TabIndex = 7;
            btn_desativar.Text = "Desativar";
            btn_desativar.UseVisualStyleBackColor = false;
            btn_desativar.Click += btn_desativar_Click;
            // 
            // btn_reativar
            // 
            btn_reativar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reativar.BackColor = Color.Transparent;
            btn_reativar.Cursor = Cursors.Hand;
            btn_reativar.FlatAppearance.BorderColor = Color.Black;
            btn_reativar.FlatAppearance.BorderSize = 2;
            btn_reativar.FlatStyle = FlatStyle.Flat;
            btn_reativar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reativar.Location = new Point(656, 410);
            btn_reativar.Name = "btn_reativar";
            btn_reativar.Size = new Size(116, 39);
            btn_reativar.TabIndex = 8;
            btn_reativar.Text = "Reativar";
            btn_reativar.UseVisualStyleBackColor = false;
            btn_reativar.Click += btn_reativar_Click;
            // 
            // btn_pesquisar_fornecedor
            // 
            btn_pesquisar_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_fornecedor.BackColor = Color.Transparent;
            btn_pesquisar_fornecedor.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_fornecedor.BackgroundImage");
            btn_pesquisar_fornecedor.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_fornecedor.Cursor = Cursors.Hand;
            btn_pesquisar_fornecedor.FlatAppearance.BorderSize = 0;
            btn_pesquisar_fornecedor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_pesquisar_fornecedor.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_fornecedor.Location = new Point(749, 13);
            btn_pesquisar_fornecedor.Name = "btn_pesquisar_fornecedor";
            btn_pesquisar_fornecedor.Size = new Size(23, 23);
            btn_pesquisar_fornecedor.TabIndex = 2;
            btn_pesquisar_fornecedor.UseVisualStyleBackColor = false;
            btn_pesquisar_fornecedor.Click += btn_pesquisar_fornecedor_Click;
            // 
            // txt_pesquisar_fornecedor
            // 
            txt_pesquisar_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_fornecedor.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_fornecedor.Cursor = Cursors.IBeam;
            txt_pesquisar_fornecedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_fornecedor.Location = new Point(110, 12);
            txt_pesquisar_fornecedor.MaxLength = 255;
            txt_pesquisar_fornecedor.Name = "txt_pesquisar_fornecedor";
            txt_pesquisar_fornecedor.PlaceholderText = "Digite o nome do(a) fornecedor(a)...";
            txt_pesquisar_fornecedor.Size = new Size(633, 26);
            txt_pesquisar_fornecedor.TabIndex = 1;
            // 
            // lbl_pesquisar_fornecedor
            // 
            lbl_pesquisar_fornecedor.AutoSize = true;
            lbl_pesquisar_fornecedor.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pesquisar_fornecedor.Location = new Point(12, 14);
            lbl_pesquisar_fornecedor.Name = "lbl_pesquisar_fornecedor";
            lbl_pesquisar_fornecedor.Size = new Size(92, 19);
            lbl_pesquisar_fornecedor.TabIndex = 0;
            lbl_pesquisar_fornecedor.Text = "Pesquisar:";
            // 
            // dgv_listagem_fornecedores
            // 
            dgv_listagem_fornecedores.AllowUserToAddRows = false;
            dgv_listagem_fornecedores.AllowUserToDeleteRows = false;
            dgv_listagem_fornecedores.AllowUserToOrderColumns = true;
            dgv_listagem_fornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_fornecedores.BackgroundColor = Color.White;
            dgv_listagem_fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_fornecedores.Location = new Point(12, 96);
            dgv_listagem_fornecedores.MultiSelect = false;
            dgv_listagem_fornecedores.Name = "dgv_listagem_fornecedores";
            dgv_listagem_fornecedores.ReadOnly = true;
            dgv_listagem_fornecedores.RowHeadersWidth = 51;
            dgv_listagem_fornecedores.RowTemplate.Height = 25;
            dgv_listagem_fornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_fornecedores.Size = new Size(760, 296);
            dgv_listagem_fornecedores.TabIndex = 4;
            dgv_listagem_fornecedores.CellClick += dgv_listagem_fornecedores_CellClick;
            dgv_listagem_fornecedores.CellDoubleClick += dgv_listagem_fornecedores_CellDoubleClick;
            // 
            // form_listagem_fornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_resetar);
            Controls.Add(cbbox_condicao_fornecedor);
            Controls.Add(btn_voltar);
            Controls.Add(btn_desativar);
            Controls.Add(btn_reativar);
            Controls.Add(btn_pesquisar_fornecedor);
            Controls.Add(txt_pesquisar_fornecedor);
            Controls.Add(lbl_pesquisar_fornecedor);
            Controls.Add(dgv_listagem_fornecedores);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "form_listagem_fornecedores";
            Text = "Listagem de Fornecedores";
            Load += Form_Listagem_Fornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_fornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_resetar;
        private ComboBox cbbox_condicao_fornecedor;
        private Button btn_voltar;
        private Button btn_desativar;
        private Button btn_reativar;
        private Button btn_pesquisar_fornecedor;
        private TextBox txt_pesquisar_fornecedor;
        private Label lbl_pesquisar_fornecedor;
        private DataGridView dgv_listagem_fornecedores;
    }
}