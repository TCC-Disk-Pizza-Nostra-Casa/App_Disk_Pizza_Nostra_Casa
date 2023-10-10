namespace App_Disk_Pizza_Nostra_Casa
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            mtxt_cpf = new MaskedTextBox();
            lbl_senha = new Label();
            btn_entrar = new Button();
            txt_senha = new TextBox();
            lbl_cep = new Label();
            pctbox_boneco = new PictureBox();
            lbl_saudacao = new Label();
            ((System.ComponentModel.ISupportInitialize)pctbox_boneco).BeginInit();
            SuspendLayout();
            // 
            // mtxt_cpf
            // 
            mtxt_cpf.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mtxt_cpf.BackColor = Color.White;
            mtxt_cpf.BorderStyle = BorderStyle.FixedSingle;
            mtxt_cpf.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            mtxt_cpf.ForeColor = Color.Black;
            mtxt_cpf.Location = new Point(297, 124);
            mtxt_cpf.Mask = "000,000,000-00";
            mtxt_cpf.Name = "mtxt_cpf";
            mtxt_cpf.Size = new Size(263, 26);
            mtxt_cpf.TabIndex = 4;
            mtxt_cpf.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.ForeColor = Color.Black;
            lbl_senha.Location = new Point(292, 205);
            lbl_senha.Margin = new Padding(4, 0, 4, 0);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 19);
            lbl_senha.TabIndex = 6;
            lbl_senha.Text = "Senha:";
            lbl_senha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_entrar
            // 
            btn_entrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_entrar.BackColor = Color.Transparent;
            btn_entrar.FlatAppearance.BorderColor = Color.Black;
            btn_entrar.FlatAppearance.BorderSize = 2;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.Black;
            btn_entrar.Location = new Point(370, 313);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(122, 36);
            btn_entrar.TabIndex = 8;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.BackColor = Color.White;
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            txt_senha.ForeColor = Color.Black;
            txt_senha.Location = new Point(297, 236);
            txt_senha.MaxLength = 20;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Digite sua senha...";
            txt_senha.Size = new Size(263, 26);
            txt_senha.TabIndex = 7;
            txt_senha.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_cep
            // 
            lbl_cep.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cep.AutoSize = true;
            lbl_cep.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cep.ForeColor = Color.Black;
            lbl_cep.Location = new Point(292, 93);
            lbl_cep.Margin = new Padding(4, 0, 4, 0);
            lbl_cep.Name = "lbl_cep";
            lbl_cep.Size = new Size(48, 19);
            lbl_cep.TabIndex = 5;
            lbl_cep.Text = "CPF:";
            lbl_cep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pctbox_boneco
            // 
            pctbox_boneco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pctbox_boneco.BackColor = Color.Transparent;
            pctbox_boneco.Image = (Image)resources.GetObject("pctbox_boneco.Image");
            pctbox_boneco.Location = new Point(12, 12);
            pctbox_boneco.Name = "pctbox_boneco";
            pctbox_boneco.Size = new Size(265, 337);
            pctbox_boneco.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbox_boneco.TabIndex = 9;
            pctbox_boneco.TabStop = false;
            // 
            // lbl_saudacao
            // 
            lbl_saudacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_saudacao.AutoSize = true;
            lbl_saudacao.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_saudacao.Location = new Point(297, 12);
            lbl_saudacao.Name = "lbl_saudacao";
            lbl_saudacao.Size = new Size(263, 37);
            lbl_saudacao.TabIndex = 10;
            lbl_saudacao.Text = "Seja bem-vindo!";
            lbl_saudacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 361);
            Controls.Add(lbl_saudacao);
            Controls.Add(pctbox_boneco);
            Controls.Add(mtxt_cpf);
            Controls.Add(lbl_senha);
            Controls.Add(btn_entrar);
            Controls.Add(txt_senha);
            Controls.Add(lbl_cep);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Login";
            Load += form_login_Load;
            ((System.ComponentModel.ISupportInitialize)pctbox_boneco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxt_cpf;
        private Label lbl_senha;
        private Button btn_entrar;
        private TextBox txt_senha;
        private Label lbl_cep;
        private PictureBox pctbox_boneco;
        private Label lbl_saudacao;
    }
}