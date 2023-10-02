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
            cbx_clientes_addvenda = new ComboBox();
            btn_Salvar = new Button();
            label6 = new Label();
            lbl_valortotal = new Label();
            btn_Calcular = new Button();
            btnCancelar = new Button();
            txt_observacoes = new TextBox();
            dgv_adicionar_vendas = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            btn_Remover = new Button();
            cbx_produtos_addvenda = new ComboBox();
            label7 = new Label();
            comboBox4 = new ComboBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox3 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            label14 = new Label();
            comboBox8 = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_adicionar_vendas).BeginInit();
            groupBox1.SuspendLayout();
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
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(633, 111);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 5;
            label4.Text = "Fazer Entrega?";
            label4.Click += label4_Click;
            // 
            // rdbtn_sim
            // 
            rdbtn_sim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdbtn_sim.AutoSize = true;
            rdbtn_sim.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbtn_sim.Location = new Point(634, 132);
            rdbtn_sim.Name = "rdbtn_sim";
            rdbtn_sim.Size = new Size(54, 22);
            rdbtn_sim.TabIndex = 6;
            rdbtn_sim.TabStop = true;
            rdbtn_sim.Text = "Sim";
            rdbtn_sim.UseVisualStyleBackColor = true;
            rdbtn_sim.CheckedChanged += rdbtn_sim_CheckedChanged;
            // 
            // rdbtn_nao
            // 
            rdbtn_nao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdbtn_nao.AutoSize = true;
            rdbtn_nao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbtn_nao.Location = new Point(694, 132);
            rdbtn_nao.Name = "rdbtn_nao";
            rdbtn_nao.Size = new Size(55, 22);
            rdbtn_nao.TabIndex = 7;
            rdbtn_nao.TabStop = true;
            rdbtn_nao.Text = "Não";
            rdbtn_nao.UseVisualStyleBackColor = true;
            rdbtn_nao.CheckedChanged += rdbtn_nao_CheckedChanged;
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
            btn_Salvar.Location = new Point(643, 522);
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
            label6.Location = new Point(542, 500);
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
            lbl_valortotal.Location = new Point(643, 500);
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
            btn_Calcular.Location = new Point(521, 522);
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
            btnCancelar.Location = new Point(12, 524);
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
            txt_observacoes.Location = new Point(12, 382);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira observações sobre a(s) pizza(s)";
            txt_observacoes.Size = new Size(760, 113);
            txt_observacoes.TabIndex = 30;
            txt_observacoes.TextChanged += txt_observacoes_TextChanged;
            // 
            // dgv_adicionar_vendas
            // 
            dgv_adicionar_vendas.AllowUserToAddRows = false;
            dgv_adicionar_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adicionar_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adicionar_vendas.Columns.AddRange(new DataGridViewColumn[] { Produto, Preco });
            dgv_adicionar_vendas.Location = new Point(12, 215);
            dgv_adicionar_vendas.Name = "dgv_adicionar_vendas";
            dgv_adicionar_vendas.ReadOnly = true;
            dgv_adicionar_vendas.RowTemplate.Height = 25;
            dgv_adicionar_vendas.Size = new Size(760, 161);
            dgv_adicionar_vendas.TabIndex = 31;
            dgv_adicionar_vendas.CellContentClick += dgv_adicionar_vendas_CellContentClick;
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
            // btn_Remover
            // 
            btn_Remover.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Remover.BackColor = SystemColors.Window;
            btn_Remover.FlatAppearance.BorderColor = Color.Black;
            btn_Remover.FlatAppearance.BorderSize = 2;
            btn_Remover.FlatStyle = FlatStyle.Flat;
            btn_Remover.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Remover.Location = new Point(134, 524);
            btn_Remover.Name = "btn_Remover";
            btn_Remover.Size = new Size(116, 41);
            btn_Remover.TabIndex = 32;
            btn_Remover.Text = "Remover";
            btn_Remover.UseVisualStyleBackColor = false;
            btn_Remover.Click += btn_Remover_Click;
            // 
            // cbx_produtos_addvenda
            // 
            cbx_produtos_addvenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_produtos_addvenda.FormattingEnabled = true;
            cbx_produtos_addvenda.Location = new Point(97, 45);
            cbx_produtos_addvenda.MaximumSize = new Size(300, 0);
            cbx_produtos_addvenda.Name = "cbx_produtos_addvenda";
            cbx_produtos_addvenda.Size = new Size(238, 26);
            cbx_produtos_addvenda.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(97, 24);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 36;
            label7.Text = "Grande";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(97, 70);
            comboBox4.MaximumSize = new Size(300, 0);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(238, 26);
            comboBox4.TabIndex = 37;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(341, 70);
            comboBox1.MaximumSize = new Size(300, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 26);
            comboBox1.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(341, 24);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 39;
            label8.Text = "Broto";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(341, 45);
            comboBox2.MaximumSize = new Size(300, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 26);
            comboBox2.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 48);
            label9.Name = "label9";
            label9.Size = new Size(72, 18);
            label9.TabIndex = 41;
            label9.Text = "Pizzas 1)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(18, 73);
            label10.Name = "label10";
            label10.Size = new Size(72, 18);
            label10.TabIndex = 42;
            label10.Text = "Pizzas 2)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 98);
            label11.Name = "label11";
            label11.Size = new Size(78, 18);
            label11.TabIndex = 43;
            label11.Text = "Especiais";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(36, 123);
            label12.Name = "label12";
            label12.Size = new Size(54, 18);
            label12.TabIndex = 44;
            label12.Text = "Doces";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(341, 120);
            comboBox3.MaximumSize = new Size(300, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(236, 26);
            comboBox3.TabIndex = 48;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(341, 95);
            comboBox5.MaximumSize = new Size(300, 0);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(236, 26);
            comboBox5.TabIndex = 47;
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(97, 120);
            comboBox6.MaximumSize = new Size(300, 0);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(238, 26);
            comboBox6.TabIndex = 46;
            // 
            // comboBox7
            // 
            comboBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(97, 95);
            comboBox7.MaximumSize = new Size(300, 0);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(238, 26);
            comboBox7.TabIndex = 45;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(612, 45);
            label14.Name = "label14";
            label14.Size = new Size(67, 18);
            label14.TabIndex = 50;
            label14.Text = "Bebidas";
            label14.Click += label14_Click;
            // 
            // comboBox8
            // 
            comboBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(612, 66);
            comboBox8.MaximumSize = new Size(300, 0);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(160, 23);
            comboBox8.TabIndex = 49;
            comboBox8.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox7);
            groupBox1.Controls.Add(cbx_produtos_addvenda);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 33);
            groupBox1.MaximumSize = new Size(600, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(594, 161);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizzas:";
            // 
            // form_adicionar_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 577);
            Controls.Add(label14);
            Controls.Add(comboBox8);
            Controls.Add(btn_Remover);
            Controls.Add(dgv_adicionar_vendas);
            Controls.Add(txt_observacoes);
            Controls.Add(btnCancelar);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_valortotal);
            Controls.Add(label6);
            Controls.Add(btn_Salvar);
            Controls.Add(cbx_clientes_addvenda);
            Controls.Add(label5);
            Controls.Add(rdbtn_nao);
            Controls.Add(rdbtn_sim);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(800, 500);
            Name = "form_adicionar_venda";
            Text = "Adicionar Venda";
            Load += form_adicionar_venda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_adicionar_vendas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btn_Calcular;
        private Button btnCancelar;
        private TextBox txt_observacoes;
        private DataGridView dgv_adicionar_vendas;
        private Button btnInserir_dgv;
        private Button btnExcluir_dgv;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Preco;
        private Button btn_Remover;
        private Button button1;
        private ComboBox cbx_produtos_addvenda;
        private Label label7;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboBox3;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label label14;
        private ComboBox comboBox8;
        private GroupBox groupBox1;
    }
}