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
    public partial class NovaCategoria : Form
    {
        public NovaCategoria()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
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
                if (new CategoriaService().Inserir(textBox_Nome.Text,textBox_Valor.Text) != -1)
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
