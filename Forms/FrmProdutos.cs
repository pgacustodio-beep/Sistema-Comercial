using MySql.Data.MySqlClient;
using SistemaComercialETEC.DAL;
using System.Data;

namespace SistemaComercialETEC
{
    public partial class FrmProdutos : Form
    {
        private int idSelecionado = 0;
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql =
                        "INSERT INTO produtos(nome, preco, estoque) " +
                        "VALUES(@nome, @preco, @estoque)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@estoque", int.Parse(txtEstoque.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto salvo com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            {
                ListarProdutos();
            }

            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "SELECT * FROM produtos";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvProdutos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void ListarProdutos()
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql = "SELECT * FROM produtos";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvProdutos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();

            idSelecionado = 0;

            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql =
                        "UPDATE produtos SET " +
                        "nome=@nome, " +
                        "preco=@preco, " +
                        "estoque=@estoque " +
                        "WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@estoque", int.Parse(txtEstoque.Text));
                    cmd.Parameters.AddWithValue("@id", idSelecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto atualizado!");

                    ListarProdutos();

                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            ListarProdutos();

            dgvProdutos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProdutos.MultiSelect = false;

            dgvProdutos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvProdutos.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(linha.Cells["id"].Value);

                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtPreco.Text = linha.Cells["preco"].Value.ToString();
                txtEstoque.Text = linha.Cells["estoque"].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSelecionado == 0)
                {
                    MessageBox.Show("Selecione um produto.");
                    return;
                }

                DialogResult resultado =
                    MessageBox.Show(
                        "Deseja excluir este produto?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();

                    using (MySqlConnection conn = conexao.ObterConexao())
                    {
                        conn.Open();

                        string sql =
                            "DELETE FROM produtos WHERE id=@id";

                        MySqlCommand cmd =
                            new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@id", idSelecionado);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Produto excluído!");

                        ListarProdutos();

                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql =
                        "SELECT * FROM produtos " +
                        "WHERE nome LIKE @nome";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(sql, conn);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@nome",
                        "%" + txtPesquisar.Text + "%");

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvProdutos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
