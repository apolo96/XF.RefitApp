using Akavache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

using Xamarin.Forms;

namespace XF.RefitApp
{
    public partial class App : Application
    {
        public App()
        {            
            InitializeComponent();
            BlobCache.ApplicationName = "XF.RefitApp";
            MainPage = new XF.RefitApp.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
