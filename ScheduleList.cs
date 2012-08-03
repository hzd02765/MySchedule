using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchedule
{
    class ScheduleList
    {
        private List<ShortItem> shortitems;
        private List<LongItem> longitems;

        public ScheduleList()
        {
            shortitems = new List<ShortItem>();
            longitems = new List<LongItem>();
        }

        public bool AddShortitems(ShortItem sitem)
        {
            //if (FindShortitem(sitem))
            if (SelectShortitems(sitem.StartDateTime, sitem.Itemall) == null)
            {
                shortitems.Add(sitem);
                return true;
            }
            return false;
        }

        //public void DeleteShortitems(int index)
        //{
        //    shortitems.RemoveAt(index);
        //}

        public void DeleteShortitems(DateTime startdate, string itemString)
        {
            shortitems.RemoveAll(delegate(ShortItem s)
            {
                return s.StartDateTime.Date == startdate.Date && s.Itemall == itemString;
            });
        }

        //public ShortItem SelectShortitems(int index)
        //{
        //    int loop = 0;
        //    foreach (ShortItem sitem in shortitems)
        //    {
        //        if (loop == index)
        //        {
        //            return sitem;
        //        }
        //        loop++;
        //    }
        //    return null;
        //}

        public ShortItem SelectShortitems(DateTime startdate, string itemString)
        {
            return shortitems.Find(delegate(ShortItem s)
            {
                return s.StartDateTime.Date == startdate.Date && s.Itemall == itemString;
            });
        }

        //public bool FindShortitem(ShortItem sitem)
        //{
        //    foreach (ShortItem sitem2 in shortitems)
        //    {
        //        if (sitem2.Itemall == sitem.Itemall)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        public bool AddLongitems(LongItem litem)
        {
            //if (FindLongitem(litem))
            if (SelectLongitems(litem.Itemall) == null)
            {
                longitems.Add(litem);
                return true;
            }
            return false;
        }

        //public void DeleteLongitems(int index)
        //{
        //    longitems.RemoveAt(index);
        //}

        public void DeleteLongitems(string itemString)
        {
            longitems.RemoveAll(delegate(LongItem l)
            {
                return l.Itemall == itemString;
            });
        }

        //public LongItem SelectLongitems(int index)
        //{
        //    int loop = 0;
        //    foreach (LongItem litem in longitems)
        //    {
        //        if (loop == index)
        //        {
        //            return litem;
        //        }
        //        loop++;
        //    }
        //    return null;
        //}

        public LongItem SelectLongitems(string itemString)
        {
            return longitems.Find(delegate(LongItem l)
            {
                return l.Itemall == itemString;
            });
        }

        //public bool FindLongitem(LongItem litem)
        //{
        //    foreach (LongItem litem2 in longitems)
        //    {
        //        if (litem2.Itemall == litem.Itemall)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        public List<ShortItem> Shortitems
        {
            get
            {
                return shortitems;
            }
        }

        public List<LongItem> Longitems
        {
            get
            {
                return longitems;
            }
        }
        public List<ShortItem> GetCurrentShortitems(DateTime startdate)
        {
            return shortitems.FindAll(delegate(ShortItem shortitem)
            {
                return shortitem.StartDateTime.Date == startdate.Date;
            });
        }
        public List<LongItem> GetCurrentLongitems(DateTime startdate)
        {
            return longitems.FindAll(delegate(LongItem longitem)
            {
                return longitem.StartDateTime.Date <= startdate.Date && longitem.EndDateTime.Date >= startdate.Date;
            });
        }
    }
}
