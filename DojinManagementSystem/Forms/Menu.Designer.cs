namespace DojinManagementSystem.Forms
{
    partial class Menu
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_OpenInput = new System.Windows.Forms.Button();
            this.Btn_OpenView = new System.Windows.Forms.Button();
            this.Btn_OpenMSMente = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游明朝 Demibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dojin Manegement System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(320, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "～同人誌管理システム～";
            // 
            // Btn_OpenInput
            // 
            this.Btn_OpenInput.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_OpenInput.Location = new System.Drawing.Point(31, 117);
            this.Btn_OpenInput.Name = "Btn_OpenInput";
            this.Btn_OpenInput.Size = new System.Drawing.Size(148, 63);
            this.Btn_OpenInput.TabIndex = 2;
            this.Btn_OpenInput.Text = "同人誌情報入力";
            this.Btn_OpenInput.UseVisualStyleBackColor = true;
            this.Btn_OpenInput.Click += new System.EventHandler(this.Btn_OpenInput_Click);
            // 
            // Btn_OpenView
            // 
            this.Btn_OpenView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_OpenView.Location = new System.Drawing.Point(185, 117);
            this.Btn_OpenView.Name = "Btn_OpenView";
            this.Btn_OpenView.Size = new System.Drawing.Size(148, 63);
            this.Btn_OpenView.TabIndex = 3;
            this.Btn_OpenView.Text = "同人誌情報参照";
            this.Btn_OpenView.UseVisualStyleBackColor = true;
            this.Btn_OpenView.Click += new System.EventHandler(this.Btn_OpenView_Click);
            // 
            // Btn_OpenMSMente
            // 
            this.Btn_OpenMSMente.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_OpenMSMente.Location = new System.Drawing.Point(339, 117);
            this.Btn_OpenMSMente.Name = "Btn_OpenMSMente";
            this.Btn_OpenMSMente.Size = new System.Drawing.Size(148, 63);
            this.Btn_OpenMSMente.TabIndex = 4;
            this.Btn_OpenMSMente.Text = "マスタ管理";
            this.Btn_OpenMSMente.UseVisualStyleBackColor = true;
            this.Btn_OpenMSMente.Click += new System.EventHandler(this.Btn_OpenMSMente_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(428, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "終了";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 229);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Btn_OpenMSMente);
            this.Controls.Add(this.Btn_OpenView);
            this.Controls.Add(this.Btn_OpenInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "DMS メインメニュー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_OpenInput;
        private System.Windows.Forms.Button Btn_OpenView;
        private System.Windows.Forms.Button Btn_OpenMSMente;
        private System.Windows.Forms.Button btnClose;
    }
}

