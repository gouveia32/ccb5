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
    public class ItemConformidadeDAO : IDisposable
    {
        private Connection _connection;

        public ItemConformidadeDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(ItemConformidade item)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO ITEM_CONFORMIDADE (ITEM,COD_CHECKLIST) VALUES (@ITEM,@COD_CHECKLIST);";

                    comando.Parameters.Add("@ITEM", MySqlDbType.Text).Value = item.Item;
                    comando.Parameters.Add("@COD_CHECKLIST", MySqlDbType.Int16).Value = item.CodigoCheckList;

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

        public bool Remover(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "DELETE FROM ITEM_CONFORMIDADE WHERE COD_CHECKLIST = @COD_CHECKLIST";

                    comando.Parameters.Add("@COD_CHECKLIST", MySqlDbType.Int16).Value = cod;

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

        public List<ItemConformidade> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<ItemConformidade> items = new List<ItemConformidade>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_ITEM,ITEM,COD_CHECKLIST,STATUS FROM ITEM_CONFORMIDADE WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        ItemConformidade item = new ItemConformidade();
                        item.CodigoItem = Int16.Parse(leitor["COD_ITEM"].ToString());
                        item.Item = leitor["ITEM"].ToString();
                        item.CodigoCheckList = Int16.Parse(leitor["COD_CHECKLIST"].ToString());
                        item.Status = Int16.Parse(leitor["STATUS"].ToString());

                        items.Add(item);
                    }

                    return items;
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

        public List<ItemConformidade> Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<ItemConformidade> items = new List<ItemConformidade>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_ITEM,ITEM,COD_CHECKLIST,STATUS FROM ITEM_CONFORMIDADE WHERE STATUS <> 9 AND COD_CHECKLIST = @COD_CHECKLIST";

                    comando.Parameters.Add("@COD_CHECKLIST", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        ItemConformidade item = new ItemConformidade();
                        item.CodigoItem = Int16.Parse(leitor["COD_ITEM"].ToString());
                        item.Item = leitor["ITEM"].ToString();
                        item.CodigoCheckList = Int16.Parse(leitor["COD_CHECKLIST"].ToString());
                        item.Status = Int16.Parse(leitor["STATUS"].ToString());

                        items.Add(item);
                    }

                    return items;
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
                    comando.CommandText = "SELECT COUNT(COD_ITEM) FROM ITEM_CONFORMIDADE;";

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