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

        private void NumClicked(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            if (!String.Equals(Type.Text, "Type"))
            {
                if ((Quantity.Text).Length > 24)
                {
                    Quantity.Text = "Please enter realistic quantity.";
                    CalculateTotal();
                }
                if (String.Equals(Quantity.Text, "Quantity"))
                {
                    Quantity.Text = num.ToString();
                    CalculateTotal();
                }
                else if ((Quantity.Text).All(char.IsDigit))
                {
                    Quantity.Text = Quantity.Text + num.ToString();
                    CalculateTotal();
                }
            }
            else
            {
                DisplayAlert("Alert", "Please select a product.", "OK");
            }
        }

        private void BuySelected(object sender, EventArgs e)
        {
            if(!String.Equals(Type.Text, "Type") && (Quantity.Text).All(char.IsDigit))
            {
                int quantity = int.Parse(Quantity.Text);
                if (product.quantity >= quantity)
                {
                    Boolean done = false;
                    CalculateTotal();
                    for(int i = 0; i < products.Count() && !done; i++)
                    {
                        if(String.Equals(products[i].name, product.name))
                        {
                            products[i].quantity -= quantity;
                            done = true;
                        }
                    }
                    if(done == true)
                    {
                        Quantity.Text = "Success!";
                        historyList.Add(new History(product.name, quantity, int.Parse(Total.Text),DateTime.Now.ToString()));
                    }
                }
                else
                {
                    DisplayAlert("Alert", "Quantity unavailable.", "OK");
                    ClearClicked();
                }
            }
            else
            {
                DisplayAlert("Alert", "Please select a product/quantity.", "OK");
            }
        }

        private void ClearClicked()
        {
            Quantity.Text = "Quantity";
            Total.Text = "Total";
            Type.Text = "Type";
        }

        private void ProductSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ClearClicked();
            product = (Product) e.SelectedItem;
            Type.Text = product.name;
        }
        private void CalculateTotal()
        {
            int total = product.quantity * int.Parse(Quantity.Text);
            Total.Text = total.ToString();
        }

        async void ManagerButtonClicker(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManagerPanel(historyList));
        }
    }
}
