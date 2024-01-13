using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class MastaEvent
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// イベント名
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// イベント開催日
        /// </summary>
        public DateTime EventDate { get; set; }
    }
}
