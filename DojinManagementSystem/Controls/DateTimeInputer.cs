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
    public partial class DateTimeInputer : UserControl
    {
        //実際にコントロールが渡すvalue
        private DateTime? value = null;
        private string text = "";

        //プロパティの設定
        [Browsable(false)]
        [Description("コントロールにセットされている日付")]
        public DateTime? Value
        {
            get
            {
                return value;
            }
        }
        [Browsable(false)]        
        public string ValueText
        {
            get
            {
                return text;
            }
        }

        //ValueChangeのループを起こさないためのフラグ
        private bool Chenging = false;

        public DateTimeInputer()
        {
            InitializeComponent();
            dtpBack.Value = DateTime.Now;
            value = null;
            txtDate.Text = "";
        }

        /// <summary>
        /// カレンダーから日付を選択したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpBack_ValueChanged(object sender, EventArgs e)
        {
            if (Chenging == true) return;
            else 
            {
                Chenging = true;                
                txtDate.Text = dtpBack.Value.ToShortDateString();
                value = dtpBack.Value;
                text = txtDate.Text;
                Chenging = false;
            }
        }

        /// <summary>
        /// フォーカスが外れた時のチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimeInputer_Leave(object sender, EventArgs e)
        {
            if (Chenging == true) return;
            else
            {
                Chenging = true;
                DateTime d;
                if (DateTime.TryParse(txtDate.Text, out d) == true)
                {
                    dtpBack.Value = d;
                    txtDate.Text = d.ToShortDateString();
                    value = d;
                    text = txtDate.Text;
                }
                else
                {
                    value = null;
                    txtDate.Text = "";
                    text = "";
                }
                Chenging = false;
            }
        }        

        /// <summary>
        /// データのセット
        /// </summary>
        /// <param name="setDate"></param>
        public void Set(DateTime? setDate)
        {
            Chenging = true;
            value = setDate;
            if(setDate != null)
            {
                DateTime d = setDate ?? DateTime.Now;
                text = d.ToShortDateString();
                dtpBack.Value = d;
                txtDate.Text = text;
            }
            else
            {
                text = "";
                dtpBack.Value = DateTime.Now;
                txtDate.Text = text;
            }
            Chenging = false;
        }
    }
}
