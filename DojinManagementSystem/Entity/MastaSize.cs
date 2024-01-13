using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class MastaSize
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// サイズ名
        /// </summary>
        public string SizeName { get; set; }

        /// <summary>
        /// 縦の長さ
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// 横の長さ
        /// </summary>
        public double? Width { get; set; }

    }
}
