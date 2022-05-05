using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT488_Leave_Request_Dashboard
{
    public static class BalanceModel
    {
        public static int EarnedPTO { get; set; }
        public static int EarnedMedical { get; set; }
        public static int EarnedLOA { get; set; }

        public static int UsedPTO { get; set; }
        public static int UsedMedical { get; set; }
        public static int UsedLOA { get; set; }

        public static int ScheduledPTO { get; set; }
        public static int ScheduledMedical { get; set; }
        public static int ScheduledLOA { get; set; }

        public static int RemainingPTO { get; set; }
        public static int RemainingMedical { get; set; }
        public static int RemainingLOA { get; set; }

    }
}
