using System;
using System.ComponentModel;

namespace CashRegisterApplication
{
    public class Product : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string name {
            get { return _name; }
            set
            {
                if(_name == value)
                {
                    return;
                }
                _name = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
                }
            }
         }
        private int _quantity;
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if(_quantity == value)
                {
                    return;
                }
                _quantity = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(quantity)));
                }
            }
        }
        private double _price;
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price == value)
                {
                    return;
                }
                _price = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(price)));
                }
            }
        }

        public Product(string name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

    }
}
