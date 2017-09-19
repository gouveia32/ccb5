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
    public partial class Locacao : Form
    {
        private Veiculo veiculo;
        private long codCliente = 0;
        private long codVeiculo = 0;
        private string formapagamento;
        private string nomeuser;

        public Locacao(string nomeusuario)
        {
            nomeuser = nomeusuario;
            InitializeComponent();
        }
        private void toolStripButton_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a locação?",
            "Efetuar Nova Locação",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if (radioButton_Boleto.Checked) { formapagamento = "Boleto"; };
                if (radioButton_Dinheiro.Checked) { formapagamento = "Dinheiro"; };
                if (radioButton_CartaoDebito.Checked) { formapagamento = "Cartão Debito"; };
                if (radioButton_CartaoCredito.Checked) { formapagamento = "Cartão Credito"; };

                if (textBox_CheckList.Text == "Realizado")
                {
                    if (new LocacaoService().EfetuarReserva(codVeiculo, codCliente,
                        dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, comboBox_TipoRetirada.Text, formapagamento, textBox_ValorPedido.Text, Autenticacao.UsuarioLogado) != false)
                    {
                        MessageBox.Show("Locação Inserida com sucesso!");
                        this.Close();
                    }
                    else MessageBox.Show("Ops! Verifique se todos os itens estão preenchidos e se o valor do pedido foi calculado");
                }else MessageBox.Show("Efetue o CheckList do veiculo antes de efetuar a locação! Aproveite e verifique se os demais campos estão preenchidos");
                if (result1 == DialogResult.Cancel)
                {

                }
            }
        }

        private void toolStripButton_CheckList_Click(object sender, EventArgs e)
        {
            if (veiculo != null)
            {
                CheckList novo = new CheckList(codVeiculo);
                if (novo.ShowDialog() == DialogResult.OK) { textBox_CheckList.Text = "Realizado"; }
            }
            else MessageBox.Show("Selecione um veiculo!");

        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_PesquisarC_Click(object sender, EventArgs e)
        {
            SelecionarCliente novo = new SelecionarCliente();
            novo.ShowDialog();
            if(novo.CodigoCliente != 0) { 
            textBox_Cliente.BackColor = Color.PaleGreen; 
            textBox_Cliente.Text = new LocacaoService().BuscarCliente(novo.CodigoCliente);
            codCliente = novo.CodigoCliente;
            }
        }

        private void toolStripButton_PesquisarV_Click(object sender, EventArgs e)
        {
            SelecionarVeiculo novo = new SelecionarVeiculo();
            novo.ShowDialog();
            if(novo.CodigoVeiculo != 0) { 
            veiculo = new LocacaoService().BuscarVeiculo(novo.CodigoVeiculo);
            codVeiculo = novo.CodigoVeiculo;
            textBox_Veiculo.Text = veiculo.Modelo;
            textBox_Veiculo.BackColor = Color.PaleGreen;
            }
        }

        private void dateTimePicker_Retirada_ValueChanged(object sender, EventArgs e)
        {
            if (codVeiculo != 0)
            {
                if (new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, codVeiculo) == 1)
                {
                    MessageBox.Show("A data de retirada não pode ser maior que a de entrega!!");
                }
                if (new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, codVeiculo) != 1 && new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, veiculo.CodigoVeiculo) != 0)
                {
                    textBox_ValorPedido.Text = new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, veiculo.CodigoVeiculo).ToString();
                }
            }
            else MessageBox.Show("Selecione um veiculo !!");
        }

        private void dateTimePicker_Entrega_ValueChanged(object sender, EventArgs e)
        {
            if (codVeiculo != 0)
            {
                if (new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, codVeiculo) == 1)
                {
                    MessageBox.Show("A data de retirada não pode ser maior que a de entrega!!");
                }
                if (new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, codVeiculo) != 1 && new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, veiculo.CodigoVeiculo) != 0)
                {
                    textBox_ValorPedido.Text = new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, veiculo.CodigoVeiculo).ToString();
                }
            }
            else MessageBox.Show("Selecione um veiculo !!");
        }
    }
}

