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
    public partial class MSEditGenre : Form
    {
        MSGenreRepository _MsGenrerepository = new MSGenreRepository();

        public MSEditGenre()
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
            var form = new MSRegistGenre();
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
                var form = new MSRegistGenre(int.Parse(dgvList.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                form.ShowDialog();
                View();
            }
        }

        private void View()
        {
            dgvList.DataSource = _MsGenrerepository.Select();
            dgvList.Columns["Id"].HeaderText = "ID";
            dgvList.Columns["Id"].Width = 40;
            dgvList.Columns["GenreName"].HeaderText = "ジャンル名";
            dgvList.Columns["GenreName"].Width = 220;
        }

       
    }
}
