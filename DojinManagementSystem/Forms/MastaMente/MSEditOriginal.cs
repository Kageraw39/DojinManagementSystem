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

namespace DojinManagementSystem.Forms.MastaMente
{
    public partial class MSEditOriginal : Form
    {
        MSOriginalRepository _MsOriginalRepository = new MSOriginalRepository();

        public MSEditOriginal()
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
            var form = new MSRegistOriginal();
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
                var form = new MSRegistOriginal(int.Parse(dgvList.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                form.ShowDialog();
                View();
            }
        }

        /// <summary>
        /// データ表示
        /// </summary>
        private void View()
        {
            dgvList.DataSource = _MsOriginalRepository.Select();
            dgvList.Columns["Id"].HeaderText = "ID";
            dgvList.Columns["Id"].Width = 40;
            dgvList.Columns["OriginalName"].HeaderText = "原作名";
            dgvList.Columns["OriginalName"].Width = 220;
        }        
    }
}
