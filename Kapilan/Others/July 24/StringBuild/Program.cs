using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace StringBuild
{
    internal class Program
    {
        StringBuilder sb = new StringBuilder("google"/*,"chrome","data","boat"*/);
        Console.WriteLine(sb);
        static void Main(string[] args)
        {
            Console.WriteLine(sb);
        }
    }
}