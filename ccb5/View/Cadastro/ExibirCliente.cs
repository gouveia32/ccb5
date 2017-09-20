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
    public partial class ExibirCliente : Form
    {
        private long CodigoCliente = 0;

        public ExibirCliente()
        {
            InitializeComponent();
        }

        public ExibirCliente(long codigo)
        {
            CodigoCliente = codigo;
            InitializeComponent();

            Cliente cliente = new ClienteService().Buscar(codigo);
        
            PessoaFisica pessoaFisica = new ClienteService().BuscarPessoaFisica(cliente.Id);
            PessoaJuridica pessoaJuridica = new ClienteService().BuscarPessoaJuridica(cliente.Id);

            radioButton_PessoaFisica.Enabled = false;
            radioButton_PessoaJuridica.Enabled = false;

            if (pessoaFisica.CodigoCliente != 0)
           {
                itensPessoaFisica();

                radioButton_PessoaFisica.Checked = true;
                
                textBox_CPF.Text = pessoaFisica.CPF;
                textBox_RG.Text = pessoaFisica.RG;
                textBox_CNH.Text = pessoaFisica.CNH;
                textBox_Naturalidade.Text = pessoaFisica.Naturalidade;
                textBox_Passaporte.Text = pessoaFisica.Passaporte;
                textBox_DataNasc.Text = pessoaFisica.DataNascimento;
                textBox_Nome.Text = pessoaFisica.Nome;
                TelefoneCliente telefoneCliente = new ClienteService().BuscarTelefoneCliente(codigo);
                textBox_Telefone.Text = telefoneCliente.Telefone;

            }
           else if (pessoaJuridica.CodigoCliente != 0)
           {
                itensPessoaJuridica();
                radioButton_PessoaJuridica.Checked = true;

                textBox_InscEstadual.Text = pessoaJuridica.InscricaoEstadual;
                textBox_CNPJ.Text = pessoaJuridica.CNPJ;
                textBox_RazaoSocial.Text = pessoaJuridica.RazaoSocial;
                textBox_NomeFantasia.Text = pessoaJuridica.NomeFantasia;

                TelefoneCliente telefoneCliente = new ClienteService().BuscarTelefoneCliente(codigo);
                textBox_Telefone.Text = telefoneCliente.Telefone;
            }
            else
            {
                MessageBox.Show("Houve um erro. Não encontrou resultados na tabela de Pessoa Juridica e nem Pessoa Física.");
                this.Close();
            }

            preencheEndereco(cliente.EnderecoId);
            textBox_Email.Text = cliente.Email;

        }


        private void preencheEndereco(long codigoEndereco)
        {
            Endereco endereco = new ClienteService().BuscarEndereco(codigoEndereco);

            textBox_CEP.Text = endereco.CEP;
            textBox_Bairro.Text = endereco.Bairro;
            textBox_Cidade.Text = endereco.Cidade;
            comboBox_Estado.SelectedIndex = comboBox_Estado.FindStringExact(endereco.Estado);
            textBox_Logradouro.Text = endereco.Logradouro;
            textBox_N.Text = endereco.Numero;

        }

        
        private void itensPessoaFisica()
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

        private void itensPessoaJuridica()
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
        private void toolStripButton_Sair_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a impressão do cadastro?",
             "Impressão",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja realmente excluir o cadastro?",
            "Excluir Cliente",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
                if (new ClienteService().Remover(CodigoCliente) != false)
                {
                    MessageBox.Show(" Veículo removido com sucesso", "Remoção do veículo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {
                if (new ClienteService().Atualizar(
                    CodigoCliente,
                    radioButton_PessoaFisica.Checked,
                    radioButton_PessoaJuridica.Checked,
                    textBox_CPF.Text,
                    textBox_RG.Text,
                    textBox_CNH.Text,
                    textBox_Naturalidade.Text,
                    textBox_Passaporte.Text,
                    textBox_DataNasc.Text,
                    textBox_Nome.Text,
                    textBox_Telefone.Text,
                    textBox_InscEstadual.Text,
                    textBox_CNPJ.Text,
                    textBox_RazaoSocial.Text,
                    textBox_NomeFantasia.Text,
                    textBox_Email.Text,
                    comboBox_Estado.Text,
                    textBox_CEP.Text,
                    textBox_Bairro.Text,
                    textBox_Cidade.Text,
                    textBox_Logradouro.Text,
                    textBox_N.Text
                    ))
                {
                    MessageBox.Show("Atualizado com sucesso! - ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }


            }
            if (result3 == DialogResult.Cancel)
            {

            }
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
                label_Passaporte.Visible = true;
                textBox_Passaporte.Visible = true;
                label_DataNasc.Visible = true;
               
            }
        }

        private void radioButton_PessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PessoaJuridica.Checked)
            {
                label_CPF.Visible = false;
                textBox_CPF.Visible = false;
                label_RG.Visible = false;
                textBox_RG.Visible = false;
                label_CNH.Visible = false;
                textBox_CNH.Visible = false;
                label_Naturalidade.Visible = false;
                label_Passaporte.Visible = false;
                textBox_Passaporte.Visible = false;
                label_DataNasc.Visible = false;
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

        private void label_DataNasc_Click(object sender, EventArgs e)
        {

        }
    }
}
