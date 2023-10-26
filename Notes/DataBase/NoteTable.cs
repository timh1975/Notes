using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Notes.DataBase
{
    /// <summary>
    /// Objects for note table
    /// </summary>
    [SQLite.Table("Note")]
    public class NoteTable
    {
        [PrimaryKey, AutoIncrement]
        public int note_id { get; set; }
        public string note { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(typeof(Comments))]
        public int Comment_Id { get; set; }

        [OneToOne]
        public Comments Comments { get; set; }


    }
}
