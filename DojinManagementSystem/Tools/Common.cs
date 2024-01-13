using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static DojinManagementSystem.Global;
using static DojinManagementSystem.CommonEntity;
using Dapper;
using System.IO;

namespace DojinManagementSystem.Tools
{
    public class Common
    {
        private static DBConection _Connection = new DBConection();

        /// <summary>
        /// 親フォームを隠して、フォームオープン
        /// </summary>
        /// <param name="pearent"></param>
        /// <param name="child"></param>
        public static void OpenForm(Form pearent, Form child)
        {            
            child.Show();           
        }

        /// <summary>
        /// string→double?(空文字、不正はnullに)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double? StringToNullDouble (string str)
        {
            //まず空文字の確認
            if(str.Trim() == "")
            {
                return null;
            }

            //空文字以外の確認
            double d;
           if(double.TryParse(str.Trim(),out d) == true)
           {
                double? dd = d;
                return dd;
           }
           else
           {
                return null;
           }
        }

        /// <summary>
        /// DBのマスタからコンボボックスのセットアップ
        /// </summary>
        /// <param name="cmb">設定するコンボボックス</param>
        /// <param name="table">元テーブル</param>
        /// <param name="keyColumn">キー列</param>
        /// <param name="valueColumn">バリュー列</param>
        /// <param name="existNull">空白選択の有無</param>
        public static void SetCombobox(ComboBox cmb,string table, string keyColumn, string valueColumn , bool existNull)
        {
            List<ComboEntity> data;

            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    {keyColumn} as ComboKey,
    {valueColumn} as ComboValue
from
    {table}
";
                data = db.Query<ComboEntity>(sql).ToList();
            }
            if(existNull == true)
            {
                data.Insert(0, new ComboEntity { ComboKey = "null", ComboValue = "" });
            }
            cmb.DataSource = data;
            cmb.DisplayMember = "ComboValue";
            cmb.ValueMember = "ComboKey";
        }       
    }
}
