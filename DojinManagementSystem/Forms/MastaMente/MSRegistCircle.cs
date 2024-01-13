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
    public partial class MSRegistCircle : Form
    {
        private int EditMode;
        private MastaCircle Data;

        MSCircleRepository _MSCircleRepository = new MSCircleRepository();

        /// <summary>
        /// 新規用コンストラクタ
        /// </summary>
        public MSRegistCircle()
        {
            InitializeComponent();
            EditMode = Mode.New;
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public MSRegistCircle(int id)
        {
            InitializeComponent();
            Data = _MSCircleRepository.SelectById(id);

            txtId.Text = Data.Id.ToString();
            txtCircleName.Text = Data.CircleName.ToString();
            txtCircleMaster.Text = Data.CircleMaster.ToString();

            EditMode = Mode.Edit;
        }

        /// <summary>
        /// フォームのロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSRegistCircle_Load(object sender, EventArgs e)
        {
            //モードによって各コントロールの状態を変更
            switch (EditMode)
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
            switch (EditMode)
            {
                case Mode.New:
                    if (InputCheck() == false) return;
                    _MSCircleRepository.Insert(txtCircleName.Text.Trim(), txtCircleMaster.Text.Trim());
                    break;

                case Mode.Edit:
                    if (InputCheck() == false) return;
                    _MSCircleRepository.Update(Data.Id, txtCircleName.Text.Trim(), txtCircleMaster.Text.Trim());
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
            _MSCircleRepository.Delete(Data.Id);
            this.Close();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private bool InputCheck()
        {
            if (txtCircleName.Text.Length > 50)
            {
                MessageBox.Show(text: "サークル名は50文字以下で入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            else if (txtCircleName.Text.Length < 1)
            {
                MessageBox.Show(text: "サークル名は必須です。", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }

            if (txtCircleMaster.Text.Length > 20)
            {
                MessageBox.Show(text: "サークル主名は20文字以下で入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
