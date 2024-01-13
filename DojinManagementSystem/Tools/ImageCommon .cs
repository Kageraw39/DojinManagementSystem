using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using static DojinManagementSystem.Global;
using static DojinManagementSystem.CommonEntity;
using Dapper;
using System.IO;

namespace DojinManagementSystem.Tools
{
    public class ImageCommon
    {
        /// <summary>
        /// 横幅が指定のピクセルになるように画像のサイズを変更する（縦横比維持）
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="ToSize"></param>
        /// <returns></returns>
        public static Bitmap ResizeImage_W(Bitmap Input,int ToSize)
        {
            //拡大縮小の倍率を取得
            double Mag = (double)ToSize / (double)(Input.Width);

            //返却用のBitmapを生成
            Bitmap Resized;

            //縮小と拡大で処理は変更する
            //縮小の際はBitmapのままサイズだけ変更して返す
            if(Mag <= 1)
            {                
                Resized = new Bitmap(Input, (int)(Input.Width * Mag),(int)(Input.Height * Mag));
                return Resized;
            }
            //拡大の際はGraphicsを利用
            else
            {
                //目標サイズのGraphicsの生成
                Bitmap b = new Bitmap((int)(Input.Width * Mag), (int)(Input.Height * Mag));
                Graphics g = Graphics.FromImage(b);
                //画像の拡大
                g.DrawImage(Input, 0, 0, (int)(Input.Width * Mag), (int)(Input.Height * Mag));
                return b;
            }            
        }

        /// <summary>
        /// 高さが指定のピクセルになるように画像のサイズを変更する（縦横比維持）
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="ToSize"></param>
        /// <returns></returns>
        public static Bitmap ResizeImage_H(Bitmap Input, int ToSize)
        {
            //拡大縮小の倍率を取得
            double Mag = (double)ToSize / (double)(Input.Height);

            //返却用のBitmapを生成
            Bitmap Resized;

            //縮小と拡大で処理は変更する
            //縮小の際はBitmapのままサイズだけ変更して返す
            if (Mag <= 1)
            {
                Resized = new Bitmap(Input, (int)(Input.Width * Mag), (int)(Input.Height * Mag));
                return Resized;
            }
            //拡大の際はGraphicsを利用
            else
            {
                //目標サイズのGraphicsの生成
                Bitmap b = new Bitmap((int)(Input.Width * Mag), (int)(Input.Height * Mag));
                Graphics g = Graphics.FromImage(b);
                //画像の拡大
                g.DrawImage(Input, 0, 0, (int)(Input.Width * Mag), (int)(Input.Height * Mag));
                return b;
            }
        }
    }
}
