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
	public partial class GlobalTimesheet2 : ContentPage
	{
        public string GprojectName { get; set; }
        public string GtaskName { get; set; }
		public GlobalTimesheet2 (string proname)
		{
            InitializeComponent();

            phase.Items.Add("Phase001");        
            phase.Items.Add("Phase003");
            phase.Items.Add("Phase006");

            GprojectName = proname;
            BindingContext = this;


        }

        private void phase_SelectedIndexChanged(object sender, EventArgs e)
        {
            GtaskName = phase.Items[phase.SelectedIndex];
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalTimesheet3(GprojectName,GtaskName));
        }
    }
}