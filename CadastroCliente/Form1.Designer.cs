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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClienteConfirmarSalvar = new System.Windows.Forms.Button();
            this.buttonClienteExluir = new System.Windows.Forms.Button();
            this.buttonClienteEditar = new System.Windows.Forms.Button();
            this.buttonClienteSalvar = new System.Windows.Forms.Button();
            this.maskedTextBoxTelefoneCad = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRegistroCad = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonPessoaJuridicaCad = new System.Windows.Forms.RadioButton();
            this.radioButtonPessoaFisicaCad = new System.Windows.Forms.RadioButton();
            this.textBoxAnoFundacaoCad = new System.Windows.Forms.TextBox();
            this.registroCad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telefoneCad = new System.Windows.Forms.Label();
            this.nomeCad = new System.Windows.Forms.Label();
            this.textBoxNomeCad = new System.Windows.Forms.TextBox();
            this.tabPageEnderecos = new System.Windows.Forms.TabPage();
            this.dataGridViewEnderecos = new System.Windows.Forms.DataGridView();
            this.groupBoxEnderecos = new System.Windows.Forms.GroupBox();
            this.textBoxEnderecoUF = new System.Windows.Forms.ComboBox();
            this.buttonEnderecoConfirmarSalvar = new System.Windows.Forms.Button();
            this.buttonEnderecoExcluir = new System.Windows.Forms.Button();
            this.buttonEnderecoEditar = new System.Windows.Forms.Button();
            this.buttonEnderecoNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEnderecoCidade = new System.Windows.Forms.TextBox();
            this.EnderecoCidade = new System.Windows.Forms.Label();
            this.textBoxEnderecoBairro = new System.Windows.Forms.TextBox();
            this.EnderecoBairro = new System.Windows.Forms.Label();
            this.textBoxEnderecoNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEnderecoRua = new System.Windows.Forms.TextBox();
            this.dataSetCliente = new CadastroCliente.DataSetCliente();
            this.appStylistRuntime1 = new Infragistics.Win.AppStyling.Runtime.AppStylistRuntime(this.components);
            this.dataSetClienteEndereco = new CadastroCliente.DataSetClienteEndereco();
            this.clientesTableAdapter = new CadastroCliente.DataSetClienteTableAdapters.clientesTableAdapter();
            this.enderecosTableAdapter = new CadastroCliente.DataSetClienteTableAdapters.enderecosTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControlClientes.SuspendLayout();
            this.tabPageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPageEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecos)).BeginInit();
            this.groupBoxEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClienteEndereco)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(569, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(73, 21);
            this.clientesToolStripMenuItem1.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem2
            // 
            this.salvarToolStripMenuItem2.Name = "salvarToolStripMenuItem2";
            this.salvarToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.salvarToolStripMenuItem2.Text = "Novo";
            this.salvarToolStripMenuItem2.Click += new System.EventHandler(this.SalvarToolStripMenuItem2_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.EditarToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.excluirToolStripMenuItem1.Text = "Excluir";
            this.excluirToolStripMenuItem1.Click += new System.EventHandler(this.ExcluirToolStripMenuItem1_Click);
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
            // tabControlClientes
            // 
            this.tabControlClientes.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlClientes.Controls.Add(this.tabPageClientes);
            this.tabControlClientes.Controls.Add(this.tabPageEnderecos);
            this.tabControlClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlClientes.ItemSize = new System.Drawing.Size(50, 30);
            this.tabControlClientes.Location = new System.Drawing.Point(0, 28);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(569, 456);
            this.tabControlClientes.TabIndex = 6;
            this.tabControlClientes.Tag = "Clientes";
            this.tabControlClientes.SelectedIndexChanged += new System.EventHandler(this.TabControlClientes_SelectedIndexChanged);
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.BackColor = System.Drawing.Color.White;
            this.tabPageClientes.CausesValidation = false;
            this.tabPageClientes.Controls.Add(this.dataGridViewClientes);
            this.tabPageClientes.Controls.Add(this.groupBox2);
            this.tabPageClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageClientes.Location = new System.Drawing.Point(4, 34);
            this.tabPageClientes.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientes.Size = new System.Drawing.Size(561, 418);
            this.tabPageClientes.TabIndex = 0;
            this.tabPageClientes.Text = "Cliente";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewClientes.Location = new System.Drawing.Point(31, 19);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClientes.RowHeadersVisible = false;
            this.dataGridViewClientes.RowHeadersWidth = 25;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewClientes.TabIndex = 8;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClientes_CellContentClick);
            this.dataGridViewClientes.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellMouseLeave);
            this.dataGridViewClientes.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClientes_CellMouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClienteConfirmarSalvar);
            this.groupBox2.Controls.Add(this.buttonClienteExluir);
            this.groupBox2.Controls.Add(this.buttonClienteEditar);
            this.groupBox2.Controls.Add(this.buttonClienteSalvar);
            this.groupBox2.Controls.Add(this.maskedTextBoxTelefoneCad);
            this.groupBox2.Controls.Add(this.maskedTextBoxRegistroCad);
            this.groupBox2.Controls.Add(this.radioButtonPessoaJuridicaCad);
            this.groupBox2.Controls.Add(this.radioButtonPessoaFisicaCad);
            this.groupBox2.Controls.Add(this.textBoxAnoFundacaoCad);
            this.groupBox2.Controls.Add(this.registroCad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.telefoneCad);
            this.groupBox2.Controls.Add(this.nomeCad);
            this.groupBox2.Controls.Add(this.textBoxNomeCad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(31, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 227);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Cliente";
            // 
            // buttonClienteConfirmarSalvar
            // 
            this.buttonClienteConfirmarSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClienteConfirmarSalvar.FlatAppearance.BorderSize = 0;
            this.buttonClienteConfirmarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteConfirmarSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonClienteConfirmarSalvar.Image")));
            this.buttonClienteConfirmarSalvar.Location = new System.Drawing.Point(407, 153);
            this.buttonClienteConfirmarSalvar.Name = "buttonClienteConfirmarSalvar";
            this.buttonClienteConfirmarSalvar.Size = new System.Drawing.Size(60, 57);
            this.buttonClienteConfirmarSalvar.TabIndex = 4;
            this.buttonClienteConfirmarSalvar.Text = "Salvar";
            this.buttonClienteConfirmarSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonClienteConfirmarSalvar.UseVisualStyleBackColor = true;
            this.buttonClienteConfirmarSalvar.Click += new System.EventHandler(this.ButtonClienteConfirmar_Click);
            // 
            // buttonClienteExluir
            // 
            this.buttonClienteExluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClienteExluir.FlatAppearance.BorderSize = 0;
            this.buttonClienteExluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteExluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonClienteExluir.Image")));
            this.buttonClienteExluir.Location = new System.Drawing.Point(98, 24);
            this.buttonClienteExluir.Name = "buttonClienteExluir";
            this.buttonClienteExluir.Size = new System.Drawing.Size(35, 34);
            this.buttonClienteExluir.TabIndex = 44;
            this.buttonClienteExluir.UseVisualStyleBackColor = true;
            this.buttonClienteExluir.Click += new System.EventHandler(this.ButtonClienteExcluir_Click);
            // 
            // buttonClienteEditar
            // 
            this.buttonClienteEditar.FlatAppearance.BorderSize = 0;
            this.buttonClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonClienteEditar.Image")));
            this.buttonClienteEditar.Location = new System.Drawing.Point(52, 24);
            this.buttonClienteEditar.Name = "buttonClienteEditar";
            this.buttonClienteEditar.Size = new System.Drawing.Size(54, 34);
            this.buttonClienteEditar.TabIndex = 43;
            this.buttonClienteEditar.UseVisualStyleBackColor = true;
            this.buttonClienteEditar.Click += new System.EventHandler(this.ButtonClienteEditar_Click);
            // 
            // buttonClienteSalvar
            // 
            this.buttonClienteSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClienteSalvar.FlatAppearance.BorderSize = 0;
            this.buttonClienteSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonClienteSalvar.Image")));
            this.buttonClienteSalvar.Location = new System.Drawing.Point(16, 24);
            this.buttonClienteSalvar.Name = "buttonClienteSalvar";
            this.buttonClienteSalvar.Size = new System.Drawing.Size(46, 34);
            this.buttonClienteSalvar.TabIndex = 42;
            this.buttonClienteSalvar.UseVisualStyleBackColor = true;
            this.buttonClienteSalvar.Click += new System.EventHandler(this.ButtonClienteNovo_Click);
            // 
            // maskedTextBoxTelefoneCad
            // 
            this.maskedTextBoxTelefoneCad.Location = new System.Drawing.Point(346, 106);
            this.maskedTextBoxTelefoneCad.Mask = "(00) 00000-0000";
            this.maskedTextBoxTelefoneCad.Name = "maskedTextBoxTelefoneCad";
            this.maskedTextBoxTelefoneCad.Size = new System.Drawing.Size(121, 23);
            this.maskedTextBoxTelefoneCad.TabIndex = 3;
            // 
            // maskedTextBoxRegistroCad
            // 
            this.maskedTextBoxRegistroCad.Location = new System.Drawing.Point(83, 106);
            this.maskedTextBoxRegistroCad.Mask = "000.000.000-00";
            this.maskedTextBoxRegistroCad.Name = "maskedTextBoxRegistroCad";
            this.maskedTextBoxRegistroCad.Size = new System.Drawing.Size(180, 23);
            this.maskedTextBoxRegistroCad.TabIndex = 2;
            // 
            // radioButtonPessoaJuridicaCad
            // 
            this.radioButtonPessoaJuridicaCad.AutoSize = true;
            this.radioButtonPessoaJuridicaCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonPessoaJuridicaCad.Location = new System.Drawing.Point(83, 171);
            this.radioButtonPessoaJuridicaCad.Name = "radioButtonPessoaJuridicaCad";
            this.radioButtonPessoaJuridicaCad.Size = new System.Drawing.Size(126, 21);
            this.radioButtonPessoaJuridicaCad.TabIndex = 12;
            this.radioButtonPessoaJuridicaCad.Text = "Pessoa Juridica";
            this.radioButtonPessoaJuridicaCad.UseVisualStyleBackColor = true;
            this.radioButtonPessoaJuridicaCad.CheckedChanged += new System.EventHandler(this.RadioButtonPessoaJuridicaCad_CheckedChanged);
            // 
            // radioButtonPessoaFisicaCad
            // 
            this.radioButtonPessoaFisicaCad.AutoSize = true;
            this.radioButtonPessoaFisicaCad.Checked = true;
            this.radioButtonPessoaFisicaCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonPessoaFisicaCad.Location = new System.Drawing.Point(83, 144);
            this.radioButtonPessoaFisicaCad.Name = "radioButtonPessoaFisicaCad";
            this.radioButtonPessoaFisicaCad.Size = new System.Drawing.Size(113, 21);
            this.radioButtonPessoaFisicaCad.TabIndex = 11;
            this.radioButtonPessoaFisicaCad.TabStop = true;
            this.radioButtonPessoaFisicaCad.Text = "Pessoa Fisíca";
            this.radioButtonPessoaFisicaCad.UseVisualStyleBackColor = true;
            this.radioButtonPessoaFisicaCad.CheckedChanged += new System.EventHandler(this.RadioButtonPessoaFisicaCad_CheckedChanged);
            // 
            // textBoxAnoFundacaoCad
            // 
            this.textBoxAnoFundacaoCad.Location = new System.Drawing.Point(411, 67);
            this.textBoxAnoFundacaoCad.MaxLength = 4;
            this.textBoxAnoFundacaoCad.Name = "textBoxAnoFundacaoCad";
            this.textBoxAnoFundacaoCad.Size = new System.Drawing.Size(56, 23);
            this.textBoxAnoFundacaoCad.TabIndex = 1;
            // 
            // registroCad
            // 
            this.registroCad.AutoSize = true;
            this.registroCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registroCad.Location = new System.Drawing.Point(16, 106);
            this.registroCad.Name = "registroCad";
            this.registroCad.Size = new System.Drawing.Size(61, 17);
            this.registroCad.TabIndex = 5;
            this.registroCad.Text = "Registro";
            this.registroCad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(305, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano Fundação";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefoneCad
            // 
            this.telefoneCad.AutoSize = true;
            this.telefoneCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telefoneCad.Location = new System.Drawing.Point(276, 109);
            this.telefoneCad.Name = "telefoneCad";
            this.telefoneCad.Size = new System.Drawing.Size(64, 17);
            this.telefoneCad.TabIndex = 3;
            this.telefoneCad.Text = "Telefone";
            this.telefoneCad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeCad
            // 
            this.nomeCad.AutoSize = true;
            this.nomeCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeCad.Location = new System.Drawing.Point(32, 70);
            this.nomeCad.Name = "nomeCad";
            this.nomeCad.Size = new System.Drawing.Size(45, 17);
            this.nomeCad.TabIndex = 1;
            this.nomeCad.Text = "Nome";
            this.nomeCad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNomeCad
            // 
            this.textBoxNomeCad.Location = new System.Drawing.Point(83, 67);
            this.textBoxNomeCad.Name = "textBoxNomeCad";
            this.textBoxNomeCad.Size = new System.Drawing.Size(208, 23);
            this.textBoxNomeCad.TabIndex = 0;
            // 
            // tabPageEnderecos
            // 
            this.tabPageEnderecos.BackColor = System.Drawing.Color.White;
            this.tabPageEnderecos.Controls.Add(this.dataGridViewEnderecos);
            this.tabPageEnderecos.Controls.Add(this.groupBoxEnderecos);
            this.tabPageEnderecos.Location = new System.Drawing.Point(4, 34);
            this.tabPageEnderecos.Name = "tabPageEnderecos";
            this.tabPageEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnderecos.Size = new System.Drawing.Size(561, 418);
            this.tabPageEnderecos.TabIndex = 1;
            this.tabPageEnderecos.Text = "Endereços";
            // 
            // dataGridViewEnderecos
            // 
            this.dataGridViewEnderecos.AllowUserToAddRows = false;
            this.dataGridViewEnderecos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEnderecos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEnderecos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnderecos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEnderecos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEnderecos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEnderecos.Location = new System.Drawing.Point(31, 18);
            this.dataGridViewEnderecos.Name = "dataGridViewEnderecos";
            this.dataGridViewEnderecos.RowHeadersVisible = false;
            this.dataGridViewEnderecos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewEnderecos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEnderecos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEnderecos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewEnderecos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewEnderecos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEnderecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEnderecos.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewEnderecos.TabIndex = 5;
            this.dataGridViewEnderecos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEnderecos_CellContentClick);
            this.dataGridViewEnderecos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnderecos_CellMouseLeave);
            this.dataGridViewEnderecos.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEnderecos_CellMouseMove);
            // 
            // groupBoxEnderecos
            // 
            this.groupBoxEnderecos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoUF);
            this.groupBoxEnderecos.Controls.Add(this.buttonEnderecoConfirmarSalvar);
            this.groupBoxEnderecos.Controls.Add(this.buttonEnderecoExcluir);
            this.groupBoxEnderecos.Controls.Add(this.buttonEnderecoEditar);
            this.groupBoxEnderecos.Controls.Add(this.buttonEnderecoNovo);
            this.groupBoxEnderecos.Controls.Add(this.label3);
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoCidade);
            this.groupBoxEnderecos.Controls.Add(this.EnderecoCidade);
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoBairro);
            this.groupBoxEnderecos.Controls.Add(this.EnderecoBairro);
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoNumero);
            this.groupBoxEnderecos.Controls.Add(this.label9);
            this.groupBoxEnderecos.Controls.Add(this.label10);
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoRua);
            this.groupBoxEnderecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEnderecos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxEnderecos.Location = new System.Drawing.Point(31, 185);
            this.groupBoxEnderecos.Name = "groupBoxEnderecos";
            this.groupBoxEnderecos.Size = new System.Drawing.Size(500, 227);
            this.groupBoxEnderecos.TabIndex = 4;
            this.groupBoxEnderecos.TabStop = false;
            this.groupBoxEnderecos.Text = "Endereços";
            // 
            // textBoxEnderecoUF
            // 
            this.textBoxEnderecoUF.FormattingEnabled = true;
            this.textBoxEnderecoUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.textBoxEnderecoUF.Location = new System.Drawing.Point(84, 150);
            this.textBoxEnderecoUF.Name = "textBoxEnderecoUF";
            this.textBoxEnderecoUF.Size = new System.Drawing.Size(121, 24);
            this.textBoxEnderecoUF.TabIndex = 33;
            // 
            // buttonEnderecoConfirmarSalvar
            // 
            this.buttonEnderecoConfirmarSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEnderecoConfirmarSalvar.FlatAppearance.BorderSize = 0;
            this.buttonEnderecoConfirmarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnderecoConfirmarSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnderecoConfirmarSalvar.Image")));
            this.buttonEnderecoConfirmarSalvar.Location = new System.Drawing.Point(410, 150);
            this.buttonEnderecoConfirmarSalvar.Name = "buttonEnderecoConfirmarSalvar";
            this.buttonEnderecoConfirmarSalvar.Size = new System.Drawing.Size(60, 57);
            this.buttonEnderecoConfirmarSalvar.TabIndex = 34;
            this.buttonEnderecoConfirmarSalvar.Text = "Salvar";
            this.buttonEnderecoConfirmarSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEnderecoConfirmarSalvar.UseVisualStyleBackColor = true;
            this.buttonEnderecoConfirmarSalvar.Click += new System.EventHandler(this.ButtonEnderecoConfirmar_Click);
            // 
            // buttonEnderecoExcluir
            // 
            this.buttonEnderecoExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEnderecoExcluir.FlatAppearance.BorderSize = 0;
            this.buttonEnderecoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnderecoExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnderecoExcluir.Image")));
            this.buttonEnderecoExcluir.Location = new System.Drawing.Point(101, 25);
            this.buttonEnderecoExcluir.Name = "buttonEnderecoExcluir";
            this.buttonEnderecoExcluir.Size = new System.Drawing.Size(35, 34);
            this.buttonEnderecoExcluir.TabIndex = 41;
            this.buttonEnderecoExcluir.UseVisualStyleBackColor = true;
            this.buttonEnderecoExcluir.Click += new System.EventHandler(this.ButtonEnderecoExcluir_Click);
            // 
            // buttonEnderecoEditar
            // 
            this.buttonEnderecoEditar.FlatAppearance.BorderSize = 0;
            this.buttonEnderecoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnderecoEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnderecoEditar.Image")));
            this.buttonEnderecoEditar.Location = new System.Drawing.Point(55, 25);
            this.buttonEnderecoEditar.Name = "buttonEnderecoEditar";
            this.buttonEnderecoEditar.Size = new System.Drawing.Size(54, 34);
            this.buttonEnderecoEditar.TabIndex = 40;
            this.buttonEnderecoEditar.UseVisualStyleBackColor = true;
            this.buttonEnderecoEditar.Click += new System.EventHandler(this.ButtonEnderecoEditar_Click);
            // 
            // buttonEnderecoNovo
            // 
            this.buttonEnderecoNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEnderecoNovo.FlatAppearance.BorderSize = 0;
            this.buttonEnderecoNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnderecoNovo.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnderecoNovo.Image")));
            this.buttonEnderecoNovo.Location = new System.Drawing.Point(19, 25);
            this.buttonEnderecoNovo.Name = "buttonEnderecoNovo";
            this.buttonEnderecoNovo.Size = new System.Drawing.Size(46, 34);
            this.buttonEnderecoNovo.TabIndex = 39;
            this.buttonEnderecoNovo.UseVisualStyleBackColor = true;
            this.buttonEnderecoNovo.Click += new System.EventHandler(this.ButtonEnderecoNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "UF";
            // 
            // textBoxEnderecoCidade
            // 
            this.textBoxEnderecoCidade.Location = new System.Drawing.Point(84, 110);
            this.textBoxEnderecoCidade.Name = "textBoxEnderecoCidade";
            this.textBoxEnderecoCidade.Size = new System.Drawing.Size(182, 23);
            this.textBoxEnderecoCidade.TabIndex = 31;
            // 
            // EnderecoCidade
            // 
            this.EnderecoCidade.AutoSize = true;
            this.EnderecoCidade.Location = new System.Drawing.Point(26, 113);
            this.EnderecoCidade.Name = "EnderecoCidade";
            this.EnderecoCidade.Size = new System.Drawing.Size(52, 17);
            this.EnderecoCidade.TabIndex = 35;
            this.EnderecoCidade.Text = "Cidade";
            // 
            // textBoxEnderecoBairro
            // 
            this.textBoxEnderecoBairro.Location = new System.Drawing.Point(330, 107);
            this.textBoxEnderecoBairro.Name = "textBoxEnderecoBairro";
            this.textBoxEnderecoBairro.Size = new System.Drawing.Size(140, 23);
            this.textBoxEnderecoBairro.TabIndex = 32;
            // 
            // EnderecoBairro
            // 
            this.EnderecoBairro.AutoSize = true;
            this.EnderecoBairro.Location = new System.Drawing.Point(278, 110);
            this.EnderecoBairro.Name = "EnderecoBairro";
            this.EnderecoBairro.Size = new System.Drawing.Size(46, 17);
            this.EnderecoBairro.TabIndex = 33;
            this.EnderecoBairro.Text = "Bairro";
            // 
            // textBoxEnderecoNumero
            // 
            this.textBoxEnderecoNumero.Location = new System.Drawing.Point(384, 65);
            this.textBoxEnderecoNumero.Name = "textBoxEnderecoNumero";
            this.textBoxEnderecoNumero.Size = new System.Drawing.Size(86, 23);
            this.textBoxEnderecoNumero.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Rua";
            // 
            // textBoxEnderecoRua
            // 
            this.textBoxEnderecoRua.Location = new System.Drawing.Point(84, 65);
            this.textBoxEnderecoRua.Name = "textBoxEnderecoRua";
            this.textBoxEnderecoRua.Size = new System.Drawing.Size(210, 23);
            this.textBoxEnderecoRua.TabIndex = 29;
            // 
            // dataSetCliente
            // 
            this.dataSetCliente.DataSetName = "DataSetCliente";
            this.dataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetClienteEndereco
            // 
            this.dataSetClienteEndereco.DataSetName = "DataSetClienteEndereco";
            this.dataSetClienteEndereco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // enderecosTableAdapter
            // 
            this.enderecosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(569, 490);
            this.Controls.Add(this.tabControlClientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlClientes.ResumeLayout(false);
            this.tabPageClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageEnderecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecos)).EndInit();
            this.groupBoxEnderecos.ResumeLayout(false);
            this.groupBoxEnderecos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClienteEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefoneCad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegistroCad;
        private System.Windows.Forms.RadioButton radioButtonPessoaJuridicaCad;
        private System.Windows.Forms.RadioButton radioButtonPessoaFisicaCad;
        private System.Windows.Forms.TextBox textBoxAnoFundacaoCad;
        private System.Windows.Forms.Label registroCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label telefoneCad;
        private System.Windows.Forms.Label nomeCad;
        private System.Windows.Forms.TextBox textBoxNomeCad;
        private System.Windows.Forms.TabPage tabPageEnderecos;
        private System.Windows.Forms.GroupBox groupBoxEnderecos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEnderecoCidade;
        private System.Windows.Forms.Label EnderecoCidade;
        private System.Windows.Forms.TextBox textBoxEnderecoBairro;
        private System.Windows.Forms.Label EnderecoBairro;
        private System.Windows.Forms.TextBox textBoxEnderecoNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEnderecoRua;
        private Infragistics.Win.AppStyling.Runtime.AppStylistRuntime appStylistRuntime1;
        private System.Windows.Forms.Button buttonEnderecoEditar;
        private System.Windows.Forms.Button buttonEnderecoNovo;
        private System.Windows.Forms.Button buttonEnderecoExcluir;
        private System.Windows.Forms.Button buttonEnderecoConfirmarSalvar;
        private DataSetClienteEndereco dataSetClienteEndereco;
        private DataSetCliente dataSetCliente;
        private System.Windows.Forms.Button buttonClienteExluir;
        private System.Windows.Forms.Button buttonClienteEditar;
        private System.Windows.Forms.Button buttonClienteSalvar;
        private System.Windows.Forms.Button buttonClienteConfirmarSalvar;
        private DataSetClienteTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox textBoxEnderecoUF;
        private DataSetClienteTableAdapters.enderecosTableAdapter enderecosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridView dataGridViewEnderecos;
    }
}

