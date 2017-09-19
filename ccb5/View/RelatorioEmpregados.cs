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
    public partial class RelatorioEmpregados : Form
    {
        public RelatorioEmpregados()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelatorioEmpregados_Load(object sender, EventArgs e)
        {
            EmpregadoBindingSource.DataSource = new EmpregadoService().Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
