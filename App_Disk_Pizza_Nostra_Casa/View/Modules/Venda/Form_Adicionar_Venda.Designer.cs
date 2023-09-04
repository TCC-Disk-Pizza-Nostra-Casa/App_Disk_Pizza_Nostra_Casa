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
            cbx_pizzas_addvenda = new ComboBox();
            cbx_bebidas_addvenda = new ComboBox();
            btn_Salvar = new Button();
            label6 = new Label();
            lbl_valortotal = new Label();
            btn_Calcular = new Button();
            btnCancelar = new Button();
            txt_observacoes = new TextBox();
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
            label3.Size = new Size(58, 18);
            label3.TabIndex = 2;
            label3.Text = "Pizzas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 5;
            label4.Text = "Fazer Entrega?";
            // 
            // rdbtn_sim
            // 
            rdbtn_sim.AutoSize = true;
            rdbtn_sim.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbtn_sim.Location = new Point(147, 143);
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
            rdbtn_nao.Location = new Point(209, 143);
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
            label5.Size = new Size(71, 18);
            label5.TabIndex = 8;
            label5.Text = "Bebidas:";
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
            // 
            // cbx_pizzas_addvenda
            // 
            cbx_pizzas_addvenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_pizzas_addvenda.FormattingEnabled = true;
            cbx_pizzas_addvenda.Location = new Point(147, 53);
            cbx_pizzas_addvenda.Name = "cbx_pizzas_addvenda";
            cbx_pizzas_addvenda.Size = new Size(625, 23);
            cbx_pizzas_addvenda.TabIndex = 11;
            // 
            // cbx_bebidas_addvenda
            // 
            cbx_bebidas_addvenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_bebidas_addvenda.FormattingEnabled = true;
            cbx_bebidas_addvenda.Location = new Point(147, 99);
            cbx_bebidas_addvenda.Name = "cbx_bebidas_addvenda";
            cbx_bebidas_addvenda.Size = new Size(625, 23);
            cbx_bebidas_addvenda.TabIndex = 12;
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
            txt_observacoes.Location = new Point(12, 171);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira observações sobre a(s) pizza(s)";
            txt_observacoes.Size = new Size(758, 196);
            txt_observacoes.TabIndex = 30;
            // 
            // form_adicionar_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(txt_observacoes);
            Controls.Add(btnCancelar);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_valortotal);
            Controls.Add(label6);
            Controls.Add(btn_Salvar);
            Controls.Add(cbx_bebidas_addvenda);
            Controls.Add(cbx_pizzas_addvenda);
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
        private ComboBox cbx_pizzas_addvenda;
        private ComboBox cbx_bebidas_addvenda;
        private Button btn_Salvar;
        private Label label6;
        private Label lbl_valortotal;
        private Button btn_Calcular;
        private Button btnCancelar;
        private TextBox txt_observacoes;
    }
}