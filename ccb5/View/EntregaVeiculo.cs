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
    public partial class EntregaVeiculo : Form
    {
        private long CodigoVeiculo = 0;
        private long CodigoReserva = 0;
        private ExibirPedido exibirPedido;

        public EntregaVeiculo(long codVeiculo, long codReserva, ExibirPedido telaPedido)
        {
            exibirPedido = telaPedido;

            CodigoVeiculo = codVeiculo;
            CodigoReserva = codReserva;
            InitializeComponent();
        }
        private void toolStripButton_Confirmar_Click(object sender, EventArgs e)
        {

            EntregaVeiculoService entregaService = new EntregaVeiculoService();
            VeiculoService veiculoService = new VeiculoService();

            if (entregaService.verificaChecklist(textBox_CheckList.Text))
            {

                Reserva reserva = entregaService.buscarReserva(CodigoReserva);
                Veiculo veiculo = veiculoService.BuscarVeiculo(reserva.CodigoVeiculo);
                if (entregaService.devolucao(reserva, veiculo, dateTimePicker_DataEntrega.Value) == true)
                {
                    MessageBox.Show("Devolução Realizada com sucesso!");
                    ExibirPedido exibePedido = new ExibirPedido();
                    exibirPedido.Close();
                    Close();
                }
   
            }
            else
            {
                MessageBox.Show("Favor Realizar o checklist do veículo");
            }
            
      
        }

        private void toolStripButton_CheckList_Click(object sender, EventArgs e)
        {

            CheckList novo = new CheckList(CodigoVeiculo);
            if (novo.ShowDialog() == DialogResult.OK) { textBox_CheckList.Text = "Realizado"; }

        }

        private void toolStripButton_Pesquisar_Click(object sender, EventArgs e)
        {
            SelecionarVeiculo novo = new SelecionarVeiculo();
            novo.Show();
        }

        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
