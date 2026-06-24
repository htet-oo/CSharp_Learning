using System;
using System.Windows;
using System.Windows.Controls;

namespace Renshu_Star
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(txtBox.Text, out int value))
            {
                txtBlock.Text = new string('☆', value);
            }
            else
            {
                txtBlock.Text = "数字を代入してください。";

            }
        }
    }
}