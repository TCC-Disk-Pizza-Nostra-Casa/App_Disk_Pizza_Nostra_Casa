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
            lbl_usuario = new Label();
            lbl_senha = new Label();
            label1 = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            label3 = new Label();
            btn_entrar = new Button();
            pnl_imagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbox_imagem).BeginInit();
            SuspendLayout();
            // 
            // pnl_imagem
            // 
            pnl_imagem.BackColor = Color.FromArgb(130, 69, 34);
            pnl_imagem.Controls.Add(pctbox_imagem);
            pnl_imagem.Dock = DockStyle.Left;
            pnl_imagem.Location = new Point(0, 0);
            pnl_imagem.Margin = new Padding(4);
            pnl_imagem.Name = "pnl_imagem";
            pnl_imagem.Size = new Size(500, 540);
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
            pctbox_imagem.Size = new Size(500, 540);
            pctbox_imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbox_imagem.TabIndex = 1;
            pctbox_imagem.TabStop = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuario.ForeColor = Color.Black;
            lbl_usuario.Location = new Point(734, 131);
            lbl_usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(75, 19);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuário:";
            lbl_usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.ForeColor = Color.Black;
            lbl_senha.Location = new Point(734, 272);
            lbl_senha.Margin = new Padding(4, 0, 4, 0);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 19);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha:";
            lbl_senha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(130, 69, 34);
            label1.Location = new Point(635, 179);
            label1.Name = "label1";
            label1.Size = new Size(269, 18);
            label1.TabIndex = 6;
            label1.Text = "_____________________________";
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_usuario.BackColor = SystemColors.Control;
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.ForeColor = Color.Black;
            txt_usuario.Location = new Point(635, 171);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Digite seu nome completo";
            txt_usuario.Size = new Size(269, 19);
            txt_usuario.TabIndex = 7;
            txt_usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.BackColor = SystemColors.Control;
            txt_senha.BorderStyle = BorderStyle.None;
            txt_senha.ForeColor = Color.Black;
            txt_senha.Location = new Point(635, 306);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Digite sua senha";
            txt_senha.Size = new Size(269, 19);
            txt_senha.TabIndex = 9;
            txt_senha.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 69, 34);
            label3.Location = new Point(635, 314);
            label3.Name = "label3";
            label3.Size = new Size(269, 18);
            label3.TabIndex = 8;
            label3.Text = "_____________________________";
            // 
            // btn_entrar
            // 
            btn_entrar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_entrar.BackColor = Color.Transparent;
            btn_entrar.FlatAppearance.BorderColor = Color.Black;
            btn_entrar.FlatAppearance.BorderSize = 2;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.Black;
            btn_entrar.Location = new Point(705, 409);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(122, 36);
            btn_entrar.TabIndex = 10;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 540);
            Controls.Add(btn_entrar);
            Controls.Add(txt_senha);
            Controls.Add(label3);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(pnl_imagem);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(1045, 579);
            MinimumSize = new Size(1045, 579);
            Name = "form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Login";
            Load += form_login_Load;
            pnl_imagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctbox_imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_imagem;
        private PictureBox pctbox_imagem;
        private Label lbl_usuario;
        private Label lbl_senha;
        private Label label1;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label label3;
        private Button btn_entrar;
    }
}