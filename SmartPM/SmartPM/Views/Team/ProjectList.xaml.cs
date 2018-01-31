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
	public partial class ProjectList : ContentPage
	{
		public ProjectList ()
		{
			InitializeComponent ();
            List<AProjectList> list = new List<AProjectList>
            {
                new AProjectList
                {
                    projectName = "dummyProject001",
                    projectManager = "dummyManager001",
                    projectStart = "dummyStartDate",
                    projectEnd = "dummyEndDate",
                    projectCost = "10,000,000 Baht"
                },
               
                  new AProjectList
                {
                    projectName = "dummyProject005",
                    projectManager = "dummyManager005",
                    projectStart = "dummyStartDate",
                    projectEnd = "dummyEndDate",
                    projectCost = "10 Baht"
                }
            };
            projectlist.ItemsSource = list;
        }

        private async void projectlist_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var Projectlists = e.Item as AProjectList;
            string id = Projectlists.projectName;


            var page = new ProjectDashboardScreen();
            //App.Current.MainPage = new NavigationPage(page);
            await Navigation.PushAsync(page);
        }
    }
}