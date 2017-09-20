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
    public class TelefoneClienteDAO : IDAO<TelefoneCliente>, IDisposable
    {
        private Connection _connection;

        public TelefoneClienteDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(TelefoneCliente telefoneCliente)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO TELEFONE_CLIENTE (TELEFONE,CLIENTE_ID) VALUES (@TELEFONE,@CLIENTE_ID);";

                    comando.Parameters.Add("@TELEFONE", MySqlDbType.Text).Value = telefoneCliente.Telefone;
                    comando.Parameters.Add("@CLIENTE_ID", MySqlDbType.Int16).Value = telefoneCliente.Id;

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

        public long InserirTelefoneFornecedor(TelefoneFornecedor telefoneFornecedor)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO TELEFONE_CLIENTE (TELEFONE,FORNECEDOR_ID) VALUES (@TELEFONE,@FORNECEDOR_ID);";

                    comando.Parameters.Add("@TELEFONE", MySqlDbType.Text).Value = telefoneFornecedor.Telefone;
                    comando.Parameters.Add("@FORNECEDOR_ID", MySqlDbType.Int16).Value = telefoneFornecedor.Id;

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

        public bool Remover(TelefoneCliente telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE TELEFONE_CLIENTE SET STATUS = @STATUS WHERE ID = @ID";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = telefone.Id;
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


        public bool AtualizarPessoaFisica(TelefoneCliente telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE TELEFONE_CLIENTE SET TELEFONE = @TELEFONE WHERE CLIENTE_ID = @CLIENTE_ID;";

                    comando.Parameters.Add("@CLIENTE_ID", MySqlDbType.Int16).Value = telefone.Id;
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

        public bool AtualizarPessoaJuridica(TelefoneFornecedor telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE TELEFONE_CLIENTE SET TELEFONE = @TELEFONE WHERE CLIENTE_ID = @CLIENTE_ID;";

                    comando.Parameters.Add("@CLIENTE_ID", MySqlDbType.Int16).Value = telefone.Id;
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

        public bool Atualizar(TelefoneCliente telefone)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE SET TELEFONE = @TELEFONE WHERE ID = @ID;";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = telefone.Id;
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

        public List<TelefoneCliente> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<TelefoneCliente> telefones = new List<TelefoneCliente>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,TELEFONE,STATUS FROM TELEFONE_CLIENTE  WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        TelefoneCliente telefone = new TelefoneCliente();
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

        public TelefoneCliente Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    TelefoneCliente telefone = new TelefoneCliente();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,TELEFONE,STATUS FROM TELEFONE_CLIENTE  WHERE STATUS <> 9 AND CLIENTE_ID = @CLIENTE_ID;";

                    comando.Parameters.Add("@CLIENTE_ID",MySqlDbType.Int16).Value = cod;
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

        public TelefoneCliente BuscarTelefoneCliente(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    TelefoneCliente telefone = new TelefoneCliente();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,TELEFONE,STATUS FROM TELEFONE_CLIENTE  WHERE STATUS <> 9 AND CLIENTE_ID = @CLIENTE_ID;";

                    comando.Parameters.Add("@CLIENTE_ID", MySqlDbType.Int16).Value = cod;
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
                    comando.CommandText = "SELECT COUNT(ID) FROM TELEFONE_CLIENTE;";

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