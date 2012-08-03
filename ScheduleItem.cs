using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchedule
{
    abstract class ScheduleItem
    {
        protected DateTime startDateTime, endDateTime;
        private string subject;
        private string contents;
        protected string itemall;

        public ScheduleItem(string subject, string contents)
        {
            this.subject = subject;
            this.contents = contents;
        }

        public string Itemall
        {
            get
            {
                return itemall;
            }

        }

        public string Subject
        {
            get
            {
                return subject;
            }

        }

        public string Contents
        {
            get
            {
                return contents;
            }
        }
        public abstract string[] GetField();
        public DateTime StartDateTime
        {
            get
            {
                return startDateTime;
            }
        }
        public DateTime EndDateTime
        {
            get
            {
                return endDateTime;
            }
        }
    }
    class ShortItem : ScheduleItem
    {
        public ShortItem(string sdate, string start, string end, string subject, string contents)
            : base(subject, contents)
        {
            //startDateTime = DateTime.Parse(sdate + " " + start);
            //endDateTime = DateTime.Parse(sdate + " " + end);
            //itemall = start + "～" + end + " " + subject + ":" + contents;
            if (DateTime.Parse(sdate + " " + start) <= DateTime.Parse(sdate + " " + end))
            {
                startDateTime = DateTime.Parse(sdate + " " + start);
                endDateTime = DateTime.Parse(sdate + " " + end);
                itemall = start + "～" + end + " " + subject + ":" + contents;
            }
            else
            {
                endDateTime = DateTime.Parse(sdate + " " + start);
                startDateTime = DateTime.Parse(sdate + " " + end);
                itemall = end  + "～" + start + " " + subject + ":" + contents;
            }
        }
        public override string[] GetField()
        {
            string[] field = new string[3];
            field[0] = string.Format("{0:yyyy/MM/dd}", startDateTime);
            field[1] = string.Format("{0:HH:mm}", startDateTime);
            field[2] = string.Format("{0:HH:mm}", endDateTime);
            return field;
        }
    }
    class LongItem : ScheduleItem
    {
        public LongItem(string sdate, string edate, string subject, string contents)
            : base(subject, contents)
        {
            startDateTime = DateTime.Parse(sdate);
            endDateTime = DateTime.Parse(edate);
            itemall = sdate.Substring(5) + "～" + edate.Substring(5) + " " + subject + ":" + contents;
        }
        public override string[] GetField()
        {
            string[] field = new string[2];
            field[0] = string.Format("{0:yyyy/MM/dd}", startDateTime);
            field[1] = string.Format("{0:yyyy/MM/dd}", endDateTime);
            return field;
        }
    }
}
