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
    public partial class MainPage : ContentPage
    {
        //private ListView lv;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageModel();

        }

       

        void Btn_GoToAddTask(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddTask());
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            lv.ItemsSource = await App.Database.GetItemsAsync();

            
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new AddTask()
                {
                    BindingContext = e.SelectedItem as AddTaskModel
                });
            }
        }
    }

    
}
