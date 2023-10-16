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
            txt_preco = new TextBox();
            lbl_preco = new Label();
            txt_nome = new TextBox();
            lbl_observacoes = new Label();
            grpbox_dados = new GroupBox();
            lbl_categoria = new Label();
            cbbox_categoria = new ComboBox();
            cbbox_tamanho = new ComboBox();
            lbl_tamanho = new Label();
            grpbox_dados.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.Cursor = Cursors.Hand;
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
            btn_salvar.Cursor = Cursors.Hand;
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
            txt_observacoes.Location = new Point(12, 309);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira possíveis observações sobre o produto...";
            txt_observacoes.Size = new Size(760, 85);
            txt_observacoes.TabIndex = 42;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(14, 37);
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
            lbl_fornecedor.Location = new Point(14, 197);
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
            cbbox_fornecedor.Location = new Point(129, 197);
            cbbox_fornecedor.Name = "cbbox_fornecedor";
            cbbox_fornecedor.Size = new Size(612, 26);
            cbbox_fornecedor.TabIndex = 54;
            // 
            // txt_preco
            // 
            txt_preco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_preco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_preco.Location = new Point(86, 75);
            txt_preco.MaxLength = 14;
            txt_preco.Name = "txt_preco";
            txt_preco.PlaceholderText = "Insira o preço do produto aqui...";
            txt_preco.Size = new Size(655, 26);
            txt_preco.TabIndex = 51;
            txt_preco.KeyPress += txt_preco_KeyPress;
            // 
            // lbl_preco
            // 
            lbl_preco.BackColor = Color.Transparent;
            lbl_preco.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_preco.Location = new Point(14, 74);
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
            txt_nome.Location = new Point(80, 34);
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Insira o nome do produto aqui...";
            txt_nome.Size = new Size(661, 26);
            txt_nome.TabIndex = 49;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.BackColor = Color.Transparent;
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.Location = new Point(10, 269);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(125, 28);
            lbl_observacoes.TabIndex = 58;
            lbl_observacoes.Text = "Observações:";
            lbl_observacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpbox_dados
            // 
            grpbox_dados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_dados.BackColor = Color.Transparent;
            grpbox_dados.Controls.Add(lbl_categoria);
            grpbox_dados.Controls.Add(cbbox_categoria);
            grpbox_dados.Controls.Add(cbbox_fornecedor);
            grpbox_dados.Controls.Add(txt_nome);
            grpbox_dados.Controls.Add(lbl_nome);
            grpbox_dados.Controls.Add(lbl_preco);
            grpbox_dados.Controls.Add(lbl_fornecedor);
            grpbox_dados.Controls.Add(txt_preco);
            grpbox_dados.Controls.Add(cbbox_tamanho);
            grpbox_dados.Controls.Add(lbl_tamanho);
            grpbox_dados.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpbox_dados.Location = new Point(12, 12);
            grpbox_dados.Name = "grpbox_dados";
            grpbox_dados.Size = new Size(760, 245);
            grpbox_dados.TabIndex = 59;
            grpbox_dados.TabStop = false;
            grpbox_dados.Text = "Dados";
            // 
            // lbl_categoria
            // 
            lbl_categoria.BackColor = Color.Transparent;
            lbl_categoria.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_categoria.Location = new Point(14, 156);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(93, 26);
            lbl_categoria.TabIndex = 61;
            lbl_categoria.Text = "Categoria:";
            lbl_categoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbox_categoria
            // 
            cbbox_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_categoria.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_categoria.FormattingEnabled = true;
            cbbox_categoria.Location = new Point(113, 156);
            cbbox_categoria.Name = "cbbox_categoria";
            cbbox_categoria.Size = new Size(628, 26);
            cbbox_categoria.TabIndex = 58;
            cbbox_categoria.SelectedIndexChanged += cbbox_categoria_SelectedIndexChanged;
            // 
            // cbbox_tamanho
            // 
            cbbox_tamanho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_tamanho.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_tamanho.FormattingEnabled = true;
            cbbox_tamanho.Location = new Point(113, 115);
            cbbox_tamanho.Name = "cbbox_tamanho";
            cbbox_tamanho.Size = new Size(628, 26);
            cbbox_tamanho.TabIndex = 60;
            // 
            // lbl_tamanho
            // 
            lbl_tamanho.BackColor = Color.Transparent;
            lbl_tamanho.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tamanho.Location = new Point(14, 115);
            lbl_tamanho.Name = "lbl_tamanho";
            lbl_tamanho.Size = new Size(93, 26);
            lbl_tamanho.TabIndex = 59;
            lbl_tamanho.Text = "Tamanho:";
            lbl_tamanho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // form_cadastro_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(grpbox_dados);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            Controls.Add(lbl_observacoes);
            Controls.Add(txt_observacoes);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_produtos";
            Text = "Cadastro de Produtos";
            Load += form_cadastro_produtos_Load;
            grpbox_dados.ResumeLayout(false);
            grpbox_dados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_salvar;
        private TextBox txt_observacoes;
        private TextBox txt_preco;
        private Label lbl_preco;
        private TextBox txt_nome;
        private Label lbl_fornecedor;
        private ComboBox cbbox_fornecedor;
        private Label lbl_observacoes;
        private Label lbl_nome;
        private GroupBox grpbox_dados;
        private ComboBox cbbox_tamanho;
        private Label lbl_categoria;
        private ComboBox cbbox_categoria;
        private Label lbl_tamanho;
    }
}