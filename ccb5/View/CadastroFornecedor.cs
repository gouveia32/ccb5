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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
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
                if (new FornecedorService().Inserir(textBox_NomeFantasia.Text, textBox_RazaoSocial.Text,
                    textBox_CNPJ.Text, textBox_InscEstadual.Text, textBox_CEP.Text, textBox_Logradouro.Text,
                    textBox_Bairro.Text, textBox_N.Text, textBox_Cidade.Text, comboBox_Estado.Text,
                    textBox_Email.Text, textBox_Telefone.Text, textBox_Celular.Text) != -1)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    this.Close();
                }
            }
            if (result2 == DialogResult.Cancel)
            {

            }
            
        }

    }
}
