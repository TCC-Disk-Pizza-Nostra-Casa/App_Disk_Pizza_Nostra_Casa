﻿namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{
    partial class form_cadastro_fornecedores
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
            btn_cancelar = new Button();
            btn_salvar = new Button();
            lbl_observacoes = new Label();
            txt_observacoes = new TextBox();
            grpbox_dados = new GroupBox();
            lbl_email = new Label();
            txt_telefone = new Label();
            mtxt_telefone = new MaskedTextBox();
            lbl_cnpj = new Label();
            mtxt_cnpj = new MaskedTextBox();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            txt_email = new TextBox();
            grpbox_dados.SuspendLayout();
            SuspendLayout();
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
            btn_cancelar.Location = new Point(534, 406);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(116, 42);
            btn_cancelar.TabIndex = 11;
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
            btn_salvar.Location = new Point(656, 406);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(116, 42);
            btn_salvar.TabIndex = 12;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.Location = new Point(12, 230);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(125, 28);
            lbl_observacoes.TabIndex = 9;
            lbl_observacoes.Text = "Observações:";
            lbl_observacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.Location = new Point(12, 271);
            txt_observacoes.MaxLength = 255;
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira possíveis observações sobre o(a) fornecedor(a)...";
            txt_observacoes.Size = new Size(760, 119);
            txt_observacoes.TabIndex = 10;
            // 
            // grpbox_dados
            // 
            grpbox_dados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_dados.BackColor = Color.Transparent;
            grpbox_dados.Controls.Add(lbl_email);
            grpbox_dados.Controls.Add(txt_telefone);
            grpbox_dados.Controls.Add(mtxt_telefone);
            grpbox_dados.Controls.Add(lbl_cnpj);
            grpbox_dados.Controls.Add(mtxt_cnpj);
            grpbox_dados.Controls.Add(txt_nome);
            grpbox_dados.Controls.Add(lbl_nome);
            grpbox_dados.Controls.Add(txt_email);
            grpbox_dados.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpbox_dados.Location = new Point(12, 12);
            grpbox_dados.Name = "grpbox_dados";
            grpbox_dados.Size = new Size(760, 206);
            grpbox_dados.TabIndex = 0;
            grpbox_dados.TabStop = false;
            grpbox_dados.Text = "Dados";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.BackColor = Color.Transparent;
            lbl_email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(14, 119);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(57, 19);
            lbl_email.TabIndex = 5;
            lbl_email.Text = "Email:";
            lbl_email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_telefone
            // 
            txt_telefone.AutoSize = true;
            txt_telefone.BackColor = Color.Transparent;
            txt_telefone.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_telefone.Location = new Point(14, 160);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(80, 19);
            txt_telefone.TabIndex = 7;
            txt_telefone.Text = "Telefone:";
            txt_telefone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mtxt_telefone
            // 
            mtxt_telefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_telefone.Location = new Point(100, 157);
            mtxt_telefone.Mask = "(00) 00000-0000";
            mtxt_telefone.Name = "mtxt_telefone";
            mtxt_telefone.Size = new Size(640, 26);
            mtxt_telefone.TabIndex = 8;
            // 
            // lbl_cnpj
            // 
            lbl_cnpj.AutoSize = true;
            lbl_cnpj.BackColor = Color.Transparent;
            lbl_cnpj.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cnpj.Location = new Point(14, 82);
            lbl_cnpj.Name = "lbl_cnpj";
            lbl_cnpj.Size = new Size(59, 19);
            lbl_cnpj.TabIndex = 3;
            lbl_cnpj.Text = "CNPJ:";
            lbl_cnpj.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mtxt_cnpj
            // 
            mtxt_cnpj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxt_cnpj.Location = new Point(79, 75);
            mtxt_cnpj.Mask = "00,000,000/0000-00";
            mtxt_cnpj.Name = "mtxt_cnpj";
            mtxt_cnpj.Size = new Size(661, 26);
            mtxt_cnpj.TabIndex = 4;
            // 
            // txt_nome
            // 
            txt_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(80, 34);
            txt_nome.MaxLength = 255;
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Insira o nome do(a) fornecedor(a) aqui...";
            txt_nome.Size = new Size(660, 26);
            txt_nome.TabIndex = 2;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(14, 37);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 19);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome:";
            lbl_nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(77, 116);
            txt_email.MaxLength = 60;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Exemplo: fornecedor@gmail.com";
            txt_email.Size = new Size(663, 26);
            txt_email.TabIndex = 6;
            // 
            // form_cadastro_fornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(grpbox_dados);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            Controls.Add(lbl_observacoes);
            Controls.Add(txt_observacoes);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(800, 500);
            Name = "form_cadastro_fornecedores";
            Text = "Cadastro de Fornecedores";
            Load += Form_Cadastro_Fornecedor_Load;
            grpbox_dados.ResumeLayout(false);
            grpbox_dados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_salvar;
        private Label lbl_observacoes;
        private TextBox txt_observacoes;
        private GroupBox grpbox_dados;
        private TextBox txt_nome;
        private Label lbl_nome;
        private Label lbl_cnpj;
        private MaskedTextBox mtxt_cnpj;
        private Label txt_telefone;
        private MaskedTextBox mtxt_telefone;
        private TextBox txt_email;
        private Label lbl_email;
    }
}