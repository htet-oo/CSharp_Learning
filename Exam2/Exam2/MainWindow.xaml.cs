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

namespace Exam2
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                int starYear = int.Parse(tbxStartyear.Text);
                int endYear = int.Parse(tbxEndYear.Text);
                int numberOfLeapYear = 0;
                int dayCount = 0;
                int oddYearCount = 0;
                int evenYearCount = 0;
                for (int i = starYear; i <= endYear; i++)
                {
                    bool isLeapYear = DateTime.IsLeapYear(i);
                    if(isLeapYear)
                    {
                        numberOfLeapYear += 1;
                    }
                    if (i % 2 == 0)
                    {
                        evenYearCount += 1;
                    }
                    else
                    {
                        oddYearCount += 1;
                    }
                    dayCount += 365;
                }
                dayCount += numberOfLeapYear;

                lblYearCnt.Text = $"{numberOfLeapYear}";
                lblDayCnt.Text = $"{dayCount}";
                lblEventCnt.Text = $"{evenYearCount}";
                lblOddCnt.Text = $"{oddYearCount}";
                ;

            }
            catch(FormatException)
            {
                MessageBox.Show("Please only enter number only");
            }
        }
    }
}