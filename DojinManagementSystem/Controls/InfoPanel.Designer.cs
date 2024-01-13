namespace DojinManagementSystem.Controls
{
    partial class InfoPanel
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
            this.BasePanel = new System.Windows.Forms.Panel();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.txtR18 = new System.Windows.Forms.TextBox();
            this.txtPublishDate = new System.Windows.Forms.TextBox();
            this.txtOrigine = new System.Windows.Forms.TextBox();
            this.txtCircle = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.BasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // BasePanel
            // 
            this.BasePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BasePanel.Controls.Add(this.txtBookType);
            this.BasePanel.Controls.Add(this.txtR18);
            this.BasePanel.Controls.Add(this.txtPublishDate);
            this.BasePanel.Controls.Add(this.txtOrigine);
            this.BasePanel.Controls.Add(this.txtCircle);
            this.BasePanel.Controls.Add(this.txtTitle);
            this.BasePanel.Controls.Add(this.pbCover);
            this.BasePanel.Location = new System.Drawing.Point(3, 3);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(476, 196);
            this.BasePanel.TabIndex = 0;
            // 
            // txtBookType
            // 
            this.txtBookType.BackColor = System.Drawing.SystemColors.Control;
            this.txtBookType.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtBookType.Location = new System.Drawing.Point(319, 161);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.ReadOnly = true;
            this.txtBookType.Size = new System.Drawing.Size(140, 23);
            this.txtBookType.TabIndex = 6;
            this.txtBookType.TabStop = false;
            // 
            // txtR18
            // 
            this.txtR18.BackColor = System.Drawing.SystemColors.Control;
            this.txtR18.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtR18.Location = new System.Drawing.Point(173, 161);
            this.txtR18.Name = "txtR18";
            this.txtR18.ReadOnly = true;
            this.txtR18.Size = new System.Drawing.Size(140, 23);
            this.txtR18.TabIndex = 5;
            this.txtR18.TabStop = false;
            this.txtR18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtPublishDate.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtPublishDate.Location = new System.Drawing.Point(173, 132);
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.ReadOnly = true;
            this.txtPublishDate.Size = new System.Drawing.Size(285, 23);
            this.txtPublishDate.TabIndex = 4;
            this.txtPublishDate.TabStop = false;
            // 
            // txtOrigine
            // 
            this.txtOrigine.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrigine.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtOrigine.Location = new System.Drawing.Point(174, 103);
            this.txtOrigine.Name = "txtOrigine";
            this.txtOrigine.ReadOnly = true;
            this.txtOrigine.Size = new System.Drawing.Size(285, 23);
            this.txtOrigine.TabIndex = 3;
            this.txtOrigine.TabStop = false;
            // 
            // txtCircle
            // 
            this.txtCircle.BackColor = System.Drawing.SystemColors.Control;
            this.txtCircle.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtCircle.Location = new System.Drawing.Point(174, 74);
            this.txtCircle.Name = "txtCircle";
            this.txtCircle.ReadOnly = true;
            this.txtCircle.Size = new System.Drawing.Size(285, 23);
            this.txtCircle.TabIndex = 2;
            this.txtCircle.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtTitle.Location = new System.Drawing.Point(174, 13);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(285, 52);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TabStop = false;
            // 
            // pbCover
            // 
            this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCover.Location = new System.Drawing.Point(16, 13);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(141, 171);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // InfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InfoPanel";
            this.Size = new System.Drawing.Size(480, 200);
            this.BasePanel.ResumeLayout(false);
            this.BasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.TextBox txtR18;
        private System.Windows.Forms.TextBox txtPublishDate;
        private System.Windows.Forms.TextBox txtOrigine;
        private System.Windows.Forms.TextBox txtCircle;
        private System.Windows.Forms.TextBox txtTitle;
    }
}
