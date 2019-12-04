using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqllitespecific.Models
{
    [Table("OrderPurchase")]
    public class OrderPurchaseModel
    {
        [PrimaryKey, Column("OrderPurchaseId"), AutoIncrement]
        public int OrderPurchaseId { get; set; }

        [Column("OrderId")]
        //[ForeignKey(typeof(Order))]
        public int OrderId { get; set; }

        [Column("Count"), NotNull]
        public int Count { get; set; }

    }
}
