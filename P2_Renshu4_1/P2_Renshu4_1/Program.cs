
namespace P2_Renshu4_1DBpractice
{
    using Microsoft.Data.SqlClient;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wwwht\source\repos\P2_Renshu4_1\P2_Renshu4_1\Database1.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                string query = "SELECT id,name,value FROM m_shouhin;";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                int value = reader.GetInt32(2);
                                Console.WriteLine($"Id:{id}, name:{name}, value:{value}");
                            }
                            // パラメータを使った場合の処理
                            //if (reader.HasRo
                            //ws)
                            //{
                            //    reader.Read();
                            //    string name = reader.GetString(1);
                            //    Console.WriteLine($"商品は{name}ですね！");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("商品が見つかりませんでした。");
                            //}

                            // 実行結果の後処理
                            //reader.Close();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("エラーが発生しました。");
                    }

                    // データベースへの接続解除
                    //conn.Close();
                }
            }
        }
    }
}