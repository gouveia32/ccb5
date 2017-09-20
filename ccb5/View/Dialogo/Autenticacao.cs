using Persistencia.DAO;
using Persistencia.Modelo;
using Persistencia.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccb5
{
    public partial class Autenticacao : Form
    {
        public static Usuario UsuarioLogado { get; set;}
        public String logado;
        public Autenticacao()
        {
            InitializeComponent();
        }
           
        private void toolStripButton_entrar_Click(object sender, EventArgs e)
        {
            UsuarioService userS = new UsuarioService();
            if (userS.Autenticar(textBox_usuario.Text, textBox_senha.Text))
            {
                this.DialogResult = DialogResult.OK;
                logado = textBox_usuario.Text;
                UsuarioLogado = new UsuarioDAO().BuscarUsuario(textBox_usuario.Text);
            }
            else MessageBox.Show("Usuario ou senha incorretos!", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Autenticacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UsuarioService userS = new UsuarioService();
               if (userS.Autenticar(textBox_usuario.Text, textBox_senha.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    UsuarioLogado = new UsuarioDAO().BuscarUsuario(textBox_usuario.Text);
                    logado = textBox_usuario.Text;
                }
                else MessageBox.Show("Usuario ou senha incorretos!", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void toolStripButton_sair_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente sair do sistema?",
            "Sair do sistema",
            MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.OK)
            {
                this.Close();
            }            
        }
    }
}
    
    
    

