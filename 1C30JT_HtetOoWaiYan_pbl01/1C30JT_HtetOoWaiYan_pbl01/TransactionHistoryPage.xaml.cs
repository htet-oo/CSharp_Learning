using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1C30JT_HtetOoWaiYan_pbl01
{

    public partial class TransactionHistoryPage : Page
    {
        TransactionManage transactionManage = new TransactionManage();
        public TransactionHistoryPage()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            DateTime? fromDate = dp_fromDate.SelectedDate;

            DateTime? toDate = dp_toDate.SelectedDate;

            string type = ((ComboBoxItem)cbx_typeFilter.SelectedItem).Content.ToString();

            decimal? minAmount = null;

            if (!string.IsNullOrWhiteSpace(tbx_minAmount.Text))
            {
                minAmount = decimal.Parse(tbx_minAmount.Text);
            }

            var transactionList = transactionManage.findWithFilter(
                fromDate,
                toDate,
                type,
                minAmount
            );

            dg_transactionHistory.ItemsSource = transactionList;
        }
    }
}
