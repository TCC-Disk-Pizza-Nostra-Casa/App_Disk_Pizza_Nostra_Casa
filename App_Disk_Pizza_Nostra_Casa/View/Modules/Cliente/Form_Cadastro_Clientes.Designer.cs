namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Cliente
{
    partial class Form_Cadastro_Clientes
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
            panel1 = new Panel();
            label1 = new Label();
            txt_nome_produto = new TextBox();
            txt_estoque_produto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txt_observacoes_produto = new TextBox();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_observacoes_produto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_estoque_produto);
            panel1.Controls.Add(txt_nome_produto);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 461);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(141, 26);
            label1.TabIndex = 10;
            label1.Text = "Nome do Cliente:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_nome_produto
            // 
            txt_nome_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_produto.Location = new Point(183, 12);
            txt_nome_produto.Name = "txt_nome_produto";
            txt_nome_produto.PlaceholderText = "Insira o nome do produto...";
            txt_nome_produto.Size = new Size(589, 26);
            txt_nome_produto.TabIndex = 12;
            // 
            // txt_estoque_produto
            // 
            txt_estoque_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_estoque_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_estoque_produto.Location = new Point(183, 53);
            txt_estoque_produto.Name = "txt_estoque_produto";
            txt_estoque_produto.PlaceholderText = "Insira o e-mail...";
            txt_estoque_produto.Size = new Size(589, 26);
            txt_estoque_produto.TabIndex = 35;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(72, 26);
            label4.TabIndex = 36;
            label4.Text = "E-mail:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 94);
            label5.Name = "label5";
            label5.Size = new Size(80, 26);
            label5.TabIndex = 38;
            label5.Text = "Telefone:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(183, 94);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Insira o telefone...";
            textBox1.Size = new Size(589, 26);
            textBox1.TabIndex = 37;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 40;
            label2.Text = "Observações:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_observacoes_produto
            // 
            txt_observacoes_produto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes_produto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes_produto.Location = new Point(12, 168);
            txt_observacoes_produto.Multiline = true;
            txt_observacoes_produto.Name = "txt_observacoes_produto";
            txt_observacoes_produto.PlaceholderText = "Insira observações sobre o produto...(campo não obrigatório).";
            txt_observacoes_produto.Size = new Size(760, 218);
            txt_observacoes_produto.TabIndex = 39;
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
            btn_cancelar.TabIndex = 42;
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
            btn_salvar.TabIndex = 41;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            // 
            // Form_Cadastro_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "Form_Cadastro_Clientes";
            Text = "Form_Cadastro_Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txt_nome_produto;
        private TextBox txt_estoque_produto;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label2;
        private TextBox txt_observacoes_produto;
        private Button btn_cancelar;
        private Button btn_salvar;
    }
}