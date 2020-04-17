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
    public partial class TelaEditarFuncionario : Form
    {
        TelaPrincipal tela;

        int tipoPessoa = 0;

        public TelaEditarFuncionario(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();

            tela = telaPrincipal;

            AtualizarTabela();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btAtualizarTabela_Click(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btExcluirItemSelecionado_Click(object sender, EventArgs e)
        {
            ExcluirItem();
        }

        private void btEditarItemSelecionado_Click(object sender, EventArgs e)
        {
            EditarItem();
        }

        private void AtualizarTabela()
        {
            Conexao.BuscarRegistrosAtivos("funcionarios", dtFuncionarios);

        }

        private void ExcluirItem()
        {
            int id = PegarId();
            Conexao.RemoverRegistro("funcionarios", id);
            AtualizarTabela();
        }

        private int PegarId()
        {
            int id = 0;

            DataGridViewRow linha = dtFuncionarios.CurrentRow;

            if (linha != null)
            {
                id = (int)linha.Cells[0].Value;
            }

            return id;
        }


        private void EditarItem()
        {
            try
            {
                string nome = tbNome.Text;
                string dataNascimento = tbDataNascimento.Text;
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
                string dataAdmissao = tbDataAdmissao.Text;
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

                Conexao.EditarRegistro("funcionarios", PegarId(), informacoes);
                Limpar();
                AtualizarTabela();
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

        private void Limpar()
        {
            tbNome.Clear();
            tbDataNascimento.Clear();
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
            tbDataAdmissao.Clear();
            tbDataDemissao.Clear();
        }

        private void dtFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtFuncionarios.Rows[e.RowIndex];

                tbCEP.Text = row.Cells["cep"].Value.ToString();
                tbCidade.Text = row.Cells["cidade"].Value.ToString();
                mtbCNPJ.Text = row.Cells["cnpj"].Value.ToString();
                tbComplemento.Text = row.Cells["complemento"].Value.ToString();
                mtbCPF.Text = row.Cells["cpf"].Value.ToString();
                tbDataAdmissao.Text = row.Cells["data_admissao"].Value.ToString();
                tbDataDemissao.Text = row.Cells["data_demissao"].Value.ToString();
                tbDataNascimento.Text = row.Cells["data_nascimento"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
                tbEstado.Text = row.Cells["estado"].Value.ToString();
                tbNome.Text = row.Cells["nome"].Value.ToString();
                tbNumResidencia.Text = row.Cells["numero_residencia"].Value.ToString();
                tbRua.Text = row.Cells["rua"].Value.ToString();
                mtbTelefone.Text = row.Cells["telefone"].Value.ToString();

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

        private void TelaEditarFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
