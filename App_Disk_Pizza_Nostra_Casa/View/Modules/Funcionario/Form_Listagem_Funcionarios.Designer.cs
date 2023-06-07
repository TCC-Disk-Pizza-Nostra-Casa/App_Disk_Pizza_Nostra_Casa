namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Funcionario
{
    partial class form_listagem_funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listagem_funcionarios));
            this.btn_pesquisar_funcionario = new System.Windows.Forms.Button();
            this.txt_pesquisar_funcionario = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_funcionario = new System.Windows.Forms.Label();
            this.dgv_listagem_funcionarios = new System.Windows.Forms.DataGridView();
            this.dgv_listagem_funcionarios_numero_linha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_listagem_funcionarios_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_listagem_funcionarios_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_listagem_funcionarios_contratacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listagem_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar_funcionario
            // 
            this.btn_pesquisar_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisar_funcionario.BackColor = System.Drawing.Color.Transparent;
            this.btn_pesquisar_funcionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar_funcionario.BackgroundImage")));
            this.btn_pesquisar_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pesquisar_funcionario.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar_funcionario.Location = new System.Drawing.Point(749, 8);
            this.btn_pesquisar_funcionario.Name = "btn_pesquisar_funcionario";
            this.btn_pesquisar_funcionario.Size = new System.Drawing.Size(23, 23);
            this.btn_pesquisar_funcionario.TabIndex = 5;
            this.btn_pesquisar_funcionario.UseVisualStyleBackColor = false;
            // 
            // txt_pesquisar_funcionario
            // 
            this.txt_pesquisar_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pesquisar_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pesquisar_funcionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pesquisar_funcionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisar_funcionario.Location = new System.Drawing.Point(118, 9);
            this.txt_pesquisar_funcionario.Name = "txt_pesquisar_funcionario";
            this.txt_pesquisar_funcionario.PlaceholderText = "Digite o nome do funcionário...";
            this.txt_pesquisar_funcionario.Size = new System.Drawing.Size(625, 22);
            this.txt_pesquisar_funcionario.TabIndex = 4;
            // 
            // lbl_pesquisar_funcionario
            // 
            this.lbl_pesquisar_funcionario.AutoSize = true;
            this.lbl_pesquisar_funcionario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pesquisar_funcionario.Location = new System.Drawing.Point(12, 9);
            this.lbl_pesquisar_funcionario.Name = "lbl_pesquisar_funcionario";
            this.lbl_pesquisar_funcionario.Size = new System.Drawing.Size(100, 22);
            this.lbl_pesquisar_funcionario.TabIndex = 6;
            this.lbl_pesquisar_funcionario.Text = "Pesquisar:";
            // 
            // dgv_listagem_funcionarios
            // 
            this.dgv_listagem_funcionarios.AllowUserToAddRows = false;
            this.dgv_listagem_funcionarios.AllowUserToDeleteRows = false;
            this.dgv_listagem_funcionarios.AllowUserToOrderColumns = true;
            this.dgv_listagem_funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listagem_funcionarios.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_listagem_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listagem_funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_listagem_funcionarios_numero_linha,
            this.dgv_listagem_funcionarios_nome,
            this.dgv_listagem_funcionarios_email,
            this.dgv_listagem_funcionarios_contratacao});
            this.dgv_listagem_funcionarios.Location = new System.Drawing.Point(12, 48);
            this.dgv_listagem_funcionarios.MultiSelect = false;
            this.dgv_listagem_funcionarios.Name = "dgv_listagem_funcionarios";
            this.dgv_listagem_funcionarios.ReadOnly = true;
            this.dgv_listagem_funcionarios.RowTemplate.Height = 25;
            this.dgv_listagem_funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listagem_funcionarios.Size = new System.Drawing.Size(760, 401);
            this.dgv_listagem_funcionarios.TabIndex = 3;
            // 
            // dgv_listagem_funcionarios_numero_linha
            // 
            this.dgv_listagem_funcionarios_numero_linha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_funcionarios_numero_linha.DividerWidth = 2;
            this.dgv_listagem_funcionarios_numero_linha.HeaderText = "Nº Linha:";
            this.dgv_listagem_funcionarios_numero_linha.Name = "dgv_listagem_funcionarios_numero_linha";
            this.dgv_listagem_funcionarios_numero_linha.ReadOnly = true;
            this.dgv_listagem_funcionarios_numero_linha.ToolTipText = "Numeração das linhas da tabela.";
            // 
            // dgv_listagem_funcionarios_nome
            // 
            this.dgv_listagem_funcionarios_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_funcionarios_nome.DividerWidth = 2;
            this.dgv_listagem_funcionarios_nome.HeaderText = "Nome:";
            this.dgv_listagem_funcionarios_nome.Name = "dgv_listagem_funcionarios_nome";
            this.dgv_listagem_funcionarios_nome.ReadOnly = true;
            this.dgv_listagem_funcionarios_nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listagem_funcionarios_nome.ToolTipText = "Nome completo do funcionário.";
            // 
            // dgv_listagem_funcionarios_email
            // 
            this.dgv_listagem_funcionarios_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_funcionarios_email.DividerWidth = 2;
            this.dgv_listagem_funcionarios_email.HeaderText = "E-Mail:";
            this.dgv_listagem_funcionarios_email.Name = "dgv_listagem_funcionarios_email";
            this.dgv_listagem_funcionarios_email.ReadOnly = true;
            this.dgv_listagem_funcionarios_email.ToolTipText = "E-Mail do funcionário.";
            // 
            // dgv_listagem_funcionarios_contratacao
            // 
            this.dgv_listagem_funcionarios_contratacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_listagem_funcionarios_contratacao.HeaderText = "Contratado em:";
            this.dgv_listagem_funcionarios_contratacao.Name = "dgv_listagem_funcionarios_contratacao";
            this.dgv_listagem_funcionarios_contratacao.ReadOnly = true;
            this.dgv_listagem_funcionarios_contratacao.ToolTipText = "Data de contratação do funcionário";
            // 
            // form_listagem_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_pesquisar_funcionario);
            this.Controls.Add(this.txt_pesquisar_funcionario);
            this.Controls.Add(this.lbl_pesquisar_funcionario);
            this.Controls.Add(this.dgv_listagem_funcionarios);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "form_listagem_funcionarios";
            this.Text = "Listagem de Funcionários";
            this.Load += new System.EventHandler(this.form_listagem_funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listagem_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_pesquisar_funcionario;
        private TextBox txt_pesquisar_funcionario;
        private Label lbl_pesquisar_funcionario;
        private DataGridView dgv_listagem_funcionarios;
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_numero_linha;
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_nome;
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_email;
        private DataGridViewTextBoxColumn dgv_listagem_funcionarios_contratacao;
    }
}