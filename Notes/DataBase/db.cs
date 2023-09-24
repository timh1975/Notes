using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Notes.DataBase
{
    public class db
    {
        static SQLiteAsyncConnection database;

        public db()
        {

        }


        public static async Task Init()
        {
            if (database != null)
                return;

            database = new SQLiteAsyncConnection(Constrants.DatabasePath, Constrants.Flags);
            var result = await database.CreateTableAsync<Note>();
        }

        public static async Task AddNote(Note n)
        {          
            await Init();

            var result = await database.InsertAsync(n);
        }

    }

}

