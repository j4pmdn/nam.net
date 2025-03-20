namespace HelloWorld
{

    internal class Program
    {
        /*
          
            bool =  System.Boolean 2 cái là 1

            value types
            
            reference types  

            object là cha của tất cả KDL

            string ->  reference types 
            $ inter collation  -> dùng string builder tối ưu hiệu năng hơn

            + chuỗi -> tạo biến đối tượng mới


            dynamic -> ko phải là 1 kiểu cụ thể
              tương tự var

            var dựa trên giá trị gán vào -> kiểu dữ liệu


            nullable
            int x? -> có thể mang giá trị null

            x.HasVue -> true  -> x có giá trị
                     -> false -> x null
        */  

        static void Main(string[] args)
        {
            int? x = 0;

            if (x != null)
            {

            }

            Console.WriteLine(x.HasValue.ToString());

            // Hằng số khác Java 
            // Hằng số vẫn là object trong .net
        
            Console.WriteLine("abcdefgh".ToUpper());  
        }

    }
}
