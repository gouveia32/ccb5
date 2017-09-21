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
    public partial class CadastroEmpregados : Form
    {
        public CadastroEmpregados()
        {
            InitializeComponent();
        }

        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show( "Deseja salvar o novo cadastro?",
                                                    "Salvar novo cadastro",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
                if (new EmpregadoService().Inserir(
                    textBox_NomeFantasia.Text, 
                    textBox_CEP.Text,
                    dateTimePicker_DataNascimento.Value.ToString(), 
                    dateTimePicker_DataAdmissao.Value.ToString(), 
                    dateTimePicker_DataDemissao.Value.ToString(), 
                    textBox_Logradouro.Text,
                    textBox_Bairro.Text, 
                    textBox_N.Text, 
                    textBox_Cidade.Text, 
                    comboBox_Estado.Text, 
                    textBox_Email.Text, 
                    textBox_Telefone.Text, 
                    textBox_Celular.Text) != -1)
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
