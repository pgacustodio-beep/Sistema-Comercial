using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaComercialETEC.Utils;

namespace SistemaComercialETEC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frm = new FrmProdutos();

            frm.MdiParent = this;

            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Sessao.Usuario + " | Nível: " + Sessao.Nivel;

            ConfigurarPermissoes();
        }

        private void ConfigurarPermissoes()
        {
            if (Sessao.Nivel == "FUNCIONARIO")
            {
                cadastroToolStripMenuItem.Visible = false;
            }
        }

        private void abrirPDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas frm = new FrmVendas();

            frm.MdiParent = this;

            frm.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();

            login.Show();

            this.Close();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();

            frm.MdiParent = this;

            frm.Show();
        }
    }
}
