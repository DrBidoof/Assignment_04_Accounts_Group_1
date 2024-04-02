using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public static class Utils
    {
        private static DayTime _time = new DayTime(1_048_000_000);

        private static Random random = new Random();
        public static readonly Dictionary<Account_Type, string> ACCOUNT_TYPE = new Dictionary<Account_Type, string>()
        {
            { Account_Type.Checking, "CK" },
            { Account_Type.Saving, "SV" },
            { Account_Type.Visa, "VS" }
        };

        public static DayTime Time
        {
            get => _time += random.Next(1000);
        }

        public static DayTime Now
        {
            get => _time += 0;
        }

    }
}
