
namespace DojinManagementSystem.Forms
{
    partial class EditSetting
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.txtPicutureFolder = new System.Windows.Forms.TextBox();
            this.txtDBPass = new System.Windows.Forms.TextBox();
            this.txtDBUser = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DBサーバー名 or IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(383, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "データベース名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(26, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DBユーザー名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(383, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "DBユーザーPass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(26, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "表示画像保存先";
            // 
            // txtDBServer
            // 
            this.txtDBServer.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtDBServer.Location = new System.Drawing.Point(167, 27);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(197, 23);
            this.txtDBServer.TabIndex = 5;
            // 
            // txtPicutureFolder
            // 
            this.txtPicutureFolder.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtPicutureFolder.Location = new System.Drawing.Point(167, 91);
            this.txtPicutureFolder.Name = "txtPicutureFolder";
            this.txtPicutureFolder.Size = new System.Drawing.Size(429, 23);
            this.txtPicutureFolder.TabIndex = 6;
            // 
            // txtDBPass
            // 
            this.txtDBPass.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtDBPass.Location = new System.Drawing.Point(501, 56);
            this.txtDBPass.Name = "txtDBPass";
            this.txtDBPass.Size = new System.Drawing.Size(196, 23);
            this.txtDBPass.TabIndex = 7;
            // 
            // txtDBUser
            // 
            this.txtDBUser.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtDBUser.Location = new System.Drawing.Point(167, 56);
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Size = new System.Drawing.Size(197, 23);
            this.txtDBUser.TabIndex = 8;
            // 
            // txtDBName
            // 
            this.txtDBName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtDBName.Location = new System.Drawing.Point(500, 27);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(197, 23);
            this.txtDBName.TabIndex = 9;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSelectFolder.Location = new System.Drawing.Point(602, 91);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(95, 23);
            this.btnSelectFolder.TabIndex = 10;
            this.btnSelectFolder.Text = "参照";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSaveConfig.Location = new System.Drawing.Point(538, 131);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(159, 23);
            this.btnSaveConfig.TabIndex = 12;
            this.btnSaveConfig.Text = "変更";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // EditSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 171);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtDBUser);
            this.Controls.Add(this.txtDBPass);
            this.Controls.Add(this.txtPicutureFolder);
            this.Controls.Add(this.txtDBServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSetting";
            this.Text = "EditSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.TextBox txtPicutureFolder;
        private System.Windows.Forms.TextBox txtDBPass;
        private System.Windows.Forms.TextBox txtDBUser;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSaveConfig;
    }
}