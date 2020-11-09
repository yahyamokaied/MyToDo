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
                Id = "",
                TaskName = "",
                Prio = false,
                Guest = "",
                TaskDate = DateTime.Now,
                DateAndTime = "",
                TaskTime = DateTime.Now


            };
        }


        public DateTime TaskTime

        {

            get
            {
                return task.TaskTime.Date;
            }
            //get { return task.TaskDate.ToString(@"dd\/M\/yy");}
            set
            {
                task.TaskTime = value;
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged("TaskTime");

            }
        }


        public string DateAndTime

        {
            
            get
            {
                string txt =
                    task.TaskDate.ToShortDateString() + task.TaskTime.ToShortTimeString();
                return txt
                    ;
            }
            //get { return task.TaskDate.ToString(@"dd\/M\/yy");}
            set
            {
                task.DateAndTime = value;
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged("DateAndTime");

            }
        }

        public DateTime TaskDate

        {
            get { 
                return 
                    task.TaskDate.Date;
                    }
            //get { return task.TaskDate.ToString(@"dd\/M\/yy");}
            set
            {
                task.TaskDate = value;
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged("TaskDate");

            }
        }
        /*
        public string TaskDate
        {
            get { return task.TaskDate; }
            set
            {
                task.TaskDate = value;
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged("TaskDate");

            }
        }
        */
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

        public Boolean Prio
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

        void Btn_save(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
