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
using static DojinManagementSystem.Tools.OverForm;

namespace DojinManagementSystem.Forms.TableSearch
{
    public partial class SearchEvent : Form
    {
        MSEventRepository _MSEventRepository = new MSEventRepository();

        public SearchEvent()
        {
            InitializeComponent();
            EventSearchDepo.EventName = "";
            EventSearchDepo.EventId = null;
            EventSearchDepo.EventDate = null;
            //初期日付設定
            //初期日付は起動日前後6か月とする
            DateTime def_from = DateTime.Today.AddMonths(-6);
            DateTime def_to = DateTime.Today.AddMonths(6);
            dtpEventFrom.Set(def_from);
            dtpEventTo.Set(def_to);
            dgvList.DataSource = _MSEventRepository.Search(null, null, def_from, def_to);
            ColumnSetting();
        }

        private void ColumnSetting()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["EventName"].HeaderText = "イベント名";
            dgvList.Columns["EventName"].Width = 300;
            dgvList.Columns["EventDate"].HeaderText = "開催日";
            dgvList.Columns["EventDate"].Width = 100;
        }      

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = _MSEventRepository.Search(null, txtName.Text.Trim(), dtpEventFrom.Value, dtpEventTo.Value);
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

            EventSearchDepo.EventId = int.Parse(dgvList.CurrentRow.Cells["id"].Value.ToString());
            EventSearchDepo.EventName = dgvList.CurrentRow.Cells["EventName"].Value.ToString();
            EventSearchDepo.EventDate = DateTime.Parse(dgvList.CurrentRow.Cells["EventDate"].Value.ToString());
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
