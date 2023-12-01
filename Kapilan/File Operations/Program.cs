namespace File_Operations
{
    class Program
    {
        public void Copy_Contents()
        {
            var File1 = @"C:\Users\visualapp\Documents\Check_task.txt";
            var File2 = @"C:\Users\visualapp\Documents\file_\Copy2.txt";
            File.Copy(File1, File2);
            Console.WriteLine(File.ReadAllText(File2));
            Console.WriteLine("------------------------------------");
        }
        public void Compare_two_files()
        {
            var areEquals = File.ReadLines(@"C:\Users\visualapp\Documents\Check_task.txt").SequenceEqual(File.ReadLines(@"C:\Users\visualapp\Documents\Check_task_2.txt"));
            Console.WriteLine(areEquals);
            Console.WriteLine("------------------------------------");
        }
        public void Find_size()
        {
            DirectoryInfo dInfo = new DirectoryInfo(@"C:\Kapilan\Find_Year_Days");
            long sizeOfDir = DirectorySize(dInfo, true);
            Console.WriteLine("Directory size in Bytes : " +
            "{0:N0} Bytes", sizeOfDir);
            Console.WriteLine("Directory size in KB : " +
            "{0:N2} KB", ((double)sizeOfDir) / 1024);
            Console.WriteLine("Directory size in MB : " +
            "{0:N2} MB", ((double)sizeOfDir) / (1024 * 1024));

            static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
            {
                long totalSize = dInfo.EnumerateFiles()
                             .Sum(file => file.Length);
                if (includeSubDir)
                {
                    totalSize += dInfo.EnumerateDirectories()
                             .Sum(dir => DirectorySize(dir, true));
                }
                return totalSize;
            }
            Console.WriteLine("------------------------------------");
        }
        public void File_Time()
        {
            FileInfo info = new FileInfo(@"C:\Kapilan\File Operations\File Operations.sln");
            DateTime time = info.CreationTime;
            Console.WriteLine($"File was Created at : {time}");
            Console.WriteLine("------------------------------------");
        }
        public void List_DiskDrives()
        {
            DriveInfo[] driveslist = DriveInfo.GetDrives();
            foreach (DriveInfo d in driveslist)
            {
                Console.WriteLine($"Drive {d.Name} ");
                Console.WriteLine($"File type: {d.DriveType} ");
                if (d.IsReady == true)
                {
                    Console.WriteLine(" Total size of drive:{0, 15} bytes ", d.TotalSize);
                }
                Console.WriteLine("------------------------------------");
            }
        }
        public static void Main()
        {
            Program Call = new Program();
            Call.Copy_Contents();
            Call.Compare_two_files();
            Call.Find_size();
            Call.File_Time();
            Call.List_DiskDrives();
        }
    }
}