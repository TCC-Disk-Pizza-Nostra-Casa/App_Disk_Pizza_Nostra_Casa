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
            lbl_observacoes = new Label();
            txt_observacoes = new TextBox();
            ckbox_administrador = new CheckBox();
            groupBox1 = new GroupBox();
            pnl_campos = new Panel();
            lbl_senha = new Label();
            txt_senha = new TextBox();
            mtxt_telefone = new MaskedTextBox();
            lbl_telefone = new Label();
            txt_email = new TextBox();
            txt_cargo = new TextBox();
            email = new Label();
            lbl_cep = new Label();
            mtxt_cep = new MaskedTextBox();
            lbl_cargo = new Label();
            lbl_rg = new Label();
            lbl_cpf = new Label();
            mtxt_rg = new MaskedTextBox();
            mtxt_cpf = new MaskedTextBox();
            txt_pronome = new TextBox();
            txt_genero = new TextBox();
            txt_nome_social = new TextBox();
            txt_nome = new TextBox();
            lbl__pronome = new Label();
            lbl_genero = new Label();
            lbl_nome_social = new Label();
            lbl_nome = new Label();
            groupBox1.SuspendLayout();
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
            btn_salvar.Click += btn_salvar_Click;
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
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_observacoes.AutoSize = true;
            lbl_observacoes.BackColor = Color.Transparent;
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.Location = new Point(12, 293);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(116, 19);
            lbl_observacoes.TabIndex = 36;
            lbl_observacoes.Text = "Observações:";
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.Location = new Point(12, 326);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.Size = new Size(760, 69);
            txt_observacoes.TabIndex = 39;
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pnl_campos);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 269);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // pnl_campos
            // 
            pnl_campos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_campos.AutoScroll = true;
            pnl_campos.Controls.Add(lbl_senha);
            pnl_campos.Controls.Add(txt_senha);
            pnl_campos.Controls.Add(mtxt_telefone);
            pnl_campos.Controls.Add(lbl_telefone);
            pnl_campos.Controls.Add(txt_email);
            pnl_campos.Controls.Add(txt_cargo);
            pnl_campos.Controls.Add(email);
            pnl_campos.Controls.Add(lbl_cep);
            pnl_campos.Controls.Add(mtxt_cep);
            pnl_campos.Controls.Add(lbl_cargo);
            pnl_campos.Controls.Add(lbl_rg);
            pnl_campos.Controls.Add(lbl_cpf);
            pnl_campos.Controls.Add(mtxt_rg);
            pnl_campos.Controls.Add(mtxt_cpf);
            pnl_campos.Controls.Add(txt_pronome);
            pnl_campos.Controls.Add(txt_genero);
            pnl_campos.Controls.Add(txt_nome_social);
            pnl_campos.Controls.Add(txt_nome);
            pnl_campos.Controls.Add(lbl__pronome);
            pnl_campos.Controls.Add(lbl_genero);
            pnl_campos.Controls.Add(lbl_nome_social);
            pnl_campos.Controls.Add(lbl_nome);
            pnl_campos.Location = new Point(6, 25);
            pnl_campos.Name = "pnl_campos";
            pnl_campos.Padding = new Padding(0, 0, 0, 10);
            pnl_campos.Size = new Size(748, 228);
            pnl_campos.TabIndex = 36;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(13, 411);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 19);
            lbl_senha.TabIndex = 28;
            lbl_senha.Text = "Senha:";
            lbl_senha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(83, 408);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(645, 26);
            txt_senha.TabIndex = 27;
            // 
            // mtxt_telefone
            // 
            mtxt_telefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_telefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_telefone.Location = new Point(98, 371);
            mtxt_telefone.Mask = "(00) 00000-0000";
            mtxt_telefone.Name = "mtxt_telefone";
            mtxt_telefone.Size = new Size(630, 26);
            mtxt_telefone.TabIndex = 24;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.BackColor = Color.Transparent;
            lbl_telefone.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefone.Location = new Point(12, 374);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(80, 19);
            lbl_telefone.TabIndex = 23;
            lbl_telefone.Text = "Telefone:";
            lbl_telefone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(76, 332);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(652, 26);
            txt_email.TabIndex = 21;
            // 
            // txt_cargo
            // 
            txt_cargo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_cargo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cargo.Location = new Point(81, 253);
            txt_cargo.Name = "txt_cargo";
            txt_cargo.PlaceholderText = "Campo obrigatório";
            txt_cargo.Size = new Size(647, 26);
            txt_cargo.TabIndex = 20;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(13, 335);
            email.Name = "email";
            email.Size = new Size(57, 19);
            email.TabIndex = 16;
            email.Text = "Email:";
            email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_cep
            // 
            lbl_cep.AutoSize = true;
            lbl_cep.BackColor = Color.Transparent;
            lbl_cep.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cep.Location = new Point(12, 295);
            lbl_cep.Name = "lbl_cep";
            lbl_cep.Size = new Size(49, 19);
            lbl_cep.TabIndex = 15;
            lbl_cep.Text = "CEP:";
            lbl_cep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mtxt_cep
            // 
            mtxt_cep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_cep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_cep.Location = new Point(67, 292);
            mtxt_cep.Mask = "00000-000";
            mtxt_cep.Name = "mtxt_cep";
            mtxt_cep.Size = new Size(661, 26);
            mtxt_cep.TabIndex = 14;
            // 
            // lbl_cargo
            // 
            lbl_cargo.AutoSize = true;
            lbl_cargo.BackColor = Color.Transparent;
            lbl_cargo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cargo.Location = new Point(13, 256);
            lbl_cargo.Name = "lbl_cargo";
            lbl_cargo.Size = new Size(62, 19);
            lbl_cargo.TabIndex = 13;
            lbl_cargo.Text = "Cargo:";
            lbl_cargo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_rg
            // 
            lbl_rg.AutoSize = true;
            lbl_rg.BackColor = Color.Transparent;
            lbl_rg.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_rg.Location = new Point(12, 215);
            lbl_rg.Name = "lbl_rg";
            lbl_rg.Size = new Size(39, 19);
            lbl_rg.TabIndex = 11;
            lbl_rg.Text = "RG:";
            lbl_rg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.BackColor = Color.Transparent;
            lbl_cpf.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cpf.Location = new Point(12, 174);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(48, 19);
            lbl_cpf.TabIndex = 10;
            lbl_cpf.Text = "CPF:";
            lbl_cpf.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mtxt_rg
            // 
            mtxt_rg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_rg.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_rg.Location = new Point(57, 212);
            mtxt_rg.Mask = "00,000,000-0";
            mtxt_rg.Name = "mtxt_rg";
            mtxt_rg.Size = new Size(671, 26);
            mtxt_rg.TabIndex = 9;
            // 
            // mtxt_cpf
            // 
            mtxt_cpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_cpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_cpf.Location = new Point(66, 171);
            mtxt_cpf.Mask = "000,000,000-00";
            mtxt_cpf.Name = "mtxt_cpf";
            mtxt_cpf.Size = new Size(662, 26);
            mtxt_cpf.TabIndex = 8;
            // 
            // txt_pronome
            // 
            txt_pronome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pronome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pronome.Location = new Point(103, 130);
            txt_pronome.Name = "txt_pronome";
            txt_pronome.Size = new Size(625, 26);
            txt_pronome.TabIndex = 7;
            // 
            // txt_genero
            // 
            txt_genero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_genero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_genero.Location = new Point(89, 89);
            txt_genero.Name = "txt_genero";
            txt_genero.Size = new Size(639, 26);
            txt_genero.TabIndex = 6;
            // 
            // txt_nome_social
            // 
            txt_nome_social.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome_social.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_social.Location = new Point(129, 48);
            txt_nome_social.Name = "txt_nome_social";
            txt_nome_social.Size = new Size(599, 26);
            txt_nome_social.TabIndex = 5;
            // 
            // txt_nome
            // 
            txt_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(78, 7);
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Campo obrigatório";
            txt_nome.Size = new Size(650, 26);
            txt_nome.TabIndex = 4;
            // 
            // lbl__pronome
            // 
            lbl__pronome.AutoSize = true;
            lbl__pronome.BackColor = Color.Transparent;
            lbl__pronome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl__pronome.Location = new Point(12, 133);
            lbl__pronome.Name = "lbl__pronome";
            lbl__pronome.Size = new Size(85, 19);
            lbl__pronome.TabIndex = 3;
            lbl__pronome.Text = "Pronome:";
            lbl__pronome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.BackColor = Color.Transparent;
            lbl_genero.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_genero.Location = new Point(12, 92);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(71, 19);
            lbl_genero.TabIndex = 2;
            lbl_genero.Text = "Gênero:";
            lbl_genero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_nome_social
            // 
            lbl_nome_social.AutoSize = true;
            lbl_nome_social.BackColor = Color.Transparent;
            lbl_nome_social.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome_social.Location = new Point(12, 51);
            lbl_nome_social.Name = "lbl_nome_social";
            lbl_nome_social.Size = new Size(111, 19);
            lbl_nome_social.TabIndex = 1;
            lbl_nome_social.Text = "Nome Social:";
            lbl_nome_social.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(12, 10);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 19);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome:";
            lbl_nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // form_cadastro_funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(groupBox1);
            Controls.Add(lbl_observacoes);
            Controls.Add(ckbox_administrador);
            Controls.Add(txt_observacoes);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_funcionarios";
            Text = "Cadastro de Funcionários";
            Load += form_cadastro_funcionarios_Load;
            groupBox1.ResumeLayout(false);
            pnl_campos.ResumeLayout(false);
            pnl_campos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private Button btn_cancelar;
        private Label lbl_observacoes;
        private TextBox txt_observacoes;
        private CheckBox ckbox_administrador;
        private GroupBox groupBox1;
        private Panel pnl_campos;
        private MaskedTextBox mtxt_telefone;
        private Label lbl_telefone;
        private TextBox txt_email;
        private TextBox txt_cargo;
        private Label email;
        private Label lbl_cep;
        private MaskedTextBox mtxt_cep;
        private Label lbl_cargo;
        private Label lbl_rg;
        private Label lbl_cpf;
        private MaskedTextBox mtxt_rg;
        private MaskedTextBox mtxt_cpf;
        private TextBox txt_pronome;
        private TextBox txt_genero;
        private TextBox txt_nome_social;
        private TextBox txt_nome;
        private Label lbl__pronome;
        private Label lbl_genero;
        private Label lbl_nome_social;
        private Label lbl_nome;
        private Label lbl_senha;
        private TextBox txt_senha;
    }
}