using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL1_14_Ticketing
{
    internal class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection
            ("Server=127.0.0.1;Port=5432;Database=postgres;" +
            "User id=postgres;Password=admin;");
    }
}
