using System;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<Student> table = new HashTable<Student>(100);
            
            Student bob = new Student(99999999, "Bob", 3.2m);
            Student cindy = new Student(75000000, "Cindy", 1.2m);
            Student sharron = new Student(50000000, "Sharron", 2.5m);
            Student jim = new Student(25000, "Jim", 4.0m);
            Student steve = new Student(15000, "Steve", 3.8m);
            Student aaron = new Student(10000, "Aaron", 2.7m);
            Student carl = new Student(5000, "Carl", 1.7m);
            Student becky = new Student(1, "Becky", 3.9m);
            
            // Sanity check
            Student random = new Student((UInt32) (new Random()).Next(1, 9999999), "Random", 1.0m);

            Student[] students = {bob, cindy, sharron, jim, steve, aaron, carl, becky, random};

            foreach (Student student in students)
            {
                // if (student.Name.Equals("Random"))
                // {
                //     continue;
                // }
                
                table.Add(student);
            }

            foreach (Student student in students)
            {
                Console.WriteLine($"Finding {student.Name}");

                Student studentInHashTable = table.Find(student.GetHashCode());

                if (studentInHashTable != default)
                {
                    Console.Write($"Student with ID {studentInHashTable.GetHashCode()} found! ");
                    Console.Write($"Their Name is {studentInHashTable.Name} ");
                    Console.WriteLine($"and their GPA is {studentInHashTable.Gpa}");
                    
                    continue;
                }
                
                Console.WriteLine($"{student.Name} not found.");
            }
        }
    }
}
