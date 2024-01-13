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
    public partial class MSRegistGenre : Form
    {
        private int EditMode;
        private MastaGenre Data;

        MSGenreRepository _MSGenreRepository = new MSGenreRepository();

        /// <summary>
        /// 新規用コンストラクタ
        /// </summary>
        public MSRegistGenre()
        {
            InitializeComponent();
            EditMode = Mode.New;
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public MSRegistGenre(int id)
        {
            InitializeComponent();
            Data = _MSGenreRepository.SelectById(id);

            txtId.Text = Data.Id.ToString();
            txtGenre.Text = Data.GenreName;

            EditMode = Mode.Edit;
        }


        /// <summary>
        /// フォームのロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSRegistGenre_Load(object sender, EventArgs e)
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
            //モードによって処理を変更
            switch(EditMode)
            {
                case Mode.New:
                    if (InputCheck() == false) return;
                    _MSGenreRepository.Insert(txtGenre.Text.Trim());
                    break;

                case Mode.Edit:
                    if (InputCheck() == false) return;
                    _MSGenreRepository.Update(Data.Id, txtGenre.Text.Trim());
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
            if(MessageBox.Show(text:"データ削除します。\nよろしいですか？",caption:"確認",buttons:MessageBoxButtons.OKCancel,icon:MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            _MSGenreRepository.Delete(Data.Id);
            this.Close();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private bool InputCheck()
        {
            if(txtGenre.Text.Length > 20)
            {
                MessageBox.Show(text: "ジャンル名は20文字以下で入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
