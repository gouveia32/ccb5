using MySql.Data.MySqlClient;
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
    public partial class TelaPrincipal : Form 
    {
        private String loginName;
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        public TelaPrincipal(string usuario)
        {
            Usuario user = new UsuarioService().BuscaNome(usuario);
            loginName = user.Nome;
            InitializeComponent();
        }


        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente sair do sistema?",
            "Sair do sistema",
            MessageBoxButtons.OKCancel);
            if(result1 == DialogResult.OK)
            {
                for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
                {
                    if (Application.OpenForms[intIndex] != this)
                        Application.OpenForms[intIndex].Close();
                }
                this.Close();
            }
            if (result1 == DialogResult.Cancel)
            {

            }

        }

        private void toolStripButton_Categorias_Click(object sender, EventArgs e)
        {
            Categorias nova = new Categorias();
            nova.ShowDialog();
        }

        private void toolStripButton_TrocarUsuario_Click(object sender, EventArgs e)
        {
            Autenticacao login = new Autenticacao();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Usuario user = new UsuarioDAO().BuscarNome(login.logado);
                loginName = user.Nome;
                toolStripStatusLabel1.Text = "Usuario:  " + loginName;
            }
        }

        private void toolStripButton_Sobre_Click(object sender, EventArgs e)
        {
            Sobre novo = new Sobre();
            novo.ShowDialog();
        }

        private void toolStripButton_Clientes_Click(object sender, EventArgs e)
        {
            Clientes novo = new Clientes();
            novo.ShowDialog();
        }

        private void toolStripButton_Veiculos_Click(object sender, EventArgs e)
        {
            Veiculos novo = new Veiculos();
            novo.ShowDialog();
        }

        private void toolStripButton_Locacao_Click(object sender, EventArgs e)
        {
            Locacao novo = new Locacao(loginName);
            novo.ShowDialog();
        }

        private void toolStripButton_Pedidos_Click(object sender, EventArgs e)
        {
            Pedidos novo = new Pedidos(loginName);
            novo.ShowDialog();
        }

        private void toolStripButton_Relatorios_Click(object sender, EventArgs e)
        {
            Relatorios novo = new Relatorios();
            novo.ShowDialog();
        }

        private void toolStripButton_Fornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores novo = new Fornecedores();
            novo.ShowDialog();
        }

        private void toolStripButton_Usuarios_Click(object sender, EventArgs e)
        {
            Usuarios novo = new Usuarios();
            novo.ShowDialog();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
                toolStripStatusLabel1.Text = "Usuario:  " + loginName;
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog_Importar.AddExtension = true;
            openFileDialog_Importar.DefaultExt = ".sql";
            openFileDialog_Importar.Filter = "SQL Files (*.sql)|*.sql";
            openFileDialog_Importar.Title = "Importa Backup";
            openFileDialog_Importar.FileName = "Backup.sql";
            if (openFileDialog_Importar.ShowDialog() == DialogResult.OK)
            {
                new Utils().Backup(openFileDialog_Importar.FileName, Utils.OptionsBackup.Import);
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog_Exportar.AddExtension = true;
            saveFileDialog_Exportar.DefaultExt = ".sql";
            saveFileDialog_Exportar.Filter = "SQL Files (*.sql)|*.sql";
            saveFileDialog_Exportar.Title = "Exporta Backup";
            saveFileDialog_Exportar.FileName = "Backup.sql";

            if (saveFileDialog_Exportar.ShowDialog() == DialogResult.OK)
            {
                new Utils().Backup(saveFileDialog_Exportar.FileName, Utils.OptionsBackup.Export);
            }
        }

        private void btnEmpregado_Click(object sender, EventArgs e)
        {
            Empregados novo = new Empregados();
            novo.ShowDialog();
        }
    }
}

