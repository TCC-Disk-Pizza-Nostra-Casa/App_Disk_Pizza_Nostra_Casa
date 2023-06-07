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
            this.dgv_listagem_produtos = new System.Windows.Forms.DataGridView();
            this.dgv_listagem_produtos_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_listagem_produtos_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_listagem_produtos_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_listagem_produtos_observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pesquisar_produtos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listagem_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listagem_produtos
            // 
            this.dgv_listagem_produtos.AllowUserToAddRows = false;
            this.dgv_listagem_produtos.AllowUserToDeleteRows = false;
            this.dgv_listagem_produtos.AllowUserToOrderColumns = true;
            this.dgv_listagem_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listagem_produtos.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_listagem_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listagem_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_listagem_produtos_nome,
            this.dgv_listagem_produtos_estoque,
            this.dgv_listagem_produtos_preco,
            this.dgv_listagem_produtos_observacoes});
            this.dgv_listagem_produtos.Location = new System.Drawing.Point(12, 49);
            this.dgv_listagem_produtos.MultiSelect = false;
            this.dgv_listagem_produtos.Name = "dgv_listagem_produtos";
            this.dgv_listagem_produtos.ReadOnly = true;
            this.dgv_listagem_produtos.RowTemplate.Height = 25;
            this.dgv_listagem_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listagem_produtos.Size = new System.Drawing.Size(760, 400);
            this.dgv_listagem_produtos.TabIndex = 0;
            // 
            // dgv_listagem_produtos_nome
            // 
            this.dgv_listagem_produtos_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_produtos_nome.DividerWidth = 2;
            this.dgv_listagem_produtos_nome.HeaderText = "Nome";
            this.dgv_listagem_produtos_nome.Name = "dgv_listagem_produtos_nome";
            this.dgv_listagem_produtos_nome.ReadOnly = true;
            this.dgv_listagem_produtos_nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgv_listagem_produtos_estoque
            // 
            this.dgv_listagem_produtos_estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_produtos_estoque.DividerWidth = 2;
            this.dgv_listagem_produtos_estoque.HeaderText = "Estoque";
            this.dgv_listagem_produtos_estoque.Name = "dgv_listagem_produtos_estoque";
            this.dgv_listagem_produtos_estoque.ReadOnly = true;
            // 
            // dgv_listagem_produtos_preco
            // 
            this.dgv_listagem_produtos_preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_produtos_preco.DividerWidth = 2;
            this.dgv_listagem_produtos_preco.HeaderText = "Preço";
            this.dgv_listagem_produtos_preco.Name = "dgv_listagem_produtos_preco";
            this.dgv_listagem_produtos_preco.ReadOnly = true;
            // 
            // dgv_listagem_produtos_observacoes
            // 
            this.dgv_listagem_produtos_observacoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_produtos_observacoes.HeaderText = "Observações";
            this.dgv_listagem_produtos_observacoes.Name = "dgv_listagem_produtos_observacoes";
            this.dgv_listagem_produtos_observacoes.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // txt_pesquisar_produtos
            // 
            this.txt_pesquisar_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pesquisar_produtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pesquisar_produtos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pesquisar_produtos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisar_produtos.Location = new System.Drawing.Point(118, 9);
            this.txt_pesquisar_produtos.Name = "txt_pesquisar_produtos";
            this.txt_pesquisar_produtos.PlaceholderText = "Digite o nome do produto...";
            this.txt_pesquisar_produtos.Size = new System.Drawing.Size(625, 22);
            this.txt_pesquisar_produtos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(749, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // form_listagem_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pesquisar_produtos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_listagem_produtos);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "form_listagem_produtos";
            this.Text = "Form_Listagem_Produtos";
            this.Load += new System.EventHandler(this.form_listagem_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listagem_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_listagem_produtos;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_nome;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_estoque;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_preco;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_observacoes;
        private Label label1;
        private TextBox txt_pesquisar_produtos;
        private Button button1;
    }
}