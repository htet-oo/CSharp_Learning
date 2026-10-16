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

namespace ExamNo._1
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
                double height = double.Parse(tbxHeight.Text);
                double weight = double.Parse(tbxWeight.Text);
                double resultForBmi = weight / ((height/100)*(height/100));
                lblBmi.Content = Math.Round(resultForBmi,2);

                double resultForStdWeight = ((height/100) * (height/100) * 22);
                lblStdWeight.Content = Math.Round(resultForStdWeight);

                if (weight >= resultForStdWeight)
                {
                    lblDiffWeight.Content = '+';
                }
                else
                {
                    lblDiffWeight.Content = '-';
                }

                string resultForLblJudge;
                if(resultForBmi >= 40)
                {
                    resultForLblJudge = "あなたの体重は肥満度が高いです。";
                }else if (resultForBmi < 40 && resultForBmi >= 35)
                {
                    resultForLblJudge = "あなたの体重は肥満です。";
                }else if (resultForBmi < 35 && resultForBmi >= 30)
                {
                    resultForLblJudge = "あなたの体重は少し肥満です。";
                }else if (resultForBmi < 30 && resultForBmi >= 25)
                {
                    resultForLblJudge = "あなたの体重は肥満傾向です。";
                }
                else if (resultForBmi < 25 && resultForBmi >= 18.5)
                {
                    resultForLblJudge = "あなたの体重は適正です。";
                }
                else if (resultForBmi < 18.5)
                {
                    resultForLblJudge = "あなた低体重です。";
                }
                else
                {
                    resultForLblJudge = "";
                }

                    lblJudge.Content = resultForLblJudge;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Only Number");
            }
        }
    }
}