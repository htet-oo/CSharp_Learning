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

namespace p2_enshu_5_3_Htet_Oo_Wai_Yan
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
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wwwht\source\repos\p2_enshu_5_3_Htet_Oo_Wai_Yan\p2_enshu_5_3_Htet_Oo_Wai_Yan\userDB.mdf;Integrated Security=True";
                string query = "SELECT * FROM tbl01 WHERE id = @id";
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = query;
                    command.Parameters.Add("@id", SqlDbType.NVarChar);
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
                                ret_TextBlock_Name.Text = $"お名前は「{reader.GetString(2)}」様です。";
                                ret_TextBlock_Tel.Text = $"電話番号は「{reader.GetString(3)}」です。";
                            }
                            else
                            {
                                ret_TextBlock_Name.Text = "パスワードが違います。";
                            }
                        }
                        else
                        {
                            ret_TextBlock_Name.Text = "入力されたidがありません。";
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