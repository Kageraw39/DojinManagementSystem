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
    public partial class SearchChara : Form
    {
        MSCharaRepository _MSCharaRepository = new MSCharaRepository();

        public SearchChara()
        {
            InitializeComponent();
            CharaSearchDepo.CharaId = null;
            CharaSearchDepo.CharaName = "";
            CharaSearchDepo.FlgR18 = null;
            dgvList.DataSource = _MSCharaRepository.Search(null, null, true, true);
            ColumnSetting();

            rdoAll.Checked = true;
        }     
        
        private void ColumnSetting()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["CharaName"].HeaderText = "特徴名";
            dgvList.Columns["CharaName"].Width = 130; 
            dgvList.Columns["FlgR18"].HeaderText = "R18";
            dgvList.Columns["FlgR18"].Width = 40;
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

            CharaSearchDepo.CharaId = int.Parse(dgvList.CurrentRow.Cells["Id"].Value.ToString());
            CharaSearchDepo.CharaName = dgvList.CurrentRow.Cells["CharaName"].Value.ToString();
            CharaSearchDepo.FlgR18 = bool.Parse(dgvList.CurrentRow.Cells["FlgR18"].Value.ToString());
            this.Close();           
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoAll.Checked == true)
            {
                dgvList.DataSource = _MSCharaRepository.Search(null, txtCharaName.Text, true, true);
            }
            else if (rdoNotR18.Checked == true)
            {
                dgvList.DataSource = _MSCharaRepository.Search(null, txtCharaName.Text, true, false);

            }
            else if(rdoR18.Checked == true)
            {
                dgvList.DataSource = _MSCharaRepository.Search(null, txtCharaName.Text, false, true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
