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

namespace ccb5.View
{
    public partial class RelatorioPedidos : Form
    {
        public RelatorioPedidos()
        {
            InitializeComponent();
        }

        private void RelatorioPedidos_Load(object sender, EventArgs e)
        {
            ReservaBindingSource.DataSource = new PedidoService().Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
