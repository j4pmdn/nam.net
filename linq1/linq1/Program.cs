namespace linq1
{
    internal class Program
    {

        // LINQ cho phép viết trực tiếp các câu truy vấn ngay trong mã nguồn chương trình.
        // Ưu điểm của LINQ là cho phép viết lệnh truy vấn ngắn gọn, dễ dàng,
        // sử dụng cùng một cú pháp cho tất cả các dạng nguồn dữ liệu khác nhau,
        // có thể phát hiện lỗi ngay khi biên dịch hoặc lỗi khi cấu trúc nguồn dữ liệu thay đổi.

        static void Main(string[] args)
        {
            var datasource = GetIntNumber();
            Print(datasource);


            // query syntax
            //var ns = from n in datasource
            //         where n >= 0
            //         select n;

            // method syntax
            var ns = datasource.Where(n =>  n > 0);

            Print(ns);
            Console.WriteLine("----------------");
            Console.WriteLine(ns.Count());
        }
        
        static IEnumerable<int> GetIntNumber()
        {
            var ns = new[] { 0, 1, 2, 3, 29, 123, 345, 234, -1231, -3423 };
            return ns;
        }

        static void Print(IEnumerable<int> values)
        {
            Console.WriteLine("----------------");
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
