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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRegistro = new System.Windows.Forms.MaskedTextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.radioButtonPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.radioButtonPessoaFisica = new System.Windows.Forms.RadioButton();
            this.textBoxAoNascimento = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.Label();
            this.Ano = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBox1.Controls.Add(this.maskedTextBoxRegistro);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.radioButtonPessoaJuridica);
            this.groupBox1.Controls.Add(this.radioButtonPessoaFisica);
            this.groupBox1.Controls.Add(this.textBoxAoNascimento);
            this.groupBox1.Controls.Add(this.textBoxEnderecoCompleto);
            this.groupBox1.Controls.Add(this.Registro);
            this.groupBox1.Controls.Add(this.Ano);
            this.groupBox1.Controls.Add(this.Telefone);
            this.groupBox1.Controls.Add(this.Endereco);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(25, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.Location = new System.Drawing.Point(787, 142);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(82, 62);
            this.buttonExcluir.TabIndex = 14;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Visible = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.Location = new System.Drawing.Point(787, 142);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(82, 62);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSalvar.Visible = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click_1);
            // 
            // radioButtonPessoaJuridica
            // 
            this.radioButtonPessoaJuridica.AutoSize = true;
            this.radioButtonPessoaJuridica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonPessoaJuridica.Location = new System.Drawing.Point(743, 88);
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
            this.radioButtonPessoaFisica.Location = new System.Drawing.Point(743, 48);
            this.radioButtonPessoaFisica.Name = "radioButtonPessoaFisica";
            this.radioButtonPessoaFisica.Size = new System.Drawing.Size(113, 21);
            this.radioButtonPessoaFisica.TabIndex = 11;
            this.radioButtonPessoaFisica.TabStop = true;
            this.radioButtonPessoaFisica.Text = "Pessoa Fisíca";
            this.radioButtonPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // textBoxAoNascimento
            // 
            this.textBoxAoNascimento.Location = new System.Drawing.Point(498, 46);
            this.textBoxAoNascimento.Name = "textBoxAoNascimento";
            this.textBoxAoNascimento.Size = new System.Drawing.Size(79, 23);
            this.textBoxAoNascimento.TabIndex = 9;
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(112, 107);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(607, 23);
            this.textBoxEnderecoCompleto.TabIndex = 7;
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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clientesToolStripMenuItem1.Checked = true;
            this.clientesToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem2,
            this.editarToolStripMenuItem1,
            this.excluirToolStripMenuItem1});
            this.clientesToolStripMenuItem1.Font = new System.Drawing.Font("Roboto", 10F);
            this.clientesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(75, 21);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // salvarToolStripMenuItem2
            // 
            this.salvarToolStripMenuItem2.Name = "salvarToolStripMenuItem2";
            this.salvarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem2.Text = "Novo";
            this.salvarToolStripMenuItem2.Click += new System.EventHandler(this.salvarToolStripMenuItem2_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click_1);
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem1.Text = "Excluir";
            this.excluirToolStripMenuItem1.Click += new System.EventHandler(this.excluirToolStripMenuItem1_Click_1);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // cllienteToolStripMenuItem
            // 
            this.cllienteToolStripMenuItem.Name = "cllienteToolStripMenuItem";
            this.cllienteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
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
        private System.Windows.Forms.TextBox textBoxAoNascimento;
        private System.Windows.Forms.TextBox textBoxEnderecoCompleto;
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
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
    }
}

