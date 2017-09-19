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
    public partial class CheckList : Form
    {
        private Veiculo veiculo;
        RadioButton[] radios;

        public CheckList()
        {
            InitializeComponent();
            radios = new[] { radioButton_CBuzina, radioButton_CBancos, radioButton_CBateria, radioButton_CChaveRoda, radioButton_CEstepe, radioButton_CExtintor, radioButton_CFarol, radioButton_CLataria, radioButton_CLuzFreio, radioButton_CMacaco, radioButton_CPainel, radioButton_CParabrisa, radioButton_CParachoques, radioButton_CPinturas, radioButton_CSetas, radioButton_CTriangulo };
        }

        public CheckList(long cod)
        {
            InitializeComponent();
            radios = new[] { radioButton_CBuzina, radioButton_CBancos, radioButton_CBateria, radioButton_CChaveRoda, radioButton_CEstepe, radioButton_CExtintor, radioButton_CFarol, radioButton_CLataria, radioButton_CLuzFreio, radioButton_CMacaco, radioButton_CPainel, radioButton_CParabrisa, radioButton_CParachoques, radioButton_CPinturas, radioButton_CSetas, radioButton_CTriangulo };
            veiculo = new VeiculoDAO().Buscar(cod);
        }

        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            
           Close();
           
        }

        private void toolStripButton_Confirmar_Click(object sender, EventArgs e)
        {
            List<String> select_itens = new List<string>();

            foreach (RadioButton radio in radios)
            {
                if (radio.Checked)
                    select_itens.Add(radio.Name);
            }

            if (veiculo != null)
                if (new CheckListService().Inserir(veiculo.CodigoVeiculo, textBox_Observacoes.Text, 0, dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"), select_itens.ToArray()) != -1)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();

                }
        }

        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SelecionarVeiculo selecionarveiculo = new SelecionarVeiculo();
            selecionarveiculo.ShowDialog();

            veiculo = new VeiculoDAO().Buscar(selecionarveiculo.CodigoVeiculo);

            textBox_Veiculo.Text = veiculo.Modelo;
            textBox_KM.Text = veiculo.KM;
            comboBox_Tanque.Text = veiculo.Tanque;
        }

        private void CheckList_Activated(object sender, EventArgs e)
        {
            if (veiculo != null)
                if (new CheckListService().Verificar(veiculo.CodigoVeiculo))
                {
                    Dictionary<long, Object> itens = new CheckListService().Buscar(veiculo.CodigoVeiculo);
                    textBox_Veiculo.Text = veiculo.Modelo;
                    textBox_KM.Text = veiculo.KM;
                    comboBox_Tanque.Text = veiculo.Tanque;

                    foreach (RadioButton radio in radios)
                    {
                        foreach (ItemConformidade item in ((List<ItemConformidade>)itens[2]))
                            if (radio.Name == item.Item)
                                radio.Select();
                    }

                    dateTimePicker1.Text = ((VeiculoTemCheckList)itens[0]).DataChecagem;
                    textBox_Observacoes.Text = ((Persistencia.Modelo.CheckList)itens[1]).Observacao;
                }
                else
                {
                    textBox_Veiculo.Text = veiculo.Modelo;
                    textBox_KM.Text = veiculo.KM;
                    comboBox_Tanque.Text = veiculo.Tanque;
                }
        }
    }
}
