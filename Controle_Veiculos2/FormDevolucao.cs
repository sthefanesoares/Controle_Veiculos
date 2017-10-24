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
    public partial class FormDevolucao : Form
    {
        public FormDevolucao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void locacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBuggyDataSet);

        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBuggyDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBuggyDataSet.Locacao);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBuggyDataSet);
            MessageBox.Show("Seu arquivo está salvo! :)", "Arquivo Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
