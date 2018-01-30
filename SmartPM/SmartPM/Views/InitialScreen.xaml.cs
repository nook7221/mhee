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
	public partial class InitialScreen : ContentPage
	{
        Image StartImage;

        public InitialScreen()
        {
            var sub = new AbsoluteLayout();
            StartImage = new Image
            {
                Source = "newlogo.png",
                WidthRequest = 150,
                HeightRequest = 150
            };
            AbsoluteLayout.SetLayoutFlags(StartImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(StartImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(StartImage);
            this.BackgroundColor = Color.FromHex("#F4F4F4");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await StartImage.ScaleTo(1, 2000);
            await StartImage.ScaleTo(1, 1000);
            Application.Current.MainPage = new LoginScreen();        
        }
    }
}