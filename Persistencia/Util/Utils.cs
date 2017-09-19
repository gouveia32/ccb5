using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistencia.Util
{
    public class Utils
    {
        public enum OptionsBackup { Export, Import};

        public void Backup(string file, OptionsBackup op)
        {
            new Thread(() =>
            {
                if (op == OptionsBackup.Export)
                {
                    using (MySqlBackup mySqlBackup = new MySqlBackup(new Connection().Buscar().CreateCommand()))
                    {
                        mySqlBackup.ExportToFile(file);
                    }
                }
                else
                {
                    using (MySqlBackup mySqlBackup = new MySqlBackup(new Connection().Buscar().CreateCommand()))
                    {
                        mySqlBackup.ImportFromFile(file);
                    }
                }
            });
        }
    }
}
