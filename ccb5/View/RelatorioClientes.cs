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
    public partial class RelatorioClientes : Form
    {
        public RelatorioClientes()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RelatorioClientes_Load(object sender, EventArgs e)
        {
            ClienteBindingSource.DataSource = new ClienteService().ListarPessoaFisica();
            PessoaJuridicaBindingSource.DataSource = new ClienteService().ListarPessoaJuridica();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
