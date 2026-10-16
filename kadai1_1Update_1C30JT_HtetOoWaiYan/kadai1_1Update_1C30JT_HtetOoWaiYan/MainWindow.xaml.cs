using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kadai1_1Update_1C30JT_HtetOoWaiYan
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Book book = new Book();

        private void txtBookNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblBookName.Content = book.GetBookName(int.TryParse(txtBookNumber.Text,out int bookNumInt)? bookNumInt : 0);
            lblPrice.Content = book.GetBookPrice(int.TryParse(txtBookNumber.Text, out  bookNumInt)? bookNumInt : 0);
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int price = int.TryParse(lblPrice.Content.ToString(), out int priceInt)? priceInt : 0;
            int quentity = int.TryParse(txtQuantity.Text, out int quentityInt)? quentityInt : 0;
            book.CalcSum(price, quentity);
            lblSum.Content = book.GetSum().ToString();

        }
    }
}