using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Util
{
    public class Connection: Interface.IConnection, IDisposable
    {
        private MySqlConnection _connection;

        public Connection()
        {
            string connnectionstring = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;
            _connection = new MySqlConnection(connnectionstring);
        }

        public MySqlConnection Abrir()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (MySqlException)
            {
                throw;
            }
     
            return _connection;
        }

        public MySqlConnection Buscar()
        {
            return Abrir();
        }

        public ConnectionState Status()
        {
            return _connection.State;
        }

        public void Fechar()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        public void Dispose()
        {
            Fechar();
            GC.SuppressFinalize(this);
        }
    }
}
