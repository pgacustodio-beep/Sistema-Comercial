namespace SistemaComercialETEC
{
    partial class FrmVendas
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
            cbProdutos = new ComboBox();
            txtQuantidade = new TextBox();
            txtTotal = new TextBox();
            btnAdicionar = new Button();
            btnFinalizarVenda = new Button();
            dgvCarrinho = new DataGridView();
            lblProduto = new Label();
            lblQuantidade = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // cbProdutos
            // 
            cbProdutos.FormattingEnabled = true;
            cbProdutos.Location = new Point(145, 28);
            cbProdutos.Name = "cbProdutos";
            cbProdutos.Size = new Size(121, 23);
            cbProdutos.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(145, 63);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(109, 267);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(61, 110);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(114, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar Item";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.Location = new Point(82, 310);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(125, 23);
            btnFinalizarVenda.TabIndex = 4;
            btnFinalizarVenda.Text = "Finalizar Venda";
            btnFinalizarVenda.UseVisualStyleBackColor = true;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(61, 155);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.Size = new Size(537, 85);
            dgvCarrinho.TabIndex = 5;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(61, 31);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 6;
            lblProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(61, 63);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(61, 270);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "TOTAL:";
            lblTotal.Click += lblTotal_Click;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblQuantidade);
            Controls.Add(lblProduto);
            Controls.Add(dgvCarrinho);
            Controls.Add(btnFinalizarVenda);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTotal);
            Controls.Add(txtQuantidade);
            Controls.Add(cbProdutos);
            Name = "FrmVendas";
            Text = "Caixa / PDV";
            Load += FrmVendas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProdutos;
        private TextBox txtQuantidade;
        private TextBox txtTotal;
        private Button btnAdicionar;
        private Button btnFinalizarVenda;
        private DataGridView dgvCarrinho;
        private Label lblProduto;
        private Label lblQuantidade;
        private Label lblTotal;
    }
}