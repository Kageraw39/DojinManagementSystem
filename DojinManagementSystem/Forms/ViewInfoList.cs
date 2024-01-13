using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DojinManagementSystem.Repository;
using static DojinManagementSystem.Tools.ImageCommon;

namespace DojinManagementSystem.Forms
{
    public partial class ViewInfoList : Form
    {
        public SearchEntity searchEntity = new SearchEntity(); //検索条件
        public List<ViewBookInfoAbstract> resultAbsList = new List<ViewBookInfoAbstract>(); //表示情報のリスト

        int nowPage; //今のページ
        int maxPage; //最大ページ

        BookInfoRepository _BookInfoRepository = new BookInfoRepository();
        BookCharaInfoRepository _BookCharaInfoRepository = new BookCharaInfoRepository();
        BookOmumibusInfoRepository _BookOmunibusInfoRepository = new BookOmumibusInfoRepository();
        BookJointInfoRepository _BookJointInfoRepository = new BookJointInfoRepository();

        bool flgInitial = true; //true:読み込み情報なし false:読み込み情報なし

        public ViewInfoList()
        {
            InitializeComponent();
            flgInitial = true;
        }

        
        /// <summary>
        /// 表示情報のリロード
        /// </summary>
        public void Reload()
        {
            //表示内容の削除
            ClearInfo(true);

            //表示情報がある時にそれぞれの処理
            if (resultAbsList.Count != 0)
            {
            
                //最大ページのカウント
                int resultCnt = resultAbsList.Count;
                maxPage = (resultCnt / 8) + 1;
                //ページ数が8の倍数の時は1引く
                if(resultCnt % 8 == 0)
                {
                    maxPage = maxPage - 1;
                }
                txtMaxPage.Text = maxPage.ToString();

                //今のページを1に
                nowPage = 1;
                txtViewPage.Text = nowPage.ToString();

                //1ページ目の情報を表示                
                MovePage(1);

                //初期状態フラグを折る
                flgInitial = false;
            }   
            else
            {
                resultAbsList = new List<ViewBookInfoAbstract>();
                flgInitial = true;
            }
        }

        private void ResearchAndReload()
        {
            //再検索する
            resultAbsList = new List<ViewBookInfoAbstract>();
            resultAbsList = _BookInfoRepository.SearchAbstracts(searchEntity); 

            //検索結果のウィンドウを再ロード
            Reload();
        }

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="AllInitialize">true…ページ情報、内部情報も初期化　false…本の情報表示部のみ消す</param>
        public void ClearInfo(bool AllInitialize)
        {
            //Info1
            Info1.SetTitle("");
            Info1.SetCircle("");
            Info1.SetOriginal("");
            Info1.SetPublishDate(null);
            Info1.ResetR18();
            Info1.SetGenre("");
            Info1.resetCover();
            //Info2
            Info2.SetTitle("");
            Info2.SetCircle("");
            Info2.SetOriginal("");
            Info2.SetPublishDate(null);
            Info2.ResetR18();
            Info2.SetGenre("");
            Info2.resetCover();
            //Info3
            Info3.SetTitle("");
            Info3.SetCircle("");
            Info3.SetOriginal("");
            Info3.SetPublishDate(null);
            Info3.ResetR18();
            Info3.SetGenre("");
            Info3.resetCover();
            //Info4
            Info4.SetTitle("");
            Info4.SetCircle("");
            Info4.SetOriginal("");
            Info4.SetPublishDate(null);
            Info4.ResetR18();
            Info4.SetGenre("");
            Info4.resetCover();
            //Info5
            Info5.SetTitle("");
            Info5.SetCircle("");
            Info5.SetOriginal("");
            Info5.SetPublishDate(null);
            Info5.ResetR18();
            Info5.SetGenre("");
            Info5.resetCover();
            //Info6
            Info6.SetTitle("");
            Info6.SetCircle("");
            Info6.SetOriginal("");
            Info6.SetPublishDate(null);
            Info6.ResetR18();
            Info6.SetGenre("");
            Info6.resetCover();
            //Info7
            Info7.SetTitle("");
            Info7.SetCircle("");
            Info7.SetOriginal("");
            Info7.SetPublishDate(null);
            Info7.ResetR18();
            Info7.SetGenre("");
            Info7.resetCover();
            //Info8
            Info8.SetTitle("");
            Info8.SetCircle("");
            Info8.SetOriginal("");
            Info8.SetPublishDate(null);
            Info8.ResetR18();
            Info8.SetGenre("");
            Info8.resetCover();
            if (AllInitialize == true)
            {
                //ページ数
                txtViewPage.Text = "";
                txtMaxPage.Text = "";
                //内部情報の初期化
                nowPage = 0;
                maxPage = 0;
                flgInitial = true;
            }
        }

        /// <summary>
        /// ページを1つ進めるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForword_Click(object sender, EventArgs e)
        {
            //初期状態の時、今が最後のページの時は何もしない
            if (flgInitial == true) return;
            if (nowPage >= maxPage) return;

            //現在のページをインクリメント
            nowPage += 1;
            txtViewPage.Text = nowPage.ToString();

            //表示情報更新
            MovePage(nowPage);
            
        }

        /// <summary>
        /// ページを1つ戻すボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            //初期状態の時、今がはじめのページの時は何もしない
            if (flgInitial == true) return;
            if (nowPage == 1) return;

            //現在のページをデクリメント
            nowPage -= 1;
            txtViewPage.Text = nowPage.ToString();

            //表示情報更新
            MovePage(nowPage);
        }

        /// <summary>
        /// 最後のページに移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoEnd_Click(object sender, EventArgs e)
        {
            //初期状態の時、今が最後のページの時は何もしない
            if (flgInitial == true) return;
            if (nowPage >= maxPage) return;

            //現在のページを最終ページに
            nowPage = maxPage;
            txtViewPage.Text = nowPage.ToString();

            //表示情報更新
            MovePage(nowPage);
        }

        /// <summary>
        /// 最初のページに移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoFront_Click(object sender, EventArgs e)
        {
            //初期状態の時、今がはじめのページの時は何もしない
            if (flgInitial == true) return;
            if (nowPage == 1) return;

            //現在のページをデクリメント
            nowPage = 1;
            txtViewPage.Text = nowPage.ToString();

            //表示情報更新
            MovePage(nowPage);
        }

        /// <summary>
        /// ページ移動による表示更新
        /// </summary>
        /// <param name="newPageNo">移動先ページ</param>
        private void MovePage(int newPageNo)
        {
            //表示情報初期化
            ClearInfo(false);

            //データ件数を数える
            var datacount = resultAbsList.Count();

            //新しいページより前にいくつのデータがあるか数える
            var beforeDataCount = 8 * (newPageNo - 1);

            //情報表示
            if ((datacount-beforeDataCount) >= 1)
            {
                //Info1                
                //画像の存在確認
                //コントロールに値をセット
                Info1.SetTitle(resultAbsList[beforeDataCount].BookName);
                Info1.SetCircle(resultAbsList[beforeDataCount].CircleName);
                Info1.SetOriginal(resultAbsList[beforeDataCount].OriginalName);
                Info1.SetPublishDate(resultAbsList[beforeDataCount].PublishDate);
                Info1.SetR18(resultAbsList[beforeDataCount].FlgR18);
                Info1.SetGenre(resultAbsList[beforeDataCount].GenreName);
                //表紙画像セット
                string ImagePath1 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath1) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage1;
                    using (var fs = new System.IO.FileStream(ImagePath1, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage1 = new Bitmap(fs);

                        Bitmap Resized1;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage1.Height >= ReadImage1.Width)
                        {
                            Resized1 = ResizeImage_H(ReadImage1, Info1.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized1 = ResizeImage_W(ReadImage1, Info1.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info1.SetCover(Resized1);
                    }
                }                
                else
                {
                    Info1.resetCover();
                }
            }
            if ((datacount - beforeDataCount) >= 2)
            {
                //Info2                
                //画像の存在確認
                //コントロールに値をセット
                Info2.SetTitle(resultAbsList[beforeDataCount + 1].BookName);
                Info2.SetCircle(resultAbsList[beforeDataCount + 1].CircleName);
                Info2.SetOriginal(resultAbsList[beforeDataCount + 1].OriginalName);
                Info2.SetPublishDate(resultAbsList[beforeDataCount + 1].PublishDate);
                Info2.SetR18(resultAbsList[beforeDataCount + 1].FlgR18);
                Info2.SetGenre(resultAbsList[beforeDataCount + 1].GenreName);
                //表紙画像セット
                string ImagePath2 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount + 1].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath2) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage2;
                    using (var fs = new System.IO.FileStream(ImagePath2, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage2 = new Bitmap(fs);

                        Bitmap Resized2;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage2.Height >= ReadImage2.Width)
                        {
                            Resized2 = ResizeImage_H(ReadImage2, Info2.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized2 = ResizeImage_W(ReadImage2, Info2.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info2.SetCover(Resized2);
                    }
                }
                else
                {
                    Info2.resetCover();
                }
            }
            if ((datacount - beforeDataCount) >= 3)
            {
                //Info3                
                //画像の存在確認
                //コントロールに値をセット
                Info3.SetTitle(resultAbsList[beforeDataCount + 2].BookName);
                Info3.SetCircle(resultAbsList[beforeDataCount + 2].CircleName);
                Info3.SetOriginal(resultAbsList[beforeDataCount + 2].OriginalName);
                Info3.SetPublishDate(resultAbsList[beforeDataCount + 2].PublishDate);
                Info3.SetR18(resultAbsList[beforeDataCount + 2].FlgR18);
                Info3.SetGenre(resultAbsList[beforeDataCount + 2].GenreName);
                //表紙画像セット
                string ImagePath3 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount + 2].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath3) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage3;
                    using (var fs = new System.IO.FileStream(ImagePath3, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage3 = new Bitmap(fs);

                        Bitmap Resized3;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage3.Height >= ReadImage3.Width)
                        {
                            Resized3 = ResizeImage_H(ReadImage3, Info3.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized3 = ResizeImage_W(ReadImage3, Info3.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info3.SetCover(Resized3);
                    }
                }
                else
                {
                    Info3.resetCover();
                }
            }
            if ((datacount - beforeDataCount) >= 4)
            {
                //Info4                
                //画像の存在確認
                //コントロールに値をセット
                Info4.SetTitle(resultAbsList[beforeDataCount + 3].BookName);
                Info4.SetCircle(resultAbsList[beforeDataCount + 3].CircleName);
                Info4.SetOriginal(resultAbsList[beforeDataCount + 3].OriginalName);
                Info4.SetPublishDate(resultAbsList[beforeDataCount + 3].PublishDate);
                Info4.SetR18(resultAbsList[beforeDataCount + 3].FlgR18);
                Info4.SetGenre(resultAbsList[beforeDataCount + 3].GenreName);
                //表紙画像セット
                string ImagePath4 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount + 3].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath4) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage4;
                    using (var fs = new System.IO.FileStream(ImagePath4, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage4 = new Bitmap(fs);

                        Bitmap Resized4;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage4.Height >= ReadImage4.Width)
                        {
                            Resized4 = ResizeImage_H(ReadImage4, Info4.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized4 = ResizeImage_W(ReadImage4, Info4.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info4.SetCover(Resized4);
                    }
                }
                else
                {
                    Info4.resetCover();
                }
            }
            if ((datacount - beforeDataCount) >= 5)
            {
                //Info5                
                //画像の存在確認
                //コントロールに値をセット
                Info5.SetTitle(resultAbsList[beforeDataCount + 4].BookName);
                Info5.SetCircle(resultAbsList[beforeDataCount + 4].CircleName);
                Info5.SetOriginal(resultAbsList[beforeDataCount + 4].OriginalName);
                Info5.SetPublishDate(resultAbsList[beforeDataCount + 4].PublishDate);
                Info5.SetR18(resultAbsList[beforeDataCount + 4].FlgR18);
                Info5.SetGenre(resultAbsList[beforeDataCount + 4].GenreName);
                //表紙画像セット
                string ImagePath5 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount + 4].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath5) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage5;
                    using (var fs = new System.IO.FileStream(ImagePath5, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage5 = new Bitmap(fs);

                        Bitmap Resized5;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage5.Height >= ReadImage5.Width)
                        {
                            Resized5 = ResizeImage_H(ReadImage5, Info5.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized5 = ResizeImage_W(ReadImage5, Info5.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info5.SetCover(Resized5);
                    }
                }
                else
                {
                    Info5.resetCover();
                }
            }
            if ((datacount - beforeDataCount) >= 6)
            {
                //Info6                
                //画像の存在確認
                //コントロールに値をセット
                Info6.SetTitle(resultAbsList[beforeDataCount + 5].BookName);
                Info6.SetCircle(resultAbsList[beforeDataCount + 5].CircleName);
                Info6.SetOriginal(resultAbsList[beforeDataCount + 5].OriginalName);
                Info6.SetPublishDate(resultAbsList[beforeDataCount + 5].PublishDate);
                Info6.SetR18(resultAbsList[beforeDataCount + 5].FlgR18);
                Info6.SetGenre(resultAbsList[beforeDataCount + 5].GenreName);
                //表紙画像セット
                string ImagePath6 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount + 5].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath6) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage6;
                    using (var fs = new System.IO.FileStream(ImagePath6, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage6 = new Bitmap(fs);

                        Bitmap Resized6;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage6.Height >= ReadImage6.Width)
                        {
                            Resized6 = ResizeImage_H(ReadImage6, Info6.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized6 = ResizeImage_W(ReadImage6, Info6.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info6.SetCover(Resized6);
                    }
                }
                else
                {
                    Info6.resetCover();
                }
            }
            if ((datacount - beforeDataCount) >= 7)
            {
                //Info7                
                //画像の存在確認
                //コントロールに値をセット
                Info7.SetTitle(resultAbsList[beforeDataCount + 6].BookName);
                Info7.SetCircle(resultAbsList[beforeDataCount + 6].CircleName);
                Info7.SetOriginal(resultAbsList[beforeDataCount + 6].OriginalName);
                Info7.SetPublishDate(resultAbsList[beforeDataCount + 6].PublishDate);
                Info7.SetR18(resultAbsList[beforeDataCount + 6].FlgR18);
                Info7.SetGenre(resultAbsList[beforeDataCount + 6].GenreName);
                //表紙画像セット
                string ImagePath7 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount + 6].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath7) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage7;
                    using (var fs = new System.IO.FileStream(ImagePath7, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage7 = new Bitmap(fs);

                        Bitmap Resized7;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage7.Height >= ReadImage7.Width)
                        {
                            Resized7 = ResizeImage_H(ReadImage7, Info7.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized7 = ResizeImage_W(ReadImage7, Info7.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info7.SetCover(Resized7);
                    }
                }
                else
                {
                    Info7.resetCover();
                }
            }
            if ((datacount - beforeDataCount) >= 8)
            {
                //Info8                
                //画像の存在確認
                //コントロールに値をセット
                Info8.SetTitle(resultAbsList[beforeDataCount + 7].BookName);
                Info8.SetCircle(resultAbsList[beforeDataCount + 7].CircleName);
                Info8.SetOriginal(resultAbsList[beforeDataCount + 7].OriginalName);
                Info8.SetPublishDate(resultAbsList[beforeDataCount + 7].PublishDate);
                Info8.SetR18(resultAbsList[beforeDataCount + 7].FlgR18);
                Info8.SetGenre(resultAbsList[beforeDataCount + 7].GenreName);
                //表紙画像セット
                string ImagePath8 = Path.Combine(Properties.Settings.Default.PicutureFolder, resultAbsList[beforeDataCount + 7].BookId.ToString().Trim() + ".jpg");
                if (File.Exists(ImagePath8) == true)
                {
                    //画像ファイルを開くまでの一連の操作
                    // ファイルストリームでファイルを開いてBitmapに記録
                    Bitmap ReadImage8;
                    using (var fs = new System.IO.FileStream(ImagePath8, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        ReadImage8 = new Bitmap(fs);

                        Bitmap Resized8;
                        //縦長か横長か確認し、それによって方法かえて縮小
                        //縦長
                        if (ReadImage8.Height >= ReadImage8.Width)
                        {
                            Resized8 = ResizeImage_H(ReadImage8, Info8.GetCoverHeight());
                        }
                        //横長
                        else
                        {
                            Resized8 = ResizeImage_W(ReadImage8, Info8.GetCoverWidth());
                        }
                        //サイズ変更した画像を表示
                        Info8.SetCover(Resized8);
                    }
                }
                else
                {
                    Info8.resetCover();
                }
            }
        }

        /// <summary>
        /// Info1削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            DeleteInfo(1);
        }
        /// <summary>
        /// Info2削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete2_Click(object sender, EventArgs e)
        {
            DeleteInfo(2);
        }
        /// <summary>
        /// Info3削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete3_Click(object sender, EventArgs e)
        {
            DeleteInfo(3);
        }
        /// <summary>
        /// Info4削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete4_Click(object sender, EventArgs e)
        {
            DeleteInfo(4);
        }
        /// <summary>
        /// Info5削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete5_Click(object sender, EventArgs e)
        {
            DeleteInfo(5);
        }
        /// <summary>
        /// Info6削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete6_Click(object sender, EventArgs e)
        {
            DeleteInfo(6);
        }
        /// <summary>
        /// Info7削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete7_Click(object sender, EventArgs e)
        {
            DeleteInfo(7);
        }
        /// <summary>
        /// Info8削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete8_Click(object sender, EventArgs e)
        {
            DeleteInfo(8);
        }

        /// <summary>
        /// データの削除
        /// </summary>
        /// <param name="InfoNo">どの枠のデータを削除するか</param>
        private void DeleteInfo(int InfoNo)
        {
            //初期状態の時は何もしない
            if (flgInitial == true) return;

            //データ件数を数える
            var datacount = resultAbsList.Count();
            //今のページより前にいくつのデータがあるか数える
            var beforeDataCount = 8 * (nowPage - 1);

            //そこにデータがない時は何もしない
            if ((beforeDataCount + InfoNo) > datacount) return;

            //そこにあるデータを取得する
            var DeleteData = resultAbsList[beforeDataCount + InfoNo - 1];

            //確認する
            DialogResult r =
                MessageBox.Show
                (
                    text: "以下のデータを削除します。よろしいですか？\r\n" +
                        "\r\n" +
                        "タイトル:" + DeleteData.BookName + "\r\n" +
                        "サークル名:" + DeleteData.CircleName
                   ,caption: "削除確認"
                   ,buttons: MessageBoxButtons.OKCancel
                   ,icon: MessageBoxIcon.Warning
                ) ;
            if (r != DialogResult.OK) return;

            //今いるページを記録しておく
            var page = nowPage;
            //DBからデータを削除
            _BookInfoRepository.Delete(DeleteData.BookId);
            _BookCharaInfoRepository.Delete(DeleteData.BookId);
            _BookJointInfoRepository.Delete(DeleteData.BookId);
            _BookOmunibusInfoRepository.Delete(DeleteData.BookId);
            //画像を削除
            string DeletePath = Path.Combine(Properties.Settings.Default.PicutureFolder, DeleteData.BookId.ToString().Trim() + ".jpg");
            File.Delete(DeletePath);
            //手元のリストから削除
            resultAbsList.RemoveAt(beforeDataCount + InfoNo - 1);

            //削除報告
            MessageBox.Show("削除に成功しました。");

            //再読み込み
            Reload();

            //データが0件になったら初期状態へ
            if (resultAbsList.Count < 1)
            {
                ClearInfo(true);
                return;
            }

            //最後に読み込んでいたページに移動
            //削除で最後に読み込んだページが消えるときには1ページ前に
            if (resultAbsList.Count % 8 == 0)
            {
                //初期状態の時、今がはじめのページの時は何もしない
                if (flgInitial == true) return;
                if ((page - 1) <=  1) return;

                //現在のページ設定
                nowPage = page - 1;
                txtViewPage.Text = nowPage.ToString();

                MovePage(page - 1);
                return;
            }
            else
            {
                //初期状態の時、今がはじめのページの時は何もしない
                if (flgInitial == true) return;

                nowPage = page;
                txtViewPage.Text = nowPage.ToString();

                MovePage(page);
                return;
            }
        }

        /// <summary>
        /// Iinfo1編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit1_Click(object sender, EventArgs e)
        {
            EditInfo(1);
        }
        /// <summary>
        /// Iinfo2編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit2_Click(object sender, EventArgs e)
        {
            EditInfo(2);
        }
        /// <summary>
        /// Iinfo3編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit3_Click(object sender, EventArgs e)
        {
            EditInfo(3);
        }
        /// <summary>
        /// Iinfo4編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit4_Click(object sender, EventArgs e)
        {
            EditInfo(4);
        }
        /// <summary>
        /// Iinfo5編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit5_Click(object sender, EventArgs e)
        {
            EditInfo(5);
        }
        /// <summary>
        /// Iinfo6編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit6_Click(object sender, EventArgs e)
        {
            EditInfo(6);
        }
        /// <summary>
        /// Iinfo7編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit7_Click(object sender, EventArgs e)
        {
            EditInfo(7);
        }
        /// <summary>
        /// Iinfo7編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit8_Click(object sender, EventArgs e)
        {
            EditInfo(8);
        }

        /// <summary>
        /// データの編集
        /// </summary>
        /// <param name="InfoNo">どの枠のデータを編集するか</param>
        private void EditInfo(int InfoNo)
        {

            //初期状態の時は何もしない
            if (flgInitial == true) return;

            //データ件数を数える
            var datacount = resultAbsList.Count();
            //今のページより前にいくつのデータがあるか数える
            var beforeDataCount = 8 * (nowPage - 1);

            //そこにデータがない時は何もしない
            if ((beforeDataCount + InfoNo) > datacount) return;

            //そこにあるデータを取得する
            var EditData = resultAbsList[beforeDataCount + InfoNo - 1];

            //今のページを記録しておく
            var page = nowPage;

            //更新用のフォームを開く
            var editForm = new InputInfo(EditData.BookId);
            editForm.ShowDialog();

            //表示の初期化
            ResearchAndReload();

            //データが0件になったら初期状態へ
            if (resultAbsList.Count < 1)
            {
                ClearInfo(true);
                return;
            }

            //最後に読み込んでいたページに移動
            //削除で最後に読み込んだページが消えるときには1ページ前に
            if (resultAbsList.Count % 8 == 0)
            {
                //初期状態の時、今がはじめのページの時は何もしない
                if (flgInitial == true) return;
                if ((page - 1) <= 1) return;

                //現在のページ設定
                nowPage = page - 1;
                txtViewPage.Text = nowPage.ToString();

                MovePage(page - 1);
                return;
            }
            else
            {
                //初期状態の時、今がはじめのページの時は何もしない
                if (flgInitial == true) return;

                nowPage = page;
                txtViewPage.Text = nowPage.ToString();

                MovePage(page);
                return;
            }
        }
    }
}
