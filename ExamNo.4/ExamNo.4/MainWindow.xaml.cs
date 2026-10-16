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

namespace ExamNo._4
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

        private void btnCal_Click(object sender, RoutedEventArgs e)
        {
            int totalMoney = int.Parse(tbxBuy.Text);
            int receiveMoney = int.Parse(tbxPay.Text);
            int calMoney = 0;
            int[] array = new int[9];

            if(receiveMoney < totalMoney)
            {
                MessageBox.Show("Money Not Enough");
            }
            else
            {
                calMoney = totalMoney - receiveMoney;
            }

            int moneyCount;
            calMoney = receiveMoney - totalMoney;

            array[0] = calMoney / 10000;
            calMoney %= 10000;

            array[1] = calMoney / 5000;
            calMoney %= 5000;

            array[2] = calMoney / 1000;
            calMoney %= 1000;

            array[3] = calMoney / 500;
            calMoney %= 500;

            array[4] = calMoney / 100;
            calMoney %= 100;

            array[5] = calMoney / 50;
            calMoney %= 50;

            array[6] = calMoney / 10;
            calMoney %= 10;

            array[7] = calMoney / 5;
            calMoney %= 5;

            array[8] = calMoney;

            lblTenThous.Content = $"{array[0]}枚";
            lblFiveThous.Content = $"{array[1]}枚";
            lblOneThous.Content = $"{array[2]}枚";
            lblFiveHund.Content = $"{array[3]}枚";
            lblOneHund.Content = $"{array[4]}枚";
            lblFifty.Content = $"{array[5]}枚";
            lblTen.Content = $"{array[6]}枚";
            lblFive.Content = $"{array[7]}枚";
            lblOne.Content = $"{array[8]}枚";



        }
    }
}