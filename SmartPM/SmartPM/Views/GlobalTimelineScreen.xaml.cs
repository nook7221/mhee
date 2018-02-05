using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace SmartPM.Views.Team
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GlobalTimelineScreen : ContentPage
	{
		public GlobalTimelineScreen ()
		{
			InitializeComponent ();
            IList<TempTimelineModel> item = new ObservableCollection<TempTimelineModel>()
            {
                new TempTimelineModel
                {
                    _date = "5/2/2018",
                    _header = "Project Start",
                    _descrips = "This Project has been started"

                },
                new TempTimelineModel
                {
                    _date = "6/2/2018",
                    _header = "Project phase 1",
                    _descrips = "phase 1 has been finished"
                },
                 new TempTimelineModel
                {
                    _date = "7/2/2018",
                    _header = "Project phase 2",
                    _descrips = "phase 2 has been finished"
                },
                  new TempTimelineModel
                {
                    _date = "8/2/2018",
                    _header = "Project phase 3",
                    _descrips = "phase 3 has been finished"
                },
                new TempTimelineModel
                {
                    _date = "10/2/1018",
                    _header = "Project End",
                    _descrips = "This Project has been finished",
                    IsLast = true

                },
                                new TempTimelineModel
                {
                    _date = "11/2/1018",
                    _header = "Project Edit 1",
                    _descrips = "Edit batch 1",
                    IsLast = true

                },
                                                new TempTimelineModel
                {
                    _date = "11/2/1018",
                    _header = "Project Edit 2",
                    _descrips = "Edit batch 2",
                    IsLast = true

                }
            };
            BindingContext = item;

		}

        private void timelineListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            timelineListView.SelectedItem = null;
        }
    }
}