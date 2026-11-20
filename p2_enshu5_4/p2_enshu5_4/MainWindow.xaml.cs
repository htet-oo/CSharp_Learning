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

namespace p2_enshu5_4
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
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wwwht\source\repos\p2_enshu5_4\p2_enshu5_4\userDB.mdf;Integrated Security=True";
                string query = "SELECT * FROM tbl01 WHERE id = @id";
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = query;
                    command.Parameters.Add("@id",SqlDbType.NVarChar);
                    command.Parameters["@id"].Value = id_textBox.Text;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (pas_TextBox.Password == reader.GetString(1))
                            {
                                ret_TextBlock1.Text = $"お名前は「{reader.GetString(2)}」様です。";
                                ret_TextBlock2.Text = $"電話番号は 「{reader.GetString(3)}」になります。";
                              
                            }
                            else
                            {
                                ret_TextBlock3.Text = "パスワードが違います。";
                                ret_TextBlock1.Text = "";
                                ret_TextBlock2.Text = "";
                            }
                        }
                        else
                        {
                            ret_TextBlock3.Text = "入力されたidがありません。";
                            ret_TextBlock1.Text = "";
                            ret_TextBlock2.Text = "";

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
    }
}