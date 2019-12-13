using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App123.Models
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]

        public int Id {get; set; }

    public string Name { get; set; }
        public string Surname { get; set; }
        public int Identity { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public string Password { get; set; }
        

    }
}
