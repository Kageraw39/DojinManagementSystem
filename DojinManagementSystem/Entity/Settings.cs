using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace DojinManagementSystem.Entity
{
    public class Settings
    {
        private string _DataBaseServer;
        private string _DataBaseName;
        private string _DataBaseUser;
        private string _DataBasePass;
        private string _PicutureFolder;

        public string DataBaseServer
        {
            get { return _DataBaseServer; }
            set { _DataBaseServer = value; }
        }
        public string DataBaseName
        {
            get { return _DataBaseName; }
            set { _DataBaseName = value; }
        }
        public string DataBaseUser
        {
            get { return _DataBaseUser; }
            set { _DataBaseUser = value; }
        }
        public string DataBasePass
        {
            get { return _DataBasePass; }
            set { _DataBasePass = value; }
        }
        public string PicutureFolder
        {
            get { return _PicutureFolder; }
            set { _PicutureFolder = value; }
        }
    }
}