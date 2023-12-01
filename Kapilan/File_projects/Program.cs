using System.Collections.Concurrent;

namespace File_projects
{
    class Program
    {
        public void create_file()
        {
            string path = @"C:\New folder\Created_By_Program.txt";
            File.Create(path);
            Console.WriteLine("Created");
            Console.WriteLine("-----------------------");
        }
        public void Create_Directory()
        {
            Directory.CreateDirectory(@"C:\NewDirectory");
            Console.WriteLine("Directory Created");
            Console.WriteLine("-----------------------");
        }
        public void Read_Text_File()
        {
            string textfile = @"C:\Users\visualapp\Documents\Naven Na Task.txt";
            string text = File.ReadAllText(textfile);
            Console.WriteLine(text);
            Console.WriteLine("-----------------------");
        }
        public void Read_File_Information()
        {
            FileInfo info = new FileInfo(@"C:\Users\visualapp\Documents\Naven Na Task.txt");
            FileAttributes attributes = info.Attributes;
            Console.WriteLine(attributes);
            Console.WriteLine("-----------------------");
        }
        public void View_Access_Date_Time()
        {
            FileInfo info = new FileInfo(@"C:\Users\visualapp\Documents\Naven Na Task.txt");
            DateTime time = info.CreationTime;
            Console.WriteLine("File Creation Time :" + time);
            DateTime AccesTime = info.LastAccessTime;
            Console.WriteLine("File Last Access Time :" + AccesTime);
            DateTime WriteTime = info.LastWriteTime;
            Console.WriteLine("File Last Write Time :" + WriteTime);
            Console.WriteLine("-----------------------");
        }
        public void Directory_GetAllFiles()
        {
            string[] files = Directory.GetFiles(@"C:\Kapilan\Tasks", "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("-----------------------");
        }
        public void File_Exists()
        {
            string path = @"\\Vaf\vaf\string Task.txt";
            if (File.Exists(path))
            {
                Console.WriteLine($"The File Path {path} is Exists");
            }
            else
            {
                Console.WriteLine($"The File Path {path} is Not Exists");
            }
            Console.WriteLine("-----------------------");
        }
        public void Directory_GetFiles()
        {
            string[] get = Directory.GetFiles(@"C:\Users\visualapp\Pictures\New folder");
            foreach (string set in get)
            {
                Console.WriteLine(set);
            }
            Console.WriteLine("-----------------------");
        }
        public static void Main(string[] args)
        {
            Program found = new Program();
            found.create_file();
            found.Create_Directory();
            found.Read_Text_File();
            found.Read_File_Information();
            found.View_Access_Date_Time();
            found.Directory_GetAllFiles();
            found.File_Exists();
            found.Directory_GetFiles();
        }
    }
}