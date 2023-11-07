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
            SuspendLayout();
            // 
            // form_listagem_vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            MinimumSize = new Size(800, 500);
            Name = "form_listagem_vendas";
            Text = "Listagem de Vendas";
            Load += form_listagem_vendas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_pesquisar_produtos;
        private TextBox txt_pesquisar_produtos;
        private Label lbl_pesquisar_produtos;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}