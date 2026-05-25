namespace SistemaComercialETEC
{
    partial class FrmProdutos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblPreco = new Label();
            lblEstoque = new Label();
            btnSalvar = new Button();
            btnListar = new Button();
            dgvProdutos = new DataGridView();
            txtEstoque = new TextBox();
            txtPreco = new TextBox();
            txtNome = new TextBox();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(30, 36);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(30, 73);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(30, 111);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(49, 15);
            lblEstoque.TabIndex = 2;
            lblEstoque.Text = "Estoque";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(58, 218);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(58, 305);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(208, 189);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(520, 133);
            dgvProdutos.TabIndex = 5;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(106, 103);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(100, 23);
            txtEstoque.TabIndex = 6;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(106, 65);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(106, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 8;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(30, 146);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 9;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(106, 138);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(100, 23);
            txtPesquisar.TabIndex = 10;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(58, 189);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 11;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(58, 247);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(58, 276);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(txtNome);
            Controls.Add(txtPreco);
            Controls.Add(txtEstoque);
            Controls.Add(dgvProdutos);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(lblEstoque);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Name = "FrmProdutos";
            Text = "Cadastro de Produtos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblPreco;
        private Label lblEstoque;
        private Button btnSalvar;
        private Button btnListar;
        private DataGridView dgvProdutos;
        private TextBox txtEstoque;
        private TextBox txtPreco;
        private TextBox txtNome;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
    }
}
