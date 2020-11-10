using System;

using System.ComponentModel;
using Xamarin.Forms;
using MyToDo.Models;
namespace MyToDo.ViewModels
{
    public class AddTaskViewModel : BaseViewModel
    {
        private AddTaskModel task;

        //public event PropertyChangedEventHandler PropertyChanged;

        public AddTaskViewModel()
        {
            task = new AddTaskModel
            {
                Id = "",
                TaskName = "",
                Prio = false,
                Guest = "",
                TaskDate = DateTime.Now,
               // DateAndTime = "",
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

                System.Diagnostics.Debug.WriteLine("hello from time" + value);
                if (value.Equals(task.TaskTime.Date)) return;



                task.TaskTime = value;
               // System.Console.WriteLine("iam here"+value);
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged();

            }
        }

        /*
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
                System.Diagnostics.Debug.WriteLine("hello from date and time" + value);

                if (value.Equals(task.TaskTime.Date)) return;


                task.DateAndTime = value;
                //System.Console.WriteLine("iam here" + value);
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged();

            }
        }
        */
        public DateTime TaskDate

        {
            get { 
                return 
                    task.TaskDate.Date;
                    }
            //get { return task.TaskDate.ToString(@"dd\/M\/yy");}
            set
            {
                System.Diagnostics.Debug.WriteLine("hello from date" + value);
                if (value.Equals(task.TaskDate.Date)) return;
                task.TaskDate = value;
                    

               // task.TaskDate = value;
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged();

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
                System.Diagnostics.Debug.WriteLine("hello from name" + value);
                if (value.Equals(task.TaskName)) return;

                task.TaskName = value;
                //System.Console.WriteLine("iam here" + value);
                OnPropertyChanged();
               
            }
        }

        public Boolean Prio
        {
            get { return task.Prio; }
            set
            {

                System.Diagnostics.Debug.WriteLine("hello from prio" + value);
                if (value.Equals(task.Prio)) return;



                task.Prio = value;
                OnPropertyChanged();

            }
        }
        public string Guest
        {
            get { return task.Guest; }
            set
            {
                System.Diagnostics.Debug.WriteLine("hello from guest" + value);
                if (value.Equals(task.Guest)) return;
                task.Guest = value;
                OnPropertyChanged();

            }
        }

        
    }
}
