namespace DojinManagementSystem.Forms
{
    partial class MastaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditCircle = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnEditBuyWay = new System.Windows.Forms.Button();
            this.btnEditSize = new System.Windows.Forms.Button();
            this.btnEditOrigine = new System.Windows.Forms.Button();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnEditChara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label1.Location = new System.Drawing.Point(120, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "マスタ管理メニュー";
            // 
            // btnEditCircle
            // 
            this.btnEditCircle.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEditCircle.Location = new System.Drawing.Point(12, 73);
            this.btnEditCircle.Name = "btnEditCircle";
            this.btnEditCircle.Size = new System.Drawing.Size(215, 80);
            this.btnEditCircle.TabIndex = 1;
            this.btnEditCircle.Text = "サークルマスタ";
            this.btnEditCircle.UseVisualStyleBackColor = true;
            this.btnEditCircle.Click += new System.EventHandler(this.btnEditCircle_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEditEvent.Location = new System.Drawing.Point(233, 73);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(215, 80);
            this.btnEditEvent.TabIndex = 2;
            this.btnEditEvent.Text = "イベントマスタ";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnEditBuyWay
            // 
            this.btnEditBuyWay.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEditBuyWay.Location = new System.Drawing.Point(233, 245);
            this.btnEditBuyWay.Name = "btnEditBuyWay";
            this.btnEditBuyWay.Size = new System.Drawing.Size(215, 80);
            this.btnEditBuyWay.TabIndex = 6;
            this.btnEditBuyWay.Text = "購入方法マスタ";
            this.btnEditBuyWay.UseVisualStyleBackColor = true;
            this.btnEditBuyWay.Click += new System.EventHandler(this.btnEditBuyWay_Click);
            // 
            // btnEditSize
            // 
            this.btnEditSize.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEditSize.Location = new System.Drawing.Point(12, 245);
            this.btnEditSize.Name = "btnEditSize";
            this.btnEditSize.Size = new System.Drawing.Size(215, 80);
            this.btnEditSize.TabIndex = 5;
            this.btnEditSize.Text = "サイズマスタ";
            this.btnEditSize.UseVisualStyleBackColor = true;
            this.btnEditSize.Click += new System.EventHandler(this.btnEditSize_Click);
            // 
            // btnEditOrigine
            // 
            this.btnEditOrigine.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEditOrigine.Location = new System.Drawing.Point(233, 159);
            this.btnEditOrigine.Name = "btnEditOrigine";
            this.btnEditOrigine.Size = new System.Drawing.Size(215, 80);
            this.btnEditOrigine.TabIndex = 4;
            this.btnEditOrigine.Text = "原作マスタ";
            this.btnEditOrigine.UseVisualStyleBackColor = true;
            this.btnEditOrigine.Click += new System.EventHandler(this.btnEditOrigine_Click);
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEditGenre.Location = new System.Drawing.Point(12, 159);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(215, 80);
            this.btnEditGenre.TabIndex = 3;
            this.btnEditGenre.Text = "ジャンルマスタ";
            this.btnEditGenre.UseVisualStyleBackColor = true;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEditGenre_Click);
            // 
            // btnEditChara
            // 
            this.btnEditChara.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEditChara.Location = new System.Drawing.Point(119, 331);
            this.btnEditChara.Name = "btnEditChara";
            this.btnEditChara.Size = new System.Drawing.Size(215, 80);
            this.btnEditChara.TabIndex = 7;
            this.btnEditChara.Text = "特徴マスタ";
            this.btnEditChara.UseVisualStyleBackColor = true;
            this.btnEditChara.Click += new System.EventHandler(this.btnEditChara_Click);
            // 
            // MastaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 425);
            this.Controls.Add(this.btnEditChara);
            this.Controls.Add(this.btnEditGenre);
            this.Controls.Add(this.btnEditOrigine);
            this.Controls.Add(this.btnEditSize);
            this.Controls.Add(this.btnEditBuyWay);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btnEditCircle);
            this.Controls.Add(this.label1);
            this.Name = "MastaMenu";
            this.Text = "マスタ管理メニュー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCircle;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnEditBuyWay;
        private System.Windows.Forms.Button btnEditSize;
        private System.Windows.Forms.Button btnEditOrigine;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnEditChara;
    }
}