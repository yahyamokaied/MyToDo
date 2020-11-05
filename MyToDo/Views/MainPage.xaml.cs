 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDo.Models;
using Xamarin.Forms;


namespace MyToDo.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageModel();
        }

        void Btn_GoToAddTask(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddTask());
        }
    }
}
