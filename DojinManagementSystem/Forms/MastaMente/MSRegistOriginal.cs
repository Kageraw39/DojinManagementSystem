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
    public partial class MSRegistOriginal : Form
    {
        private int EditMode;
        private MastaOriginal Data;

        MSOriginalRepository _MsOriginalRepository = new MSOriginalRepository();

        /// <summary>
        /// 新規用コンストラクタ
        /// </summary>
        public MSRegistOriginal()
        {
            InitializeComponent();
            EditMode = Mode.New;
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public MSRegistOriginal(int id)
        {
            InitializeComponent();
            Data = _MsOriginalRepository.SelectById(id);

            txtId.Text = Data.Id.ToString();
            txtOrigineName.Text = Data.OriginalName;

            EditMode = Mode.Edit;
        }

        /// <summary>
        /// フォームのロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSRegistOriginal_Load(object sender, EventArgs e)
        {
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
            //モードによって処理を変更
            switch(EditMode)
            {
                case Mode.New:
                    if (InputCheck() == false) return;
                    _MsOriginalRepository.Insert(txtOrigineName.Text.Trim());
                    break;

                case Mode.Edit:
                    if (InputCheck() == false) return;
                    _MsOriginalRepository.Update(Data.Id, txtOrigineName.Text.Trim());
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
            _MsOriginalRepository.Delete(Data.Id);
            this.Close();
        }

        private bool InputCheck()
        {
            if(txtOrigineName.Text.Length > 50)
            {
                MessageBox.Show(text: "原作名は50文字以下で入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            return true;
        }        
    }
}
