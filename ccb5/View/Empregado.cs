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
    public partial class Empregados : Form
    {
        public Empregados()
        {
            InitializeComponent();
        }

        private void toolStripButton_Novo_Click_1(object sender, EventArgs e)
        {
            CadastroEmpregados novo = new CadastroEmpregados();
            novo.ShowDialog();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empregados_Activated(object sender, EventArgs e)
        {
            dataGrid_Empregados.Rows.Clear();

            foreach (Empregado empregado in new EmpregadoService().Listar())
            {
                int index = dataGrid_Empregados.Rows.Add();
                DataGridViewRow dado = dataGrid_Empregados.Rows[index];

                EmpregadoService empregadoService = new EmpregadoService();

                Empregado pessoa =  empregadoService.BuscarEmpregado(empregado.Id);
                dado.Cells["Nome"].Value = pessoa.Nome;
                dado.Cells["Email"].Value = pessoa.Email;
                dado.Cells["Código"].Value = empregado.Id;
            }
        }

        private void dataGrid_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirEmpregado novo = new ExibirEmpregado(long.Parse(dataGrid_Empregados.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            novo.ShowDialog();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            BuscaEmpregado();
        }

        private void textBox_ValorBusca_Click(object sender, EventArgs e)
        {
            if(textBox_ValorBusca.Text == "Digite Nome.")
            {
                textBox_ValorBusca.Text = "";
            }
        }

        private void textBox_ValorBusca_KeyUp(object sender, KeyEventArgs e)
        {
            BuscaEmpregado();
        }

        private void BuscaEmpregado()
        {
            if (textBox_ValorBusca.Text.Trim().Equals("")) return;

            dataGrid_Empregados.Rows.Clear();
            List<Empregado> empregados = new Search().Empregado(textBox_ValorBusca.Text.ToLower());

            foreach (Empregado empregado in empregados)
            {
                int index = dataGrid_Empregados.Rows.Add();
                DataGridViewRow dado = dataGrid_Empregados.Rows[index];
                dado.Cells["Nome"].Value = empregado.Nome;
                dado.Cells["Email"].Value = empregado.Email;
                dado.Cells["Código"].Value = empregado.Id;
            }
        }
    }
}
