using MySql.Data.MySqlClient;
using Persistencia.Interface;
using Persistencia.Modelo;
using Persistencia.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAO
{
    public class TelefoneEmpregadoDAO : IDAO<TelefoneEmpregado>, IDisposable
    {
        private Connection _connection;

        public TelefoneEmpregadoDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(TelefoneEmpregado telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO TELEFONE_EMPREGADO (TELEFONE,EMPREGADO_ID) VALUES (@TELEFONE,@EMPREGADO_ID);";

                    comando.Parameters.Add("@TELEFONE", MySqlDbType.Text).Value = telefone.Telefone;
                    comando.Parameters.Add("@EMPREGADO_ID", MySqlDbType.Int16).Value = telefone.EmpregadoId;

                    if (comando.ExecuteNonQuery() > 0)
                        return comando.LastInsertedId;
                    return -1;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }


        public bool Remover(TelefoneEmpregado telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE TELEFONE_EMPREGADO  SET STATUS = @STATUS WHERE ID = @EMPREGADO_ID";

                    comando.Parameters.Add("@EMPREGADO_ID", MySqlDbType.Int16).Value = telefone.EmpregadoId;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = telefone.Status;


                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }


        public bool Atualizar(TelefoneEmpregado telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE TELEFONE_EMPREGADO SET TELEFONE = @TELEFONE WHERE EMPREGADO_ID = @EMPREGADO_ID;";

                    comando.Parameters.Add("@EMPREGADO_ID", MySqlDbType.Int16).Value = telefone.EmpregadoId;
                    comando.Parameters.Add("@TELEFONE", MySqlDbType.Text).Value = telefone.Telefone;

                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public List<TelefoneEmpregado> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<TelefoneEmpregado> telefones = new List<TelefoneEmpregado>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_TELEFONE_EMPREGADO,TELEFONE,STATUS FROM TELEFONE_EMPREGADO WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        TelefoneEmpregado telefone = new TelefoneEmpregado();
                        telefone.CodigoTelefoneEmpregado = Int16.Parse(leitor["COD_TELEFONE_EMPREGADO"].ToString());
                        telefone.Telefone = leitor["TELEFONE"].ToString();
                        telefone.Status = Int16.Parse(leitor["STATUS"].ToString());

                        telefones.Add(telefone);
                    }

                    return telefones;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public TelefoneEmpregado Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    TelefoneEmpregado telefone = new TelefoneEmpregado();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT EMPREGADO_ID,TELEFONE,STATUS FROM TELEFONE_EMPREGADO WHERE STATUS <> 9 AND EMPREGADO_ID = @ID;";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        telefone.EmpregadoId = Int16.Parse(leitor["EMPREGADO_ID"].ToString());
                        telefone.Telefone = leitor["TELEFONE"].ToString();
                        telefone.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return telefone;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public long Contagem()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COUNT(COD_TELEFONE_EMPREGADO) FROM TELEFONE_EMPREGADO;";

                    return (long)comando.ExecuteScalar();
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }


        public void Dispose()
        {
            _connection.Fechar();
            GC.SuppressFinalize(this);
        }

    }
}