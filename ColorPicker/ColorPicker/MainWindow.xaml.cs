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

namespace ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //メンバ変数（クラス内で使用できる変数，外からは気軽に変更できないように基本private）
        private int red = 0;
        private int green = 0;
        private int blue = 0;

        //コンストラクタ（クラス生成時に実行される特別なメソッド）
        //今回はウィンドウ作成時に実行されます
        public MainWindow()
        {
            InitializeComponent();
            rctResult.Fill = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));
        }

        //メソッド群
        private void sldRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            red = (int) sldRed.Value;
            rctResult.Fill = new SolidColorBrush( Color.FromRgb((byte)red, (byte)green, (byte)blue));
        }

        private void sldGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            green = (int)sldGreen.Value;
            rctResult.Fill = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));
        }

        private void sldBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            blue = (int)sldBlue.Value;
            rctResult.Fill = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));
        }
    }
}