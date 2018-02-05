using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net;
using SmartPM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace SmartPM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GlobalTimesheet : ContentPage
	{
        public string GprojectName { get; set; }
		public GlobalTimesheet ()
		{
			InitializeComponent ();

            project.Items.Add("Project001");
            project.Items.Add("Project002");
            project.Items.Add("dummyProject");




        
        }

        private void project_SelectedIndexChanged(object sender, EventArgs e)
        {
            GprojectName = project.Items[project.SelectedIndex];
        }
      
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalTimesheet2(GprojectName));
        }
    }
	
}