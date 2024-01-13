using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    class TableBookOmunibusInfo
    {
        /// <summary>
        /// BookId
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 収録誌表示順
        /// </summary>
        public int PutOrder { get; set; }

        /// <summary>
        /// 収録同人誌名
        /// </summary>
        public string PutTitle { get; set; }

        /// <summary>
        /// 収録同人誌ID
        /// </summary>
        public int? PutBookId { get; set; }
    }
}
