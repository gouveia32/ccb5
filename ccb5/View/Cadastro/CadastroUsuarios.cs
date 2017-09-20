using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia.Service;

namespace ccb5
{
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }
        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

                if ((new UsuarioService().Inserir(textBox_Nome.Text,textBox_RG.Text,textBox_CPF.Text,textBox_Usuario.Text,textBox_Senha.Text) != 0))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    this.Close();
                }
                else MessageBox.Show("Preencha corretamente as informações");
            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }
    }
}
