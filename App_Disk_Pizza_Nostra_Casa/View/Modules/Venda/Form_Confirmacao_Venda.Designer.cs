namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Venda
{
    partial class form_confirmacao_venda
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
            txt_observacoes = new TextBox();
            lbl_observacoes = new Label();
            lbl_valor_total = new Label();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salvar.FlatAppearance.BorderColor = Color.Black;
            btn_salvar.FlatAppearance.BorderSize = 2;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.Black;
            btn_salvar.Location = new Point(256, 310);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(116, 39);
            btn_salvar.TabIndex = 0;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar.FlatAppearance.BorderSize = 2;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.Black;
            btn_cancelar.Location = new Point(12, 310);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(116, 39);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.ForeColor = Color.Black;
            txt_observacoes.Location = new Point(12, 120);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira possíveis observações sobre a venda...";
            txt_observacoes.Size = new Size(360, 172);
            txt_observacoes.TabIndex = 2;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.AutoSize = true;
            lbl_observacoes.BackColor = Color.Transparent;
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.ForeColor = Color.Black;
            lbl_observacoes.Location = new Point(12, 89);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(116, 19);
            lbl_observacoes.TabIndex = 3;
            lbl_observacoes.Text = "Observações:";
            // 
            // lbl_valor_total
            // 
            lbl_valor_total.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_valor_total.BackColor = Color.Transparent;
            lbl_valor_total.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valor_total.ForeColor = Color.Black;
            lbl_valor_total.Location = new Point(12, 9);
            lbl_valor_total.Name = "lbl_valor_total";
            lbl_valor_total.Size = new Size(360, 71);
            lbl_valor_total.TabIndex = 5;
            lbl_valor_total.Text = "Valor";
            lbl_valor_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_confirmacao_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            ControlBox = false;
            Controls.Add(lbl_valor_total);
            Controls.Add(lbl_observacoes);
            Controls.Add(txt_observacoes);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_salvar);
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(400, 400);
            Name = "form_confirmacao_venda";
            Text = "Confirmação de Venda";
            Load += form_confirmacao_venda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private Button btn_cancelar;
        private TextBox txt_observacoes;
        private Label lbl_observacoes;
        private Label lbl_valor_total;
    }
}