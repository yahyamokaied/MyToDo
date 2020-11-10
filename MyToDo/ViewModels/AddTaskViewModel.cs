using System;

using System.ComponentModel;
using Xamarin.Forms;
using MyToDo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MyToDo.Services;
using SQLite;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    public class AddTaskViewModel : BaseViewModel

    {
        
        /*
        public AddTaskViewModel()//INavigationService navigation)   
        {
            System.Diagnostics.Debug.WriteLine("iam live " + task);
            
        //);
        }
        */

        public ICommand BtnSave { get; set; }
        public AddTaskModel task;
        private AddTaskModel newTask;

        //public event PropertyChangedEventHandler PropertyChanged;

        public AddTaskViewModel()
        {
            // INavigationService navigation
            string DBPath = Database.DBPath;
            SQLiteConnection db = new SQLiteConnection(DBPath);
            task = new AddTaskModel
            {
                
                TaskName = "",
                Prio = false,
                Guest = "",
                TaskDate = DateTime.Now,
               // DateAndTime = "",
                TaskTime = DateTime.Now


            };

            BtnSave = new Command(
                 async() =>
                 //(async () =>
                 {
                     
                    
                     db.CreateTable<AddTaskModel>();
                     var maxPk = db.Table<AddTaskModel>().OrderByDescending(t => t.Id).FirstOrDefault();

                     newTask = new AddTaskModel
                     {
                         Id = (maxPk == null ? 1 : maxPk.Id+1),
                        Prio = task.Prio,
                         Guest = task.Guest,
                         TaskName = task.TaskName,
                         TaskDate = task.TaskDate,
                         TaskTime = task.TaskTime


                     };
                     db.Insert(newTask);
                     // :

                     // fix the alert :)
                     //await DisplayAlert("Alert", " Saved!!! ");
                     //System.Diagnostics.Debug.WriteLine("the task is : " +  newTask.TaskName);
                     //await navigation.PopAsync();

                     
                     //System.Diagnostics.Debug.WriteLine("the task is : " +  task.TaskName);
                 });
        }

        /*
        private Task DisplayAlert(object p, string v1, string v2)
        {
            throw new NotImplementedException();
        }
        */
        /*
        private Task DisplayAlert()
        {
            throw new NotImplementedException();
        }
        */

        public DateTime TaskTime

        {

            get
            {
                return task.TaskTime.Date;
            }
            
            set
            {

                System.Diagnostics.Debug.WriteLine("hello from time" + value);
                if (value.Equals(task.TaskTime.Date)) return;



                task.TaskTime = value;
              
                OnPropertyChanged();

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
                System.Diagnostics.Debug.WriteLine("hello from date" + value);
                if (value.Equals(task.TaskDate.Date)) return;
                task.TaskDate = value;
                    

               // task.TaskDate = value;
                //string s2 = TaskDate.ToString("dd/MM/yyyy");
                OnPropertyChanged();

            }
        }
        
        /*
        public int Id
        {
            get { return task.Id; }
            set
            {
                task.Id = value;
                OnPropertyChanged("Id");

            }
        }
        */
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

        public bool Prio
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
