namespace DojinManagementSystem.Forms
{
    partial class ViewSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchCircle = new System.Windows.Forms.Button();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnSearchOrigene = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOriginal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchChara = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtiToDate = new DojinManagementSystem.Controls.DateTimeInputer();
            this.dtiFromDate = new DojinManagementSystem.Controls.DateTimeInputer();
            this.gbR18 = new System.Windows.Forms.GroupBox();
            this.rdoNotR18 = new System.Windows.Forms.RadioButton();
            this.rdoR18 = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.gbOmnibus = new System.Windows.Forms.GroupBox();
            this.rdoNotOmni = new System.Windows.Forms.RadioButton();
            this.rdoOmni = new System.Windows.Forms.RadioButton();
            this.rdoAll2 = new System.Windows.Forms.RadioButton();
            this.gbJoint = new System.Windows.Forms.GroupBox();
            this.rdoNotJoint = new System.Windows.Forms.RadioButton();
            this.rdoJoint = new System.Windows.Forms.RadioButton();
            this.rdoAll3 = new System.Windows.Forms.RadioButton();
            this.gbCopy = new System.Windows.Forms.GroupBox();
            this.rdoNotCopy = new System.Windows.Forms.RadioButton();
            this.rdoCopy = new System.Windows.Forms.RadioButton();
            this.rdoAll4 = new System.Windows.Forms.RadioButton();
            this.btnClearChara = new System.Windows.Forms.Button();
            this.cmbCircle = new System.Windows.Forms.ComboBox();
            this.txtCharaId = new System.Windows.Forms.TextBox();
            this.txtChara = new System.Windows.Forms.TextBox();
            this.gbR18.SuspendLayout();
            this.gbOmnibus.SuspendLayout();
            this.gbJoint.SuspendLayout();
            this.gbCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイトル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "発行サークル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "ジャンル";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "イベント名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "発行日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "原作";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(110, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(361, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(110, 96);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(323, 23);
            this.txtAuthor.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(396, 440);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchCircle
            // 
            this.btnSearchCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCircle.Image")));
            this.btnSearchCircle.Location = new System.Drawing.Point(439, 61);
            this.btnSearchCircle.Name = "btnSearchCircle";
            this.btnSearchCircle.Size = new System.Drawing.Size(32, 58);
            this.btnSearchCircle.TabIndex = 4;
            this.btnSearchCircle.UseVisualStyleBackColor = true;
            this.btnSearchCircle.Click += new System.EventHandler(this.btnSearchCircle_Click);
            // 
            // cmbEvent
            // 
            this.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(110, 135);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(361, 24);
            this.cmbEvent.TabIndex = 8;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(111, 207);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(361, 24);
            this.cmbGenre.TabIndex = 14;
            // 
            // btnSearchOrigene
            // 
            this.btnSearchOrigene.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchOrigene.Image")));
            this.btnSearchOrigene.Location = new System.Drawing.Point(440, 242);
            this.btnSearchOrigene.Name = "btnSearchOrigene";
            this.btnSearchOrigene.Size = new System.Drawing.Size(32, 23);
            this.btnSearchOrigene.TabIndex = 17;
            this.btnSearchOrigene.UseVisualStyleBackColor = true;
            this.btnSearchOrigene.Click += new System.EventHandler(this.btnSearchOrigene_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "～";
            // 
            // cmbOriginal
            // 
            this.cmbOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOriginal.FormattingEnabled = true;
            this.cmbOriginal.Location = new System.Drawing.Point(111, 242);
            this.cmbOriginal.Name = "cmbOriginal";
            this.cmbOriginal.Size = new System.Drawing.Size(322, 24);
            this.cmbOriginal.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "特徴";
            // 
            // btnSearchChara
            // 
            this.btnSearchChara.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchChara.Image")));
            this.btnSearchChara.Location = new System.Drawing.Point(370, 279);
            this.btnSearchChara.Name = "btnSearchChara";
            this.btnSearchChara.Size = new System.Drawing.Size(50, 23);
            this.btnSearchChara.TabIndex = 21;
            this.btnSearchChara.UseVisualStyleBackColor = true;
            this.btnSearchChara.Click += new System.EventHandler(this.btnSearchChara_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(16, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtiToDate
            // 
            this.dtiToDate.Location = new System.Drawing.Point(318, 168);
            this.dtiToDate.Name = "dtiToDate";
            this.dtiToDate.Size = new System.Drawing.Size(154, 30);
            this.dtiToDate.TabIndex = 12;
            // 
            // dtiFromDate
            // 
            this.dtiFromDate.Location = new System.Drawing.Point(107, 168);
            this.dtiFromDate.Name = "dtiFromDate";
            this.dtiFromDate.Size = new System.Drawing.Size(152, 30);
            this.dtiFromDate.TabIndex = 10;
            // 
            // gbR18
            // 
            this.gbR18.Controls.Add(this.rdoNotR18);
            this.gbR18.Controls.Add(this.rdoR18);
            this.gbR18.Controls.Add(this.rdoAll);
            this.gbR18.Location = new System.Drawing.Point(39, 318);
            this.gbR18.Name = "gbR18";
            this.gbR18.Size = new System.Drawing.Size(89, 105);
            this.gbR18.TabIndex = 23;
            this.gbR18.TabStop = false;
            this.gbR18.Text = "R18";
            // 
            // rdoNotR18
            // 
            this.rdoNotR18.AutoSize = true;
            this.rdoNotR18.Location = new System.Drawing.Point(11, 74);
            this.rdoNotR18.Name = "rdoNotR18";
            this.rdoNotR18.Size = new System.Drawing.Size(74, 20);
            this.rdoNotR18.TabIndex = 2;
            this.rdoNotR18.TabStop = true;
            this.rdoNotR18.Text = "全年齢";
            this.rdoNotR18.UseVisualStyleBackColor = true;
            // 
            // rdoR18
            // 
            this.rdoR18.AutoSize = true;
            this.rdoR18.Location = new System.Drawing.Point(11, 48);
            this.rdoR18.Name = "rdoR18";
            this.rdoR18.Size = new System.Drawing.Size(52, 20);
            this.rdoR18.TabIndex = 1;
            this.rdoR18.TabStop = true;
            this.rdoR18.Text = "R18";
            this.rdoR18.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(11, 22);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(66, 20);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "すべて";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // gbOmnibus
            // 
            this.gbOmnibus.Controls.Add(this.rdoNotOmni);
            this.gbOmnibus.Controls.Add(this.rdoOmni);
            this.gbOmnibus.Controls.Add(this.rdoAll2);
            this.gbOmnibus.Location = new System.Drawing.Point(146, 318);
            this.gbOmnibus.Name = "gbOmnibus";
            this.gbOmnibus.Size = new System.Drawing.Size(89, 105);
            this.gbOmnibus.TabIndex = 24;
            this.gbOmnibus.TabStop = false;
            this.gbOmnibus.Text = "総集編";
            // 
            // rdoNotOmni
            // 
            this.rdoNotOmni.AutoSize = true;
            this.rdoNotOmni.Location = new System.Drawing.Point(11, 74);
            this.rdoNotOmni.Name = "rdoNotOmni";
            this.rdoNotOmni.Size = new System.Drawing.Size(58, 20);
            this.rdoNotOmni.TabIndex = 2;
            this.rdoNotOmni.TabStop = true;
            this.rdoNotOmni.Text = "単作";
            this.rdoNotOmni.UseVisualStyleBackColor = true;
            // 
            // rdoOmni
            // 
            this.rdoOmni.AutoSize = true;
            this.rdoOmni.Location = new System.Drawing.Point(11, 48);
            this.rdoOmni.Name = "rdoOmni";
            this.rdoOmni.Size = new System.Drawing.Size(74, 20);
            this.rdoOmni.TabIndex = 1;
            this.rdoOmni.TabStop = true;
            this.rdoOmni.Text = "総集編";
            this.rdoOmni.UseVisualStyleBackColor = true;
            // 
            // rdoAll2
            // 
            this.rdoAll2.AutoSize = true;
            this.rdoAll2.Location = new System.Drawing.Point(11, 22);
            this.rdoAll2.Name = "rdoAll2";
            this.rdoAll2.Size = new System.Drawing.Size(66, 20);
            this.rdoAll2.TabIndex = 0;
            this.rdoAll2.TabStop = true;
            this.rdoAll2.Text = "すべて";
            this.rdoAll2.UseVisualStyleBackColor = true;
            // 
            // gbJoint
            // 
            this.gbJoint.Controls.Add(this.rdoNotJoint);
            this.gbJoint.Controls.Add(this.rdoJoint);
            this.gbJoint.Controls.Add(this.rdoAll3);
            this.gbJoint.Location = new System.Drawing.Point(254, 318);
            this.gbJoint.Name = "gbJoint";
            this.gbJoint.Size = new System.Drawing.Size(89, 105);
            this.gbJoint.TabIndex = 25;
            this.gbJoint.TabStop = false;
            this.gbJoint.Text = "合同誌";
            // 
            // rdoNotJoint
            // 
            this.rdoNotJoint.AutoSize = true;
            this.rdoNotJoint.Location = new System.Drawing.Point(11, 74);
            this.rdoNotJoint.Name = "rdoNotJoint";
            this.rdoNotJoint.Size = new System.Drawing.Size(74, 20);
            this.rdoNotJoint.TabIndex = 2;
            this.rdoNotJoint.TabStop = true;
            this.rdoNotJoint.Text = "個人誌";
            this.rdoNotJoint.UseVisualStyleBackColor = true;
            // 
            // rdoJoint
            // 
            this.rdoJoint.AutoSize = true;
            this.rdoJoint.Location = new System.Drawing.Point(11, 48);
            this.rdoJoint.Name = "rdoJoint";
            this.rdoJoint.Size = new System.Drawing.Size(74, 20);
            this.rdoJoint.TabIndex = 1;
            this.rdoJoint.TabStop = true;
            this.rdoJoint.Text = "合同誌";
            this.rdoJoint.UseVisualStyleBackColor = true;
            // 
            // rdoAll3
            // 
            this.rdoAll3.AutoSize = true;
            this.rdoAll3.Location = new System.Drawing.Point(11, 22);
            this.rdoAll3.Name = "rdoAll3";
            this.rdoAll3.Size = new System.Drawing.Size(66, 20);
            this.rdoAll3.TabIndex = 0;
            this.rdoAll3.TabStop = true;
            this.rdoAll3.Text = "すべて";
            this.rdoAll3.UseVisualStyleBackColor = true;
            // 
            // gbCopy
            // 
            this.gbCopy.Controls.Add(this.rdoNotCopy);
            this.gbCopy.Controls.Add(this.rdoCopy);
            this.gbCopy.Controls.Add(this.rdoAll4);
            this.gbCopy.Location = new System.Drawing.Point(359, 318);
            this.gbCopy.Name = "gbCopy";
            this.gbCopy.Size = new System.Drawing.Size(89, 105);
            this.gbCopy.TabIndex = 26;
            this.gbCopy.TabStop = false;
            this.gbCopy.Text = "コピー誌";
            // 
            // rdoNotCopy
            // 
            this.rdoNotCopy.AutoSize = true;
            this.rdoNotCopy.Location = new System.Drawing.Point(11, 74);
            this.rdoNotCopy.Name = "rdoNotCopy";
            this.rdoNotCopy.Size = new System.Drawing.Size(58, 20);
            this.rdoNotCopy.TabIndex = 2;
            this.rdoNotCopy.TabStop = true;
            this.rdoNotCopy.Text = "製本";
            this.rdoNotCopy.UseVisualStyleBackColor = true;
            // 
            // rdoCopy
            // 
            this.rdoCopy.AutoSize = true;
            this.rdoCopy.Location = new System.Drawing.Point(11, 48);
            this.rdoCopy.Name = "rdoCopy";
            this.rdoCopy.Size = new System.Drawing.Size(62, 20);
            this.rdoCopy.TabIndex = 1;
            this.rdoCopy.TabStop = true;
            this.rdoCopy.Text = "コピー";
            this.rdoCopy.UseVisualStyleBackColor = true;
            // 
            // rdoAll4
            // 
            this.rdoAll4.AutoSize = true;
            this.rdoAll4.Location = new System.Drawing.Point(11, 22);
            this.rdoAll4.Name = "rdoAll4";
            this.rdoAll4.Size = new System.Drawing.Size(66, 20);
            this.rdoAll4.TabIndex = 0;
            this.rdoAll4.TabStop = true;
            this.rdoAll4.Text = "すべて";
            this.rdoAll4.UseVisualStyleBackColor = true;
            // 
            // btnClearChara
            // 
            this.btnClearChara.Image = ((System.Drawing.Image)(resources.GetObject("btnClearChara.Image")));
            this.btnClearChara.Location = new System.Drawing.Point(422, 279);
            this.btnClearChara.Name = "btnClearChara";
            this.btnClearChara.Size = new System.Drawing.Size(49, 23);
            this.btnClearChara.TabIndex = 22;
            this.btnClearChara.UseVisualStyleBackColor = true;
            this.btnClearChara.Click += new System.EventHandler(this.btnClearChara_Click);
            // 
            // cmbCircle
            // 
            this.cmbCircle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCircle.FormattingEnabled = true;
            this.cmbCircle.Location = new System.Drawing.Point(111, 61);
            this.cmbCircle.Name = "cmbCircle";
            this.cmbCircle.Size = new System.Drawing.Size(321, 24);
            this.cmbCircle.TabIndex = 3;
            // 
            // txtCharaId
            // 
            this.txtCharaId.Enabled = false;
            this.txtCharaId.Location = new System.Drawing.Point(313, 279);
            this.txtCharaId.Name = "txtCharaId";
            this.txtCharaId.ReadOnly = true;
            this.txtCharaId.Size = new System.Drawing.Size(54, 23);
            this.txtCharaId.TabIndex = 20;
            // 
            // txtChara
            // 
            this.txtChara.Location = new System.Drawing.Point(111, 279);
            this.txtChara.Name = "txtChara";
            this.txtChara.Size = new System.Drawing.Size(198, 23);
            this.txtChara.TabIndex = 19;
            // 
            // ViewSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 483);
            this.Controls.Add(this.txtChara);
            this.Controls.Add(this.txtCharaId);
            this.Controls.Add(this.cmbCircle);
            this.Controls.Add(this.btnClearChara);
            this.Controls.Add(this.gbOmnibus);
            this.Controls.Add(this.gbJoint);
            this.Controls.Add(this.gbCopy);
            this.Controls.Add(this.gbR18);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearchChara);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOriginal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearchOrigene);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.btnSearchCircle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtiToDate);
            this.Controls.Add(this.dtiFromDate);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewSearch";
            this.Text = "検索条件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewSearch_FormClosing);
            this.Load += new System.EventHandler(this.ViewSearch_Load);
            this.gbR18.ResumeLayout(false);
            this.gbR18.PerformLayout();
            this.gbOmnibus.ResumeLayout(false);
            this.gbOmnibus.PerformLayout();
            this.gbJoint.ResumeLayout(false);
            this.gbJoint.PerformLayout();
            this.gbCopy.ResumeLayout(false);
            this.gbCopy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private Controls.DateTimeInputer dtiFromDate;
        private Controls.DateTimeInputer dtiToDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchCircle;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnSearchOrigene;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOriginal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchChara;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbR18;
        private System.Windows.Forms.RadioButton rdoNotR18;
        private System.Windows.Forms.RadioButton rdoR18;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.GroupBox gbOmnibus;
        private System.Windows.Forms.RadioButton rdoNotOmni;
        private System.Windows.Forms.RadioButton rdoOmni;
        private System.Windows.Forms.RadioButton rdoAll2;
        private System.Windows.Forms.GroupBox gbJoint;
        private System.Windows.Forms.RadioButton rdoNotJoint;
        private System.Windows.Forms.RadioButton rdoJoint;
        private System.Windows.Forms.RadioButton rdoAll3;
        private System.Windows.Forms.GroupBox gbCopy;
        private System.Windows.Forms.RadioButton rdoNotCopy;
        private System.Windows.Forms.RadioButton rdoCopy;
        private System.Windows.Forms.RadioButton rdoAll4;
        private System.Windows.Forms.Button btnClearChara;
        private System.Windows.Forms.ComboBox cmbCircle;
        private System.Windows.Forms.TextBox txtCharaId;
        private System.Windows.Forms.TextBox txtChara;
    }
}