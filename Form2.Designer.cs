﻿namespace MySchedule
{
    partial class DisplayForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endtimeDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.enddateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.starttimeDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.startdateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.contentTextBox);
            this.groupBox1.Controls.Add(this.subjectTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.endtimeDomainUpDown);
            this.groupBox1.Controls.Add(this.enddateTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.starttimeDomainUpDown);
            this.groupBox1.Controls.Add(this.startdateTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(179, 209);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(6, 105);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(248, 98);
            this.contentTextBox.TabIndex = 8;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(41, 80);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.ReadOnly = true;
            this.subjectTextBox.Size = new System.Drawing.Size(213, 19);
            this.subjectTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "件名";
            // 
            // endtimeDomainUpDown
            // 
            this.endtimeDomainUpDown.Items.Add("23:30");
            this.endtimeDomainUpDown.Items.Add("23:00");
            this.endtimeDomainUpDown.Items.Add("22:30");
            this.endtimeDomainUpDown.Items.Add("22:00");
            this.endtimeDomainUpDown.Items.Add("21:30");
            this.endtimeDomainUpDown.Items.Add("21:00");
            this.endtimeDomainUpDown.Items.Add("20:30");
            this.endtimeDomainUpDown.Items.Add("20:00");
            this.endtimeDomainUpDown.Items.Add("19:30");
            this.endtimeDomainUpDown.Items.Add("19:00");
            this.endtimeDomainUpDown.Items.Add("18:30");
            this.endtimeDomainUpDown.Items.Add("18:00");
            this.endtimeDomainUpDown.Items.Add("17:30");
            this.endtimeDomainUpDown.Items.Add("17:00");
            this.endtimeDomainUpDown.Items.Add("16:30");
            this.endtimeDomainUpDown.Items.Add("16:00");
            this.endtimeDomainUpDown.Items.Add("15:30");
            this.endtimeDomainUpDown.Items.Add("15:00");
            this.endtimeDomainUpDown.Items.Add("14:30");
            this.endtimeDomainUpDown.Items.Add("14:00");
            this.endtimeDomainUpDown.Items.Add("13:30");
            this.endtimeDomainUpDown.Items.Add("13:00");
            this.endtimeDomainUpDown.Items.Add("12:30");
            this.endtimeDomainUpDown.Items.Add("12:00");
            this.endtimeDomainUpDown.Items.Add("11:30");
            this.endtimeDomainUpDown.Items.Add("11:00");
            this.endtimeDomainUpDown.Items.Add("10:30");
            this.endtimeDomainUpDown.Items.Add("10:00");
            this.endtimeDomainUpDown.Items.Add("09:30");
            this.endtimeDomainUpDown.Items.Add("09:00");
            this.endtimeDomainUpDown.Items.Add("08:30");
            this.endtimeDomainUpDown.Items.Add("08:00");
            this.endtimeDomainUpDown.Items.Add("07:30");
            this.endtimeDomainUpDown.Items.Add("07:00");
            this.endtimeDomainUpDown.Items.Add("06:30");
            this.endtimeDomainUpDown.Items.Add("06:00");
            this.endtimeDomainUpDown.Items.Add("05:30");
            this.endtimeDomainUpDown.Items.Add("05:00");
            this.endtimeDomainUpDown.Items.Add("04:30");
            this.endtimeDomainUpDown.Items.Add("04:00");
            this.endtimeDomainUpDown.Items.Add("03:30");
            this.endtimeDomainUpDown.Items.Add("03:00");
            this.endtimeDomainUpDown.Items.Add("02:30");
            this.endtimeDomainUpDown.Items.Add("02:00");
            this.endtimeDomainUpDown.Items.Add("01:30");
            this.endtimeDomainUpDown.Items.Add("01:00");
            this.endtimeDomainUpDown.Items.Add("00:30");
            this.endtimeDomainUpDown.Items.Add("00:00");
            this.endtimeDomainUpDown.Location = new System.Drawing.Point(140, 39);
            this.endtimeDomainUpDown.Name = "endtimeDomainUpDown";
            this.endtimeDomainUpDown.ReadOnly = true;
            this.endtimeDomainUpDown.Size = new System.Drawing.Size(120, 19);
            this.endtimeDomainUpDown.TabIndex = 5;
            this.endtimeDomainUpDown.Text = "domainUpDown1";
            this.endtimeDomainUpDown.Wrap = true;
            // 
            // enddateTextBox
            // 
            this.enddateTextBox.Location = new System.Drawing.Point(41, 38);
            this.enddateTextBox.Name = "enddateTextBox";
            this.enddateTextBox.ReadOnly = true;
            this.enddateTextBox.Size = new System.Drawing.Size(100, 19);
            this.enddateTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "終了";
            // 
            // starttimeDomainUpDown
            // 
            this.starttimeDomainUpDown.Items.Add("23:30");
            this.starttimeDomainUpDown.Items.Add("23:00");
            this.starttimeDomainUpDown.Items.Add("22:30");
            this.starttimeDomainUpDown.Items.Add("22:00");
            this.starttimeDomainUpDown.Items.Add("21:30");
            this.starttimeDomainUpDown.Items.Add("21:00");
            this.starttimeDomainUpDown.Items.Add("20:30");
            this.starttimeDomainUpDown.Items.Add("20:00");
            this.starttimeDomainUpDown.Items.Add("19:30");
            this.starttimeDomainUpDown.Items.Add("19:00");
            this.starttimeDomainUpDown.Items.Add("18:30");
            this.starttimeDomainUpDown.Items.Add("18:00");
            this.starttimeDomainUpDown.Items.Add("17:30");
            this.starttimeDomainUpDown.Items.Add("17:00");
            this.starttimeDomainUpDown.Items.Add("16:30");
            this.starttimeDomainUpDown.Items.Add("16:00");
            this.starttimeDomainUpDown.Items.Add("15:30");
            this.starttimeDomainUpDown.Items.Add("15:00");
            this.starttimeDomainUpDown.Items.Add("14:30");
            this.starttimeDomainUpDown.Items.Add("14:00");
            this.starttimeDomainUpDown.Items.Add("13:30");
            this.starttimeDomainUpDown.Items.Add("13:00");
            this.starttimeDomainUpDown.Items.Add("12:30");
            this.starttimeDomainUpDown.Items.Add("12:00");
            this.starttimeDomainUpDown.Items.Add("11:30");
            this.starttimeDomainUpDown.Items.Add("11:00");
            this.starttimeDomainUpDown.Items.Add("10:30");
            this.starttimeDomainUpDown.Items.Add("10:00");
            this.starttimeDomainUpDown.Items.Add("09:30");
            this.starttimeDomainUpDown.Items.Add("09:00");
            this.starttimeDomainUpDown.Items.Add("08:30");
            this.starttimeDomainUpDown.Items.Add("08:00");
            this.starttimeDomainUpDown.Items.Add("07:30");
            this.starttimeDomainUpDown.Items.Add("07:00");
            this.starttimeDomainUpDown.Items.Add("06:30");
            this.starttimeDomainUpDown.Items.Add("06:00");
            this.starttimeDomainUpDown.Items.Add("05:30");
            this.starttimeDomainUpDown.Items.Add("05:00");
            this.starttimeDomainUpDown.Items.Add("04:30");
            this.starttimeDomainUpDown.Items.Add("04:00");
            this.starttimeDomainUpDown.Items.Add("03:30");
            this.starttimeDomainUpDown.Items.Add("03:00");
            this.starttimeDomainUpDown.Items.Add("02:30");
            this.starttimeDomainUpDown.Items.Add("02:00");
            this.starttimeDomainUpDown.Items.Add("01:30");
            this.starttimeDomainUpDown.Items.Add("01:00");
            this.starttimeDomainUpDown.Items.Add("00:30");
            this.starttimeDomainUpDown.Items.Add("00:00");
            this.starttimeDomainUpDown.Location = new System.Drawing.Point(140, 12);
            this.starttimeDomainUpDown.Name = "starttimeDomainUpDown";
            this.starttimeDomainUpDown.ReadOnly = true;
            this.starttimeDomainUpDown.Size = new System.Drawing.Size(120, 19);
            this.starttimeDomainUpDown.TabIndex = 2;
            this.starttimeDomainUpDown.Text = "domainUpDown1";
            this.starttimeDomainUpDown.Wrap = true;
            // 
            // startdateTextBox
            // 
            this.startdateTextBox.Location = new System.Drawing.Point(41, 12);
            this.startdateTextBox.Name = "startdateTextBox";
            this.startdateTextBox.ReadOnly = true;
            this.startdateTextBox.Size = new System.Drawing.Size(100, 19);
            this.startdateTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "開始";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "予定の表示";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DomainUpDown starttimeDomainUpDown;
        internal System.Windows.Forms.TextBox startdateTextBox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox enddateTextBox;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox contentTextBox;
        internal System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DomainUpDown endtimeDomainUpDown;
        internal System.Windows.Forms.Button okButton;
    }
}