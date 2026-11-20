
using _1C30JT_HtetOoWaiYan_pbl01.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace _1C30JT_HtetOoWaiYan_pbl01
{
    public partial class MainWindow : Window
    {
        TransactionValidator validator = new TransactionValidator();
        TransactionManage transactionManage = new TransactionManage();

        public MainWindow()
        {
            InitializeComponent();

            forDisplay();
        }

        private void AddTransaction_Click(object sender, RoutedEventArgs e)
        {
            string result = validator.checkUserInput(tbx_amountInput.Text);

            if (result == "ok")
            {
                int userInputAmount = int.Parse(tbx_amountInput.Text);

                Transaction transaction = new Transaction();
                transaction.Amount = userInputAmount;

                Button clickedButton = (Button)sender;

                if (clickedButton.Name == "btn_income")
                {
                    transaction.Type = "In";
                }
                else
                {
                    transaction.Type = "Out";
                }

                if (dp_transactionDate.SelectedDate == null)
                {
                    transaction.TransactionDate = DateTime.Today;
                }
                else
                {
                    transaction.TransactionDate = dp_transactionDate.SelectedDate.Value;
                }

                transaction.Memo = tbx_memo.Text;

                transactionManage.addTransaction(transaction);

                forDisplay();

                tbx_amountInput.Clear();
                tbx_memo.Clear();
                dp_transactionDate.SelectedDate = null;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void forDisplay()
        {
            var balanceDetails = transactionManage.getBalanceDetails();

            tbl_balance.Text = balanceDetails.balance.ToString();
            tbl_income.Text = balanceDetails.totalIncome.ToString();
            tbl_expense.Text = balanceDetails.totalExpense.ToString();
        }

        private void btn_history_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;

            MainFrame.Visibility = Visibility.Visible;
            MainFrame.Navigate(new TransactionHistoryPage());
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility.Collapsed;

            HomePanel.Visibility = Visibility.Visible;
        }
    }
}
