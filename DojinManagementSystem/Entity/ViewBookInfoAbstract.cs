using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class ViewBookInfoAbstract
    {
        /// <summary>
        /// BookId
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 冊子名
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// サークル名
        /// </summary>
        public string CircleName { get; set; }

        /// <summary>
        /// 分類名
        /// </summary>
        public string GenreName { get; set; }

        /// <summary>
        /// 原作名
        /// </summary>
        public string OriginalName { get; set; }

        /// <summary>
        /// 発行日
        /// </summary>
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// R18フラグ
        /// </summary>
        public bool FlgR18 { get; set; }

        /// <summary>
        /// 総集編フラグ
        /// </summary>
        public bool FlgOmunibus { get; set; }

        /// <summary>
        /// 合同誌フラグ
        /// </summary>
        public bool FlgJoint { get; set; }

    }
}
