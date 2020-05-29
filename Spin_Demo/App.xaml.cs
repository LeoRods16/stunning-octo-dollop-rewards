using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spin_Demo
{
    public partial class App : Application
    {
        public static string filePath;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ScratchPage());
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
