using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace SmartPM
{
   
    public class CheckConnectivity
    {

        public bool InternetCheckConnectivity()
        {

            var isConnected = CrossConnectivity.Current.IsConnected;
            if (isConnected == true)
            {
                return true;
            }
            return false;
        }

    }
 
}
