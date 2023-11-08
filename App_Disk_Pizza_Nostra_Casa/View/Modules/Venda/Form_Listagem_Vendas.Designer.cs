namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Venda
{
    partial class form_listagem_vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listagem_vendas));
            cbbox_cliente = new ComboBox();
            cbbox_funcionario = new ComboBox();
            dtpck_data_venda = new DateTimePicker();
            dgv_listagem_vendas = new DataGridView();
            dgv_listagem_itens_venda = new DataGridView();
            btn_pesquisar_venda = new Button();
            btn_resetar = new Button();
            btn_voltar = new Button();
            btn_desativar = new Button();
            btn_reativar = new Button();
            cbbox_condicao_venda = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_vendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_itens_venda).BeginInit();
            SuspendLayout();
            // 
            // cbbox_cliente
            // 
            cbbox_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_cliente.FormattingEnabled = true;
            cbbox_cliente.Location = new Point(139, 12);
            cbbox_cliente.Name = "cbbox_cliente";
            cbbox_cliente.Size = new Size(121, 26);
            cbbox_cliente.TabIndex = 0;
            // 
            // cbbox_funcionario
            // 
            cbbox_funcionario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_funcionario.FormattingEnabled = true;
            cbbox_funcionario.Location = new Point(12, 12);
            cbbox_funcionario.Name = "cbbox_funcionario";
            cbbox_funcionario.Size = new Size(121, 26);
            cbbox_funcionario.TabIndex = 1;
            // 
            // dtpck_data_venda
            // 
            dtpck_data_venda.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpck_data_venda.Format = DateTimePickerFormat.Short;
            dtpck_data_venda.Location = new Point(266, 12);
            dtpck_data_venda.Name = "dtpck_data_venda";
            dtpck_data_venda.Size = new Size(209, 26);
            dtpck_data_venda.TabIndex = 2;
            // 
            // dgv_listagem_vendas
            // 
            dgv_listagem_vendas.AllowUserToAddRows = false;
            dgv_listagem_vendas.AllowUserToDeleteRows = false;
            dgv_listagem_vendas.AllowUserToOrderColumns = true;
            dgv_listagem_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_vendas.BackgroundColor = Color.White;
            dgv_listagem_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_vendas.Location = new Point(12, 96);
            dgv_listagem_vendas.MultiSelect = false;
            dgv_listagem_vendas.Name = "dgv_listagem_vendas";
            dgv_listagem_vendas.ReadOnly = true;
            dgv_listagem_vendas.RowHeadersWidth = 51;
            dgv_listagem_vendas.RowTemplate.Height = 25;
            dgv_listagem_vendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_vendas.Size = new Size(760, 109);
            dgv_listagem_vendas.TabIndex = 50;
            // 
            // dgv_listagem_itens_venda
            // 
            dgv_listagem_itens_venda.AllowUserToAddRows = false;
            dgv_listagem_itens_venda.AllowUserToDeleteRows = false;
            dgv_listagem_itens_venda.AllowUserToOrderColumns = true;
            dgv_listagem_itens_venda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_itens_venda.BackgroundColor = Color.White;
            dgv_listagem_itens_venda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_itens_venda.Location = new Point(12, 224);
            dgv_listagem_itens_venda.MultiSelect = false;
            dgv_listagem_itens_venda.Name = "dgv_listagem_itens_venda";
            dgv_listagem_itens_venda.ReadOnly = true;
            dgv_listagem_itens_venda.RowHeadersWidth = 51;
            dgv_listagem_itens_venda.RowTemplate.Height = 25;
            dgv_listagem_itens_venda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_itens_venda.Size = new Size(760, 172);
            dgv_listagem_itens_venda.TabIndex = 51;
            // 
            // btn_pesquisar_venda
            // 
            btn_pesquisar_venda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_venda.BackColor = Color.Transparent;
            btn_pesquisar_venda.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_venda.BackgroundImage");
            btn_pesquisar_venda.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_venda.FlatAppearance.BorderSize = 0;
            btn_pesquisar_venda.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_venda.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pesquisar_venda.Location = new Point(749, 12);
            btn_pesquisar_venda.Name = "btn_pesquisar_venda";
            btn_pesquisar_venda.Size = new Size(23, 23);
            btn_pesquisar_venda.TabIndex = 52;
            btn_pesquisar_venda.UseVisualStyleBackColor = false;
            // 
            // btn_resetar
            // 
            btn_resetar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_resetar.BackColor = Color.Transparent;
            btn_resetar.Cursor = Cursors.Hand;
            btn_resetar.FlatAppearance.BorderColor = Color.Black;
            btn_resetar.FlatAppearance.BorderSize = 2;
            btn_resetar.FlatStyle = FlatStyle.Flat;
            btn_resetar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_resetar.Location = new Point(134, 410);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(116, 39);
            btn_resetar.TabIndex = 56;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = false;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_voltar.BackColor = Color.Transparent;
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.FlatAppearance.BorderColor = Color.Black;
            btn_voltar.FlatAppearance.BorderSize = 2;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_voltar.Location = new Point(12, 410);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(116, 39);
            btn_voltar.TabIndex = 55;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_desativar
            // 
            btn_desativar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_desativar.BackColor = Color.Transparent;
            btn_desativar.Cursor = Cursors.Hand;
            btn_desativar.FlatAppearance.BorderColor = Color.Black;
            btn_desativar.FlatAppearance.BorderSize = 2;
            btn_desativar.FlatStyle = FlatStyle.Flat;
            btn_desativar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_desativar.Location = new Point(534, 410);
            btn_desativar.Name = "btn_desativar";
            btn_desativar.Size = new Size(116, 39);
            btn_desativar.TabIndex = 54;
            btn_desativar.Text = "Desativar";
            btn_desativar.UseVisualStyleBackColor = false;
            btn_desativar.Click += btn_desativar_Click;
            // 
            // btn_reativar
            // 
            btn_reativar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reativar.BackColor = Color.Transparent;
            btn_reativar.Cursor = Cursors.Hand;
            btn_reativar.FlatAppearance.BorderColor = Color.Black;
            btn_reativar.FlatAppearance.BorderSize = 2;
            btn_reativar.FlatStyle = FlatStyle.Flat;
            btn_reativar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reativar.Location = new Point(656, 410);
            btn_reativar.Name = "btn_reativar";
            btn_reativar.Size = new Size(116, 39);
            btn_reativar.TabIndex = 53;
            btn_reativar.Text = "Reativar";
            btn_reativar.UseVisualStyleBackColor = false;
            btn_reativar.Click += btn_reativar_Click;
            // 
            // cbbox_condicao_venda
            // 
            cbbox_condicao_venda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbox_condicao_venda.Cursor = Cursors.Hand;
            cbbox_condicao_venda.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_condicao_venda.FormattingEnabled = true;
            cbbox_condicao_venda.Location = new Point(613, 54);
            cbbox_condicao_venda.Name = "cbbox_condicao_venda";
            cbbox_condicao_venda.Size = new Size(159, 26);
            cbbox_condicao_venda.TabIndex = 57;
            // 
            // form_listagem_vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(cbbox_condicao_venda);
            Controls.Add(btn_resetar);
            Controls.Add(btn_voltar);
            Controls.Add(btn_desativar);
            Controls.Add(btn_reativar);
            Controls.Add(btn_pesquisar_venda);
            Controls.Add(dgv_listagem_itens_venda);
            Controls.Add(dgv_listagem_vendas);
            Controls.Add(dtpck_data_venda);
            Controls.Add(cbbox_funcionario);
            Controls.Add(cbbox_cliente);
            MinimumSize = new Size(800, 500);
            Name = "form_listagem_vendas";
            Text = "Listagem de Vendas";
            Load += form_listagem_vendas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_vendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_itens_venda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_pesquisar_produtos;
        private TextBox txt_pesquisar_produtos;
        private Label lbl_pesquisar_produtos;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cbbox_cliente;
        private ComboBox cbbox_funcionario;
        private DateTimePicker dtpck_data_venda;
        private DataGridView dgv_listagem_vendas;
        private DataGridView dgv_listagem_itens_venda;
        private Button btn_pesquisar_venda;
        private Button btn_resetar;
        private Button btn_voltar;
        private Button btn_desativar;
        private Button btn_reativar;
        private ComboBox cbbox_condicao_venda;
    }
}