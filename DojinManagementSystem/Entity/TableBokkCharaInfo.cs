using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class TableBookCharaInfo
    {
        /// <summary>
        /// BookId
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 表示順
        /// </summary>
        public int CharaOrder { get; set; }

        /// <summary>
        /// 特徴名
        /// </summary>
        public string CharaName { get; set; }

        /// <summary>
        /// 特徴ID
        /// </summary>
        public int? CharaId { get; set; }



    }
}
