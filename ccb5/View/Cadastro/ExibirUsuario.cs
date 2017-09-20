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
    public partial class ExibirUsuario : Form
    {
        private long CodigoUsuario = 0;
        private long CodigoPermissao= 0;
        public ExibirUsuario()
        {
            InitializeComponent();
        }
        public ExibirUsuario(long codigo)
        {
            CodigoUsuario = codigo;
            InitializeComponent();
            Usuario usuario = new UsuarioService().Busca(codigo);
            textBox_Nome.Text = usuario.Nome;
            textBox_CPF.Text = usuario.CPF;
            textBox_RG.Text = usuario.RG;
            textBox_Usuario.Text = usuario.Login;
            textBox_Senha.Text = usuario.Senha;
            CodigoPermissao = usuario.CodigoPermissao;
            Permissao permissao = new UsuarioService().BuscarPermissao(usuario.CodigoPermissao);
            comboBox_TipoUsuario.Text = permissao.Descricao;
        }
        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja efetuar as alterações?",
            "Salvar Alterações",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {
                if (new UsuarioService().Atualizar(CodigoPermissao,CodigoUsuario,textBox_Nome.Text, textBox_RG.Text, textBox_CPF.Text,  textBox_Usuario.Text, textBox_Senha.Text,comboBox_TipoUsuario.Text))
                 {
                        MessageBox.Show("Usuario alterado com sucesso!");
                  }

                else MessageBox.Show("Preencha corretamente as informações");

            }
            if (result3 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja realmente excluir o usuário?",
            "Excluir Usuário",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

                if (new UsuarioService().Remover(CodigoUsuario))
                {
                    MessageBox.Show("Usuario removido com sucesso!");
                    this.Close();
                }
                else
                MessageBox.Show("Ops! Ocorreu um erro");
                

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
