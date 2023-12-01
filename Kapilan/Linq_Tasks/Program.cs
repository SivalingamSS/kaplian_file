using Linq_Tasks.Class;
using Newtonsoft.Json;

namespace Linq_Tasks
{
    class program
    {
        public void Find_Same()
        {
            var file1 = File.ReadAllText(@"C:\Kapilan\Linq_Tasks\Json_Files\Json1.json");
            var file2 = File.ReadAllText(@"C:\Kapilan\Linq_Tasks\Json_Files\Json3.json");
            StudentDt[] array = JsonConvert.DeserializeObject<StudentDt[]>(file1);
            StudentDt[] array1 = JsonConvert.DeserializeObject<StudentDt[]>(file2);
            var result = array.Intersect(array1, new StudentComparer());
            foreach (var str in result)
            {
                Console.WriteLine("{0}.{1} {2} {3}", str.Id, str.StudentName, str.Age, str.Department);
            }

            Console.WriteLine("------------------------------------------");
        }
        public void Find_Diff()
        {
            var file1 = File.ReadAllText(@"C:\Kapilan\Linq_Tasks\Json_Files\Json1.json");
            var file2 = File.ReadAllText(@"C:\Kapilan\Linq_Tasks\Json_Files\Json3.json");
            StudentDt[] array = JsonConvert.DeserializeObject<StudentDt[]>(file1);
            StudentDt[] array1 = JsonConvert.DeserializeObject<StudentDt[]>(file2);
            var result = array.Union(array);
            foreach (var str in result)
            {
                Console.WriteLine("{0}.{1} {2} {3}", str.Id, str.StudentName, str.Age, str.Department);
            }

            Console.WriteLine("------------------------------------------");
        }

        public void Inner_Join()
        {
            List<Student> studentList1 = new List<Student>()
            {
                  new Student() { StudentID = 1 ,StudentName = "Raju"},
                  new Student() { StudentID = 2 ,StudentName = "Viswha"}
            };
            List<Student> studentList2 = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName = "Sridhar"},
                new Student(){StudentID = 2,StudentName = "Naveen"}

            };
            var res = from s1 in studentList1
                      join s2 in studentList2
                      on s1.StudentID equals s2.StudentID
                      select new
                      {
                          s1.StudentID,
                          s2.StudentName
                      };

            foreach (var data in res)
            {
                Console.WriteLine("{0}.{1}", data.StudentID, data.StudentName);
            }
            Console.WriteLine("------------------------------------------");
        }
        public void Left_Join()
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", AddressId = 1},
                new Employee { ID = 2, Name = "Priyanka", AddressId =2}
            };
            List<Employee1> employee1 = new List<Employee1>()
            {
                new Employee1 { ID = 1, AddressLine = "AddressLine1"},
                new Employee1 { ID = 2, AddressLine = "AddressLine2"}
            };
            var emloyees = from emp in employee
                           join emp1 in employee1
                           on emp.ID equals emp1.ID
                           into data_A
                           from data_B in data_A.DefaultIfEmpty(new Employee1())
                           select new
                           {
                               emp.ID,
                               emp.Name,
                               data_B.AddressLine
                           };
            foreach (var get in emloyees)
            {
                Console.WriteLine("{0} {1} {2}", get.ID, get.Name, get.AddressLine);
            }
            Console.WriteLine("------------------------------------------");
        }
        public void Call_Function()
        {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
                var doubledNumbers = numbers.Select(MultiplyByTwo);
                foreach (var num in doubledNumbers)
                {
                    Console.WriteLine(num);
                }
            Console.WriteLine("------------------------------------------");
        }
        int MultiplyByTwo(int number)
        {
            return number * 2;
        }
        public void LINQ_Max_Min_Count()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            var High = intList.Max();
            var Low = intList.Min();
            var Sum = intList.Sum();
            Console.WriteLine(High);
            Console.WriteLine(Low);
            Console.WriteLine(Sum);
            Console.WriteLine("------------------------------------------");
        }
        public void Merge_File()
        {
            var file1 = File.ReadAllText(@"C:\Kapilan\Linq_Tasks\Json_Files\Json1.json");
            var file2 = File.ReadAllText(@"C:\Kapilan\Linq_Tasks\Json_Files\Json3.json");
            StudentDt[] array = JsonConvert.DeserializeObject<StudentDt[]>(file1);
            StudentDt[] array1 = JsonConvert.DeserializeObject<StudentDt[]>(file2);
            var result = array.Concat(array1);
            foreach (var str in result)
            {
                Console.WriteLine("{0} {1} {2} {3}", str.Id, str.StudentName, str.Age, str.Department);
            }

            Console.WriteLine("------------------------------------------");
        }
        public void Group_by()
        {
            IList<Student> studentList = new List<Student>()
            {
              new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
              new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 }
            };
            var groupedResult = from s in studentList
                                group s by s.Age;
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);
                foreach (Student s in ageGroup)
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Console.WriteLine("------------------------------------------");
        }
        public void Get_Month_Date()
        {
            int count30 = 0;
            int count31 = 0;
            int targetYear = 2023;
            var allMonths = Enumerable.Range(1, 12);
            var monthsWith31Days = allMonths.Where(month => DateTime.DaysInMonth(targetYear, month) == 31);
            var monthsWith30Days = allMonths.Where(month => DateTime.DaysInMonth(targetYear, month) == 30);
            foreach (var month in monthsWith31Days)
            {
                count30++;
            }
            foreach (var month in monthsWith30Days)
            {
                count31++;
            }
            Console.WriteLine($"Months with 30 days in {targetYear}: {count30}");
            Console.WriteLine($"Months with 31 days in {targetYear}: {count31}");
            Console.WriteLine("------------------------------------------");
        }
        public void Get_Month_Day()
        {
            var dates = GetWeekendDates(new DateTime(2022, 1, 1), new DateTime(2022, 12, 31));
        }
        List<string> GetWeekendDates(DateTime startDate, DateTime endDate)
        {
            int CountSaturday = 0;
            int CountSunday = 0;
            List<string> weekendList = new List<string>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    CountSaturday++;
                    Console.WriteLine(date.ToString("yyyy-MM-dd"));
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    CountSunday++;
                    Console.WriteLine(date.ToString("yyyy-MM-dd"));
                }
            }
            Console.WriteLine($"Count of the Saturday is {CountSaturday}");
            Console.WriteLine($"Count of the Saturday is {CountSunday}");
            Console.WriteLine("------------------------------------------");
            return weekendList;

        }
        public void Specific_String()
        {
            List<string> list = new List<string>();
            IList<Student> studentList = new List<Student>()
            {
                     new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                     new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                     new Student() { StudentID = 3, StudentName = "Mathew",  Age = 23 },
                     new Student() { StudentID = 4, StudentName = "Stew",  Age = 25 },
            };
            List<Student> student2 = new List<Student>();
            var result = from s in studentList
                         select s.StudentName;
            foreach (var student in result)
            {
                list.Add(student.ToString());
                Console.WriteLine(student);
            }
            Console.WriteLine("------------------------------------------");
        }
        public void Contain_Any()
        {
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(10);
            Console.WriteLine(result);
            {
                IList<Student> studentList = new List<Student>()
                {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                 new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 }
                };
                bool find = studentList.Any(s => s.Age > 12 && s.Age < 20);
                Console.WriteLine(find);
            }
            Console.WriteLine("------------------------------------------");
        }
        public void Predicate()
        {
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            bool result = isUpper("johnwick");
            Console.WriteLine(result);
            Console.WriteLine("------------------------------------------");
        }
        public void Select_Selectmany()
        {
            IList<Student> studentList = new List<Student>()
            {
                     new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                     new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 }
            };
            var selectResult = from s in studentList
                               select s.StudentName;
            foreach (var s in selectResult)
            {
                Console.WriteLine(s);
            }
            List<string> nameList = new List<string>() { "Pranaya", "Kumar" };
            var querySyntax = nameList.SelectMany(s => s);
            foreach (var sd in querySyntax)
            {
                Console.WriteLine(sd + "");
            }
            Console.WriteLine("------------------------------------------");
        }
        public void Get_Date()
        {
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 12, 31);
            var details = Enumerable.Range(0, Int32.MaxValue);
            var monthsBetween = details.Select(assign => startDate.AddMonths(assign)).TakeWhile(date => date <= endDate).Select(date => date.ToString("MM"));
            foreach(var data in monthsBetween)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("------------------------------------------");
        }
        public void OverLap_Interval()
        {
            var startDateA = new DateTime(2023, 5, 1);
            var endDateA = new DateTime(2023, 5, 10); 
            var startDateB = new DateTime(2023, 5, 5);
            var endDateB = new DateTime(2023, 5, 15);
            if (startDateA < startDateB && endDateA < endDateB)
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                Console.WriteLine("NotOverlapping");
            }
            Console.WriteLine("------------------------------------------");
        }
        public void Offset_OrderBy()
        {
            IList<Student> studentList = new List<Student>()
            {
                     new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                     new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                     new Student() { StudentID = 3, StudentName = "Wick",  Age = 23 },
                     new Student() { StudentID = 4, StudentName = "Trom",  Age = 25 },
            };
            var result = studentList.Skip(2).Take(1);
            foreach (var total in result)
            {
                Console.WriteLine("{0} {1} {2}", total.StudentID, total.StudentName, total.Age);
            }
            Console.WriteLine("------------------------------------------");
        }
        public static void Main()
        {
            var call = new program();
            call.Find_Same();
            call.Find_Diff();
            call.Inner_Join();
            call.Left_Join();
            call.Call_Function();
            call.LINQ_Max_Min_Count();
            call.Merge_File();
            call.Group_by();
            call.Get_Month_Date();
            call.Get_Month_Day();
            call.Specific_String();
            call.Contain_Any();
            call.Predicate();
            call.Select_Selectmany();
            call.Get_Date();
            call.OverLap_Interval();
            call.Offset_OrderBy();
        }
    }
}