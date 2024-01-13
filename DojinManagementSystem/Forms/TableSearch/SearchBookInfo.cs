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

namespace DojinManagementSystem.Forms.TableSearch
{
    public partial class SearchBookInfo : Form
    {
        BookInfoRepository _BookInfoRepository = new BookInfoRepository();
           
        /// <summary>
        /// コンストラクタ（引数必須）
        /// </summary>
        /// <param name="circleId"></param>
        /// <param name="originalId"></param>
        public SearchBookInfo(int? circleId,int? originalId)
        {
            InitializeComponent();
            //OverFormの初期化
            BookInfoSearchDepo_Lite.BookId = null;
            BookInfoSearchDepo_Lite.BookName = "";                        
            //コンボボックスのセットアップ
            SetCombobox(cmbCircle, "ms_circle", "id", "circle_name", true);
            SetCombobox(cmbOrigine, "ms_original", "id", "original_name", true);
            //指定なしラジオボタンをデフォに
            rdoAll.Checked = true;
            //引数によって処理を変更
            //引数のどちらかがnot nullの場合はコンボにセットして検索を行う
            if(circleId != null || originalId != null)
            {
                dgvList.DataSource = _BookInfoRepository.SearchLite(null, null, circleId, originalId,null, false);               
            }
            //両方nullの場合は空検索を行う
            else
            {
                dgvList.DataSource = _BookInfoRepository.SearchLite(null, null, null,null,null, true);                
            }
            ColumnSetting();            
        }

        private void ColumnSetting()
        {
            dgvList.Columns["BookId"].Visible = false;
            dgvList.Columns["BookName"].HeaderText = "同人誌名";
            dgvList.Columns["BookName"].Width = 355;
            dgvList.Columns["SeriesNo"].Visible = false;
            dgvList.Columns["FirstName"].Visible = false;
            dgvList.Columns["FirstId"].Visible = false;
            dgvList.Columns["CircleId"].Visible = false;
            dgvList.Columns["Author"].Visible = false;
            dgvList.Columns["EventId"].Visible = false;            
            dgvList.Columns["PublishDate"].HeaderText = "発行日";
            dgvList.Columns["PublishDate"].Width = 110;
            dgvList.Columns["GenreId"].Visible = false;
            dgvList.Columns["OriginalId"].Visible = false;
            dgvList.Columns["FlgR18"].Visible = false;
            dgvList.Columns["FlgOmnibus"].Visible = false;
            dgvList.Columns["FlgJoint"].Visible = false;
            dgvList.Columns["FlgCopy"].Visible = false;
            dgvList.Columns["SizeId"].Visible = false;
            dgvList.Columns["BuyDate"].Visible = false;
            dgvList.Columns["Price"].Visible = false;
            dgvList.Columns["BuyWayId"].Visible = false;
            dgvList.Columns["Memo"].Visible = false;
            dgvList.Columns["FlgDelete"].Visible = false;
            dgvList.Columns["CreateDate"].Visible = false;
            dgvList.Columns["UpdateDate"].Visible = false;
        }

        /// <summary>
        /// サークル検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchCircle_Click(object sender, EventArgs e)
        {
            Form from = new TableSearch.SearchCircle();
            from.ShowDialog();
            //検索結果がなかった場合は何もしない
            if (CircleSearchDepo.CircleId == null) return;
            //帰ってきた検索結果をコンボボックスにセットする               
            cmbCircle.SelectedValue = CircleSearchDepo.CircleId.ToString();            
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
            cmbOrigine.SelectedValue = OriginalSearchDepo.OriginalId.ToString();
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int? SelectedCircle;
            int? SelectedOriginal;
            bool? FlgR18 = null;
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
            if (cmbOrigine.SelectedValue.ToString() == "null")
            {
                SelectedOriginal = null;
            }
            else
            {
                SelectedOriginal = int.Parse(cmbOrigine.SelectedValue.ToString());
            }
            //対象年齢情報
            if(rdoAll.Checked == true)
            {
                FlgR18 = null;
            }
            else if(rdoNotR18.Checked == true)
            {
                FlgR18 = false;
            }
            else if(rdoR18.Checked == true)
            {
                FlgR18 = true;
            }
            dgvList.DataSource = _BookInfoRepository.SearchLite(null,txtTitle.Text, SelectedCircle, SelectedOriginal,FlgR18, false);
        }

        /// <summary>
        /// 選択ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvList.RowCount <= 0) return;
            if (dgvList.CurrentRow.Index <= -1) return;

            BookInfoSearchDepo_Lite.BookId = int.Parse(dgvList.CurrentRow.Cells["BookId"].Value.ToString());
            BookInfoSearchDepo_Lite.BookName = dgvList.CurrentRow.Cells["BookName"].Value.ToString();
            this.Close();
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
    }
}
