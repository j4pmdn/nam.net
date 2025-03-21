namespace linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = GetStudents();
            Print(students.OrderByDescending(s => s.YoB).OrderBy(s => s.Name));
        }

        static void Print(IEnumerable<Student> sudents)
        {
            foreach (var student in sudents)
            {
                Print(student);
            }
        }

        private static void Print(Student student)
        {
            Console.WriteLine($"Name: {student.Name}, City: {student.City}, YoB: {student.YoB}");
        }

        static IEnumerable<Student> GetStudents()
        {
            return new Student[] 
            { 
                new Student()
                {
                    Name = "Test 2010",
                    City = "HCMC",
                    YoB = 2010
                },
                new Student()
                {
                    Name = "Test 2012",
                    City = "HCMC",
                    YoB = 2012
                },
                new Student()
                {
                    Name = "Test 2011",
                    City = "HCMC",
                    YoB = 2011
                }
            };
        }
    }
}
