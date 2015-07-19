using appPoo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace appPoo
{
    public class App : Application
    {
        static RootPage masterDetail;

        public static  RootPage criarMenuELayout()
        {
            masterDetail = new RootPage();
            return masterDetail;

        }
        public App()
        {
            MainPage = criarMenuELayout();
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
