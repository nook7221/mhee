using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Models
{
    public class TimeSheetModel
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string userPosition { get; set; }
        public string timesheetId { get; set; }
        public string date { get; set; }
        public string projectname { get; set; }
        public string projectPhase { get; set; }
        public string jobResponsible { get; set; }
        public string Duration { get; set; }
        public string OT { get; set; }
        public string totalDuration { get; set; }
        public string totalOT { get; set; }
        public string total { get; set; }
        public string RFCno { get; set; }
    }

    public class Timesheets
    {
        List<TimeSheetModel> timesheets { get; set; }
    }
}
