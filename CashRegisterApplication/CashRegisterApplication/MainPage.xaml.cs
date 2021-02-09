using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//< Label Text = "Cash Register App" FontSize = "Medium" HorizontalTextAlignment = "Center" FontAttributes = "Bold" />
namespace CashRegisterApplication
{
    public partial class MainPage : ContentPage
    {
        Product product;
        ObservableCollection<Product> products;
        List<History> historyList = new List<History>();
        public MainPage()
        {
            InitializeComponent();

             products = new ObservableCollection<Product>
            {
                new Product("Pants", 20),
                new Product("Shoes", 50),
                new Product("Hats", 10),
                new Product("Tshirts", 10),
                new Product("Dresses", 24)
            };
            productList.ItemsSource = products;
        }

      
    }
}
