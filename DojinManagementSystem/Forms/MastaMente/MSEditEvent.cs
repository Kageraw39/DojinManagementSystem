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
    public partial class MSEditEvent : Form
    {
        MSEventRepository _MSEventRepository = new MSEventRepository();

        public MSEditEvent()
        {
            InitializeComponent();
            View();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var form = new MSRegistEvent();
            form.ShowDialog();
            View();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var form = new MSRegistEvent(int.Parse(dgvList.Rows[e.RowIndex].Cells["id"].Value.ToString()));
                form.ShowDialog();
                View();
            }
        }

        private void View()
        {
            dgvList.DataSource = _MSEventRepository.Select();
            dgvList.Columns["Id"].HeaderText = "ID";
            dgvList.Columns["Id"].Width = 40;
            dgvList.Columns["EventName"].HeaderText = "イベント名";
            dgvList.Columns["EventName"].Width = 300;
            dgvList.Columns["EventDate"].HeaderText = "開催日";
            dgvList.Columns["EventDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
            dgvList.Columns["EventDate"].Width = 100;
        }
    }
}
