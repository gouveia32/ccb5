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
    public class DocumentoDAO : IDAO<Documento>, IDisposable
    {
        private Connection _connection;

        public DocumentoDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Documento documento)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO DOCUMENTO(RENAVAM,CHASSI,PLACA,MES_DATA_LICENCIAMENTO, ANO_DATA_LICENCIAMENTO ,COD_VEICULO, STATUS) VALUES (@RENAVAM,@CHASSI,@PLACA,@MES_DATA_LICENCIAMENTO, @ANO_DATA_LICENCIAMENTO ,@COD_VEICULO, @STATUS);";

                    comando.Parameters.Add("@RENAVAM", MySqlDbType.Text).Value = documento.Renavam;
                    comando.Parameters.Add("@CHASSI", MySqlDbType.Text).Value = documento.Chassi;
                    comando.Parameters.Add("@PLACA", MySqlDbType.Text).Value = documento.Placa;
                    comando.Parameters.Add("@MES_DATA_LICENCIAMENTO", MySqlDbType.Text).Value = documento.MesDataLicenciamento;
                    comando.Parameters.Add("@ANO_DATA_LICENCIAMENTO", MySqlDbType.Text).Value = documento.AnoDataLicenciamento;
                    comando.Parameters.Add("@COD_VEICULO", MySqlDbType.Text).Value = documento.CodigoVeiculo;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = documento.Status;

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

        public bool Remover(Documento documento)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE DOCUMENTO SET STATUS = @STATUS WHERE COD_VEICULO = @COD_VEICULO";

                    comando.Parameters.Add("@COD_VEICULO", MySqlDbType.Int16).Value = documento.CodigoVeiculo;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = documento.Status;

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

        public bool Atualizar(Documento documento)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE DOCUMENTO SET RENAVAM = @RENAVAM, CHASSI = @CHASSI, PLACA = @PLACA, MES_DATA_LICENCIAMENTO = @MES_DATA_LICENCIAMENTO, ANO_DATA_LICENCIAMENTO = @ANO_DATA_LICENCIAMENTO WHERE COD_DOCUMENTO = @COD_DOCUMENTO";

                    comando.Parameters.Add("@RENAVAM", MySqlDbType.Text).Value = documento.Renavam;
                    comando.Parameters.Add("@CHASSI", MySqlDbType.Text).Value = documento.Chassi;
                    comando.Parameters.Add("@PLACA", MySqlDbType.Text).Value = documento.Placa;
                    comando.Parameters.Add("@MES_DATA_LICENCIAMENTO", MySqlDbType.Text).Value = documento.MesDataLicenciamento;
                    comando.Parameters.Add("@ANO_DATA_LICENCIAMENTO", MySqlDbType.Text).Value = documento.AnoDataLicenciamento;
                    comando.Parameters.Add("@COD_DOCUMENTO", MySqlDbType.Int16).Value = documento.CodigoDocumento;

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

        public List<Documento> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Documento> documentos = new List<Documento>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_DOCUMENTO,RENAVAM,CHASSI,PLACA,MES_DATA_LICENCIAMENTO, ANO_DATA_LICENCIAMENTO,COD_VEICULO,STATUS FROM DOCUMENTO WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Documento documento = new Documento();
                        documento.CodigoDocumento = Int64.Parse(leitor["COD_DOCUMENTO"].ToString());
                        documento.Renavam = leitor["RENAVAM"].ToString();
                        documento.Chassi = leitor["CHASSI"].ToString();
                        documento.Placa = leitor["PLACA"].ToString();
                        documento.MesDataLicenciamento = leitor["MES_DATA_LICENCIAMENTO"].ToString();
                        documento.AnoDataLicenciamento = leitor["ANO_DATA_LICENCIAMENTO"].ToString();
                        documento.CodigoVeiculo = Int16.Parse(leitor["COD_VEICULO"].ToString());
                        documento.Status = Int16.Parse(leitor["STATUS"].ToString());

                        documentos.Add(documento);
                    }   

                    return documentos;
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

        public Documento Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Documento documento = new Documento();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_DOCUMENTO,RENAVAM,CHASSI,PLACA,MES_DATA_LICENCIAMENTO, ANO_DATA_LICENCIAMENTO,COD_VEICULO, STATUS FROM DOCUMENTO WHERE STATUS <> 9 AND COD_VEICULO = @COD_VEICULO;";

                    comando.Parameters.Add("@COD_VEICULO", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        documento.CodigoDocumento = Int64.Parse(leitor["COD_DOCUMENTO"].ToString());
                        documento.Renavam = leitor["RENAVAM"].ToString();
                        documento.Chassi = leitor["CHASSI"].ToString();
                        documento.Placa = leitor["PLACA"].ToString();
                        documento.MesDataLicenciamento = leitor["MES_DATA_LICENCIAMENTO"].ToString();
                        documento.AnoDataLicenciamento = leitor["ANO_DATA_LICENCIAMENTO"].ToString();
                        documento.CodigoVeiculo = Int16.Parse(leitor["COD_VEICULO"].ToString());
                        documento.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return documento;
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
                    comando.CommandText = "SELECT COUNT(COD_DOCUMENTO) FROM DOCUMENTO WHERE STATUS <> 9;";

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