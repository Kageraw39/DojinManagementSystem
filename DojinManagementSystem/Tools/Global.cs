using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DojinManagementSystem
{
    public class Global
    {
        public class DBConection
        {
            static string DBServer = Properties.Settings.Default.DataBaseServer;
            static string DBUser = Properties.Settings.Default.DataBaseUser;
            static string DBPass = Properties.Settings.Default.DataBasePass;
            static string DBName = Properties.Settings.Default.DataBaseName;

            public string GetConnection() => $"Data Source={DBServer};Database={DBName};User ID={DBUser};password={DBPass};Charset='utf8'";

        }

        public class Mode
        {
            public const int New = 0;
            public const int Edit = 1;
        }

    }
}
