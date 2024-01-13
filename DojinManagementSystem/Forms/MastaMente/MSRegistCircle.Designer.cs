namespace DojinManagementSystem.Forms.MastaMente
{
    partial class MSRegistCircle
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCircleMaster = new System.Windows.Forms.TextBox();
            this.txtCircleName = new System.Windows.Forms.TextBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "サークル主";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "サークル名";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtId.Location = new System.Drawing.Point(102, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(83, 23);
            this.txtId.TabIndex = 1;
            // 
            // txtCircleMaster
            // 
            this.txtCircleMaster.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtCircleMaster.Location = new System.Drawing.Point(102, 85);
            this.txtCircleMaster.Name = "txtCircleMaster";
            this.txtCircleMaster.Size = new System.Drawing.Size(208, 23);
            this.txtCircleMaster.TabIndex = 5;
            // 
            // txtCircleName
            // 
            this.txtCircleName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtCircleName.Location = new System.Drawing.Point(102, 51);
            this.txtCircleName.Name = "txtCircleName";
            this.txtCircleName.Size = new System.Drawing.Size(208, 23);
            this.txtCircleName.TabIndex = 3;
            // 
            // btnRegist
            // 
            this.btnRegist.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnRegist.Location = new System.Drawing.Point(218, 123);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 29);
            this.btnRegist.TabIndex = 6;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnDelete.Location = new System.Drawing.Point(34, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MSRegistCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 175);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.txtCircleName);
            this.Controls.Add(this.txtCircleMaster);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MSRegistCircle";
            this.Text = "サークル登録";
            this.Load += new System.EventHandler(this.MSRegistCircle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCircleMaster;
        private System.Windows.Forms.TextBox txtCircleName;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnDelete;
    }
}