using System;
using Xamarin.Forms;

namespace donateRed.Common
{
    public class App : Application
    {

        public App()
        {
            MainPage = new NavigationPage(new Views.MainPage());

        }


    }
}
