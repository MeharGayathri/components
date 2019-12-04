using SQLite;
using sqllitespecific.Interfaces;
using sqllitespecific.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace sqllitespecific.Repository
{
   public class sqlExtension
    {
        public static SQLiteConnection GetConnection()
        {
            var connection = DependencyService.Get<Isqlite>().sqlConnection();
            connection.CreateTable<Order>();
            connection.CreateTable<OrderPurchaseModel>();
            return connection;
        }
    }
}
