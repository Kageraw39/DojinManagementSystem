using DojinManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem.Tools
{
    /// <summary>
    /// 別フォームでの検索して選択したものを別フォームに飛ばす用
    /// 別フォームからのアクセスする者の保存用
    /// </summary>
     public class OverForm
    {
        //////////////////////////
        /*--初期化をしないもの--*/
        //////////////////////////       

        /// <summary>
        /// 一時フォルダの場所を保存
        /// </summary>
        public class SystemOnetime
        {
            public static string OnetimeFolderPath = "";
        }

        /// <summary>
        /// システムで一時的に保存する値をこの辺に格納
        /// </summary>
        public class SystemDepo
        {
            //画像を開くフォルダー
            public static string OpenImageFolder = null;
        }



        ////////////////////////////////
        /*---使うたびに初期化するもの-*/
        ////////////////////////////////

        /// <summary>
        /// サークル検索用
        /// </summary>
        public class CircleSearchDepo
        {
            public static string CircleName = "";
            public static string CircleMasterName = "";
            public static int? CircleId = null;
        }

        /// <summary>
        /// 原作検索用
        /// </summary>
        public class OriginalSearchDepo
        {
            public static string OriginalName = "";
            public static int? OriginalId = null;
        }

        /// <summary>
        /// 特徴検索用
        /// </summary>
        public class CharaSearchDepo
        {
            public static string CharaName = "";
            public static int? CharaId = null;
            public static bool? FlgR18 = null;
        }

        /// <summary>
        /// 同人誌検索用（簡易版）
        /// </summary>
        public class BookInfoSearchDepo_Lite
        {
            public static string BookName = "";
            public static int? BookId = null;
        }

        /// <summary>
        /// イベント検索用
        /// </summary>
        public class EventSearchDepo
        {
            public static int? EventId = null;
            public static string EventName = "";
            public static DateTime? EventDate = null;
        }        
    }
}
