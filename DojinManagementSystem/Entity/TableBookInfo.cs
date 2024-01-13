using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class TableBookInfo
    {
        /// <summary>
        /// BookId
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 同人誌名
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// 巻数
        /// </summary>
        public int? SeriesNo { get; set; }

        /// <summary>
        /// 初刊名
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 初刊ID
        /// </summary>
        public int? FirstId { get; set; }

        /// <summary>
        /// サークルID
        /// </summary>
        public int? CircleId { get; set; }

        /// <summary>
        /// 作者名
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// イベントID
        /// </summary>
        public int? EventId { get; set; }

        /// <summary>
        /// 発行日
        /// </summary>
        public DateTime? PublishDate{ get; set; }

        /// <summary>
        /// ジャンル
        /// </summary>
        public int? GenreId { get; set; }

        /// <summary>
        /// 原作名
        /// </summary>
        public int? OriginalId { get; set; }

        /// <summary>
        /// R18フラグ
        /// </summary>
        public bool FlgR18 { get; set; }

        /// <summary>
        /// 総集編フラグ
        /// </summary>
        public bool FlgOmnibus { get; set; }

        /// <summary>
        /// 合同誌フラグ
        /// </summary>
        public bool FlgJoint { get; set; }

        /// <summary>
        /// コピー誌フラグ
        /// </summary>
        public bool FlgCopy { get; set; }

        /// <summary>
        /// サイズID
        /// </summary>
        public int? SizeId { get; set; }

        /// <summary>
        /// 購入日
        /// </summary>
        public DateTime? BuyDate { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public int? Price { get; set; }

        /// <summary>
        /// 購入方法
        /// </summary>
        public int? BuyWayId { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 削除フラグ
        /// </summary>
        public bool FlgDelete { get; set; }

        /// <summary>
        /// データ作成日
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// データ更新日
        /// </summary>
        public DateTime UpdateDate { get; set; }

    }
}
