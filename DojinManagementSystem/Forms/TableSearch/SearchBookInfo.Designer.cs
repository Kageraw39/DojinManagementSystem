namespace DojinManagementSystem.Forms.TableSearch
{
    partial class SearchBookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBookInfo));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoR18 = new System.Windows.Forms.RadioButton();
            this.rdoNotR18 = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.cmbCircle = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchOrg = new System.Windows.Forms.Button();
            this.cmbOrigine = new System.Windows.Forms.ComboBox();
            this.btnSearchCircle = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(13, 156);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(478, 178);
            this.dgvList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoR18);
            this.panel1.Controls.Add(this.rdoNotR18);
            this.panel1.Controls.Add(this.rdoAll);
            this.panel1.Controls.Add(this.cmbCircle);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnSearchOrg);
            this.panel1.Controls.Add(this.cmbOrigine);
            this.panel1.Controls.Add(this.btnSearchCircle);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 137);
            this.panel1.TabIndex = 0;
            // 
            // rdoR18
            // 
            this.rdoR18.AutoSize = true;
            this.rdoR18.Location = new System.Drawing.Point(240, 106);
            this.rdoR18.Name = "rdoR18";
            this.rdoR18.Size = new System.Drawing.Size(43, 16);
            this.rdoR18.TabIndex = 10;
            this.rdoR18.TabStop = true;
            this.rdoR18.Text = "R18";
            this.rdoR18.UseVisualStyleBackColor = true;
            // 
            // rdoNotR18
            // 
            this.rdoNotR18.AutoSize = true;
            this.rdoNotR18.Location = new System.Drawing.Point(175, 106);
            this.rdoNotR18.Name = "rdoNotR18";
            this.rdoNotR18.Size = new System.Drawing.Size(59, 16);
            this.rdoNotR18.TabIndex = 9;
            this.rdoNotR18.TabStop = true;
            this.rdoNotR18.Text = "全年齢";
            this.rdoNotR18.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(103, 106);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(66, 16);
            this.rdoAll.TabIndex = 8;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "指定なし";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // cmbCircle
            // 
            this.cmbCircle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCircle.FormattingEnabled = true;
            this.cmbCircle.Location = new System.Drawing.Point(103, 42);
            this.cmbCircle.Name = "cmbCircle";
            this.cmbCircle.Size = new System.Drawing.Size(316, 20);
            this.cmbCircle.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSearch.Location = new System.Drawing.Point(387, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchOrg
            // 
            this.btnSearchOrg.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchOrg.Image")));
            this.btnSearchOrg.Location = new System.Drawing.Point(425, 74);
            this.btnSearchOrg.Name = "btnSearchOrg";
            this.btnSearchOrg.Size = new System.Drawing.Size(32, 23);
            this.btnSearchOrg.TabIndex = 7;
            this.btnSearchOrg.UseVisualStyleBackColor = true;
            this.btnSearchOrg.Click += new System.EventHandler(this.btnSearchOrg_Click);
            // 
            // cmbOrigine
            // 
            this.cmbOrigine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigine.FormattingEnabled = true;
            this.cmbOrigine.Location = new System.Drawing.Point(103, 75);
            this.cmbOrigine.Name = "cmbOrigine";
            this.cmbOrigine.Size = new System.Drawing.Size(316, 20);
            this.cmbOrigine.TabIndex = 6;
            // 
            // btnSearchCircle
            // 
            this.btnSearchCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCircle.Image")));
            this.btnSearchCircle.Location = new System.Drawing.Point(425, 42);
            this.btnSearchCircle.Name = "btnSearchCircle";
            this.btnSearchCircle.Size = new System.Drawing.Size(32, 23);
            this.btnSearchCircle.TabIndex = 4;
            this.btnSearchCircle.UseVisualStyleBackColor = true;
            this.btnSearchCircle.Click += new System.EventHandler(this.btnSearchCircle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtTitle.Location = new System.Drawing.Point(103, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(354, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "原作";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "発行サークル";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイトル";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSelect.Location = new System.Drawing.Point(411, 340);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "選択";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnClose.Location = new System.Drawing.Point(21, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SearchBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvList);
            this.Name = "SearchBookInfo";
            this.Text = "同人誌検索";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchCircle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchOrg;
        private System.Windows.Forms.ComboBox cmbOrigine;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbCircle;
        private System.Windows.Forms.RadioButton rdoR18;
        private System.Windows.Forms.RadioButton rdoNotR18;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}