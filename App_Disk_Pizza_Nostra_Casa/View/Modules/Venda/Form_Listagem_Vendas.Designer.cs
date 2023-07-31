﻿namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Venda
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
            dgv_listagem_produtos_nome = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_estoque = new DataGridViewTextBoxColumn();
            dgv_listagem_produtos_preco = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_listagem_vendas).BeginInit();
            SuspendLayout();
            // 
            // btn_pesquisar_vendas
            // 
            btn_pesquisar_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar_vendas.BackColor = Color.Transparent;
            btn_pesquisar_vendas.BackgroundImage = (Image)resources.GetObject("btn_pesquisar_vendas.BackgroundImage");
            btn_pesquisar_vendas.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar_vendas.FlatAppearance.BorderSize = 0;
            btn_pesquisar_vendas.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_vendas.Location = new Point(747, 11);
            btn_pesquisar_vendas.Name = "btn_pesquisar_vendas";
            btn_pesquisar_vendas.Size = new Size(23, 23);
            btn_pesquisar_vendas.TabIndex = 4;
            btn_pesquisar_vendas.UseVisualStyleBackColor = false;
            // 
            // txt_pesquisar_vendas
            // 
            txt_pesquisar_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pesquisar_vendas.BorderStyle = BorderStyle.FixedSingle;
            txt_pesquisar_vendas.Cursor = Cursors.IBeam;
            txt_pesquisar_vendas.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar_vendas.Location = new Point(116, 12);
            txt_pesquisar_vendas.Name = "txt_pesquisar_vendas";
            txt_pesquisar_vendas.PlaceholderText = "Digite a venda...";
            txt_pesquisar_vendas.Size = new Size(625, 22);
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
            dgv_listagem_vendas.BackgroundColor = Color.Gray;
            dgv_listagem_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listagem_vendas.Columns.AddRange(new DataGridViewColumn[] { dgv_listagem_produtos_nome, dgv_listagem_produtos_estoque, dgv_listagem_produtos_preco });
            dgv_listagem_vendas.Location = new Point(10, 49);
            dgv_listagem_vendas.MultiSelect = false;
            dgv_listagem_vendas.Name = "dgv_listagem_vendas";
            dgv_listagem_vendas.ReadOnly = true;
            dgv_listagem_vendas.RowTemplate.Height = 25;
            dgv_listagem_vendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listagem_vendas.Size = new Size(760, 400);
            dgv_listagem_vendas.TabIndex = 6;
            dgv_listagem_vendas.CellContentClick += dgv_listagem_vendas_CellContentClick;
            // 
            // dgv_listagem_produtos_nome
            // 
            dgv_listagem_produtos_nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_produtos_nome.DividerWidth = 2;
            dgv_listagem_produtos_nome.FillWeight = 121.8274F;
            dgv_listagem_produtos_nome.HeaderText = "Data da Venda";
            dgv_listagem_produtos_nome.Name = "dgv_listagem_produtos_nome";
            dgv_listagem_produtos_nome.ReadOnly = true;
            dgv_listagem_produtos_nome.Resizable = DataGridViewTriState.True;
            // 
            // dgv_listagem_produtos_estoque
            // 
            dgv_listagem_produtos_estoque.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_produtos_estoque.DividerWidth = 2;
            dgv_listagem_produtos_estoque.FillWeight = 59.83022F;
            dgv_listagem_produtos_estoque.HeaderText = "Delivery";
            dgv_listagem_produtos_estoque.Name = "dgv_listagem_produtos_estoque";
            dgv_listagem_produtos_estoque.ReadOnly = true;
            // 
            // dgv_listagem_produtos_preco
            // 
            dgv_listagem_produtos_preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listagem_produtos_preco.DividerWidth = 2;
            dgv_listagem_produtos_preco.FillWeight = 68.52115F;
            dgv_listagem_produtos_preco.HeaderText = "Valor Total";
            dgv_listagem_produtos_preco.Name = "dgv_listagem_produtos_preco";
            dgv_listagem_produtos_preco.ReadOnly = true;
            // 
            // form_listagem_vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
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
        private DataGridView dgv_listagem_produtos;
        private Label lbl_pesquisar_vendas;
        private Button btn_pesquisar_vendas;
        private TextBox txt_pesquisar_vendas;
        private DataGridView dgv_listagem_vendas;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_nome;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_estoque;
        private DataGridViewTextBoxColumn dgv_listagem_produtos_preco;
    }
}