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
            rdbtn_sim = new RadioButton();
            rdbtn_nao = new RadioButton();
            label5 = new Label();
            cbx_cliente_addvenda = new ComboBox();
            cbx_produtos_addvenda = new ComboBox();
            btn_Salvar = new Button();
            label6 = new Label();
            lbl_valortotal = new Label();
            btn_Calcular = new Button();
            btnCancelar = new Button();
            txt_observacoes = new TextBox();
            dgv_adicionar_vendas = new DataGridView();
            btnInserir_dgv = new Button();
            btnExcluir_dgv = new Button();
            Produto = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_adicionar_vendas).BeginInit();
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
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 2;
            label3.Text = "Produtos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 5;
            label4.Text = "Fazer Entrega?";
            // 
            // rdbtn_sim
            // 
            rdbtn_sim.AutoSize = true;
            rdbtn_sim.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbtn_sim.Location = new Point(147, 97);
            rdbtn_sim.Name = "rdbtn_sim";
            rdbtn_sim.Size = new Size(54, 22);
            rdbtn_sim.TabIndex = 6;
            rdbtn_sim.TabStop = true;
            rdbtn_sim.Text = "Sim";
            rdbtn_sim.UseVisualStyleBackColor = true;
            // 
            // rdbtn_nao
            // 
            rdbtn_nao.AutoSize = true;
            rdbtn_nao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbtn_nao.Location = new Point(209, 97);
            rdbtn_nao.Name = "rdbtn_nao";
            rdbtn_nao.Size = new Size(55, 22);
            rdbtn_nao.TabIndex = 7;
            rdbtn_nao.TabStop = true;
            rdbtn_nao.Text = "Não";
            rdbtn_nao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 99);
            label5.Name = "label5";
            label5.Size = new Size(0, 18);
            label5.TabIndex = 8;
            // 
            // cbx_cliente_addvenda
            // 
            cbx_cliente_addvenda.AllowDrop = true;
            cbx_cliente_addvenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_cliente_addvenda.FormattingEnabled = true;
            cbx_cliente_addvenda.Location = new Point(147, 9);
            cbx_cliente_addvenda.Name = "cbx_cliente_addvenda";
            cbx_cliente_addvenda.Size = new Size(625, 23);
            cbx_cliente_addvenda.TabIndex = 10;
            cbx_cliente_addvenda.SelectedIndexChanged += cbx_cliente_addvenda_SelectedIndexChanged;
            // 
            // cbx_produtos_addvenda
            // 
            cbx_produtos_addvenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_produtos_addvenda.FormattingEnabled = true;
            cbx_produtos_addvenda.Location = new Point(147, 53);
            cbx_produtos_addvenda.Name = "cbx_produtos_addvenda";
            cbx_produtos_addvenda.Size = new Size(625, 23);
            cbx_produtos_addvenda.TabIndex = 11;
            cbx_produtos_addvenda.SelectedIndexChanged += cbx_produtos_addvenda_SelectedIndexChanged;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Salvar.BackColor = SystemColors.Window;
            btn_Salvar.FlatAppearance.BorderColor = Color.Black;
            btn_Salvar.FlatAppearance.BorderSize = 2;
            btn_Salvar.FlatStyle = FlatStyle.Flat;
            btn_Salvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salvar.Location = new Point(643, 406);
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
            label6.Location = new Point(542, 384);
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
            lbl_valortotal.Location = new Point(643, 384);
            lbl_valortotal.Name = "lbl_valortotal";
            lbl_valortotal.Size = new Size(18, 19);
            lbl_valortotal.TabIndex = 16;
            lbl_valortotal.Text = "0";
            lbl_valortotal.Click += lbl_valortotal_Click;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Calcular.BackColor = SystemColors.Window;
            btn_Calcular.FlatAppearance.BorderColor = Color.Black;
            btn_Calcular.FlatAppearance.BorderSize = 2;
            btn_Calcular.FlatStyle = FlatStyle.Flat;
            btn_Calcular.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(521, 406);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(116, 41);
            btn_Calcular.TabIndex = 17;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.FlatAppearance.BorderColor = Color.Black;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(12, 408);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 41);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.Location = new Point(408, 125);
            txt_observacoes.MaximumSize = new Size(366, 205);
            txt_observacoes.MinimumSize = new Size(366, 205);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira observações sobre a(s) pizza(s)";
            txt_observacoes.Size = new Size(366, 205);
            txt_observacoes.TabIndex = 30;
            // 
            // dgv_adicionar_vendas
            // 
            dgv_adicionar_vendas.AllowUserToAddRows = false;
            dgv_adicionar_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adicionar_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adicionar_vendas.Columns.AddRange(new DataGridViewColumn[] { Produto, Preco });
            dgv_adicionar_vendas.Location = new Point(12, 125);
            dgv_adicionar_vendas.MaximumSize = new Size(366, 205);
            dgv_adicionar_vendas.MinimumSize = new Size(366, 205);
            dgv_adicionar_vendas.Name = "dgv_adicionar_vendas";
            dgv_adicionar_vendas.ReadOnly = true;
            dgv_adicionar_vendas.RowTemplate.Height = 25;
            dgv_adicionar_vendas.Size = new Size(366, 205);
            dgv_adicionar_vendas.TabIndex = 31;
            // 
            // btnInserir_dgv
            // 
            btnInserir_dgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInserir_dgv.BackColor = SystemColors.Window;
            btnInserir_dgv.FlatAppearance.BorderColor = Color.Black;
            btnInserir_dgv.FlatAppearance.BorderSize = 2;
            btnInserir_dgv.FlatStyle = FlatStyle.Flat;
            btnInserir_dgv.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInserir_dgv.ForeColor = Color.Blue;
            btnInserir_dgv.Location = new Point(12, 336);
            btnInserir_dgv.Name = "btnInserir_dgv";
            btnInserir_dgv.Size = new Size(52, 47);
            btnInserir_dgv.TabIndex = 32;
            btnInserir_dgv.Text = "+";
            btnInserir_dgv.UseVisualStyleBackColor = false;
            btnInserir_dgv.Click += btnInserir_dgv_Click;
            // 
            // btnExcluir_dgv
            // 
            btnExcluir_dgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir_dgv.BackColor = SystemColors.Window;
            btnExcluir_dgv.FlatAppearance.BorderColor = Color.Black;
            btnExcluir_dgv.FlatAppearance.BorderSize = 2;
            btnExcluir_dgv.FlatStyle = FlatStyle.Flat;
            btnExcluir_dgv.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir_dgv.ForeColor = Color.Red;
            btnExcluir_dgv.Location = new Point(81, 336);
            btnExcluir_dgv.Name = "btnExcluir_dgv";
            btnExcluir_dgv.Size = new Size(52, 47);
            btnExcluir_dgv.TabIndex = 33;
            btnExcluir_dgv.Text = "X";
            btnExcluir_dgv.UseVisualStyleBackColor = false;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.MinimumWidth = 100;
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            Produto.Width = 213;
            // 
            // Preco
            // 
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            // 
            // form_adicionar_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(btnExcluir_dgv);
            Controls.Add(btnInserir_dgv);
            Controls.Add(dgv_adicionar_vendas);
            Controls.Add(txt_observacoes);
            Controls.Add(btnCancelar);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_valortotal);
            Controls.Add(label6);
            Controls.Add(btn_Salvar);
            Controls.Add(cbx_produtos_addvenda);
            Controls.Add(cbx_cliente_addvenda);
            Controls.Add(label5);
            Controls.Add(rdbtn_nao);
            Controls.Add(rdbtn_sim);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(800, 500);
            Name = "form_adicionar_venda";
            Text = "Adicionar Venda";
            Load += form_adicionar_venda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_adicionar_vendas).EndInit();
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
        private ComboBox cbx_cliente_addvenda;
        private ComboBox cbx_produtos_addvenda;
        private Button btn_Salvar;
        private Label label6;
        private Label lbl_valortotal;
        private Button btn_Calcular;
        private Button btnCancelar;
        private TextBox txt_observacoes;
        private DataGridView dgv_adicionar_vendas;
        private Button btnInserir_dgv;
        private Button btnExcluir_dgv;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Preco;
    }
}