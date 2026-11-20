using Microsoft.Data.SqlClient;
using System.Data;
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

namespace p2_enshu5_7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wwwht\source\repos\p2_enshu5_7\p2_enshu5_7\Database.mdf;Integrated Security=True";
                string query = "INSERT INTO Item (Name, BuyingPrice, SellingPrice) VALUES (@name, @buyingprice, @sellingprice)";
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = query;
                    
                    command.Parameters.Add("@name",SqlDbType.NVarChar);
                    command.Parameters["@name"].Value = txtBox_name.Text;

                    command.Parameters.Add("@buyingprice", SqlDbType.Int);
                    command.Parameters["@buyingprice"].Value = int.Parse(txtBox_purchase.Text);

                    command.Parameters.Add("@sellingprice", SqlDbType.Int);
                    command.Parameters["@sellingprice"].Value = int.Parse(txtBox_sell.Text);

                    try
                    {
                        conn.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBoxResult answer = MessageBox.Show(
                                $"{txtBox_name.Text}:{txtBox_purchase.Text} / {txtBox_sell.Text}",
                                "入力された値",
                                MessageBoxButton.OKCancel,
                                MessageBoxImage.Information
                            );

                            if (answer == MessageBoxResult.OK)
                            {
                                MessageBox.Show("書き込み成功！", "実行結果");
                            }
                        }
                        else
                        {

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBox_name.Text = string.Empty;
            txtBox_purchase.Text = string.Empty;
            txtBox_sell.Text = string.Empty;
        }
    }
}