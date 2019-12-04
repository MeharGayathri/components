using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dbimages
{
    public class Class1
    {
        readonly SQLiteConnection database;
        public Class1(string data)
        {
            database = new SQLiteConnection(data);
            database.CreateTable<Class2>();
        }
        public List<Class2> getClass2List()
        {
            return database.Table<Class2>().ToList();
        }
        public int saveClass2(Class2 obj)
        {
            return database.Insert(obj);
        }
        public List<Class2> GetContentRecords(string con)
        {
            return database.Table<Class2>().Where(i => i.content==con).ToList();
        }
    }
}
