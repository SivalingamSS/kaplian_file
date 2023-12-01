namespace Virtu
{
    class a
    {
        public virtual void method()
        {
            Console.WriteLine("The Man");
        }
    }
    class b : a 
    {
        public override void method()
        {
            Console.WriteLine("The Bear");
        }
    }
    class c : a
    {
        public override void method()
        {
            Console.WriteLine("The Man");
        }
    }
    class d : c
    {
        public static void Main(string[] args)
        {
            a cal = new a();
            cal.method();
            b cakk = new b();
            cakk.method();
            //cakk.meth();
            c call = new c();
            call.method();
        }
    }
}