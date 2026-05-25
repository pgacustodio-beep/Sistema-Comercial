using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaComercialETEC.DAL;
using SistemaComercialETEC.Utils;

namespace SistemaComercialETEC
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.ObterConexao())
                {
                    conn.Open();

                    string sql =
                        "SELECT * FROM usuarios " +
                        "WHERE usuario=@usuario " +
                        "AND senha=@senha";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@usuario",
                        txtUsuario.Text);

                    cmd.Parameters.AddWithValue(
                        "@senha",
                    Criptografia.GerarHash(
                        txtSenha.Text));

                    MessageBox.Show(Criptografia.GerarHash("123"));

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Sessao.IdUsuario =
                            Convert.ToInt32(reader["id"]);

                        Sessao.Usuario =
                            reader["usuario"].ToString();

                        Sessao.Nivel =
                            reader["nivel"].ToString();

                        FrmPrincipal principal =
                            new FrmPrincipal();

                        principal.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Usuário ou senha inválidos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
