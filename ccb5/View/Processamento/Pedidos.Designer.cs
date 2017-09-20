namespace ccb5
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Novo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            this.textBox_ValorBusca = new System.Windows.Forms.TextBox();
            this.dataGridView_Pedidos = new System.Windows.Forms.DataGridView();
            this.CodigoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_ValorBusca = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Novo,
            this.toolStripSeparator2,
            this.toolStripButton_Sair,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(960, 73);
            this.toolStrip1.TabIndex = 1;
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
            this.toolStripButton_Novo.Click += new System.EventHandler(this.toolStripButton_Novo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.AutoSize = true;
            this.button_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pesquisar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("button_Pesquisar.Image")));
            this.button_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pesquisar.Location = new System.Drawing.Point(824, 171);
            this.button_Pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(120, 37);
            this.button_Pesquisar.TabIndex = 9;
            this.button_Pesquisar.Text = "Pesquisar";
            this.button_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Pesquisar.UseVisualStyleBackColor = true;
            this.button_Pesquisar.Click += new System.EventHandler(this.button_Pesquisar_Click);
            // 
            // textBox_ValorBusca
            // 
            this.textBox_ValorBusca.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorBusca.Location = new System.Drawing.Point(17, 175);
            this.textBox_ValorBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ValorBusca.Name = "textBox_ValorBusca";
            this.textBox_ValorBusca.Size = new System.Drawing.Size(797, 30);
            this.textBox_ValorBusca.TabIndex = 8;
            this.textBox_ValorBusca.Text = "Digite Nº Pedido,Nome Cliente,Razão Social,CNPJ,CPF.";
            this.textBox_ValorBusca.Click += new System.EventHandler(this.textBox_ValorBusca_Click);
            // 
            // dataGridView_Pedidos
            // 
            this.dataGridView_Pedidos.AllowUserToAddRows = false;
            this.dataGridView_Pedidos.AllowUserToDeleteRows = false;
            this.dataGridView_Pedidos.AllowUserToOrderColumns = true;
            this.dataGridView_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPedido,
            this.Status,
            this.DataReserva,
            this.DataEntrega,
            this.DataRetirada,
            this.Cliente,
            this.Veiculo,
            this.Valor});
            this.dataGridView_Pedidos.Location = new System.Drawing.Point(17, 213);
            this.dataGridView_Pedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Pedidos.Name = "dataGridView_Pedidos";
            this.dataGridView_Pedidos.ReadOnly = true;
            this.dataGridView_Pedidos.Size = new System.Drawing.Size(927, 367);
            this.dataGridView_Pedidos.TabIndex = 13;
            this.dataGridView_Pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pedidos_CellClick_1);
            // 
            // CodigoPedido
            // 
            this.CodigoPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodigoPedido.HeaderText = "Número Reserva";
            this.CodigoPedido.Name = "CodigoPedido";
            this.CodigoPedido.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DataReserva
            // 
            this.DataReserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataReserva.HeaderText = "Data da Reserva";
            this.DataReserva.Name = "DataReserva";
            this.DataReserva.ReadOnly = true;
            // 
            // DataEntrega
            // 
            this.DataEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataEntrega.HeaderText = "Data da Entrega";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.ReadOnly = true;
            // 
            // DataRetirada
            // 
            this.DataRetirada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataRetirada.HeaderText = "Data da Retirada";
            this.DataRetirada.Name = "DataRetirada";
            this.DataRetirada.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Veiculo
            // 
            this.Veiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Veiculo.HeaderText = "Veiculo";
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // label_ValorBusca
            // 
            this.label_ValorBusca.AutoSize = true;
            this.label_ValorBusca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorBusca.Location = new System.Drawing.Point(379, 148);
            this.label_ValorBusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ValorBusca.Name = "label_ValorBusca";
            this.label_ValorBusca.Size = new System.Drawing.Size(136, 24);
            this.label_ValorBusca.TabIndex = 10;
            this.label_ValorBusca.Text = "Buscar Pedidos";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(960, 594);
            this.Controls.Add(this.dataGridView_Pedidos);
            this.Controls.Add(this.label_ValorBusca);
            this.Controls.Add(this.button_Pesquisar);
            this.Controls.Add(this.textBox_ValorBusca);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Activated += new System.EventHandler(this.Pedidos_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button button_Pesquisar;
        private System.Windows.Forms.TextBox textBox_ValorBusca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridView_Pedidos;
        private System.Windows.Forms.Label label_ValorBusca;
        private System.Windows.Forms.ToolStripButton toolStripButton_Novo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}