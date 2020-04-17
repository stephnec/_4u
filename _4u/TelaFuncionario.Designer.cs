namespace _4u
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbNumResidencia = new System.Windows.Forms.TextBox();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbNumResidencia = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbTipoFuncionario = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.lbDataAdmissao = new System.Windows.Forms.Label();
            this.lbDataDemissao = new System.Windows.Forms.Label();
            this.gbDadosEmpresa = new System.Windows.Forms.GroupBox();
            this.tbDataDemissao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDadosEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(750, 609);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(153, 32);
            this.btLimpar.TabIndex = 61;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(564, 609);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(153, 32);
            this.btCadastrar.TabIndex = 60;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbNumResidencia
            // 
            this.tbNumResidencia.Location = new System.Drawing.Point(541, 85);
            this.tbNumResidencia.Name = "tbNumResidencia";
            this.tbNumResidencia.Size = new System.Drawing.Size(100, 20);
            this.tbNumResidencia.TabIndex = 57;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(144, 132);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(187, 20);
            this.tbComplemento.TabIndex = 56;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(66, 85);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(265, 20);
            this.tbRua.TabIndex = 55;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(479, 26);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(162, 20);
            this.tbCidade.TabIndex = 54;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(295, 26);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(86, 20);
            this.tbEstado.TabIndex = 53;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(66, 26);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(133, 20);
            this.tbCEP.TabIndex = 52;
            this.tbCEP.Leave += new System.EventHandler(this.tbCEP_Leave);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaJuridica.Location = new System.Drawing.Point(284, 125);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(112, 19);
            this.rbPessoaJuridica.TabIndex = 50;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaTipo_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaFisica.Location = new System.Drawing.Point(175, 125);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(101, 19);
            this.rbPessoaFisica.TabIndex = 49;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaTipo_CheckedChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(356, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(284, 20);
            this.tbEmail.TabIndex = 48;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(74, 40);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(257, 20);
            this.tbNome.TabIndex = 46;
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
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCEP.Location = new System.Drawing.Point(14, 25);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(45, 20);
            this.lbCEP.TabIndex = 39;
            this.lbCEP.Text = "CEP:";
            // 
            // lbTipoFuncionario
            // 
            this.lbTipoFuncionario.AutoSize = true;
            this.lbTipoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoFuncionario.Location = new System.Drawing.Point(13, 123);
            this.lbTipoFuncionario.Name = "lbTipoFuncionario";
            this.lbTipoFuncionario.Size = new System.Drawing.Size(152, 20);
            this.lbTipoFuncionario.TabIndex = 37;
            this.lbTipoFuncionario.Text = "Tipo de Funcionário:";
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
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncionario.Location = new System.Drawing.Point(257, 20);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(125, 25);
            this.lbFuncionario.TabIndex = 32;
            this.lbFuncionario.Text = "Funcionário";
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Controls.Add(this.mtbDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.mtbCNPJ);
            this.gbDadosPessoais.Controls.Add(this.mtbCPF);
            this.gbDadosPessoais.Controls.Add(this.lbCNPJ);
            this.gbDadosPessoais.Controls.Add(this.lbCPF);
            this.gbDadosPessoais.Controls.Add(this.tbNome);
            this.gbDadosPessoais.Controls.Add(this.lbNome);
            this.gbDadosPessoais.Controls.Add(this.lbDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.lbTelefone);
            this.gbDadosPessoais.Controls.Add(this.lbEmail);
            this.gbDadosPessoais.Controls.Add(this.tbEmail);
            this.gbDadosPessoais.Controls.Add(this.rbPessoaJuridica);
            this.gbDadosPessoais.Controls.Add(this.lbTipoFuncionario);
            this.gbDadosPessoais.Controls.Add(this.rbPessoaFisica);
            this.gbDadosPessoais.Location = new System.Drawing.Point(251, 63);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(652, 173);
            this.gbDadosPessoais.TabIndex = 62;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(100, 78);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(176, 20);
            this.mtbTelefone.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "aaaa-mm-dd";
            // 
            // mtbDataNascimento
            // 
            this.mtbDataNascimento.Location = new System.Drawing.Point(511, 38);
            this.mtbDataNascimento.Mask = "0000-00-00";
            this.mtbDataNascimento.Name = "mtbDataNascimento";
            this.mtbDataNascimento.Size = new System.Drawing.Size(129, 20);
            this.mtbDataNascimento.TabIndex = 70;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Enabled = false;
            this.mtbCNPJ.Location = new System.Drawing.Point(480, 139);
            this.mtbCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(161, 20);
            this.mtbCNPJ.TabIndex = 67;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(479, 109);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(161, 20);
            this.mtbCPF.TabIndex = 66;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNPJ.Location = new System.Drawing.Point(410, 140);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(46, 16);
            this.lbCNPJ.TabIndex = 64;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(410, 113);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(37, 16);
            this.lbCPF.TabIndex = 62;
            this.lbCPF.Text = "CPF:";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.lbCEP);
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
            this.gbEndereco.Location = new System.Drawing.Point(251, 260);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(652, 175);
            this.gbEndereco.TabIndex = 63;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.Location = new System.Drawing.Point(23, 37);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(56, 20);
            this.lbCargo.TabIndex = 58;
            this.lbCargo.Text = "Cargo:";
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.Location = new System.Drawing.Point(358, 40);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(52, 20);
            this.lbSetor.TabIndex = 60;
            this.lbSetor.Text = "Setor:";
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Desenvolvedor de Softwares",
            "Designer Gráfico",
            "Editor de Vídeos",
            "Estagiário",
            "Recepcionista",
            "Programador",
            "WebDesigner",
            ""});
            this.cbCargo.Location = new System.Drawing.Point(85, 39);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(224, 21);
            this.cbCargo.TabIndex = 61;
            this.cbCargo.Text = "Selecione um cargo";
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Items.AddRange(new object[] {
            "Atendimento",
            "Operacional",
            "Desenvolvimento"});
            this.cbSetor.Location = new System.Drawing.Point(416, 42);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(224, 21);
            this.cbSetor.TabIndex = 62;
            this.cbSetor.Text = "Selecione um setor";
            // 
            // lbDataAdmissao
            // 
            this.lbDataAdmissao.AutoSize = true;
            this.lbDataAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAdmissao.Location = new System.Drawing.Point(23, 82);
            this.lbDataAdmissao.Name = "lbDataAdmissao";
            this.lbDataAdmissao.Size = new System.Drawing.Size(118, 20);
            this.lbDataAdmissao.TabIndex = 63;
            this.lbDataAdmissao.Text = "Data Admissão";
            // 
            // lbDataDemissao
            // 
            this.lbDataDemissao.AutoSize = true;
            this.lbDataDemissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDemissao.Location = new System.Drawing.Point(347, 82);
            this.lbDataDemissao.Name = "lbDataDemissao";
            this.lbDataDemissao.Size = new System.Drawing.Size(119, 20);
            this.lbDataDemissao.TabIndex = 64;
            this.lbDataDemissao.Text = "Data Demissão";
            // 
            // gbDadosEmpresa
            // 
            this.gbDadosEmpresa.Controls.Add(this.tbDataDemissao);
            this.gbDadosEmpresa.Controls.Add(this.label3);
            this.gbDadosEmpresa.Controls.Add(this.label2);
            this.gbDadosEmpresa.Controls.Add(this.mtbDataAdmissao);
            this.gbDadosEmpresa.Controls.Add(this.lbDataDemissao);
            this.gbDadosEmpresa.Controls.Add(this.lbDataAdmissao);
            this.gbDadosEmpresa.Controls.Add(this.cbSetor);
            this.gbDadosEmpresa.Controls.Add(this.cbCargo);
            this.gbDadosEmpresa.Controls.Add(this.lbSetor);
            this.gbDadosEmpresa.Controls.Add(this.lbCargo);
            this.gbDadosEmpresa.Location = new System.Drawing.Point(251, 468);
            this.gbDadosEmpresa.Name = "gbDadosEmpresa";
            this.gbDadosEmpresa.Size = new System.Drawing.Size(652, 121);
            this.gbDadosEmpresa.TabIndex = 64;
            this.gbDadosEmpresa.TabStop = false;
            this.gbDadosEmpresa.Text = "Dados Empresa";
            // 
            // tbDataDemissao
            // 
            this.tbDataDemissao.Location = new System.Drawing.Point(480, 84);
            this.tbDataDemissao.Name = "tbDataDemissao";
            this.tbDataDemissao.Size = new System.Drawing.Size(152, 20);
            this.tbDataDemissao.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "aaaa-mm-dd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "aaaa-mm-dd";
            // 
            // mtbDataAdmissao
            // 
            this.mtbDataAdmissao.Location = new System.Drawing.Point(157, 84);
            this.mtbDataAdmissao.Mask = "0000-00-00";
            this.mtbDataAdmissao.Name = "mtbDataAdmissao";
            this.mtbDataAdmissao.Size = new System.Drawing.Size(152, 20);
            this.mtbDataAdmissao.TabIndex = 72;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbDadosEmpresa);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.lbFuncionario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "we do it 4Ü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaFuncionario_FormClosed);
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDadosEmpresa.ResumeLayout(false);
            this.gbDadosEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbNumResidencia;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbNumResidencia;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbTipoFuncionario;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.Label lbDataAdmissao;
        private System.Windows.Forms.Label lbDataDemissao;
        private System.Windows.Forms.GroupBox gbDadosEmpresa;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbDataAdmissao;
        private System.Windows.Forms.TextBox tbDataDemissao;
    }
}