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
    public partial class FormEmpresario : Form
    {
        public FormEmpresario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void empresariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBuggyDataSet);

        }

        private void FormEmpresario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBuggyDataSet.Empresarios' table. You can move, or remove it, as needed.
            this.empresariosTableAdapter.Fill(this.sistemaBuggyDataSet.Empresarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBuggyDataSet);
            MessageBox.Show("Seu arquivo está salvo! :)", "Arquivo Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SistemaBuggyDataSet SistemaBuggyDataSet { get; set; }
    }
}
