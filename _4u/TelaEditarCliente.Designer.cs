namespace _4u
{
    partial class TelaEditarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarCliente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtClientes = new System.Windows.Forms.DataGridView();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbNumResidencia = new System.Windows.Forms.Label();
            this.tbNumResidencia = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.tbDataNascimento = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.lbTipoCliente = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAtualizarTabela = new System.Windows.Forms.Button();
            this.lbCliente = new System.Windows.Forms.Label();
            this.gbServicos = new System.Windows.Forms.GroupBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.lbServico = new System.Windows.Forms.Label();
            this.btExcluirItemSelecionado = new System.Windows.Forms.Button();
            this.btEditarItemSelecionado = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            this.gbEndereco.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.gbServicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // dtClientes
            // 
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.Location = new System.Drawing.Point(711, 56);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.Size = new System.Drawing.Size(282, 565);
            this.dtClientes.TabIndex = 74;
            this.dtClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtClientes_CellContentClick);
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.label8);
            this.gbEndereco.Controls.Add(this.lbRua);
            this.gbEndereco.Controls.Add(this.lbNumResidencia);
            this.gbEndereco.Controls.Add(this.tbNumResidencia);
            this.gbEndereco.Controls.Add(this.lbEstado);
            this.gbEndereco.Controls.Add(this.tbComplemento);
            this.gbEndereco.Controls.Add(this.lbCidade);
            this.gbEndereco.Controls.Add(this.tbRua);
            this.gbEndereco.Controls.Add(this.lbComplemento);
            this.gbEndereco.Controls.Add(this.tbCidade);
            this.gbEndereco.Controls.Add(this.tbCEP);
            this.gbEndereco.Controls.Add(this.tbEstado);
            this.gbEndereco.Location = new System.Drawing.Point(27, 291);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(652, 175);
            this.gbEndereco.TabIndex = 79;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "CEP:";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRua.Location = new System.Drawing.Point(13, 84);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(43, 20);
            this.lbRua.TabIndex = 40;
            this.lbRua.Text = "Rua:";
            // 
            // lbNumResidencia
            // 
            this.lbNumResidencia.AutoSize = true;
            this.lbNumResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumResidencia.Location = new System.Drawing.Point(361, 83);
            this.lbNumResidencia.Name = "lbNumResidencia";
            this.lbNumResidencia.Size = new System.Drawing.Size(174, 20);
            this.lbNumResidencia.TabIndex = 41;
            this.lbNumResidencia.Text = "Número da Residência:";
            // 
            // tbNumResidencia
            // 
            this.tbNumResidencia.Location = new System.Drawing.Point(541, 85);
            this.tbNumResidencia.Name = "tbNumResidencia";
            this.tbNumResidencia.Size = new System.Drawing.Size(100, 20);
            this.tbNumResidencia.TabIndex = 57;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(229, 25);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(64, 20);
            this.lbEstado.TabIndex = 42;
            this.lbEstado.Text = "Estado:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(144, 132);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(187, 20);
            this.tbComplemento.TabIndex = 56;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(412, 25);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(63, 20);
            this.lbCidade.TabIndex = 43;
            this.lbCidade.Text = "Cidade:";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(66, 85);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(265, 20);
            this.tbRua.TabIndex = 55;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.Location = new System.Drawing.Point(14, 132);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(112, 20);
            this.lbComplemento.TabIndex = 44;
            this.lbComplemento.Text = "Complemento:";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(479, 26);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(162, 20);
            this.tbCidade.TabIndex = 54;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(66, 26);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(133, 20);
            this.tbCEP.TabIndex = 52;
            this.tbCEP.Leave += new System.EventHandler(this.tbCEP_Leave);
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(295, 26);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(86, 20);
            this.tbEstado.TabIndex = 53;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gbDadosPessoais.Controls.Add(this.mtbCNPJ);
            this.gbDadosPessoais.Controls.Add(this.mtbCPF);
            this.gbDadosPessoais.Controls.Add(this.lbCNPJ);
            this.gbDadosPessoais.Controls.Add(this.tbNome);
            this.gbDadosPessoais.Controls.Add(this.lbNome);
            this.gbDadosPessoais.Controls.Add(this.lbDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.tbDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.lbTelefone);
            this.gbDadosPessoais.Controls.Add(this.lbEmail);
            this.gbDadosPessoais.Controls.Add(this.tbEmail);
            this.gbDadosPessoais.Controls.Add(this.rbPessoaJuridica);
            this.gbDadosPessoais.Controls.Add(this.lbTipoCliente);
            this.gbDadosPessoais.Controls.Add(this.lbCPF);
            this.gbDadosPessoais.Controls.Add(this.rbPessoaFisica);
            this.gbDadosPessoais.Location = new System.Drawing.Point(27, 94);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(652, 173);
            this.gbDadosPessoais.TabIndex = 78;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(97, 78);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(176, 20);
            this.mtbTelefone.TabIndex = 79;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Enabled = false;
            this.mtbCNPJ.Location = new System.Drawing.Point(479, 140);
            this.mtbCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(161, 20);
            this.mtbCNPJ.TabIndex = 75;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(478, 110);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(161, 20);
            this.mtbCPF.TabIndex = 74;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNPJ.Location = new System.Drawing.Point(410, 141);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(46, 16);
            this.lbCNPJ.TabIndex = 60;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(74, 40);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(257, 20);
            this.tbNome.TabIndex = 46;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(13, 38);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 33;
            this.lbNome.Text = "Nome:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(347, 38);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(158, 20);
            this.lbDataNascimento.TabIndex = 34;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // tbDataNascimento
            // 
            this.tbDataNascimento.Location = new System.Drawing.Point(512, 38);
            this.tbDataNascimento.Name = "tbDataNascimento";
            this.tbDataNascimento.Size = new System.Drawing.Size(128, 20);
            this.tbDataNascimento.TabIndex = 59;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(13, 78);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(75, 20);
            this.lbTelefone.TabIndex = 35;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(296, 78);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 20);
            this.lbEmail.TabIndex = 36;
            this.lbEmail.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(356, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(284, 20);
            this.tbEmail.TabIndex = 48;
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaJuridica.Location = new System.Drawing.Point(265, 126);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(112, 19);
            this.rbPessoaJuridica.TabIndex = 50;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaTipo_CheckedChanged);
            // 
            // lbTipoCliente
            // 
            this.lbTipoCliente.AutoSize = true;
            this.lbTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoCliente.Location = new System.Drawing.Point(12, 124);
            this.lbTipoCliente.Name = "lbTipoCliente";
            this.lbTipoCliente.Size = new System.Drawing.Size(118, 20);
            this.lbTipoCliente.TabIndex = 37;
            this.lbTipoCliente.Text = "Tipo de Cliente:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(410, 114);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(37, 16);
            this.lbCPF.TabIndex = 38;
            this.lbCPF.Text = "CPF:";
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaFisica.Location = new System.Drawing.Point(139, 126);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(101, 19);
            this.rbPessoaFisica.TabIndex = 49;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaTipo_CheckedChanged);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(497, 500);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(171, 30);
            this.btLimpar.TabIndex = 77;
            this.btLimpar.Text = "Limpar Dados";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAtualizarTabela
            // 
            this.btAtualizarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarTabela.Location = new System.Drawing.Point(27, 571);
            this.btAtualizarTabela.Name = "btAtualizarTabela";
            this.btAtualizarTabela.Size = new System.Drawing.Size(171, 29);
            this.btAtualizarTabela.TabIndex = 76;
            this.btAtualizarTabela.Text = "Atualizar Tabela";
            this.btAtualizarTabela.UseVisualStyleBackColor = true;
            this.btAtualizarTabela.Click += new System.EventHandler(this.btAtualizarTabela_Click);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(22, 41);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(79, 25);
            this.lbCliente.TabIndex = 75;
            this.lbCliente.Text = "Cliente";
            // 
            // gbServicos
            // 
            this.gbServicos.Controls.Add(this.cbServico);
            this.gbServicos.Controls.Add(this.lbServico);
            this.gbServicos.Location = new System.Drawing.Point(27, 473);
            this.gbServicos.Name = "gbServicos";
            this.gbServicos.Size = new System.Drawing.Size(404, 70);
            this.gbServicos.TabIndex = 80;
            this.gbServicos.TabStop = false;
            this.gbServicos.Text = "Serviços";
            // 
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Items.AddRange(new object[] {
            "Banco de Dados",
            "Desenvolvimento Mobile",
            "Design Gráfico",
            "Edição de Vídeo",
            "Games",
            "WebDesign"});
            this.cbServico.Location = new System.Drawing.Point(97, 30);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(284, 21);
            this.cbServico.TabIndex = 59;
            this.cbServico.Text = "Selecione o serviço desejado";
            // 
            // lbServico
            // 
            this.lbServico.AutoSize = true;
            this.lbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServico.Location = new System.Drawing.Point(14, 31);
            this.lbServico.Name = "lbServico";
            this.lbServico.Size = new System.Drawing.Size(65, 20);
            this.lbServico.TabIndex = 58;
            this.lbServico.Text = "Serviço:";
            // 
            // btExcluirItemSelecionado
            // 
            this.btExcluirItemSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirItemSelecionado.Location = new System.Drawing.Point(496, 571);
            this.btExcluirItemSelecionado.Name = "btExcluirItemSelecionado";
            this.btExcluirItemSelecionado.Size = new System.Drawing.Size(171, 29);
            this.btExcluirItemSelecionado.TabIndex = 81;
            this.btExcluirItemSelecionado.Text = "Excluir item";
            this.btExcluirItemSelecionado.UseVisualStyleBackColor = true;
            this.btExcluirItemSelecionado.Click += new System.EventHandler(this.btExcluirItemSelecionado_Click);
            // 
            // btEditarItemSelecionado
            // 
            this.btEditarItemSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarItemSelecionado.Location = new System.Drawing.Point(260, 571);
            this.btEditarItemSelecionado.Name = "btEditarItemSelecionado";
            this.btEditarItemSelecionado.Size = new System.Drawing.Size(171, 29);
            this.btEditarItemSelecionado.TabIndex = 82;
            this.btEditarItemSelecionado.Text = "Editar Item";
            this.btEditarItemSelecionado.UseVisualStyleBackColor = true;
            this.btEditarItemSelecionado.Click += new System.EventHandler(this.btEditarItemSelecionado_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(708, 624);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(286, 26);
            this.lbInfo.TabIndex = 83;
            this.lbInfo.Text = "dê dois clicks na dt para editar o campo desejado\r\n(atenção no campo de datas)";
            // 
            // TelaEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 658);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btEditarItemSelecionado);
            this.Controls.Add(this.btExcluirItemSelecionado);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btAtualizarTabela);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.gbServicos);
            this.Controls.Add(this.dtClientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "we do it 4Ü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaEditarCliente_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbServicos.ResumeLayout(false);
            this.gbServicos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbNumResidencia;
        private System.Windows.Forms.TextBox tbNumResidencia;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox tbDataNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.Label lbTipoCliente;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAtualizarTabela;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.GroupBox gbServicos;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.Button btExcluirItemSelecionado;
        private System.Windows.Forms.Button btEditarItemSelecionado;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
    }
}