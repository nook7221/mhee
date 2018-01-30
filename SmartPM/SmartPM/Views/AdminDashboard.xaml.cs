using SmartPM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net;
using SmartPM.Views;


namespace SmartPM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminDashboard : ContentPage
	{
        private AuthenModel userAccount = new AuthenModel();
        public AdminDashboard()
        {
            InitializeComponent();
            //App.Current.MainPage = new LoginScreen();
        }
        public AdminDashboard (AuthenModel authenModel)
        { 
			InitializeComponent ();
            userAccount = authenModel;
            BindingContext = userAccount;

            
		}

        private async void ToolbarItem_Activated(object sender, EventArgs e)
        {
            userAccount = null;
            await Navigation.PushAsync(new LoginScreen());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAccount(userAccount));
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountList());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskScreen());
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dummyView());
        }
    }
}