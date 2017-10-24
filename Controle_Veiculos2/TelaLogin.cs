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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // FECHAR APLICAÇÃO
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if((textBox1.Text == "adm") && (textBox2.Text == "1234")) // AREA PARA ACESSAR LOGIN E SENHA
            {
                FormPrincipal frmp = new FormPrincipal(); //CHAMAR O FORM PRINCIPAL
                frmp.Show();
                this.Visible = false;
          
            }
            else // SE NÃO DIGITAR CORRETAMENTE MESS DE ERRO
            {

            MessageBox.Show("Ops, ocorreu algum erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
           
            }
        }
    }
}
