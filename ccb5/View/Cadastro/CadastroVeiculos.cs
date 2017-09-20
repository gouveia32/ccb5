using Persistencia.DAO;
using Persistencia.Service;
using Persistencia.Modelo;
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
    public partial class CadastroVeiculos : Form
    {
        public long codCatSelecionada = 0;
        public long codForSelecionado = 0;
        public CadastroVeiculos()
        {
            InitializeComponent();

        }
        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void toolStripButton_PesquisarF_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor selecionarF = new SelecionarFornecedor();

            if (selecionarF.ShowDialog() == DialogResult.OK)
            {
                codForSelecionado = selecionarF.codFornecedor;
                Fornecedor fornecedor = new FornecedorDAO().Buscar(codForSelecionado);
                textBox_Fornecedor.Text = fornecedor.NomeFantasia;
                textBox_Fornecedor.BackColor = Color.PaleGreen;
            }
        }

        private void toolStripButton_BuscarC_Click(object sender, EventArgs e)
        {
            SelecionarCategoria selecionarC = new SelecionarCategoria();
            if (selecionarC.ShowDialog() == DialogResult.OK)
            {
                codCatSelecionada = selecionarC.codCategoria;
                Categoria categoria = new CategoriaDAO().Buscar(codCatSelecionada);
                textBox_Categoria.Text = categoria.Nome;
                textBox_Categoria.BackColor = Color.PaleGreen;
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

                long i = new VeiculoService().Inserir(
                    textBox_Marca.Text,
                    textBox_Modelo.Text,
                    textBox_KM.Text,
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
                    TextBox_AnoLic.Text,
                    codForSelecionado
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
    }
}

