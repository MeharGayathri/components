using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqllitespecific.Models
{
    [Table("OrderModel")]
    public class Order
    {
        [PrimaryKey, Column("OrderId")]
        public int OrderId { get; set; }

        [Column("OrderName"), NotNull]
        public string OrderName { get; set; }
        public List<OrderPurchaseModel> OrderPurchases { get; set; }


    }
}
