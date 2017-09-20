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
    public partial class SelecionarFornecedor : Form
    {
        public long codFornecedor;
        public SelecionarFornecedor()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroFornecedor novo = new CadastroFornecedor();
            novo.ShowDialog();
        }

        private void SelecionarFornecedor_Activated(object sender, EventArgs e)
        {
            dataGrid_Fornecedor.Rows.Clear();

            foreach (Fornecedor fornecedor in new FornecedorService().Listar())
            {
                int index = dataGrid_Fornecedor.Rows.Add();
                DataGridViewRow dado = dataGrid_Fornecedor.Rows[index];
                dado.Cells["Código"].Value = fornecedor.Id;
                dado.Cells["Nome"].Value = fornecedor.NomeFantasia;
                dado.Cells["Razao"].Value = fornecedor.RazaoSocial;
                dado.Cells["CNPJ"].Value = fornecedor.CNPJ;
            }
        }

        private void dataGrid_Fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Fornecedor fornecedor = new FornecedorDAO().Buscar(long.Parse(dataGrid_Fornecedor.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            codFornecedor = fornecedor.Id;
            this.DialogResult = DialogResult.OK;
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            dataGrid_Fornecedor.Rows.Clear();

            foreach (Fornecedor fornecedor in new FornecedorService().Buscar(textBox_ValorBusca.Text))
            {
                int index = dataGrid_Fornecedor.Rows.Add();
                DataGridViewRow dado = dataGrid_Fornecedor.Rows[index];
                dado.Cells["Código"].Value = fornecedor.Id;
                dado.Cells["Nome"].Value = fornecedor.NomeFantasia;
                dado.Cells["Razao"].Value = fornecedor.RazaoSocial;
                dado.Cells["CNPJ"].Value = fornecedor.CNPJ;
            }
        }

        private void textBox_ValorBusca_Click(object sender, EventArgs e)
        {
            if (textBox_ValorBusca.Text == "Digite Nome Fantasia,Razão Social,CNPJ.")
            {
                textBox_ValorBusca.Text = "";
            }
        }

        private void SelecionarFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGrid_Fornecedor.Rows.Clear();

                foreach (Fornecedor fornecedor in new FornecedorService().Buscar(textBox_ValorBusca.Text))
                {
                    int index = dataGrid_Fornecedor.Rows.Add();
                    DataGridViewRow dado = dataGrid_Fornecedor.Rows[index];
                    dado.Cells["Código"].Value = fornecedor.Id;
                    dado.Cells["Nome"].Value = fornecedor.NomeFantasia;
                    dado.Cells["Razao"].Value = fornecedor.RazaoSocial;
                    dado.Cells["CNPJ"].Value = fornecedor.CNPJ;
                }
            }
        }
    }
}
