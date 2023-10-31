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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbx_clientes_addvenda = new ComboBox();
            btn_Salvar = new Button();
            label6 = new Label();
            lbl_valortotal = new Label();
            btnCancelar = new Button();
            txt_observacoes = new TextBox();
            dgv_adicionar_vendas = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            btn_Remover = new Button();
            label7 = new Label();
            cbox_delivery = new CheckBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            lbl_categoria = new Label();
            lbl_tamanho = new Label();
            cbbox_categoria = new ComboBox();
            cbbox_tamanho = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_adicionar_vendas).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 1;
            label2.Text = "Nome do Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(516, 150);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 5;
            label4.Text = "Fazer Entrega?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 57);
            label5.Name = "label5";
            label5.Size = new Size(0, 18);
            label5.TabIndex = 8;
            // 
            // cbx_clientes_addvenda
            // 
            cbx_clientes_addvenda.AllowDrop = true;
            cbx_clientes_addvenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_clientes_addvenda.FormattingEnabled = true;
            cbx_clientes_addvenda.Location = new Point(147, 9);
            cbx_clientes_addvenda.Name = "cbx_clientes_addvenda";
            cbx_clientes_addvenda.Size = new Size(625, 23);
            cbx_clientes_addvenda.TabIndex = 10;
            cbx_clientes_addvenda.SelectedIndexChanged += cbx_cliente_addvenda_SelectedIndexChanged;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Salvar.BackColor = SystemColors.Window;
            btn_Salvar.FlatAppearance.BorderColor = Color.Black;
            btn_Salvar.FlatAppearance.BorderSize = 2;
            btn_Salvar.FlatStyle = FlatStyle.Flat;
            btn_Salvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salvar.Location = new Point(643, 537);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(131, 41);
            btn_Salvar.TabIndex = 13;
            btn_Salvar.Text = "Salvar Pedido";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(638, 150);
            label6.Name = "label6";
            label6.Size = new Size(95, 19);
            label6.TabIndex = 15;
            label6.Text = "Valor Total:";
            // 
            // lbl_valortotal
            // 
            lbl_valortotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_valortotal.AutoSize = true;
            lbl_valortotal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valortotal.Location = new Point(673, 171);
            lbl_valortotal.Name = "lbl_valortotal";
            lbl_valortotal.Size = new Size(18, 19);
            lbl_valortotal.TabIndex = 16;
            lbl_valortotal.Text = "0";
            lbl_valortotal.Click += lbl_valortotal_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.FlatAppearance.BorderColor = Color.Black;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(12, 537);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 41);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.Location = new Point(12, 387);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira observações sobre a(s) pizza(s)";
            txt_observacoes.Size = new Size(760, 126);
            txt_observacoes.TabIndex = 30;
            // 
            // dgv_adicionar_vendas
            // 
            dgv_adicionar_vendas.AllowUserToAddRows = false;
            dgv_adicionar_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adicionar_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adicionar_vendas.Columns.AddRange(new DataGridViewColumn[] { Produto, Preco });
            dgv_adicionar_vendas.Location = new Point(12, 247);
            dgv_adicionar_vendas.Name = "dgv_adicionar_vendas";
            dgv_adicionar_vendas.ReadOnly = true;
            dgv_adicionar_vendas.RowTemplate.Height = 25;
            dgv_adicionar_vendas.Size = new Size(760, 134);
            dgv_adicionar_vendas.TabIndex = 31;
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Produto.HeaderText = "Produto";
            Produto.MinimumWidth = 100;
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            Produto.Resizable = DataGridViewTriState.True;
            // 
            // Preco
            // 
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            Preco.Width = 175;
            // 
            // btn_Remover
            // 
            btn_Remover.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Remover.BackColor = SystemColors.Window;
            btn_Remover.FlatAppearance.BorderColor = Color.Black;
            btn_Remover.FlatAppearance.BorderSize = 2;
            btn_Remover.FlatStyle = FlatStyle.Flat;
            btn_Remover.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Remover.Location = new Point(134, 537);
            btn_Remover.Name = "btn_Remover";
            btn_Remover.Size = new Size(116, 41);
            btn_Remover.TabIndex = 32;
            btn_Remover.Text = "Remover";
            btn_Remover.UseVisualStyleBackColor = false;
            btn_Remover.Click += btn_Remover_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(614, 82);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 36;
            // 
            // cbox_delivery
            // 
            cbox_delivery.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbox_delivery.AutoSize = true;
            cbox_delivery.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_delivery.Location = new Point(519, 168);
            cbox_delivery.Name = "cbox_delivery";
            cbox_delivery.Size = new Size(55, 22);
            cbox_delivery.TabIndex = 52;
            cbox_delivery.Text = "Sim";
            cbox_delivery.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(cbox_delivery);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(lbl_categoria);
            groupBox2.Controls.Add(lbl_tamanho);
            groupBox2.Controls.Add(cbbox_categoria);
            groupBox2.Controls.Add(cbbox_tamanho);
            groupBox2.Controls.Add(lbl_valortotal);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 203);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pizzas:";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(37, 105);
            label8.Name = "label8";
            label8.Size = new Size(62, 26);
            label8.TabIndex = 67;
            label8.Text = "Nome:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(628, 26);
            comboBox1.TabIndex = 66;
            // 
            // lbl_categoria
            // 
            lbl_categoria.BackColor = Color.Transparent;
            lbl_categoria.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_categoria.Location = new Point(6, 63);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(93, 26);
            lbl_categoria.TabIndex = 65;
            lbl_categoria.Text = "Categoria:";
            lbl_categoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_tamanho
            // 
            lbl_tamanho.BackColor = Color.Transparent;
            lbl_tamanho.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tamanho.Location = new Point(6, 22);
            lbl_tamanho.Name = "lbl_tamanho";
            lbl_tamanho.Size = new Size(93, 26);
            lbl_tamanho.TabIndex = 63;
            lbl_tamanho.Text = "Tamanho:";
            lbl_tamanho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbox_categoria
            // 
            cbbox_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_categoria.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_categoria.FormattingEnabled = true;
            cbbox_categoria.Location = new Point(105, 63);
            cbbox_categoria.Name = "cbbox_categoria";
            cbbox_categoria.Size = new Size(628, 26);
            cbbox_categoria.TabIndex = 62;
            // 
            // cbbox_tamanho
            // 
            cbbox_tamanho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_tamanho.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_tamanho.FormattingEnabled = true;
            cbbox_tamanho.Location = new Point(105, 22);
            cbbox_tamanho.Name = "cbbox_tamanho";
            cbbox_tamanho.Size = new Size(628, 26);
            cbbox_tamanho.TabIndex = 64;
            // 
            // form_adicionar_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 595);
            Controls.Add(label7);
            Controls.Add(btn_Remover);
            Controls.Add(dgv_adicionar_vendas);
            Controls.Add(txt_observacoes);
            Controls.Add(btnCancelar);
            Controls.Add(btn_Salvar);
            Controls.Add(cbx_clientes_addvenda);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            MinimumSize = new Size(800, 500);
            Name = "form_adicionar_venda";
            Text = "Adicionar Venda";
            Load += form_adicionar_venda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_adicionar_vendas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rdbtn_sim;
        private RadioButton rdbtn_nao;
        private Label label5;
        private ComboBox cbx_clientes_addvenda;
        private Button btn_Salvar;
        private Label label6;
        private Label lbl_valortotal;
        private Button btnCancelar;
        private TextBox txt_observacoes;
        private DataGridView dgv_adicionar_vendas;
        private Button btnInserir_dgv;
        private Button btnExcluir_dgv;
        private Button btn_Remover;
        private Button button1;
        private ComboBox cbx_produtos_addvenda;
        private Label label7;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private CheckBox cbox_delivery;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Preco;
        private GroupBox groupBox2;
        private Label label8;
        private ComboBox comboBox1;
        private Label lbl_categoria;
        private Label lbl_tamanho;
        private ComboBox cbbox_categoria;
        private ComboBox cbbox_tamanho;
    }
}