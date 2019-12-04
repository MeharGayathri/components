using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqllitespecific.Interfaces
{
    public interface Isqlite
    {
        SQLiteConnection sqlConnection();

    }
}
