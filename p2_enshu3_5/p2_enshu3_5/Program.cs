namespace p2_enshu3_5
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            List<(string ProductName, int Stock, int Price)> productList = new List<(string ProductName, int Stock, int Price)>
            {
                ("キーボード",50, 8000),
                ("マウス",120,2500),
                ("モニター", 8, 28000),
                ("ウェブカメラ",8,5000),
                ("ヘッドセット",60,12000)
            };

            var under30List = productList.Where(product => product.Stock <= 30).ToList();
            foreach ( var under30 in under30List )
            {
                Console.WriteLine($"{under30.ProductName} : 在庫数 {under30.Stock}　個");
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("商品名と　価格の　一覧");
            foreach (var product in productList)
            {
                Console.WriteLine($"{product.ProductName} ({product.Price}円)");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("価格が10000円ょり高く、かつ在庫数が１０個未満の商品　: ");
            var over10000and10 = productList.Where(product => (product.Price > 10000) && (product.Stock <= 10)).ToList();
            foreach (var product in over10000and10)
            {
                Console.WriteLine($"{product.ProductName} : 在庫数 {product.Stock}個, 価格　{product.Price}");
            }
        }
    }
}
