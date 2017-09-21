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
    public partial class AjustarTabelas : Form
    {
        private Connection _connection;

        public AjustarTabelas()
        {
            _connection = new Connection();

            InitializeComponent();

        }

        public AjustarTabelas(long codigo)
        {
            InitializeComponent();   
        }
  
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmpregado_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT count(id) AS qt FROM EMPREGADOS;";
                    MySqlDataReader leitor = comando.ExecuteReader();
                    if (leitor.HasRows)
                    {
                        leitor.Read();
                        progressBar1.Maximum = Convert.ToInt32(leitor["qt"].ToString());
                        progressBar1.Value = 0;
                        progressBar1.Visible = true;
                        leitor.Close();
                    }
                    else return;

                    comando.CommandText = "SELECT id,nome,funcao,nascimento,admissao,demissao,endereco,cidade,uf,cep,telefone1,telefone2,telefone3,email,obs FROM EMPREGADOS;";
                    leitor = comando.ExecuteReader();

                    
                    while (leitor.Read())
                    {
                        progressBar1.Value += 1;
                        
                        EmpregadoService empregadoService = new EmpregadoService();

                        new EmpregadoService().Inserir(
                                    leitor["nome"].ToString(),
                                    leitor["cep"].ToString(),
                                    leitor["nascimento"].ToString(),
                                    leitor["admissao"].ToString(),
                                    leitor["demissao"].ToString(),
                                    leitor["endereco"].ToString(),
                                    "",
                                    "0",
                                    leitor["cidade"].ToString(),
                                    leitor["uf"].ToString(),
                                    leitor["email"].ToString(),
                                    leitor["telefone1"].ToString(),
                                    leitor["telefone2"].ToString());
                    }
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
                progressBar1.Visible = false;
            }
        }

        private void AjustarTabelas_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }
    }
}
