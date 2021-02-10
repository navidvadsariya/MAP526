using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashRegisterApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestockPage : ContentPage
    {
        Product product;
        ObservableCollection<Product> localProductList;
        int quantity;
        public RestockPage(ObservableCollection<Product> productList)
        {
            InitializeComponent();
            localProductList = productList;
            productRestockList.ItemsSource = localProductList;
        }

        private void ProductRestockSelected(object sender, SelectedItemChangedEventArgs e)
        { 
            product = (Product)e.SelectedItem;
        }

        private void RestockClicked(object sender, EventArgs e)
        {
            if(product != null  && updatedQuantity.Text != null && (updatedQuantity.Text).All(char.IsDigit) && updatedQuantity.Text.Length > 0)
            {
                Boolean done = false;

                quantity = int.Parse(updatedQuantity.Text);

                if (quantity >= 0)
                {
                    for (int i = 0; i < localProductList.Count() && !done; i++)
                    {
                        if (String.Equals(localProductList[i].name, product.name))
                        {
                            localProductList[i].quantity += quantity;
                            done = true;
                        }
                    }
                  
                }
                else
                {
                    DisplayAlert("Alert", "Please enter valid quantity.", "OK");
                }
            }
            else
            {
                DisplayAlert("Alert", "Please select a product and new quantity.", "OK");
            }
           
            updatedQuantity.Text = "";
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}