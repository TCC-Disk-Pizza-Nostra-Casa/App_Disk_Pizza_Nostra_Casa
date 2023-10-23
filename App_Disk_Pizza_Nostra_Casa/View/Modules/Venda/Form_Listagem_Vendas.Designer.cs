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
            btn_pesquisar_vendas = new Button();
            txt_pesquisar_vendas = new TextBox();
            lbl_pesquisar_vendas = new Label();
            dgv_listagem_vendas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_nome = new DataGridViewTextBoxColumn();
            nome_cliente = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_estoque = new DataGridViewTextBoxColumn();
            Funcionario = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_preco = new DataGridViewTextBoxColumn();
            btn_excluir = new Button();
            dtp_to_search = new DateTimePicker();
            cbx_funcionario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_vendas).BeginInit();
            SuspendLayout();
            // 
            // btn_pesquisar_vendas
            // 
            btn_pesquisar_vendas.BackColor = Color.Transparent;
            btn_pesquisar_vendas.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_vendas.BackgroundImage");
            btn_pesquisar_vendas.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_vendas.FlatAppearance.BorderSize = 0;
            btn_pesquisar_vendas.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_vendas.Location = new Point(402, 9);
            btn_pesquisar_vendas.Name = "btn_pesquisar_vendas";
            btn_pesquisar_vendas.Size = new Size(23, 23);
            btn_pesquisar_vendas.TabIndex = 4;
            btn_pesquisar_vendas.UseVisualStyleBackColor = false;
            btn_pesquisar_vendas.Click += btn_pesquisar_vendas_Click;
            // 
            // txt_pesquisar_vendas
            // 
            txt_pesquisar_vendas.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_vendas.Cursor = Cursors.IBeam;
            txt_pesquisar_vendas.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_vendas.Location = new Point(116, 12);
            txt_pesquisar_vendas.Name = "txt_pesquisar_vendas";
            txt_pesquisar_vendas.PlaceholderText = "Digite o nome do cliente:";
            txt_pesquisar_vendas.Size = new Size(280, 22);
            txt_pesquisar_vendas.TabIndex = 3;
            // 
            // lbl_pesquisar_vendas
            // 
            lbl_pesquisar_vendas.AutoSize = true;
            lbl_pesquisar_vendas.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pesquisar_vendas.Location = new Point(10, 12);
            lbl_pesquisar_vendas.Name = "lbl_pesquisar_vendas";
            lbl_pesquisar_vendas.Size = new Size(100, 22);
            lbl_pesquisar_vendas.TabIndex = 5;
            lbl_pesquisar_vendas.Text = "Pesquisar:";
            // 
            // dgv_listagem_vendas
            // 
            dgv_listagem_vendas.AllowUserToAddRows = false;
            dgv_listagem_vendas.AllowUserToDeleteRows = false;
            dgv_listagem_vendas.AllowUserToOrderColumns = true;
            dgv_listagem_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_vendas.BackgroundColor = Color.White;
            dgv_listagem_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_vendas.Columns.AddRange(new DataGridViewColumn[] { id, codigo, dgv_listagem_produtos_nome, nome_cliente, dgv_listagem_produtos_estoque, Funcionario, dgv_listagem_produtos_preco });
            dgv_listagem_vendas.Location = new Point(10, 99);
            dgv_listagem_vendas.MultiSelect = false;
            dgv_listagem_vendas.Name = "dgv_listagem_vendas";
            dgv_listagem_vendas.ReadOnly = true;
            dgv_listagem_vendas.RowTemplate.Height = 25;
            dgv_listagem_vendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_vendas.Size = new Size(762, 348);
            dgv_listagem_vendas.TabIndex = 6;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // dgv_listagem_produtos_nome
            // 
            dgv_listagem_produtos_nome.DividerWidth = 2;
            dgv_listagem_produtos_nome.FillWeight = 130F;
            dgv_listagem_produtos_nome.HeaderText = "Data da Venda";
            dgv_listagem_produtos_nome.Name = "dgv_listagem_produtos_nome";
            dgv_listagem_produtos_nome.ReadOnly = true;
            dgv_listagem_produtos_nome.Resizable = DataGridViewTriState.True;
            dgv_listagem_produtos_nome.Width = 250;
            // 
            // nome_cliente
            // 
            nome_cliente.FillWeight = 420F;
            nome_cliente.HeaderText = "Cliente";
            nome_cliente.Name = "nome_cliente";
            nome_cliente.ReadOnly = true;
            nome_cliente.Width = 200;
            // 
            // dgv_listagem_produtos_estoque
            // 
            dgv_listagem_produtos_estoque.DividerWidth = 2;
            dgv_listagem_produtos_estoque.HeaderText = "Delivery";
            dgv_listagem_produtos_estoque.Name = "dgv_listagem_produtos_estoque";
            dgv_listagem_produtos_estoque.ReadOnly = true;
            // 
            // Funcionario
            // 
            Funcionario.FillWeight = 420F;
            Funcionario.HeaderText = "Funcionario";
            Funcionario.Name = "Funcionario";
            Funcionario.ReadOnly = true;
            Funcionario.Width = 200;
            // 
            // dgv_listagem_produtos_preco
            // 
            dgv_listagem_produtos_preco.DividerWidth = 2;
            dgv_listagem_produtos_preco.FillWeight = 200F;
            dgv_listagem_produtos_preco.HeaderText = "Valor Total";
            dgv_listagem_produtos_preco.Name = "dgv_listagem_produtos_preco";
            dgv_listagem_produtos_preco.ReadOnly = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_excluir.BackColor = Color.White;
            btn_excluir.ForeColor = SystemColors.ActiveCaptionText;
            btn_excluir.Location = new Point(665, 453);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(107, 40);
            btn_excluir.TabIndex = 7;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // dtp_to_search
            // 
            dtp_to_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtp_to_search.Location = new Point(512, 12);
            dtp_to_search.Name = "dtp_to_search";
            dtp_to_search.Size = new Size(271, 23);
            dtp_to_search.TabIndex = 8;
            dtp_to_search.ValueChanged += dtp_to_search_ValueChanged;
            // 
            // cbx_funcionario
            // 
            cbx_funcionario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbx_funcionario.FormattingEnabled = true;
            cbx_funcionario.Location = new Point(825, 12);
            cbx_funcionario.Name = "cbx_funcionario";
            cbx_funcionario.Size = new Size(247, 23);
            cbx_funcionario.TabIndex = 9;
            cbx_funcionario.Text = "Selecione o funcionário:";
            // 
            // form_listagem_vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(cbx_funcionario);
            Controls.Add(dtp_to_search);
            Controls.Add(btn_excluir);
            Controls.Add(dgv_listagem_vendas);
            Controls.Add(btn_pesquisar_vendas);
            Controls.Add(txt_pesquisar_vendas);
            Controls.Add(lbl_pesquisar_vendas);
            MinimumSize = new Size(800, 500);
            Name = "form_listagem_vendas";
            Text = "Listagem de Vendas";
            Load += form_listagem_vendas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_vendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pesquisar_produtos;
        private TextBox txt_pesquisar_produtos;
        private Label lbl_pesquisar_produtos;
        private Label lbl_pesquisar_vendas;
        private Button btn_pesquisar_vendas;
        private TextBox txt_pesquisar_vendas;
        private DataGridView dgv_listagem_vendas;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_excluir;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_nome;
        private DataGridViewTextBoxColumn nome_cliente;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_estoque;
        private DataGridViewTextBoxColumn Funcionario;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_preco;
        private DateTimePicker dtp_to_search;
        private ComboBox cbx_funcionario;
    }
}