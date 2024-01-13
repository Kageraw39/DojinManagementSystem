using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DojinManagementSystem.Forms.MastaMente;

using static DojinManagementSystem.Tools.Common;

namespace DojinManagementSystem.Forms
{
    public partial class MastaMenu : Form
    {
        public MastaMenu()
        {
            InitializeComponent();
        }

        private void btnEditCircle_Click(object sender, EventArgs e)
        {
            MSEditCircle frmMSEditCircle = new MSEditCircle();
            OpenForm(this, frmMSEditCircle);
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            MSEditEvent frmMSEditEvent = new MSEditEvent();
            OpenForm(this,frmMSEditEvent);
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            MSEditGenre frmMSEditGenre = new MSEditGenre();
            OpenForm(this, frmMSEditGenre);
        }

        private void btnEditOrigine_Click(object sender, EventArgs e)
        {
            MSEditOriginal frmMSEditOrigine = new MSEditOriginal();
            OpenForm(this, frmMSEditOrigine);
        }

        private void btnEditSize_Click(object sender, EventArgs e)
        {
            MSEditSize frmMSEditSize = new MSEditSize();
            OpenForm(this, frmMSEditSize);
        }

        private void btnEditBuyWay_Click(object sender, EventArgs e)
        {
            MSEditBuyWay frmMSEditBuyWay = new MSEditBuyWay();
            OpenForm(this, frmMSEditBuyWay);
        }

        private void btnEditChara_Click(object sender, EventArgs e)
        {
            MSEditChara frmMSEditChara = new MSEditChara();
            OpenForm(this, frmMSEditChara);
        }
    }
}
