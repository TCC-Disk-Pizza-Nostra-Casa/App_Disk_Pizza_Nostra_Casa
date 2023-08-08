namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Login
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
            pnl_imagem = new Panel();
            pctbox_imagem = new PictureBox();
            lbl_cep = new Label();
            lbl_senha = new Label();
            txt_cpf = new TextBox();
            txt_senha = new TextBox();
            btn_entrar = new Button();
            panel1 = new Panel();
            pnl_imagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbox_imagem).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_imagem
            // 
            pnl_imagem.BackColor = Color.FromArgb(130, 69, 34);
            pnl_imagem.BorderStyle = BorderStyle.FixedSingle;
            pnl_imagem.Controls.Add(pctbox_imagem);
            pnl_imagem.Dock = DockStyle.Left;
            pnl_imagem.Location = new Point(0, 0);
            pnl_imagem.Margin = new Padding(4);
            pnl_imagem.Name = "pnl_imagem";
            pnl_imagem.Size = new Size(349, 361);
            pnl_imagem.TabIndex = 0;
            // 
            // pctbox_imagem
            // 
            pctbox_imagem.BackColor = Color.Transparent;
            pctbox_imagem.Dock = DockStyle.Fill;
            pctbox_imagem.Image = (Image)resources.GetObject("pctbox_imagem.Image");
            pctbox_imagem.Location = new Point(0, 0);
            pctbox_imagem.Margin = new Padding(4);
            pctbox_imagem.Name = "pctbox_imagem";
            pctbox_imagem.Size = new Size(347, 359);
            pctbox_imagem.SizeMode = PictureBoxSizeMode.Zoom;
            pctbox_imagem.TabIndex = 1;
            pctbox_imagem.TabStop = false;
            // 
            // lbl_cep
            // 
            lbl_cep.Anchor = AnchorStyles.None;
            lbl_cep.AutoSize = true;
            lbl_cep.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cep.ForeColor = Color.Black;
            lbl_cep.Location = new Point(145, 49);
            lbl_cep.Margin = new Padding(4, 0, 4, 0);
            lbl_cep.Name = "lbl_cep";
            lbl_cep.Size = new Size(48, 19);
            lbl_cep.TabIndex = 1;
            lbl_cep.Text = "CPF:";
            lbl_cep.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.None;
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.ForeColor = Color.Black;
            lbl_senha.Location = new Point(133, 172);
            lbl_senha.Margin = new Padding(4, 0, 4, 0);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 19);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha:";
            lbl_senha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_cpf
            // 
            txt_cpf.Anchor = AnchorStyles.None;
            txt_cpf.BackColor = SystemColors.Control;
            txt_cpf.BorderStyle = BorderStyle.None;
            txt_cpf.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            txt_cpf.ForeColor = Color.Black;
            txt_cpf.Location = new Point(27, 93);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.PlaceholderText = "Digite seu CPF...";
            txt_cpf.Size = new Size(278, 19);
            txt_cpf.TabIndex = 7;
            txt_cpf.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.None;
            txt_senha.BackColor = SystemColors.Control;
            txt_senha.BorderStyle = BorderStyle.None;
            txt_senha.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            txt_senha.ForeColor = Color.Black;
            txt_senha.Location = new Point(27, 216);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Digite sua senha...";
            txt_senha.Size = new Size(278, 19);
            txt_senha.TabIndex = 9;
            txt_senha.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_entrar
            // 
            btn_entrar.Anchor = AnchorStyles.None;
            btn_entrar.BackColor = Color.Transparent;
            btn_entrar.FlatAppearance.BorderColor = Color.Black;
            btn_entrar.FlatAppearance.BorderSize = 2;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.Black;
            btn_entrar.Location = new Point(105, 286);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(122, 36);
            btn_entrar.TabIndex = 10;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbl_senha);
            panel1.Controls.Add(btn_entrar);
            panel1.Controls.Add(txt_cpf);
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(lbl_cep);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(349, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 361);
            panel1.TabIndex = 11;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(684, 361);
            Controls.Add(panel1);
            Controls.Add(pnl_imagem);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Login";
            Load += form_login_Load;
            pnl_imagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctbox_imagem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_imagem;
        private PictureBox pctbox_imagem;
        private Label lbl_cep;
        private Label lbl_senha;
        private TextBox txt_cpf;
        private TextBox txt_senha;
        private Button btn_entrar;
        private Panel panel1;
    }
}