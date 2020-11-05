using System;
using System.Collections.Generic;
using MyToDo.Models;
using Xamarin.Forms;

namespace MyToDo.Views
{
    public partial class AddTask : ContentPage
    {
        public AddTask()
        {
            InitializeComponent();

            BindingContext = new AddTaskModel();
        }

        void Btn_GoToHome(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
