﻿namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{
    partial class Form_Cadastro_Fornecedor
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
            label4 = new Label();
            txt_observacoes_fornecedor = new TextBox();
            grp_dados = new GroupBox();
            pnl_dados = new Panel();
            msk_cnpj_fornecedor = new MaskedTextBox();
            msk_telefone_fornecedor = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            txt_nome_fornecedor = new TextBox();
            label1 = new Label();
            grp_dados.SuspendLayout();
            pnl_dados.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar.FlatAppearance.BorderSize = 2;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(525, 406);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(116, 42);
            btn_cancelar.TabIndex = 6;
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
            btn_salvar.Location = new Point(656, 406);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(116, 42);
            btn_salvar.TabIndex = 5;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 240);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 53;
            label4.Text = "Observações:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_observacoes_fornecedor
            // 
            txt_observacoes_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes_fornecedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes_fornecedor.Location = new Point(12, 271);
            txt_observacoes_fornecedor.Multiline = true;
            txt_observacoes_fornecedor.Name = "txt_observacoes_fornecedor";
            txt_observacoes_fornecedor.PlaceholderText = "Insira observações sobre o fornecedor...(campo não obrigatório).";
            txt_observacoes_fornecedor.Size = new Size(760, 119);
            txt_observacoes_fornecedor.TabIndex = 4;
            // 
            // grp_dados
            // 
            grp_dados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grp_dados.Controls.Add(pnl_dados);
            grp_dados.Location = new Point(12, 12);
            grp_dados.Name = "grp_dados";
            grp_dados.Size = new Size(760, 201);
            grp_dados.TabIndex = 56;
            grp_dados.TabStop = false;
            grp_dados.Text = "Dados";
            // 
            // pnl_dados
            // 
            pnl_dados.AutoScroll = true;
            pnl_dados.BackColor = Color.Transparent;
            pnl_dados.Controls.Add(msk_cnpj_fornecedor);
            pnl_dados.Controls.Add(msk_telefone_fornecedor);
            pnl_dados.Controls.Add(label3);
            pnl_dados.Controls.Add(label2);
            pnl_dados.Controls.Add(txt_nome_fornecedor);
            pnl_dados.Controls.Add(label1);
            pnl_dados.Dock = DockStyle.Fill;
            pnl_dados.Location = new Point(3, 19);
            pnl_dados.Name = "pnl_dados";
            pnl_dados.Size = new Size(754, 179);
            pnl_dados.TabIndex = 57;
            // 
            // msk_cnpj_fornecedor
            // 
            msk_cnpj_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            msk_cnpj_fornecedor.Location = new Point(77, 74);
            msk_cnpj_fornecedor.Mask = "00.000.000/0000-00";
            msk_cnpj_fornecedor.Name = "msk_cnpj_fornecedor";
            msk_cnpj_fornecedor.Size = new Size(670, 23);
            msk_cnpj_fornecedor.TabIndex = 2;
            // 
            // msk_telefone_fornecedor
            // 
            msk_telefone_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            msk_telefone_fornecedor.Location = new Point(101, 133);
            msk_telefone_fornecedor.Mask = "(99) 00000-0000";
            msk_telefone_fornecedor.Name = "msk_telefone_fornecedor";
            msk_telefone_fornecedor.Size = new Size(646, 23);
            msk_telefone_fornecedor.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 130);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 53;
            label3.Text = "Telefone:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 71);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 50;
            label2.Text = "CNPJ:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_nome_fornecedor
            // 
            txt_nome_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome_fornecedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_fornecedor.Location = new Point(196, 12);
            txt_nome_fornecedor.Name = "txt_nome_fornecedor";
            txt_nome_fornecedor.PlaceholderText = "Insira o nome do fornecedor...";
            txt_nome_fornecedor.Size = new Size(551, 26);
            txt_nome_fornecedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(177, 26);
            label1.TabIndex = 48;
            label1.Text = "Nome do Fornecedor:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form_Cadastro_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(grp_dados);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            Controls.Add(label4);
            Controls.Add(txt_observacoes_fornecedor);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(800, 500);
            Name = "Form_Cadastro_Fornecedor";
            Text = "Cadastro de Fornecedores";
            Load += Form_Cadastro_Fornecedor_Load;
            grp_dados.ResumeLayout(false);
            pnl_dados.ResumeLayout(false);
            pnl_dados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_salvar;
        private Label label4;
        private TextBox txt_observacoes_fornecedor;
        private GroupBox grp_dados;
        private Panel pnl_dados;
        private Label label3;
        private Label label2;
        private TextBox txt_nome_fornecedor;
        private Label label1;
        private MaskedTextBox msk_telefone_fornecedor;
        private MaskedTextBox msk_cnpj_fornecedor;
    }
}