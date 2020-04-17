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
    public partial class TelaLogin : Form
    {
        TelaInicial tela;

        public TelaLogin(TelaInicial telaInicial)
        {
            InitializeComponent();

            tela = telaInicial;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void Logar()
        {
            string usuario = tbUsuario.Text;
            string senha = tbSenha.Text;

            if (usuario != "" && senha != "")
            {
                //TelaPrincipal tela = new TelaPrincipal();
                //tela.Show();


                bool conectado = Conexao.login("usuarios", tbUsuario.Text, tbSenha.Text);

                if (conectado == true)
                {
                    tbUsuario.Clear();
                    tbSenha.Clear();
                    this.Hide();

                    TelaPrincipal tela = new TelaPrincipal(this);

                    tela.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Digite o usuário e a senha.");
            }
        }
    }
}
