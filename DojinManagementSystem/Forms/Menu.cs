using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DojinManagementSystem.Tools.Common;

namespace DojinManagementSystem.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_OpenInput_Click(object sender, EventArgs e)
        {
            InputInfo frmInputInfo = new InputInfo();
            OpenForm(this, frmInputInfo);
        }

        private void Btn_OpenView_Click(object sender, EventArgs e)
        {
            ViewSearch frmViewSearch = new ViewSearch();
            //2画面表示するため場所を指定
            frmViewSearch.StartPosition = FormStartPosition.Manual;
            frmViewSearch.Location = new Point(10, 10);
            OpenForm(this, frmViewSearch);
        }

        private void Btn_OpenMSMente_Click(object sender, EventArgs e)
        {
            MastaMenu frmMastaMenu = new MastaMenu();
            OpenForm(this, frmMastaMenu);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
