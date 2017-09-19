using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using Persistencia.DAO;
using Persistencia.Modelo;
using Persistencia.Service;

namespace ccb5
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }
        private void radioButton_PessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PessoaFisica.Checked)
            {
                label_CNPJ.Visible = false;
                textBox_InscEstadual.Visible = false;
                label_InscEstadual.Visible = false;
                textBox_CNPJ.Visible = false;
                label_RazaoSocial.Visible = false;
                textBox_RazaoSocial.Visible = false;
                label_NomeFantasia.Visible = false;
                textBox_NomeFantasia.Visible = false;
                label_CPF.Visible = true;
                textBox_CPF.Visible = true;
                label_RG.Visible = true;
                textBox_RG.Visible = true;
                label_CNH.Visible = true;
                textBox_CNH.Visible = true;
                label_Naturalidade.Visible = true;
                textBox_Naturalidade.Visible = true;
                label_Passaporte.Visible = true;
                textBox_Passaporte.Visible = true;
                label_DataNasc.Visible = true;
                textBox_DataNasc.Visible = true;
                label_Nome.Visible = true;
                textBox_Nome.Visible = true;
            }
        }
        private void radioButton_PessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PessoaJuridica.Checked)
            {
                label_Nome.Visible = false;
                textBox_Nome.Visible = false;
                label_CPF.Visible = false;
                textBox_CPF.Visible = false;
                label_RG.Visible = false;
                textBox_RG.Visible = false;
                label_CNH.Visible = false;
                textBox_CNH.Visible = false;
                label_Naturalidade.Visible = false;
                textBox_Naturalidade.Visible = false;
                label_Passaporte.Visible = false;
                textBox_Passaporte.Visible = false;
                label_DataNasc.Visible = false;
                textBox_DataNasc.Visible = false;
                label_CNPJ.Visible = true;
                textBox_InscEstadual.Visible = true;
                label_InscEstadual.Visible = true;
                textBox_CNPJ.Visible = true;
                label_RazaoSocial.Visible = true;
                textBox_RazaoSocial.Visible = true;
                label_NomeFantasia.Visible = true;
                textBox_NomeFantasia.Visible = true;
            }
        }
        private void toolStripButton_salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

                long i = new ClienteService().Inserir(
                 radioButton_PessoaFisica.Checked,
                 radioButton_PessoaJuridica.Checked,

                 textBox_NomeFantasia.Text,
                 textBox_RazaoSocial.Text,
                 textBox_CNPJ.Text,
                 textBox_InscEstadual.Text,

                 textBox_Nome.Text,
                 textBox_RG.Text,
                 textBox_CNH.Text,
                 textBox_Passaporte.Text,
                 textBox_CPF.Text,
                 textBox_Naturalidade.Text,
                 textBox_DataNasc.Text,

                 textBox_CEP.Text,
                 textBox_Bairro.Text,
                 textBox_Telefone.Text,
                 textBox_Email.Text,
                 textBox_Logradouro.Text,
                 textBox_Numero.Text,
                 textBox_Cidade.Text,
                 comboBox_Estado.Text

                );

                if (i != -1)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso! - " + i);
                    this.Close();
                }


            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            label_CNPJ.Visible = false;
            textBox_InscEstadual.Visible = false;
            label_InscEstadual.Visible = false;
            textBox_CNPJ.Visible = false;
            label_RazaoSocial.Visible = false;
            textBox_RazaoSocial.Visible = false;
            label_NomeFantasia.Visible = false;
            textBox_NomeFantasia.Visible = false;
            label_CPF.Visible = true;
            textBox_CPF.Visible = true;
            label_RG.Visible = true;
            textBox_RG.Visible = true;
            label_CNH.Visible = true;
            textBox_CNH.Visible = true;
            label_Naturalidade.Visible = true;
            textBox_Naturalidade.Visible = true;
            label_Passaporte.Visible = true;
            textBox_Passaporte.Visible = true;
            label_DataNasc.Visible = true;
            textBox_DataNasc.Visible = true;
            label_Nome.Visible = true;
            textBox_Nome.Visible = true;
        }
    }
}
