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
    public partial class MSEditSize : Form
    {
        MSSizeRepository _MsSizeRepository = new MSSizeRepository();

        public MSEditSize()
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
            var form = new MSRegistSize();
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
            var form = new MSRegistSize(int.Parse(dgvList.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
            form.ShowDialog();
            View();
        }

        /// <summary>
        /// データ表示
        /// </summary>
        private void View()
        {
            dgvList.DataSource = _MsSizeRepository.Select();
            dgvList.Columns["Id"].HeaderText = "ID";
            dgvList.Columns["Id"].Width = 40;
            dgvList.Columns["SizeName"].HeaderText = "サイズ名";
            dgvList.Columns["SizeName"].Width = 150;
            dgvList.Columns["Height"].HeaderText = "縦(cm)";
            dgvList.Columns["Height"].DefaultCellStyle.Format = "F2";
            dgvList.Columns["Height"].Width = 80;
            dgvList.Columns["Width"].HeaderText = "横(cm)";
            dgvList.Columns["Width"].DefaultCellStyle.Format = "F2";
            dgvList.Columns["Width"].Width = 80;
        }

        
    }
}
