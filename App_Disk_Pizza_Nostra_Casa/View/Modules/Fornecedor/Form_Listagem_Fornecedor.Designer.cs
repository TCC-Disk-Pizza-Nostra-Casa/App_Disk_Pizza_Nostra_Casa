namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Fornecedor
{
    partial class Form_Listagem_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Listagem_Fornecedor));
            dgv_listagem_fornecedor = new DataGridView();
            dgv_listagem_fornecedor_nome = new DataGridViewTextBoxColumn();
            dgv_listagem_fornecedor_cnpj = new DataGridViewTextBoxColumn();
            dgv_listagem_fornecedor_telefone = new DataGridViewTextBoxColumn();
            dgv_listagem_fornecedor_data_cadastro = new DataGridViewTextBoxColumn();
            dgv_listagem_fornecedor_observacoes = new DataGridViewTextBoxColumn();
            btn_pesquisar_fornecedor = new Button();
            txt_pesquisar_fornecedor = new TextBox();
            lbl_pesquisar_produtos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_fornecedor).BeginInit();
            SuspendLayout();
            // 
            // dgv_listagem_fornecedor
            // 
            dgv_listagem_fornecedor.AllowUserToAddRows = false;
            dgv_listagem_fornecedor.AllowUserToDeleteRows = false;
            dgv_listagem_fornecedor.AllowUserToOrderColumns = true;
            dgv_listagem_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_fornecedor.BackgroundColor = Color.White;
            dgv_listagem_fornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_fornecedor.Columns.AddRange(new DataGridViewColumn[] { dgv_listagem_fornecedor_nome, dgv_listagem_fornecedor_cnpj, dgv_listagem_fornecedor_telefone, dgv_listagem_fornecedor_data_cadastro, dgv_listagem_fornecedor_observacoes });
            dgv_listagem_fornecedor.Location = new Point(12, 49);
            dgv_listagem_fornecedor.MultiSelect = false;
            dgv_listagem_fornecedor.Name = "dgv_listagem_fornecedor";
            dgv_listagem_fornecedor.ReadOnly = true;
            dgv_listagem_fornecedor.RowTemplate.Height = 25;
            dgv_listagem_fornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_fornecedor.Size = new Size(760, 400);
            dgv_listagem_fornecedor.TabIndex = 1;
            // 
            // dgv_listagem_fornecedor_nome
            // 
            dgv_listagem_fornecedor_nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_fornecedor_nome.DividerWidth = 2;
            dgv_listagem_fornecedor_nome.FillWeight = 121.8274F;
            dgv_listagem_fornecedor_nome.HeaderText = "Nome";
            dgv_listagem_fornecedor_nome.Name = "dgv_listagem_fornecedor_nome";
            dgv_listagem_fornecedor_nome.ReadOnly = true;
            dgv_listagem_fornecedor_nome.Resizable = DataGridViewTriState.True;
            // 
            // dgv_listagem_fornecedor_cnpj
            // 
            dgv_listagem_fornecedor_cnpj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_fornecedor_cnpj.DividerWidth = 2;
            dgv_listagem_fornecedor_cnpj.FillWeight = 59.83022F;
            dgv_listagem_fornecedor_cnpj.HeaderText = "CNPJ";
            dgv_listagem_fornecedor_cnpj.Name = "dgv_listagem_fornecedor_cnpj";
            dgv_listagem_fornecedor_cnpj.ReadOnly = true;
            // 
            // dgv_listagem_fornecedor_telefone
            // 
            dgv_listagem_fornecedor_telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_fornecedor_telefone.DividerWidth = 2;
            dgv_listagem_fornecedor_telefone.FillWeight = 68.52115F;
            dgv_listagem_fornecedor_telefone.HeaderText = "Telefone";
            dgv_listagem_fornecedor_telefone.Name = "dgv_listagem_fornecedor_telefone";
            dgv_listagem_fornecedor_telefone.ReadOnly = true;
            // 
            // dgv_listagem_fornecedor_data_cadastro
            // 
            dgv_listagem_fornecedor_data_cadastro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_fornecedor_data_cadastro.DividerWidth = 2;
            dgv_listagem_fornecedor_data_cadastro.HeaderText = "Data de Cadastro";
            dgv_listagem_fornecedor_data_cadastro.Name = "dgv_listagem_fornecedor_data_cadastro";
            dgv_listagem_fornecedor_data_cadastro.ReadOnly = true;
            // 
            // dgv_listagem_fornecedor_observacoes
            // 
            dgv_listagem_fornecedor_observacoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_fornecedor_observacoes.FillWeight = 149.8212F;
            dgv_listagem_fornecedor_observacoes.HeaderText = "Observações";
            dgv_listagem_fornecedor_observacoes.Name = "dgv_listagem_fornecedor_observacoes";
            dgv_listagem_fornecedor_observacoes.ReadOnly = true;
            // 
            // btn_pesquisar_fornecedor
            // 
            btn_pesquisar_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_fornecedor.BackColor = Color.Transparent;
            btn_pesquisar_fornecedor.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_fornecedor.BackgroundImage");
            btn_pesquisar_fornecedor.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_fornecedor.FlatAppearance.BorderSize = 0;
            btn_pesquisar_fornecedor.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_fornecedor.Location = new Point(751, 11);
            btn_pesquisar_fornecedor.Name = "btn_pesquisar_fornecedor";
            btn_pesquisar_fornecedor.Size = new Size(23, 23);
            btn_pesquisar_fornecedor.TabIndex = 4;
            btn_pesquisar_fornecedor.UseVisualStyleBackColor = false;
            btn_pesquisar_fornecedor.Click += btn_pesquisar_fornecedor_Click;
            // 
            // txt_pesquisar_fornecedor
            // 
            txt_pesquisar_fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_fornecedor.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_fornecedor.Cursor = Cursors.IBeam;
            txt_pesquisar_fornecedor.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_fornecedor.Location = new Point(120, 12);
            txt_pesquisar_fornecedor.Name = "txt_pesquisar_fornecedor";
            txt_pesquisar_fornecedor.PlaceholderText = "Digite o nome do fornecedor...";
            txt_pesquisar_fornecedor.Size = new Size(625, 22);
            txt_pesquisar_fornecedor.TabIndex = 3;
            // 
            // lbl_pesquisar_produtos
            // 
            lbl_pesquisar_produtos.AutoSize = true;
            lbl_pesquisar_produtos.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pesquisar_produtos.Location = new Point(14, 12);
            lbl_pesquisar_produtos.Name = "lbl_pesquisar_produtos";
            lbl_pesquisar_produtos.Size = new Size(100, 22);
            lbl_pesquisar_produtos.TabIndex = 5;
            lbl_pesquisar_produtos.Text = "Pesquisar:";
            // 
            // Form_Listagem_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_pesquisar_fornecedor);
            Controls.Add(txt_pesquisar_fornecedor);
            Controls.Add(lbl_pesquisar_produtos);
            Controls.Add(dgv_listagem_fornecedor);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 500);
            Name = "Form_Listagem_Fornecedor";
            Text = "Form_Listagem_Fornecedor";
            Load += Form_Listagem_Fornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_fornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_listagem_fornecedor;
        private Button btn_pesquisar_fornecedor;
        private TextBox txt_pesquisar_fornecedor;
        private Label lbl_pesquisar_produtos;
        private DataGridViewTextBoxColumn dgv_listagem_fornecedor_nome;
        private DataGridViewTextBoxColumn dgv_listagem_fornecedor_cnpj;
        private DataGridViewTextBoxColumn dgv_listagem_fornecedor_telefone;
        private DataGridViewTextBoxColumn dgv_listagem_fornecedor_data_cadastro;
        private DataGridViewTextBoxColumn dgv_listagem_fornecedor_observacoes;
    }
}