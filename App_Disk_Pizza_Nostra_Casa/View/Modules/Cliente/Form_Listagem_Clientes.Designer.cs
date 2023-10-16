namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Cliente
{
    partial class form_listagem_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listagem_clientes));
            btn_resetar = new Button();
            cbbox_condicao_cliente = new ComboBox();
            btn_voltar = new Button();
            btn_desativar = new Button();
            btn_reativar = new Button();
            btn_pesquisar_cliente = new Button();
            txt_pesquisar_cliente = new TextBox();
            lbl_pesquisar_cliente = new Label();
            dgv_listagem_clientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_clientes).BeginInit();
            SuspendLayout();
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
            btn_resetar.TabIndex = 48;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = false;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // cbbox_condicao_cliente
            // 
            cbbox_condicao_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbox_condicao_cliente.Cursor = Cursors.Hand;
            cbbox_condicao_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_condicao_cliente.FormattingEnabled = true;
            cbbox_condicao_cliente.Location = new Point(613, 53);
            cbbox_condicao_cliente.Name = "cbbox_condicao_cliente";
            cbbox_condicao_cliente.Size = new Size(159, 26);
            cbbox_condicao_cliente.TabIndex = 47;
            cbbox_condicao_cliente.SelectedIndexChanged += cbbox_condicao_cliente_SelectedIndexChanged;
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
            btn_voltar.TabIndex = 46;
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
            btn_desativar.TabIndex = 45;
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
            btn_reativar.TabIndex = 44;
            btn_reativar.Text = "Reativar";
            btn_reativar.UseVisualStyleBackColor = false;
            btn_reativar.Click += btn_reativar_Click;
            // 
            // btn_pesquisar_cliente
            // 
            btn_pesquisar_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_cliente.BackColor = Color.Transparent;
            btn_pesquisar_cliente.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_cliente.BackgroundImage");
            btn_pesquisar_cliente.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_cliente.FlatAppearance.BorderSize = 0;
            btn_pesquisar_cliente.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_cliente.Location = new Point(749, 13);
            btn_pesquisar_cliente.Name = "btn_pesquisar_cliente";
            btn_pesquisar_cliente.Size = new Size(23, 23);
            btn_pesquisar_cliente.TabIndex = 42;
            btn_pesquisar_cliente.UseVisualStyleBackColor = false;
            btn_pesquisar_cliente.Click += btn_pesquisar_cliente_Click;
            // 
            // txt_pesquisar_cliente
            // 
            txt_pesquisar_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_cliente.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_cliente.Cursor = Cursors.IBeam;
            txt_pesquisar_cliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_cliente.Location = new Point(110, 12);
            txt_pesquisar_cliente.Name = "txt_pesquisar_cliente";
            txt_pesquisar_cliente.PlaceholderText = "Digite o nome do cliente...";
            txt_pesquisar_cliente.Size = new Size(633, 26);
            txt_pesquisar_cliente.TabIndex = 41;
            // 
            // lbl_pesquisar_cliente
            // 
            lbl_pesquisar_cliente.AutoSize = true;
            lbl_pesquisar_cliente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pesquisar_cliente.Location = new Point(12, 14);
            lbl_pesquisar_cliente.Name = "lbl_pesquisar_cliente";
            lbl_pesquisar_cliente.Size = new Size(92, 19);
            lbl_pesquisar_cliente.TabIndex = 43;
            lbl_pesquisar_cliente.Text = "Pesquisar:";
            // 
            // dgv_listagem_clientes
            // 
            dgv_listagem_clientes.AllowUserToAddRows = false;
            dgv_listagem_clientes.AllowUserToDeleteRows = false;
            dgv_listagem_clientes.AllowUserToOrderColumns = true;
            dgv_listagem_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_clientes.BackgroundColor = Color.White;
            dgv_listagem_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_clientes.Location = new Point(12, 96);
            dgv_listagem_clientes.MultiSelect = false;
            dgv_listagem_clientes.Name = "dgv_listagem_clientes";
            dgv_listagem_clientes.ReadOnly = true;
            dgv_listagem_clientes.RowHeadersWidth = 51;
            dgv_listagem_clientes.RowTemplate.Height = 25;
            dgv_listagem_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_clientes.Size = new Size(760, 301);
            dgv_listagem_clientes.TabIndex = 40;
            dgv_listagem_clientes.CellClick += dgv_listagem_clientes_CellClick;
            dgv_listagem_clientes.CellDoubleClick += dgv_listagem_clientes_CellDoubleClick;
            // 
            // form_listagem_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_resetar);
            Controls.Add(cbbox_condicao_cliente);
            Controls.Add(btn_voltar);
            Controls.Add(btn_desativar);
            Controls.Add(btn_reativar);
            Controls.Add(btn_pesquisar_cliente);
            Controls.Add(txt_pesquisar_cliente);
            Controls.Add(lbl_pesquisar_cliente);
            Controls.Add(dgv_listagem_clientes);
            MinimumSize = new Size(800, 500);
            Name = "form_listagem_clientes";
            Text = "Listagem de Clientes";
            Load += form_listagem_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_resetar;
        private ComboBox cbbox_condicao_cliente;
        private Button btn_voltar;
        private Button btn_desativar;
        private Button btn_reativar;
        private Button btn_pesquisar_cliente;
        private TextBox txt_pesquisar_cliente;
        private Label lbl_pesquisar_cliente;
        private DataGridView dgv_listagem_clientes;
    }
}