namespace P2_Renshu7_2
{
    using Microsoft.Data.SqlClient;
    internal class Program
    {

        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wwwht\source\repos\P2_Renshu7_2\P2_Renshu7_2\Sales.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                string query = "SELECT Orders.order_id,Products.product_name,Products.product_price,Orders.quantity FROM Orders INNER JOIN Products ON Orders.Product_id = Products.product_id";
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
                                int orderId = reader.GetInt32(0);
                                string productName = reader.GetString(1);
                                int productPrice = reader.GetInt32(2);
                                int quantity = reader.GetInt32(3);

                                Console.WriteLine($" Order ID : {orderId}, Product : {productName}, Price : {productPrice}, Quantity : {quantity}");
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("エラーが発生しました。");

                    }
                }
            }
        }
    }
}
