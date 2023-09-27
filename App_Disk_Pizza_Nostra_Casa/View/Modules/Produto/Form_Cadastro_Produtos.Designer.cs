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
            label4 = new Label();
            txt_observacoes_produto = new TextBox();
            grp_dados = new GroupBox();
            pnl_dados = new Panel();
            label6 = new Label();
            cbx_fornecedor_produto = new ComboBox();
            label3 = new Label();
            txt_estoque_produto = new TextBox();
            txt_preco_produto = new TextBox();
            label2 = new Label();
            txt_nome_produto = new TextBox();
            label1 = new Label();
            label5 = new Label();
            grp_dados.SuspendLayout();
            pnl_dados.SuspendLayout();
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
            btn_cancelar.Location = new Point(525, 410);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(116, 39);
            btn_cancelar.TabIndex = 45;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
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
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(125, 26);
            label4.TabIndex = 43;
            label4.Text = "Observações:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_observacoes_produto
            // 
            txt_observacoes_produto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes_produto.Location = new Point(12, 299);
            txt_observacoes_produto.Multiline = true;
            txt_observacoes_produto.Name = "txt_observacoes_produto";
            txt_observacoes_produto.PlaceholderText = "Insira observações sobre o produto...(campo não obrigatório).";
            txt_observacoes_produto.Size = new Size(760, 96);
            txt_observacoes_produto.TabIndex = 42;
            // 
            // grp_dados
            // 
            grp_dados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grp_dados.Controls.Add(pnl_dados);
            grp_dados.Location = new Point(12, 12);
            grp_dados.Name = "grp_dados";
            grp_dados.Size = new Size(760, 248);
            grp_dados.TabIndex = 57;
            grp_dados.TabStop = false;
            grp_dados.Text = "Dados";
            // 
            // pnl_dados
            // 
            pnl_dados.AutoScroll = true;
            pnl_dados.BackColor = Color.Transparent;
            pnl_dados.Controls.Add(label6);
            pnl_dados.Controls.Add(cbx_fornecedor_produto);
            pnl_dados.Controls.Add(label3);
            pnl_dados.Controls.Add(txt_estoque_produto);
            pnl_dados.Controls.Add(txt_preco_produto);
            pnl_dados.Controls.Add(label2);
            pnl_dados.Controls.Add(txt_nome_produto);
            pnl_dados.Controls.Add(label1);
            pnl_dados.Dock = DockStyle.Fill;
            pnl_dados.Location = new Point(3, 19);
            pnl_dados.Name = "pnl_dados";
            pnl_dados.Size = new Size(754, 226);
            pnl_dados.TabIndex = 57;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 186);
            label6.Name = "label6";
            label6.Size = new Size(109, 26);
            label6.TabIndex = 55;
            label6.Text = "Fornecedor:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbx_fornecedor_produto
            // 
            cbx_fornecedor_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_fornecedor_produto.FormattingEnabled = true;
            cbx_fornecedor_produto.Location = new Point(128, 187);
            cbx_fornecedor_produto.Name = "cbx_fornecedor_produto";
            cbx_fornecedor_produto.Size = new Size(623, 24);
            cbx_fornecedor_produto.TabIndex = 54;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 130);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 53;
            label3.Text = "Estoque:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_estoque_produto
            // 
            txt_estoque_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_estoque_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_estoque_produto.Location = new Point(101, 130);
            txt_estoque_produto.Name = "txt_estoque_produto";
            txt_estoque_produto.PlaceholderText = "Insira a quantidade do produto no estoque...";
            txt_estoque_produto.Size = new Size(650, 26);
            txt_estoque_produto.TabIndex = 52;
            // 
            // txt_preco_produto
            // 
            txt_preco_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_preco_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_preco_produto.Location = new Point(78, 71);
            txt_preco_produto.MaxLength = 14;
            txt_preco_produto.Name = "txt_preco_produto";
            txt_preco_produto.PlaceholderText = "Insira o preço do produto...";
            txt_preco_produto.Size = new Size(673, 26);
            txt_preco_produto.TabIndex = 51;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 71);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 50;
            label2.Text = "Preço:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_nome_produto
            // 
            txt_nome_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_produto.Location = new Point(167, 12);
            txt_nome_produto.Name = "txt_nome_produto";
            txt_nome_produto.PlaceholderText = "Insira o nome do produto...";
            txt_nome_produto.Size = new Size(584, 26);
            txt_nome_produto.TabIndex = 49;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(177, 26);
            label1.TabIndex = 48;
            label1.Text = "Nome do Produto:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 268);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 58;
            label5.Text = "Observações:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // form_cadastro_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(label5);
            Controls.Add(grp_dados);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            Controls.Add(label4);
            Controls.Add(txt_observacoes_produto);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_produtos";
            Text = "Cadastro de Produtos";
            Load += form_cadastro_produtos_Load;
            grp_dados.ResumeLayout(false);
            pnl_dados.ResumeLayout(false);
            pnl_dados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_salvar;
        private Label label4;
        private TextBox txt_observacoes_produto;
        private GroupBox grp_dados;
        private Panel pnl_dados;
        private Label label3;
        private TextBox txt_estoque_produto;
        private TextBox txt_preco_produto;
        private Label label2;
        private TextBox txt_nome_produto;
        private Label label1;
        private Label label6;
        private ComboBox cbx_fornecedor_produto;
        private Label label5;
    }
}