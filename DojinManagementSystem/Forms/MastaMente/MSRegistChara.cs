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
    public partial class MSRegistChara : Form
    {
        private int EditMode;
        private MastaChara Data;

        MSCharaRepository _MSCharaRepository = new MSCharaRepository();

        /// <summary>
        /// 新規用コンストラクタ
        /// </summary>
        public MSRegistChara()
        {
            InitializeComponent();
            EditMode = Mode.New;
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public MSRegistChara(int id)
        {
            InitializeComponent();
            Data = _MSCharaRepository.SelectById(id);

            txtId.Text = Data.Id.ToString();
            txtCharaName.Text = Data.CharaName;
            chkR18.Checked = Data.FlgR18;

            EditMode = Mode.Edit;
        }

        /// <summary>
        /// フォームのロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSRegistChara_Load(object sender, EventArgs e)
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
            switch (EditMode)
            {
                case Mode.New:
                    if (InputCheck() == false) return;
                    _MSCharaRepository.Insert(txtCharaName.Text.Trim(),chkR18.Checked);
                    break;

                case Mode.Edit:
                    if (InputCheck() == false) return;
                    _MSCharaRepository.Update(Data.Id, txtCharaName.Text.Trim(), chkR18.Checked);
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
            if((MessageBox.Show(text: "データを削除します。\nよろしいですか？", caption: "確認", buttons: MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Question) == DialogResult.Cancel))
            {
                return;
            }
            _MSCharaRepository.Delete(Data.Id);
            this.Close();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        private bool InputCheck()
        {
            if(txtCharaName.Text.Length > 10)
            {
                MessageBox.Show(text: "特徴名は10文字以下で入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
