using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4u
{
    public partial class TelaPrincipal : Form
    {
        TelaLogin tela;
       
        public TelaPrincipal(TelaLogin telaLogin)
        {
            InitializeComponent();

            tela = telaLogin;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            TelaCliente tela = new TelaCliente(this);

            tela.Show();

            this.Hide();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            TelaFuncionario tela = new TelaFuncionario(this);

            tela.Show();

            this.Hide();
        }

        private void btEditarCliente_Click(object sender, EventArgs e)
        {
            TelaEditarCliente tela = new TelaEditarCliente(this);

            tela.Show();

            this.Hide();
        }

        private void btEditarFuncionario_Click(object sender, EventArgs e)
        {
            TelaEditarFuncionario tela = new TelaEditarFuncionario(this);

            tela.Show();

            this.Hide();
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente sair da aplicação?",
                "Confirmar Saída",
                MessageBoxButtons.YesNo
            );

            if (resultado == DialogResult.Yes)
            {
                tela.Show();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
