 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDo.Models;
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

        protected override void OnAppearing()
        {
            //base.OnAppearing();

            string DBPath = Database.DBPath;
            SQLiteConnection db = new SQLiteConnection(DBPath);

            //void getData()
           // {
                lv = new ListView();
                lv.ItemsSource = db.Table<AddTaskModel>().OrderBy(t => t.TaskName).ToList();
            //};
        }
    }

    
}
