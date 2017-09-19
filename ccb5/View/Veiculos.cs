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
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroVeiculos novo = new CadastroVeiculos();
            novo.ShowDialog();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirVeiculo novo = new ExibirVeiculo();
            novo.ShowDialog();
        }

        private void Veiculos_Activated(object sender, EventArgs e)
        {
            dataGrid_Veiculo.Rows.Clear();

            foreach (Veiculo veiculo in new VeiculoService().Listar())
            {
                int index = dataGrid_Veiculo.Rows.Add();
                DataGridViewRow dado = dataGrid_Veiculo.Rows[index];
                dado.Cells["Código"].Value = veiculo.CodigoVeiculo;
                dado.Cells["Marca"].Value = veiculo.Marca;
                dado.Cells["Modelo"].Value = veiculo.Modelo;

                Documento documento = new VeiculoService().BuscarDocumento(veiculo.CodigoVeiculo);
            
                dado.Cells["Placa"].Value = documento.Placa;
                dado.Cells["Renavam"].Value = documento.Renavam;
                
            }
           
        }

        private void dataGrid_Veiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirVeiculo novo = new ExibirVeiculo(long.Parse(dataGrid_Veiculo.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            novo.ShowDialog();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
                dataGrid_Veiculo.Rows.Clear();

                foreach (Veiculo veiculo in new VeiculoService().Pesquisar(textBox_ValorBusca.Text))
                {
                    int index = dataGrid_Veiculo.Rows.Add();
                    DataGridViewRow dado = dataGrid_Veiculo.Rows[index];
                    dado.Cells["Código"].Value = veiculo.CodigoVeiculo;
                    dado.Cells["Marca"].Value = veiculo.Marca;
                    dado.Cells["Modelo"].Value = veiculo.Modelo;

                    Documento documento = new VeiculoService().BuscarDocumento(veiculo.CodigoVeiculo);

                    dado.Cells["Placa"].Value = documento.Placa;
                    dado.Cells["Renavam"].Value = documento.Renavam;

                }
            }

        private void textBox_ValorBusca_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ValorBusca.Text == "Digite Marca ou Modelo.")
            {
                textBox_ValorBusca.Text = "";
            }
        }

        private void Veiculos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGrid_Veiculo.Rows.Clear();

                foreach (Veiculo veiculo in new VeiculoService().Pesquisar(textBox_ValorBusca.Text))
                {
                    int index = dataGrid_Veiculo.Rows.Add();
                    DataGridViewRow dado = dataGrid_Veiculo.Rows[index];
                    dado.Cells["Código"].Value = veiculo.CodigoVeiculo;
                    dado.Cells["Marca"].Value = veiculo.Marca;
                    dado.Cells["Modelo"].Value = veiculo.Modelo;

                    Documento documento = new VeiculoService().BuscarDocumento(veiculo.CodigoVeiculo);

                    dado.Cells["Placa"].Value = documento.Placa;
                    dado.Cells["Renavam"].Value = documento.Renavam;

                }
            }
        }

        private void textBox_ValorBusca_Click(object sender, EventArgs e)
        {
            if (textBox_ValorBusca.Text == "Digite Marca ou Modelo.")
            {
                textBox_ValorBusca.Text = "";
            }
        }
    }
}

