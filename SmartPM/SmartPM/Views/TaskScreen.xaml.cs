using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaskScreen : ContentPage
	{
		public TaskScreen ()
		{
			InitializeComponent ();
            List<TaskModel> task = new List<TaskModel>
            {
                new TaskModel
                {
                    taskId = "t001",
                    projectnumber = "p001",
                    taskname = "Gettering Requirement",
                    taskstart = "31/01/2018",
                    taskend = "01/02/2018",
                    actualstart = "01/02/2018",
                    actualend = "01/02/2018",
                    variant = "0"
                    
                },
                new TaskModel
                {
                     taskId = "t002",
                    projectnumber = "p001",
                    taskname = "Gettering Requirement",
                    taskstart = "02/02/2018",
                    taskend = "05/02/2018",
                    actualstart = "03/02/2018",
                    actualend = "05/02/2018",
                    variant = "2"
                }
            };
            Tasklist.ItemsSource = task;

		}
        private async void tasklist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        }
    }
}