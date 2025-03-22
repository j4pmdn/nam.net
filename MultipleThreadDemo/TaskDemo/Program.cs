using System.Diagnostics;

namespace TaskDemo
{
    internal class Program
    {
        // nên viết hàm async hơn hàm bình thường
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var t1 = Delay1Async();
            var t2 = Delay2Async();
            var t3 = Delay3Async();
           // stopwatch.Stop();

            await t1;
            await t2;
            await t3;

            stopwatch.Stop();

            Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");
        }

        // Hàm async ko bao giờ trả về kiểu void
        // Hàm async thực sự là async khi nó thực hiện lời gọi await
        static async Task Delay1Async()
        {
            Console.WriteLine("Delay1...");
            await Task.Delay(1000);
            Console.WriteLine("Delay1 done...");
        }

        static async Task Delay2Async()
        {
            Console.WriteLine("Delay2...");
            await Task.Delay(2000);
            Console.WriteLine("Delay2 done...");
        }

        static async Task Delay3Async()
        {
            Console.WriteLine("Delay3...");
            await Task.Delay(3000); 
            Console.WriteLine("Delay3 done...");
        }
    }
}
