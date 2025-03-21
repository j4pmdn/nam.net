namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ds1 = new List<int>();

            ds1.Add(1);
            ds1.Add(2);
            ds1.AddRange(new int[] {3, 4, 5});

            Console.WriteLine(ds1.Count);
        }
    }
}
