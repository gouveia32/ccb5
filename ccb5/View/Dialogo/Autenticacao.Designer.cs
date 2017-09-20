namespace ccb5
{
    partial class Autenticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autenticacao));
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Entrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_sair = new System.Windows.Forms.ToolStripButton();
            this.picture_autenticacao = new System.Windows.Forms.PictureBox();
            this.label_autenticacao = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_usuario = new System.Windows.Forms.MaskedTextBox();
            this.textBox_senha = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_autenticacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_usuario.Location = new System.Drawing.Point(20, 92);
            this.label_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(71, 24);
            this.label_usuario.TabIndex = 0;
            this.label_usuario.Text = "Usuário";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_senha.Location = new System.Drawing.Point(29, 130);
            this.label_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(59, 24);
            this.label_senha.TabIndex = 0;
            this.label_senha.Text = "Senha";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Entrar,
            this.toolStripSeparator1,
            this.toolStripButton_sair});
            this.toolStrip1.Location = new System.Drawing.Point(196, 177);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(163, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Entrar
            // 
            this.toolStripButton_Entrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Entrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_Entrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Entrar.Image")));
            this.toolStripButton_Entrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Entrar.Name = "toolStripButton_Entrar";
            this.toolStripButton_Entrar.Size = new System.Drawing.Size(87, 28);
            this.toolStripButton_Entrar.Text = "Entrar";
            this.toolStripButton_Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_Entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton_Entrar.Click += new System.EventHandler(this.toolStripButton_entrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton_sair
            // 
            this.toolStripButton_sair.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_sair.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton_sair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sair.Image")));
            this.toolStripButton_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sair.Name = "toolStripButton_sair";
            this.toolStripButton_sair.Size = new System.Drawing.Size(67, 28);
            this.toolStripButton_sair.Text = "Sair";
            this.toolStripButton_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton_sair.Click += new System.EventHandler(this.toolStripButton_sair_Click);
            // 
            // picture_autenticacao
            // 
            this.picture_autenticacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_autenticacao.BackgroundImage")));
            this.picture_autenticacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_autenticacao.Location = new System.Drawing.Point(36, 26);
            this.picture_autenticacao.Margin = new System.Windows.Forms.Padding(4);
            this.picture_autenticacao.Name = "picture_autenticacao";
            this.picture_autenticacao.Size = new System.Drawing.Size(57, 48);
            this.picture_autenticacao.TabIndex = 7;
            this.picture_autenticacao.TabStop = false;
            // 
            // label_autenticacao
            // 
            this.label_autenticacao.AutoSize = true;
            this.label_autenticacao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_autenticacao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_autenticacao.Location = new System.Drawing.Point(101, 37);
            this.label_autenticacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_autenticacao.Name = "label_autenticacao";
            this.label_autenticacao.Size = new System.Drawing.Size(254, 29);
            this.label_autenticacao.TabIndex = 0;
            this.label_autenticacao.Text = "Autenticação do Sistema";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(97, 92);
            this.textBox_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(256, 22);
            this.textBox_usuario.TabIndex = 8;
            this.textBox_usuario.Text = "admin";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(97, 130);
            this.textBox_senha.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(256, 22);
            this.textBox_senha.TabIndex = 9;
            this.textBox_senha.Text = "admin";
            this.textBox_senha.UseSystemPasswordChar = true;
            // 
            // Autenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 219);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label_autenticacao);
            this.Controls.Add(this.picture_autenticacao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Autenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Autenticacao_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_autenticacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Entrar;
        private System.Windows.Forms.PictureBox picture_autenticacao;
        private System.Windows.Forms.Label label_autenticacao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_sair;
        private System.Windows.Forms.MaskedTextBox textBox_usuario;
        private System.Windows.Forms.MaskedTextBox textBox_senha;
    }
}