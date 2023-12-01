namespace Constructor
{
    class Method
    {
        public Method()
        {
            Console.WriteLine("Create Anime");
        } 
        public static void Main(string[] args)
        {
            Method m1 = new Method(); 
            Method m2 = new Method();
            Method m3 = new Method();
        }    
    }
}
