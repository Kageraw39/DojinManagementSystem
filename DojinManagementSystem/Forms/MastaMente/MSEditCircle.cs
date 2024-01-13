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
    public partial class MSEditCircle : Form
    {
        MSCircleRepository _MsCircleRepository = new MSCircleRepository();

        public MSEditCircle()
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
            var form = new MSRegistCircle();
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
            if(e.RowIndex > -1)
            {
                var form = new MSRegistCircle(int.Parse(dgvList.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                form.ShowDialog();
                View();
            }
        }

        private void View()
        {
            dgvList.DataSource = _MsCircleRepository.Select();
            dgvList.Columns["Id"].HeaderText = "Id";
            dgvList.Columns["Id"].Width = 40;
            dgvList.Columns["CircleName"].HeaderText = "サークル名";
            dgvList.Columns["CircleName"].Width = 190;
            dgvList.Columns["CircleMaster"].HeaderText = "サークル主";
            dgvList.Columns["CircleMaster"].Width = 140;
        }
    }
}
