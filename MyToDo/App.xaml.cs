using System;
using Xamarin.Forms;
using MyToDo.Models;
using MyToDo.Views;
using Xamarin.Forms.Xaml;
using MyToDo.Services;
using Xamarin.Essentials;

namespace MyToDo
{
    public partial class App : Application
    {
        static Database database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
