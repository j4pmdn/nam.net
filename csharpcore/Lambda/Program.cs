namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // out -> kiểu dữ liệu của kết quả trả về

            /*
                Expression lambda có kiểu Func
                Statement lambda có kiểu Action
            */
            Func<int, int, int> sum = (int a, int b) => a + b;

            Console.WriteLine(sum(3, 5));

            Action<string> printUpper = s => Console.WriteLine(s.ToUpper());

            printUpper("abc");
        }
    }
}
