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

namespace Renshu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int bookNumber = int.TryParse(tbxBookNo.Text, out int bookNumberInt) ? bookNumberInt : 0;
                int bookCount = int.TryParse(tbxBookCount.Text, out int bookCountInt) ? bookCountInt : 0;

                Book book = new Book();
                string bookName = book.GetBookName(bookNumber);
                int bookPrice = book.GetBookPrice(bookNumber);
                int totalPrice = book.GetSum(bookPrice, bookCount);

                lblBookName.Text = bookName;
                lblBookPrice.Text = bookPrice.ToString();
                lblSum.Text = totalPrice.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show("エーラーが発生しました。");
            }
        }
    }
}