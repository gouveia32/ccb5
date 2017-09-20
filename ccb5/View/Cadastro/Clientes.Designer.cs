namespace ccb5
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Novo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox_ValorBusca = new System.Windows.Forms.TextBox();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            this.label_ValorBusca = new System.Windows.Forms.Label();
            this.dataGrid_Clientes = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Novo,
            this.toolStripSeparator1,
            this.toolStripButton_Sair,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(960, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Novo
            // 
            this.toolStripButton_Novo.AutoSize = false;
            this.toolStripButton_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Novo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Novo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Novo.Image")));
            this.toolStripButton_Novo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Novo.Name = "toolStripButton_Novo";
            this.toolStripButton_Novo.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Novo.Text = "Novo";
            this.toolStripButton_Novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Novo.Click += new System.EventHandler(this.toolStripButton_Novo_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Sair
            // 
            this.toolStripButton_Sair.AutoSize = false;
            this.toolStripButton_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Sair.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Sair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Sair.Image")));
            this.toolStripButton_Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sair.Name = "toolStripButton_Sair";
            this.toolStripButton_Sair.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Sair.Text = "Sair";
            this.toolStripButton_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Sair.Click += new System.EventHandler(this.toolStripButton_Sair_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
            // 
            // textBox_ValorBusca
            // 
            this.textBox_ValorBusca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorBusca.Location = new System.Drawing.Point(152, 156);
            this.textBox_ValorBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ValorBusca.Name = "textBox_ValorBusca";
            this.textBox_ValorBusca.Size = new System.Drawing.Size(613, 26);
            this.textBox_ValorBusca.TabIndex = 1;
            this.textBox_ValorBusca.Text = "Digite Nome,CPF,RG,Razão Social,CNPJ,Nome Fantasia.";
            this.textBox_ValorBusca.Click += new System.EventHandler(this.textBox_ValorBusca_Click);
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.AutoSize = true;
            this.button_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pesquisar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("button_Pesquisar.Image")));
            this.button_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pesquisar.Location = new System.Drawing.Point(824, 149);
            this.button_Pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(120, 37);
            this.button_Pesquisar.TabIndex = 4;
            this.button_Pesquisar.Text = "Pesquisar";
            this.button_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Pesquisar.UseVisualStyleBackColor = true;
            this.button_Pesquisar.Click += new System.EventHandler(this.button_Pesquisar_Click);
            // 
            // label_ValorBusca
            // 
            this.label_ValorBusca.AutoSize = true;
            this.label_ValorBusca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorBusca.Location = new System.Drawing.Point(344, 122);
            this.label_ValorBusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ValorBusca.Name = "label_ValorBusca";
            this.label_ValorBusca.Size = new System.Drawing.Size(137, 24);
            this.label_ValorBusca.TabIndex = 7;
            this.label_ValorBusca.Text = "Buscar Clientes";
            // 
            // dataGrid_Clientes
            // 
            this.dataGrid_Clientes.AllowUserToAddRows = false;
            this.dataGrid_Clientes.AllowUserToDeleteRows = false;
            this.dataGrid_Clientes.AllowUserToOrderColumns = true;
            this.dataGrid_Clientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Tipo,
            this.Documento,
            this.Nome});
            this.dataGrid_Clientes.Location = new System.Drawing.Point(17, 191);
            this.dataGrid_Clientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid_Clientes.Name = "dataGrid_Clientes";
            this.dataGrid_Clientes.ReadOnly = true;
            this.dataGrid_Clientes.Size = new System.Drawing.Size(927, 389);
            this.dataGrid_Clientes.TabIndex = 8;
            this.dataGrid_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Clientes_CellClick);
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(960, 594);
            this.Controls.Add(this.dataGrid_Clientes);
            this.Controls.Add(this.label_ValorBusca);
            this.Controls.Add(this.button_Pesquisar);
            this.Controls.Add(this.textBox_ValorBusca);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.Clientes_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.TextBox textBox_ValorBusca;
        private System.Windows.Forms.Button button_Pesquisar;
        private System.Windows.Forms.Label label_ValorBusca;
        private System.Windows.Forms.ToolStripButton toolStripButton_Novo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGrid_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}