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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime startdate, enddate;
            int starttimeindex, endtimeindex;

            monthCalendar1.MaxSelectionCount = 100;

            startdate = monthCalendar1.SelectionStart.Date;
            startTextBox.Text = String.Format("{0:yyyy/MM/dd}", startdate);

            enddate = monthCalendar1.SelectionEnd.Date;
            endTextBox.Text = String.Format("{0:yyyy/MM/dd}", enddate);

            starttimeindex = 46 - DateTime.Now.Hour * 2;
            if (DateTime.Now.Minute > 29)
            {
                if(starttimeindex == 0){
                    starttimeindex = 47;
                }else{
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
        }
    }
}
