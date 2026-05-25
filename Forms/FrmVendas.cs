using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaComercialETEC.DAL;
using System.Data;

namespace SistemaComercialETEC
{
    public partial class FrmVendas : Form
    {
        private decimal totalVenda = 0;
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            CarregarProdutos();

            dgvCarrinho.Columns.Add("Produto", "Produto");
            dgvCarrinho.Columns.Add("Qtd", "Qtd");
            dgvCarrinho.Columns.Add("Preco", "Preço");
            dgvCarrinho.Columns.Add("Subtotal", "Subtotal");

            dgvCarrinho.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarProdutos()
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn =
                    conexao.ObterConexao())
                {
                    conn.Open();

                    string sql =
                        "SELECT id, nome FROM produtos";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    cbProdutos.DataSource = dt;

                    cbProdutos.DisplayMember = "nome";
                    cbProdutos.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int produtoId =
                    Convert.ToInt32(cbProdutos.SelectedValue);

                int quantidade =
                    int.Parse(txtQuantidade.Text);

                Conexao conexao = new Conexao();

                using (MySqlConnection conn =
                    conexao.ObterConexao())
                {
                    conn.Open();

                    string sql =
                        "SELECT nome, preco FROM produtos " +
                        "WHERE id=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", produtoId);

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nome =
                            reader["nome"].ToString();

                        decimal preco =
                            Convert.ToDecimal(reader["preco"]);

                        decimal subtotal =
                            preco * quantidade;

                        dgvCarrinho.Rows.Add(
                            nome,
                            quantidade,
                            preco,
                            subtotal);

                        totalVenda += subtotal;

                        txtTotal.Text =
                            totalVenda.ToString("F2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn =
                    conexao.ObterConexao())
                {
                    conn.Open();

                    MySqlTransaction transacao =
                        conn.BeginTransaction();

                    try
                    {
                        string sqlVenda =
                            "INSERT INTO vendas(data_venda, total) " +
                            "VALUES(@data, @total)";

                        MySqlCommand cmdVenda =
                            new MySqlCommand(
                                sqlVenda,
                                conn,
                                transacao);

                        cmdVenda.Parameters.AddWithValue(
                            "@data",
                            DateTime.Now);

                        cmdVenda.Parameters.AddWithValue(
                            "@total",
                            totalVenda);

                        cmdVenda.ExecuteNonQuery();

                        int vendaId =
                            Convert.ToInt32(cmdVenda.LastInsertedId);

                        foreach (DataGridViewRow row in dgvCarrinho.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                string nomeProduto =
                                    row.Cells[0].Value.ToString();

                                int qtd =
                                    Convert.ToInt32(row.Cells[1].Value);

                                decimal preco =
                                    Convert.ToDecimal(row.Cells[2].Value);

                                decimal subtotal =
                                    Convert.ToDecimal(row.Cells[3].Value);

                                string sqlProduto =
                                    "SELECT id FROM produtos " +
                                    "WHERE nome=@nome";

                                MySqlCommand cmdProduto =
                                    new MySqlCommand(
                                        sqlProduto,
                                        conn,
                                        transacao);

                                cmdProduto.Parameters.AddWithValue(
                                    "@nome",
                                    nomeProduto);

                                int produtoId =
                                    Convert.ToInt32(
                                        cmdProduto.ExecuteScalar());

                                string sqlItem =
                                    "INSERT INTO itens_venda " +
                                    "(venda_id, produto_id, quantidade, preco, subtotal) " +
                                    "VALUES(@venda, @produto, @qtd, @preco, @subtotal)";

                                MySqlCommand cmdItem =
                                    new MySqlCommand(
                                        sqlItem,
                                        conn,
                                        transacao);

                                cmdItem.Parameters.AddWithValue("@venda", vendaId);
                                cmdItem.Parameters.AddWithValue("@produto", produtoId);
                                cmdItem.Parameters.AddWithValue("@qtd", qtd);
                                cmdItem.Parameters.AddWithValue("@preco", preco);
                                cmdItem.Parameters.AddWithValue("@subtotal", subtotal);

                                cmdItem.ExecuteNonQuery();

                                string sqlEstoque =
                                    "UPDATE produtos SET estoque = estoque - @qtd " +
                                    "WHERE id=@id";

                                MySqlCommand cmdEstoque =
                                    new MySqlCommand(
                                        sqlEstoque,
                                        conn,
                                        transacao);

                                cmdEstoque.Parameters.AddWithValue("@qtd", qtd);
                                cmdEstoque.Parameters.AddWithValue("@id", produtoId);

                                cmdEstoque.ExecuteNonQuery();
                            }
                        }

                        transacao.Commit();

                        MessageBox.Show(
                            "Venda finalizada com sucesso!");

                        dgvCarrinho.Rows.Clear();

                        txtTotal.Clear();

                        totalVenda = 0;
                    }
                    catch (Exception ex)
                    {
                        transacao.Rollback();

                        MessageBox.Show(
                            "Erro ao finalizar venda: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
