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
            txt_observacoes = new TextBox();
            lbl_observacoes = new Label();
            lbl_valor_total = new Label();
            lbl_tipo_consumo = new Label();
            cbbox_tipo_consumo = new ComboBox();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Bottom;
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.FlatAppearance.BorderColor = Color.Black;
            btn_salvar.FlatAppearance.BorderSize = 2;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.Black;
            btn_salvar.Location = new Point(132, 310);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(116, 39);
            btn_salvar.TabIndex = 5;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_observacoes
            // 
            txt_observacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacoes.ForeColor = Color.Black;
            txt_observacoes.Location = new Point(12, 154);
            txt_observacoes.MaxLength = 255;
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.PlaceholderText = "Insira possíveis observações sobre a venda...";
            txt_observacoes.Size = new Size(360, 141);
            txt_observacoes.TabIndex = 4;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.AutoSize = true;
            lbl_observacoes.BackColor = Color.Transparent;
            lbl_observacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_observacoes.ForeColor = Color.Black;
            lbl_observacoes.Location = new Point(12, 124);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(116, 19);
            lbl_observacoes.TabIndex = 3;
            lbl_observacoes.Text = "Observações:";
            // 
            // lbl_valor_total
            // 
            lbl_valor_total.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_valor_total.BackColor = Color.Transparent;
            lbl_valor_total.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valor_total.ForeColor = Color.Black;
            lbl_valor_total.Location = new Point(12, 9);
            lbl_valor_total.Name = "lbl_valor_total";
            lbl_valor_total.Size = new Size(360, 63);
            lbl_valor_total.TabIndex = 0;
            lbl_valor_total.Text = "Valor";
            lbl_valor_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_tipo_consumo
            // 
            lbl_tipo_consumo.AutoSize = true;
            lbl_tipo_consumo.BackColor = Color.Transparent;
            lbl_tipo_consumo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tipo_consumo.ForeColor = Color.Black;
            lbl_tipo_consumo.Location = new Point(12, 87);
            lbl_tipo_consumo.Name = "lbl_tipo_consumo";
            lbl_tipo_consumo.Size = new Size(90, 19);
            lbl_tipo_consumo.TabIndex = 1;
            lbl_tipo_consumo.Text = "Consumo:";
            // 
            // cbbox_tipo_consumo
            // 
            cbbox_tipo_consumo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbox_tipo_consumo.Cursor = Cursors.Hand;
            cbbox_tipo_consumo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_tipo_consumo.FormattingEnabled = true;
            cbbox_tipo_consumo.Location = new Point(108, 84);
            cbbox_tipo_consumo.MaxLength = 21;
            cbbox_tipo_consumo.Name = "cbbox_tipo_consumo";
            cbbox_tipo_consumo.Size = new Size(264, 26);
            cbbox_tipo_consumo.TabIndex = 2;
            // 
            // form_confirmacao_venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(cbbox_tipo_consumo);
            Controls.Add(lbl_tipo_consumo);
            Controls.Add(lbl_valor_total);
            Controls.Add(lbl_observacoes);
            Controls.Add(txt_observacoes);
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
        private TextBox txt_observacoes;
        private Label lbl_observacoes;
        private Label lbl_valor_total;
        private Label lbl_tipo_consumo;
        private ComboBox cbbox_tipo_consumo;
    }
}