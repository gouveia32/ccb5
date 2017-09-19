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
    public class ReservaDAO: IDAO<Reserva>,IDisposable
    {
        private Connection _connection;

        public ReservaDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Reserva reserva)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO RESERVA(VALOR_LOCACAO,DATA_RESERVA,FORMA_PAGAMENTO,TIPO_RETIRADA,DATA_ENTREGA,DATA_RETIRADA,SITUACAO,COD_CLIENTE,COD_USUARIO,COD_VEICULO,STATUS) VALUES (@VALOR_LOCACAO,@DATA_RESERVA,@FORMA_PAGAMENTO,@TIPO_RETIRADA,@DATA_ENTREGA,@DATA_RETIRADA,@SITUACAO,@COD_CLIENTE,@COD_USUARIO,@COD_VEICULO,@STATUS);";

                    comando.Parameters.Add("@VALOR_LOCACAO", MySqlDbType.Decimal).Value = reserva.ValorLocacao;
                    comando.Parameters.Add("@DATA_RESERVA", MySqlDbType.Text).Value = reserva.DataReserva;
                    comando.Parameters.Add("@FORMA_PAGAMENTO", MySqlDbType.Text).Value = reserva.FormaPagamento;
                    comando.Parameters.Add("@TIPO_RETIRADA", MySqlDbType.Text).Value = reserva.TipoRetirada;
                    comando.Parameters.Add("@DATA_ENTREGA", MySqlDbType.Text).Value = reserva.DataEntrega;
                    comando.Parameters.Add("@DATA_RETIRADA", MySqlDbType.Text).Value = reserva.DataRetirada;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = reserva.Status;
                    comando.Parameters.Add("@SITUACAO", MySqlDbType.Text).Value = reserva.Situacao;
                    comando.Parameters.Add("@COD_CLIENTE", MySqlDbType.Int16).Value = reserva.CodigoCliente;
                    comando.Parameters.Add("@COD_USUARIO", MySqlDbType.Int16).Value = reserva.CodigoUsuario;
                    comando.Parameters.Add("@COD_VEICULO", MySqlDbType.Int16).Value = reserva.CodigoVeiculo;

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

        public bool Remover(Reserva reserva)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE RESERVA SET STATUS = @STATUS WHERE NUMERO_RESERVA = @NUMERO_RESERVA";

                    comando.Parameters.Add("@NUMERO_RESERVA", MySqlDbType.Int16).Value = reserva.NumeroReserva;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = reserva.Status;

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

        public bool Atualizar(Reserva reserva)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE RESERVA SET DATA_RESERVA = @DATA_RESERVA, FORMA_PAGAMENTO = @FORMA_PAGAMENTO, TIPO_RETIRADA = @TIPO_RETIRADA, DATA_ENTREGA = @DATA_ENTREGA, DATA_RETIRADA = @DATA_RETIRADA, SITUACAO = @SITUACAO, COD_CLIENTE = @COD_CLIENTE, COD_USUARIO = @COD_USUARIO, COD_VEICULO = @COD_VEICULO, STATUS = @STATUS, VALOR_LOCACAO = @VALOR_LOCACAO WHERE NUMERO_RESERVA = @NUMERO_RESERVA; ";

                    comando.Parameters.Add("@DATA_RESERVA", MySqlDbType.Text).Value = reserva.DataReserva;
                    comando.Parameters.Add("@FORMA_PAGAMENTO", MySqlDbType.Text).Value = reserva.FormaPagamento;
                    comando.Parameters.Add("@TIPO_RETIRADA", MySqlDbType.Text).Value = reserva.TipoRetirada;
                    comando.Parameters.Add("@DATA_ENTREGA", MySqlDbType.Text).Value = reserva.DataEntrega;
                    comando.Parameters.Add("@DATA_RETIRADA", MySqlDbType.Text).Value = reserva.DataRetirada;
                    comando.Parameters.Add("@SITUACAO", MySqlDbType.Text).Value = reserva.Situacao;
                    comando.Parameters.Add("@COD_CLIENTE", MySqlDbType.Int16).Value = reserva.CodigoCliente;
                    comando.Parameters.Add("@COD_USUARIO", MySqlDbType.Int16).Value = reserva.CodigoUsuario;
                    comando.Parameters.Add("@COD_VEICULO", MySqlDbType.Int16).Value = reserva.CodigoVeiculo;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = reserva.Status;
                    comando.Parameters.Add("@VALOR_LOCACAO", MySqlDbType.Decimal).Value = reserva.ValorLocacao;
                    comando.Parameters.Add("@NUMERO_RESERVA", MySqlDbType.Int16).Value = reserva.NumeroReserva;

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

        public List<Reserva> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Reserva> reservas = new List<Reserva>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT NUMERO_RESERVA,VALOR_LOCACAO,DATA_RESERVA,FORMA_PAGAMENTO,TIPO_RETIRADA,DATA_ENTREGA,DATA_RETIRADA,SITUACAO,STATUS,COD_CLIENTE,COD_USUARIO,COD_VEICULO, VALOR_LOCACAO FROM RESERVA WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.NumeroReserva = Int16.Parse(leitor["NUMERO_RESERVA"].ToString());
                        reserva.DataReserva = leitor["DATA_RESERVA"].ToString();
                        reserva.FormaPagamento = leitor["FORMA_PAGAMENTO"].ToString();
                        reserva.TipoRetirada = leitor["TIPO_RETIRADA"].ToString();
                        reserva.DataEntrega = leitor["DATA_ENTREGA"].ToString();
                        reserva.DataRetirada = leitor["DATA_RETIRADA"].ToString();
                        reserva.Situacao = leitor["SITUACAO"].ToString();
                        reserva.Status = Int16.Parse(leitor["STATUS"].ToString());
                        reserva.CodigoCliente = Int16.Parse(leitor["COD_CLIENTE"].ToString());
                        reserva.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        reserva.CodigoVeiculo = Int16.Parse(leitor["COD_VEICULO"].ToString());
                        reserva.ValorLocacao = Decimal.Parse(leitor["VALOR_LOCACAO"].ToString());

                        reservas.Add(reserva);
                    }

                    return reservas;
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

        public List<Reserva> Pesquisar(string busca)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Reserva> reservas = new List<Reserva>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT * FROM RESERVA WHERE(NUMERO_RESERVA LIKE '%' @BUSCA '%' OR DATA_RESERVA LIKE '%' @BUSCA '%' OR DATA_ENTREGA LIKE '%' @BUSCA '%' OR DATA_RETIRADA LIKE '%' @BUSCA '%' OR SITUACAO LIKE '%' @BUSCA '%' ) AND STATUS <> 9;";
                    comando.Parameters.Add("@BUSCA", MySqlDbType.Text).Value = busca;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.NumeroReserva = Int16.Parse(leitor["NUMERO_RESERVA"].ToString());
                        reserva.DataReserva = leitor["DATA_RESERVA"].ToString();
                        reserva.FormaPagamento = leitor["FORMA_PAGAMENTO"].ToString();
                        reserva.TipoRetirada = leitor["TIPO_RETIRADA"].ToString();
                        reserva.DataEntrega = leitor["DATA_ENTREGA"].ToString();
                        reserva.DataRetirada = leitor["DATA_RETIRADA"].ToString();
                        reserva.Situacao = leitor["SITUACAO"].ToString();
                        reserva.Status = Int16.Parse(leitor["STATUS"].ToString());
                        reserva.CodigoCliente = Int16.Parse(leitor["COD_CLIENTE"].ToString());
                        reserva.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        reserva.CodigoVeiculo = Int16.Parse(leitor["COD_VEICULO"].ToString());
                        reserva.ValorLocacao = Decimal.Parse(leitor["VALOR_LOCACAO"].ToString());

                        reservas.Add(reserva);
                    }

                    return reservas;
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

        public Reserva Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Reserva reserva = new Reserva();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT NUMERO_RESERVA,DATA_RESERVA,FORMA_PAGAMENTO,TIPO_RETIRADA,DATA_ENTREGA,DATA_RETIRADA,SITUACAO,STATUS,COD_CLIENTE,COD_USUARIO,COD_VEICULO, VALOR_LOCACAO FROM RESERVA WHERE STATUS <> 9 AND NUMERO_RESERVA = @NUMERO_RESERVA;";

                    comando.Parameters.Add("@NUMERO_RESERVA",MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        reserva.NumeroReserva = Int16.Parse(leitor["NUMERO_RESERVA"].ToString());
                        reserva.DataReserva = leitor["DATA_RESERVA"].ToString();
                        reserva.FormaPagamento = leitor["FORMA_PAGAMENTO"].ToString();
                        reserva.TipoRetirada = leitor["TIPO_RETIRADA"].ToString();
                        reserva.DataEntrega = leitor["DATA_ENTREGA"].ToString();
                        reserva.DataRetirada = leitor["DATA_RETIRADA"].ToString();
                        reserva.Situacao = leitor["SITUACAO"].ToString();
                        reserva.Status = Int16.Parse(leitor["STATUS"].ToString());
                        reserva.CodigoCliente = Int16.Parse(leitor["COD_CLIENTE"].ToString());
                        reserva.CodigoUsuario = Int16.Parse(leitor["COD_USUARIO"].ToString());
                        reserva.CodigoVeiculo = Int16.Parse(leitor["COD_VEICULO"].ToString());
                        reserva.ValorLocacao = Decimal.Parse(leitor["VALOR_LOCACAO"].ToString());
                    }

                    return reserva;
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
                    comando.CommandText = "SELECT COUNT(COD_RESERVA) FROM RESERVA;";

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

        public bool Devolucao(Reserva reserva)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE RESERVA SET DATA_RESERVA = @DATA_RESERVA,STATUS = @STATUS ,VALOR_LOCACAO = @VALOR_LOCACAO, FORMA_PAGAMENTO = @FORMA_PAGAMENTO, TIPO_RETIRADA = @TIPO_RETIRADA, DATA_ENTREGA = @DATA_ENTREGA, DATA_RETIRADA = @DATA_RETIRADA, SITUACAO = @SITUACAO, COD_CLIENTE = @COD_CLIENTE, COD_USUARIO = @COD_USUARIO, COD_VEICULO = @COD_VEICULO WHERE NUMERO_RESERVA = @NUMERO_RESERVA;";

                    comando.Parameters.Add("@NUMERO_RESERVA", MySqlDbType.Int16).Value = reserva.NumeroReserva;
                    comando.Parameters.Add("@VALOR_LOCACAO", MySqlDbType.Decimal).Value = reserva.ValorLocacao;
                    comando.Parameters.Add("@DATA_RESERVA", MySqlDbType.Text).Value = reserva.DataReserva;
                    comando.Parameters.Add("@FORMA_PAGAMENTO", MySqlDbType.Int16).Value = reserva.FormaPagamento;
                    comando.Parameters.Add("@TIPO_RETIRADA", MySqlDbType.Int16).Value = reserva.TipoRetirada;
                    comando.Parameters.Add("@DATA_ENTREGA", MySqlDbType.Text).Value = reserva.DataEntrega;
                    comando.Parameters.Add("@DATA_RETIRADA", MySqlDbType.Text).Value = reserva.DataRetirada;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = reserva.Status;
                    comando.Parameters.Add("@SITUACAO", MySqlDbType.Int16).Value = reserva.Situacao;
                    comando.Parameters.Add("@COD_CLIENTE", MySqlDbType.Int16).Value = reserva.CodigoCliente;
                    comando.Parameters.Add("@COD_USUARIO", MySqlDbType.Int16).Value = reserva.CodigoUsuario;
                    comando.Parameters.Add("@COD_VEICULO", MySqlDbType.Int16).Value = reserva.CodigoVeiculo;

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
        public void Dispose()
        {
            _connection.Fechar();
            GC.SuppressFinalize(this);
        }
    }
}