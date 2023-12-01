using Microsoft.Exchange.WebServices.Data;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace enum_to_int
{
    class Program
    {
        public enum Pole
        {
            [Description("This is called North Direction")]
            North,
            East,
            South,
            West,
        }
        public void Get_one_int()
        {
            int Nothvalue = (int)Pole.North;
            Console.WriteLine(Nothvalue);
            Console.WriteLine("---------------------");
        }
        public void Get_all_int()
        {
            foreach (int i in Enum.GetValues(typeof(Pole)))
            {
                Console.WriteLine(i);
            };
            Console.WriteLine("---------------------");
        }
        public void Convert_List()
        {
            List<Pole> days = Enum.GetValues(typeof(Pole)).Cast<Pole>().ToList();
            foreach (var box in days)
            {
                Console.WriteLine(box.ToString());
            }
            Console.WriteLine("---------------------");
        }
        public void Read_file_line()
        {
            string path = File.ReadAllText(@"C:\Users\visualapp\Documents\Naven Na Task.txt");
            Console.WriteLine("The Length In The Path is :" + path.Split('\r').Length); //carriage return in the line ends
            Console.WriteLine("The Words In The Path is :" + path.Split(' ').Length);
            Console.WriteLine("---------------------");
        }
        public void Replace_file_line()
        {
            String strFile = File.ReadAllText(@"C:\Users\visualapp\Documents\Check_task.txt");
            strFile = strFile.Replace("ISRO", "Indian Science Research Organization");
            File.WriteAllText(@"C:\Users\visualapp\Documents\Check_task.txt", strFile);
            Console.WriteLine(strFile);
            Console.WriteLine("---------------------");
        }
        public void Read_file_extension()
        {
            string fileName = @"C:\Users\visualapp\Downloads\7xm.xyz465228.jpg";
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            Console.WriteLine("File Extension:" + extn);
            long size = fi.Length;
            Console.WriteLine("File Size:" + size);
            Console.WriteLine("---------------------");
        }
        public void Read_Description()
        {
            var authorLevel = Pole.North.GetEnumDescription();
            Console.WriteLine(authorLevel);
            Console.WriteLine("---------------------");
        }
        public void Move_File()
        {
            string sourceDir = @"\\Vaf\vaf\string Task.txt";
            string destDir = @"C:\Users\visualapp\Documents\New folder";
            File.Move(sourceDir, destDir);
            Console.WriteLine("Moved");
        }
        public void Convert_Enum()
        {
            var dayNames = new List<string> { "Monday", "Tuesday ", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var dayValues = new List<DayOfWeek>();
            foreach (var dayName in dayNames)
            {
                var dayValue = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayName);
                dayValues.Add(dayValue);
            }
            Console.WriteLine(String.Join(Environment.NewLine, dayValues));
            Console.WriteLine("---------------------");
        }
        public static void Main()
        {
            Program Get = new Program();
            Get.Get_one_int();
            Get.Get_all_int();
            Get.Convert_List();
            Get.Read_file_line();
            Get.Replace_file_line();
            Get.Read_file_extension();
            Get.Read_Description();
            Get.Move_File();  
            Get.Convert_Enum();
        }
    }
}
