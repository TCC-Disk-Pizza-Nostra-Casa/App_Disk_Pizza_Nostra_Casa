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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.ckbox_administrador = new System.Windows.Forms.CheckBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.mtxt_rg = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.mtxt_cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.pnl_campos = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.cbbox_genero = new System.Windows.Forms.ComboBox();
            this.cbbox_cargo = new System.Windows.Forms.ComboBox();
            this.txt_observacoes = new System.Windows.Forms.TextBox();
            this.pnl_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha.Location = new System.Drawing.Point(96, 452);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.PlaceholderText = "Crie uma senha para o(a) funcionário(a)...";
            this.txt_senha.Size = new System.Drawing.Size(786, 30);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(96, 343);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceholderText = "Insira o email do(a) funcionário(a)...";
            this.txt_email.Size = new System.Drawing.Size(786, 30);
            this.txt_email.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(94, 16);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PlaceholderText = "Insira o nome do(a) funcionário(a)...";
            this.txt_nome.Size = new System.Drawing.Size(590, 30);
            this.txt_nome.TabIndex = 4;
            // 
            // ckbox_administrador
            // 
            this.ckbox_administrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbox_administrador.AutoSize = true;
            this.ckbox_administrador.BackColor = System.Drawing.Color.Transparent;
            this.ckbox_administrador.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbox_administrador.Location = new System.Drawing.Point(677, 13);
            this.ckbox_administrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbox_administrador.Name = "ckbox_administrador";
            this.ckbox_administrador.Size = new System.Drawing.Size(203, 36);
            this.ckbox_administrador.TabIndex = 5;
            this.ckbox_administrador.Text = "Administrador";
            this.ckbox_administrador.UseVisualStyleBackColor = false;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome.Location = new System.Drawing.Point(14, 12);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(67, 23);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome:";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.Location = new System.Drawing.Point(16, 347);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(71, 23);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "E-mail:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_telefone.Location = new System.Drawing.Point(16, 401);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(90, 23);
            this.lbl_telefone.TabIndex = 8;
            this.lbl_telefone.Text = "Telefone:";
            this.lbl_telefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_telefone.Location = new System.Drawing.Point(96, 397);
            this.mtxt_telefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxt_telefone.Mask = "(00) 00000-0000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(786, 30);
            this.mtxt_telefone.TabIndex = 9;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_genero.Location = new System.Drawing.Point(14, 75);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(82, 23);
            this.lbl_genero.TabIndex = 11;
            this.lbl_genero.Text = "Gênero:";
            this.lbl_genero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_senha.Location = new System.Drawing.Point(16, 456);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(71, 23);
            this.lbl_senha.TabIndex = 12;
            this.lbl_senha.Text = "Senha:";
            this.lbl_senha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cpf.Location = new System.Drawing.Point(94, 125);
            this.mtxt_cpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(786, 30);
            this.mtxt_cpf.TabIndex = 17;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpf.Location = new System.Drawing.Point(14, 129);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(55, 23);
            this.lbl_cpf.TabIndex = 16;
            this.lbl_cpf.Text = "CPF:";
            this.lbl_cpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rg.Location = new System.Drawing.Point(14, 188);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(46, 23);
            this.lbl_rg.TabIndex = 19;
            this.lbl_rg.Text = "RG:";
            this.lbl_rg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxt_rg
            // 
            this.mtxt_rg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_rg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_rg.Location = new System.Drawing.Point(94, 184);
            this.mtxt_rg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxt_rg.Mask = "00,000,000-0";
            this.mtxt_rg.Name = "mtxt_rg";
            this.mtxt_rg.Size = new System.Drawing.Size(786, 30);
            this.mtxt_rg.TabIndex = 20;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cargo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cargo.Location = new System.Drawing.Point(16, 244);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(70, 23);
            this.lbl_cargo.TabIndex = 21;
            this.lbl_cargo.Text = "Cargo:";
            this.lbl_cargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxt_cep
            // 
            this.mtxt_cep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_cep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cep.Location = new System.Drawing.Point(96, 288);
            this.mtxt_cep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxt_cep.Mask = "00,000-000";
            this.mtxt_cep.Name = "mtxt_cep";
            this.mtxt_cep.Size = new System.Drawing.Size(786, 30);
            this.mtxt_cep.TabIndex = 25;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cep.Location = new System.Drawing.Point(16, 292);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(56, 23);
            this.lbl_cep.TabIndex = 24;
            this.lbl_cep.Text = "CEP:";
            this.lbl_cep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_campos
            // 
            this.pnl_campos.BackColor = System.Drawing.Color.White;
            this.pnl_campos.Controls.Add(this.btn_cancelar);
            this.pnl_campos.Controls.Add(this.btn_salvar);
            this.pnl_campos.Controls.Add(this.mtxt_cep);
            this.pnl_campos.Controls.Add(this.cbbox_genero);
            this.pnl_campos.Controls.Add(this.lbl_cep);
            this.pnl_campos.Controls.Add(this.cbbox_cargo);
            this.pnl_campos.Controls.Add(this.lbl_cargo);
            this.pnl_campos.Controls.Add(this.txt_observacoes);
            this.pnl_campos.Controls.Add(this.mtxt_rg);
            this.pnl_campos.Controls.Add(this.lbl_rg);
            this.pnl_campos.Controls.Add(this.txt_email);
            this.pnl_campos.Controls.Add(this.lbl_email);
            this.pnl_campos.Controls.Add(this.lbl_telefone);
            this.pnl_campos.Controls.Add(this.mtxt_telefone);
            this.pnl_campos.Controls.Add(this.txt_senha);
            this.pnl_campos.Controls.Add(this.lbl_genero);
            this.pnl_campos.Controls.Add(this.ckbox_administrador);
            this.pnl_campos.Controls.Add(this.lbl_cpf);
            this.pnl_campos.Controls.Add(this.lbl_senha);
            this.pnl_campos.Controls.Add(this.lbl_nome);
            this.pnl_campos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_campos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_campos.Location = new System.Drawing.Point(0, 0);
            this.pnl_campos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_campos.Name = "pnl_campos";
            this.pnl_campos.Size = new System.Drawing.Size(896, 615);
            this.pnl_campos.TabIndex = 28;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(598, 547);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(133, 52);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_salvar.FlatAppearance.BorderSize = 2;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.Location = new System.Drawing.Point(747, 547);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(133, 52);
            this.btn_salvar.TabIndex = 32;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // cbbox_genero
            // 
            this.cbbox_genero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbox_genero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbox_genero.FormattingEnabled = true;
            this.cbbox_genero.Location = new System.Drawing.Point(94, 71);
            this.cbbox_genero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbox_genero.Name = "cbbox_genero";
            this.cbbox_genero.Size = new System.Drawing.Size(786, 31);
            this.cbbox_genero.TabIndex = 31;
            // 
            // cbbox_cargo
            // 
            this.cbbox_cargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbox_cargo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbox_cargo.FormattingEnabled = true;
            this.cbbox_cargo.Location = new System.Drawing.Point(96, 240);
            this.cbbox_cargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbox_cargo.Name = "cbbox_cargo";
            this.cbbox_cargo.Size = new System.Drawing.Size(786, 31);
            this.cbbox_cargo.TabIndex = 30;
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_observacoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_observacoes.Location = new System.Drawing.Point(16, 507);
            this.txt_observacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.PlaceholderText = "Insira observações sobre o(a) funcionário(a)...";
            this.txt_observacoes.Size = new System.Drawing.Size(866, 19);
            this.txt_observacoes.TabIndex = 29;
            // 
            // form_cadastro_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 615);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pnl_campos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(912, 651);
            this.Name = "form_cadastro_funcionarios";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.form_cadastro_funcionarios_Load);
            this.pnl_campos.ResumeLayout(false);
            this.pnl_campos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label lbl_senha;
        private MaskedTextBox mtxt_cpf;
        private Label lbl_cpf;
        private Label lbl_rg;
        private MaskedTextBox mtxt_rg;
        private Label lbl_cargo;
        private MaskedTextBox mtxt_cep;
        private Label lbl_cep;
        private Panel pnl_campos;
        private TextBox txt_observacoes;
        private ComboBox cbbox_genero;
        private ComboBox cbbox_cargo;
        private Button btn_salvar;
        private Button btn_cancelar;
    }
}