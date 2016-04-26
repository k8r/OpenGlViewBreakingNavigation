using System;

using Xamarin.Forms;

namespace OpenGlViewBreakingNavigation
{
    // test app that shows how xamarin.forms 2.1 throws an exception when you try to 
    // navigate between two pages, one with an Open GL View; 1.3.5 doesn't have this problem
    public class App : Application
    {
        public App()
        {
            var navPage = new NavigationPage(new FirstPage());
            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

