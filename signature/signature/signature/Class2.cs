using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace signature
{
    public class Class2
    {

        readonly SQLiteConnection database;
        public Class2(string data)
        {
            database = new SQLiteConnection(data);
            database.CreateTable<Class1>();
        }
        public List<Class1> GetStreams()
        {
            return database.Table<Class1>().ToList();
        }
        public int SaveStream(Class1 obj)
        {
            return database.Insert(obj);
        }
    }
}
