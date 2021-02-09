using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegisterApplication
{
    public class History
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public double total_price { get; set; }
        public string purchase_date { get; set; }

        public History(string name, int quantity, double total_price, string purchase_date)
        {
            this.name = name;
            this.quantity = quantity;
            this.total_price = total_price;
            this.purchase_date = purchase_date;
        }
    }
}
