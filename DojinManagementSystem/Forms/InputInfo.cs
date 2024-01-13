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
using static DojinManagementSystem.Global;
using DojinManagementSystem.Repository;
using static DojinManagementSystem.Tools.Common;
using static DojinManagementSystem.Tools.OverForm;
using static DojinManagementSystem.Tools.ImageCommon;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace DojinManagementSystem.Forms
{
    public partial class InputInfo : Form
    {
        private int? EditId = null;

        private int EditMode;

        BookInfoRepository _BookInfoRepositoty = new BookInfoRepository();
        BookCharaInfoRepository _BookCharaInfoRepository = new BookCharaInfoRepository();
        BookOmumibusInfoRepository _BookOmunibusInfoRepository = new BookOmumibusInfoRepository();
        BookJointInfoRepository _BookJointInfoRepository = new BookJointInfoRepository();

        MSOriginalRepository _MSOriginalRepository = new MSOriginalRepository();
        MSCircleRepository _MSCircleRepository = new MSCircleRepository();
        MSCharaRepository _MSCharaRepository = new MSCharaRepository();

        public enum ExifSpinStyle : int
        {
            TopLeft = 1,
            TopRight = 2,
            BottomRight = 3,
            BottomLeft = 4,
            LeftTop = 5,
            RightTop = 6,
            RightBottom = 7,
            LeftBottom = 8
        }


        /// <summary>
        /// 新規用コンストラクタ
        /// </summary>
        public InputInfo()
        {
            //共通初期設定
            InitializeComponent();
            FirstSetup();

            //登録ボタンの名前
            btnRegistInfo.Text = "新規登録";

            //モード設定
            EditMode = Mode.New;

        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public InputInfo(int id)
        {
            //共通初期設定
            InitializeComponent();
            FirstSetup();
            //編集中のBookIdを記録
            EditId = id;

            //データの表示
            DispEditData(id);

            //登録ボタンの名前
            btnRegistInfo.Text = "更新";

            //モード設定
            EditMode = Mode.Edit;
        }

        /// <summary>
        /// ロード処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputInfo_Load(object sender, EventArgs e)
        {
            //タブの追加をする
            //コンストラクタではタブ追加ができないためここで行う
            if (chkOmnibus.Checked == true)
            {
                tabInput.TabPages.Insert(0, tbpOmunibus);
            }
            if (chkJoint.Checked == true)
            {
                tabInput.TabPages.Insert(0, tbpJoin);
            }
        }

        /// <summary>
        /// 共通初期設定
        /// </summary>
        private void FirstSetup()
        {
            //コンボボックスのセット
            SetCombobox(cmbCircle, "ms_circle", "id", "circle_name", true);
            SetCombobox(cmbEventName, "ms_event", "id", "event_name", true);
            SetCombobox(cmbGenre, "ms_genre", "id", "genre_name", true);
            SetCombobox(cmbOriginal, "ms_original", "id", "original_name", true);
            SetCombobox(cmbBuyWay, "ms_buy_way", "id", "buy_way", true);
            SetCombobox(cmbSize, "ms_size", "id", "size_name", true);

            //総集編と合同誌のタブのDataGridViewの列を設定する
            //総集編
            dgvInOmnibusBooks.Columns.Add("InOmnibusBookName","収録誌名");
            dgvInOmnibusBooks.Columns["InOmnibusBookName"].Width = 300;
            dgvInOmnibusBooks.Columns.Add("InOmnibusBookId", "収録誌ID");
            dgvInOmnibusBooks.Columns["InOmnibusBookId"].Width = 100;
            //合同誌
            dgvJoinAuthors.Columns.Add("JoinAuthorsName", "参加者名");
            dgvJoinAuthors.Columns["JoinAuthorsName"].Width = 175;
            dgvJoinAuthors.Columns.Add("JoinAuthorsCircleName", "参加者主催サークル");
            dgvJoinAuthors.Columns["JoinAuthorsCircleName"].Width = 155;
            dgvJoinAuthors.Columns.Add("JoinAuthorsCircleId", "サークルID");
            dgvJoinAuthors.Columns["JoinAuthorsCircleId"].Width = 80;

            //総集編と合同誌のタブを非表示に
            tabInput.TabPages.Remove(tbpOmunibus);
            tabInput.TabPages.Remove(tbpJoin);
        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 総集編チェックボックス変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkOmnibus_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOmnibus.Checked == true)
            {
                tabInput.TabPages.Insert(0,tbpOmunibus);
            }
            else
            {
                tabInput.TabPages.Remove(tbpOmunibus);
            }
        }

        /// <summary>
        /// 合同誌チェックボックス変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkJoint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJoint.Checked == true)
            {
                tabInput.TabPages.Insert(0, tbpJoin);
            }
            else
            {
                tabInput.TabPages.Remove(tbpJoin);
            }
        }

        /// <summary>
        /// 上部サークル検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchCircle_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchCircle();         
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CircleSearchDepo.CircleId == null) return;
            //帰ってきた検索結果をコンボボックスにセットする               
            cmbCircle.SelectedValue = CircleSearchDepo.CircleId.ToString();
            txtAuthor.Text = CircleSearchDepo.CircleMasterName;
        }

        /// <summary>
        /// イベント検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchEvent();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (EventSearchDepo.EventId == null) return;
            //帰ってきた検索結果をコンボボックスにセットする
            //発行日にイベントの開催日をセットする
            cmbEventName.SelectedValue = EventSearchDepo.EventId.ToString();
            dtiPublishDate.Set(EventSearchDepo.EventDate);
        }

        /// <summary>
        /// 原作検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchOrg_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchOrigine();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (OriginalSearchDepo.OriginalId == null) return;
            //帰ってきた検索結果をコンボボックスにセットする           
            cmbOriginal.SelectedValue = OriginalSearchDepo.OriginalId.ToString();
        }

        /// <summary>
        /// 特徴検索ボタン 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchChara1_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchChara();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CharaSearchDepo.CharaId == null) return;
            //帰ってきた結果を特徴1のテキストボックス類に入れてロックする
            txtChara1.Text = CharaSearchDepo.CharaName;
            txtChara1.Enabled = false;
            txtCharaId1.Text = CharaSearchDepo.CharaId.ToString();
        }

        /// <summary>
        /// 特徴検索ボタン 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchChara2_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchChara();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CharaSearchDepo.CharaId == null) return;
            //帰ってきた結果を特徴1のテキストボックス類に入れてロックする
            txtChara2.Text = CharaSearchDepo.CharaName;
            txtChara2.Enabled = false;
            txtCharaId2.Text = CharaSearchDepo.CharaId.ToString();
        }

        /// <summary>
        /// 特徴検索ボタン 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchChara3_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchChara();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CharaSearchDepo.CharaId == null) return;
            //帰ってきた結果を特徴1のテキストボックス類に入れてロックする
            txtChara3.Text = CharaSearchDepo.CharaName;
            txtChara3.Enabled = false;
            txtCharaId3.Text = CharaSearchDepo.CharaId.ToString();
        }

        /// <summary>
        /// 特徴検索ボタン 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchChara4_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchChara();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CharaSearchDepo.CharaId == null) return;
            //帰ってきた結果を特徴1のテキストボックス類に入れてロックする
            txtChara4.Text = CharaSearchDepo.CharaName;
            txtChara4.Enabled = false;
            txtCharaId4.Text = CharaSearchDepo.CharaId.ToString();
        }

        /// <summary>
        /// 特徴検索ボタン 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchChara5_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchChara();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CharaSearchDepo.CharaId == null) return;
            //帰ってきた結果を特徴1のテキストボックス類に入れてロックする
            txtChara5.Text = CharaSearchDepo.CharaName;
            txtChara5.Enabled = false;
            txtCharaId5.Text = CharaSearchDepo.CharaId.ToString();
        }

        /// <summary>
        /// 特徴検索ボタン 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchChara6_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchChara();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CharaSearchDepo.CharaId == null) return;
            //帰ってきた結果を特徴1のテキストボックス類に入れてロックする
            txtChara6.Text = CharaSearchDepo.CharaName;
            txtChara6.Enabled = false;
            txtCharaId6.Text = CharaSearchDepo.CharaId.ToString();
        }

        /// <summary>
        /// 特徴クリアボタン 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChara1_Click(object sender, EventArgs e)
        {
            txtChara1.Text = "";
            txtCharaId1.Text = "";
            txtChara1.Enabled = true;
        }

        /// <summary>
        /// 特徴クリアボタン 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChara2_Click(object sender, EventArgs e)
        {
            txtChara2.Text = "";
            txtCharaId2.Text = "";
            txtChara2.Enabled = true;
        }

        /// <summary>
        /// 特徴クリアボタン 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChara3_Click(object sender, EventArgs e)
        {
            txtChara3.Text = "";
            txtCharaId3.Text = "";
            txtChara3.Enabled = true;
        }

        /// <summary>
        /// 特徴クリアボタン 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChara4_Click(object sender, EventArgs e)
        {
            txtChara4.Text = "";
            txtCharaId4.Text = "";
            txtChara4.Enabled = true;
        }

        /// <summary>
        /// 特徴クリアボタン 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChara5_Click(object sender, EventArgs e)
        {
            txtChara5.Text = "";
            txtCharaId5.Text = "";
            txtChara5.Enabled = true;
        }

        /// <summary>
        /// 特徴クリアボタン 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChara6_Click(object sender, EventArgs e)
        {
            txtChara6.Text = "";
            txtCharaId6.Text = "";
            txtChara6.Enabled = true;
        }

        /// <summary>
        /// 初刊検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            int? SelectedCircle;
            int? SelectedOriginal;
            //コンボボックスの値を取得
            //サークル情報
            if(cmbCircle.SelectedValue.ToString() == "null")
            {
                SelectedCircle = null;
            }
            else
            {
                SelectedCircle = int.Parse(cmbCircle.SelectedValue.ToString());
            }
            //原作情報
            if (cmbOriginal.SelectedValue.ToString() == "null")
            {
                SelectedOriginal = null;
            }
            else
            {
                SelectedOriginal = int.Parse(cmbOriginal.SelectedValue.ToString());
            }
            Form form = new TableSearch.SearchBookInfo(SelectedCircle,SelectedOriginal);
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (BookInfoSearchDepo_Lite.BookId == null) return;
            //検索結果があった場合はテキストをセットしてロックする
            txtFirstName.Text = BookInfoSearchDepo_Lite.BookName;
            txtFirstId.Text = BookInfoSearchDepo_Lite.BookId.ToString();
            txtFirstName.Enabled = false;
        }

        /// <summary>
        /// 初刊クリアボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFirst_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtFirstId.Text = "";
            txtFirstName.Enabled = true;
        }

        /// <summary>
        /// 表紙画像登録ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistCover_Click(object sender, EventArgs e)
        {
            //インスタンス作成
            OpenFileDialog Ofd = new OpenFileDialog();

            //ファイルダイアログの設定を行う
            //前回開いたフォルダがあればそこを開くようにする
            if (SystemDepo.OpenImageFolder == null)
            {
                Ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }
            else
            {
                Ofd.InitialDirectory = SystemDepo.OpenImageFolder;
            }
            Ofd.Filter = "画像ファイル(*.png;*.jpg;*.bmp,*.tif)|*.png;*.jpg;*.bmp;*.tif";
            Ofd.Title = "登録する画像を選択してください";
            Ofd.RestoreDirectory = true;

            //ファイルダイアログを表示
            DialogResult d = Ofd.ShowDialog();

            //結果が帰ってきたら続きの処理を行う
            if(d == DialogResult.OK)
            {
                //ファイル名とフォルダーPathを記録
                string FileName = Ofd.FileName;
                SystemDepo.OpenImageFolder = Path.GetDirectoryName(FileName);

                //画像ファイルを開くまでの一連の操作
                // ファイルの存在を確認
                if (System.IO.File.Exists(FileName) == false) return;
                // 拡張子の確認
                var ext = System.IO.Path.GetExtension(FileName).ToLower();
                // ファイルの拡張子が対応しているファイルかどうか調べる
                if ((ext != ".bmp") && (ext != ".jpg") && (ext != ".png") && (ext != ".tif")) return;                                
                // ファイルストリームでファイルを開いてBitmapに記録
                Bitmap ReadImage;
                using (var fs = new System.IO.FileStream(FileName,System.IO.FileMode.Open,System.IO.FileAccess.Read))
                {
                    ReadImage = new Bitmap(fs);
                    //Exif情報を読み込んで回転させる
                    var property = ReadImage.PropertyItems.FirstOrDefault(p => p.Id == 0x0112);
                    if(property != null)
                    {
                        var rotation = RotateFlipType.RotateNoneFlipNone;
                        var SpinStyle = (ExifSpinStyle)BitConverter.ToUInt16(property.Value, 0);
                        switch(SpinStyle)
                        {
                            case ExifSpinStyle.TopLeft:
                                break;

                            case ExifSpinStyle.TopRight:
                                rotation = RotateFlipType.RotateNoneFlipX;
                                break;

                            case ExifSpinStyle.BottomRight:
                                rotation = RotateFlipType.Rotate180FlipNone;
                                break;

                            case ExifSpinStyle.BottomLeft:
                                rotation = RotateFlipType.RotateNoneFlipY;
                                break;

                            case ExifSpinStyle.LeftTop:
                                rotation = RotateFlipType.Rotate270FlipY;
                                break;

                            case ExifSpinStyle.RightTop:
                                rotation = RotateFlipType.Rotate90FlipNone;
                                break;

                            case ExifSpinStyle.RightBottom:
                                rotation = RotateFlipType.Rotate90FlipY;
                                break;

                            case ExifSpinStyle.LeftBottom:
                                rotation = RotateFlipType.Rotate270FlipNone;
                                break;
                        }
                        ReadImage.RotateFlip(rotation);

                        property.Value = BitConverter.GetBytes((int)ExifSpinStyle.TopLeft);
                        ReadImage.SetPropertyItem(property);
                    }
                    //読み込んだした画像をjpgにして一時フォルダに保管しておく
                    ReadImage.Save(Path.Combine(SystemOnetime.OnetimeFolderPath, "ResizedImage.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);

                    Bitmap Resized;
                    //縦長か横長か確認し、それによって方法かえて縮小
                    //縦長
                    if(ReadImage.Height >= ReadImage.Width)
                    {
                        Resized = ResizeImage_H(ReadImage, pbCover.Height);
                    }
                    //横長
                    else
                    {
                        Resized = ResizeImage_W(ReadImage, pbCover.Width);
                    }                    
                    //サイズ変更した画像を表示
                    pbCover.Image = Resized;
                }

                
            }

        }

        /// <summary>
        /// 総集編タブ検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            int? SelectedCircle;
            int? SelectedOriginal;
            //コンボボックスの値を取得
            //サークル情報
            if (cmbCircle.SelectedValue.ToString() == "null")
            {
                SelectedCircle = null;
            }
            else
            {
                SelectedCircle = int.Parse(cmbCircle.SelectedValue.ToString());
            }
            //原作情報
            if (cmbOriginal.SelectedValue.ToString() == "null")
            {
                SelectedOriginal = null;
            }
            else
            {
                SelectedOriginal = int.Parse(cmbOriginal.SelectedValue.ToString());
            }
            Form form = new TableSearch.SearchBookInfo(SelectedCircle, SelectedOriginal);
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (BookInfoSearchDepo_Lite.BookId == null) return;
            //検索結果があった場合はその結果をDataGridViewに入れる
            dgvInOmnibusBooks.Rows.Add();
            dgvInOmnibusBooks.Rows[dgvInOmnibusBooks.RowCount - 1].Cells["InOmnibusBookName"].Value = BookInfoSearchDepo_Lite.BookName;
            dgvInOmnibusBooks.Rows[dgvInOmnibusBooks.RowCount - 1].Cells["InOmnibusBookId"].Value = BookInfoSearchDepo_Lite.BookId;
        }

        /// <summary>
        /// 総集編タブ追加ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtInOmnibus.Text) == false)
            {
                dgvInOmnibusBooks.Rows.Add();
                dgvInOmnibusBooks.Rows[dgvInOmnibusBooks.RowCount - 1].Cells["InOmnibusBookName"].Value = txtInOmnibus.Text;
                dgvInOmnibusBooks.Rows[dgvInOmnibusBooks.RowCount - 1].Cells["InOmnibusBookId"].Value = "";
                txtInOmnibus.Text = "";
            }
        }

        /// <summary>
        /// 総集編タブ削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvInOmnibusBooks.RowCount <= 0) return;
            if (dgvInOmnibusBooks.CurrentRow.Index <= -1) return;

            dgvInOmnibusBooks.Rows.Remove(dgvInOmnibusBooks.CurrentRow);
        }

        /// <summary>
        /// 合同誌タブ検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchJoinAuthor_Click(object sender, EventArgs e)
        {
            Form from = new TableSearch.SearchCircle();
            from.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CircleSearchDepo.CircleId == null) return;
            //帰ってきた検索結果をDatagridViewに入れる           
            dgvJoinAuthors.Rows.Add();
            dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsName"].Value = CircleSearchDepo.CircleMasterName;
            dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsCircleName"].Value = CircleSearchDepo.CircleName;
            dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsCircleId"].Value = CircleSearchDepo.CircleId;
        }

        /// <summary>
        /// 合同誌タブ追加ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtJoinAuthor.Text) == false)
            {
                dgvJoinAuthors.Rows.Add();
                dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsName"].Value = txtJoinAuthor.Text;
                dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsCircleName"].Value = "";
                dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsCircleId"].Value = "";
                txtJoinAuthor.Text = "";
            }
        }

        /// <summary>
        /// 合同誌タブ削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteJoinAuthor_Click(object sender, EventArgs e)
        {
            if (dgvJoinAuthors.RowCount <= 0) return;
            if (dgvJoinAuthors.CurrentRow.Index <= -1) return;

            dgvJoinAuthors.Rows.Remove(dgvJoinAuthors.CurrentRow);
        }

        /// <summary>
        /// 登録・更新ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistInfo_Click(object sender, EventArgs e)
        {
            #region
            //入力確認
            if (InputCheck() == false) return;

            //データ照会
            DataInquiry();

            //登録用同人誌基本情報の作成
            TableBookInfo regist = new TableBookInfo();
            //BookId
            if (EditMode == Mode.Edit)
            {
                regist.BookId = EditId ?? 0;
            }
            else
            {
                regist.BookId = 0;
            }
            //同人誌名
            regist.BookName = txtTitle.Text.Trim();
            //巻数
            if(String.IsNullOrEmpty(txtNo.Text) == false)
            {
                regist.SeriesNo = int.Parse(txtNo.Text);
            }
            else
            {
                regist.SeriesNo = null;
            }
            //初刊名
            regist.FirstName = txtFirstName.Text;
            //初刊ID
            if(string.IsNullOrEmpty(txtFirstId.Text) == false)
            {
                regist.FirstId = int.Parse(txtFirstId.Text);
            }
            else
            {
                regist.FirstId = null;
            }
            //サークルID
            if(cmbCircle.SelectedValue.ToString() != "null")
            {
                regist.CircleId = int.Parse(cmbCircle.SelectedValue.ToString());
            }
            else
            {
                regist.CircleId = null;
            }
            //作者名
            regist.Author = txtAuthor.Text;
            //イベントID
            if (cmbEventName.SelectedValue.ToString() != "null")
            {
                regist.EventId = int.Parse(cmbEventName.SelectedValue.ToString());
            }
            else
            {
                regist.EventId = null;
            }
            //発行日
            regist.PublishDate = dtiPublishDate.Value;
            //ジャンル
            if (cmbGenre.SelectedValue.ToString() != "null")
            {
                regist.GenreId = int.Parse(cmbGenre.SelectedValue.ToString());
            }
            else
            {
                regist.GenreId = null;
            }
            //原作名
            if (cmbOriginal.SelectedValue.ToString() != "null")
            {
                regist.OriginalId = int.Parse(cmbOriginal.SelectedValue.ToString());
            }
            else
            {
                regist.OriginalId = null;
            }
            //R18フラグ
            regist.FlgR18 = chkR18.Checked;
            //総集編フラグ
            regist.FlgOmnibus = chkOmnibus.Checked;
            //合同誌フラグ
            regist.FlgJoint = chkJoint.Checked;
            //コピー誌フラグ
            regist.FlgCopy = chkCopy.Checked;
            //サイズID
            if (cmbSize.SelectedValue.ToString() != "null")
            {
                regist.SizeId = int.Parse(cmbSize.SelectedValue.ToString());
            }
            else
            {
                regist.SizeId = null;
            }
            //購入日
            regist.BuyDate = dtiBuyDate.Value;
            //金額
            if (string.IsNullOrEmpty(txtPrice.Text) == false)
            {
                regist.Price = int.Parse(txtPrice.Text);
            }
            else
            {
                regist.Price = null;
            }
            //購入方法
            if (cmbBuyWay.SelectedValue.ToString() != "null")
            {
                regist.BuyWayId = int.Parse(cmbBuyWay.SelectedValue.ToString());
            }
            else
            {
                regist.BuyWayId = null;
            }
            //メモ
            regist.Memo = txtMemo.Text;            


            //登録用同人誌特徴情報の作成
            List<TableBookCharaInfo> registChara = new List<TableBookCharaInfo>();
            //一時保存用            
            int id = 0;
            int order = 0;
            //特徴1
            if(string.IsNullOrEmpty(txtChara1.Text) == false)
            {
                TableBookCharaInfo regcha = new TableBookCharaInfo();
                order += 1;
                regcha.CharaOrder = order;
                regcha.CharaName = txtChara1.Text;
                if(string.IsNullOrEmpty(txtCharaId1.Text) == false && int.TryParse(txtCharaId1.Text,out id) == true)
                {
                    regcha.CharaId = id;
                }
                else
                {
                    regcha.CharaId = null;
                }
                registChara.Add(regcha);
            }
            //特徴2            
            if (string.IsNullOrEmpty(txtChara2.Text) == false)
            {
                TableBookCharaInfo regcha = new TableBookCharaInfo();
                order += 1;
                regcha.CharaOrder = order;
                regcha.CharaName = txtChara2.Text;
                if (string.IsNullOrEmpty(txtCharaId2.Text) == false && int.TryParse(txtCharaId2.Text, out id) == true)
                {
                    regcha.CharaId = id;
                }
                else
                {
                    regcha.CharaId = null;
                }
                registChara.Add(regcha);
            }
            //特徴3
            if (string.IsNullOrEmpty(txtChara3.Text) == false)
            {
                TableBookCharaInfo regcha = new TableBookCharaInfo();
                order += 1;
                regcha.CharaOrder = order;
                regcha.CharaName = txtChara3.Text;
                if (string.IsNullOrEmpty(txtCharaId3.Text) == false && int.TryParse(txtCharaId3.Text, out id) == true)
                {
                    regcha.CharaId = id;
                }
                else
                {
                    regcha.CharaId = null;
                }
                registChara.Add(regcha);
            }
            //特徴4
            if (string.IsNullOrEmpty(txtChara4.Text) == false)
            {
                TableBookCharaInfo regcha = new TableBookCharaInfo();
                order += 1;
                regcha.CharaOrder = order;
                regcha.CharaName = txtChara4.Text;
                if (string.IsNullOrEmpty(txtCharaId4.Text) == false && int.TryParse(txtCharaId4.Text, out id) == true)
                {
                    regcha.CharaId = id;
                }
                else
                {
                    regcha.CharaId = null;
                }
                registChara.Add(regcha);
            }
            //特徴5
            if (string.IsNullOrEmpty(txtChara5.Text) == false)
            {
                TableBookCharaInfo regcha = new TableBookCharaInfo();
                order += 1;
                regcha.CharaOrder = order;
                regcha.CharaName = txtChara5.Text;
                if (string.IsNullOrEmpty(txtCharaId5.Text) == false && int.TryParse(txtCharaId5.Text, out id) == true)
                {
                    regcha.CharaId = id;
                }
                else
                {
                    regcha.CharaId = null;
                }
                registChara.Add(regcha);
            }
            //特徴6
            if (string.IsNullOrEmpty(txtChara6.Text) == false)
            {
                TableBookCharaInfo regcha = new TableBookCharaInfo();
                order += 1;
                regcha.CharaOrder = order;
                regcha.CharaName = txtChara6.Text;
                if (string.IsNullOrEmpty(txtCharaId6.Text) == false && int.TryParse(txtCharaId6.Text, out id) == true)
                {
                    regcha.CharaId = id;
                }
                else
                {
                    regcha.CharaId = null;
                }
                registChara.Add(regcha);
            }

            //登録用同人誌総集編情報の作成（総集編チェックボックスチェック時）
            List<TableBookOmunibusInfo> registOmunibus = new List<TableBookOmunibusInfo>();
            if (chkOmnibus.Checked == true)
            {                
                if(dgvInOmnibusBooks.RowCount > 0)
                {
                    for(int i = 0;i < dgvInOmnibusBooks.RowCount;i++)
                    {                       
                        TableBookOmunibusInfo regomn = new TableBookOmunibusInfo();                        
                        //DataGridViewの情報を取得
                        string regTitle = "";
                        int? regId = null;
                        if(dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookName"].Value != null)
                        {
                            regTitle = dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookName"].Value.ToString();
                        }
                        if (dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookId"].Value != null)
                        {
                            int a;
                            if(int.TryParse(dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookId"].Value.ToString(),out a) == true)
                            {
                                regId = a;
                            }                           
                        }
                        regomn.PutOrder = i + 1;
                        regomn.PutTitle = regTitle;
                        regomn.PutBookId = regId;
                        //リストに追加
                        registOmunibus.Add(regomn);
                    }
                }
            }            

            //登録用同人誌合同誌情報の作成
            List <TableBookJointInfo> registJoint = new List<TableBookJointInfo>();
            if(chkJoint.Checked == true)
            {
                if(dgvJoinAuthors.RowCount > 0)
                {
                    for(int i=0;i<dgvJoinAuthors.RowCount;i++)
                    {
                        TableBookJointInfo regjoi = new TableBookJointInfo();
                        //DataGridViewの情報を取得
                        string regName = "";
                        int? regCirId = null;
                        if(dgvJoinAuthors.Rows[i].Cells["JoinAuthorsName"].Value != null)
                        {
                            regName = dgvJoinAuthors.Rows[i].Cells["JoinAuthorsName"].Value.ToString();
                        }
                        if(dgvJoinAuthors.Rows[i].Cells["JoinAuthorsCircleId"].Value != null)
                        {
                            int b;
                            if (int.TryParse(dgvJoinAuthors.Rows[i].Cells["JoinAuthorsCircleId"].Value.ToString(), out b) == true)
                            {
                                regCirId = b;
                            }                                                       
                        }
                        regjoi.JoinOrder = i + 1;
                        regjoi.JoinName = regName;
                        regjoi.JoinCircleId = regCirId;
                        //リストに追加
                        registJoint.Add(regjoi);
                    }
                }
            }
            
            //各情報の登録・更新                            
            if (EditMode == Mode.New)
            {
                //同人誌基本情報
                int newBookId = -1;
                newBookId = _BookInfoRepositoty.Insert(regist);
                //特徴情報
                for (int i = 0; i < registChara.Count; i++)
                {
                    registChara[i].BookId = newBookId;
                    _BookCharaInfoRepository.Insert(registChara[i]);
                }
                //総集編情報
                if(chkOmnibus.Checked == true)
                {
                    for(int i = 0;i<registOmunibus.Count;i++)
                    {
                        registOmunibus[i].BookId = newBookId;
                        _BookOmunibusInfoRepository.Insert(registOmunibus[i]);
                    }
                }
                //合同誌情報
                if(chkJoint.Checked == true)
                {
                    for(int i = 0;i<registJoint.Count;i++)
                    {
                        registJoint[i].BookId = newBookId;
                        _BookJointInfoRepository.Insert(registJoint[i]);
                    }
                }
                //表紙の画像を保存
                string PictureName = newBookId.ToString() + ".jpg";
                string FileFrom = Path.Combine(SystemOnetime.OnetimeFolderPath, "ResizedImage.jpg");
                string FileTo = Path.Combine(Properties.Settings.Default.PicutureFolder, PictureName);
                if (File.Exists(FileFrom) == true)
                {
                    File.Copy(FileFrom, FileTo, true);
                    File.Delete(FileFrom);
                }

                MessageBox.Show("新規登録しました。");
            }
            else if (EditMode == Mode.Edit)
            {
                //同人誌基本情報
                _BookInfoRepositoty.Update(regist);
                //特徴情報
                _BookCharaInfoRepository.Delete(EditId ?? -1);
                for (int i = 0; i < registChara.Count; i++)
                {
                    registChara[i].BookId = EditId ?? -1;
                    _BookCharaInfoRepository.Insert(registChara[i]);
                }
                //総集編情報
                if (chkOmnibus.Checked == true)
                {
                    _BookOmunibusInfoRepository.Delete(EditId ?? -1);
                    for (int i = 0; i < registOmunibus.Count; i++)
                    {
                        registOmunibus[i].BookId = EditId ?? -1;
                        _BookOmunibusInfoRepository.Insert(registOmunibus[i]);
                    }
                }
                //合同誌情報
                if (chkJoint.Checked == true)
                {
                    _BookJointInfoRepository.Delete(EditId ?? -1);
                    for (int i = 0; i < registJoint.Count; i++)
                    {
                        registJoint[i].BookId = EditId ?? -1;
                        _BookJointInfoRepository.Insert(registJoint[i]);
                    }
                }
                //表紙の画像を保存
                string PictureName = EditId.ToString() + ".jpg";
                string FileFrom = Path.Combine(SystemOnetime.OnetimeFolderPath, "ResizedImage.jpg");
                string FileTo = Path.Combine(Properties.Settings.Default.PicutureFolder, PictureName);
                if (File.Exists(FileFrom) == true)
                {
                    File.Copy(FileFrom, FileTo, true);
                    File.Delete(FileFrom);
                }

                MessageBox.Show("データ更新しました。");

                this.Close();
            }
            #endregion
        }

        /// <summary>
        /// データ表示
        /// </summary>
        /// <param name="id"></param>
        private void DispEditData(int id)
        {
            TableBookInfo t = new TableBookInfo();
            List<TableBookCharaInfo> tc = new List<TableBookCharaInfo>();
            List<TableBookOmunibusInfo> to = new List<TableBookOmunibusInfo>();
            List<TableBookJointInfo> tj = new List<TableBookJointInfo>();

            //データ取得
            t = _BookInfoRepositoty.SelectById(id);
            tc = _BookCharaInfoRepository.SelectById(id);
            if(t.FlgOmnibus == true)
            {
                to = _BookOmunibusInfoRepository.SelectById(id);
            }
            if(t.FlgJoint == true)
            {
                tj = _BookJointInfoRepository.SelectById(id);
            }

            //データの表示
            //タイトル
            if(string.IsNullOrEmpty(t.BookName) == false)
            {
                txtTitle.Text = t.BookName;
            }
            //サークルID
            if(t.CircleId != null)
            {
                cmbCircle.SelectedValue = t.CircleId.ToString();                
            }
            //作者名
            if (string.IsNullOrEmpty(t.Author) == false)
            {
                txtAuthor.Text = t.Author;
            }
            //初刊名
            if(string.IsNullOrEmpty(t.FirstName) == false)
            {
                txtFirstName.Text = t.FirstName;
            }
            //初刊ID
            if(t.FirstId != null)
            {                
                txtFirstId.Text = t.FirstId.ToString();
                //初刊IDがあるときは初刊名はenableに
                txtFirstName.Enabled = false;
            }
            //巻数
            if(t.SeriesNo != null)
            {
                txtNo.Text = t.SeriesNo.ToString();
            }
            //発行日
            if(t.PublishDate != null)
            {
                dtiPublishDate.Set(t.PublishDate);
            }
            //発行イベント
            if(t.EventId != null)
            {
                cmbEventName.SelectedValue = t.EventId.ToString();
            }
            //ジャンル
            if(t.GenreId != null)
            {
                cmbGenre.SelectedValue = t.GenreId.ToString();
            }
            //原作
            if(t.OriginalId != null)
            {
                cmbOriginal.SelectedValue = t.OriginalId.ToString();
            }
            //R18フラグ
            chkR18.Checked = t.FlgR18;
            //総集編フラグ
            chkOmnibus.Checked = t.FlgOmnibus;
            if (chkOmnibus.Checked == true)
            {
                tabInput.TabPages.Insert(0, tbpOmunibus);
            }
            //合同誌フラグ
            chkJoint.Checked = t.FlgJoint;
            if (chkJoint.Checked == true)
            {
                tabInput.TabPages.Insert(0, tbpJoin);
            }
            //コピー誌フラグ
            chkCopy.Checked = t.FlgCopy;
            //購入日
            if(t.BuyDate != null)
            {
                dtiBuyDate.Set(t.BuyDate);
            }
            //値段
            if(t.Price != null)
            {
                txtPrice.Text = t.Price.ToString();
            }
            //購入方法
            if(t.BuyWayId != null)
            {
                cmbBuyWay.SelectedValue = t.BuyWayId.ToString();
            }
            //サイズ
            if(t.SizeId != null)
            {
                cmbSize.SelectedValue = t.SizeId.ToString();
            }
            //特徴
            for(int i = 0;i<tc.Count;i++)
            {
                if(string.IsNullOrEmpty(tc[i].CharaName) == false)
                {                    
                    switch (i)
                    {
                        case 0:
                            txtChara1.Text = tc[i].CharaName;
                            if(tc[i].CharaId != null)
                            {
                                txtCharaId1.Text = tc[i].CharaId.ToString();
                                txtChara1.Enabled = false;
                            }
                            break;
                        case 1:
                            txtChara2.Text = tc[i].CharaName;
                            if (tc[i].CharaId != null)
                            {
                                txtCharaId2.Text = tc[i].CharaId.ToString();
                                txtChara2.Enabled = false;
                            }
                            break;
                        case 2:
                            txtChara3.Text = tc[i].CharaName;
                            if (tc[i].CharaId != null)
                            {
                                txtCharaId3.Text = tc[i].CharaId.ToString();
                                txtChara3.Enabled = false;
                            }
                            break;
                        case 3:
                            txtChara4.Text = tc[i].CharaName;
                            if (tc[i].CharaId != null)
                            {
                                txtCharaId4.Text = tc[i].CharaId.ToString();
                                txtChara4.Enabled = false;
                            }
                            break;
                        case 4:
                            txtChara5.Text = tc[i].CharaName;
                            if (tc[i].CharaId != null)
                            {
                                txtCharaId5.Text = tc[i].CharaId.ToString();
                                txtChara5.Enabled = false;
                            }
                            break;
                        case 5:
                            txtChara6.Text = tc[i].CharaName;
                            if (tc[i].CharaId != null)
                            {
                                txtCharaId6.Text = tc[i].CharaId.ToString();
                                txtChara6.Enabled = false;
                            }
                            break;
                    }
                }                                                            
            }
            //メモ
            txtMemo.Text = t.Memo;

            //総集編情報
            if(t.FlgOmnibus == true)
            {
                to = _BookOmunibusInfoRepository.SelectById(id);
                for(int i= 0;i<to.Count;i++)
                {
                    if (string.IsNullOrEmpty(to[i].PutTitle) == false)
                    {
                        dgvInOmnibusBooks.Rows.Add();
                        dgvInOmnibusBooks.Rows[dgvInOmnibusBooks.RowCount - 1].Cells["InOmnibusBookName"].Value = to[i].PutTitle;
                        if(to[i].PutBookId != null)
                        {
                            dgvInOmnibusBooks.Rows[dgvInOmnibusBooks.RowCount - 1].Cells["InOmnibusBookId"].Value = to[i].PutBookId.ToString();
                        }                        
                    }
                }               
            }

            //合同誌情報
            if(t.FlgJoint == true)
            {
                tj = _BookJointInfoRepository.SelectById(id);
                for(int i=0;i<tj.Count;i++)
                {
                    if(string.IsNullOrEmpty(tj[i].JoinName) == false)
                    {                       
                        dgvJoinAuthors.Rows.Add();
                        dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsName"].Value = tj[i].JoinName;                        
                        if(tj[i].JoinCircleId != null)
                        {
                            dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsCircleId"].Value = tj[i].JoinCircleId.ToString();
                            var get = _MSCircleRepository.SelectById(tj[i].JoinCircleId ?? 0);
                            if(get != null)
                            {
                                dgvJoinAuthors.Rows[dgvJoinAuthors.RowCount - 1].Cells["JoinAuthorsCircleName"].Value = get.CircleName;
                            }
                        }                        
                        txtJoinAuthor.Text = "";
                    }
                }
            }

            //画像表示
            string ImagePath = Path.Combine(Properties.Settings.Default.PicutureFolder, id.ToString().Trim() + ".jpg");
            if (File.Exists(ImagePath) == true)
            {
                //画像ファイルを開くまでの一連の操作
                // ファイルストリームでファイルを開いてBitmapに記録
                Bitmap ReadImage;               
                using (var fs = new System.IO.FileStream(ImagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    ReadImage = new Bitmap(fs);                    

                    Bitmap Resized;
                    //縦長か横長か確認し、それによって方法かえて縮小
                    //縦長
                    if (ReadImage.Height >= ReadImage.Width)
                    {
                        Resized = ResizeImage_H(ReadImage, pbCover.Height);
                    }
                    //横長
                    else
                    {
                        Resized = ResizeImage_W(ReadImage, pbCover.Width);
                    }
                    //サイズ変更した画像を表示
                    pbCover.Image = Resized;
                }
            }
            else
            {
                pbCover.Image = null;
            }


        }

        /// <summary>
        /// 入力確認
        /// </summary>
        /// <returns></returns>
        private bool InputCheck()
        {
            //必須入力チェック
            //タイトル
            if(string.IsNullOrEmpty(txtTitle.Text) == true)
            {
                MessageBox.Show(text: "タイトルが空白です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            //発行サークル
            if(cmbCircle.SelectedValue.ToString() == "null")
            {
                MessageBox.Show(text: "発行サークルが未選択です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            //ジャンル
            if(cmbGenre.SelectedValue.ToString() == "null")
            {
                MessageBox.Show(text: "ジャンルが未選択です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            //原作
            if(cmbOriginal.SelectedValue.ToString() == "null")
            {
                MessageBox.Show(text: "原作が未選択です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            //総集編収録誌
            if(chkOmnibus.Checked == true)
            {
                if(dgvInOmnibusBooks.RowCount <= 0)
                {
                    MessageBox.Show(text: "総集編の収録誌が未入力です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return false;
                }
            }
            //合同誌参加者
            if(chkJoint.Checked == true)
            {
                if(dgvJoinAuthors.RowCount <= 0)
                {
                    MessageBox.Show(text: "合同誌の参加者が未入力です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return false;
                }
            }

            //不正入力チェック
            //巻数
            int a;
            if(string.IsNullOrEmpty(txtNo.Text) == false)
            {
                if (int.TryParse(txtNo.Text, out a) == false)
                {
                    MessageBox.Show(text: "巻数は整数です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return false;
                }
            }           
            //値段
            if(string.IsNullOrEmpty(txtPrice.Text) == false)
            {
                if(int.TryParse(txtPrice.Text,out a) == false)
                {
                    MessageBox.Show(text: "値段は整数です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return false;
                }
            }

            //他の入力チェック
            //未入力項目を表示する
            string NotInputed = "";
            //作者
            if(string.IsNullOrEmpty(txtAuthor.Text) == true)
            {
                NotInputed += ",作者";
            }
            //発行日
            if(dtiPublishDate.Value == null)
            {
                NotInputed += ",発行日";
            }
            //発行イベント
            if(cmbEventName.SelectedValue.ToString() == "null")
            {
                NotInputed += ",発行イベント";
            }
            //特徴
            if(string.IsNullOrEmpty(txtChara1.Text) == true && string.IsNullOrEmpty(txtChara2.Text) == true &&
                string.IsNullOrEmpty(txtChara3.Text) == true && string.IsNullOrEmpty(txtChara4.Text) == true&&
                string.IsNullOrEmpty(txtChara5.Text) == true && string.IsNullOrEmpty(txtChara6.Text) == true)
            {
                NotInputed += ",特徴";
            }
            //未入力項目があればそれを表示する
            if(string.IsNullOrEmpty(NotInputed) == false)
            {
                NotInputed = NotInputed.Substring(1);
                DialogResult r = MessageBox.Show(text: "以下の項目が未入力です。よろしいですか？\n\n" + NotInputed, caption: "確認", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
                if (r != DialogResult.Yes)
                {
                    return false;
                }
            }
            
            return true;
        }

        /// <summary>
        /// データ照合
        /// </summary>
        private void DataInquiry()
        {
            //初刊(初刊ID)
            if(string.IsNullOrEmpty(txtFirstName.Text) == false && string.IsNullOrEmpty(txtFirstId.Text) == true)
            {
                List<TableBookInfo> firstBook = new List<TableBookInfo>();
                firstBook = _BookInfoRepositoty.SearchInquiry(txtFirstName.Text.Trim());
                //1件のみ見つかったらIDを入れる
                if(firstBook.Count == 1)
                {
                    txtFirstId.Text = firstBook[0].BookId.ToString();
                    txtFirstName.Enabled = false;
                }
            }            
            //特徴1(特徴ID)
            if(string.IsNullOrEmpty(txtChara1.Text) == false && string.IsNullOrEmpty(txtCharaId1.Text) == true)
            {
                List<MastaChara> chara1 = new List<MastaChara>();
                chara1 = _MSCharaRepository.Search(null,txtChara1.Text.Trim(),false,false);
                //1件のみ見つかったらIDを入れる
                if(chara1.Count == 1)
                {
                    txtCharaId1.Text = chara1[0].Id.ToString();
                    txtChara1.Enabled = false;
                }
            }
            //特徴2(特徴ID)
            if (string.IsNullOrEmpty(txtChara2.Text) == false && string.IsNullOrEmpty(txtCharaId2.Text) == true)
            {
                List<MastaChara> chara2 = new List<MastaChara>();
                chara2 = _MSCharaRepository.Search(null, txtChara2.Text.Trim(), false, false);
                //1件のみ見つかったらIDを入れる
                if (chara2.Count == 1)
                {
                    txtCharaId2.Text = chara2[0].Id.ToString();
                    txtChara2.Enabled = false;
                }
            }
            //特徴3(特徴ID)
            if (string.IsNullOrEmpty(txtChara3.Text) == false && string.IsNullOrEmpty(txtCharaId3.Text) == true)
            {
                List<MastaChara> chara3 = new List<MastaChara>();
                chara3 = _MSCharaRepository.Search(null, txtChara3.Text.Trim(), false, false);
                //1件のみ見つかったらIDを入れる
                if (chara3.Count == 1)
                {
                    txtCharaId3.Text = chara3[0].Id.ToString();
                    txtChara3.Enabled = false;
                }
            }
            //特徴4(特徴ID)
            if (string.IsNullOrEmpty(txtChara4.Text) == false && string.IsNullOrEmpty(txtCharaId4.Text) == true)
            {
                List<MastaChara> chara4 = new List<MastaChara>();
                chara4 = _MSCharaRepository.Search(null, txtChara4.Text.Trim(), false, false);
                //1件のみ見つかったらIDを入れる
                if (chara4.Count == 1)
                {
                    txtCharaId4.Text = chara4[0].Id.ToString();
                    txtChara4.Enabled = false;
                }
            }
            //特徴5(特徴ID)
            if (string.IsNullOrEmpty(txtChara5.Text) == false && string.IsNullOrEmpty(txtCharaId5.Text) == true)
            {
                List<MastaChara> chara5 = new List<MastaChara>();
                chara5 = _MSCharaRepository.Search(null, txtChara5.Text.Trim(), false, false);
                //1件のみ見つかったらIDを入れる
                if (chara5.Count == 1)
                {
                    txtCharaId5.Text = chara5[0].Id.ToString();
                    txtChara5.Enabled = false;
                }
            }
            //特徴6(特徴ID)
            if (string.IsNullOrEmpty(txtChara6.Text) == false && string.IsNullOrEmpty(txtCharaId6.Text) == true)
            {
                List<MastaChara> chara6 = new List<MastaChara>();
                chara6 = _MSCharaRepository.Search(null, txtChara6.Text.Trim(), false, false);
                //1件のみ見つかったらIDを入れる
                if (chara6.Count == 1)
                {
                    txtCharaId6.Text = chara6[0].Id.ToString();
                    txtChara6.Enabled = false;
                }
            }
            //総集編収録誌(同人誌ID)
            if(chkOmnibus.Checked == true && dgvInOmnibusBooks.Rows.Count > 0)
            {
                for(int i =0;i < dgvInOmnibusBooks.Rows.Count;i++)
                {
                    //本の名前を保存
                    string bookName = "";
                    if(dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookName"].Value != null)
                    {
                        bookName = dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookName"].Value.ToString().Trim();
                    }
                    //IDの有無を確認
                    bool idExist = false;
                    if(dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookId"].Value != null)
                    {
                        if (dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookId"].Value.ToString() != "")
                        {
                            idExist = true;
                        }
                    }
                    //IDがなければ検索する
                    if(idExist == false)
                    {
                        List<TableBookInfo> inBook = new List<TableBookInfo>();
                        inBook = _BookInfoRepositoty.SearchInquiry(bookName);
                        //1件のみ見つかったらIDを入れる
                        if (inBook.Count == 1)
                        {
                            dgvInOmnibusBooks.Rows[i].Cells["InOmnibusBookId"].Value = inBook[0].BookId.ToString();
                        }
                    }

                }
            }
            //合同誌参加者(サークルID)
            if(chkJoint.Checked == true && dgvJoinAuthors.Rows.Count > 0)
            {
                for(int i=0;i<dgvJoinAuthors.Rows.Count;i++)
                {
                    //JoinAuthorsCircleName
                    //JoinAuthorsCircleId
                    //作者の名前を保存
                    string authorName = "";
                    if(dgvJoinAuthors.Rows[i].Cells["JoinAuthorsName"].Value != null)
                    {
                        authorName = dgvJoinAuthors.Rows[i].Cells["JoinAuthorsName"].Value.ToString().Trim();
                    }
                    //IDの有無を確認
                    bool idExist = false;
                    if(dgvJoinAuthors.Rows[i].Cells["JoinAuthorsCircleId"].Value != null)
                    {
                        if(dgvJoinAuthors.Rows[i].Cells["JoinAuthorsCircleId"].Value.ToString() != "")
                        {
                            idExist = true;
                        }
                    }
                    //IDがなければ検索する
                    if(idExist == false)
                    {
                        List<MastaCircle> circle = new List<MastaCircle>();
                        circle = _MSCircleRepository.SearchInquiry(authorName);
                        //1件のみ見つかったらIDを入れる
                        if(circle.Count == 1)
                        {
                            dgvJoinAuthors.Rows[i].Cells["JoinAuthorsCircleId"].Value = circle[0].Id.ToString();
                            dgvJoinAuthors.Rows[i].Cells["JoinAuthorsCircleName"].Value = circle[0].CircleName.ToString();
                        }
                    }
                }
            }
        }

        
    }    
}
