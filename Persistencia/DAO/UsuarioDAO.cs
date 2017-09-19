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
using System.Windows.Forms;

namespace Persistencia.DAO
{
    public class UsuarioDAO : IDAO<Usuario>, IDisposable
    {
        private Connection _connection;

        public UsuarioDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Usuario user)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO USUARIO(NOME,RG,CPF,LOGIN,SENHA,COD_PERMISSAO,STATUS) VALUES (@NOME,@RG,@CPF,@LOGIN,@SENHA,@COD_PERMISSAO,@STATUS);";

                    comando.Parameters.Add("@NOME", MySqlDbType.Text).Value = user.Nome;
                    comando.Parameters.Add("@RG", MySqlDbType.Text).Value = user.RG;
                    comando.Parameters.Add("@CPF", MySqlDbType.Text).Value = user.CPF;
                    comando.Parameters.Add("@LOGIN", MySqlDbType.Text).Value = user.Login;
                    comando.Parameters.Add("@SENHA", MySqlDbType.Text).Value = user.Senha;
                    comando.Parameters.Add("@COD_PERMISSAO", MySqlDbType.Int16).Value = user.CodigoPermissao;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = user.Status;

                    if (comando.ExecuteNonQuery() > 0)
                        return comando.LastInsertedId;
                    return -1;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public bool Remover(Usuario user)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE USUARIO SET STATUS = @STATUS WHERE COD_USUARIO = @COD_USUARIO";

                    comando.Parameters.Add("@COD_USUARIO", MySqlDbType.Int16).Value = user.CodigoUsuario;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = user.Status;

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

        public bool Atualizar(Usuario user)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE USUARIO SET NOME = @NOME, CPF = @CPF,RG = @RG, LOGIN = @LOGIN, SENHA = @SENHA, COD_PERMISSAO = @COD_PERMISSAO WHERE COD_USUARIO = @COD_USUARIO;";

                    comando.Parameters.Add("@COD_USUARIO", MySqlDbType.Int16).Value = user.CodigoUsuario;
                    comando.Parameters.Add("@NOME", MySqlDbType.Text).Value = user.Nome;
                    comando.Parameters.Add("@CPF", MySqlDbType.Text).Value = user.CPF;
                    comando.Parameters.Add("@RG", MySqlDbType.Text).Value = user.RG;
                    comando.Parameters.Add("@LOGIN", MySqlDbType.Text).Value = user.Login;
                    comando.Parameters.Add("@SENHA", MySqlDbType.Text).Value = user.Senha;
                    comando.Parameters.Add("@COD_PERMISSAO", MySqlDbType.Int16).Value = user.CodigoPermissao;

                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch(MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public List<Usuario> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Usuario> users = new List<Usuario>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_USUARIO,NOME,CPF,RG,LOGIN,SENHA,COD_PERMISSAO,STATUS FROM USUARIO WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while(leitor.Read())
                    {
                        Usuario user = new Usuario();
                        user.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        user.Nome = leitor["NOME"].ToString();
                        user.CPF = leitor["CPF"].ToString();
                        user.RG = leitor["RG"].ToString();
                        user.Login = leitor["LOGIN"].ToString();
                        user.Senha = leitor["SENHA"].ToString();
                        user.CodigoPermissao = Int16.Parse(leitor["COD_PERMISSAO"].ToString());
                        user.Status = Int16.Parse(leitor["STATUS"].ToString());

                        users.Add(user);
                    }

                    return users;
                }
            }
            catch(MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public List<Usuario> Pesquisar(string buscar)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Usuario> users = new List<Usuario>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_USUARIO,NOME,CPF,RG,LOGIN,SENHA,COD_PERMISSAO,STATUS FROM USUARIO WHERE (NOME LIKE '%' @BUSCA '%' OR LOGIN LIKE '%' @BUSCA '%' OR RG LIKE '%' @BUSCA '%' OR CPF LIKE '%' @BUSCA '%' ) AND STATUS <> 9;";
                    comando.Parameters.Add("@BUSCA", MySqlDbType.Text).Value = buscar;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Usuario user = new Usuario();
                        user.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        user.Nome = leitor["NOME"].ToString();
                        user.CPF = leitor["CPF"].ToString();
                        user.RG = leitor["RG"].ToString();
                        user.Login = leitor["LOGIN"].ToString();
                        user.Senha = leitor["SENHA"].ToString();
                        user.CodigoPermissao = Int16.Parse(leitor["COD_PERMISSAO"].ToString());
                        user.Status = Int16.Parse(leitor["STATUS"].ToString());

                        users.Add(user);
                    }

                    return users;
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

        public Usuario Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Usuario user = new Usuario();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_USUARIO,NOME,CPF,RG,LOGIN,SENHA,COD_PERMISSAO,STATUS FROM USUARIO WHERE STATUS <> 9 AND COD_USUARIO = @COD_USUARIO;";

                    comando.Parameters.Add("@COD_USUARIO",MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        user.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        user.Nome = leitor["NOME"].ToString();
                        user.CPF = leitor["CPF"].ToString();
                        user.RG = leitor["RG"].ToString();
                        user.Login = leitor["LOGIN"].ToString();
                        user.Senha = leitor["SENHA"].ToString();
                        user.CodigoPermissao = Int16.Parse(leitor["COD_PERMISSAO"].ToString());
                        user.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }
                    return user;
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

        public Usuario BuscarUsuario(string login)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Usuario user = new Usuario();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_USUARIO,NOME,CPF,RG,LOGIN,SENHA,COD_PERMISSAO,STATUS FROM USUARIO WHERE STATUS <> 9 AND LOGIN = @LOGIN;";

                    comando.Parameters.Add("@LOGIN", MySqlDbType.Text).Value = login;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        user.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        user.Nome = leitor["NOME"].ToString();
                        user.CPF = leitor["CPF"].ToString();
                        user.RG = leitor["RG"].ToString();
                        user.Login = leitor["LOGIN"].ToString();
                        user.Senha = leitor["SENHA"].ToString();
                        user.CodigoPermissao = Int16.Parse(leitor["COD_PERMISSAO"].ToString());
                        user.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }
                    return user;
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

        public Usuario BuscarNome(String login)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Usuario user = new Usuario();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_USUARIO,NOME,CPF,RG,LOGIN,SENHA,COD_PERMISSAO,STATUS FROM USUARIO WHERE STATUS <> 9 AND LOGIN = @LOGIN;";

                    comando.Parameters.Add("@LOGIN", MySqlDbType.String).Value = login;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        user.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        user.Nome = leitor["NOME"].ToString();
                        user.CPF = leitor["CPF"].ToString();
                        user.RG = leitor["RG"].ToString();
                        user.Login = leitor["LOGIN"].ToString();
                        user.Senha = leitor["SENHA"].ToString();
                        user.CodigoPermissao = Int16.Parse(leitor["COD_PERMISSAO"].ToString());
                        user.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }
                    return user;
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
                    comando.CommandText = "SELECT COUNT(COD_USUARIO) FROM USUARIO;";

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