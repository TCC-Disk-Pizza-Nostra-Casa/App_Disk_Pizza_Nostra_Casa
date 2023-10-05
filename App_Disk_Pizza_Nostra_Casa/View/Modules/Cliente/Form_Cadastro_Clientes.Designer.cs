namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Cliente
{
    partial class form_cadastro_clientes
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
            btn_cancelar = new Button();
            btn_salvar = new Button();
            label2 = new Label();
            txt_observacoes_cliente = new TextBox();
            label5 = new Label();
            txt_telefone_cliente = new TextBox();
            label4 = new Label();
            txt_email_cliente = new TextBox();
            txt_nome_cliente = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_observacoes_cliente);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_telefone_cliente);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_email_cliente);
            panel1.Controls.Add(txt_nome_cliente);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 461);
            panel1.TabIndex = 0;
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
            btn_cancelar.Click += btn_cancelar_Click;
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
            btn_salvar.Click += btn_salvar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 175);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 40;
            label2.Text = "Observações:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_observacoes_cliente
            // 
            txt_observacoes_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes_cliente.Location = new Point(12, 207);
            txt_observacoes_cliente.Multiline = true;
            txt_observacoes_cliente.Name = "txt_observacoes_cliente";
            txt_observacoes_cliente.PlaceholderText = "Insira observações sobre o cliente...(campo não obrigatório).";
            txt_observacoes_cliente.Size = new Size(760, 179);
            txt_observacoes_cliente.TabIndex = 39;
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
            // txt_telefone_cliente
            // 
            txt_telefone_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_telefone_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone_cliente.Location = new Point(183, 94);
            txt_telefone_cliente.Name = "txt_telefone_cliente";
            txt_telefone_cliente.PlaceholderText = "Insira o telefone...";
            txt_telefone_cliente.Size = new Size(589, 26);
            txt_telefone_cliente.TabIndex = 37;
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
            // txt_email_cliente
            // 
            txt_email_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email_cliente.Location = new Point(183, 53);
            txt_email_cliente.Name = "txt_email_cliente";
            txt_email_cliente.PlaceholderText = "Insira o e-mail...";
            txt_email_cliente.Size = new Size(589, 26);
            txt_email_cliente.TabIndex = 35;
            // 
            // txt_nome_cliente
            // 
            txt_nome_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_cliente.Location = new Point(183, 12);
            txt_nome_cliente.Name = "txt_nome_cliente";
            txt_nome_cliente.PlaceholderText = "Insira o nome do cliente...";
            txt_nome_cliente.Size = new Size(589, 26);
            txt_nome_cliente.TabIndex = 12;
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
            // form_cadastro_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_clientes";
            Text = "Cadastro de Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txt_nome_cliente;
        private TextBox txt_email_cliente;
        private Label label4;
        private Label label5;
        private TextBox txt_telefone_cliente;
        private Label label2;
        private TextBox txt_observacoes_cliente;
        private Button btn_cancelar;
        private Button btn_salvar;
    }
}