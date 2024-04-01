using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public static class Utils
    {
        private static DayTime _time;
        private static Random random;
        public static readonly Dictionary<Account_Type, string> ACCOUNT_TYPE = new Dictionary<Account_Type, string>()
        {
            { Account_Type.Checking, "CH" },
            { Account_Type.Saving, "SA" },
            { Account_Type.Visa, "VI" }
        };

        public static DayTime Time
        {
            get
            {
                int randomIncrement = random.Next(1, 11); 
                _time += randomIncrement;
                return _time;
            }
        }

        public static DayTime Now
        {
            get
            {
                return _time;
            }
        }
    }
}
