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
    public partial class ManagerPanel : ContentPage
    {
        List<History> localHistory;
        ObservableCollection<Product> localProductList;
        public ManagerPanel(List<History> historyList, ObservableCollection<Product> productList)
        {
            InitializeComponent();
            localHistory = historyList;
            localProductList = productList;
        }

        async void HistoryButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage(localHistory));
        }

        async void RestockButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RestockPage(localProductList));
        }
    }
}