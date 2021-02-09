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
    public partial class ManagerPanel : ContentPage
    {
        List<History> localHistory;
        public ManagerPanel(List<History> historyList)
        {
            InitializeComponent();
            localHistory = historyList;
        }

        async void HistoryButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage(localHistory));
        }

        async void RestockButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage(localHistory));
        }
    }
}