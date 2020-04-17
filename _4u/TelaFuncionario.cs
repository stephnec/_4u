using Correios;
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
    public partial class TelaFuncionario : Form
    {
        TelaPrincipal tela;

        int tipoPessoa = 0;
        public TelaFuncionario(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();

            tela = telaPrincipal;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            AdicionarRegistro();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            tbNome.Clear();
            mtbDataNascimento.Clear();
            mtbTelefone.Clear();
            tbEmail.Clear();
            mtbCPF.Clear();
            mtbCNPJ.Clear();
            tbCEP.Clear();
            tbEstado.Clear();
            tbCidade.Clear();
            tbRua.Clear();
            tbNumResidencia.Clear();
            tbComplemento.Clear();
            cbCargo.Text = "Selecione um cargo";
            cbSetor.Text = "Selecione um setor";
            mtbDataAdmissao.Clear();
            tbDataDemissao.Clear();
        }

        private void AdicionarRegistro()
        {
            try
            {
                string nome = tbNome.Text;
                string dataNascimento = mtbDataNascimento.Text;
                string telefone = mtbTelefone.Text;
                string email = tbEmail.Text;
                string cpf = mtbCPF.Text;
                string cnpj = mtbCNPJ.Text;
                string cep = tbCEP.Text;
                string estado = tbEstado.Text;
                string cidade = tbCidade.Text;
                string rua = tbRua.Text;
                string numResidencia = tbNumResidencia.Text;
                string complemento = tbComplemento.Text;
                string cargo = cbCargo.Text;
                string setor = cbSetor.Text;
                string dataAdmissao = mtbDataAdmissao.Text;
                string dataDemissao = tbDataDemissao.Text;




                Dictionary<string, string> informacoes = new Dictionary<string, string>()
                {
                    {"nome", nome },
                    {"data_nascimento", dataNascimento },
                    {"telefone", telefone },
                    {"email", email },
                    {"tipo_funcionario", tipoPessoa.ToString()},
                    {"cpf", cpf},
                    {"cnpj", cnpj},
                    {"cep", cep},
                    {"estado", estado},
                    {"cidade", cidade},
                    {"rua", rua},
                    {"numero_residencia", numResidencia},
                    {"complemento", complemento},
                    {"cargo", cargo},
                    {"setor", setor},
                    {"data_admissao", dataAdmissao},
                    {"data_demissao", dataDemissao}

                };
                Conexao.AdicionarRegistro("funcionarios", informacoes);
                Limpar();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void rbPessoaTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPessoaFisica.Checked)
            {
                mtbCPF.Enabled = true;
                mtbCNPJ.Enabled = false;
                tipoPessoa = 0;
            }
            else if (rbPessoaJuridica.Checked)
            {
                mtbCPF.Enabled = false;
                mtbCNPJ.Enabled = true;
                tipoPessoa = 1;
            }
        }
        private void tbCEP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCEP.Text))
            {
                MessageBox.Show("O campo de CEP está vazio ou inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(tbCEP.Text);

                    if (retorno is null)
                    {
                        MessageBox.Show("CEP não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    tbEstado.Text = retorno.uf;
                    tbCidade.Text = retorno.cidade;
                    tbRua.Text = retorno.end;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("CEP inválido: " + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void TelaFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
