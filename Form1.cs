using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchedule
{
    public partial class MainForm : Form
    {
        DateTime startdate, enddate;
        int starttimeindex, endtimeindex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDate();
        }
        private void InitializeDate()
        {
            monthCalendar1.MaxSelectionCount = 100;

            startdate = monthCalendar1.SelectionStart.Date;
            startTextBox.Text = String.Format("{0:yyyy/MM/dd}", startdate);

            enddate = monthCalendar1.SelectionEnd.Date;
            endTextBox.Text = String.Format("{0:yyyy/MM/dd}", enddate);

            starttimeindex = 46 - DateTime.Now.Hour * 2;
            if (DateTime.Now.Minute > 29)
            {
                if (starttimeindex == 0)
                {
                    starttimeindex = 47;
                }
                else
                {
                    starttimeindex--;
                }

            }
            if (starttimeindex == 0)
            {
                endtimeindex = 47;
            }
            else
            {
                endtimeindex = starttimeindex - 1;
            }
            starttimeDomainUpDown.SelectedIndex = starttimeindex;
            endtimeDomainUpDown.SelectedIndex = endtimeindex;

            listviewGroup.Text = startTextBox.Text + " " + listviewGroup.Text; 
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            startdate = monthCalendar1.SelectionStart.Date;
            startTextBox.Text = String.Format("{0:yyyy/MM/dd}", startdate);

            enddate = monthCalendar1.SelectionEnd.Date;
            endTextBox.Text = String.Format("{0:yyyy/MM/dd}", enddate);

            if (startTextBox.Text == endTextBox.Text)
            {
                starttimeDomainUpDown.Enabled = true;
                endtimeDomainUpDown.Enabled = true;
            }
            else
            {
                starttimeDomainUpDown.Enabled = false;
                endtimeDomainUpDown.Enabled = false;
            }

            listviewGroup.Text = startTextBox.Text + " 予定リスト表示";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearSubject();
        }
        private void ClearSubject() 
        {
            subjectTextBox.Text = null;
            contentTextBox.Text = null;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            string record;

            if (subjectTextBox.Text != "" && contentTextBox.Text != "")
            {
                int subjectcount = Encoding.GetEncoding("Shift_JIS").
                    GetByteCount(subjectTextBox.Text);
                if (subjectcount > 20)
                {
                    MessageBox.Show("件名を短くしてください。", "予定登録エラー");
                    return;
                }

                string subject = subjectTextBox.Text + new String(' ', 20 - subjectcount);

                if (startTextBox.Text == endTextBox.Text)
                {
                    label5.Text = "時間　　　　件名　　　　　　　内容";
                    record = starttimeDomainUpDown.Text + "～" +
                        endtimeDomainUpDown.Text + " " +
                        subject + ":" + contentTextBox.Text;
                    scheduleListBox.Items.Add(record);
                    ClearSubject();
                }
                else
                {
                    label5.Text = "期間　　　　件名　　　　　　　内容";
                    record = startTextBox.Text.Substring(5) + "～" +
                        endTextBox.Text.Substring(5) + " " + subject +
                        ":" + contentTextBox.Text;
                    scheduleListBox.Items.Add(record);
                    ClearSubject();
                }
            }
            else 
            {
                MessageBox.Show("件名と内容を入力してください。","予定登録エラー");
            }
        }

        private void scheduleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scheduleListBox.SelectedIndex != -1)
            {
                string contents = (string)scheduleListBox.SelectedItem;
                if (Encoding.GetEncoding("Shift_JIS").GetByteCount(contents) > 59)
                {
                    displayButton.Enabled = true;
                }
                else
                {
                    displayButton.Enabled = false;
                }
            }
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            scheduleListBox.Items.Remove(scheduleListBox.SelectedItem);
        }
    }
}
