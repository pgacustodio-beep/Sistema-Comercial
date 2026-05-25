namespace SistemaComercialETEC
{
    partial class FrmDashboard
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
            lblTotalProdutos = new Label();
            lblEstoque = new Label();
            lblVendasHoje = new Label();
            lblMaisVendido = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // lblTotalProdutos
            // 
            lblTotalProdutos.AutoSize = true;
            lblTotalProdutos.Location = new Point(50, 66);
            lblTotalProdutos.Name = "lblTotalProdutos";
            lblTotalProdutos.Size = new Size(83, 15);
            lblTotalProdutos.TabIndex = 0;
            lblTotalProdutos.Text = "Total Produtos";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(50, 108);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(49, 15);
            lblEstoque.TabIndex = 1;
            lblEstoque.Text = "Estoque";
            // 
            // lblVendasHoje
            // 
            lblVendasHoje.AutoSize = true;
            lblVendasHoje.Location = new Point(50, 151);
            lblVendasHoje.Name = "lblVendasHoje";
            lblVendasHoje.Size = new Size(72, 15);
            lblVendasHoje.TabIndex = 2;
            lblVendasHoje.Text = "Vendas Hoje";
            // 
            // lblMaisVendido
            // 
            lblMaisVendido.AutoSize = true;
            lblMaisVendido.Location = new Point(50, 195);
            lblMaisVendido.Name = "lblMaisVendido";
            lblMaisVendido.Size = new Size(78, 15);
            lblMaisVendido.TabIndex = 3;
            lblMaisVendido.Text = "Mais Vendido";
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(800, 450);
            formsPlot1.TabIndex = 5;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlot1);
            Controls.Add(lblMaisVendido);
            Controls.Add(lblVendasHoje);
            Controls.Add(lblEstoque);
            Controls.Add(lblTotalProdutos);
            Name = "FrmDashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += FrmDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalProdutos;
        private Label lblEstoque;
        private Label lblVendasHoje;
        private Label lblMaisVendido;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}