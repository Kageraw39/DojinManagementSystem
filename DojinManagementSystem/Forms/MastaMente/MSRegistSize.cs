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
using static DojinManagementSystem.Tools.Common;

namespace DojinManagementSystem.Forms.MastaMente
{
    public partial class MSRegistSize : Form
    {
        private int EditMode;
        private MastaSize Data;

        MSSizeRepository _MSSizeRepository = new MSSizeRepository();

        /// <summary>
        /// 新規用コンストラクタ
        /// </summary>
        public MSRegistSize()
        {
            InitializeComponent();
            EditMode = Mode.New;
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public MSRegistSize(int id)
        {
            InitializeComponent();
            Data = _MSSizeRepository.SelectById(id);

            txtId.Text = Data.Id.ToString();
            txtSizeName.Text = Data.SizeName;
            if(Data.Height != null)
            {
                double d = Data.Height ?? 0;
                txtHeight.Text = d.ToString("F2");
            }
            else 
            {
                txtHeight.Text = "";
            }
            if(Data.Width != null)
            {
                double d = Data.Width ?? 0;
                txtWidth.Text = d.ToString("F2");
            }

            EditMode = Mode.Edit;
        }

        private void MSRegistSize_Load(object sender, EventArgs e)
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

            switch(EditMode)
            {
                case Mode.New:
                    if (InputCheck() == false) return;
                    _MSSizeRepository.Insert(txtSizeName.Text, StringToNullDouble(txtHeight.Text), StringToNullDouble(txtWidth.Text));
                    break;

                case Mode.Edit:
                    if (InputCheck() == false) return;
                    _MSSizeRepository.Update(Data.Id, txtSizeName.Text, StringToNullDouble(txtHeight.Text), StringToNullDouble(txtWidth.Text));
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
            _MSSizeRepository.Delete(Data.Id);
            this.Close();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private bool InputCheck()
        {
            double h = 0;
            double w = 0;

            //サイズ名
            if(txtSizeName.Text.Length > 10)
            {
                MessageBox.Show(text: "サイズ名は10文字以下で入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }

            //縦（一応）       
            if(txtHeight.Text.Trim() != "" && double.TryParse(txtHeight.Text.Trim(),out h) == false)
            {
                MessageBox.Show(text: "縦の長さには数字を入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            else if (h < 0 || h > 999.99)
            {
                MessageBox.Show(text: "縦の長さが有効範囲から外れています", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }

            //横（一応）
            if (txtWidth.Text.Trim() != "" && double.TryParse(txtWidth.Text.Trim(), out w) == false)
            {
                MessageBox.Show(text: "横の長さには数字を入力してください", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            else if (w < 0 || w > 999.99)
            {
                MessageBox.Show(text: "横の長さが有効範囲から外れています", caption: "エラー", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 縦…フォーカス外れた時にチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHeight_Validated(object sender, EventArgs e)
        {
            double h = 0;
            if (txtHeight.Text.Trim() != "" && double.TryParse(txtHeight.Text.Trim(), out h) == false)
            {
                txtHeight.Text = "";               
            }
            else if (h < 0 || h > 999.99)
            {
                txtHeight.Text = "";
            }
        }

        /// <summary>
        /// 横…フォーカス外れた時にチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWidth_Validated(object sender, EventArgs e)
        {
            double w = 0;
            if (txtWidth.Text.Trim() != "" && double.TryParse(txtWidth.Text.Trim(), out w) == false)
            {
                txtWidth.Text = "";
            }
            else if (w < 0 || w > 999.99)
            {
                txtWidth.Text = "";
            }
        }

       
    }
}
