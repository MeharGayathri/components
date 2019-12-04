using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace sqlite.Interfaces
{
    public interface Isqlite
    {
        SQLiteConnection sqlConnection();

    }
}
