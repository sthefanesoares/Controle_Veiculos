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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBuggyDataSet);

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBuggyDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sistemaBuggyDataSet.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBuggyDataSet);
            MessageBox.Show("Seu arquivo está salvo! :)", "Arquivo Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SistemaBuggyDataSet SistemaBuggyDataSet { get; set; }
    }
}
