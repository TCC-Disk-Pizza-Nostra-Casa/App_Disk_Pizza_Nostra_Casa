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
            txt_senha = new TextBox();
            txt_email = new TextBox();
            txt_nome = new TextBox();
            ckbox_administrador = new CheckBox();
            lbl_nome = new Label();
            lbl_email = new Label();
            lbl_telefone = new Label();
            mtxt_telefone = new MaskedTextBox();
            lbl_genero = new Label();
            txt_genero = new TextBox();
            lbl_senha = new Label();
            pctbox_foto = new PictureBox();
            mtxt_cpf = new MaskedTextBox();
            lbl_cpf = new Label();
            ((System.ComponentModel.ISupportInitialize)pctbox_foto).BeginInit();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txt_senha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(88, 380);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(320, 26);
            txt_senha.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txt_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(88, 297);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(320, 26);
            txt_email.TabIndex = 3;
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(88, 12);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(320, 26);
            txt_nome.TabIndex = 4;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // ckbox_administrador
            // 
            ckbox_administrador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ckbox_administrador.AutoSize = true;
            ckbox_administrador.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbox_administrador.Location = new Point(15, 421);
            ckbox_administrador.Name = "ckbox_administrador";
            ckbox_administrador.Size = new Size(156, 28);
            ckbox_administrador.TabIndex = 5;
            ckbox_administrador.Text = "Administrador";
            ckbox_administrador.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nome.Location = new Point(12, 15);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(54, 18);
            lbl_nome.TabIndex = 6;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_email
            // 
            lbl_email.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email.Location = new Point(12, 300);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(57, 18);
            lbl_email.TabIndex = 7;
            lbl_email.Text = "E-mail:";
            // 
            // lbl_telefone
            // 
            lbl_telefone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefone.Location = new Point(12, 341);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(70, 18);
            lbl_telefone.TabIndex = 8;
            lbl_telefone.Text = "Telefone:";
            // 
            // mtxt_telefone
            // 
            mtxt_telefone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            mtxt_telefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_telefone.Location = new Point(88, 338);
            mtxt_telefone.Mask = "(00) 00000-0000";
            mtxt_telefone.Name = "mtxt_telefone";
            mtxt_telefone.Size = new Size(320, 26);
            mtxt_telefone.TabIndex = 9;
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_genero.Location = new Point(12, 56);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(64, 18);
            lbl_genero.TabIndex = 11;
            lbl_genero.Text = "Gênero:";
            // 
            // txt_genero
            // 
            txt_genero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_genero.Location = new Point(88, 53);
            txt_genero.Name = "txt_genero";
            txt_genero.Size = new Size(320, 26);
            txt_genero.TabIndex = 10;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha.Location = new Point(12, 383);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(57, 18);
            lbl_senha.TabIndex = 12;
            lbl_senha.Text = "Senha:";
            // 
            // pctbox_foto
            // 
            pctbox_foto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pctbox_foto.BorderStyle = BorderStyle.FixedSingle;
            pctbox_foto.Location = new Point(422, 12);
            pctbox_foto.Name = "pctbox_foto";
            pctbox_foto.Size = new Size(350, 438);
            pctbox_foto.SizeMode = PictureBoxSizeMode.AutoSize;
            pctbox_foto.TabIndex = 13;
            pctbox_foto.TabStop = false;
            // 
            // mtxt_cpf
            // 
            mtxt_cpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_cpf.Location = new Point(88, 94);
            mtxt_cpf.Mask = "000,000,000-00";
            mtxt_cpf.Name = "mtxt_cpf";
            mtxt_cpf.Size = new Size(320, 26);
            mtxt_cpf.TabIndex = 17;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cpf.Location = new Point(12, 97);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(45, 18);
            lbl_cpf.TabIndex = 16;
            lbl_cpf.Text = "CPF:";
            // 
            // form_cadastro_funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(mtxt_cpf);
            Controls.Add(lbl_cpf);
            Controls.Add(pctbox_foto);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_genero);
            Controls.Add(txt_genero);
            Controls.Add(mtxt_telefone);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_email);
            Controls.Add(lbl_nome);
            Controls.Add(ckbox_administrador);
            Controls.Add(txt_nome);
            Controls.Add(txt_email);
            Controls.Add(txt_senha);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_funcionarios";
            Text = "Cadastro de Funcionários";
            ((System.ComponentModel.ISupportInitialize)pctbox_foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_senha;
        private TextBox txt_email;
        private TextBox txt_nome;
        private CheckBox ckbox_administrador;
        private Label lbl_nome;
        private Label lbl_email;
        private Label lbl_telefone;
        private MaskedTextBox mtxt_telefone;
        private Label lbl_genero;
        private TextBox txt_genero;
        private Label lbl_senha;
        private PictureBox pctbox_foto;
        private MaskedTextBox mtxt_cpf;
        private Label lbl_cpf;
    }
}