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
    public partial class DetailHistoryPage : ContentPage
    {
        public DetailHistoryPage(History history)
        {
            InitializeComponent();
            Title.Text = history.name;
            Name.Text = history.name;
            Quantity.Text = history.quantity.ToString();
            DateAndTime.Text = history.purchase_date;
            TotalAmount.Text = history.total_price.ToString();
        }
    }
}