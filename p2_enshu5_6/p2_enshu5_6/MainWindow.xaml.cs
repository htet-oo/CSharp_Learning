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

namespace p2_enshu5_6
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
            if(txtBox_num.Text != "")
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wwwht\source\repos\p2_enshu5_6\p2_enshu5_6\Database.mdf;Integrated Security=True";
                    string query = "SELECT * FROM Item WHERE Id = @id";
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = query;
                        command.Parameters.Add("@Id",SqlDbType.Int);
                        command.Parameters["@Id"].Value = int.Parse(txtBox_num.Text);
                        try
                        {
                            conn.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtBox_name.Text = reader.GetString(1);
                                txtBox_purchase.Text = reader.GetInt32(2).ToString();
                                txtBox_sell.Text = reader.GetInt32(3).ToString();
                            }
                        }catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBox_name.Text = string.Empty;
            txtBox_num.Text = string.Empty;
            txtBox_purchase.Text = string.Empty;
            txtBox_sell.Text= string.Empty;
        }
    }
}