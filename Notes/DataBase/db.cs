using SQLite;

namespace Notes.DataBase
{
    public class Db
    {
        static SQLiteAsyncConnection database;

        public Db()
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
            var resutl = await database.CreateTableAsync<Comments>();
        }

        /// <summary>
        /// Adds new note to database
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static async Task AddNote(NoteTable n)
        {          
            await InitialiseDataBase();

            var result = await database.InsertAsync(n);
        }

        public static async Task<int> AddComment(Comments n)
        {
            await InitialiseDataBase();
            var result = database.InsertAsync(n);
            int fk = await database.ExecuteScalarAsync<int>("Select Comment_Id FROM Comment order by Comment_Id DESC limit 1");

            //await Application.Current.MainPage.DisplayAlert("Primary Key ID", fk.ToString(),"Cancel");
            return fk;
            

        }

      
       
    }

}

