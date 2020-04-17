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
    public partial class TelaCadastro : Form
    {
        TelaInicial tela;

        public TelaCadastro(TelaInicial telaInicial)
        {
            InitializeComponent();

            tela = telaInicial;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = tbNome.Text;
            string email = tbEmail.Text;
            string senha = tbSenha.Text;
            string confirmaSenha = tbConfirmaSenha.Text;
            string codigoFuncionario = tbCodFuncionario.Text;

            if (confirmaSenha == senha)
            {
                if ((usuario != "") || (email != "") || (senha != "") || (confirmaSenha != "") || (codigoFuncionario != ""))
                {
                    Adicionar();

                    tela.Show();

                    this.Close();

                    tbNome.Clear();
                    tbEmail.Clear();
                    tbSenha.Clear();
                    tbConfirmaSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Digite os campos corretamente");
                }
            }
            else
            {
                MessageBox.Show("Digite sua senha corretamente.");
            }
        }


        private void Adicionar()
        {
            try
            {
                string usuario = tbNome.Text;
                string email = tbEmail.Text;
                string senha = tbSenha.Text;
                string codigoFuncionario = tbCodFuncionario.Text;

                Dictionary<string, string> informacoes = new Dictionary<string, string>()
                {
                    {"nome", usuario },
                    {"email", email },
                    {"senha", senha },
                    {"funcionario_id", codigoFuncionario }
                };
                Conexao.AdicionarRegistro("usuarios", informacoes);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }



        private void btVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void TelaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
           tela.Show();
        }
    }
}
