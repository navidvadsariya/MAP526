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
        ObservableCollection<Product> localProductList;
        public RestockPage(ObservableCollection<Product> productList)
        {
            InitializeComponent();
            localProductList = productList;
            productRestockList.ItemsSource = localProductList;
        }

        private void ProductRestockSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void RestockClicked(object sender, EventArgs e)
        {

        }

        private void CancelClicked(object sender, EventArgs e)
        {

        }
    }
}