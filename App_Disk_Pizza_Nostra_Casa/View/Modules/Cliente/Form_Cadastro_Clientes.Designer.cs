namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Cliente
{
    partial class form_cadastro_clientes
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
            grpbox_dados = new GroupBox();
            pnl_campos = new Panel();
            lbl_data_nascimento = new Label();
            dtpck_data_nascimento = new DateTimePicker();
            cbbox_estado_civil = new ComboBox();
            cbbox_sexo = new ComboBox();
            lbl_estado_civil = new Label();
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
            lbl_observacoes = new Label();
            txt_observacoes = new TextBox();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            grpbox_dados.SuspendLayout();
            pnl_campos.SuspendLayout();
            SuspendLayout();
            // 
            // grpbox_dados
            // 
            grpbox_dados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_dados.Controls.Add(pnl_campos);
            grpbox_dados.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpbox_dados.Location = new Point(12, 12);
            grpbox_dados.Name = "grpbox_dados";
            grpbox_dados.Size = new Size(760, 269);
            grpbox_dados.TabIndex = 46;
            grpbox_dados.TabStop = false;
            grpbox_dados.Text = "Dados";
            // 
            // pnl_campos
            // 
            pnl_campos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_campos.AutoScroll = true;
            pnl_campos.Controls.Add(lbl_data_nascimento);
            pnl_campos.Controls.Add(dtpck_data_nascimento);
            pnl_campos.Controls.Add(cbbox_estado_civil);
            pnl_campos.Controls.Add(cbbox_sexo);
            pnl_campos.Controls.Add(lbl_estado_civil);
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
            pnl_campos.Location = new Point(6, 20);
            pnl_campos.Name = "pnl_campos";
            pnl_campos.Padding = new Padding(0, 0, 0, 10);
            pnl_campos.Size = new Size(748, 228);
            pnl_campos.TabIndex = 37;
            // 
            // lbl_data_nascimento
            // 
            lbl_data_nascimento.AutoSize = true;
            lbl_data_nascimento.BackColor = Color.Transparent;
            lbl_data_nascimento.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_data_nascimento.Location = new Point(12, 297);
            lbl_data_nascimento.Name = "lbl_data_nascimento";
            lbl_data_nascimento.Size = new Size(168, 19);
            lbl_data_nascimento.TabIndex = 37;
            lbl_data_nascimento.Text = "Data de Nascimento:";
            lbl_data_nascimento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpck_data_nascimento
            // 
            dtpck_data_nascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpck_data_nascimento.Format = DateTimePickerFormat.Short;
            dtpck_data_nascimento.Location = new Point(186, 294);
            dtpck_data_nascimento.Name = "dtpck_data_nascimento";
            dtpck_data_nascimento.Size = new Size(542, 26);
            dtpck_data_nascimento.TabIndex = 36;
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
            txt_email.PlaceholderText = "Exemplo: cliente@gmail.com";
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
            txt_nome.PlaceholderText = "Insira o nome do(a) cliente aqui...";
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
            // lbl_observacoes
            // 
            lbl_observacoes.AutoSize = true;
            lbl_observacoes.BackColor = Color.Transparent;
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.Location = new Point(12, 293);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(116, 19);
            lbl_observacoes.TabIndex = 44;
            lbl_observacoes.Text = "Observações:";
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.Location = new Point(12, 326);
            txt_observacoes.MaxLength = 255;
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira possíveis observações sobre o(a) cliente...";
            txt_observacoes.Size = new Size(760, 69);
            txt_observacoes.TabIndex = 45;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.Cursor = Cursors.Hand;
            btn_cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar.FlatAppearance.BorderSize = 2;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(534, 410);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(116, 39);
            btn_cancelar.TabIndex = 43;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salvar.BackColor = Color.Transparent;
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.FlatAppearance.BorderColor = Color.Black;
            btn_salvar.FlatAppearance.BorderSize = 2;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.Location = new Point(656, 410);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(116, 39);
            btn_salvar.TabIndex = 42;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // form_cadastro_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(grpbox_dados);
            Controls.Add(lbl_observacoes);
            Controls.Add(txt_observacoes);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_clientes";
            Text = "Cadastro de Clientes";
            Load += form_cadastro_clientes_Load;
            grpbox_dados.ResumeLayout(false);
            pnl_campos.ResumeLayout(false);
            pnl_campos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpbox_dados;
        private Label lbl_observacoes;
        private TextBox txt_observacoes;
        private Button btn_cancelar;
        private Button btn_salvar;
        private Panel pnl_campos;
        private ComboBox cbbox_estado_civil;
        private ComboBox cbbox_sexo;
        private Label lbl_estado_civil;
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
        private Label lbl_data_nascimento;
        private DateTimePicker dtpck_data_nascimento;
    }
}