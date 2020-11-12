using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDo.Models;
using Xamarin.Essentials;
using MyToDo.Services;
using SQLite;
using Xamarin.Forms;

namespace MyToDo.Views
{
    public partial class AddTask : ContentPage
    {
        public AddTask()
        {
            InitializeComponent();

            //BindingContext = new AddTaskModel();
            BindingContext = new ViewModels.AddTaskViewModel();
        }

        void Btn_GoToHome(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
        /*
        void Btn_save(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
        */

        async void Btn_Mail(System.Object sender, System.EventArgs e)
        {


            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    // do your UWP assignments...
                    break;
                case Device.Android:
                    var da = taskDateInput.Date.ToString();
                    var ti = taskTimeInput.Time.ToString();
                    var pr = prioInput.IsToggled.ToString();
                    var ta = taskNameInput.Text.ToString();
                    var sub = "New Task " + da + " "+ ti;
                    var bod = " \rPriority: " + pr + " \rTask: " + ta;
                    await Email.ComposeAsync(sub,bod, guestInput.Text);
                    break;
                default:
                    // do your Android & iOS assignments...
                    break;
            }

        }

        }

    
}
