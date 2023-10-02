namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Produto
{
    partial class form_listagem_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listagem_produtos));
            dgv_listagem_produtos = new DataGridView();
            dgv_listagem_produtos_nome = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_estoque = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_preco = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_observacoes = new DataGridViewTextBoxColumn();
            lbl_pesquisar_produtos = new Label();
            txt_pesquisar_produtos = new TextBox();
            btn_pesquisar_produtos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_produtos).BeginInit();
            SuspendLayout();
            // 
            // dgv_listagem_produtos
            // 
            dgv_listagem_produtos.AllowUserToAddRows = false;
            dgv_listagem_produtos.AllowUserToDeleteRows = false;
            dgv_listagem_produtos.AllowUserToOrderColumns = true;
            dgv_listagem_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listagem_produtos.BackgroundColor = Color.White;
            dgv_listagem_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_produtos.Columns.AddRange(new DataGridViewColumn[] { dgv_listagem_produtos_nome, dgv_listagem_produtos_estoque, dgv_listagem_produtos_preco, dgv_listagem_produtos_observacoes });
            dgv_listagem_produtos.Location = new Point(12, 48);
            dgv_listagem_produtos.MultiSelect = false;
            dgv_listagem_produtos.Name = "dgv_listagem_produtos";
            dgv_listagem_produtos.ReadOnly = true;
            dgv_listagem_produtos.RowTemplate.Height = 25;
            dgv_listagem_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_produtos.Size = new Size(760, 400);
            dgv_listagem_produtos.TabIndex = 0;
            // 
            // dgv_listagem_produtos_nome
            // 
            dgv_listagem_produtos_nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_produtos_nome.DividerWidth = 2;
            dgv_listagem_produtos_nome.FillWeight = 121.8274F;
            dgv_listagem_produtos_nome.HeaderText = "Nome";
            dgv_listagem_produtos_nome.Name = "dgv_listagem_produtos_nome";
            dgv_listagem_produtos_nome.ReadOnly = true;
            dgv_listagem_produtos_nome.Resizable = DataGridViewTriState.True;
            // 
            // dgv_listagem_produtos_estoque
            // 
            dgv_listagem_produtos_estoque.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_produtos_estoque.DividerWidth = 2;
            dgv_listagem_produtos_estoque.FillWeight = 59.83022F;
            dgv_listagem_produtos_estoque.HeaderText = "Estoque";
            dgv_listagem_produtos_estoque.Name = "dgv_listagem_produtos_estoque";
            dgv_listagem_produtos_estoque.ReadOnly = true;
            // 
            // dgv_listagem_produtos_preco
            // 
            dgv_listagem_produtos_preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_produtos_preco.DividerWidth = 2;
            dgv_listagem_produtos_preco.FillWeight = 68.52115F;
            dgv_listagem_produtos_preco.HeaderText = "Preço";
            dgv_listagem_produtos_preco.Name = "dgv_listagem_produtos_preco";
            dgv_listagem_produtos_preco.ReadOnly = true;
            // 
            // dgv_listagem_produtos_observacoes
            // 
            dgv_listagem_produtos_observacoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_produtos_observacoes.FillWeight = 149.8212F;
            dgv_listagem_produtos_observacoes.HeaderText = "Observações";
            dgv_listagem_produtos_observacoes.Name = "dgv_listagem_produtos_observacoes";
            dgv_listagem_produtos_observacoes.ReadOnly = true;
            // 
            // lbl_pesquisar_produtos
            // 
            lbl_pesquisar_produtos.AutoSize = true;
            lbl_pesquisar_produtos.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pesquisar_produtos.Location = new Point(12, 12);
            lbl_pesquisar_produtos.Name = "lbl_pesquisar_produtos";
            lbl_pesquisar_produtos.Size = new Size(100, 22);
            lbl_pesquisar_produtos.TabIndex = 2;
            lbl_pesquisar_produtos.Text = "Pesquisar:";
            // 
            // txt_pesquisar_produtos
            // 
            txt_pesquisar_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_produtos.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_produtos.Cursor = Cursors.IBeam;
            txt_pesquisar_produtos.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_produtos.Location = new Point(118, 12);
            txt_pesquisar_produtos.Name = "txt_pesquisar_produtos";
            txt_pesquisar_produtos.PlaceholderText = "Digite o nome do produto...";
            txt_pesquisar_produtos.Size = new Size(625, 22);
            txt_pesquisar_produtos.TabIndex = 1;
            // 
            // btn_pesquisar_produtos
            // 
            btn_pesquisar_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_produtos.BackColor = Color.Transparent;
            btn_pesquisar_produtos.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_produtos.BackgroundImage");
            btn_pesquisar_produtos.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_produtos.FlatAppearance.BorderSize = 0;
            btn_pesquisar_produtos.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_produtos.Location = new Point(749, 11);
            btn_pesquisar_produtos.Name = "btn_pesquisar_produtos";
            btn_pesquisar_produtos.Size = new Size(23, 23);
            btn_pesquisar_produtos.TabIndex = 2;
            btn_pesquisar_produtos.UseVisualStyleBackColor = false;
            btn_pesquisar_produtos.Click += btn_pesquisar_produtos_Click;
            // 
            // form_listagem_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_pesquisar_produtos);
            Controls.Add(txt_pesquisar_produtos);
            Controls.Add(lbl_pesquisar_produtos);
            Controls.Add(dgv_listagem_produtos);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "form_listagem_produtos";
            Text = "Listagem de Produtos";
            Load += form_listagem_produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_listagem_produtos;
        private Label lbl_pesquisar_produtos;
        private TextBox txt_pesquisar_produtos;
        private Button btn_pesquisar_produtos;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_nome;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_estoque;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_preco;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_observacoes;
    }
}