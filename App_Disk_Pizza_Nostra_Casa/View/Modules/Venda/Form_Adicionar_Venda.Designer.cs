namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Venda
{
    partial class form_adicionar_venda
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
            btn_salvar_pedido = new Button();
            btn_cancelar_pedido = new Button();
            cbbox_cliente = new ComboBox();
            lbl_nome_produto = new Label();
            cbbox_nome_produto = new ComboBox();
            lbl_tamanho_produto = new Label();
            cbbox_categoria_produto = new ComboBox();
            cbbox_tamanho_produto = new ComboBox();
            lbl_categoria_produto = new Label();
            dgv_carrinho_produtos = new DataGridView();
            btn_remover_produto = new Button();
            btn_adicionar_produto = new Button();
            grpbox_envolvidos = new GroupBox();
            lbl_cliente = new Label();
            lbl_funcionario = new Label();
            cbbox_funcionario = new ComboBox();
            grpbox_produtos = new GroupBox();
            panel1 = new Panel();
            txt_quantidade_produto = new TextBox();
            lbl_quantidade_produto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_carrinho_produtos).BeginInit();
            grpbox_envolvidos.SuspendLayout();
            grpbox_produtos.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_salvar_pedido
            // 
            btn_salvar_pedido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salvar_pedido.BackColor = Color.Transparent;
            btn_salvar_pedido.Cursor = Cursors.Hand;
            btn_salvar_pedido.FlatAppearance.BorderColor = Color.Black;
            btn_salvar_pedido.FlatAppearance.BorderSize = 2;
            btn_salvar_pedido.FlatStyle = FlatStyle.Flat;
            btn_salvar_pedido.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar_pedido.Location = new Point(622, 410);
            btn_salvar_pedido.Name = "btn_salvar_pedido";
            btn_salvar_pedido.Size = new Size(150, 39);
            btn_salvar_pedido.TabIndex = 45;
            btn_salvar_pedido.Text = "Salvar Pedido";
            btn_salvar_pedido.UseVisualStyleBackColor = false;
            btn_salvar_pedido.Click += btn_salvar_pedido_Click;
            // 
            // btn_cancelar_pedido
            // 
            btn_cancelar_pedido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar_pedido.BackColor = Color.Transparent;
            btn_cancelar_pedido.Cursor = Cursors.Hand;
            btn_cancelar_pedido.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar_pedido.FlatAppearance.BorderSize = 2;
            btn_cancelar_pedido.FlatStyle = FlatStyle.Flat;
            btn_cancelar_pedido.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar_pedido.Location = new Point(466, 410);
            btn_cancelar_pedido.Name = "btn_cancelar_pedido";
            btn_cancelar_pedido.Size = new Size(150, 39);
            btn_cancelar_pedido.TabIndex = 46;
            btn_cancelar_pedido.Text = "Cancelar Pedido";
            btn_cancelar_pedido.UseVisualStyleBackColor = false;
            btn_cancelar_pedido.Click += btn_cancelar_pedido_Click;
            // 
            // cbbox_cliente
            // 
            cbbox_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_cliente.FormattingEnabled = true;
            cbbox_cliente.Location = new Point(94, 68);
            cbbox_cliente.Name = "cbbox_cliente";
            cbbox_cliente.Size = new Size(649, 26);
            cbbox_cliente.TabIndex = 0;
            // 
            // lbl_nome_produto
            // 
            lbl_nome_produto.AutoSize = true;
            lbl_nome_produto.BackColor = Color.Transparent;
            lbl_nome_produto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome_produto.Location = new Point(14, 98);
            lbl_nome_produto.Name = "lbl_nome_produto";
            lbl_nome_produto.Size = new Size(77, 19);
            lbl_nome_produto.TabIndex = 59;
            lbl_nome_produto.Text = "Produto:";
            lbl_nome_produto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbox_nome_produto
            // 
            cbbox_nome_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_nome_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_nome_produto.FormattingEnabled = true;
            cbbox_nome_produto.Location = new Point(97, 95);
            cbbox_nome_produto.Name = "cbbox_nome_produto";
            cbbox_nome_produto.Size = new Size(631, 26);
            cbbox_nome_produto.TabIndex = 2;
            // 
            // lbl_tamanho_produto
            // 
            lbl_tamanho_produto.AutoSize = true;
            lbl_tamanho_produto.BackColor = Color.Transparent;
            lbl_tamanho_produto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tamanho_produto.Location = new Point(14, 56);
            lbl_tamanho_produto.Name = "lbl_tamanho_produto";
            lbl_tamanho_produto.Size = new Size(86, 19);
            lbl_tamanho_produto.TabIndex = 58;
            lbl_tamanho_produto.Text = "Tamanho:";
            lbl_tamanho_produto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbox_categoria_produto
            // 
            cbbox_categoria_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_categoria_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_categoria_produto.FormattingEnabled = true;
            cbbox_categoria_produto.Location = new Point(109, 12);
            cbbox_categoria_produto.Name = "cbbox_categoria_produto";
            cbbox_categoria_produto.Size = new Size(619, 26);
            cbbox_categoria_produto.TabIndex = 0;
            cbbox_categoria_produto.SelectedIndexChanged += cbbox_categoria_produto_SelectedIndexChanged;
            // 
            // cbbox_tamanho_produto
            // 
            cbbox_tamanho_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_tamanho_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_tamanho_produto.FormattingEnabled = true;
            cbbox_tamanho_produto.Location = new Point(106, 53);
            cbbox_tamanho_produto.Name = "cbbox_tamanho_produto";
            cbbox_tamanho_produto.Size = new Size(622, 26);
            cbbox_tamanho_produto.TabIndex = 1;
            // 
            // lbl_categoria_produto
            // 
            lbl_categoria_produto.AutoSize = true;
            lbl_categoria_produto.BackColor = Color.Transparent;
            lbl_categoria_produto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_categoria_produto.Location = new Point(14, 15);
            lbl_categoria_produto.Name = "lbl_categoria_produto";
            lbl_categoria_produto.Size = new Size(89, 19);
            lbl_categoria_produto.TabIndex = 57;
            lbl_categoria_produto.Text = "Categoria:";
            lbl_categoria_produto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv_carrinho_produtos
            // 
            dgv_carrinho_produtos.AllowUserToAddRows = false;
            dgv_carrinho_produtos.AllowUserToDeleteRows = false;
            dgv_carrinho_produtos.AllowUserToOrderColumns = true;
            dgv_carrinho_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_carrinho_produtos.BackgroundColor = Color.White;
            dgv_carrinho_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_carrinho_produtos.Location = new Point(12, 282);
            dgv_carrinho_produtos.MultiSelect = false;
            dgv_carrinho_produtos.Name = "dgv_carrinho_produtos";
            dgv_carrinho_produtos.ReadOnly = true;
            dgv_carrinho_produtos.RowHeadersWidth = 51;
            dgv_carrinho_produtos.RowTemplate.Height = 25;
            dgv_carrinho_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_carrinho_produtos.Size = new Size(760, 112);
            dgv_carrinho_produtos.TabIndex = 49;
            // 
            // btn_remover_produto
            // 
            btn_remover_produto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_remover_produto.BackColor = Color.Transparent;
            btn_remover_produto.Cursor = Cursors.Hand;
            btn_remover_produto.FlatAppearance.BorderColor = Color.Black;
            btn_remover_produto.FlatAppearance.BorderSize = 2;
            btn_remover_produto.FlatStyle = FlatStyle.Flat;
            btn_remover_produto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_remover_produto.Location = new Point(12, 410);
            btn_remover_produto.Name = "btn_remover_produto";
            btn_remover_produto.Size = new Size(160, 39);
            btn_remover_produto.TabIndex = 53;
            btn_remover_produto.Text = "Remover Produto";
            btn_remover_produto.UseVisualStyleBackColor = false;
            btn_remover_produto.Click += btn_remover_produto_Click;
            // 
            // btn_adicionar_produto
            // 
            btn_adicionar_produto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_adicionar_produto.BackColor = Color.Transparent;
            btn_adicionar_produto.Cursor = Cursors.Hand;
            btn_adicionar_produto.FlatAppearance.BorderColor = Color.Black;
            btn_adicionar_produto.FlatAppearance.BorderSize = 2;
            btn_adicionar_produto.FlatStyle = FlatStyle.Flat;
            btn_adicionar_produto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adicionar_produto.Location = new Point(178, 410);
            btn_adicionar_produto.Name = "btn_adicionar_produto";
            btn_adicionar_produto.Size = new Size(160, 39);
            btn_adicionar_produto.TabIndex = 52;
            btn_adicionar_produto.Text = "Adicionar Produto";
            btn_adicionar_produto.UseVisualStyleBackColor = false;
            btn_adicionar_produto.Click += btn_adicionar_produto_Click;
            // 
            // grpbox_envolvidos
            // 
            grpbox_envolvidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_envolvidos.Controls.Add(lbl_cliente);
            grpbox_envolvidos.Controls.Add(lbl_funcionario);
            grpbox_envolvidos.Controls.Add(cbbox_cliente);
            grpbox_envolvidos.Controls.Add(cbbox_funcionario);
            grpbox_envolvidos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpbox_envolvidos.Location = new Point(12, 12);
            grpbox_envolvidos.Name = "grpbox_envolvidos";
            grpbox_envolvidos.Size = new Size(760, 110);
            grpbox_envolvidos.TabIndex = 48;
            grpbox_envolvidos.TabStop = false;
            grpbox_envolvidos.Text = "Envolvidos:";
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.BackColor = Color.Transparent;
            lbl_cliente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cliente.Location = new Point(20, 71);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(68, 19);
            lbl_cliente.TabIndex = 61;
            lbl_cliente.Text = "Cliente:";
            lbl_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_funcionario
            // 
            lbl_funcionario.AutoSize = true;
            lbl_funcionario.BackColor = Color.Transparent;
            lbl_funcionario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_funcionario.Location = new Point(20, 33);
            lbl_funcionario.Name = "lbl_funcionario";
            lbl_funcionario.Size = new Size(107, 19);
            lbl_funcionario.TabIndex = 60;
            lbl_funcionario.Text = "Funcionário:";
            lbl_funcionario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbox_funcionario
            // 
            cbbox_funcionario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_funcionario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_funcionario.FormattingEnabled = true;
            cbbox_funcionario.Location = new Point(133, 30);
            cbbox_funcionario.Name = "cbbox_funcionario";
            cbbox_funcionario.Size = new Size(610, 26);
            cbbox_funcionario.TabIndex = 0;
            // 
            // grpbox_produtos
            // 
            grpbox_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_produtos.Controls.Add(panel1);
            grpbox_produtos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpbox_produtos.Location = new Point(12, 137);
            grpbox_produtos.Name = "grpbox_produtos";
            grpbox_produtos.Size = new Size(760, 133);
            grpbox_produtos.TabIndex = 60;
            grpbox_produtos.TabStop = false;
            grpbox_produtos.Text = "Produtos:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(txt_quantidade_produto);
            panel1.Controls.Add(cbbox_categoria_produto);
            panel1.Controls.Add(lbl_nome_produto);
            panel1.Controls.Add(lbl_categoria_produto);
            panel1.Controls.Add(cbbox_nome_produto);
            panel1.Controls.Add(cbbox_tamanho_produto);
            panel1.Controls.Add(lbl_tamanho_produto);
            panel1.Controls.Add(lbl_quantidade_produto);
            panel1.Location = new Point(6, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 93);
            panel1.TabIndex = 0;
            // 
            // txt_quantidade_produto
            // 
            txt_quantidade_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_quantidade_produto.Location = new Point(123, 137);
            txt_quantidade_produto.Name = "txt_quantidade_produto";
            txt_quantidade_produto.Size = new Size(605, 26);
            txt_quantidade_produto.TabIndex = 61;
            txt_quantidade_produto.KeyPress += txt_quantidade_produto_KeyPress;
            // 
            // lbl_quantidade_produto
            // 
            lbl_quantidade_produto.AutoSize = true;
            lbl_quantidade_produto.BackColor = Color.Transparent;
            lbl_quantidade_produto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_quantidade_produto.Location = new Point(14, 140);
            lbl_quantidade_produto.Name = "lbl_quantidade_produto";
            lbl_quantidade_produto.Size = new Size(103, 19);
            lbl_quantidade_produto.TabIndex = 61;
            lbl_quantidade_produto.Text = "Quantidade:";
            // 
            // form_adicionar_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(grpbox_produtos);
            Controls.Add(grpbox_envolvidos);
            Controls.Add(btn_remover_produto);
            Controls.Add(btn_adicionar_produto);
            Controls.Add(btn_cancelar_pedido);
            Controls.Add(btn_salvar_pedido);
            Controls.Add(dgv_carrinho_produtos);
            MinimumSize = new Size(800, 500);
            Name = "form_adicionar_venda";
            Text = "Efetuação de Vendas";
            Load += form_adicionar_venda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_carrinho_produtos).EndInit();
            grpbox_envolvidos.ResumeLayout(false);
            grpbox_envolvidos.PerformLayout();
            grpbox_produtos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_salvar_pedido;
        private Button btn_cancelar_pedido;
        private ComboBox cbbox_cliente;
        private ComboBox cbbox_categoria_produto;
        private ComboBox cbbox_nome_produto;
        private ComboBox cbbox_tamanho_produto;
        private Label lbl_nome_produto;
        private Label lbl_tamanho_produto;
        private Label lbl_categoria_produto;
        private DataGridView dgv_carrinho_produtos;
        private Button btn_remover_produto;
        private Button btn_adicionar_produto;
        private GroupBox grpbox_envolvidos;
        private ComboBox cbbox_funcionario;
        private Label lbl_cliente;
        private Label lbl_funcionario;
        private GroupBox grpbox_produtos;
        private Panel panel1;
        private Label lbl_quantidade_produto;
        private TextBox txt_quantidade_produto;
    }
}