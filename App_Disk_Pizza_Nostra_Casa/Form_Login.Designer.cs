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
            this.pnl_imagem = new System.Windows.Forms.Panel();
            this.pctbox_imagem = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.pnl_imagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_imagem
            // 
            this.pnl_imagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(69)))), ((int)(((byte)(34)))));
            this.pnl_imagem.Controls.Add(this.pctbox_imagem);
            this.pnl_imagem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_imagem.Location = new System.Drawing.Point(0, 0);
            this.pnl_imagem.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_imagem.Name = "pnl_imagem";
            this.pnl_imagem.Size = new System.Drawing.Size(500, 540);
            this.pnl_imagem.TabIndex = 0;
            // 
            // pctbox_imagem
            // 
            this.pctbox_imagem.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbox_imagem.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_imagem.Image")));
            this.pctbox_imagem.Location = new System.Drawing.Point(0, 0);
            this.pctbox_imagem.Margin = new System.Windows.Forms.Padding(4);
            this.pctbox_imagem.Name = "pctbox_imagem";
            this.pctbox_imagem.Size = new System.Drawing.Size(500, 540);
            this.pctbox_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_imagem.TabIndex = 1;
            this.pctbox_imagem.TabStop = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_usuario.Location = new System.Drawing.Point(734, 131);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(75, 19);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuário:";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_senha
            // 
            this.lbl_senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_senha.ForeColor = System.Drawing.Color.Black;
            this.lbl_senha.Location = new System.Drawing.Point(734, 272);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(64, 19);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha:";
            this.lbl_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(69)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(635, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "_____________________________";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(635, 171);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Digite seu nome completo";
            this.txt_usuario.Size = new System.Drawing.Size(269, 19);
            this.txt_usuario.TabIndex = 7;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.Control;
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.ForeColor = System.Drawing.Color.Black;
            this.txt_senha.Location = new System.Drawing.Point(635, 306);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PlaceholderText = "Digite sua senha";
            this.txt_senha.Size = new System.Drawing.Size(269, 19);
            this.txt_senha.TabIndex = 9;
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(69)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(635, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "_____________________________";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_entrar.FlatAppearance.BorderSize = 2;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar.ForeColor = System.Drawing.Color.Black;
            this.btn_entrar.Location = new System.Drawing.Point(705, 409);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(122, 36);
            this.btn_entrar.TabIndex = 10;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1029, 540);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.pnl_imagem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1045, 579);
            this.MinimumSize = new System.Drawing.Size(1045, 579);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.pnl_imagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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