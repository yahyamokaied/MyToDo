using System;

using System.ComponentModel;
using Xamarin.Forms;
using MyToDo.Models;
namespace MyToDo.ViewModels
{
    public class AddTaskViewModel : BaseModel
    {
        private AddTaskModel task;

        public event PropertyChangedEventHandler PropertyChanged;

        public AddTaskViewModel()
        {
            task = new AddTaskModel
            {
                Id = "newId",
                TaskName = "Cofee with Yahya",
                Prio = "Highest",
                Guest = "Jon"



            };
        }

        public string Id
        {
            get { return task.Id; }
            set
            {
                task.Id = value;
                OnPropertyChanged("Id");

            }
        }
        public string TaskName
        {
            get { return task.TaskName; }
            set
            {
                task.TaskName = value;
                OnPropertyChanged("TaskName");

            }
        }

        public string Prio
        {
            get { return task.Prio; }
            set
            {
                task.Prio = value;
                OnPropertyChanged("Prio");

            }
        }
        public string Guest
        {
            get { return task.Guest; }
            set
            {
                task.Guest = value;
                OnPropertyChanged("Guest");

            }
        }
    }
}
