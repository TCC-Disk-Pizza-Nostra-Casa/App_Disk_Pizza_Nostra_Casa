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
            btn_Calcular = new Button();
            btnCancelar = new Button();
            txt_observacoes = new TextBox();
            dgv_adicionar_vendas = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            btn_Remover = new Button();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            cbx_bebidas_addvenda = new ComboBox();
            cbox_delivery = new CheckBox();
            cbox_grande = new CheckBox();
            cbox_broto = new CheckBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            cbx_tradicionais_addvenda = new ComboBox();
            cbx_variadas_addvenda = new ComboBox();
            cbx_especiais_addvenda = new ComboBox();
            cbx_doces_addvenda = new ComboBox();
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
            label4.Location = new Point(384, 406);
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
            btn_Salvar.Location = new Point(643, 403);
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
            btn_Calcular.Location = new Point(521, 403);
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
            btnCancelar.Location = new Point(12, 403);
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
            txt_observacoes.Location = new Point(12, 291);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira observações sobre a(s) pizza(s)";
            txt_observacoes.Size = new Size(760, 88);
            txt_observacoes.TabIndex = 30;
            // 
            // dgv_adicionar_vendas
            // 
            dgv_adicionar_vendas.AllowUserToAddRows = false;
            dgv_adicionar_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adicionar_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adicionar_vendas.Columns.AddRange(new DataGridViewColumn[] { Produto, Preco });
            dgv_adicionar_vendas.Location = new Point(12, 178);
            dgv_adicionar_vendas.Name = "dgv_adicionar_vendas";
            dgv_adicionar_vendas.ReadOnly = true;
            dgv_adicionar_vendas.RowTemplate.Height = 25;
            dgv_adicionar_vendas.Size = new Size(760, 98);
            dgv_adicionar_vendas.TabIndex = 31;
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
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
            btn_Remover.Location = new Point(134, 403);
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
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(25, 65);
            label9.Name = "label9";
            label9.Size = new Size(93, 18);
            label9.TabIndex = 41;
            label9.Text = "Tradicionais";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(198, 66);
            label10.Name = "label10";
            label10.Size = new Size(71, 18);
            label10.TabIndex = 42;
            label10.Text = "Variádas";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(368, 66);
            label11.Name = "label11";
            label11.Size = new Size(78, 18);
            label11.TabIndex = 43;
            label11.Text = "Especiais";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(539, 65);
            label12.Name = "label12";
            label12.Size = new Size(54, 18);
            label12.TabIndex = 44;
            label12.Text = "Doces";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(708, 66);
            label14.Name = "label14";
            label14.Size = new Size(67, 18);
            label14.TabIndex = 50;
            label14.Text = "Bebidas";
            // 
            // cbx_bebidas_addvenda
            // 
            cbx_bebidas_addvenda.FormattingEnabled = true;
            cbx_bebidas_addvenda.Location = new Point(708, 92);
            cbx_bebidas_addvenda.MaximumSize = new Size(300, 0);
            cbx_bebidas_addvenda.Name = "cbx_bebidas_addvenda";
            cbx_bebidas_addvenda.Size = new Size(160, 26);
            cbx_bebidas_addvenda.TabIndex = 49;
            // 
            // cbox_delivery
            // 
            cbox_delivery.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbox_delivery.AutoSize = true;
            cbox_delivery.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_delivery.Location = new Point(387, 423);
            cbox_delivery.Name = "cbox_delivery";
            cbox_delivery.Size = new Size(55, 22);
            cbox_delivery.TabIndex = 52;
            cbox_delivery.Text = "Sim";
            cbox_delivery.UseVisualStyleBackColor = true;
            // 
            // cbox_grande
            // 
            cbox_grande.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbox_grande.AutoSize = true;
            cbox_grande.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_grande.Location = new Point(192, 33);
            cbox_grande.Name = "cbox_grande";
            cbox_grande.Size = new Size(79, 22);
            cbox_grande.TabIndex = 53;
            cbox_grande.Text = "Grande";
            cbox_grande.UseVisualStyleBackColor = true;
            // 
            // cbox_broto
            // 
            cbox_broto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbox_broto.AutoSize = true;
            cbox_broto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_broto.Location = new Point(277, 33);
            cbox_broto.Name = "cbox_broto";
            cbox_broto.Size = new Size(65, 22);
            cbox_broto.TabIndex = 54;
            cbox_broto.Text = "Broto";
            cbox_broto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbx_tradicionais_addvenda);
            groupBox2.Controls.Add(cbx_variadas_addvenda);
            groupBox2.Controls.Add(cbx_especiais_addvenda);
            groupBox2.Controls.Add(cbx_doces_addvenda);
            groupBox2.Controls.Add(cbox_broto);
            groupBox2.Controls.Add(cbx_bebidas_addvenda);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbox_grande);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 134);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pizzas:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(23, 34);
            label8.Name = "label8";
            label8.Size = new Size(169, 19);
            label8.TabIndex = 59;
            label8.Text = "TAMANHO DA PIZZA:";
            // 
            // cbx_tradicionais_addvenda
            // 
            cbx_tradicionais_addvenda.FormattingEnabled = true;
            cbx_tradicionais_addvenda.Location = new Point(28, 92);
            cbx_tradicionais_addvenda.MaximumSize = new Size(300, 0);
            cbx_tradicionais_addvenda.Name = "cbx_tradicionais_addvenda";
            cbx_tradicionais_addvenda.Size = new Size(160, 26);
            cbx_tradicionais_addvenda.TabIndex = 58;
            // 
            // cbx_variadas_addvenda
            // 
            cbx_variadas_addvenda.FormattingEnabled = true;
            cbx_variadas_addvenda.Location = new Point(198, 92);
            cbx_variadas_addvenda.MaximumSize = new Size(300, 0);
            cbx_variadas_addvenda.Name = "cbx_variadas_addvenda";
            cbx_variadas_addvenda.Size = new Size(160, 26);
            cbx_variadas_addvenda.TabIndex = 57;
            // 
            // cbx_especiais_addvenda
            // 
            cbx_especiais_addvenda.FormattingEnabled = true;
            cbx_especiais_addvenda.Location = new Point(368, 92);
            cbx_especiais_addvenda.MaximumSize = new Size(300, 0);
            cbx_especiais_addvenda.Name = "cbx_especiais_addvenda";
            cbx_especiais_addvenda.Size = new Size(160, 26);
            cbx_especiais_addvenda.TabIndex = 56;
            // 
            // cbx_doces_addvenda
            // 
            cbx_doces_addvenda.FormattingEnabled = true;
            cbx_doces_addvenda.Location = new Point(538, 92);
            cbx_doces_addvenda.MaximumSize = new Size(300, 0);
            cbx_doces_addvenda.Name = "cbx_doces_addvenda";
            cbx_doces_addvenda.Size = new Size(160, 26);
            cbx_doces_addvenda.TabIndex = 55;
            // 
            // form_adicionar_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(cbox_delivery);
            Controls.Add(label7);
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
            Controls.Add(label4);
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
        private Button btn_Calcular;
        private Button btnCancelar;
        private TextBox txt_observacoes;
        private DataGridView dgv_adicionar_vendas;
        private Button btnInserir_dgv;
        private Button btnExcluir_dgv;
        private Button btn_Remover;
        private Button button1;
        private ComboBox cbx_produtos_addvenda;
        private Label label7;
        private ComboBox cbx_tradicionais_addvenda;
        private ComboBox cbx_doces_addvenda;
        private ComboBox cbx_especiais_addvenda;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cbx_variadas_addvenda;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label label14;
        private ComboBox comboBox8;
        private CheckBox cbox_grande;
        private ComboBox cbx_bebidas_addvenda;
        private CheckBox cbox_delivery;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Preco;
        private CheckBox cbox_broto;
        private GroupBox groupBox2;
        private Label label8;
    }
}