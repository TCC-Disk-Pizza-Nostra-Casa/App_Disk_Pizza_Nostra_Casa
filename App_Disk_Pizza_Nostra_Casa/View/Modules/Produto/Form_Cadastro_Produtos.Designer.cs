namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Produto
{
    partial class form_cadastro_produtos
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
            btn_cancelar = new Button();
            btn_salvar = new Button();
            txt_observacoes = new TextBox();
            lbl_nome = new Label();
            lbl_fornecedor = new Label();
            cbbox_fornecedor = new ComboBox();
            lbl_estoque = new Label();
            txt_preco = new TextBox();
            lbl_preco = new Label();
            txt_nome = new TextBox();
            lbl_observacoes = new Label();
            nud_estoque = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_estoque).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar.FlatAppearance.BorderSize = 2;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(534, 410);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(116, 39);
            btn_cancelar.TabIndex = 45;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salvar.BackColor = Color.Transparent;
            btn_salvar.FlatAppearance.BorderColor = Color.Black;
            btn_salvar.FlatAppearance.BorderSize = 2;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.Location = new Point(656, 410);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(116, 39);
            btn_salvar.TabIndex = 44;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.Location = new Point(12, 217);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira observações sobre o produto...(campo não obrigatório).";
            txt_observacoes.Size = new Size(760, 177);
            txt_observacoes.TabIndex = 42;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(12, 15);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 19);
            lbl_nome.TabIndex = 56;
            lbl_nome.Text = "Nome:";
            lbl_nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_fornecedor
            // 
            lbl_fornecedor.BackColor = Color.Transparent;
            lbl_fornecedor.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_fornecedor.Location = new Point(12, 135);
            lbl_fornecedor.Name = "lbl_fornecedor";
            lbl_fornecedor.Size = new Size(109, 26);
            lbl_fornecedor.TabIndex = 55;
            lbl_fornecedor.Text = "Fornecedor:";
            lbl_fornecedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbox_fornecedor
            // 
            cbbox_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_fornecedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_fornecedor.FormattingEnabled = true;
            cbbox_fornecedor.Location = new Point(127, 135);
            cbbox_fornecedor.Name = "cbbox_fornecedor";
            cbbox_fornecedor.Size = new Size(645, 26);
            cbbox_fornecedor.TabIndex = 54;
            // 
            // lbl_estoque
            // 
            lbl_estoque.BackColor = Color.Transparent;
            lbl_estoque.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_estoque.Location = new Point(12, 94);
            lbl_estoque.Name = "lbl_estoque";
            lbl_estoque.Size = new Size(82, 26);
            lbl_estoque.TabIndex = 53;
            lbl_estoque.Text = "Estoque:";
            lbl_estoque.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_preco
            // 
            txt_preco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_preco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_preco.Location = new Point(85, 53);
            txt_preco.MaxLength = 14;
            txt_preco.Name = "txt_preco";
            txt_preco.PlaceholderText = "Insira o preço do produto...";
            txt_preco.Size = new Size(687, 26);
            txt_preco.TabIndex = 51;
            txt_preco.KeyPress += txt_preco_KeyPress;
            // 
            // lbl_preco
            // 
            lbl_preco.BackColor = Color.Transparent;
            lbl_preco.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_preco.Location = new Point(12, 53);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(67, 26);
            lbl_preco.TabIndex = 50;
            lbl_preco.Text = "Preço:";
            lbl_preco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_nome
            // 
            txt_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(78, 12);
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Insira o nome do produto...";
            txt_nome.Size = new Size(694, 26);
            txt_nome.TabIndex = 49;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.BackColor = Color.Transparent;
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.Location = new Point(12, 175);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(125, 28);
            lbl_observacoes.TabIndex = 58;
            lbl_observacoes.Text = "Observações:";
            lbl_observacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nud_estoque
            // 
            nud_estoque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nud_estoque.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nud_estoque.Location = new Point(100, 94);
            nud_estoque.Name = "nud_estoque";
            nud_estoque.Size = new Size(672, 26);
            nud_estoque.TabIndex = 57;
            nud_estoque.TextAlign = HorizontalAlignment.Right;
            // 
            // form_cadastro_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(nud_estoque);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_fornecedor);
            Controls.Add(btn_cancelar);
            Controls.Add(cbbox_fornecedor);
            Controls.Add(lbl_estoque);
            Controls.Add(btn_salvar);
            Controls.Add(txt_preco);
            Controls.Add(lbl_preco);
            Controls.Add(txt_nome);
            Controls.Add(lbl_observacoes);
            Controls.Add(txt_observacoes);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_produtos";
            Text = "Cadastro de Produtos";
            Load += form_cadastro_produtos_Load;
            ((System.ComponentModel.ISupportInitialize)nud_estoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_salvar;
        private TextBox txt_observacoes;
        private Label lbl_estoque;
        private TextBox txt_preco;
        private Label lbl_preco;
        private TextBox txt_nome;
        private Label lbl_fornecedor;
        private ComboBox cbbox_fornecedor;
        private Label lbl_observacoes;
        private Label lbl_nome;
        private NumericUpDown nud_estoque;
    }
}