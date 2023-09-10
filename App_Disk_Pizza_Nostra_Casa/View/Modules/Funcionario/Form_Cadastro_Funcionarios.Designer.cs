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
            lbl_senha = new Label();
            mtxt_cpf = new MaskedTextBox();
            lbl_cpf = new Label();
            lbl_rg = new Label();
            mtxt_rg = new MaskedTextBox();
            lbl_cargo = new Label();
            mtxt_cep = new MaskedTextBox();
            lbl_cep = new Label();
            pnl_campos = new Panel();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            cbbox_genero = new ComboBox();
            cbbox_cargo = new ComboBox();
            txt_observacoes = new TextBox();
            pnl_campos.SuspendLayout();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(96, 452);
            txt_senha.Margin = new Padding(3, 4, 3, 4);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Crie uma senha para o(a) funcionário(a)...";
            txt_senha.Size = new Size(786, 30);
            txt_senha.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(96, 343);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Insira o email do(a) funcionário(a)...";
            txt_email.Size = new Size(786, 30);
            txt_email.TabIndex = 3;
            // 
            // txt_nome
            // 
            txt_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(94, 16);
            txt_nome.Margin = new Padding(3, 4, 3, 4);
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Insira o nome do(a) funcionário(a)...";
            txt_nome.Size = new Size(590, 30);
            txt_nome.TabIndex = 4;
            // 
            // ckbox_administrador
            // 
            ckbox_administrador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ckbox_administrador.AutoSize = true;
            ckbox_administrador.BackColor = Color.Transparent;
            ckbox_administrador.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbox_administrador.Location = new Point(677, 13);
            ckbox_administrador.Margin = new Padding(3, 4, 3, 4);
            ckbox_administrador.Name = "ckbox_administrador";
            ckbox_administrador.Size = new Size(203, 36);
            ckbox_administrador.TabIndex = 5;
            ckbox_administrador.Text = "Administrador";
            ckbox_administrador.UseVisualStyleBackColor = false;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nome.Location = new Point(14, 12);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(67, 23);
            lbl_nome.TabIndex = 6;
            lbl_nome.Text = "Nome:";
            lbl_nome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.BackColor = Color.Transparent;
            lbl_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email.Location = new Point(16, 347);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(71, 23);
            lbl_email.TabIndex = 7;
            lbl_email.Text = "E-mail:";
            lbl_email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.BackColor = Color.Transparent;
            lbl_telefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefone.Location = new Point(16, 401);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(90, 23);
            lbl_telefone.TabIndex = 8;
            lbl_telefone.Text = "Telefone:";
            lbl_telefone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mtxt_telefone
            // 
            mtxt_telefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_telefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_telefone.Location = new Point(96, 397);
            mtxt_telefone.Margin = new Padding(3, 4, 3, 4);
            mtxt_telefone.Mask = "(00) 00000-0000";
            mtxt_telefone.Name = "mtxt_telefone";
            mtxt_telefone.Size = new Size(786, 30);
            mtxt_telefone.TabIndex = 9;
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.BackColor = Color.Transparent;
            lbl_genero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_genero.Location = new Point(14, 75);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(82, 23);
            lbl_genero.TabIndex = 11;
            lbl_genero.Text = "Gênero:";
            lbl_genero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha.Location = new Point(16, 456);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(71, 23);
            lbl_senha.TabIndex = 12;
            lbl_senha.Text = "Senha:";
            lbl_senha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mtxt_cpf
            // 
            mtxt_cpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_cpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_cpf.Location = new Point(94, 125);
            mtxt_cpf.Margin = new Padding(3, 4, 3, 4);
            mtxt_cpf.Mask = "000,000,000-00";
            mtxt_cpf.Name = "mtxt_cpf";
            mtxt_cpf.Size = new Size(786, 30);
            mtxt_cpf.TabIndex = 17;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.BackColor = Color.Transparent;
            lbl_cpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cpf.Location = new Point(14, 129);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(55, 23);
            lbl_cpf.TabIndex = 16;
            lbl_cpf.Text = "CPF:";
            lbl_cpf.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_rg
            // 
            lbl_rg.AutoSize = true;
            lbl_rg.BackColor = Color.Transparent;
            lbl_rg.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_rg.Location = new Point(14, 188);
            lbl_rg.Name = "lbl_rg";
            lbl_rg.Size = new Size(46, 23);
            lbl_rg.TabIndex = 19;
            lbl_rg.Text = "RG:";
            lbl_rg.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mtxt_rg
            // 
            mtxt_rg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_rg.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_rg.Location = new Point(94, 184);
            mtxt_rg.Margin = new Padding(3, 4, 3, 4);
            mtxt_rg.Mask = "00,000,000-0";
            mtxt_rg.Name = "mtxt_rg";
            mtxt_rg.Size = new Size(786, 30);
            mtxt_rg.TabIndex = 20;
            // 
            // lbl_cargo
            // 
            lbl_cargo.AutoSize = true;
            lbl_cargo.BackColor = Color.Transparent;
            lbl_cargo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cargo.Location = new Point(16, 244);
            lbl_cargo.Name = "lbl_cargo";
            lbl_cargo.Size = new Size(70, 23);
            lbl_cargo.TabIndex = 21;
            lbl_cargo.Text = "Cargo:";
            lbl_cargo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mtxt_cep
            // 
            mtxt_cep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_cep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_cep.Location = new Point(96, 288);
            mtxt_cep.Margin = new Padding(3, 4, 3, 4);
            mtxt_cep.Mask = "00000-000";
            mtxt_cep.Name = "mtxt_cep";
            mtxt_cep.Size = new Size(786, 30);
            mtxt_cep.TabIndex = 25;
            // 
            // lbl_cep
            // 
            lbl_cep.AutoSize = true;
            lbl_cep.BackColor = Color.Transparent;
            lbl_cep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cep.Location = new Point(16, 292);
            lbl_cep.Name = "lbl_cep";
            lbl_cep.Size = new Size(56, 23);
            lbl_cep.TabIndex = 24;
            lbl_cep.Text = "CEP:";
            lbl_cep.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnl_campos
            // 
            pnl_campos.BackColor = Color.White;
            pnl_campos.Controls.Add(btn_cancelar);
            pnl_campos.Controls.Add(btn_salvar);
            pnl_campos.Controls.Add(mtxt_cep);
            pnl_campos.Controls.Add(cbbox_genero);
            pnl_campos.Controls.Add(lbl_cep);
            pnl_campos.Controls.Add(cbbox_cargo);
            pnl_campos.Controls.Add(lbl_cargo);
            pnl_campos.Controls.Add(txt_observacoes);
            pnl_campos.Controls.Add(mtxt_rg);
            pnl_campos.Controls.Add(lbl_rg);
            pnl_campos.Controls.Add(txt_email);
            pnl_campos.Controls.Add(lbl_email);
            pnl_campos.Controls.Add(lbl_telefone);
            pnl_campos.Controls.Add(mtxt_telefone);
            pnl_campos.Controls.Add(txt_senha);
            pnl_campos.Controls.Add(lbl_genero);
            pnl_campos.Controls.Add(ckbox_administrador);
            pnl_campos.Controls.Add(lbl_cpf);
            pnl_campos.Controls.Add(lbl_senha);
            pnl_campos.Controls.Add(lbl_nome);
            pnl_campos.Dock = DockStyle.Fill;
            pnl_campos.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_campos.Location = new Point(0, 0);
            pnl_campos.Margin = new Padding(3, 4, 3, 4);
            pnl_campos.Name = "pnl_campos";
            pnl_campos.Size = new Size(896, 615);
            pnl_campos.TabIndex = 28;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar.FlatAppearance.BorderSize = 2;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(598, 547);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(133, 52);
            btn_cancelar.TabIndex = 33;
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
            btn_salvar.Location = new Point(747, 547);
            btn_salvar.Margin = new Padding(3, 4, 3, 4);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(133, 52);
            btn_salvar.TabIndex = 32;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // cbbox_genero
            // 
            cbbox_genero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_genero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_genero.FormattingEnabled = true;
            cbbox_genero.Location = new Point(94, 71);
            cbbox_genero.Margin = new Padding(3, 4, 3, 4);
            cbbox_genero.Name = "cbbox_genero";
            cbbox_genero.Size = new Size(786, 31);
            cbbox_genero.TabIndex = 31;
            // 
            // cbbox_cargo
            // 
            cbbox_cargo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_cargo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_cargo.FormattingEnabled = true;
            cbbox_cargo.Location = new Point(96, 240);
            cbbox_cargo.Margin = new Padding(3, 4, 3, 4);
            cbbox_cargo.Name = "cbbox_cargo";
            cbbox_cargo.Size = new Size(786, 31);
            cbbox_cargo.TabIndex = 30;
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.Location = new Point(16, 507);
            txt_observacoes.Margin = new Padding(3, 4, 3, 4);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira observações sobre o(a) funcionário(a)...";
            txt_observacoes.Size = new Size(866, 19);
            txt_observacoes.TabIndex = 29;
            // 
            // form_cadastro_funcionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(896, 615);
            Controls.Add(mtxt_cpf);
            Controls.Add(txt_nome);
            Controls.Add(pnl_campos);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 648);
            Name = "form_cadastro_funcionarios";
            Text = "Cadastro de Funcionários";
            Load += form_cadastro_funcionarios_Load;
            pnl_campos.ResumeLayout(false);
            pnl_campos.PerformLayout();
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