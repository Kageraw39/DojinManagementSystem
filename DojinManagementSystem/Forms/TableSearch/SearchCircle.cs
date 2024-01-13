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
    public partial class SearchCircle : Form
    {
        MSCircleRepository _MSCircleRepository = new MSCircleRepository();

        public SearchCircle()
        {
            InitializeComponent();            
            CircleSearchDepo.CircleName = "";
            CircleSearchDepo.CircleMasterName = "";
            CircleSearchDepo.CircleId = null;
            dgvList.DataSource = _MSCircleRepository.Search(null, null, null);
            ColumnSetting();
        }

        private void ColumnSetting()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["CircleName"].HeaderText = "サークル名";
            dgvList.Columns["CircleName"].Width = 150;
            dgvList.Columns["CircleMaster"].HeaderText = "サークル主";
            dgvList.Columns["CircleMaster"].Width = 150;
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

            CircleSearchDepo.CircleId = int.Parse(dgvList.CurrentRow.Cells["Id"].Value.ToString());
            CircleSearchDepo.CircleName = dgvList.CurrentRow.Cells["CircleName"].Value.ToString();
            CircleSearchDepo.CircleMasterName = dgvList.CurrentRow.Cells["CircleMaster"].Value.ToString();
            this.Close();           
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = _MSCircleRepository.Search(null,txtCircleName.Text,txtAuthor.Text);
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