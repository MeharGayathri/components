using sqllitespecific.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace sqllitespecific.Views
{
    public class OrderCell : TextCell
    {
        public OrderCell()
        {
           // this.SetBinding(TextProperty, nameof(OrderPurchaseModel.OrderName));
            this.SetBinding(TextCell.DetailProperty, nameof(OrderPurchaseModel.Count), stringFormat: "Count: {0}");
        }
    }
}
