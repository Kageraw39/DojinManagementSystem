namespace DojinManagementSystem.Controls
{
    partial class DateTimeInputer
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpBack = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpBack
            // 
            this.dtpBack.CalendarFont = new System.Drawing.Font("MS UI Gothic", 9F);
            this.dtpBack.CustomFormat = "yyyy/MM/dd";
            this.dtpBack.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dtpBack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBack.Location = new System.Drawing.Point(3, 3);
            this.dtpBack.Name = "dtpBack";
            this.dtpBack.Size = new System.Drawing.Size(145, 23);
            this.dtpBack.TabIndex = 0;
            this.dtpBack.Value = new System.DateTime(2019, 12, 24, 0, 0, 0, 0);
            this.dtpBack.ValueChanged += new System.EventHandler(this.dtpBack_ValueChanged);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtDate.Location = new System.Drawing.Point(3, 3);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(106, 23);
            this.txtDate.TabIndex = 1;
            // 
            // DateTimeInputer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dtpBack);
            this.Name = "DateTimeInputer";
            this.Size = new System.Drawing.Size(152, 30);
            this.Leave += new System.EventHandler(this.DateTimeInputer_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBack;
        private System.Windows.Forms.TextBox txtDate;
    }
}
