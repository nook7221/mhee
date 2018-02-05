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
    public partial class GlobalTimesheet3 : ContentPage
    {

        public string GprojectName { get; set; }
        public string GtaskName { get; set; }
        public string GjobName { get; set; }
        public GlobalTimesheet3 (string proname, string taskname)
		{
			InitializeComponent ();

            job.Items.Add("Job001");
            job.Items.Add("Job003");


            GprojectName = proname;
            GtaskName = taskname;
            BindingContext = this;
        }

        private void job_SelectedIndexChanged(object sender, EventArgs e)
        {
            GjobName = job.Items[job.SelectedIndex];
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalTimesheetSubmit(GprojectName,GtaskName,GjobName));
        }
    }
}