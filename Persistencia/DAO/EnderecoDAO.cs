﻿using MySql.Data.MySqlClient;
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
    public class EnderecoDAO : IDAO<Endereco>, IDisposable
    {
        private Connection _connection;

        public EnderecoDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Endereco endereco)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO ENDERECO (CEP,BAIRRO,LOGRADOURO,NUMERO,CIDADE,ESTADO) VALUES (@CEP,@BAIRRO,@LOGRADOURO,@NUMERO,@CIDADE,@ESTADO);";

                    comando.Parameters.Add("@CEP", MySqlDbType.Text).Value = endereco.CEP;
                    comando.Parameters.Add("@BAIRRO", MySqlDbType.Text).Value = endereco.Bairro;
                    comando.Parameters.Add("@LOGRADOURO", MySqlDbType.Text).Value = endereco.Logradouro;
                    comando.Parameters.Add("@NUMERO", MySqlDbType.Text).Value = endereco.Numero;
                    comando.Parameters.Add("@CIDADE", MySqlDbType.Text).Value = endereco.Cidade;
                    comando.Parameters.Add("@ESTADO", MySqlDbType.Text).Value = endereco.Estado;

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

        public bool Remover(Endereco endereco)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE ENDERECO SET STATUS = @STATUS WHERE ID = @ID;";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = endereco.Id;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = endereco.Status;

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

        public bool Atualizar(Endereco endereco)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE ENDERECO SET CEP = @CEP, BAIRRO = @BAIRRO, LOGRADOURO = @LOGRADOURO, NUMERO = @NUMERO, CIDADE = @CIDADE, ESTADO = @ESTADO WHERE ID = @ID;";

                    comando.Parameters.Add("@ID", MySqlDbType.Int16).Value = endereco.Id;
                    comando.Parameters.Add("@CEP", MySqlDbType.Text).Value = endereco.CEP;
                    comando.Parameters.Add("@BAIRRO", MySqlDbType.Text).Value = endereco.Bairro;
                    comando.Parameters.Add("@LOGRADOURO", MySqlDbType.Text).Value = endereco.Logradouro;
                    comando.Parameters.Add("@NUMERO", MySqlDbType.Int16).Value = endereco.Numero;
                    comando.Parameters.Add("@CIDADE", MySqlDbType.Text).Value = endereco.Cidade;
                    comando.Parameters.Add("@ESTADO", MySqlDbType.Text).Value = endereco.Estado;

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

        public List<Endereco> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Endereco> enderecos = new List<Endereco>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,CEP,BAIRRO,LOGRADOURO,NUMERO,CIDADE,ESTADO,STATUS FROM ENDERECO WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Endereco endereco = new Endereco();
                        endereco.Id = Int16.Parse(leitor["ID"].ToString());
                        endereco.CEP = leitor["CEP"].ToString();
                        endereco.Bairro = leitor["BAIRRO"].ToString();
                        endereco.Bairro = leitor["LOGRADOURO"].ToString();
                        endereco.Numero = leitor["NUMERO"].ToString();
                        endereco.Cidade = leitor["CIDADE"].ToString();
                        endereco.Estado = leitor["ESTADO"].ToString();
                        endereco.Status = Int16.Parse(leitor["STATUS"].ToString());

                        enderecos.Add(endereco);
                    }

                    return enderecos;
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

        public Endereco Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Endereco endereco = new Endereco();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT ID,CEP,BAIRRO,LOGRADOURO,NUMERO,CIDADE,ESTADO,STATUS FROM ENDERECO WHERE STATUS <> 9 AND ID = @ID;";

                    comando.Parameters.Add("ID", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        endereco.Id = Int16.Parse(leitor["ID"].ToString());
                        endereco.CEP = leitor["CEP"].ToString();
                        endereco.Bairro = leitor["BAIRRO"].ToString();
                        endereco.Logradouro = leitor["LOGRADOURO"].ToString();
                        endereco.Numero = leitor["NUMERO"].ToString();
                        endereco.Cidade = leitor["CIDADE"].ToString();
                        endereco.Estado = leitor["ESTADO"].ToString();
                        endereco.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return endereco;
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
                    comando.CommandText = "SELECT COUNT(ENDERECO_ID) FROM ENDERECO;";

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