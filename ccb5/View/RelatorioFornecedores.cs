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
    public partial class RelatorioFornecedores : Form
    {
        public RelatorioFornecedores()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelatorioFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorBindingSource.DataSource = new FornecedorService().Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
