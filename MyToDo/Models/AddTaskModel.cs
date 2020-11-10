using System;
using SQLite;

namespace MyToDo.Models
{
    public class AddTaskModel
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public Boolean Prio { get; set; }
        public string Guest { get; set; }
        public DateTime TaskDate { get; set; }
        public string DateAndTime { get; set; }
        public DateTime TaskTime { get; set; }
        //TaskTime
        public string TaskInfo()
        { return $"{TaskName} {Prio} {Guest} {TaskDate}{TaskTime}"; }



       


    }
}
