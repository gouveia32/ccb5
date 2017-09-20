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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirUsuario novo = new ExibirUsuario();
            novo.ShowDialog();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroUsuarios novo = new CadastroUsuarios();
            novo.ShowDialog();
        }

        private void dataGrid_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirUsuario novo = new ExibirUsuario(long.Parse(dataGrid_Usuario.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            novo.ShowDialog();
        }

        private void textBox_ValorBusca_Click(object sender, EventArgs e)
        {
            if (textBox_ValorBusca.Text == "Digite Nome,Usuário,CPF,RG.")
            {
                textBox_ValorBusca.Text = "";
            }
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            dataGrid_Usuario.Rows.Clear();
            foreach (Usuario user in new UsuarioService().Pesquisar(textBox_ValorBusca.Text))
            {
                int index = dataGrid_Usuario.Rows.Add();
                DataGridViewRow dado = dataGrid_Usuario.Rows[index];
                dado.Cells["Código"].Value = user.Id;
                dado.Cells["Nome"].Value = user.Nome;
                dado.Cells["Login"].Value = user.Login;
                dado.Cells["RG"].Value = user.RG;
                dado.Cells["CPF"].Value = user.CPF;
            }
        }

        private void Usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGrid_Usuario.Rows.Clear();
                foreach (Usuario user in new UsuarioService().Pesquisar(textBox_ValorBusca.Text))
                {
                    int index = dataGrid_Usuario.Rows.Add();
                    DataGridViewRow dado = dataGrid_Usuario.Rows[index];
                    dado.Cells["Código"].Value = user.Id;
                    dado.Cells["Nome"].Value = user.Nome;
                    dado.Cells["Login"].Value = user.Login;
                    dado.Cells["RG"].Value = user.RG;
                    dado.Cells["CPF"].Value = user.CPF;
                }
            }
        }

        private void Usuarios_Activated(object sender, EventArgs e)
        {
            dataGrid_Usuario.Rows.Clear();
            foreach (Usuario user in new UsuarioService().Listar())
            {
                int index = dataGrid_Usuario.Rows.Add();
                DataGridViewRow dado = dataGrid_Usuario.Rows[index];
                dado.Cells["Código"].Value = user.Id;
                dado.Cells["Nome"].Value = user.Nome;
                dado.Cells["Login"].Value = user.Login;
                dado.Cells["RG"].Value = user.RG;
                dado.Cells["CPF"].Value = user.CPF;
            }
        }
    }
}
