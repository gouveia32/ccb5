namespace ccb5
{
    partial class CadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Nome = new System.Windows.Forms.Label();
            this.groupBox_TipoPessoa = new System.Windows.Forms.GroupBox();
            this.radioButton_PessoaJuridica = new System.Windows.Forms.RadioButton();
            this.radioButton_PessoaFisica = new System.Windows.Forms.RadioButton();
            this.label_RG = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Logradouro = new System.Windows.Forms.Label();
            this.label_N = new System.Windows.Forms.Label();
            this.label_CEP = new System.Windows.Forms.Label();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.label_Estado = new System.Windows.Forms.Label();
            this.comboBox_Estado = new System.Windows.Forms.ComboBox();
            this.label_CNH = new System.Windows.Forms.Label();
            this.label_Naturalidade = new System.Windows.Forms.Label();
            this.label_Passaporte = new System.Windows.Forms.Label();
            this.label_DataNasc = new System.Windows.Forms.Label();
            this.label_Telefone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_RazaoSocial = new System.Windows.Forms.Label();
            this.label_NomeFantasia = new System.Windows.Forms.Label();
            this.label_CNPJ = new System.Windows.Forms.Label();
            this.label_InscEstadual = new System.Windows.Forms.Label();
            this.label_Bairro = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.MaskedTextBox();
            this.textBox_RG = new System.Windows.Forms.MaskedTextBox();
            this.textBox_CNH = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Passaporte = new System.Windows.Forms.MaskedTextBox();
            this.textBox_NomeFantasia = new System.Windows.Forms.MaskedTextBox();
            this.textBox_RazaoSocial = new System.Windows.Forms.MaskedTextBox();
            this.textBox_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.textBox_InscEstadual = new System.Windows.Forms.MaskedTextBox();
            this.textBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Naturalidade = new System.Windows.Forms.MaskedTextBox();
            this.textBox_DataNasc = new System.Windows.Forms.MaskedTextBox();
            this.textBox_CEP = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Bairro = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Email = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Logradouro = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Cidade = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Numero = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox_TipoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Salvar,
            this.toolStripSeparator2,
            this.toolStripButton_Cancelar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(947, 73);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Salvar
            // 
            this.toolStripButton_Salvar.AutoSize = false;
            this.toolStripButton_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Salvar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Salvar.Image")));
            this.toolStripButton_Salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Salvar.Name = "toolStripButton_Salvar";
            this.toolStripButton_Salvar.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Salvar.Text = "Salvar";
            this.toolStripButton_Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Salvar.Click += new System.EventHandler(this.toolStripButton_salvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Cancelar
            // 
            this.toolStripButton_Cancelar.AutoSize = false;
            this.toolStripButton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Cancelar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Cancelar.Image")));
            this.toolStripButton_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Cancelar.Name = "toolStripButton_Cancelar";
            this.toolStripButton_Cancelar.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Cancelar.Text = "Cancelar";
            this.toolStripButton_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Cancelar.Click += new System.EventHandler(this.toolStripButton_Cancelar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.Location = new System.Drawing.Point(76, 205);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(60, 24);
            this.label_Nome.TabIndex = 2;
            this.label_Nome.Text = "Nome";
            // 
            // groupBox_TipoPessoa
            // 
            this.groupBox_TipoPessoa.Controls.Add(this.radioButton_PessoaJuridica);
            this.groupBox_TipoPessoa.Controls.Add(this.radioButton_PessoaFisica);
            this.groupBox_TipoPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TipoPessoa.Location = new System.Drawing.Point(80, 110);
            this.groupBox_TipoPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_TipoPessoa.Name = "groupBox_TipoPessoa";
            this.groupBox_TipoPessoa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_TipoPessoa.Size = new System.Drawing.Size(312, 76);
            this.groupBox_TipoPessoa.TabIndex = 4;
            this.groupBox_TipoPessoa.TabStop = false;
            this.groupBox_TipoPessoa.Text = "Pessoa Física ou Jurídica";
            // 
            // radioButton_PessoaJuridica
            // 
            this.radioButton_PessoaJuridica.AutoSize = true;
            this.radioButton_PessoaJuridica.Location = new System.Drawing.Point(162, 28);
            this.radioButton_PessoaJuridica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_PessoaJuridica.Name = "radioButton_PessoaJuridica";
            this.radioButton_PessoaJuridica.Size = new System.Drawing.Size(150, 24);
            this.radioButton_PessoaJuridica.TabIndex = 1;
            this.radioButton_PessoaJuridica.Text = "Pessoa Jurídica";
            this.radioButton_PessoaJuridica.UseVisualStyleBackColor = true;
            this.radioButton_PessoaJuridica.CheckedChanged += new System.EventHandler(this.radioButton_PessoaJuridica_CheckedChanged);
            // 
            // radioButton_PessoaFisica
            // 
            this.radioButton_PessoaFisica.AutoSize = true;
            this.radioButton_PessoaFisica.Checked = true;
            this.radioButton_PessoaFisica.Location = new System.Drawing.Point(30, 28);
            this.radioButton_PessoaFisica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_PessoaFisica.Name = "radioButton_PessoaFisica";
            this.radioButton_PessoaFisica.Size = new System.Drawing.Size(136, 24);
            this.radioButton_PessoaFisica.TabIndex = 0;
            this.radioButton_PessoaFisica.TabStop = true;
            this.radioButton_PessoaFisica.Text = "Pessoa Física";
            this.radioButton_PessoaFisica.UseVisualStyleBackColor = true;
            this.radioButton_PessoaFisica.CheckedChanged += new System.EventHandler(this.radioButton_PessoaFisica_CheckedChanged);
            // 
            // label_RG
            // 
            this.label_RG.AutoSize = true;
            this.label_RG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RG.Location = new System.Drawing.Point(88, 249);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(34, 24);
            this.label_RG.TabIndex = 12;
            this.label_RG.Text = "RG";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPF.Location = new System.Drawing.Point(520, 209);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(40, 24);
            this.label_CPF.TabIndex = 10;
            this.label_CPF.Text = "CPF";
            // 
            // label_Logradouro
            // 
            this.label_Logradouro.AutoSize = true;
            this.label_Logradouro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logradouro.Location = new System.Drawing.Point(471, 403);
            this.label_Logradouro.Name = "label_Logradouro";
            this.label_Logradouro.Size = new System.Drawing.Size(106, 24);
            this.label_Logradouro.TabIndex = 14;
            this.label_Logradouro.Text = "Logradouro";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_N.Location = new System.Drawing.Point(834, 400);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(29, 24);
            this.label_N.TabIndex = 16;
            this.label_N.Text = "nº";
            // 
            // label_CEP
            // 
            this.label_CEP.AutoSize = true;
            this.label_CEP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CEP.Location = new System.Drawing.Point(94, 397);
            this.label_CEP.Name = "label_CEP";
            this.label_CEP.Size = new System.Drawing.Size(41, 24);
            this.label_CEP.TabIndex = 18;
            this.label_CEP.Text = "CEP";
            // 
            // label_Cidade
            // 
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cidade.Location = new System.Drawing.Point(499, 442);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(68, 24);
            this.label_Cidade.TabIndex = 20;
            this.label_Cidade.Text = "Cidade";
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Estado.Location = new System.Drawing.Point(832, 442);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(32, 24);
            this.label_Estado.TabIndex = 22;
            this.label_Estado.Text = "UF";
            // 
            // comboBox_Estado
            // 
            this.comboBox_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Estado.FormattingEnabled = true;
            this.comboBox_Estado.ItemHeight = 24;
            this.comboBox_Estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP ",
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
            this.comboBox_Estado.Location = new System.Drawing.Point(864, 436);
            this.comboBox_Estado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Estado.Name = "comboBox_Estado";
            this.comboBox_Estado.Size = new System.Drawing.Size(58, 32);
            this.comboBox_Estado.TabIndex = 55;
            // 
            // label_CNH
            // 
            this.label_CNH.AutoSize = true;
            this.label_CNH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CNH.Location = new System.Drawing.Point(83, 289);
            this.label_CNH.Name = "label_CNH";
            this.label_CNH.Size = new System.Drawing.Size(46, 24);
            this.label_CNH.TabIndex = 24;
            this.label_CNH.Text = "CNH";
            // 
            // label_Naturalidade
            // 
            this.label_Naturalidade.AutoSize = true;
            this.label_Naturalidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Naturalidade.Location = new System.Drawing.Point(460, 254);
            this.label_Naturalidade.Name = "label_Naturalidade";
            this.label_Naturalidade.Size = new System.Drawing.Size(120, 24);
            this.label_Naturalidade.TabIndex = 26;
            this.label_Naturalidade.Text = "Naturalidade";
            // 
            // label_Passaporte
            // 
            this.label_Passaporte.AutoSize = true;
            this.label_Passaporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Passaporte.Location = new System.Drawing.Point(45, 338);
            this.label_Passaporte.Name = "label_Passaporte";
            this.label_Passaporte.Size = new System.Drawing.Size(102, 24);
            this.label_Passaporte.TabIndex = 28;
            this.label_Passaporte.Text = "Passaporte";
            // 
            // label_DataNasc
            // 
            this.label_DataNasc.AutoSize = true;
            this.label_DataNasc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataNasc.Location = new System.Drawing.Point(473, 305);
            this.label_DataNasc.Name = "label_DataNasc";
            this.label_DataNasc.Size = new System.Drawing.Size(98, 24);
            this.label_DataNasc.TabIndex = 30;
            this.label_DataNasc.Text = "Data Nasc.";
            // 
            // label_Telefone
            // 
            this.label_Telefone.AutoSize = true;
            this.label_Telefone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telefone.Location = new System.Drawing.Point(63, 474);
            this.label_Telefone.Name = "label_Telefone";
            this.label_Telefone.Size = new System.Drawing.Size(81, 24);
            this.label_Telefone.TabIndex = 34;
            this.label_Telefone.Text = "Telefone";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(503, 477);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(62, 24);
            this.label_Email.TabIndex = 38;
            this.label_Email.Text = "E-mail";
            // 
            // label_RazaoSocial
            // 
            this.label_RazaoSocial.AutoSize = true;
            this.label_RazaoSocial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RazaoSocial.Location = new System.Drawing.Point(38, 251);
            this.label_RazaoSocial.Name = "label_RazaoSocial";
            this.label_RazaoSocial.Size = new System.Drawing.Size(113, 24);
            this.label_RazaoSocial.TabIndex = 40;
            this.label_RazaoSocial.Text = "Razão Social";
            this.label_RazaoSocial.Visible = false;
            // 
            // label_NomeFantasia
            // 
            this.label_NomeFantasia.AutoSize = true;
            this.label_NomeFantasia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NomeFantasia.Location = new System.Drawing.Point(23, 209);
            this.label_NomeFantasia.Name = "label_NomeFantasia";
            this.label_NomeFantasia.Size = new System.Drawing.Size(134, 24);
            this.label_NomeFantasia.TabIndex = 42;
            this.label_NomeFantasia.Text = "Nome Fantasia";
            this.label_NomeFantasia.Visible = false;
            // 
            // label_CNPJ
            // 
            this.label_CNPJ.AutoSize = true;
            this.label_CNPJ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CNPJ.Location = new System.Drawing.Point(83, 338);
            this.label_CNPJ.Name = "label_CNPJ";
            this.label_CNPJ.Size = new System.Drawing.Size(49, 24);
            this.label_CNPJ.TabIndex = 44;
            this.label_CNPJ.Text = "CNPJ";
            this.label_CNPJ.Visible = false;
            // 
            // label_InscEstadual
            // 
            this.label_InscEstadual.AutoSize = true;
            this.label_InscEstadual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InscEstadual.Location = new System.Drawing.Point(30, 292);
            this.label_InscEstadual.Name = "label_InscEstadual";
            this.label_InscEstadual.Size = new System.Drawing.Size(124, 24);
            this.label_InscEstadual.TabIndex = 46;
            this.label_InscEstadual.Text = "Insc. Estadual";
            this.label_InscEstadual.Visible = false;
            // 
            // label_Bairro
            // 
            this.label_Bairro.AutoSize = true;
            this.label_Bairro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bairro.Location = new System.Drawing.Point(80, 438);
            this.label_Bairro.Name = "label_Bairro";
            this.label_Bairro.Size = new System.Drawing.Size(61, 24);
            this.label_Bairro.TabIndex = 48;
            this.label_Bairro.Text = "Bairro";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(163, 205);
            this.textBox_Nome.Mask = "?????????????????????????????????????????????????";
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(291, 32);
            this.textBox_Nome.TabIndex = 1;
            // 
            // textBox_RG
            // 
            this.textBox_RG.Location = new System.Drawing.Point(163, 245);
            this.textBox_RG.Mask = "00,000,000-0";
            this.textBox_RG.Name = "textBox_RG";
            this.textBox_RG.Size = new System.Drawing.Size(291, 32);
            this.textBox_RG.TabIndex = 3;
            // 
            // textBox_CNH
            // 
            this.textBox_CNH.Location = new System.Drawing.Point(163, 288);
            this.textBox_CNH.Mask = "00000000000";
            this.textBox_CNH.Name = "textBox_CNH";
            this.textBox_CNH.Size = new System.Drawing.Size(291, 32);
            this.textBox_CNH.TabIndex = 5;
            // 
            // textBox_Passaporte
            // 
            this.textBox_Passaporte.Location = new System.Drawing.Point(163, 337);
            this.textBox_Passaporte.Mask = "000000000000000000";
            this.textBox_Passaporte.Name = "textBox_Passaporte";
            this.textBox_Passaporte.Size = new System.Drawing.Size(291, 32);
            this.textBox_Passaporte.TabIndex = 7;
            // 
            // textBox_NomeFantasia
            // 
            this.textBox_NomeFantasia.Location = new System.Drawing.Point(163, 205);
            this.textBox_NomeFantasia.Mask = "?????????????????????????????????????????????????";
            this.textBox_NomeFantasia.Name = "textBox_NomeFantasia";
            this.textBox_NomeFantasia.Size = new System.Drawing.Size(291, 32);
            this.textBox_NomeFantasia.TabIndex = 20;
            // 
            // textBox_RazaoSocial
            // 
            this.textBox_RazaoSocial.Location = new System.Drawing.Point(163, 245);
            this.textBox_RazaoSocial.Mask = "?????????????????????????????????????????????????";
            this.textBox_RazaoSocial.Name = "textBox_RazaoSocial";
            this.textBox_RazaoSocial.Size = new System.Drawing.Size(291, 32);
            this.textBox_RazaoSocial.TabIndex = 21;
            // 
            // textBox_CNPJ
            // 
            this.textBox_CNPJ.Location = new System.Drawing.Point(164, 337);
            this.textBox_CNPJ.Mask = "00,000,000/0000-00";
            this.textBox_CNPJ.Name = "textBox_CNPJ";
            this.textBox_CNPJ.Size = new System.Drawing.Size(290, 32);
            this.textBox_CNPJ.TabIndex = 23;
            // 
            // textBox_InscEstadual
            // 
            this.textBox_InscEstadual.Location = new System.Drawing.Point(164, 288);
            this.textBox_InscEstadual.Mask = "0000000000000000000000000";
            this.textBox_InscEstadual.Name = "textBox_InscEstadual";
            this.textBox_InscEstadual.Size = new System.Drawing.Size(290, 32);
            this.textBox_InscEstadual.TabIndex = 22;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(578, 202);
            this.textBox_CPF.Mask = "000,000,000-00";
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(244, 32);
            this.textBox_CPF.TabIndex = 2;
            // 
            // textBox_Naturalidade
            // 
            this.textBox_Naturalidade.Location = new System.Drawing.Point(578, 247);
            this.textBox_Naturalidade.Mask = "?????????????????";
            this.textBox_Naturalidade.Name = "textBox_Naturalidade";
            this.textBox_Naturalidade.Size = new System.Drawing.Size(244, 32);
            this.textBox_Naturalidade.TabIndex = 4;
            // 
            // textBox_DataNasc
            // 
            this.textBox_DataNasc.Location = new System.Drawing.Point(578, 298);
            this.textBox_DataNasc.Mask = "00/00/0000";
            this.textBox_DataNasc.Name = "textBox_DataNasc";
            this.textBox_DataNasc.Size = new System.Drawing.Size(246, 32);
            this.textBox_DataNasc.TabIndex = 6;
            this.textBox_DataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_CEP
            // 
            this.textBox_CEP.Location = new System.Drawing.Point(163, 396);
            this.textBox_CEP.Mask = "00000-000";
            this.textBox_CEP.Name = "textBox_CEP";
            this.textBox_CEP.Size = new System.Drawing.Size(291, 32);
            this.textBox_CEP.TabIndex = 50;
            // 
            // textBox_Bairro
            // 
            this.textBox_Bairro.Location = new System.Drawing.Point(163, 433);
            this.textBox_Bairro.Mask = "?????????????????????????????????????????????????";
            this.textBox_Bairro.Name = "textBox_Bairro";
            this.textBox_Bairro.Size = new System.Drawing.Size(291, 32);
            this.textBox_Bairro.TabIndex = 53;
            // 
            // textBox_Telefone
            // 
            this.textBox_Telefone.Location = new System.Drawing.Point(163, 473);
            this.textBox_Telefone.Mask = "00000000000";
            this.textBox_Telefone.Name = "textBox_Telefone";
            this.textBox_Telefone.Size = new System.Drawing.Size(291, 32);
            this.textBox_Telefone.TabIndex = 56;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(578, 473);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(244, 32);
            this.textBox_Email.TabIndex = 57;
            // 
            // textBox_Logradouro
            // 
            this.textBox_Logradouro.Location = new System.Drawing.Point(578, 396);
            this.textBox_Logradouro.Mask = "?????????????????????????????????????????????????";
            this.textBox_Logradouro.Name = "textBox_Logradouro";
            this.textBox_Logradouro.Size = new System.Drawing.Size(244, 32);
            this.textBox_Logradouro.TabIndex = 51;
            // 
            // textBox_Cidade
            // 
            this.textBox_Cidade.Location = new System.Drawing.Point(578, 435);
            this.textBox_Cidade.Mask = "?????????????????????????????????????????????????";
            this.textBox_Cidade.Name = "textBox_Cidade";
            this.textBox_Cidade.Size = new System.Drawing.Size(244, 32);
            this.textBox_Cidade.TabIndex = 54;
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(864, 397);
            this.textBox_Numero.Mask = "000000";
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Size = new System.Drawing.Size(58, 32);
            this.textBox_Numero.TabIndex = 52;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(947, 534);
            this.Controls.Add(this.textBox_Numero);
            this.Controls.Add(this.textBox_Cidade);
            this.Controls.Add(this.textBox_Logradouro);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Telefone);
            this.Controls.Add(this.textBox_Bairro);
            this.Controls.Add(this.textBox_CEP);
            this.Controls.Add(this.textBox_DataNasc);
            this.Controls.Add(this.textBox_Naturalidade);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.textBox_InscEstadual);
            this.Controls.Add(this.textBox_CNPJ);
            this.Controls.Add(this.textBox_RazaoSocial);
            this.Controls.Add(this.textBox_NomeFantasia);
            this.Controls.Add(this.textBox_Passaporte);
            this.Controls.Add(this.textBox_CNH);
            this.Controls.Add(this.textBox_RG);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label_Bairro);
            this.Controls.Add(this.label_InscEstadual);
            this.Controls.Add(this.label_CNPJ);
            this.Controls.Add(this.label_NomeFantasia);
            this.Controls.Add(this.label_RazaoSocial);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Telefone);
            this.Controls.Add(this.label_DataNasc);
            this.Controls.Add(this.label_Passaporte);
            this.Controls.Add(this.label_Naturalidade);
            this.Controls.Add(this.label_CNH);
            this.Controls.Add(this.comboBox_Estado);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.label_Estado);
            this.Controls.Add(this.label_CPF);
            this.Controls.Add(this.label_Cidade);
            this.Controls.Add(this.label_CEP);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.label_Logradouro);
            this.Controls.Add(this.groupBox_TipoPessoa);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_TipoPessoa.ResumeLayout(false);
            this.groupBox_TipoPessoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.GroupBox groupBox_TipoPessoa;
        private System.Windows.Forms.RadioButton radioButton_PessoaJuridica;
        private System.Windows.Forms.RadioButton radioButton_PessoaFisica;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_Logradouro;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Label label_CEP;
        private System.Windows.Forms.Label label_Cidade;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.ComboBox comboBox_Estado;
        private System.Windows.Forms.Label label_CNH;
        private System.Windows.Forms.Label label_Naturalidade;
        private System.Windows.Forms.Label label_Passaporte;
        private System.Windows.Forms.Label label_DataNasc;
        private System.Windows.Forms.Label label_Telefone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_RazaoSocial;
        private System.Windows.Forms.Label label_NomeFantasia;
        private System.Windows.Forms.Label label_CNPJ;
        private System.Windows.Forms.Label label_InscEstadual;
        private System.Windows.Forms.Label label_Bairro;
        private System.Windows.Forms.MaskedTextBox textBox_Nome;
        private System.Windows.Forms.MaskedTextBox textBox_RG;
        private System.Windows.Forms.MaskedTextBox textBox_CNH;
        private System.Windows.Forms.MaskedTextBox textBox_Passaporte;
        private System.Windows.Forms.MaskedTextBox textBox_NomeFantasia;
        private System.Windows.Forms.MaskedTextBox textBox_RazaoSocial;
        private System.Windows.Forms.MaskedTextBox textBox_CNPJ;
        private System.Windows.Forms.MaskedTextBox textBox_InscEstadual;
        private System.Windows.Forms.MaskedTextBox textBox_CPF;
        private System.Windows.Forms.MaskedTextBox textBox_Naturalidade;
        private System.Windows.Forms.MaskedTextBox textBox_DataNasc;
        private System.Windows.Forms.MaskedTextBox textBox_CEP;
        private System.Windows.Forms.MaskedTextBox textBox_Bairro;
        private System.Windows.Forms.MaskedTextBox textBox_Telefone;
        private System.Windows.Forms.MaskedTextBox textBox_Email;
        private System.Windows.Forms.MaskedTextBox textBox_Logradouro;
        private System.Windows.Forms.MaskedTextBox textBox_Cidade;
        private System.Windows.Forms.MaskedTextBox textBox_Numero;
    }
}