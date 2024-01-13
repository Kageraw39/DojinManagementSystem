using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    class TableBookJointInfo
    {
        /// <summary>
        /// BookId
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 参加者表示順
        /// </summary>
        public int JoinOrder { get; set; }

        /// <summary>
        /// 参加者名
        /// </summary>
        public string JoinName { get; set; }

        /// <summary>
        /// 収録同人誌ID
        /// </summary>
        public int? JoinCircleId { get; set; }
    }
}
