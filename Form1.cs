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
        ScheduleList listitem;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDate();
            listitem = new ScheduleList();
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
            //string record;

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
                    /*
                    record = starttimeDomainUpDown.Text + "～" +
                        endtimeDomainUpDown.Text + " " +
                        subject + ":" + contentTextBox.Text;
                    scheduleListBox.Items.Add(record);
                    ClearSubject();
                     */
                    ShortItem shortitem = new ShortItem(startTextBox.Text, starttimeDomainUpDown.Text, endtimeDomainUpDown.Text, subject, contentTextBox.Text);
                    if (listitem.AddShortitems(shortitem))
                    {
                        scheduleListBox.Items.Clear();
                        foreach (ShortItem shorts in listitem.Shortitems)
                        {
                            scheduleListBox.Items.Add(shorts.Itemall);
                        }
                    }
                    else
                    {
                        MessageBox.Show("既に存在する予定です。","その日の予定エラー");
                    }
                }
                else
                {
                    label5.Text = "期間　　　　件名　　　　　　　内容";
                    /*
                    record = startTextBox.Text.Substring(5) + "～" +
                        endTextBox.Text.Substring(5) + " " + subject +
                        ":" + contentTextBox.Text;
                    scheduleListBox.Items.Add(record);
                    ClearSubject();
                     */
                    LongItem longitem = new LongItem(startTextBox.Text, endTextBox.Text, subject, contentTextBox.Text);
                    if (listitem.AddLongitems(longitem))
                    {
                        scheduleListBox.Items.Clear();
                        foreach (LongItem longs in listitem.Longitems)
                        {
                            scheduleListBox.Items.Add(longs.Itemall);
                        }
                    }
                    else
                    {
                        MessageBox.Show("既に存在する予定です。","長期の予定エラー");
                    }
                }
                ClearSubject();
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
            if (scheduleListBox.SelectedIndex == -1) return;
            if (scheduleListBox.SelectedItem.ToString().Substring(2, 1) == ":")
            {
                listitem.DeleteShortitems(scheduleListBox.SelectedIndex);
            }
            else
            {
                listitem.DeleteLongitems(scheduleListBox.SelectedIndex);
            }
            scheduleListBox.Items.Remove(scheduleListBox.SelectedItem);
            if (scheduleListBox.Items.Count == 0)
            {
                displayButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        //予定の表示
        private void displayButton_Click(object sender, EventArgs e)
        {
            if (scheduleListBox.SelectedIndex == -1) return;
            DisplayForm displayForm = new DisplayForm();

            if (label5.Text.IndexOf("時間") >= 0)
            {
                InputForm(displayForm, listitem.SelectShortitems(scheduleListBox.SelectedIndex), "short");
            }
            else
            {
                InputForm(displayForm, listitem.SelectLongitems(scheduleListBox.SelectedIndex), "long");
            }

            displayForm.ShowDialog();
        }
        private void InputForm(DisplayForm displayForm, ScheduleItem scheduleitme, string type)
        {
            string[] field = scheduleitme.GetField();
            if (type == "short")
            {
                displayForm.startdateTextBox.Text = field[0];
                displayForm.enddateTextBox.Text = "";
                displayForm.starttimeDomainUpDown.SelectedIndex = TimeTransformIndex(field[1]);
                displayForm.endtimeDomainUpDown.SelectedIndex = TimeTransformIndex(field[2]);
            }
            else
            {
                displayForm.startdateTextBox.Text = field[0];
                displayForm.enddateTextBox.Text = field[1];
                displayForm.starttimeDomainUpDown.Text = "";
                displayForm.endtimeDomainUpDown.Text = "";
            }
            displayForm.subjectTextBox.Text = scheduleitme.Subject.Trim();
            displayForm.contentTextBox.Text = scheduleitme.Contents;
            displayForm.okButton.Select();
        }
        private int TimeTransformIndex(string timestring)
        {
            for (int i = 0; i < this.starttimeDomainUpDown.Items.Count; i++)
            {
                if (this.starttimeDomainUpDown.Items[i].ToString() == timestring)
                {
                    return i;
                }
            }
            return -1;
        }

        //予定の修正
        private void updateButton_Click(object sender, EventArgs e)
        {
            bool shortflg = true;
            if (scheduleListBox.SelectedIndex == -1) return;

            UpdateForm updateForm = new UpdateForm();

            if (label5.Text.IndexOf("時間") >= 0)
            {
                updateForm.enddateTextBox.Enabled = false;
                InputForm2(updateForm, listitem.SelectShortitems(scheduleListBox.SelectedIndex), "short");
            }
            else
            {
                updateForm.starttimeDomainUpDown.Enabled = false;
                updateForm.endtimeDomainUpDown.Enabled = false;
                InputForm2(updateForm, listitem.SelectLongitems(scheduleListBox.SelectedIndex), "long");
                shortflg = false;
            }

            updateForm.ShowDialog();

            if (updateForm.DialogResult == DialogResult.OK)
            {
                if (shortflg)
                {
                    UpdateList(updateForm, "short");
                }
                else 
                {
                    UpdateList(updateForm, "long");
                }
            }
        }
        private void InputForm2(UpdateForm updateForm, ScheduleItem scheduleitme, string type)
        {
            string[] field = scheduleitme.GetField();
            if (type == "short")
            {
                updateForm.startdateTextBox.Text = field[0];
                updateForm.enddateTextBox.Text = field[0];
                updateForm.starttimeDomainUpDown.SelectedIndex = TimeTransformIndex(field[1]);
                updateForm.endtimeDomainUpDown.SelectedIndex = TimeTransformIndex(field[2]);
            }
            else
            {
                updateForm.startdateTextBox.Text = field[0];
                updateForm.enddateTextBox.Text = field[1];
                updateForm.starttimeDomainUpDown.Text = "";
                updateForm.endtimeDomainUpDown.Text = "";
            }
            updateForm.subjectTextBox.Text = scheduleitme.Subject.Trim();
            updateForm.contentTextBox.Text = scheduleitme.Contents;
            updateForm.okButton.Select();
        }
        private void UpdateList(UpdateForm updateForm, string type)
        {
            int subjectcount = Encoding.GetEncoding("Shift_JIS").GetByteCount(updateForm.subjectTextBox.Text);
            if (subjectcount > 20)
            {
                MessageBox.Show("件名を短くしてください", "予定登録エラー");
                return;
            }
            string subject = updateForm.subjectTextBox.Text + new String(' ', 20 - subjectcount);
            if (type == "short")
            {
                ShortItem shortitem = new ShortItem(updateForm.startdateTextBox.Text, updateForm.starttimeDomainUpDown.Text, updateForm.endtimeDomainUpDown.Text, subject, updateForm.contentTextBox.Text);
                if (listitem.AddShortitems(shortitem))
                {
                    listitem.DeleteShortitems(scheduleListBox.SelectedIndex);
                    scheduleListBox.Items.Clear();
                    foreach (ShortItem shorts in listitem.Shortitems)
                    {
                        scheduleListBox.Items.Add(shorts.Itemall);
                    }
                }
                else
                {
                    MessageBox.Show("既に存在する予定です", "その日の予定エラー");
                }
            }
            else
            {
                LongItem longitem = new LongItem(updateForm.startdateTextBox.Text, updateForm.enddateTextBox.Text, subject, updateForm.contentTextBox.Text);
                if (listitem.AddLongitems(longitem))
                {
                    listitem.DeleteLongitems(scheduleListBox.SelectedIndex);
                    scheduleListBox.Items.Clear();
                    foreach (LongItem longs in listitem.Longitems)
                    {
                        scheduleListBox.Items.Add(longs.Itemall);
                    }
                }
                else
                {
                    MessageBox.Show("既に存在する予定です", "長期の予定エラー");
                }
            }
        }
    }
}
