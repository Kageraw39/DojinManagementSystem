using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DojinManagementSystem.Global;
using DojinManagementSystem.Repository;

namespace DojinManagementSystem.Forms.MastaMente
{
    public partial class MSRegistEvent : Form
    {
        private int EditMode;
        private MastaEvent Data;

        MSEventRepository _MSEventRepository = new MSEventRepository();

        /// <summary>
        /// 新規用コンストラクタ
        /// </summary>
        public MSRegistEvent()
        {
            InitializeComponent();
            EditMode = Mode.New;
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public MSRegistEvent(int id)
        {
            InitializeComponent();
            Data = _MSEventRepository.SelectById(id);

            txtId.Text = Data.Id.ToString();
            txtEventName.Text = Data.EventName;
            dtiEventDate.Set((DateTime?)Data.EventDate);

            EditMode = Mode.Edit;
        }

        /// <summary>
        /// フォームのロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSRegistEvent_Load(object sender, EventArgs e)
        {
            //モードによって各コントロールの状態を変更
            switch(EditMode)
            {
                case Mode.New:
                    btnDelete.Enabled = false;
                    btnRegist.Text = "登録";                    
                    break;

                case Mode.Edit:
                    btnDelete.Enabled = true;
                    btnRegist.Text = "更新";
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 登録・更新ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Click(object sender, EventArgs e)
        {
            //入力確認
            if (InputCheck() == false) return;
            //日付入力欄の型をdatetime?からdatetimeに
            DateTime d = dtiEventDate.Value ?? DateTime.Now;

            //モードによって処理を変更
            switch(EditMode)
            {
                case Mode.New:
                    _MSEventRepository.Insert(txtEventName.Text.Trim(), d);
                    break;

                case Mode.Edit:
                    _MSEventRepository.Update(Data.Id, txtEventName.Text.Trim(), d);
                    break;

                default:
                    break;
            }
            this.Close();
        }

        /// <summary>
        /// 削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "データを削除します。\nよろしいですか？", caption: "確認", buttons: MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            _MSEventRepository.Delete(Data.Id);
            this.Close();
        }

        private bool InputCheck()
        {
            if(txtEventName.Text.Length > 50)
            {
                MessageBox.Show(text: "イベント名は50文字以下で入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }

            if(dtiEventDate.Value == null)
            {
                MessageBox.Show(text: "イベント開催日は必須です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
