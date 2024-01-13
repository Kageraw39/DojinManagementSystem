using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static DojinManagementSystem.Tools.OverForm;


namespace DojinManagementSystem
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //システムで利用する一時フォルダを作成する
            //一時フォルダの場所はOverFormに入れておく
            SystemOnetime.OnetimeFolderPath = Path.Combine(Path.GetTempPath(), Properties.Settings.Default.OnetimeFolderName);
            //一時フォルダーを作成
            Directory.CreateDirectory(SystemOnetime.OnetimeFolderPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Menu());

            //利用していた一時フォルダを削除する
            Directory.Delete(SystemOnetime.OnetimeFolderPath, true);
        }
    }
}
