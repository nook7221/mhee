using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Models
{
    public class AccountEditModel
    {

        public string userId { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string jobResponsible { get; set; }

        public string userEditBy { get; set; }

        public string groupId { get; set; }

        public string groupName { get; set;}

        public string status { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }
    }
    public partial class AccountEditModles
    {

        public List<AccountEditModel> AccountEditModels { get; set; }
    }
}

