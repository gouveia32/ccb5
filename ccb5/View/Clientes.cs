using Persistencia.DAO;
using Persistencia.Modelo;
using Persistencia.Service;
using Persistencia.Util;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void toolStripButton_Novo_Click_1(object sender, EventArgs e)
        {
            CadastroClientes novo = new CadastroClientes();
            novo.ShowDialog();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Activated(object sender, EventArgs e)
        {
            dataGrid_Clientes.Rows.Clear();

            foreach (Cliente cliente in new ClienteService().Listar())
            {
                int index = dataGrid_Clientes.Rows.Add();
                DataGridViewRow dado = dataGrid_Clientes.Rows[index];

                ClienteService clienteService = new ClienteService();

                string tipoPessoa = clienteService.TipoDePessoa(cliente.CodigoCliente);

                if (tipoPessoa == "PF")
                {
                    PessoaFisica pessoaFisica =  clienteService.BuscarPessoaFisica(cliente.CodigoCliente);
                    dado.Cells["Tipo"].Value = "Pessoa Física";
                    dado.Cells["Nome"].Value = pessoaFisica.Nome;
                    dado.Cells["Documento"].Value = pessoaFisica.RG;
                    dado.Cells["Código"].Value = cliente.CodigoCliente;

                } else if (tipoPessoa == "PJ")
                {
                    PessoaJuridica pessoaJuridica = clienteService.BuscarPessoaJuridica(cliente.CodigoCliente); 
                    dado.Cells["Tipo"].Value = "Pessoa Juridica";
                    dado.Cells["Nome"].Value = pessoaJuridica.NomeFantasia;
                    dado.Cells["Documento"].Value = pessoaJuridica.CNPJ;
                    dado.Cells["Código"].Value = cliente.CodigoCliente;
                }

            }
        }

        private void dataGrid_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirCliente novo = new ExibirCliente(long.Parse(dataGrid_Clientes.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            novo.ShowDialog();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            dataGrid_Clientes.Rows.Clear();
            List<PessoaFisica> pessoasfisica = new Search().PessoaFisica(textBox_ValorBusca.Text);
            List<PessoaJuridica> pessoasjuridica = new Search().PessoaJuridica(textBox_ValorBusca.Text);

            if (textBox_ValorBusca.Text.Trim().Equals(""))
            {
                pessoasfisica = new PessoaFisicaDAO().Listar();
                pessoasjuridica = new PessoaJuridicaDAO().Listar();
            }

            foreach (PessoaFisica pessoafisica in pessoasfisica)
            {
                int index = dataGrid_Clientes.Rows.Add();
                DataGridViewRow dado = dataGrid_Clientes.Rows[index];
                dado.Cells["Tipo"].Value = "Pessoa Física";
                dado.Cells["Documento"].Value = pessoafisica.CPF;
                dado.Cells["Nome"].Value = pessoafisica.Nome;
            }

            foreach (PessoaJuridica pessoafisica in pessoasjuridica)
            {
                int index = dataGrid_Clientes.Rows.Add();
                DataGridViewRow dado = dataGrid_Clientes.Rows[index];
                dado.Cells["Tipo"].Value = "Pessoa Juridica";
                dado.Cells["Documento"].Value = pessoafisica.CNPJ;
                dado.Cells["Nome"].Value = pessoafisica.NomeFantasia;
            }
        }

        private void textBox_ValorBusca_Click(object sender, EventArgs e)
        {
            if(textBox_ValorBusca.Text == "Digite Nome,CPF,RG,Razão Social,CNPJ,Nome Fantasia.")
            {
                textBox_ValorBusca.Text = "";
            }
        }

        private void Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            dataGrid_Clientes.Rows.Clear();
            List<PessoaFisica> pessoasfisica = new Search().PessoaFisica(textBox_ValorBusca.Text);
            List<PessoaJuridica> pessoasjuridica = new Search().PessoaJuridica(textBox_ValorBusca.Text);

            if (textBox_ValorBusca.Text.Trim().Equals(""))
            {
                pessoasfisica = new PessoaFisicaDAO().Listar();
                pessoasjuridica = new PessoaJuridicaDAO().Listar();
            }

            foreach (PessoaFisica pessoafisica in pessoasfisica)
            {
                int index = dataGrid_Clientes.Rows.Add();
                DataGridViewRow dado = dataGrid_Clientes.Rows[index];
                dado.Cells["Tipo"].Value = "Pessoa Física";
                dado.Cells["Documento"].Value = pessoafisica.CPF;
                dado.Cells["Nome"].Value = pessoafisica.Nome;
            }

            foreach (PessoaJuridica pessoafisica in pessoasjuridica)
            {
                int index = dataGrid_Clientes.Rows.Add();
                DataGridViewRow dado = dataGrid_Clientes.Rows[index];
                dado.Cells["Tipo"].Value = "Pessoa Juridica";
                dado.Cells["Documento"].Value = pessoafisica.CNPJ;
                dado.Cells["Nome"].Value = pessoafisica.NomeFantasia;
            }
        }
    }
}
