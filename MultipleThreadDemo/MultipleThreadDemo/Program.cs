namespace MultipleThreadDemo
{
    internal class Program
    {

        // Làm sao cho các thread kết thúc 1 cách bình thường, có kiểm soát
        // ko ép ngắt giữa chừng

        // static bool b = false;

        // Thread chính của chương trình
        static void Main(string[] args)
        {

            CancellationTokenSource cts = new CancellationTokenSource();

            var t1 = new Thread(new ParameterizedThreadStart(Print));
            var t2 = new Thread(new ParameterizedThreadStart(Print));
            var t3 = new Thread(new ParameterizedThreadStart(Print));
            // var t4 = new Thread(new ParameterizedThreadStart(Print));

            // background thread giống frontground
            // cơ chế khác nhau
            // chương trình sẽ dừng chạy khi ko còn frontground nếu còn thì chương trình vẫn còn chạy
            // ko nên dùng
            // t1.IsBackground = true;
            // t2.IsBackground = true;

            // khi start mới thực sự được khởi tạo
            t1.Start(new HelloPram() { Name = "1", CancellationToken = cts.Token });
            t2.Start(new HelloPram() { Name = "2", Delay = 2000, CancellationToken = cts.Token });
            t3.Start(new HelloPram() { Name = "3", Delay = 3000, CancellationToken = cts.Token });
            // t4.Start("T4");

            //Console.ReadLine();

            cts.CancelAfter(10000);

            // b = true;
        }

        public static void Print(object? p)
        {
            // p as HelloPram -> ép kiểu ko tương thích -> null . (HelloPram) p ép kiểu thông thường -> exception
            
            var hParam = p as HelloPram;

            //while (!b)
            if (hParam != null)
            {
                while (!hParam.CancellationToken.IsCancellationRequested)
                {

                    // hParam?.Name -> nếu hParam null -> null
                    //              ->  nếu hParam ! null -> giá trị name
                    // Console.WriteLine($"Hello {hParam?.Name ?? "NAME"}!");
                    
                    Console.WriteLine($"Hello {hParam.Name}");
                   
                    Thread.Sleep(hParam.Delay);
                    
                    //Thread.Sleep(hParam?.Delay ?? 1000);
                }
            }   
        }
    }
}
