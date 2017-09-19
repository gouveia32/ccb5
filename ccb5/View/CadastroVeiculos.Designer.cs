namespace ccb5
{
    partial class CadastroVeiculos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeiculos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Marca = new System.Windows.Forms.Label();
            this.label_Modelo = new System.Windows.Forms.Label();
            this.label_AnoFabricacao = new System.Windows.Forms.Label();
            this.label_Cor = new System.Windows.Forms.Label();
            this.label_Placa = new System.Windows.Forms.Label();
            this.label_Chassi = new System.Windows.Forms.Label();
            this.label_RENAVAM = new System.Windows.Forms.Label();
            this.label_DataLicenciamento = new System.Windows.Forms.Label();
            this.label_Categoria = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_Fornecedor = new System.Windows.Forms.Label();
            this.groupBox_Caracteristicas = new System.Windows.Forms.GroupBox();
            this.groupBox_Direcao = new System.Windows.Forms.GroupBox();
            this.checkBox_Hidraulica = new System.Windows.Forms.RadioButton();
            this.checkBox_Eletrica = new System.Windows.Forms.RadioButton();
            this.checkBox_Trava = new System.Windows.Forms.CheckBox();
            this.checkBox_Vidro = new System.Windows.Forms.CheckBox();
            this.checkBox_ArCondicionado = new System.Windows.Forms.CheckBox();
            this.groupBox_Cambio = new System.Windows.Forms.GroupBox();
            this.checkBox_Manual = new System.Windows.Forms.RadioButton();
            this.checkBox_Automatico = new System.Windows.Forms.RadioButton();
            this.groupBox_Portas = new System.Windows.Forms.GroupBox();
            this.checkBox_4portas = new System.Windows.Forms.RadioButton();
            this.checkBox_2portas = new System.Windows.Forms.RadioButton();
            this.label_Combustivel = new System.Windows.Forms.Label();
            this.comboBox_Combustivel = new System.Windows.Forms.ComboBox();
            this.label_Tanque = new System.Windows.Forms.Label();
            this.label_KM = new System.Windows.Forms.Label();
            this.comboBox_Tanque = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripBuscaF = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_PesquisarF = new System.Windows.Forms.ToolStripButton();
            this.toolStripCategoria = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_BuscarC = new System.Windows.Forms.ToolStripButton();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.usuarioServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_MesLic = new System.Windows.Forms.ComboBox();
            this.textBox_Marca = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Modelo = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Cor = new System.Windows.Forms.MaskedTextBox();
            this.textBox_KM = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Chassi = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Placa = new System.Windows.Forms.MaskedTextBox();
            this.textBox_RENAVAM = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_AnoF = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_AnoLic = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.groupBox_Caracteristicas.SuspendLayout();
            this.groupBox_Direcao.SuspendLayout();
            this.groupBox_Cambio.SuspendLayout();
            this.groupBox_Portas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            this.toolStripBuscaF.SuspendLayout();
            this.toolStripCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1045, 73);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Salvar
            // 
            this.toolStripButton_Salvar.AutoSize = false;
            this.toolStripButton_Salvar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Salvar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Salvar.Image")));
            this.toolStripButton_Salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Salvar.Name = "toolStripButton_Salvar";
            this.toolStripButton_Salvar.Size = new System.Drawing.Size(95, 70);
            this.toolStripButton_Salvar.Text = "Salvar";
            this.toolStripButton_Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Salvar.Click += new System.EventHandler(this.toolStripButton_Salvar_Click);
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
            this.toolStripButton_Cancelar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Cancelar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Cancelar.Image")));
            this.toolStripButton_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Cancelar.Name = "toolStripButton_Cancelar";
            this.toolStripButton_Cancelar.Size = new System.Drawing.Size(95, 70);
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
            // label_Marca
            // 
            this.label_Marca.AutoSize = true;
            this.label_Marca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Marca.Location = new System.Drawing.Point(60, 158);
            this.label_Marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Marca.Name = "label_Marca";
            this.label_Marca.Size = new System.Drawing.Size(62, 24);
            this.label_Marca.TabIndex = 43;
            this.label_Marca.Text = "Marca";
            // 
            // label_Modelo
            // 
            this.label_Modelo.AutoSize = true;
            this.label_Modelo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Modelo.Location = new System.Drawing.Point(49, 203);
            this.label_Modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Modelo.Name = "label_Modelo";
            this.label_Modelo.Size = new System.Drawing.Size(75, 24);
            this.label_Modelo.TabIndex = 45;
            this.label_Modelo.Text = "Modelo";
            // 
            // label_AnoFabricacao
            // 
            this.label_AnoFabricacao.AutoSize = true;
            this.label_AnoFabricacao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AnoFabricacao.Location = new System.Drawing.Point(8, 369);
            this.label_AnoFabricacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AnoFabricacao.Name = "label_AnoFabricacao";
            this.label_AnoFabricacao.Size = new System.Drawing.Size(103, 24);
            this.label_AnoFabricacao.TabIndex = 47;
            this.label_AnoFabricacao.Text = "Ano Fabric.";
            // 
            // label_Cor
            // 
            this.label_Cor.AutoSize = true;
            this.label_Cor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cor.Location = new System.Drawing.Point(85, 246);
            this.label_Cor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Cor.Name = "label_Cor";
            this.label_Cor.Size = new System.Drawing.Size(39, 24);
            this.label_Cor.TabIndex = 49;
            this.label_Cor.Text = "Cor";
            // 
            // label_Placa
            // 
            this.label_Placa.AutoSize = true;
            this.label_Placa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Placa.Location = new System.Drawing.Point(573, 284);
            this.label_Placa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Placa.Name = "label_Placa";
            this.label_Placa.Size = new System.Drawing.Size(53, 24);
            this.label_Placa.TabIndex = 51;
            this.label_Placa.Text = "Placa";
            // 
            // label_Chassi
            // 
            this.label_Chassi.AutoSize = true;
            this.label_Chassi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Chassi.Location = new System.Drawing.Point(563, 203);
            this.label_Chassi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Chassi.Name = "label_Chassi";
            this.label_Chassi.Size = new System.Drawing.Size(63, 24);
            this.label_Chassi.TabIndex = 53;
            this.label_Chassi.Text = "Chassi";
            // 
            // label_RENAVAM
            // 
            this.label_RENAVAM.AutoSize = true;
            this.label_RENAVAM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RENAVAM.Location = new System.Drawing.Point(540, 246);
            this.label_RENAVAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RENAVAM.Name = "label_RENAVAM";
            this.label_RENAVAM.Size = new System.Drawing.Size(87, 24);
            this.label_RENAVAM.TabIndex = 55;
            this.label_RENAVAM.Text = "Renavam";
            // 
            // label_DataLicenciamento
            // 
            this.label_DataLicenciamento.AutoSize = true;
            this.label_DataLicenciamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataLicenciamento.Location = new System.Drawing.Point(448, 327);
            this.label_DataLicenciamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DataLicenciamento.Name = "label_DataLicenciamento";
            this.label_DataLicenciamento.Size = new System.Drawing.Size(174, 24);
            this.label_DataLicenciamento.TabIndex = 57;
            this.label_DataLicenciamento.Text = "Data Licenciamento";
            // 
            // label_Categoria
            // 
            this.label_Categoria.AutoSize = true;
            this.label_Categoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Categoria.Location = new System.Drawing.Point(540, 159);
            this.label_Categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Categoria.Name = "label_Categoria";
            this.label_Categoria.Size = new System.Drawing.Size(90, 24);
            this.label_Categoria.TabIndex = 60;
            this.label_Categoria.Text = "Categoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            // 
            // label_Fornecedor
            // 
            this.label_Fornecedor.AutoSize = true;
            this.label_Fornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fornecedor.Location = new System.Drawing.Point(19, 112);
            this.label_Fornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Fornecedor.Name = "label_Fornecedor";
            this.label_Fornecedor.Size = new System.Drawing.Size(105, 24);
            this.label_Fornecedor.TabIndex = 62;
            this.label_Fornecedor.Text = "Fornecedor";
            // 
            // groupBox_Caracteristicas
            // 
            this.groupBox_Caracteristicas.Controls.Add(this.groupBox_Direcao);
            this.groupBox_Caracteristicas.Controls.Add(this.checkBox_Trava);
            this.groupBox_Caracteristicas.Controls.Add(this.checkBox_Vidro);
            this.groupBox_Caracteristicas.Controls.Add(this.checkBox_ArCondicionado);
            this.groupBox_Caracteristicas.Controls.Add(this.groupBox_Cambio);
            this.groupBox_Caracteristicas.Controls.Add(this.groupBox_Portas);
            this.groupBox_Caracteristicas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Caracteristicas.Location = new System.Drawing.Point(65, 411);
            this.groupBox_Caracteristicas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Caracteristicas.Name = "groupBox_Caracteristicas";
            this.groupBox_Caracteristicas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Caracteristicas.Size = new System.Drawing.Size(845, 207);
            this.groupBox_Caracteristicas.TabIndex = 17;
            this.groupBox_Caracteristicas.TabStop = false;
            this.groupBox_Caracteristicas.Text = "Características";
            // 
            // groupBox_Direcao
            // 
            this.groupBox_Direcao.Controls.Add(this.checkBox_Hidraulica);
            this.groupBox_Direcao.Controls.Add(this.checkBox_Eletrica);
            this.groupBox_Direcao.Location = new System.Drawing.Point(23, 114);
            this.groupBox_Direcao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Direcao.Name = "groupBox_Direcao";
            this.groupBox_Direcao.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Direcao.Size = new System.Drawing.Size(244, 60);
            this.groupBox_Direcao.TabIndex = 21;
            this.groupBox_Direcao.TabStop = false;
            this.groupBox_Direcao.Text = "Direção";
            // 
            // checkBox_Hidraulica
            // 
            this.checkBox_Hidraulica.AutoSize = true;
            this.checkBox_Hidraulica.Checked = true;
            this.checkBox_Hidraulica.Location = new System.Drawing.Point(129, 23);
            this.checkBox_Hidraulica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Hidraulica.Name = "checkBox_Hidraulica";
            this.checkBox_Hidraulica.Size = new System.Drawing.Size(108, 27);
            this.checkBox_Hidraulica.TabIndex = 19;
            this.checkBox_Hidraulica.TabStop = true;
            this.checkBox_Hidraulica.Text = "Hidráulica";
            this.checkBox_Hidraulica.UseVisualStyleBackColor = true;
            // 
            // checkBox_Eletrica
            // 
            this.checkBox_Eletrica.AutoSize = true;
            this.checkBox_Eletrica.Location = new System.Drawing.Point(12, 23);
            this.checkBox_Eletrica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Eletrica.Name = "checkBox_Eletrica";
            this.checkBox_Eletrica.Size = new System.Drawing.Size(87, 27);
            this.checkBox_Eletrica.TabIndex = 18;
            this.checkBox_Eletrica.Text = "Elétrica";
            this.checkBox_Eletrica.UseVisualStyleBackColor = true;
            // 
            // checkBox_Trava
            // 
            this.checkBox_Trava.AutoSize = true;
            this.checkBox_Trava.Location = new System.Drawing.Point(364, 52);
            this.checkBox_Trava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Trava.Name = "checkBox_Trava";
            this.checkBox_Trava.Size = new System.Drawing.Size(134, 27);
            this.checkBox_Trava.TabIndex = 16;
            this.checkBox_Trava.Text = "Trava Elétrica";
            this.checkBox_Trava.UseVisualStyleBackColor = true;
            // 
            // checkBox_Vidro
            // 
            this.checkBox_Vidro.AutoSize = true;
            this.checkBox_Vidro.Location = new System.Drawing.Point(627, 52);
            this.checkBox_Vidro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Vidro.Name = "checkBox_Vidro";
            this.checkBox_Vidro.Size = new System.Drawing.Size(135, 27);
            this.checkBox_Vidro.TabIndex = 17;
            this.checkBox_Vidro.Text = "Vidro Elétrico";
            this.checkBox_Vidro.UseVisualStyleBackColor = true;
            // 
            // checkBox_ArCondicionado
            // 
            this.checkBox_ArCondicionado.AutoSize = true;
            this.checkBox_ArCondicionado.Location = new System.Drawing.Point(69, 52);
            this.checkBox_ArCondicionado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_ArCondicionado.Name = "checkBox_ArCondicionado";
            this.checkBox_ArCondicionado.Size = new System.Drawing.Size(159, 27);
            this.checkBox_ArCondicionado.TabIndex = 15;
            this.checkBox_ArCondicionado.Text = "Ar Condicionado";
            this.checkBox_ArCondicionado.UseVisualStyleBackColor = true;
            // 
            // groupBox_Cambio
            // 
            this.groupBox_Cambio.Controls.Add(this.checkBox_Manual);
            this.groupBox_Cambio.Controls.Add(this.checkBox_Automatico);
            this.groupBox_Cambio.Location = new System.Drawing.Point(300, 114);
            this.groupBox_Cambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Cambio.Name = "groupBox_Cambio";
            this.groupBox_Cambio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Cambio.Size = new System.Drawing.Size(244, 60);
            this.groupBox_Cambio.TabIndex = 24;
            this.groupBox_Cambio.TabStop = false;
            this.groupBox_Cambio.Text = "Câmbio";
            // 
            // checkBox_Manual
            // 
            this.checkBox_Manual.AutoSize = true;
            this.checkBox_Manual.Checked = true;
            this.checkBox_Manual.Location = new System.Drawing.Point(153, 23);
            this.checkBox_Manual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Manual.Name = "checkBox_Manual";
            this.checkBox_Manual.Size = new System.Drawing.Size(89, 27);
            this.checkBox_Manual.TabIndex = 21;
            this.checkBox_Manual.TabStop = true;
            this.checkBox_Manual.Text = "Manual";
            this.checkBox_Manual.UseVisualStyleBackColor = true;
            // 
            // checkBox_Automatico
            // 
            this.checkBox_Automatico.AutoSize = true;
            this.checkBox_Automatico.Location = new System.Drawing.Point(16, 23);
            this.checkBox_Automatico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Automatico.Name = "checkBox_Automatico";
            this.checkBox_Automatico.Size = new System.Drawing.Size(121, 27);
            this.checkBox_Automatico.TabIndex = 20;
            this.checkBox_Automatico.Text = "Automático";
            this.checkBox_Automatico.UseVisualStyleBackColor = true;
            // 
            // groupBox_Portas
            // 
            this.groupBox_Portas.Controls.Add(this.checkBox_4portas);
            this.groupBox_Portas.Controls.Add(this.checkBox_2portas);
            this.groupBox_Portas.Location = new System.Drawing.Point(577, 114);
            this.groupBox_Portas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Portas.Name = "groupBox_Portas";
            this.groupBox_Portas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Portas.Size = new System.Drawing.Size(244, 64);
            this.groupBox_Portas.TabIndex = 27;
            this.groupBox_Portas.TabStop = false;
            this.groupBox_Portas.Text = "Portas";
            // 
            // checkBox_4portas
            // 
            this.checkBox_4portas.AutoSize = true;
            this.checkBox_4portas.Checked = true;
            this.checkBox_4portas.Location = new System.Drawing.Point(136, 25);
            this.checkBox_4portas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_4portas.Name = "checkBox_4portas";
            this.checkBox_4portas.Size = new System.Drawing.Size(95, 27);
            this.checkBox_4portas.TabIndex = 23;
            this.checkBox_4portas.TabStop = true;
            this.checkBox_4portas.Text = "4 Portas";
            this.checkBox_4portas.UseVisualStyleBackColor = true;
            // 
            // checkBox_2portas
            // 
            this.checkBox_2portas.AutoSize = true;
            this.checkBox_2portas.Location = new System.Drawing.Point(20, 25);
            this.checkBox_2portas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_2portas.Name = "checkBox_2portas";
            this.checkBox_2portas.Size = new System.Drawing.Size(95, 27);
            this.checkBox_2portas.TabIndex = 22;
            this.checkBox_2portas.Text = "2 Portas";
            this.checkBox_2portas.UseVisualStyleBackColor = true;
            // 
            // label_Combustivel
            // 
            this.label_Combustivel.AutoSize = true;
            this.label_Combustivel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Combustivel.Location = new System.Drawing.Point(8, 287);
            this.label_Combustivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Combustivel.Name = "label_Combustivel";
            this.label_Combustivel.Size = new System.Drawing.Size(113, 24);
            this.label_Combustivel.TabIndex = 95;
            this.label_Combustivel.Text = "Combustível";
            // 
            // comboBox_Combustivel
            // 
            this.comboBox_Combustivel.AutoCompleteCustomSource.AddRange(new string[] {
            "Flex",
            "Álcool",
            "Gasolina",
            "Diesel",
            "GNV"});
            this.comboBox_Combustivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Combustivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Combustivel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox_Combustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Combustivel.FormattingEnabled = true;
            this.comboBox_Combustivel.Items.AddRange(new object[] {
            "Flex",
            "Álcool",
            "Gasolina",
            "Diesel",
            "GNV"});
            this.comboBox_Combustivel.Location = new System.Drawing.Point(135, 284);
            this.comboBox_Combustivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Combustivel.Name = "comboBox_Combustivel";
            this.comboBox_Combustivel.Size = new System.Drawing.Size(396, 24);
            this.comboBox_Combustivel.TabIndex = 8;
            // 
            // label_Tanque
            // 
            this.label_Tanque.AutoSize = true;
            this.label_Tanque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tanque.Location = new System.Drawing.Point(45, 325);
            this.label_Tanque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Tanque.Name = "label_Tanque";
            this.label_Tanque.Size = new System.Drawing.Size(71, 24);
            this.label_Tanque.TabIndex = 97;
            this.label_Tanque.Text = "Tanque";
            // 
            // label_KM
            // 
            this.label_KM.AutoSize = true;
            this.label_KM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KM.Location = new System.Drawing.Point(244, 367);
            this.label_KM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_KM.Name = "label_KM";
            this.label_KM.Size = new System.Drawing.Size(37, 24);
            this.label_KM.TabIndex = 98;
            this.label_KM.Text = "KM";
            // 
            // comboBox_Tanque
            // 
            this.comboBox_Tanque.AutoCompleteCustomSource.AddRange(new string[] {
            "Reserva",
            "1/4",
            "2/4",
            "3/4",
            "1/1"});
            this.comboBox_Tanque.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Tanque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Tanque.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox_Tanque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tanque.FormattingEnabled = true;
            this.comboBox_Tanque.Items.AddRange(new object[] {
            "Reserva",
            "1/4",
            "2/4",
            "3/4",
            "1/1"});
            this.comboBox_Tanque.Location = new System.Drawing.Point(135, 325);
            this.comboBox_Tanque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Tanque.Name = "comboBox_Tanque";
            this.comboBox_Tanque.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Tanque.TabIndex = 10;
            // 
            // fornecedorBindingSource1
            // 
            this.fornecedorBindingSource1.DataMember = "fornecedor";
            // 
            // toolStripBuscaF
            // 
            this.toolStripBuscaF.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripBuscaF.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBuscaF.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBuscaF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_PesquisarF});
            this.toolStripBuscaF.Location = new System.Drawing.Point(539, 105);
            this.toolStripBuscaF.Name = "toolStripBuscaF";
            this.toolStripBuscaF.Size = new System.Drawing.Size(27, 27);
            this.toolStripBuscaF.TabIndex = 2;
            this.toolStripBuscaF.Text = "toolStrip2";
            // 
            // toolStripButton_PesquisarF
            // 
            this.toolStripButton_PesquisarF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_PesquisarF.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PesquisarF.Image")));
            this.toolStripButton_PesquisarF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PesquisarF.Name = "toolStripButton_PesquisarF";
            this.toolStripButton_PesquisarF.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_PesquisarF.Text = "toolStripButton1";
            this.toolStripButton_PesquisarF.Click += new System.EventHandler(this.toolStripButton_PesquisarF_Click);
            // 
            // toolStripCategoria
            // 
            this.toolStripCategoria.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripCategoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCategoria.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_BuscarC});
            this.toolStripCategoria.Location = new System.Drawing.Point(900, 154);
            this.toolStripCategoria.Name = "toolStripCategoria";
            this.toolStripCategoria.Size = new System.Drawing.Size(27, 27);
            this.toolStripCategoria.TabIndex = 11;
            this.toolStripCategoria.Text = "toolStrip2";
            // 
            // toolStripButton_BuscarC
            // 
            this.toolStripButton_BuscarC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_BuscarC.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_BuscarC.Image")));
            this.toolStripButton_BuscarC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_BuscarC.Name = "toolStripButton_BuscarC";
            this.toolStripButton_BuscarC.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_BuscarC.Text = "toolStripButton1";
            this.toolStripButton_BuscarC.Click += new System.EventHandler(this.toolStripButton_BuscarC_Click);
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_Categoria.Enabled = false;
            this.textBox_Categoria.Location = new System.Drawing.Point(640, 158);
            this.textBox_Categoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(255, 22);
            this.textBox_Categoria.TabIndex = 3;
            this.textBox_Categoria.Text = "Selecione a Categoria";
            this.textBox_Categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usuarioServiceBindingSource
            // 
            this.usuarioServiceBindingSource.DataSource = typeof(Persistencia.Service.UsuarioService);
            // 
            // fornecedorDAOBindingSource
            // 
            this.fornecedorDAOBindingSource.DataSource = typeof(Persistencia.DAO.FornecedorDAO);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Persistencia.Modelo.Fornecedor);
            // 
            // comboBox_MesLic
            // 
            this.comboBox_MesLic.AutoCompleteCustomSource.AddRange(new string[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox_MesLic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_MesLic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_MesLic.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox_MesLic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MesLic.FormattingEnabled = true;
            this.comboBox_MesLic.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox_MesLic.Location = new System.Drawing.Point(644, 327);
            this.comboBox_MesLic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_MesLic.Name = "comboBox_MesLic";
            this.comboBox_MesLic.Size = new System.Drawing.Size(152, 24);
            this.comboBox_MesLic.TabIndex = 11;
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(135, 156);
            this.textBox_Marca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Marca.Mask = "???????????????????????????????????????????";
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(396, 22);
            this.textBox_Marca.TabIndex = 2;
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.Location = new System.Drawing.Point(136, 202);
            this.textBox_Modelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Modelo.Mask = "???????????????????????????????????????????";
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(395, 22);
            this.textBox_Modelo.TabIndex = 4;
            // 
            // textBox_Cor
            // 
            this.textBox_Cor.Location = new System.Drawing.Point(136, 245);
            this.textBox_Cor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Cor.Mask = "???????????????????";
            this.textBox_Cor.Name = "textBox_Cor";
            this.textBox_Cor.Size = new System.Drawing.Size(132, 22);
            this.textBox_Cor.TabIndex = 6;
            // 
            // textBox_KM
            // 
            this.textBox_KM.Location = new System.Drawing.Point(292, 367);
            this.textBox_KM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_KM.Mask = "0000000";
            this.textBox_KM.Name = "textBox_KM";
            this.textBox_KM.Size = new System.Drawing.Size(132, 22);
            this.textBox_KM.TabIndex = 14;
            // 
            // textBox_Chassi
            // 
            this.textBox_Chassi.Location = new System.Drawing.Point(640, 202);
            this.textBox_Chassi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Chassi.Mask = "&&&&&&&&&&&&&&&&&";
            this.textBox_Chassi.Name = "textBox_Chassi";
            this.textBox_Chassi.Size = new System.Drawing.Size(255, 22);
            this.textBox_Chassi.TabIndex = 5;
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.Location = new System.Drawing.Point(640, 287);
            this.textBox_Placa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Placa.Mask = "LLL-0000";
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.Size = new System.Drawing.Size(255, 22);
            this.textBox_Placa.TabIndex = 9;
            // 
            // textBox_RENAVAM
            // 
            this.textBox_RENAVAM.Location = new System.Drawing.Point(640, 245);
            this.textBox_RENAVAM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RENAVAM.Mask = "00000000000";
            this.textBox_RENAVAM.Name = "textBox_RENAVAM";
            this.textBox_RENAVAM.Size = new System.Drawing.Size(255, 22);
            this.textBox_RENAVAM.TabIndex = 7;
            // 
            // TextBox_AnoF
            // 
            this.TextBox_AnoF.Location = new System.Drawing.Point(135, 367);
            this.TextBox_AnoF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_AnoF.Mask = "0000";
            this.TextBox_AnoF.Name = "TextBox_AnoF";
            this.TextBox_AnoF.Size = new System.Drawing.Size(100, 22);
            this.TextBox_AnoF.TabIndex = 13;
            // 
            // TextBox_AnoLic
            // 
            this.TextBox_AnoLic.Location = new System.Drawing.Point(807, 327);
            this.TextBox_AnoLic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_AnoLic.Mask = "0000";
            this.TextBox_AnoLic.Name = "TextBox_AnoLic";
            this.TextBox_AnoLic.Size = new System.Drawing.Size(88, 22);
            this.TextBox_AnoLic.TabIndex = 12;
            // 
            // textBox_Fornecedor
            // 
            this.textBox_Fornecedor.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_Fornecedor.Enabled = false;
            this.textBox_Fornecedor.Location = new System.Drawing.Point(136, 110);
            this.textBox_Fornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Fornecedor.Name = "textBox_Fornecedor";
            this.textBox_Fornecedor.Size = new System.Drawing.Size(395, 22);
            this.textBox_Fornecedor.TabIndex = 1;
            this.textBox_Fornecedor.Text = "Selecione o Fornecedor";
            this.textBox_Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1045, 633);
            this.Controls.Add(this.TextBox_AnoLic);
            this.Controls.Add(this.TextBox_AnoF);
            this.Controls.Add(this.textBox_RENAVAM);
            this.Controls.Add(this.textBox_Placa);
            this.Controls.Add(this.textBox_Chassi);
            this.Controls.Add(this.textBox_KM);
            this.Controls.Add(this.textBox_Cor);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.textBox_Marca);
            this.Controls.Add(this.comboBox_MesLic);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.textBox_Fornecedor);
            this.Controls.Add(this.toolStripCategoria);
            this.Controls.Add(this.toolStripBuscaF);
            this.Controls.Add(this.comboBox_Tanque);
            this.Controls.Add(this.label_KM);
            this.Controls.Add(this.label_Tanque);
            this.Controls.Add(this.comboBox_Combustivel);
            this.Controls.Add(this.label_Combustivel);
            this.Controls.Add(this.label_AnoFabricacao);
            this.Controls.Add(this.groupBox_Caracteristicas);
            this.Controls.Add(this.label_Fornecedor);
            this.Controls.Add(this.label_Categoria);
            this.Controls.Add(this.label_DataLicenciamento);
            this.Controls.Add(this.label_RENAVAM);
            this.Controls.Add(this.label_Chassi);
            this.Controls.Add(this.label_Placa);
            this.Controls.Add(this.label_Cor);
            this.Controls.Add(this.label_Modelo);
            this.Controls.Add(this.label_Marca);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CadastroVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.groupBox_Caracteristicas.ResumeLayout(false);
            this.groupBox_Caracteristicas.PerformLayout();
            this.groupBox_Direcao.ResumeLayout(false);
            this.groupBox_Direcao.PerformLayout();
            this.groupBox_Cambio.ResumeLayout(false);
            this.groupBox_Cambio.PerformLayout();
            this.groupBox_Portas.ResumeLayout(false);
            this.groupBox_Portas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            this.toolStripBuscaF.ResumeLayout(false);
            this.toolStripBuscaF.PerformLayout();
            this.toolStripCategoria.ResumeLayout(false);
            this.toolStripCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Marca;
        private System.Windows.Forms.Label label_Modelo;
        private System.Windows.Forms.Label label_AnoFabricacao;
        private System.Windows.Forms.Label label_Cor;
        private System.Windows.Forms.Label label_Placa;
        private System.Windows.Forms.Label label_Chassi;
        private System.Windows.Forms.Label label_RENAVAM;
        private System.Windows.Forms.Label label_DataLicenciamento;
        private System.Windows.Forms.Label label_Categoria;
        private System.Windows.Forms.Label label_Fornecedor;
        private System.Windows.Forms.GroupBox groupBox_Caracteristicas;
        private System.Windows.Forms.GroupBox groupBox_Direcao;
        private System.Windows.Forms.RadioButton checkBox_Hidraulica;
        private System.Windows.Forms.RadioButton checkBox_Eletrica;
        private System.Windows.Forms.CheckBox checkBox_Trava;
        private System.Windows.Forms.CheckBox checkBox_Vidro;
        private System.Windows.Forms.CheckBox checkBox_ArCondicionado;
        private System.Windows.Forms.GroupBox groupBox_Cambio;
        private System.Windows.Forms.RadioButton checkBox_Manual;
        private System.Windows.Forms.RadioButton checkBox_Automatico;
        private System.Windows.Forms.GroupBox groupBox_Portas;
        private System.Windows.Forms.RadioButton checkBox_4portas;
        private System.Windows.Forms.RadioButton checkBox_2portas;
        private System.Windows.Forms.Label label_Combustivel;
        private System.Windows.Forms.ComboBox comboBox_Combustivel;
        private System.Windows.Forms.Label label_Tanque;
        private System.Windows.Forms.Label label_KM;
        private System.Windows.Forms.ComboBox comboBox_Tanque;
        private System.Windows.Forms.BindingSource usuarioServiceBindingSource;
        private System.Windows.Forms.BindingSource fornecedorDAOBindingSource;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private System.Windows.Forms.ToolStrip toolStripBuscaF;
        private System.Windows.Forms.ToolStripButton toolStripButton_PesquisarF;
        private System.Windows.Forms.ToolStrip toolStripCategoria;
        private System.Windows.Forms.ToolStripButton toolStripButton_BuscarC;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.ComboBox comboBox_MesLic;
        private System.Windows.Forms.MaskedTextBox textBox_Marca;
        private System.Windows.Forms.MaskedTextBox textBox_Modelo;
        private System.Windows.Forms.MaskedTextBox textBox_Cor;
        private System.Windows.Forms.MaskedTextBox textBox_KM;
        private System.Windows.Forms.MaskedTextBox textBox_Chassi;
        private System.Windows.Forms.MaskedTextBox textBox_Placa;
        private System.Windows.Forms.MaskedTextBox textBox_RENAVAM;
        private System.Windows.Forms.MaskedTextBox TextBox_AnoF;
        private System.Windows.Forms.MaskedTextBox TextBox_AnoLic;
        public System.Windows.Forms.TextBox textBox_Fornecedor;
    }
}