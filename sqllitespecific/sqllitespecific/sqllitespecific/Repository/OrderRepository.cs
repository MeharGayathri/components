using sqllitespecific.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sqllitespecific.Repository
{
    public static class OrderRepository
    {
        public static Task<List<Order>> GetAll()
        {
            List<Order> data = null;
            using (var _connection = sqlExtension.GetConnection())
            {
                data = _connection.Table<Order>()
                           .ToList();
            }

            return Task.FromResult(data);
        }

        public static Task<bool> Add(Order order)
        {
            using (var _connection = sqlExtension.GetConnection())
            {
                _connection.Insert(order);
            }
            return Task.FromResult(true);
        }
    }
}
