using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_Veiculos2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editorDeTextoWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarros frmcl = new FormCarros();

            frmcl.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void empresáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpresario frmcl = new FormEmpresario();

            frmcl.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frmcl = new FormCliente();

            frmcl.Show();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocacao frmcl = new FormLocacao();

            frmcl.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormLocacao frmcl = new FormLocacao();

            frmcl.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevolucao frmcl = new FormDevolucao();

            frmcl.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FormCliente frmcl = new FormCliente();

            frmcl.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormDevolucao frmcl = new FormDevolucao();

            frmcl.Show();
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema Desenvolvido por Sthefany Soares", "Sobre!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void blogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe");
        }

        private void blogToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "vidaprogramacao.blogspot.com");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
