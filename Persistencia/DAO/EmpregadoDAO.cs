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
    public class EmpregadoDAO : IDAO<Empregado>, IDisposable
    {
        private Connection _connection;

        public EmpregadoDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Empregado empregado)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO EMPREGADO(NOME,EMAIL,ENDERECO_ID,DATA_NASCIMENTO,DATA_ADMISSAO,DATA_DEMISSAO) VALUES (@NOME,@EMAIL,@ENDERECO_ID,@DATA_NASCIMENTO,@DATA_ADMISSAO,@DATA_DEMISSAO);";

                    comando.Parameters.Add("@EMAIL", MySqlDbType.Text).Value = empregado.Email;
                    comando.Parameters.Add("@NOME", MySqlDbType.Text).Value = empregado.Nome;
                    comando.Parameters.Add("@ENDERECO_ID", MySqlDbType.Text).Value = empregado.EnderecoId;
                    comando.Parameters.Add("@DATA_NASCIMENTO", MySqlDbType.Text).Value = empregado.DataNascimento;
                    comando.Parameters.Add("@DATA_ADMISSAO", MySqlDbType.Text).Value = empregado.DataAdmissao;
                    comando.Parameters.Add("@DATA_DEMISSAO", MySqlDbType.Text).Value = empregado.DataDemissao;

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

        public bool Remover(Empregado empregado)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EMPREGADO SET STATUS = @STATUS WHERE ID = @ID";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = empregado.Id;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = empregado.Status;

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

        public bool Atualizar(Empregado empregado)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EMPREGADO SET EMAIL = @EMAIL, DATA_NASCIMENTO = @DATA_NASCIMENTO, DATA_ADMISSAO = @DATA_ADMISSAO, DATA_DEMISSAO = @DATA_DEMISSAO WHERE ID = @ID;";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = empregado.Id;
                    comando.Parameters.Add("@EMAIL", MySqlDbType.Text).Value = empregado.Email;
                    comando.Parameters.Add("@DATA_NASCIMENTO", MySqlDbType.Text).Value = empregado.DataNascimento;
                    comando.Parameters.Add("@DATA_ADMISSAO", MySqlDbType.Text).Value = empregado.DataAdmissao;
                    comando.Parameters.Add("@DATA_DEMISSAO", MySqlDbType.Text).Value = empregado.DataDemissao;

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

        public List<Empregado> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Empregado> empregados = new List<Empregado>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,NOME,EMAIL,ENDERECO_ID,STATUS,DATA_NASCIMENTO,DATA_ADMISSAO,DATA_DEMISSAO FROM EMPREGADO WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Empregado empregado = new Empregado();
                        empregado.Id = Int16.Parse(leitor["ID"].ToString());
                        empregado.Nome = leitor["NOME"].ToString();
                        empregado.Email = leitor["EMAIL"].ToString();
                        empregado.EnderecoId = Int16.Parse(leitor["ENDERECO_ID"].ToString());
                        empregado.Status = Int16.Parse(leitor["STATUS"].ToString());
                        empregado.DataNascimento = leitor["DATA_NASCIMENTO"].ToString();
                        empregado.DataAdmissao = leitor["DATA_ADMISSAO"].ToString();
                        empregado.DataDemissao = leitor["DATA_DEMISSAO"].ToString();

                        empregados.Add(empregado);
                    }

                    return empregados;
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

        public Empregado Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Empregado empregado = new Empregado();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,NOME,EMAIL,ENDERECO_ID,STATUS,DATA_NASCIMENTO,DATA_ADMISSAO,DATA_DEMISSAO FROM EMPREGADO WHERE STATUS <> 9 AND ID = @ID;";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        empregado.Id = Int16.Parse(leitor["ID"].ToString());
                        empregado.Email = leitor["EMAIL"].ToString();
                        empregado.Nome = leitor["NOME"].ToString();
                        empregado.DataNascimento = leitor["DATA_NASCIMENTO"].ToString();
                        empregado.DataAdmissao = leitor["DATA_ADMISSAO"].ToString();
                        empregado.DataDemissao = leitor["DATA_DEMISSAO"].ToString();
                        empregado.EnderecoId = Int16.Parse(leitor["ENDERECO_ID"].ToString());
                        empregado.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return empregado;
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

        public List<Empregado> BuscarEmpregado(string busca)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Empregado> empregados = new List<Empregado>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,NOME,EMAIL,DATA_NASCIMENTO,DATA_ADMISSAO,DATA_DEMISSAO FROM FORNECEDOR WHERE (NOME LIKE '%' @BUSCAR '%') AND STATUS <> 9;";
                    comando.Parameters.Add("@BUSCAR", MySqlDbType.Text).Value = busca;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Empregado empregado = new Empregado();
                        empregado.Id = Int16.Parse(leitor["ID"].ToString());
                        empregado.Nome = leitor["NOME"].ToString();
                        empregado.Email = leitor["EMAIL"].ToString();
                        empregados.Add(empregado);
                    }

                    return empregados;
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
                    comando.CommandText = "SELECT COUNT(ID) FROM EMPREGADO WHERE STATUS <> 9;";

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