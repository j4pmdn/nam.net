namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             arrays là 1 tập hợp có cùng kiểu dữ liệu -> reference types
             có 2 cách khởi tạo 
               -> new
               -> gán trực tiếp
             */

            // mang1Chieu();
            // mang2Chieu();

            jaggedArray();
        }

        // thực chất là mảng 1 chiều -> mỗi phần tử là 1 chiều
        static void jaggedArray()
        {
            int[][] mn = new int[4][];

            mn[0] = new int[4];

            mn[0] [0] = 1;
        }

        // số dòng = số cột
        static void mang2Chieu()
        {
            int[,] mang2 = {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}
            };

            Console.WriteLine(mang2[1 ,7]);
        }

        static void mang1Chieu()
        {
            // int[] mang1 = new int[5] { 2, 4, 6, 8, 10 }
            int[] mang1 = [2, 4, 6, 8, 10];

            Console.WriteLine($"{mang1.Length}");

            for (int i = 0; i < mang1.Length; i++)
            {
                Console.WriteLine(mang1[i]);
            }
        }
    }
}
