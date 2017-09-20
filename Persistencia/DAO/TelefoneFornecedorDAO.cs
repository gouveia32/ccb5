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
    public class TelefoneFornecedorDAO : IDAO<TelefoneFornecedor>, IDisposable
    {
        private Connection _connection;

        public TelefoneFornecedorDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(TelefoneFornecedor telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO TELEFONE_FORNECEDOR (TELEFONE,FORNECEDOR_ID) VALUES (@TELEFONE,@FORNECEDOR_ID);";

                    comando.Parameters.Add("@TELEFONE", MySqlDbType.Text).Value = telefone.Telefone;
                    comando.Parameters.Add("@FORNECEDOR_ID", MySqlDbType.Int16).Value = telefone.Id;

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


        public bool Remover(TelefoneFornecedor telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE ID  SET STATUS = @STATUS WHERE FORNECEDOR_ID = @FORNECEDOR_ID";

                    comando.Parameters.Add("@FORNECEDOR_ID", MySqlDbType.Int16).Value = telefone.Id;
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


        public bool Atualizar(TelefoneFornecedor telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE TELEFONE_FORNECEDOR SET TELEFONE = @TELEFONE WHERE COD_FORNECEDOR = @COD_FORNECEDOR;";

                    comando.Parameters.Add("@COD_FORNECEDOR", MySqlDbType.Int16).Value = telefone.Id;
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

        public List<TelefoneFornecedor> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<TelefoneFornecedor> telefones = new List<TelefoneFornecedor>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,TELEFONE,STATUS FROM TELEFONE_FORNECEDOR WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        TelefoneFornecedor telefone = new TelefoneFornecedor();
                        telefone.Id = Int16.Parse(leitor["ID"].ToString());
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

        public TelefoneFornecedor Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    TelefoneFornecedor telefone = new TelefoneFornecedor();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,TELEFONE,STATUS FROM TELEFONE_FORNECEDOR WHERE STATUS <> 9 AND ID = @ID;";

                    comando.Parameters.Add("@ID",MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        telefone.Id = Int16.Parse(leitor["ID"].ToString());
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
                    comando.CommandText = "SELECT COUNT(COD_TELEFONE_FORNECEDOR) FROM TELEFONE_FORNECEDOR;";

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