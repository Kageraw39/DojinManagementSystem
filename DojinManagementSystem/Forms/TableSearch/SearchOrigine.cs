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
    public partial class SearchOrigine : Form
    {
        MSOriginalRepository _MSOriginalRepository = new MSOriginalRepository();

        public SearchOrigine()
        {
            InitializeComponent();
            OriginalSearchDepo.OriginalName = "";
            OriginalSearchDepo.OriginalId = null;
            dgvList.DataSource = _MSOriginalRepository.Search(null, null);
            ColumnSetting();
        }

        private void ColumnSetting()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["OriginalName"].HeaderText = "原作名";
            dgvList.Columns["OriginalName"].Width = 250;
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
            
            OriginalSearchDepo.OriginalId = int.Parse(dgvList.CurrentRow.Cells["Id"].Value.ToString());
            OriginalSearchDepo.OriginalName = dgvList.CurrentRow.Cells["OriginalName"].Value.ToString();                
            this.Close();            
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = _MSOriginalRepository.Search(null, txtTitle.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
