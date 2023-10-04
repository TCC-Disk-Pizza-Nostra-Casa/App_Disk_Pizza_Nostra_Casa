namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Produto
{
    partial class form_listagem_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listagem_produtos));
            btn_resetar = new Button();
            cbbox_condicao_produto = new ComboBox();
            btn_voltar = new Button();
            btn_desativar = new Button();
            btn_reativar = new Button();
            btn_pesquisar_produto = new Button();
            txt_pesquisar_produto = new TextBox();
            lbl_pesquisar_produto = new Label();
            dgv_listagem_produtos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_produtos).BeginInit();
            SuspendLayout();
            // 
            // btn_resetar
            // 
            btn_resetar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_resetar.BackColor = Color.Transparent;
            btn_resetar.FlatAppearance.BorderColor = Color.Black;
            btn_resetar.FlatAppearance.BorderSize = 2;
            btn_resetar.FlatStyle = FlatStyle.Flat;
            btn_resetar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_resetar.Location = new Point(134, 410);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(116, 39);
            btn_resetar.TabIndex = 48;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = false;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // cbbox_condicao_produto
            // 
            cbbox_condicao_produto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbox_condicao_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_condicao_produto.FormattingEnabled = true;
            cbbox_condicao_produto.Location = new Point(613, 53);
            cbbox_condicao_produto.Name = "cbbox_condicao_produto";
            cbbox_condicao_produto.Size = new Size(159, 26);
            cbbox_condicao_produto.TabIndex = 47;
            cbbox_condicao_produto.SelectedIndexChanged += cbbox_condicao_produto_SelectedIndexChanged;
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
            btn_voltar.TabIndex = 46;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
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
            btn_desativar.TabIndex = 45;
            btn_desativar.Text = "Desativar";
            btn_desativar.UseVisualStyleBackColor = false;
            btn_desativar.Click += btn_desativar_Click;
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
            btn_reativar.TabIndex = 44;
            btn_reativar.Text = "Reativar";
            btn_reativar.UseVisualStyleBackColor = false;
            btn_reativar.Click += btn_reativar_Click;
            // 
            // btn_pesquisar_produto
            // 
            btn_pesquisar_produto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_produto.BackColor = Color.Transparent;
            btn_pesquisar_produto.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_produto.BackgroundImage");
            btn_pesquisar_produto.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_produto.FlatAppearance.BorderSize = 0;
            btn_pesquisar_produto.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_produto.Location = new Point(749, 13);
            btn_pesquisar_produto.Name = "btn_pesquisar_produto";
            btn_pesquisar_produto.Size = new Size(23, 23);
            btn_pesquisar_produto.TabIndex = 42;
            btn_pesquisar_produto.UseVisualStyleBackColor = false;
            btn_pesquisar_produto.Click += btn_pesquisar_produto_Click;
            // 
            // txt_pesquisar_produto
            // 
            txt_pesquisar_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_produto.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_produto.Cursor = Cursors.IBeam;
            txt_pesquisar_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_produto.Location = new Point(110, 12);
            txt_pesquisar_produto.Name = "txt_pesquisar_produto";
            txt_pesquisar_produto.PlaceholderText = "Digite o nome do produto...";
            txt_pesquisar_produto.Size = new Size(633, 26);
            txt_pesquisar_produto.TabIndex = 41;
            // 
            // lbl_pesquisar_produto
            // 
            lbl_pesquisar_produto.AutoSize = true;
            lbl_pesquisar_produto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pesquisar_produto.Location = new Point(12, 14);
            lbl_pesquisar_produto.Name = "lbl_pesquisar_produto";
            lbl_pesquisar_produto.Size = new Size(92, 19);
            lbl_pesquisar_produto.TabIndex = 43;
            lbl_pesquisar_produto.Text = "Pesquisar:";
            // 
            // dgv_listagem_produtos
            // 
            dgv_listagem_produtos.AllowUserToAddRows = false;
            dgv_listagem_produtos.AllowUserToDeleteRows = false;
            dgv_listagem_produtos.AllowUserToOrderColumns = true;
            dgv_listagem_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_produtos.BackgroundColor = Color.White;
            dgv_listagem_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_produtos.Location = new Point(12, 96);
            dgv_listagem_produtos.MultiSelect = false;
            dgv_listagem_produtos.Name = "dgv_listagem_produtos";
            dgv_listagem_produtos.ReadOnly = true;
            dgv_listagem_produtos.RowHeadersWidth = 51;
            dgv_listagem_produtos.RowTemplate.Height = 25;
            dgv_listagem_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_produtos.Size = new Size(760, 301);
            dgv_listagem_produtos.TabIndex = 40;
            dgv_listagem_produtos.CellDoubleClick += dgv_listagem_produtos_CellDoubleClick;
            // 
            // form_listagem_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_resetar);
            Controls.Add(cbbox_condicao_produto);
            Controls.Add(btn_voltar);
            Controls.Add(btn_desativar);
            Controls.Add(btn_reativar);
            Controls.Add(btn_pesquisar_produto);
            Controls.Add(txt_pesquisar_produto);
            Controls.Add(lbl_pesquisar_produto);
            Controls.Add(dgv_listagem_produtos);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "form_listagem_produtos";
            Text = "Listagem de Produtos";
            Load += form_listagem_produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_resetar;
        private ComboBox cbbox_condicao_produto;
        private Button btn_voltar;
        private Button btn_desativar;
        private Button btn_reativar;
        private Button btn_pesquisar_produto;
        private TextBox txt_pesquisar_produto;
        private Label lbl_pesquisar_produto;
        private DataGridView dgv_listagem_produtos;
    }
}