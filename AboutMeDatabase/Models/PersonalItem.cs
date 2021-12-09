using System;
using SQLite;

namespace AboutMeDatabase.Models
{
    public class PersonalItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
    }
}
