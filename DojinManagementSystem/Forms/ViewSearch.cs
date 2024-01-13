using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DojinManagementSystem.Repository;
using static DojinManagementSystem.Tools.Common;
using static DojinManagementSystem.Tools.OverForm;

namespace DojinManagementSystem.Forms
{
    public partial class ViewSearch : Form
    {
        ViewInfoList ResultView = new ViewInfoList();

        BookInfoRepository _BookInfoRepository = new BookInfoRepository();

        public ViewSearch()
        {
            InitializeComponent();

            //コンボボックスのセット
            SetCombobox(cmbEvent, "ms_event", "id", "event_name", true);
            SetCombobox(cmbGenre, "ms_genre", "id", "genre_name", true);
            SetCombobox(cmbOriginal, "ms_original", "id", "original_name", true);
            SetCombobox(cmbCircle, "ms_circle", "id", "circle_name", true);
            //ラジオボタンのセット
            rdoAll.Checked = true;
            rdoAll2.Checked = true;
            rdoAll3.Checked = true;
            rdoAll4.Checked = true;
        }

        private void ViewSearch_Load(object sender, EventArgs e)
        {

            //表示用の検索結果表示用の画面を表示           
            ResultView.StartPosition = FormStartPosition.Manual;
            ResultView.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);
            ResultView.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewSearch_FormClosing(object sender, FormClosingEventArgs e)
        {           
            ResultView.Close();           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //結果表示用ウィンドウがない時に再表示
            if(ResultView.Visible == false)
            {
                ResultView.Dispose();
                ResultView = new ViewInfoList();
                ResultView.StartPosition = FormStartPosition.Manual;
                ResultView.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);
                ResultView.Show();
            }
            //検索条件を作成する
            SearchEntity searchEntity = new SearchEntity();
            //タイトル
            searchEntity.Title = txtTitle.Text.Trim();
            //発行サークル
            if (cmbCircle.SelectedValue.ToString() != "null")
            {
                searchEntity.CircleId = int.Parse(cmbCircle.SelectedValue.ToString());
            }
            else
            {
                searchEntity.CircleId = null;
            }
            //作者
            searchEntity.Author = txtAuthor.Text.Trim();
            //イベント名
            if (cmbEvent.SelectedValue.ToString() == "null")
            {
                searchEntity.EventId = null;
            }
            else
            {
                searchEntity.EventId = int.Parse(cmbEvent.SelectedValue.ToString());
            }
            //発行日
            searchEntity.PubulishDateFrom = dtiFromDate.Value;
            searchEntity.PubulishDateTo = dtiToDate.Value;
            //ジャンル
            if(cmbGenre.SelectedValue.ToString() == "null")
            {
                searchEntity.GenreId = null;
            }
            else 
            {
                searchEntity.GenreId = int.Parse(cmbGenre.SelectedValue.ToString());
            }
            //原作
            if(cmbOriginal.SelectedValue.ToString() == "null")
            {
                searchEntity.OriginalId = null;
            }
            else
            {
                searchEntity.OriginalId = int.Parse(cmbOriginal.SelectedValue.ToString());
            }
            //特徴
            int id;
            if (string.IsNullOrEmpty(txtCharaId.Text) == false && int.TryParse(txtCharaId.Text, out id) == true)
            {
                searchEntity.CharaId = id;
            }
            else
            {
                searchEntity.CharaId = null;
            }
            //R18
            if (rdoAll.Checked == true)
            {
                searchEntity.FlgR18 = null;
            }
            else if(rdoR18.Checked == true)
            {
                searchEntity.FlgR18 = true;
            }
            else if(rdoNotR18.Checked == true)
            {
                searchEntity.FlgR18 = false;
            }
            //総集編
            if (rdoAll2.Checked == true)
            {
                searchEntity.FlgOmnibus = null;
            }
            else if (rdoOmni.Checked == true)
            {
                searchEntity.FlgOmnibus = true;
            }
            else if (rdoNotOmni.Checked == true)
            {
                searchEntity.FlgOmnibus = false;
            }
            //合同誌
            if (rdoAll3.Checked == true)
            {
                searchEntity.FlgJoint = null;
            }
            else if (rdoJoint.Checked == true)
            {
                searchEntity.FlgJoint = true;
            }
            else if (rdoNotJoint.Checked == true)
            {
                searchEntity.FlgJoint = false;
            }
            //コピー誌
            if (rdoAll4.Checked == true)
            {
                searchEntity.FlgCopy = null;
            }
            else if (rdoCopy.Checked == true)
            {
                searchEntity.FlgCopy = true;
            }
            else if (rdoNotCopy.Checked == true)
            {
                searchEntity.FlgCopy = false;
            }


            //検索する
            List<ViewBookInfoAbstract> result = new List<ViewBookInfoAbstract>();
            result = _BookInfoRepository.SearchAbstracts(searchEntity);

            //検索結果と検索条件を検索結果表示用ウィンドウに渡す
            ResultView.resultAbsList = new List<ViewBookInfoAbstract>();
            ResultView.resultAbsList = result;
            ResultView.searchEntity = new SearchEntity();
            ResultView.searchEntity = searchEntity;


            //検索結果のウィンドウを再ロード
            ResultView.Reload();
        }

        /// <summary>
        /// サークル検索ボタン
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
        /// 原作検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchOrigene_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchOrigine();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (OriginalSearchDepo.OriginalId == null) return;
            //帰ってきた検索結果をコンボボックスにセットする           
            cmbOriginal.SelectedValue = OriginalSearchDepo.OriginalId.ToString();
        }

        /// <summary>
        /// 特徴検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchChara_Click(object sender, EventArgs e)
        {
            Form form = new TableSearch.SearchChara();
            form.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CharaSearchDepo.CharaId == null) return;
            //帰ってきた結果を特徴1のテキストボックス類に入れてロックする
            txtChara.Text = CharaSearchDepo.CharaName;
            txtChara.Enabled = false;
            txtCharaId.Text = CharaSearchDepo.CharaId.ToString();
        }

        /// <summary>
        /// 特徴クリアボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChara_Click(object sender, EventArgs e)
        {
            txtChara.Text = "";
            txtCharaId.Text = "";
            txtChara.Enabled = true;
        }
    }
}