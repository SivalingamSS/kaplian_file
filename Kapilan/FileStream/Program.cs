using System.IO;
using System.Text;

namespace Filestream
{
    public class Program
    {
        static void Main(string[] args)
        {
            //WriteBinaryFile();
            //ReadBinaryFile();
            //Streamreader();
            //StreamWriter();
            //StringReader();
            //StringWritter();
            //Directory();
            //FileInfo();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"C:\Users\visualapp\Desktop\New.txt", FileMode.Create)))
            {
                writer.Write(12.5);
                writer.Write("Writed Succesfully");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(@"C:\Users\visualapp\Desktop\New.txt", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
        static void Streamreader()
        {
            FileStream f = new FileStream(@"C:\Users\visualapp\Desktop\Study.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            /*            string line = s.ReadLine();
                        Console.WriteLine(line);*/

            string line2 = "";
            while ((line2 = s.ReadLine()) != null)
            {
                Console.WriteLine(line2);
            }
        }
        static void StreamWriter()
        {
            FileStream f = new FileStream(@"C:\Users\visualapp\Desktop\New.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("hello c#");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
        }
        static void StringReader()
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Close();
            StringReader reader = new StringReader(str.ToString());
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        static void StringWritter()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.Write("Hello, ");
                sw.Write("StringWriter!");

                string result = sw.ToString();

                Console.WriteLine(result);
            }
        }
        static void Directory()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\NewCreation");

            if (directory.Exists)
            {
                Console.WriteLine("Directory already exist.");
                return;
            }
            directory.Create();
            Console.WriteLine("The directory is created successfully.");

        }
        static void FileInfo()
        {
            string path = @"C:\NewOne\Created_By_Program.txt";
            File.Create(path);
            Console.WriteLine("Created");
            Console.WriteLine("File is created Successfuly");
        }
    }
}

