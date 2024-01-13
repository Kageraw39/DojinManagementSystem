using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class MastaChara
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 特徴名
        /// </summary>
        public string CharaName { get; set; }

        /// <summary>
        /// R18フラグ
        /// </summary>
        public bool FlgR18 { get; set; }
    }
}
