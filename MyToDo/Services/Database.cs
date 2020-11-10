using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using System.Linq;
using System.Threading.Tasks;
using MyToDo.Models;
using MyToDo.Services;


namespace MyToDo.Services
{
    public class Database
    {

        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });
        static SQLiteAsyncConnection DB => lazyInitializer.Value;
        static bool initialized = false;


        public Database()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!DB.TableMappings.Any(m => m.MappedType.Name == typeof(AddTaskModel).Name))
                {
                    await DB.CreateTablesAsync(CreateFlags.None, typeof(AddTaskModel)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<AddTaskModel>> GetItemsAsync()
        {
            return DB.Table<AddTaskModel>().ToListAsync();
        }

        public Task<List<AddTaskModel>> GetItemsNotDoneAsync()
        {
            return DB.QueryAsync<AddTaskModel>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<AddTaskModel> GetItemAsync(int id)
        {
            return DB.Table<AddTaskModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(AddTaskModel item)
        {
            if (item.Id != 0)
            {
                return DB.UpdateAsync(item);
            }
            else
            {
                return DB.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(AddTaskModel item)
        {
            return DB.DeleteAsync(item);
        }

        //public static string DBPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");


    }
}
