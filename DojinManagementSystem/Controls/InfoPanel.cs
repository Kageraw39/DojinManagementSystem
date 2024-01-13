using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DojinManagementSystem.Controls
{
    public delegate void EventHandler(object sender, EventArgs e);

    public partial class InfoPanel : UserControl
    {       
        public InfoPanel()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            if(title != null)
            {
                txtTitle.Text = title.Trim();
            }
            
        }

        public void SetCircle(string circleName)
        {
            if(circleName != null)
            {
                txtCircle.Text = circleName.Trim();
            }            
        }

        public void SetOriginal(string originalName)
        {
            if(originalName != null)
            {
                txtOrigine.Text = originalName.Trim();
            }            
        }

        public void SetPublishDate(DateTime? publishDate)
        {
            if(publishDate != null)
            {
                DateTime date = publishDate ?? DateTime.Now; 
                txtPublishDate.Text = date.ToString("yyyy/MM/dd");
            }
            else
            {
                txtPublishDate.Text = "";
            }
        }

        public void SetR18(bool flgR18)
        {
            if(flgR18 == true)
            {
                txtR18.BackColor = Color.Pink;
                txtR18.ForeColor = Color.Red;
                txtR18.Text = "R18";
            }
            else
            {
                txtR18.BackColor = SystemColors.Control;
                txtR18.ForeColor = SystemColors.WindowText;
                txtR18.Text = "全年齢";
            }
        }

        public void ResetR18()
        {
            txtR18.BackColor = SystemColors.Control;
            txtR18.ForeColor = SystemColors.WindowText;
            txtR18.Text = "";
        }

        public void SetGenre(string genre)
        {
            if(genre != null)
            {
                txtBookType.Text = genre.Trim();
            }            
        }

        public void SetCoverDirect(string filePath)
        {
            Bitmap readImage;
            using (var fs = new System.IO.FileStream(filePath,System.IO.FileMode.Open,System.IO.FileAccess.Read))
            {
                readImage = new Bitmap(fs);
                pbCover.Image = readImage;
            }
        }
        public void SetCover(Bitmap bitmap)
        {
            pbCover.Image = bitmap;
        }
        public void resetCover()
        {
            pbCover.Image = null;
        }
        public int GetCoverHeight()
        {
            return pbCover.Height;
        }
        public int GetCoverWidth()
        {
            return pbCover.Width;
        }
    }
}
