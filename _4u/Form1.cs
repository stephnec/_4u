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
    public partial class TelaInicial : Form
    {

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            TelaLogin tela = new TelaLogin(this);

            tela.Show();

            this.Hide();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro(this);

            tela.Show();

            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "Deseja realmente fechar a aplicação?",
               "Confirmar Saída",
               MessageBoxButtons.YesNo
           );

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
