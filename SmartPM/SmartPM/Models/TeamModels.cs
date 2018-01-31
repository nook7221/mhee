using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Models
{
    public class TeamModels
    {
        public string projectnumber { get; set;}
        public string managername { get; set; }
        public string employeename1 { get; set;}
        public string employeename2 { get; set; }
        public string employeename3 { get; set; }
        public string employeename4 { get; set; }
        public string employeename5 { get; set; }

    }
    public class TeamModelss
    {
        List<TeamModels> team { get; set; }
    }
}
