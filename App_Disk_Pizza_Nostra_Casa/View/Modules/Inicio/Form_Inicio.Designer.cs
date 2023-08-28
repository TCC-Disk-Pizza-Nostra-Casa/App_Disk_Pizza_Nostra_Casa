namespace App_Disk_Pizza_Nostra_Casa.View.Modules.Inicio
{
    partial class form_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_inicio));
            pnl_menu_lateral = new Panel();
            pnl_opcoes = new Panel();
            btn_perfil = new Button();
            btn_sair = new Button();
            pnl_submenu_vendas = new Panel();
            btn_listagem_vendas = new Button();
            btn_adicionar_venda = new Button();
            btn_vendas = new Button();
            pnl_submenu_produtos = new Panel();
            btn_listagem_produtos = new Button();
            btn_cadastro_produtos = new Button();
            btn_produtos = new Button();
            pnl_submenu_funcionarios = new Panel();
            btn_listagem_funcionarios = new Button();
            btn_cadastro_funcionarios = new Button();
            btn_funcionarios = new Button();
            pnl_logo = new Panel();
            pctbox_logo = new PictureBox();
            pnl_formulario_externo = new Panel();
            pctbox_icone_espera = new PictureBox();
            pnl_titulo_formulario_externo = new Panel();
            pnl_menu_lateral.SuspendLayout();
            pnl_opcoes.SuspendLayout();
            pnl_submenu_vendas.SuspendLayout();
            pnl_submenu_produtos.SuspendLayout();
            pnl_submenu_funcionarios.SuspendLayout();
            pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbox_logo).BeginInit();
            pnl_formulario_externo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbox_icone_espera).BeginInit();
            SuspendLayout();
            // 
            // pnl_menu_lateral
            // 
            pnl_menu_lateral.BackColor = Color.FromArgb(130, 69, 34);
            pnl_menu_lateral.Controls.Add(pnl_opcoes);
            pnl_menu_lateral.Controls.Add(pnl_logo);
            pnl_menu_lateral.Dock = DockStyle.Left;
            pnl_menu_lateral.Location = new Point(0, 0);
            pnl_menu_lateral.Name = "pnl_menu_lateral";
            pnl_menu_lateral.Size = new Size(211, 784);
            pnl_menu_lateral.TabIndex = 0;
            // 
            // pnl_opcoes
            // 
            pnl_opcoes.AutoScroll = true;
            pnl_opcoes.Controls.Add(btn_perfil);
            pnl_opcoes.Controls.Add(btn_sair);
            pnl_opcoes.Controls.Add(pnl_submenu_vendas);
            pnl_opcoes.Controls.Add(btn_vendas);
            pnl_opcoes.Controls.Add(pnl_submenu_produtos);
            pnl_opcoes.Controls.Add(btn_produtos);
            pnl_opcoes.Controls.Add(pnl_submenu_funcionarios);
            pnl_opcoes.Controls.Add(btn_funcionarios);
            pnl_opcoes.Dock = DockStyle.Fill;
            pnl_opcoes.Location = new Point(0, 147);
            pnl_opcoes.Name = "pnl_opcoes";
            pnl_opcoes.Size = new Size(211, 637);
            pnl_opcoes.TabIndex = 12;
            // 
            // btn_perfil
            // 
            btn_perfil.BackColor = Color.Transparent;
            btn_perfil.Cursor = Cursors.Hand;
            btn_perfil.Dock = DockStyle.Bottom;
            btn_perfil.FlatAppearance.BorderSize = 0;
            btn_perfil.FlatAppearance.CheckedBackColor = Color.SaddleBrown;
            btn_perfil.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btn_perfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 68, 0);
            btn_perfil.FlatStyle = FlatStyle.Flat;
            btn_perfil.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_perfil.ForeColor = Color.White;
            btn_perfil.Location = new Point(0, 537);
            btn_perfil.Name = "btn_perfil";
            btn_perfil.Padding = new Padding(10, 0, 0, 0);
            btn_perfil.Size = new Size(211, 50);
            btn_perfil.TabIndex = 12;
            btn_perfil.Text = "Perfil";
            btn_perfil.TextAlign = ContentAlignment.MiddleLeft;
            btn_perfil.UseVisualStyleBackColor = false;
            btn_perfil.Click += btn_perfil_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.Transparent;
            btn_sair.Cursor = Cursors.Hand;
            btn_sair.Dock = DockStyle.Bottom;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatAppearance.CheckedBackColor = Color.SaddleBrown;
            btn_sair.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btn_sair.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 68, 0);
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.ForeColor = Color.White;
            btn_sair.Location = new Point(0, 587);
            btn_sair.Name = "btn_sair";
            btn_sair.Padding = new Padding(10, 0, 0, 0);
            btn_sair.Size = new Size(211, 50);
            btn_sair.TabIndex = 2;
            btn_sair.Text = "Sair";
            btn_sair.TextAlign = ContentAlignment.MiddleLeft;
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // pnl_submenu_vendas
            // 
            pnl_submenu_vendas.Controls.Add(btn_listagem_vendas);
            pnl_submenu_vendas.Controls.Add(btn_adicionar_venda);
            pnl_submenu_vendas.Dock = DockStyle.Top;
            pnl_submenu_vendas.Location = new Point(0, 326);
            pnl_submenu_vendas.Name = "pnl_submenu_vendas";
            pnl_submenu_vendas.Size = new Size(211, 88);
            pnl_submenu_vendas.TabIndex = 11;
            // 
            // btn_listagem_vendas
            // 
            btn_listagem_vendas.BackColor = Color.FromArgb(153, 88, 50);
            btn_listagem_vendas.Cursor = Cursors.Hand;
            btn_listagem_vendas.Dock = DockStyle.Top;
            btn_listagem_vendas.FlatAppearance.BorderSize = 0;
            btn_listagem_vendas.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 108, 48);
            btn_listagem_vendas.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 108, 48);
            btn_listagem_vendas.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 98, 55);
            btn_listagem_vendas.FlatStyle = FlatStyle.Flat;
            btn_listagem_vendas.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_listagem_vendas.ForeColor = Color.White;
            btn_listagem_vendas.Location = new Point(0, 44);
            btn_listagem_vendas.Name = "btn_listagem_vendas";
            btn_listagem_vendas.Padding = new Padding(30, 0, 0, 0);
            btn_listagem_vendas.Size = new Size(211, 44);
            btn_listagem_vendas.TabIndex = 10;
            btn_listagem_vendas.Text = "Listagem";
            btn_listagem_vendas.TextAlign = ContentAlignment.MiddleLeft;
            btn_listagem_vendas.UseVisualStyleBackColor = false;
            btn_listagem_vendas.Click += btn_listagem_vendas_Click;
            // 
            // btn_adicionar_venda
            // 
            btn_adicionar_venda.BackColor = Color.FromArgb(153, 88, 50);
            btn_adicionar_venda.Cursor = Cursors.Hand;
            btn_adicionar_venda.Dock = DockStyle.Top;
            btn_adicionar_venda.FlatAppearance.BorderSize = 0;
            btn_adicionar_venda.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 108, 48);
            btn_adicionar_venda.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 108, 48);
            btn_adicionar_venda.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 98, 55);
            btn_adicionar_venda.FlatStyle = FlatStyle.Flat;
            btn_adicionar_venda.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_adicionar_venda.ForeColor = Color.White;
            btn_adicionar_venda.Location = new Point(0, 0);
            btn_adicionar_venda.Name = "btn_adicionar_venda";
            btn_adicionar_venda.Padding = new Padding(30, 0, 0, 0);
            btn_adicionar_venda.Size = new Size(211, 44);
            btn_adicionar_venda.TabIndex = 9;
            btn_adicionar_venda.Text = "Adicionar venda";
            btn_adicionar_venda.TextAlign = ContentAlignment.MiddleLeft;
            btn_adicionar_venda.UseVisualStyleBackColor = false;
            btn_adicionar_venda.Click += btn_adicionar_venda_Click;
            // 
            // btn_vendas
            // 
            btn_vendas.Cursor = Cursors.Hand;
            btn_vendas.Dock = DockStyle.Top;
            btn_vendas.FlatAppearance.BorderSize = 0;
            btn_vendas.FlatAppearance.CheckedBackColor = Color.SaddleBrown;
            btn_vendas.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btn_vendas.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 68, 0);
            btn_vendas.FlatStyle = FlatStyle.Flat;
            btn_vendas.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_vendas.ForeColor = Color.White;
            btn_vendas.Location = new Point(0, 276);
            btn_vendas.Name = "btn_vendas";
            btn_vendas.Padding = new Padding(10, 0, 0, 0);
            btn_vendas.Size = new Size(211, 50);
            btn_vendas.TabIndex = 8;
            btn_vendas.Text = "Vendas";
            btn_vendas.TextAlign = ContentAlignment.MiddleLeft;
            btn_vendas.UseVisualStyleBackColor = true;
            btn_vendas.Click += btn_vendas_Click;
            // 
            // pnl_submenu_produtos
            // 
            pnl_submenu_produtos.Controls.Add(btn_listagem_produtos);
            pnl_submenu_produtos.Controls.Add(btn_cadastro_produtos);
            pnl_submenu_produtos.Dock = DockStyle.Top;
            pnl_submenu_produtos.Location = new Point(0, 188);
            pnl_submenu_produtos.Name = "pnl_submenu_produtos";
            pnl_submenu_produtos.Size = new Size(211, 88);
            pnl_submenu_produtos.TabIndex = 8;
            // 
            // btn_listagem_produtos
            // 
            btn_listagem_produtos.BackColor = Color.FromArgb(153, 88, 50);
            btn_listagem_produtos.Cursor = Cursors.Hand;
            btn_listagem_produtos.Dock = DockStyle.Top;
            btn_listagem_produtos.FlatAppearance.BorderSize = 0;
            btn_listagem_produtos.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 108, 48);
            btn_listagem_produtos.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 108, 48);
            btn_listagem_produtos.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 98, 55);
            btn_listagem_produtos.FlatStyle = FlatStyle.Flat;
            btn_listagem_produtos.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_listagem_produtos.ForeColor = Color.White;
            btn_listagem_produtos.Location = new Point(0, 44);
            btn_listagem_produtos.Name = "btn_listagem_produtos";
            btn_listagem_produtos.Padding = new Padding(30, 0, 0, 0);
            btn_listagem_produtos.Size = new Size(211, 44);
            btn_listagem_produtos.TabIndex = 7;
            btn_listagem_produtos.Text = "Listagem";
            btn_listagem_produtos.TextAlign = ContentAlignment.MiddleLeft;
            btn_listagem_produtos.UseVisualStyleBackColor = false;
            btn_listagem_produtos.Click += btn_listagem_produtos_Click;
            // 
            // btn_cadastro_produtos
            // 
            btn_cadastro_produtos.BackColor = Color.FromArgb(153, 88, 50);
            btn_cadastro_produtos.Cursor = Cursors.Hand;
            btn_cadastro_produtos.Dock = DockStyle.Top;
            btn_cadastro_produtos.FlatAppearance.BorderSize = 0;
            btn_cadastro_produtos.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 108, 48);
            btn_cadastro_produtos.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 108, 48);
            btn_cadastro_produtos.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 98, 55);
            btn_cadastro_produtos.FlatStyle = FlatStyle.Flat;
            btn_cadastro_produtos.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastro_produtos.ForeColor = Color.White;
            btn_cadastro_produtos.Location = new Point(0, 0);
            btn_cadastro_produtos.Name = "btn_cadastro_produtos";
            btn_cadastro_produtos.Padding = new Padding(30, 0, 0, 0);
            btn_cadastro_produtos.Size = new Size(211, 44);
            btn_cadastro_produtos.TabIndex = 6;
            btn_cadastro_produtos.Text = "Cadastro";
            btn_cadastro_produtos.TextAlign = ContentAlignment.MiddleLeft;
            btn_cadastro_produtos.UseVisualStyleBackColor = false;
            btn_cadastro_produtos.Click += btn_cadastro_produto_Click;
            // 
            // btn_produtos
            // 
            btn_produtos.Cursor = Cursors.Hand;
            btn_produtos.Dock = DockStyle.Top;
            btn_produtos.FlatAppearance.BorderSize = 0;
            btn_produtos.FlatAppearance.CheckedBackColor = Color.SaddleBrown;
            btn_produtos.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btn_produtos.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 68, 0);
            btn_produtos.FlatStyle = FlatStyle.Flat;
            btn_produtos.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_produtos.ForeColor = Color.White;
            btn_produtos.Location = new Point(0, 138);
            btn_produtos.Name = "btn_produtos";
            btn_produtos.Padding = new Padding(10, 0, 0, 0);
            btn_produtos.Size = new Size(211, 50);
            btn_produtos.TabIndex = 5;
            btn_produtos.Text = "Produtos";
            btn_produtos.TextAlign = ContentAlignment.MiddleLeft;
            btn_produtos.UseVisualStyleBackColor = true;
            btn_produtos.Click += btn_produtos_Click;
            // 
            // pnl_submenu_funcionarios
            // 
            pnl_submenu_funcionarios.BackColor = Color.Transparent;
            pnl_submenu_funcionarios.Controls.Add(btn_listagem_funcionarios);
            pnl_submenu_funcionarios.Controls.Add(btn_cadastro_funcionarios);
            pnl_submenu_funcionarios.Dock = DockStyle.Top;
            pnl_submenu_funcionarios.Location = new Point(0, 50);
            pnl_submenu_funcionarios.Name = "pnl_submenu_funcionarios";
            pnl_submenu_funcionarios.Size = new Size(211, 88);
            pnl_submenu_funcionarios.TabIndex = 1;
            // 
            // btn_listagem_funcionarios
            // 
            btn_listagem_funcionarios.BackColor = Color.FromArgb(153, 88, 50);
            btn_listagem_funcionarios.Cursor = Cursors.Hand;
            btn_listagem_funcionarios.Dock = DockStyle.Top;
            btn_listagem_funcionarios.FlatAppearance.BorderColor = Color.Black;
            btn_listagem_funcionarios.FlatAppearance.BorderSize = 0;
            btn_listagem_funcionarios.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 108, 48);
            btn_listagem_funcionarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 108, 48);
            btn_listagem_funcionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 98, 55);
            btn_listagem_funcionarios.FlatStyle = FlatStyle.Flat;
            btn_listagem_funcionarios.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_listagem_funcionarios.ForeColor = Color.White;
            btn_listagem_funcionarios.Location = new Point(0, 44);
            btn_listagem_funcionarios.Name = "btn_listagem_funcionarios";
            btn_listagem_funcionarios.Padding = new Padding(30, 0, 0, 0);
            btn_listagem_funcionarios.Size = new Size(211, 44);
            btn_listagem_funcionarios.TabIndex = 4;
            btn_listagem_funcionarios.Text = "Listagem";
            btn_listagem_funcionarios.TextAlign = ContentAlignment.MiddleLeft;
            btn_listagem_funcionarios.UseVisualStyleBackColor = false;
            btn_listagem_funcionarios.Click += btn_listagem_funcionario_Click;
            // 
            // btn_cadastro_funcionarios
            // 
            btn_cadastro_funcionarios.BackColor = Color.FromArgb(153, 88, 50);
            btn_cadastro_funcionarios.Cursor = Cursors.Hand;
            btn_cadastro_funcionarios.Dock = DockStyle.Top;
            btn_cadastro_funcionarios.FlatAppearance.BorderColor = Color.Black;
            btn_cadastro_funcionarios.FlatAppearance.BorderSize = 0;
            btn_cadastro_funcionarios.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 108, 48);
            btn_cadastro_funcionarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 108, 48);
            btn_cadastro_funcionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 98, 55);
            btn_cadastro_funcionarios.FlatStyle = FlatStyle.Flat;
            btn_cadastro_funcionarios.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastro_funcionarios.ForeColor = Color.White;
            btn_cadastro_funcionarios.Location = new Point(0, 0);
            btn_cadastro_funcionarios.Name = "btn_cadastro_funcionarios";
            btn_cadastro_funcionarios.Padding = new Padding(30, 0, 0, 0);
            btn_cadastro_funcionarios.Size = new Size(211, 44);
            btn_cadastro_funcionarios.TabIndex = 3;
            btn_cadastro_funcionarios.Text = "Cadastro";
            btn_cadastro_funcionarios.TextAlign = ContentAlignment.MiddleLeft;
            btn_cadastro_funcionarios.UseVisualStyleBackColor = false;
            btn_cadastro_funcionarios.Click += btn_cadastro_funcionario_Click;
            // 
            // btn_funcionarios
            // 
            btn_funcionarios.BackColor = Color.Transparent;
            btn_funcionarios.Cursor = Cursors.Hand;
            btn_funcionarios.Dock = DockStyle.Top;
            btn_funcionarios.FlatAppearance.BorderSize = 0;
            btn_funcionarios.FlatAppearance.CheckedBackColor = Color.SaddleBrown;
            btn_funcionarios.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btn_funcionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 68, 0);
            btn_funcionarios.FlatStyle = FlatStyle.Flat;
            btn_funcionarios.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_funcionarios.ForeColor = Color.White;
            btn_funcionarios.Location = new Point(0, 0);
            btn_funcionarios.Name = "btn_funcionarios";
            btn_funcionarios.Padding = new Padding(10, 0, 0, 0);
            btn_funcionarios.Size = new Size(211, 50);
            btn_funcionarios.TabIndex = 1;
            btn_funcionarios.Text = "Funcionários";
            btn_funcionarios.TextAlign = ContentAlignment.MiddleLeft;
            btn_funcionarios.UseVisualStyleBackColor = false;
            btn_funcionarios.Click += btn_funcionarios_Click;
            // 
            // pnl_logo
            // 
            pnl_logo.Controls.Add(pctbox_logo);
            pnl_logo.Dock = DockStyle.Top;
            pnl_logo.Location = new Point(0, 0);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(211, 147);
            pnl_logo.TabIndex = 0;
            // 
            // pctbox_logo
            // 
            pctbox_logo.Dock = DockStyle.Fill;
            pctbox_logo.Image = (Image)resources.GetObject("pctbox_logo.Image");
            pctbox_logo.Location = new Point(0, 0);
            pctbox_logo.Name = "pctbox_logo";
            pctbox_logo.Size = new Size(211, 147);
            pctbox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pctbox_logo.TabIndex = 0;
            pctbox_logo.TabStop = false;
            // 
            // pnl_formulario_externo
            // 
            pnl_formulario_externo.AutoScroll = true;
            pnl_formulario_externo.BackColor = Color.White;
            pnl_formulario_externo.Controls.Add(pctbox_icone_espera);
            pnl_formulario_externo.Dock = DockStyle.Fill;
            pnl_formulario_externo.Location = new Point(211, 147);
            pnl_formulario_externo.Name = "pnl_formulario_externo";
            pnl_formulario_externo.Size = new Size(973, 637);
            pnl_formulario_externo.TabIndex = 1;
            // 
            // pctbox_icone_espera
            // 
            pctbox_icone_espera.Anchor = AnchorStyles.None;
            pctbox_icone_espera.BackColor = Color.Transparent;
            pctbox_icone_espera.Image = (Image)resources.GetObject("pctbox_icone_espera.Image");
            pctbox_icone_espera.Location = new Point(311, 168);
            pctbox_icone_espera.Name = "pctbox_icone_espera";
            pctbox_icone_espera.Size = new Size(329, 267);
            pctbox_icone_espera.SizeMode = PictureBoxSizeMode.Zoom;
            pctbox_icone_espera.TabIndex = 0;
            pctbox_icone_espera.TabStop = false;
            // 
            // pnl_titulo_formulario_externo
            // 
            pnl_titulo_formulario_externo.BackColor = Color.FromArgb(130, 69, 34);
            pnl_titulo_formulario_externo.Dock = DockStyle.Top;
            pnl_titulo_formulario_externo.Location = new Point(211, 0);
            pnl_titulo_formulario_externo.Name = "pnl_titulo_formulario_externo";
            pnl_titulo_formulario_externo.Size = new Size(973, 147);
            pnl_titulo_formulario_externo.TabIndex = 2;
            // 
            // form_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 784);
            ControlBox = false;
            Controls.Add(pnl_formulario_externo);
            Controls.Add(pnl_titulo_formulario_externo);
            Controls.Add(pnl_menu_lateral);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(1200, 800);
            Name = "form_inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disk Pizza Nostra Casa's Application";
            WindowState = FormWindowState.Maximized;
            Load += form_inicio_Load;
            pnl_menu_lateral.ResumeLayout(false);
            pnl_opcoes.ResumeLayout(false);
            pnl_submenu_vendas.ResumeLayout(false);
            pnl_submenu_produtos.ResumeLayout(false);
            pnl_submenu_funcionarios.ResumeLayout(false);
            pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctbox_logo).EndInit();
            pnl_formulario_externo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctbox_icone_espera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_menu_lateral;
        private Button btn_funcionarios;
        private Panel pnl_logo;
        private PictureBox pctbox_logo;
        private Button btn_sair;
        private Button btn_listagem_vendas;
        private Button btn_adicionar_venda;
        private Button btn_vendas;
        private Button btn_listagem_produtos;
        private Button btn_cadastro_produtos;
        private Button btn_produtos;
        private Button btn_listagem_funcionarios;
        private Button btn_cadastro_funcionarios;
        private Panel pnl_submenu_funcionarios;
        private Panel pnl_submenu_vendas;
        private Panel pnl_submenu_produtos;
        private Panel pnl_opcoes;
        private Panel pnl_formulario_externo;
        private Panel pnl_titulo_formulario_externo;
        private PictureBox pctbox_icone_espera;
        private Button btn_perfil;
    }
}