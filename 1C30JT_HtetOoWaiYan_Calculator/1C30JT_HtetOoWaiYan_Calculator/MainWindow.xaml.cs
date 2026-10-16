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

namespace _1C30JT_HtetOoWaiYan_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBlock.Text = "0";
        }
        private void btnNum_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int number = int.Parse(btn.Content.ToString());
            if(txtBlock.Text == "0")
            {
                txtBlock.Text = number.ToString();
            }
            else
            {
                txtBlock.Text += number.ToString();
            }

        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if(txtBlock.Text.Length > 1)
            {
                txtBlock.Text = txtBlock.Text.Substring(0, txtBlock.Text.Length - 1);
            }
            else
            {
                txtBlock.Text = "0";
            }
        }

        private void btnOpr_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string opa = btn.Content.ToString();
            txtBlock.Text = txtBlock.Text + opa;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();
            string currentNumber = "";

            foreach (char c in txtBlock.Text)
            {
                if (char.IsDigit(c))
                {
                    currentNumber += c;
                }
                else
                {
                    if (currentNumber != "")
                    {
                        numbers.Add(double.Parse(currentNumber));
                        operators.Add(c);
                        currentNumber = "";
                    }
                }
            }
            if (currentNumber != "")
                numbers.Add(double.Parse(currentNumber));


            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '×')
                {
                    numbers[i] *= numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
                else if (operators[i] == '÷')
                {
                    numbers[i] /= numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);

                    i--;
                }
            }

            double result = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '+')
                    result += numbers[i + 1];
                else if (operators[i] == '-')
                    result -= numbers[i + 1];
            }

            txtBlock.Text = result.ToString();
        }
    }
}