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
    public partial class ExibirVeiculo : Form
    {
        private long CodigoVeiculo = 0;
        public long codCatSelecionada = 0;
        public long codForSelecionado = 0;
        public ExibirVeiculo()
        {
           
            InitializeComponent();
        }

        public ExibirVeiculo(long codigo)
        {
            CodigoVeiculo = codigo;
            InitializeComponent();

            Veiculo veiculo = new VeiculoService().BuscarVeiculo(codigo);

            Documento documento = new VeiculoService().BuscarDocumento(codigo);

            VeiculoTemFornecedor veiculoTemFornecedor = new VeiculoService().VeiculoTemFornecedor(codigo);
          
            Fornecedor fornecedor = new FornecedorService().BuscarFornecedor(veiculoTemFornecedor.CodigoFornecedor);

            Categoria categoria = new CategoriaService().Buscar(veiculo.CodigoCategoria);

            //Fornecedor
            textBox_Fornecedor.Text = fornecedor.NomeFantasia;
            codForSelecionado = fornecedor.Id;


            //Categoria
            textBox_Categoria.Text = categoria.Nome;
            codCatSelecionada = categoria.CodigoCategoria;
            //Documento
            textBox_Chassi.Text = documento.Chassi;
            textBox_Placa.Text = documento.Placa;
            textBox_RENAVAM.Text = documento.Renavam;
            comboBox_MesLic.SelectedIndex = comboBox_MesLic.FindStringExact(documento.MesDataLicenciamento);
            TextBox_AnoLic.Text = documento.AnoDataLicenciamento;

            //Veiculo
            comboBox_Combustivel.SelectedIndex = comboBox_Combustivel.FindStringExact(veiculo.Combustivel);
            comboBox_Tanque.SelectedIndex = comboBox_Tanque.FindStringExact(veiculo.Tanque);
            textBox_Cor.Text = veiculo.Cor;
            TextBox_KM.Text = veiculo.KM;
            textBox_Marca.Text = veiculo.Marca;
            textBox_Modelo.Text = veiculo.Modelo;
            TextBox_AnoF.Text = veiculo.AnoFabricacao;

            checkBox_ArCondicionado.Checked = veiculo.ArCondicionado;
            checkBox_Trava.Checked = veiculo.TravaEletrica;
            checkBox_Vidro.Checked = veiculo.VidroEletrico;

            checkBox_Automatico.Checked = veiculo.Automatico;

            if (veiculo.DirecaoHidraulica)
            {
                checkBox_Hidraulica.Checked = true;
            } else
            {
                checkBox_Eletrica.Checked = true;
            }

            if (veiculo.Automatico)
            {
                checkBox_Automatico.Checked = true;
            } else
            {
                checkBox_Manual.Checked = true;
            }

            if (veiculo.QuantidadePortas == 4) {
                checkBox_4portas.Checked = true;
            } else
            {
                checkBox_2portas.Checked = true;
            }

        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
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
            "Excluir Veículo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
                if (new VeiculoService().Remover(CodigoVeiculo) != false)
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

            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (result2 == DialogResult.OK)
            {

                if (new VeiculoService().Atualizar(
                    CodigoVeiculo,
                    codCatSelecionada,
                    codForSelecionado,
                    textBox_Marca.Text,
                    textBox_Modelo.Text,
                    TextBox_KM.Text,
                    TextBox_AnoF.Text,
                    checkBox_Vidro.Checked,
                    checkBox_Trava.Checked,
                    checkBox_Automatico.Checked,
                    (checkBox_4portas.Checked ? 4 : 2),
                    checkBox_Hidraulica.Checked,
                    checkBox_ArCondicionado.Checked,
                    textBox_Cor.Text,
                    comboBox_Combustivel.Text,
                    comboBox_Tanque.Text,
                    codCatSelecionada,
                    textBox_Placa.Text,
                    textBox_RENAVAM.Text,
                    textBox_Chassi.Text,
                    comboBox_MesLic.Text,
                    TextBox_AnoLic.Text
                ))
                {
                    MessageBox.Show("Atualizado com sucesso! - ");
                    this.Close();
                }
              

            }


            if (result2 == DialogResult.Cancel)
            {

            }


        }

        private void comboBox_Fornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton_Pesquisar_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor selecionarF = new SelecionarFornecedor();

            if (selecionarF.ShowDialog() == DialogResult.OK)
            {
                codForSelecionado = selecionarF.codFornecedor;
                Fornecedor fornecedor = new FornecedorService().BuscarFornecedor(codForSelecionado);
                textBox_Fornecedor.Text = fornecedor.NomeFantasia;
                textBox_Fornecedor.BackColor = Color.PaleGreen;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             SelecionarCategoria selecionarC = new SelecionarCategoria();
            if (selecionarC.ShowDialog() == DialogResult.OK)
            {
                codCatSelecionada = selecionarC.codCategoria;
                Categoria categoria = new CategoriaService().Buscar(codCatSelecionada);
                textBox_Categoria.Text = categoria.Nome;
                textBox_Categoria.BackColor = Color.PaleGreen;
            }
        }
    }
}
