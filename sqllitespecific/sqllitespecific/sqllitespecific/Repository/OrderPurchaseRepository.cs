using sqllitespecific.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sqllitespecific.Repository
{
    public static class OrderPurchaseRepository
    {
        public static Task<List<OrderPurchaseModel>> GetAll()
        {
            List<OrderPurchaseModel> data = null;
            using (var connection = sqlExtension.GetConnection())
            {
                data = connection.Table<OrderPurchaseModel>().ToList();
            }

            return Task.FromResult(data);
        }

        public static Task<bool> Add(OrderPurchaseModel order)
        {
            using (var connection = sqlExtension.GetConnection())
            {
                connection.Insert(order);
            }
            return Task.FromResult(true);
        }

        public static Task<bool> Edit(OrderPurchaseModel model)
        {
            using (var connection = sqlExtension.GetConnection())
            {
                string sqlQuery = "Update OrderPurchase set OrderId = ?, Count = ? where OrderPurchaseId = ?";
                var ret = connection.Execute(sqlQuery, model.OrderId, model.Count, model.OrderPurchaseId);
            }
            return Task.FromResult(true);
        }

        public static Task<bool> Delete(int orderPurchaseId)
        {
            using (var connection = sqlExtension.GetConnection())
            {
                var data = connection.Get<OrderPurchaseModel>(orderPurchaseId);
                connection.Delete(data);
            }
            return Task.FromResult(true);
        }
    }
}
