using System;
using System.IO;
using SQLite;

namespace MyToDo.Services
{
    public class Database
    {
       

          public static string DBPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
       
        
    }
}
