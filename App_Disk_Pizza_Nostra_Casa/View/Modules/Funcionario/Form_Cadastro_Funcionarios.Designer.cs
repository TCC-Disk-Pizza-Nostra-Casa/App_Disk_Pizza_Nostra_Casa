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
            cbbox_estado_civil = new ComboBox();
            cbbox_sexo = new ComboBox();
            lbl_estado_civil = new Label();
            txt_confirmar_senha = new TextBox();
            lbl_confirmar_senha = new Label();
            lbl_senha = new Label();
            txt_senha = new TextBox();
            mtxt_telefone = new MaskedTextBox();
            lbl_telefone = new Label();
            txt_email = new TextBox();
            email = new Label();
            lbl_cep = new Label();
            mtxt_cep = new MaskedTextBox();
            lbl_cpf = new Label();
            mtxt_cpf = new MaskedTextBox();
            txt_nome = new TextBox();
            lbl_sexo = new Label();
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
            txt_observacoes.MaxLength = 255;
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira possíveis observações sobre o(a) funcionário(a)...";
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
            pnl_campos.Controls.Add(cbbox_estado_civil);
            pnl_campos.Controls.Add(cbbox_sexo);
            pnl_campos.Controls.Add(lbl_estado_civil);
            pnl_campos.Controls.Add(txt_confirmar_senha);
            pnl_campos.Controls.Add(lbl_confirmar_senha);
            pnl_campos.Controls.Add(lbl_senha);
            pnl_campos.Controls.Add(txt_senha);
            pnl_campos.Controls.Add(mtxt_telefone);
            pnl_campos.Controls.Add(lbl_telefone);
            pnl_campos.Controls.Add(txt_email);
            pnl_campos.Controls.Add(email);
            pnl_campos.Controls.Add(lbl_cep);
            pnl_campos.Controls.Add(mtxt_cep);
            pnl_campos.Controls.Add(lbl_cpf);
            pnl_campos.Controls.Add(mtxt_cpf);
            pnl_campos.Controls.Add(txt_nome);
            pnl_campos.Controls.Add(lbl_sexo);
            pnl_campos.Controls.Add(lbl_nome);
            pnl_campos.Location = new Point(6, 25);
            pnl_campos.Name = "pnl_campos";
            pnl_campos.Padding = new Padding(0, 0, 0, 10);
            pnl_campos.Size = new Size(748, 228);
            pnl_campos.TabIndex = 36;
            // 
            // cbbox_estado_civil
            // 
            cbbox_estado_civil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_estado_civil.FormattingEnabled = true;
            cbbox_estado_civil.Location = new Point(124, 87);
            cbbox_estado_civil.MaxLength = 13;
            cbbox_estado_civil.Name = "cbbox_estado_civil";
            cbbox_estado_civil.Size = new Size(604, 26);
            cbbox_estado_civil.TabIndex = 34;
            // 
            // cbbox_sexo
            // 
            cbbox_sexo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_sexo.FormattingEnabled = true;
            cbbox_sexo.Location = new Point(72, 46);
            cbbox_sexo.MaxLength = 20;
            cbbox_sexo.Name = "cbbox_sexo";
            cbbox_sexo.Size = new Size(656, 26);
            cbbox_sexo.TabIndex = 33;
            // 
            // lbl_estado_civil
            // 
            lbl_estado_civil.AutoSize = true;
            lbl_estado_civil.BackColor = Color.Transparent;
            lbl_estado_civil.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_estado_civil.Location = new Point(12, 90);
            lbl_estado_civil.Name = "lbl_estado_civil";
            lbl_estado_civil.Size = new Size(106, 19);
            lbl_estado_civil.TabIndex = 32;
            lbl_estado_civil.Text = "Estado Civil:";
            lbl_estado_civil.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_confirmar_senha
            // 
            txt_confirmar_senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_confirmar_senha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_confirmar_senha.Location = new Point(161, 333);
            txt_confirmar_senha.MaxLength = 20;
            txt_confirmar_senha.Name = "txt_confirmar_senha";
            txt_confirmar_senha.PasswordChar = '*';
            txt_confirmar_senha.PlaceholderText = "Confirme a senha...";
            txt_confirmar_senha.Size = new Size(567, 26);
            txt_confirmar_senha.TabIndex = 30;
            // 
            // lbl_confirmar_senha
            // 
            lbl_confirmar_senha.AutoSize = true;
            lbl_confirmar_senha.BackColor = Color.Transparent;
            lbl_confirmar_senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirmar_senha.Location = new Point(12, 336);
            lbl_confirmar_senha.Name = "lbl_confirmar_senha";
            lbl_confirmar_senha.Size = new Size(144, 19);
            lbl_confirmar_senha.TabIndex = 29;
            lbl_confirmar_senha.Text = "Confirmar Senha:";
            lbl_confirmar_senha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(12, 296);
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
            txt_senha.Location = new Point(82, 293);
            txt_senha.MaxLength = 20;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Crie uma senha de usuário...";
            txt_senha.Size = new Size(646, 26);
            txt_senha.TabIndex = 27;
            // 
            // mtxt_telefone
            // 
            mtxt_telefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_telefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_telefone.Location = new Point(98, 252);
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
            lbl_telefone.Location = new Point(12, 255);
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
            txt_email.Location = new Point(75, 210);
            txt_email.MaxLength = 60;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Exemplo: usuario@gmail.com";
            txt_email.Size = new Size(653, 26);
            txt_email.TabIndex = 21;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(12, 213);
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
            lbl_cep.Location = new Point(12, 172);
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
            mtxt_cep.Location = new Point(67, 169);
            mtxt_cep.Mask = "00000-000";
            mtxt_cep.Name = "mtxt_cep";
            mtxt_cep.Size = new Size(661, 26);
            mtxt_cep.TabIndex = 14;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.BackColor = Color.Transparent;
            lbl_cpf.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cpf.Location = new Point(12, 131);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(48, 19);
            lbl_cpf.TabIndex = 10;
            lbl_cpf.Text = "CPF:";
            lbl_cpf.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mtxt_cpf
            // 
            mtxt_cpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_cpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxt_cpf.Location = new Point(66, 128);
            mtxt_cpf.Mask = "000,000,000-00";
            mtxt_cpf.Name = "mtxt_cpf";
            mtxt_cpf.Size = new Size(662, 26);
            mtxt_cpf.TabIndex = 8;
            // 
            // txt_nome
            // 
            txt_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(78, 7);
            txt_nome.MaxLength = 255;
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Insira seu nome aqui...";
            txt_nome.Size = new Size(650, 26);
            txt_nome.TabIndex = 4;
            // 
            // lbl_sexo
            // 
            lbl_sexo.AutoSize = true;
            lbl_sexo.BackColor = Color.Transparent;
            lbl_sexo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_sexo.Location = new Point(12, 49);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(54, 19);
            lbl_sexo.TabIndex = 2;
            lbl_sexo.Text = "Sexo:";
            lbl_sexo.TextAlign = ContentAlignment.MiddleLeft;
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
            MinimumSize = new Size(800, 498);
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
        private Label email;
        private Label lbl_cep;
        private MaskedTextBox mtxt_cep;
        private Label lbl_cpf;
        private MaskedTextBox mtxt_cpf;
        private TextBox txt_nome;
        private Label lbl_sexo;
        private Label lbl_nome;
        private Label lbl_senha;
        private TextBox txt_senha;
        private TextBox txt_confirmar_senha;
        private Label lbl_confirmar_senha;
        private Label lbl_estado_civil;
        private ComboBox cbbox_sexo;
        private ComboBox cbbox_estado_civil;
    }
}