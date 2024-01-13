using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using DojinManagementSystem.Repository;

namespace DojinManagementSystem.Forms.MastaMente
{
    public partial class MSEditBuyWay : Form
    {
        MSBuyWayRepository _MsBuyWayRepository = new MSBuyWayRepository();

        public MSEditBuyWay()
        {
            InitializeComponent();
            View();
        }       

        /// <summary>
        /// 新規登録ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Click(object sender, EventArgs e)
        {
            var form = new MSRegistBuyWay();
            form.ShowDialog();
            View();
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
        /// セルダブルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var form = new MSRegistBuyWay(int.Parse(dgvList.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                form.ShowDialog();
                View();
            }
        }

        /// <summary>
        /// データ表示
        /// </summary>
        private void View()
        {
            dgvList.DataSource = _MsBuyWayRepository.Select();
            dgvList.Columns["Id"].HeaderText = "ID";
            dgvList.Columns["Id"].Width = 40;
            dgvList.Columns["BuyWay"].HeaderText = "購入方法";
            dgvList.Columns["BuyWay"].Width = 200;
        }
    }
}
