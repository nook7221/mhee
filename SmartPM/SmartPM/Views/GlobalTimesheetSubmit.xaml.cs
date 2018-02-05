using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GlobalTimesheetSubmit : ContentPage
	{

        public string GprojectName { get; set; }
        public string GtaskName { get; set; }
        public string GjobName { get; set; }
        public GlobalTimesheetSubmit (string pname, string tname, string jname)
		{
			InitializeComponent ();
            GprojectName = pname;
            GtaskName = tname;
            GjobName = jname;
            BindingContext = this;
		}

    
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalTimesheet4());
        }
    }
}