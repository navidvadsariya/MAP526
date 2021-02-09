using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashRegisterApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        List<History> localHistory;
        public HistoryPage(List<History> historyList)
        {
            InitializeComponent();
            localHistory = historyList;
            productHistoryList.ItemsSource = localHistory;
        }

        async void ProductHistorySelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailHistoryPage((History)e.SelectedItem));            
        }

        
    }
}