using System.Security.Cryptography.X509Certificates;

namespace Strings
{
    internal class Program
    {
        public void Stringg()
        {
            string s1 = "Welcome";
            char[] ch = { 'c', 'o', 'd', 'e', 'r' };
            string s2 = new string(ch);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void clonee()
        {
            string s1 = "How Are You";
            string s2 = (string)s1.Clone();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Comparee()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";
            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));
            {
                Console.WriteLine("____________________");
            }
        }



        public void CompareOrdinall()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";
            Console.WriteLine(string.CompareOrdinal(s1, s2));
            Console.WriteLine(string.CompareOrdinal(s1, s3));
            Console.WriteLine(string.CompareOrdinal(s1, s4));
            {
                Console.WriteLine("____________________");
            }
        }

        public void CompareToo()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s3));
            {
                Console.WriteLine("____________________");
            }
        }

        public void Concatt()
        {
            string s1 = "Hello ";
            string s2 = "C#";
            Console.WriteLine(string.Concat(s1, s2));
            {
                Console.WriteLine("____________________");
            }
        }

        public void Containss()
        {
            string s1 = "Hello ";
            string s2 = "He";
            string s3 = "Hi";
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));
            {
                Console.WriteLine("____________________");
            }

        }

        public void Copyy()
        {
            string s1 = "Hello ";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void CopyToo()
        {
            string s1 = "Hello C#, How Are You?";
            char[] ch = new char[15];
            s1.CopyTo(10, ch, 0, 12);
            Console.WriteLine(ch);
            {
                Console.WriteLine("____________________");
            }
        }

        public void EndsWithh()
        {
            string s1 = "Hello";
            string s2 = "llo";
            string s3 = "C#";
            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));
            {
                Console.WriteLine("____________________");
            }
        }

        public void Equalss()
        {
            string s1 = "Hello";
            string s2 = "Hello";
            string s3 = "Bye";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            {
                Console.WriteLine("____________________");
            }
        }

        public void Formatt()
        {

            string s1 = string.Format("{0:D}", DateTime.Now);
            Console.WriteLine(s1);
            {
                Console.WriteLine("____________________");
            }

        }

        public void GetEneumatorr()
        {
            string s2 = "Hello C#";
            CharEnumerator ch = s2.GetEnumerator();
            while (ch.MoveNext())
                Console.WriteLine(ch.Current);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Gotcodet()
        {
            string s1 = "Hello C#";
            Console.WriteLine(s1.GetHashCode());
            {
                Console.WriteLine("____________________");
            }
        }


        public void GetTypee()
        {
            string s1 = "Hello C#";
            Console.WriteLine(s1.GetType());
            {
                Console.WriteLine("____________________");
            }
        }

        public void Gettypeco()
        {
            string s1 = "Hello C#";
            Console.WriteLine(s1.GetTypeCode());
            {
                Console.WriteLine("____________________");
            }
        }

        public void Inserting()
        {
            string s1 = "Hello C#";
            string s2 = s1.Insert(5, "-");
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Interned()
        {
            string s1 = "Hello C#";
            string s2 = string.Intern(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Isintered()
        {
            string s1 = "Hello C#";
            string s2 = string.Intern(s1);
            string s3 = string.IsInterned(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Normal()
        {
            string s1 = "Hello C#";
            bool b1 = s1.IsNormalized();
            Console.WriteLine(s1);
            Console.WriteLine(b1);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Normalizee()
        {
            string s1 = "Hello C#";
            string s2 = s1.Normalize();
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Nnull()
             {    
       string s1 ="h" ;
        string s2 = "";
        bool b1 = string.IsNullOrEmpty(s1);
        bool b2 = string.IsNullOrEmpty(s2);
        Console.WriteLine(b1);  
       Console.WriteLine(b2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Whitespac()
        {
            string s1 = "hhh";
            string s2 = "";
            string s3 = " ";
          bool b1 = string.IsNullOrWhiteSpace(s1);
            bool b2 = string.IsNullOrWhiteSpace(s2);
            bool b3 = string.IsNullOrWhiteSpace(s3);
            Console.WriteLine(b1);       // returns False   
            Console.WriteLine(b2);       // returns True   
            Console.WriteLine(b3);       // returns True   
            {
                Console.WriteLine("____________________");
            }
        }

        public void Joine()
         {    
           string[] s1 = { "Hello", "C#", "by", "javatpoint" };
        string s3 = string.Join("-", s1);
        Console.WriteLine(s3);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Lastindx()
        {
            string s1 = "Hello C#l";
            int index = s1.LastIndexOf('l');
            Console.WriteLine(index);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Lastindexoff()
        {
            string s1 = "abracadarab";
            char[] ch = { 'r', 'b' };
            int index = s1.LastIndexOfAny(ch);//Finds 'r' at the last  
            Console.WriteLine(index);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Padl()
        {
            string s1 = "Hello C#";// 8 length of characters  
            string s2 = s1.PadLeft(10);//(10-8=2) adds 2 whitespaces at the left side  
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }

        }

        public void Padr()
        {
            string s1 = "Hello C#";// 8 length of characters  
            string s2 = s1.PadRight(15);
            Console.Write(s2);//padding at right side (15-8=7)  
            Console.Write("JavaTpoint");//will be written after 7 white spaces  
            {
                Console.WriteLine("____________________");
            }
        }

        public void Remov()
        {
            string s1 = "Hello C#";
            string s2 = s1.Remove(2);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Replac()
        {
            string s1 = "Hello F#";
            string s2 = s1.Replace('H', '7');
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Splt()
        {
            string s1 = "Hello C Sharp";
            string[] s2 = s1.Split(' ');
            foreach (string s3 in s2)
                Console.WriteLine(s3);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Startt()
        {
            string s1 = "Hello C Sharp";
            bool b1 = s1.StartsWith("h");
            bool b2 = s1.StartsWith("H");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            {
                Console.WriteLine("____________________");
            }
        }
                         
        public void SubStringg()
        {
            string s1 = "Hello C Sharp";
            string s2 = s1.Substring(5);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Charaarr()
        {
            string s1 = "Hello C#";
            char[] ch = s1.ToCharArray();
            foreach (char c in ch)
            {
                Console.WriteLine(c);
                {
                    Console.WriteLine("____________________");
                }
            }
        }

            public void Loww()
            {
                string s1 = "Hello C#";
                string s2 = s1.ToLower();
                Console.WriteLine(s2);
                {
                    Console.WriteLine("____________________");
                }
            }

            public void Lowinvarr()
                 {
                string s1 = "Hello C#";
                string s2 = s1.ToLowerInvariant();
                Console.WriteLine(s2);
                {
                    Console.WriteLine("____________________");
                }
            }
        
        public void Str()
        {
            string s1 = "Hello C#";
            int a = 123;
            string s2 = s1.ToString();
            string s3 = a.ToString();
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Upp()
        {
            string s1 = "Hello C#";
            string s3 = s1.ToUpper();
            Console.WriteLine(s3);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Touppvar()
        {
            string s1 = "Hello C#    ";
            string s3 = s1.ToUpperInvariant();
            Console.WriteLine(s3);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Trm()
        {
            string s1 = "Hello C#";
            string s2 = s1.Trim();
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Trmend()
        {
            string s1 = "Hello C#";
            char[] ch = { '#' };
            string s2 = s1.TrimEnd(ch);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        public void Trmstar()
        {
            string s1 = "Hello C#";
            char[] ch = { 'H' };
            string s2 = s1.TrimStart(ch);
            Console.WriteLine(s2);
            {
                Console.WriteLine("____________________");
            }
        }

        static void Main(string[] args)
        {
            Program aaa = new Program();    
            aaa.Stringg();
            aaa.clonee();
            aaa.Comparee();
                aaa.CompareOrdinall();
                aaa.CompareToo();
                aaa.Concatt();
                aaa.Containss();
                aaa.Copyy();
                aaa.CopyToo();
                aaa.EndsWithh();
                aaa.Equalss();
                aaa.Formatt();
                aaa.GetEneumatorr();
                aaa.Gotcodet();
                aaa.GetTypee();
                aaa.Gettypeco();
                aaa.Inserting();
            aaa.Interned();
            aaa.Isintered();
            aaa.Normal();
            aaa.Normalizee();
            aaa.Nnull();
            aaa.Whitespac();
                aaa.Joine();
            aaa.Lastindx();
            aaa.Lastindexoff();
            aaa.Padl();
            aaa.Padr();
            aaa.Remov();
            aaa.Replac();
            aaa.Splt();
            aaa.Startt();
            aaa.SubStringg();
            aaa.Charaarr();
            aaa.Loww();
            aaa.Lowinvarr();
            aaa.Str();
            aaa.Upp();
            aaa.Touppvar();
            aaa.Trm();
            aaa.Trmend();
            aaa.Trmstar();
        }
    }
}