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
    public partial class ExibirCategoria : Form
    {
        private long CodigoCategoria = 0;

        public ExibirCategoria()
        {
            InitializeComponent();
        }

        public ExibirCategoria(long codigo)
        {
            CodigoCategoria = codigo;
            InitializeComponent();
            Categoria categoria = new CategoriaService().Buscar(CodigoCategoria);
            textBox_Nome.Text = categoria.Nome;
            textBox_Valor.Text = categoria.Valor.ToString();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar as alterações?",
            "Salvar Alterações",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
                if (new CategoriaService().Atualizar(CodigoCategoria, textBox_Nome.Text, textBox_Valor.Text) != false)
                    MessageBox.Show("Categoria alterada com Sucesso");
                this.Close();
            }
            else
                MessageBox.Show("Verifique as informações inseridas!");

            if (result2 == DialogResult.Cancel)
            { }
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente excluir?",
            "Exclusão de Categoria",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
              if(new CategoriaService().Remover(CodigoCategoria) != false)
                {
                    MessageBox.Show("Categoria excluida com sucesso!");
                    this.Close();
                } else MessageBox.Show("Categoria invalida!");
            }
        }
    }
}
