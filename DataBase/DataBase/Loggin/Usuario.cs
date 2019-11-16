using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DataBase.loggin
{
    class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string usuario { get; set; }
        public string Contra { get; set; }
        public override string ToString()
        {
            return $"{Nombre} - {usuario} - {Contra}";
        }
    }
}
