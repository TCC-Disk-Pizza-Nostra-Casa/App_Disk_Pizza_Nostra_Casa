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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            cbx_cliente_addvenda = new ComboBox();
            cbx_pizzas_addvenda = new ComboBox();
            cbx_bebidas_addvenda = new ComboBox();
            btn_Salvar = new Button();
            btn_Limpar = new Button();
            label6 = new Label();
            lbl_valortotal = new Label();
            btn_Calcular = new Button();
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
            label3.Location = new Point(12, 57);
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(147, 143);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 22);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sim";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(209, 143);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 22);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não";
            radioButton2.UseVisualStyleBackColor = true;
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
            cbx_cliente_addvenda.FormattingEnabled = true;
            cbx_cliente_addvenda.Location = new Point(147, 9);
            cbx_cliente_addvenda.Name = "cbx_cliente_addvenda";
            cbx_cliente_addvenda.Size = new Size(294, 23);
            cbx_cliente_addvenda.TabIndex = 10;
            // 
            // cbx_pizzas_addvenda
            // 
            cbx_pizzas_addvenda.FormattingEnabled = true;
            cbx_pizzas_addvenda.Location = new Point(147, 57);
            cbx_pizzas_addvenda.Name = "cbx_pizzas_addvenda";
            cbx_pizzas_addvenda.Size = new Size(294, 23);
            cbx_pizzas_addvenda.TabIndex = 11;
            // 
            // cbx_bebidas_addvenda
            // 
            cbx_bebidas_addvenda.FormattingEnabled = true;
            cbx_bebidas_addvenda.Location = new Point(147, 99);
            cbx_bebidas_addvenda.Name = "cbx_bebidas_addvenda";
            cbx_bebidas_addvenda.Size = new Size(294, 23);
            cbx_bebidas_addvenda.TabIndex = 12;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Salvar.Location = new Point(656, 408);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(116, 41);
            btn_Salvar.TabIndex = 13;
            btn_Salvar.Text = "Salvar Pedido";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(12, 408);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(134, 41);
            btn_Limpar.TabIndex = 14;
            btn_Limpar.Text = "Limpar Campos";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(555, 358);
            label6.Name = "label6";
            label6.Size = new Size(95, 19);
            label6.TabIndex = 15;
            label6.Text = "Valor Total:";
            // 
            // lbl_valortotal
            // 
            lbl_valortotal.AutoSize = true;
            lbl_valortotal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valortotal.Location = new Point(656, 359);
            lbl_valortotal.Name = "lbl_valortotal";
            lbl_valortotal.Size = new Size(18, 19);
            lbl_valortotal.TabIndex = 16;
            lbl_valortotal.Text = "0";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(534, 408);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(116, 41);
            btn_Calcular.TabIndex = 17;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // form_adicionar_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_valortotal);
            Controls.Add(label6);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Salvar);
            Controls.Add(cbx_bebidas_addvenda);
            Controls.Add(cbx_pizzas_addvenda);
            Controls.Add(cbx_cliente_addvenda);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private ComboBox cbx_cliente_addvenda;
        private ComboBox cbx_pizzas_addvenda;
        private ComboBox cbx_bebidas_addvenda;
        private Button btn_Salvar;
        private Button btn_Limpar;
        private Label label6;
        private Label lbl_valortotal;
        private Button btn_Calcular;
    }
}