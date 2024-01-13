namespace DojinManagementSystem.Forms.MastaMente
{
    partial class MSRegistChara
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
            this.label2 = new System.Windows.Forms.Label();
            this.chkR18 = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCharaName = new System.Windows.Forms.TextBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "特徴名";
            // 
            // chkR18
            // 
            this.chkR18.AutoSize = true;
            this.chkR18.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.chkR18.Location = new System.Drawing.Point(221, 19);
            this.chkR18.Name = "chkR18";
            this.chkR18.Size = new System.Drawing.Size(53, 20);
            this.chkR18.TabIndex = 2;
            this.chkR18.Text = "R18";
            this.chkR18.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtId.Location = new System.Drawing.Point(80, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(77, 23);
            this.txtId.TabIndex = 1;
            // 
            // txtCharaName
            // 
            this.txtCharaName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtCharaName.Location = new System.Drawing.Point(79, 51);
            this.txtCharaName.Name = "txtCharaName";
            this.txtCharaName.Size = new System.Drawing.Size(193, 23);
            this.txtCharaName.TabIndex = 4;
            // 
            // btnRegist
            // 
            this.btnRegist.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnRegist.Location = new System.Drawing.Point(182, 91);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(79, 29);
            this.btnRegist.TabIndex = 5;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnDelete.Location = new System.Drawing.Point(32, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MSRegistChara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 139);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.txtCharaName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkR18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MSRegistChara";
            this.Text = "特徴登録";
            this.Load += new System.EventHandler(this.MSRegistChara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkR18;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCharaName;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnDelete;
    }
}