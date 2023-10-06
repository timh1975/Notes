using SQLite;

namespace Notes.DataBase
{
    public class db
    {
        static SQLiteAsyncConnection database;

        public db()
        {

        }


        /// <summary>
        /// Create database and table if it does not exist
        /// </summary>
        /// <returns></returns>
        public static async Task InitialiseDataBase()
        {
            if (database != null)
                return;

            database = new SQLiteAsyncConnection(Config.DatabasePath, Config.Flags);
            var result = await database.CreateTableAsync<NoteTable>();
        }

        /// <summary>
        /// Adds new note to database
        /// </summary>
        /// <param name="n" note object></param>
        /// <returns></returns>
        public static async Task AddNote(NoteTable n)
        {          
            await InitialiseDataBase();

            var result = await database.InsertAsync(n);
        }

    }

}

