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
using Plugin.Connectivity;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SmartPM.Views;

namespace SmartPM.Views.PM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PMMainScreen : TabbedPage
	{
		public PMMainScreen ()
		{
			InitializeComponent ();
		}
	}
}