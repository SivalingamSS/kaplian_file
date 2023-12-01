using System.Collections;
using System.Linq;

namespace LinqDemo
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                  new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                  new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                  new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                  new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                  new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            // Where 

            var student = from get in studentList
                          where get.Age > 14 && get.Age < 20
                          select get.StudentName;
            foreach (var getanswer in student)
            {
                Console.WriteLine(getanswer);
            }
            Console.WriteLine("-----------------------");

            // typeof

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);

            var list = from to in mixedList.OfType<int>()
                       select to;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            // OrderBy + ThenBy

            var thenByResult = studentList.OrderByDescending(s => s.StudentName).ThenByDescending(s => s.Age);
            foreach (var items in thenByResult)
            {
                Console.WriteLine(items.StudentName, items.Age);
            }
            Console.WriteLine("-----------------------");


            // GroupBy
            var result = from and in studentList
                         group and by and.StudentName;

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.Age);
                }
            }
            Console.WriteLine("-----------------------");
        }
    }
}