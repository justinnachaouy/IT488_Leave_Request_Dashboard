using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT488_Leave_Request_Dashboard
{
    //
    // Global Variables
    //
    public static class Globals
    {
        public static string VarUsername { get; set; }
        public static string VarPassword { get; set; }
        public static string VarServer { get; set; }
        public static string VarDatabase { get; set; }
        public static string VarRole { get; set; }
        public static string SQLUsername { get; set; }
        public static bool Requesting_Specific_Time_Variable { get; set; }
        public static string Request_Type_Variable { get; set; }
        public static DateTime Start_Date_Variable { get; set; }
        public static DateTime End_Date_Variable { get; set; }
        public static string Start_Time_Variable { get; set; }
        public static string End_Time_Variable { get; set; }
        public static string Note_Variable { get; set; }

        public static bool ViewingEmployeeRequests { get; set; }
        public static string sqlConnectionString { get; set; }


    }

}
