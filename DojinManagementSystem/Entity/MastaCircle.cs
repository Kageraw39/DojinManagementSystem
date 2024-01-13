using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class MastaCircle
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// サークル名
        /// </summary>
        public string CircleName { get; set; }
               
        /// <summary>
        /// サークル代表者名
        /// </summary>
        public string CircleMaster { get; set; }          
    }
}
