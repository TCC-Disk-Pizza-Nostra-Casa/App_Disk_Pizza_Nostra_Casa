namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Funcionario
{
    partial class form_cadastro_funcionarios
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
            btn_salvar = new Button();
            btn_cancelar = new Button();
            pnl_campos = new Panel();
            pnl_divisao_direita = new Panel();
            pnl_divisao_esquerda = new Panel();
            lbl_observacoes = new Label();
            lbl_senha = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ckbox_administrador = new CheckBox();
            pnl_campos.SuspendLayout();
            SuspendLayout();
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
            btn_salvar.TabIndex = 33;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar.FlatAppearance.BorderSize = 2;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(534, 410);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(116, 39);
            btn_cancelar.TabIndex = 34;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // pnl_campos
            // 
            pnl_campos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_campos.BorderStyle = BorderStyle.FixedSingle;
            pnl_campos.Controls.Add(pnl_divisao_direita);
            pnl_campos.Controls.Add(pnl_divisao_esquerda);
            pnl_campos.Location = new Point(12, 12);
            pnl_campos.Name = "pnl_campos";
            pnl_campos.Size = new Size(760, 236);
            pnl_campos.TabIndex = 35;
            // 
            // pnl_divisao_direita
            // 
            pnl_divisao_direita.Dock = DockStyle.Right;
            pnl_divisao_direita.Location = new Point(383, 0);
            pnl_divisao_direita.Name = "pnl_divisao_direita";
            pnl_divisao_direita.Size = new Size(375, 234);
            pnl_divisao_direita.TabIndex = 1;
            // 
            // pnl_divisao_esquerda
            // 
            pnl_divisao_esquerda.Dock = DockStyle.Left;
            pnl_divisao_esquerda.Location = new Point(0, 0);
            pnl_divisao_esquerda.Name = "pnl_divisao_esquerda";
            pnl_divisao_esquerda.Size = new Size(375, 234);
            pnl_divisao_esquerda.TabIndex = 0;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.AutoSize = true;
            lbl_observacoes.BackColor = Color.Transparent;
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.Location = new Point(12, 326);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(116, 19);
            lbl_observacoes.TabIndex = 36;
            lbl_observacoes.Text = "Observações:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(12, 260);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 19);
            lbl_senha.TabIndex = 37;
            lbl_senha.Text = "Senha:";
            lbl_senha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(760, 23);
            textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(12, 360);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(760, 32);
            textBox2.TabIndex = 39;
            // 
            // ckbox_administrador
            // 
            ckbox_administrador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ckbox_administrador.AutoSize = true;
            ckbox_administrador.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbox_administrador.Location = new Point(12, 426);
            ckbox_administrador.Name = "ckbox_administrador";
            ckbox_administrador.Size = new Size(136, 23);
            ckbox_administrador.TabIndex = 40;
            ckbox_administrador.Text = "Administrador";
            ckbox_administrador.UseVisualStyleBackColor = true;
            // 
            // form_cadastro_funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(ckbox_administrador);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_observacoes);
            Controls.Add(pnl_campos);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            MinimumSize = new Size(800, 496);
            Name = "form_cadastro_funcionarios";
            Text = "Cadastro de Funcionários";
            Load += form_cadastro_funcionarios_Load;
            pnl_campos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private Button btn_cancelar;
        private Panel pnl_campos;
        private Panel pnl_divisao_direita;
        private Panel pnl_divisao_esquerda;
        private Label lbl_observacoes;
        private Label lbl_senha;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox ckbox_administrador;
    }
}