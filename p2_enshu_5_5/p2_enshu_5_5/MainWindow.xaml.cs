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

namespace p2_enshu_5_5
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
            if (id_RadioButton.IsChecked == true || name_RadioButton.IsChecked == true)
            {
                message_TextBlock.Text = "";
                result_ListBox.Items.Clear();
                string query = "";
                string keyword = "";
                if(id_RadioButton.IsChecked == true)
                {
                    query = @"SELECT id, username, age, sry FROM shain_tbl WHERE id LIKE '%' + @keyword + '%'";
                    keyword = id_TextBox.Text;
                }else if(name_RadioButton.IsChecked == true)
                {
                    query = @"SELECT id, username, age, sry FROM shain_tbl WHERE username LIKE '%' + @keyword + '%'";
                    keyword = name_TextBox.Text;
                }

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wwwht\source\repos\p2_enshu_5_5\p2_enshu_5_5\userDB.mdf;Integrated Security=True";
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = query;
                        command.Parameters.Add("@keyword", SqlDbType.NVarChar);
                        command.Parameters["@keyword"].Value = keyword;

                        try
                        {
                            conn.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    result_ListBox.Items.Add($"{reader.GetString(0)} {reader.GetString(1)} {reader.GetInt32(2)} {reader.GetInt32(3)}");
                                }

                            }
                            else
                            {
                                result_ListBox.Items.Add($"データがありません。");
                            }
                        }catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
            else
            {
                message_TextBlock.Text = "※検索する項目にチェックを入れてください。";
            }
        }
    }
}