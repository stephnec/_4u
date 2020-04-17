namespace _4u
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.lb = new System.Windows.Forms.Label();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.btCliente = new System.Windows.Forms.Button();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btEditarFuncionario = new System.Windows.Forms.Button();
            this.btEditarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(31, 217);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(153, 20);
            this.lb.TabIndex = 1;
            this.lb.Text = "Cadastre um Cliente";
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncionario.Location = new System.Drawing.Point(226, 217);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(187, 20);
            this.lbFuncionario.TabIndex = 3;
            this.lbFuncionario.Text = "Cadastre um Funcionário";
            // 
            // btCliente
            // 
            this.btCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCliente.BackgroundImage")));
            this.btCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCliente.Location = new System.Drawing.Point(42, 59);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(137, 142);
            this.btCliente.TabIndex = 2;
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFuncionario.BackgroundImage")));
            this.btFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFuncionario.Location = new System.Drawing.Point(251, 59);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(137, 142);
            this.btFuncionario.TabIndex = 6;
            this.btFuncionario.UseVisualStyleBackColor = true;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btEditarFuncionario
            // 
            this.btEditarFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarFuncionario.BackgroundImage")));
            this.btEditarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditarFuncionario.Location = new System.Drawing.Point(665, 59);
            this.btEditarFuncionario.Name = "btEditarFuncionario";
            this.btEditarFuncionario.Size = new System.Drawing.Size(137, 142);
            this.btEditarFuncionario.TabIndex = 13;
            this.btEditarFuncionario.UseVisualStyleBackColor = true;
            this.btEditarFuncionario.Click += new System.EventHandler(this.btEditarFuncionario_Click);
            // 
            // btEditarCliente
            // 
            this.btEditarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarCliente.BackgroundImage")));
            this.btEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditarCliente.Location = new System.Drawing.Point(455, 59);
            this.btEditarCliente.Name = "btEditarCliente";
            this.btEditarCliente.Size = new System.Drawing.Size(137, 142);
            this.btEditarCliente.TabIndex = 10;
            this.btEditarCliente.UseVisualStyleBackColor = true;
            this.btEditarCliente.Click += new System.EventHandler(this.btEditarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Editar o Registro \r\nde um Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Editar o Registro \r\nde um Funcionário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditarFuncionario);
            this.Controls.Add(this.btEditarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btFuncionario);
            this.Controls.Add(this.lbFuncionario);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "we do it 4Ü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btEditarFuncionario;
        private System.Windows.Forms.Button btEditarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}