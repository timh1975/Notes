using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DataBase
{
    [SQLite.Table("Comment")]
    public class Comments
    {
        [PrimaryKey, AutoIncrement]
        public int Comment_Id { get; set; }
        public string Comment { get; set; }
    }
}
