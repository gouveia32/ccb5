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
    public class FornecedorDAO : IDAO<Fornecedor>, IDisposable
    {
        private Connection _connection;

        public FornecedorDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Fornecedor fornecedor)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO FORNECEDOR(NOME_FANTASIA,RAZAO_SOCIAL,CNPJ,INSCRICAO_ESTADUAL,EMAIL,ENDERECO_ID) VALUES (@NOME_FANTASIA,@RAZAO_SOCIAL,@CNPJ,@INSCRICAO_ESTADUAL,@EMAIL,@ENDERECO_ID);";

                    comando.Parameters.Add("@NOME_FANTASIA", MySqlDbType.Text).Value = fornecedor.NomeFantasia;
                    comando.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.Text).Value = fornecedor.RazaoSocial;
                    comando.Parameters.Add("@CNPJ", MySqlDbType.Text).Value = fornecedor.CNPJ;
                    comando.Parameters.Add("@INSCRICAO_ESTADUAL", MySqlDbType.Text).Value = fornecedor.InscricaoEstadual;
                    comando.Parameters.Add("@EMAIL", MySqlDbType.Text).Value = fornecedor.Email;
                    comando.Parameters.Add("@ENDERECO_ID", MySqlDbType.Int16).Value = fornecedor.EnderecoId;

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

        public bool Remover(Fornecedor fornecedor)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE FORNECEDOR SET STATUS = @STATUS WHERE ID = @ID";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = fornecedor.Id;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = fornecedor.Status;

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

        public bool Atualizar(Fornecedor fornecedor)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE FORNECEDOR SET NOME_FANTASIA = @NOME_FANTASIA, RAZAO_SOCIAL = @RAZAO_SOCIAL, CNPJ = @CNPJ, INSCRICAO_ESTADUAL = @INSCRICAO_ESTADUAL, EMAIL = @EMAIL WHERE ID = @ID";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = fornecedor.Id;
                    comando.Parameters.Add("@NOME_FANTASIA", MySqlDbType.Text).Value = fornecedor.NomeFantasia;
                    comando.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.Text).Value = fornecedor.RazaoSocial;
                    comando.Parameters.Add("@CNPJ", MySqlDbType.Text).Value = fornecedor.CNPJ;
                    comando.Parameters.Add("@INSCRICAO_ESTADUAL", MySqlDbType.Text).Value = fornecedor.InscricaoEstadual;
                    comando.Parameters.Add("@EMAIL", MySqlDbType.Text).Value = fornecedor.Email;

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

        public List<Fornecedor> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Fornecedor> fornecedores = new List<Fornecedor>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,NOME_FANTASIA,RAZAO_SOCIAL,CNPJ,INSCRICAO_ESTADUAL,ENDERECO_ID,EMAIL,STATUS FROM FORNECEDOR WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Id = Int16.Parse(leitor["ID"].ToString());
                        fornecedor.NomeFantasia = leitor["NOME_FANTASIA"].ToString();
                        fornecedor.RazaoSocial = leitor["RAZAO_SOCIAL"].ToString();
                        fornecedor.CNPJ = leitor["CNPJ"].ToString();
                        fornecedor.InscricaoEstadual = leitor["INSCRICAO_ESTADUAL"].ToString();
                        fornecedor.Email = leitor["EMAIL"].ToString();
                        fornecedor.EnderecoId = Int16.Parse(leitor["ENDERECO_ID"].ToString());
                        fornecedor.Status = Int16.Parse(leitor["STATUS"].ToString());

                        fornecedores.Add(fornecedor);
                    }

                    return fornecedores;
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

        public Fornecedor Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,NOME_FANTASIA,RAZAO_SOCIAL,CNPJ,INSCRICAO_ESTADUAL,EMAIL,ENDERECO_ID,STATUS FROM FORNECEDOR WHERE STATUS <> 9 AND ID = @ID;";
                    comando.Parameters.Add("ID", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        fornecedor.Id = Int16.Parse(leitor["ID"].ToString());
                        fornecedor.NomeFantasia = leitor["NOME_FANTASIA"].ToString();
                        fornecedor.RazaoSocial = leitor["RAZAO_SOCIAL"].ToString();
                        fornecedor.CNPJ = leitor["CNPJ"].ToString();
                        fornecedor.InscricaoEstadual = leitor["INSCRICAO_ESTADUAL"].ToString();
                        fornecedor.Email = leitor["EMAIL"].ToString();
                        fornecedor.EnderecoId = Int16.Parse(leitor["ENDERECO_ID"].ToString());
                        fornecedor.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return fornecedor;
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
        public List<Fornecedor> BuscarFornecedor(string busca)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Fornecedor> fornecedores = new List<Fornecedor>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,NOME_FANTASIA,RAZAO_SOCIAL,CNPJ FROM FORNECEDOR WHERE (NOME_FANTASIA LIKE '%' @BUSCAR '%' OR RAZAO_SOCIAL LIKE '%' @BUSCAR '%' OR CNPJ LIKE '%' @BUSCAR '%') AND STATUS <> 9;";
                    comando.Parameters.Add("@BUSCAR", MySqlDbType.Text).Value = busca;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while  (leitor.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Id = Int16.Parse(leitor["ID"].ToString());
                        fornecedor.NomeFantasia = leitor["NOME_FANTASIA"].ToString();
                        fornecedor.RazaoSocial = leitor["RAZAO_SOCIAL"].ToString();
                        fornecedor.CNPJ = leitor["CNPJ"].ToString();
                        fornecedores.Add(fornecedor);
                    }

                    return fornecedores;
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
                    comando.CommandText = "SELECT COUNT(COD_FORNECEDOR) FROM FORNECEDOR;";

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