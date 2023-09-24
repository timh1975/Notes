using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Notes.DataBase
{
    [Table("Note")]
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string note { get; set; }
        public DateTime Date { get; set; }
    }
}
