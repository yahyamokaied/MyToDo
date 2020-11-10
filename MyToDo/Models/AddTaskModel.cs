using System;
using SQLite;

namespace MyToDo.Models
{
    public class AddTaskModel
    {
        [PrimaryKey , AutoIncrement]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool Prio { get; set; }
        public string Guest { get; set; }
        public DateTime TaskDate { get; set; }
        public string DateAndTime { get; set; }
        public DateTime TaskTime { get; set; }
        public bool Done { get; set; }
        //TaskTime
        //public string TaskInfo()
        // { return $"{TaskName} {Prio} {Guest} {TaskDate}{TaskTime}"; }

        public override string ToString()
        {
            return this.TaskName + "(" + TaskDate + TaskTime + "With " + Guest + ")";
           // return base.ToString();
        }




    }
}
