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
            long totalMinutes = minutes;
            long years = totalMinutes / (518400 * 60);
            totalMinutes %= 518400 * 60;
            long months = totalMinutes / (43200 * 60);
            totalMinutes %= 43200 * 60;
            long days = totalMinutes / (1440 * 60);
            totalMinutes %= 1440 * 60;
            long hours = totalMinutes / 3600;
            totalMinutes %= 3600;
            long remainingMinutes = totalMinutes / 60;

            return $"{years:D4}-{months + 1:D2}-{days + 1:D2} {hours:D2}:{remainingMinutes:D2}";
        }
    }
}
