


namespace Практ_2_5
{
    public class Program
    {
        public static void Method()
        {
            Del del = new Del();
        }
        static void Main()
        {
            Method();

            GC.Collect();
            Console.ReadLine();


        }
    }
}