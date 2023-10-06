using SQLite;

namespace Notes.DataBase
{
    /// <summary>
    /// Objects for note table
    /// </summary>
    [Table("Note")]
    public class NoteTable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string note { get; set; }
        public DateTime Date { get; set; }
    }
}
