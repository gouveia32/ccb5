namespace ccb5
{
    partial class CadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuarios));
            this.label_Senha = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_RG = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.MaskedTextBox();
            this.textBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.textBox_RG = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Senha = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Senha.Location = new System.Drawing.Point(145, 256);
            this.label_Senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(61, 24);
            this.label_Senha.TabIndex = 100;
            this.label_Senha.Text = "Senha";
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
            this.toolStrip1.Size = new System.Drawing.Size(659, 73);
            this.toolStrip1.TabIndex = 94;
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
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuario.Location = new System.Drawing.Point(131, 213);
            this.label_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(75, 24);
            this.label_Usuario.TabIndex = 117;
            this.label_Usuario.Text = "Usuário";
            // 
            // label_RG
            // 
            this.label_RG.AutoSize = true;
            this.label_RG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RG.Location = new System.Drawing.Point(335, 154);
            this.label_RG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(34, 24);
            this.label_RG.TabIndex = 115;
            this.label_RG.Text = "RG";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.Location = new System.Drawing.Point(11, 111);
            this.label_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(60, 24);
            this.label_Nome.TabIndex = 114;
            this.label_Nome.Text = "Nome";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPF.Location = new System.Drawing.Point(29, 151);
            this.label_CPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(40, 24);
            this.label_CPF.TabIndex = 112;
            this.label_CPF.Text = "CPF";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(81, 110);
            this.textBox_Nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nome.Mask = "???????????????????????????????????????";
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(527, 22);
            this.textBox_Nome.TabIndex = 120;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(81, 151);
            this.textBox_CPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_CPF.Mask = "000,000,000-00";
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(244, 22);
            this.textBox_CPF.TabIndex = 121;
            // 
            // textBox_RG
            // 
            this.textBox_RG.Location = new System.Drawing.Point(380, 153);
            this.textBox_RG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RG.Mask = "00,000,000-00";
            this.textBox_RG.Name = "textBox_RG";
            this.textBox_RG.Size = new System.Drawing.Size(228, 22);
            this.textBox_RG.TabIndex = 122;
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(217, 214);
            this.textBox_Usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(229, 22);
            this.textBox_Usuario.TabIndex = 123;
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(217, 257);
            this.textBox_Senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(229, 22);
            this.textBox_Senha.TabIndex = 124;
            this.textBox_Senha.UseSystemPasswordChar = true;
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(659, 306);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.textBox_RG);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label_Senha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.label_CPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.MaskedTextBox textBox_Nome;
        private System.Windows.Forms.MaskedTextBox textBox_CPF;
        private System.Windows.Forms.MaskedTextBox textBox_RG;
        private System.Windows.Forms.MaskedTextBox textBox_Usuario;
        private System.Windows.Forms.MaskedTextBox textBox_Senha;
    }
}