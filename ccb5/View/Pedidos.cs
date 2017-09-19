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
    public partial class Pedidos : Form
    {
        private string nomeuser;
        public Pedidos(string nomeusuario)
        {
            nomeuser = nomeusuario;
            InitializeComponent();
        }


        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            dataGridView_Pedidos.Rows.Clear();

            foreach (Reserva reserva in new PedidoService().Pesquisar(textBox_ValorBusca.Text))
            {
                int index = dataGridView_Pedidos.Rows.Add();
                DataGridViewRow dado = dataGridView_Pedidos.Rows[index];

                ClienteService clienteService = new ClienteService();
                VeiculoService veiculoService = new VeiculoService();
                PedidoService pedidoService = new PedidoService();
                Veiculo veiculo = veiculoService.BuscarVeiculo(reserva.CodigoVeiculo);

                string tipoPessoa = clienteService.TipoDePessoa(reserva.CodigoCliente);

                dado.Cells["CodigoPedido"].Value = reserva.NumeroReserva;
                dado.Cells["Status"].Value = pedidoService.StatusDaReserva(reserva.Status);
                dado.Cells["DataReserva"].Value = reserva.DataReserva;
                dado.Cells["DataEntrega"].Value = reserva.DataEntrega;
                dado.Cells["DataRetirada"].Value = reserva.DataRetirada;
                if (tipoPessoa == "PF")
                {
                    PessoaFisica pessoaFisica = clienteService.BuscarPessoaFisica(reserva.CodigoCliente);
                    dado.Cells["Cliente"].Value = pessoaFisica.Nome;

                }
                else if (tipoPessoa == "PJ")
                {
                    PessoaJuridica pessoaJuridica = clienteService.BuscarPessoaJuridica(reserva.CodigoCliente);
                    dado.Cells["Cliente"].Value = pessoaJuridica.NomeFantasia;
                }

                dado.Cells["Veiculo"].Value = veiculo.Modelo;
                dado.Cells["Valor"].Value = reserva.ValorLocacao;

            }
        }

        private void Pedidos_Activated(object sender, EventArgs e)
        {
            dataGridView_Pedidos.Rows.Clear();

            foreach (Reserva reserva in new PedidoService().Listar())
            {
                int index = dataGridView_Pedidos.Rows.Add();
                DataGridViewRow dado = dataGridView_Pedidos.Rows[index];

                ClienteService clienteService = new ClienteService();
                VeiculoService veiculoService = new VeiculoService();
                PedidoService pedidoService = new PedidoService();
                Veiculo veiculo = veiculoService.BuscarVeiculo(reserva.CodigoVeiculo);
 
                string tipoPessoa = clienteService.TipoDePessoa(reserva.CodigoCliente);

                dado.Cells["CodigoPedido"].Value = reserva.NumeroReserva;
                dado.Cells["Status"].Value = pedidoService.StatusDaReserva(reserva.Status);
                dado.Cells["DataReserva"].Value = reserva.DataReserva;
                dado.Cells["DataEntrega"].Value = reserva.DataEntrega;
                dado.Cells["DataRetirada"].Value = reserva.DataRetirada;
                if  (tipoPessoa == "PF")
                {
                    PessoaFisica pessoaFisica = clienteService.BuscarPessoaFisica(reserva.CodigoCliente);
                    dado.Cells["Cliente"].Value = pessoaFisica.Nome;

                } else if (tipoPessoa == "PJ")
                {
                    PessoaJuridica pessoaJuridica = clienteService.BuscarPessoaJuridica(reserva.CodigoCliente);
                    dado.Cells["Cliente"].Value = pessoaJuridica.NomeFantasia;
                }
                
                dado.Cells["Veiculo"].Value = veiculo.Modelo;
                dado.Cells["Valor"].Value = reserva.ValorLocacao;

            }
        }

        private void dataGridView_Pedidos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ExibirPedido novo = new ExibirPedido(long.Parse(dataGridView_Pedidos.Rows[e.RowIndex].Cells["CodigoPedido"].Value.ToString()));
            novo.ShowDialog();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            Locacao novo = new Locacao(nomeuser);
            novo.Show();
        }

        private void textBox_ValorBusca_Click(object sender, EventArgs e)
        {
            if (textBox_ValorBusca.Text == "Digite Nº Pedido,Nome Cliente,Razão Social,CNPJ,CPF.")
            {
                textBox_ValorBusca.Text = "";
            }
        }
    }
}
