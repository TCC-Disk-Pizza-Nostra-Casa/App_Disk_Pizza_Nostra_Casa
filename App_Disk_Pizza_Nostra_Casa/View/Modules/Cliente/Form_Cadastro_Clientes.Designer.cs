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
            lbl_observacoes = new Label();
            txt_observacoes = new TextBox();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            SuspendLayout();
            // 
            // grpbox_dados
            // 
            grpbox_dados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_dados.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpbox_dados.Location = new Point(12, 12);
            grpbox_dados.Name = "grpbox_dados";
            grpbox_dados.Size = new Size(760, 269);
            grpbox_dados.TabIndex = 46;
            grpbox_dados.TabStop = false;
            grpbox_dados.Text = "Dados";
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
            lbl_observacoes.TabIndex = 44;
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
            txt_observacoes.TabIndex = 45;
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
            btn_cancelar.TabIndex = 43;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
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
            btn_salvar.TabIndex = 42;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpbox_dados;
        private Label lbl_observacoes;
        private TextBox txt_observacoes;
        private Button btn_cancelar;
        private Button btn_salvar;
    }
}