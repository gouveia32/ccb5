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
    public partial class RelatorioUsuarios : Form
    {
        public RelatorioUsuarios()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelatorioUsuarios_Load(object sender, EventArgs e)
        {
            UsuarioBindingSource.DataSource = new UsuarioService().Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
