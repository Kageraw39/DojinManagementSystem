namespace DojinManagementSystem.Forms.TableSearch
{
    partial class SearchChara
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
            this.txtCharaName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoR18 = new System.Windows.Forms.RadioButton();
            this.rdoNotR18 = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "特徴名";
            // 
            // txtCharaName
            // 
            this.txtCharaName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtCharaName.Location = new System.Drawing.Point(74, 17);
            this.txtCharaName.Name = "txtCharaName";
            this.txtCharaName.Size = new System.Drawing.Size(124, 23);
            this.txtCharaName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSearch.Location = new System.Drawing.Point(123, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 98);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(186, 213);
            this.dgvList.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSelect.Location = new System.Drawing.Point(123, 318);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "選択";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnClose.Location = new System.Drawing.Point(12, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoR18);
            this.panel1.Controls.Add(this.rdoNotR18);
            this.panel1.Controls.Add(this.rdoAll);
            this.panel1.Location = new System.Drawing.Point(13, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 25);
            this.panel1.TabIndex = 2;
            // 
            // rdoR18
            // 
            this.rdoR18.AutoSize = true;
            this.rdoR18.Location = new System.Drawing.Point(136, 5);
            this.rdoR18.Name = "rdoR18";
            this.rdoR18.Size = new System.Drawing.Size(43, 16);
            this.rdoR18.TabIndex = 2;
            this.rdoR18.TabStop = true;
            this.rdoR18.Text = "R18";
            this.rdoR18.UseVisualStyleBackColor = true;
            // 
            // rdoNotR18
            // 
            this.rdoNotR18.AutoSize = true;
            this.rdoNotR18.Location = new System.Drawing.Point(73, 5);
            this.rdoNotR18.Name = "rdoNotR18";
            this.rdoNotR18.Size = new System.Drawing.Size(59, 16);
            this.rdoNotR18.TabIndex = 1;
            this.rdoNotR18.TabStop = true;
            this.rdoNotR18.Text = "全年齢";
            this.rdoNotR18.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(4, 5);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(66, 16);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "指定なし";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // SearchChara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCharaName);
            this.Controls.Add(this.label1);
            this.Name = "SearchChara";
            this.Text = "特徴検索";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCharaName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoR18;
        private System.Windows.Forms.RadioButton rdoNotR18;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}