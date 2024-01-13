using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class CommonEntity
    {
       /// <summary>
       /// コンボボックス用エンティティ
       /// </summary>
       public class ComboEntity
       {
            /// <summary>
            /// キー値
            /// </summary>
            public string ComboKey { get; set; }

            /// <summary>
            /// 表示値
            /// </summary>
            public string ComboValue { get; set; }
       }
    }
}
