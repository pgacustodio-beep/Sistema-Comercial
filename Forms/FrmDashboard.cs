using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaComercialETEC.DAL;
using ScottPlot;

namespace SistemaComercialETEC
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

            formsPlot1.Plot.Title("Vendas por Dia");

            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn =
                    conexao.ObterConexao())
                {
                    conn.Open();

                    string sql =
                        "SELECT DATE(data_venda) AS data, " +
                        "SUM(total) AS total " +
                        "FROM vendas " +
                        "GROUP BY DATE(data_venda)";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    List<double> valores =
                        new List<double>();

                    List<string> datas =
                        new List<string>();

                    while (reader.Read())
                    {
                        valores.Add(
                            Convert.ToDouble(
                                reader["total"]));

                        datas.Add(
                            Convert.ToDateTime(
                                reader["data"])
                                .ToShortDateString());
                    }

                    double[] ys = valores.ToArray();

                    formsPlot1.Plot.Clear();

                    formsPlot1.Plot.Add.Bars(ys);

                    formsPlot1.Plot.Axes.Bottom.Label.Text =
                        "Datas";

                    formsPlot1.Plot.Axes.Left.Label.Text =
                        "Valor em R$";

                    formsPlot1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
