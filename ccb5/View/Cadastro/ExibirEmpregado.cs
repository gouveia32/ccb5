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
    public partial class ExibirEmpregado : Form
    {
        private long Id = 0;
        private long EnderecoId = 0;
        public ExibirEmpregado()
        {
            InitializeComponent();
        }
        public ExibirEmpregado(long codigo)
        {
            Id = codigo;
            InitializeComponent();
            Empregado e = new EmpregadoService().BuscarEmpregado(Id);
            textBox_Nome.Text = e.Nome;
            textBox_Email.Text = e.Email;
            EnderecoId = e.EnderecoId;
            dateTimePicker_DataNascimento.Text = e.DataNascimento;
            dateTimePicker_DataAdmissao.Text = e.DataAdmissao;
            dateTimePicker_DataDemissao.Text = e.DataDemissao;

            TelefoneEmpregado telefone = new EmpregadoService().BuscarTelefone(Id);
            telefone.EmpregadoId = Id;
            textBox_Telefone.Text = telefone.Telefone;
            textBox_Celular.Text = telefone.Telefone;

            Endereco endereco = new EmpregadoService().BuscarEndereco(EnderecoId);
            textBox_CEP.Text = endereco.CEP;
            textBox_Logradouro.Text = endereco.Logradouro;
            textBox_N.Text = endereco.Numero;
            textBox_Bairro.Text = endereco.Bairro;
            textBox_Cidade.Text = endereco.Cidade;
            comboBox_Estado.Text = endereco.Estado;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja salvar as alterações no cadastro?",
            "Salvar Alterações",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {
                if (new EmpregadoService().Atualizar(Id,
                                                    textBox_Nome.Text,
                                                    textBox_CEP.Text,
                                                    dateTimePicker_DataNascimento.Value,
                                                    dateTimePicker_DataAdmissao.Value,
                                                    dateTimePicker_DataDemissao.Value,
                                                    textBox_Logradouro.Text,
                                                    textBox_Bairro.Text,
                                                    textBox_N.Text,
                                                    textBox_Cidade.Text,
                                                    comboBox_Estado.Text,
                                                    textBox_Email.Text,
                                                    textBox_Telefone.Text,
                                                    textBox_Celular.Text) != false)
                {
                    MessageBox.Show(" Empregado alterado com Sucesso", "Cadastro Alterado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else MessageBox.Show("Verifique os valores digitados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (result3 == DialogResult.Cancel)
            {

            }
        }


        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente excluir o cadastro?",
            "Excluir Fornecedor",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                

                if (new EmpregadoService().Remover(Id) != false)
                {
                    MessageBox.Show(" Empregado Removido com Sucesso", "Remoção de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                
            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja efetuar a impressão do cadastro?",
            "Impressão",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }
    }
}
