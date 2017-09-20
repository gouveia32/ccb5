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
    public partial class RelatorioVeiculos : Form
    {
        public RelatorioVeiculos()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelatorioVeiculos_Load(object sender, EventArgs e)
        {
            VeiculoBindingSource.DataSource = new VeiculoService().Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
