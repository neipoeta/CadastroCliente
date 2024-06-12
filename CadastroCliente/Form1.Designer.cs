namespace CadastroCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRegistro = new System.Windows.Forms.MaskedTextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.radioButtonPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.radioButtonPessoaFisica = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.Label();
            this.Ano = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cllienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(25, 51);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(913, 121);
            this.listBoxClientes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBox1.Controls.Add(this.maskedTextBoxRegistro);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.radioButtonPessoaJuridica);
            this.groupBox1.Controls.Add(this.radioButtonPessoaFisica);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Registro);
            this.groupBox1.Controls.Add(this.Ano);
            this.groupBox1.Controls.Add(this.Telefone);
            this.groupBox1.Controls.Add(this.Endereco);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(25, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 225);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(111, 165);
            this.maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(195, 23);
            this.maskedTextBoxTelefone.TabIndex = 18;
            // 
            // maskedTextBoxRegistro
            // 
            this.maskedTextBoxRegistro.Location = new System.Drawing.Point(421, 165);
            this.maskedTextBoxRegistro.Name = "maskedTextBoxRegistro";
            this.maskedTextBoxRegistro.Size = new System.Drawing.Size(156, 23);
            this.maskedTextBoxRegistro.TabIndex = 15;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExcluir.Location = new System.Drawing.Point(792, 182);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 14;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Visible = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSalvar.Location = new System.Drawing.Point(701, 182);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // radioButtonPessoaJuridica
            // 
            this.radioButtonPessoaJuridica.AutoSize = true;
            this.radioButtonPessoaJuridica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonPessoaJuridica.Location = new System.Drawing.Point(728, 103);
            this.radioButtonPessoaJuridica.Name = "radioButtonPessoaJuridica";
            this.radioButtonPessoaJuridica.Size = new System.Drawing.Size(126, 21);
            this.radioButtonPessoaJuridica.TabIndex = 12;
            this.radioButtonPessoaJuridica.Text = "Pessoa Juridica";
            this.radioButtonPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // radioButtonPessoaFisica
            // 
            this.radioButtonPessoaFisica.AutoSize = true;
            this.radioButtonPessoaFisica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonPessoaFisica.Location = new System.Drawing.Point(728, 57);
            this.radioButtonPessoaFisica.Name = "radioButtonPessoaFisica";
            this.radioButtonPessoaFisica.Size = new System.Drawing.Size(113, 21);
            this.radioButtonPessoaFisica.TabIndex = 11;
            this.radioButtonPessoaFisica.TabStop = true;
            this.radioButtonPessoaFisica.Text = "Pessoa Fisíca";
            this.radioButtonPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(498, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 23);
            this.textBox1.TabIndex = 7;
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registro.Location = new System.Drawing.Point(353, 165);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(61, 17);
            this.Registro.TabIndex = 5;
            this.Registro.Text = "Registro";
            this.Registro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ano
            // 
            this.Ano.AutoSize = true;
            this.Ano.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ano.Location = new System.Drawing.Point(458, 47);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(33, 17);
            this.Ano.TabIndex = 4;
            this.Ano.Text = "Ano";
            this.Ano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Telefone.Location = new System.Drawing.Point(41, 168);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(64, 17);
            this.Telefone.TabIndex = 3;
            this.Telefone.Text = "Telefone";
            this.Telefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Endereco.Location = new System.Drawing.Point(36, 107);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(69, 17);
            this.Endereco.TabIndex = 2;
            this.Endereco.Text = "Endereço";
            this.Endereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nome.Location = new System.Drawing.Point(60, 47);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(111, 44);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(260, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.AutoSize = false;
            this.salvarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // cllienteToolStripMenuItem
            // 
            this.cllienteToolStripMenuItem.Checked = true;
            this.cllienteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cllienteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cllienteToolStripMenuItem.DoubleClickEnabled = true;
            this.cllienteToolStripMenuItem.Name = "cllienteToolStripMenuItem";
            this.cllienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cllienteToolStripMenuItem.Text = "Cliente";
            this.cllienteToolStripMenuItem.Click += new System.EventHandler(this.cllienteToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            // 
            // editaToolStripMenuItem
            // 
            this.editaToolStripMenuItem.Name = "editaToolStripMenuItem";
            this.editaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editaToolStripMenuItem.Text = "Editar";
            // 
            // excluirrToolStripMenuItem
            // 
            this.excluirrToolStripMenuItem.Name = "excluirrToolStripMenuItem";
            this.excluirrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirrToolStripMenuItem.Text = "Excluir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.Label Ano;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.RadioButton radioButtonPessoaJuridica;
        private System.Windows.Forms.RadioButton radioButtonPessoaFisica;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegistro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cllienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirrToolStripMenuItem;
    }
}

