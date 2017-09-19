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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirCategoria nova = new ExibirCategoria();
            nova.Show();
        }

        private void toolStripButton_Nova_Click(object sender, EventArgs e)
        {
            NovaCategoria nova = new NovaCategoria();
            nova.ShowDialog();
        }

        private void dataGridView_Categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirCategoria nova = new ExibirCategoria(long.Parse(dataGridView_Categoria.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            nova.ShowDialog();
        }

        private void textBox_ValorBusca_Click(object sender, EventArgs e)
        {
            if (textBox_ValorBusca.Text == "Digite Nome,Valor.")
            {
                textBox_ValorBusca.Text = "";
            }
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            dataGridView_Categoria.Rows.Clear();

            foreach (Categoria categoria in new CategoriaService().Pesquisar(textBox_ValorBusca.Text))
            {
                int index = dataGridView_Categoria.Rows.Add();
                DataGridViewRow dado = dataGridView_Categoria.Rows[index];
                dado.Cells["Código"].Value = categoria.CodigoCategoria;
                dado.Cells["Nome"].Value = categoria.Nome;
                dado.Cells["Valor"].Value = categoria.Valor;
            }
        }

        private void Categorias_Activated_1(object sender, EventArgs e)
        {
            dataGridView_Categoria.Rows.Clear();

            foreach (Categoria categoria in new CategoriaService().Listar())
            {
                int index = dataGridView_Categoria.Rows.Add();
                DataGridViewRow dado = dataGridView_Categoria.Rows[index];
                dado.Cells["Código"].Value = categoria.CodigoCategoria;
                dado.Cells["Nome"].Value = categoria.Nome;
                dado.Cells["Valor"].Value = categoria.Valor;
            }
        }

        private void Categorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView_Categoria.Rows.Clear();

                foreach (Categoria categoria in new CategoriaService().Pesquisar(textBox_ValorBusca.Text))
                {
                    int index = dataGridView_Categoria.Rows.Add();
                    DataGridViewRow dado = dataGridView_Categoria.Rows[index];
                    dado.Cells["Código"].Value = categoria.CodigoCategoria;
                    dado.Cells["Nome"].Value = categoria.Nome;
                    dado.Cells["Valor"].Value = categoria.Valor;
                }
            }
        }
    }
}
