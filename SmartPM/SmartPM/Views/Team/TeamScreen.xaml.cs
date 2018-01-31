using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SmartPM.Models;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SmartPM.Views.Admin;
using Plugin.Connectivity;
using SmartPM.Views;


namespace SmartPM.Views.Team
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TeamScreen : ContentPage
	{
		public TeamScreen ()
		{
			InitializeComponent ();

            List<TeamModels> list = new List<TeamModels>
            {
                new TeamModels
                {
                    projectnumber = "Project 001",
                    managername = "ProjectManager 001",
                    employeename1 = "Employee001",
                    employeename2 = "Employee002",
                    employeename3 = "Employee003",
                    employeename4 = "Employee004",
                    employeename5 = "Employee005"
                }
            };
            projectlist.ItemsSource = list;
        }
	}
}