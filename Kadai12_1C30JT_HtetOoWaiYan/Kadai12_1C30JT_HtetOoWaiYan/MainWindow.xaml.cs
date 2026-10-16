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

namespace Kadai12_1C30JT_HtetOoWaiYan
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

        private void btnCale_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBlockState.Text = "お会計中";
                double totalMoney = double.Parse(tbxSum.Text);
                double receiveMoney = double.Parse(tbxPay.Text);
                if (totalMoney > receiveMoney)
                {
                    lblChange.Content = "エラー";
                    TextBlockState.Text = "支払金額は足りません。";
                }
                else
                {
                    lblChange.Content = $"{receiveMoney - totalMoney}円";
                    TextBlockState.Text = "ありがとうございます。";

                }
            }catch (FormatException)
            {
                TextBlockState.Text = "数字を入力してください。";
            }
            catch (OverflowException)
            {
                TextBlockState.Text = "数値が大きすぎます。";
            }catch (Exception)
            {
                TextBlockState.Text = "エラーが発生しました。";
            }


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxPay.Text = "";
            tbxSum.Text = "";
            TextBlockState.Text = "";
            lblChange.Content = "おつり : ";
        }
    }
}