using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public struct DayTime
    {
        private long minutes;
        public DayTime(long min)
        {
            minutes = min;
        }
        public static DayTime operator +(DayTime left, int minutes)
        {
            return new DayTime(left.minutes + minutes);
        }
        public override string ToString()
        {
            long remainingMinutes = minutes;
            long years = remainingMinutes / (12L * 30L * 24L * 60L);
            remainingMinutes %= (12L * 30L * 24L * 60L);

            long months = remainingMinutes / (30L * 24L * 60L);
            remainingMinutes %= (30L * 24L * 60L);

            long days = remainingMinutes / (24L * 60L);
            remainingMinutes %= (24L * 60L);

            long hours = remainingMinutes / 60L;
            remainingMinutes %= 60L;
            return $"{years:0000}-{months:00}-{days:00} {hours:00}:{remainingMinutes:00}";
        }
    }
}
