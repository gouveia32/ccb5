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
    public partial class ExibirPedido : Form
    {
        private long CodigoReserva = 0;
        private long CodVeiculo = 0;
        private String tipoPessoa = "";

        public ExibirPedido()
        {
            InitializeComponent();
        }
        public ExibirPedido(long codigo)
        {

            CodigoReserva = codigo;
            InitializeComponent();

            PedidoService pedidoService = new PedidoService();
            VeiculoService veiculoService = new VeiculoService();
            ClienteService clienteService = new ClienteService();

            Reserva reserva = pedidoService.Buscar(codigo);
            Veiculo veiculo = veiculoService.BuscarVeiculo(reserva.CodigoVeiculo);
            Usuario usuario = new UsuarioService().Busca(reserva.CodigoUsuario);

            CodVeiculo = reserva.CodigoVeiculo;
            tipoPessoa = clienteService.TipoDePessoa(reserva.CodigoCliente);
            veiculo.CodigoVeiculo = codigo;

            if (pedidoService.VerificaStatusReserva(reserva.Status) == true)
            {
                toolStripButton_Entrega.Visible = true;
            }
            else
            {
                toolStripButton_Entrega.Visible = false;
            }

            if (tipoPessoa == "PF")
            {
                PessoaFisica pessoaFisica = clienteService.BuscarPessoaFisica(reserva.CodigoCliente);
                textBox_Cliente.Text = pessoaFisica.Nome;

            }
            else if (tipoPessoa == "PJ")
            {
                PessoaJuridica pessoaJuridica = clienteService.BuscarPessoaJuridica(reserva.CodigoCliente);
                textBox_Cliente.Text = pessoaJuridica.NomeFantasia;
            }


            textBoxData.Text = reserva.DataReserva.ToString();
            textBoxFormaPagamento.Text = reserva.FormaPagamento;
            textBoxSituacao.Text = new PedidoService().StatusDaReserva(reserva.Status);
            textBoxTipoRetirada.Text = reserva.TipoRetirada;
            
            textBoxusuario.Text = usuario.Nome;

            textBox_NPedido.Text = reserva.NumeroReserva.ToString();
            textBox_Valor.Text = reserva.ValorLocacao.ToString("C");

            dataGridView_Pedido.Rows.Clear();

            int index = dataGridView_Pedido.Rows.Add();
            DataGridViewRow dado = dataGridView_Pedido.Rows[index];

            dado.Cells["ReservaId"].Value = reserva.NumeroReserva;
            dado.Cells["DataReserva"].Value = reserva.DataReserva;
            dado.Cells["DataEntrega"].Value = reserva.DataEntrega;
            dado.Cells["DataRetirada"].Value = reserva.DataRetirada;
            dado.Cells["Veiculo"].Value = veiculo.Modelo;
            dado.Cells["ValorCategoria"].Value = reserva.DataEntrega;
            dado.Cells["Total"].Value = reserva.ValorLocacao.ToString("C"); 

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a impressão do pedido?",
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

        private void toolStripButton_Contrato_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja emitir o contrato?",
             "Contrato",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }


        private void toolStripButton_Entrega_Click(object sender, EventArgs e)
        {

            EntregaVeiculo novo = new EntregaVeiculo(CodVeiculo, CodigoReserva, this);
            novo.Show();


        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
