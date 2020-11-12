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
        
       

        public ICommand BtnSave { get; set; }
        public AddTaskModel task;
        private AddTaskModel newTask;

        

        public AddTaskViewModel()
        {
            
            task = new AddTaskModel
            {
                
                TaskName = "",
                Prio = false,
                Guest = "",
                TaskDate = DateTime.Now,
               
                TaskTime = DateTime.Now


            };

            BtnSave = new Command(
                 async() =>
                 
                 {
                     
                    
                     

                     newTask = new AddTaskModel
                     {
                         
                        Prio = task.Prio,
                         Guest = task.Guest,
                         TaskName = task.TaskName,
                         TaskDate = task.TaskDate,
                        TaskTime = task.TaskTime,
                        


                     };

                     
                     await App.Database.SaveItemAsync(newTask);
                     
                 });
        }

        
        
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
            
            set
            {
                System.Diagnostics.Debug.WriteLine("hello from date" + value);
                if (value.Equals(task.TaskDate.Date)) return;
                task.TaskDate = value;
                    

              
                OnPropertyChanged();

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
