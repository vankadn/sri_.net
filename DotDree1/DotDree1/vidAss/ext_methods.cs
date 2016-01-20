using System;
using ForNamespace;

namespace DotDree1.vidAss
{
    class ext_methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class to display extension methods");
            //   ExClass x = new ExClass();
            Console.WriteLine(ExClass.adder(4, 4, 5));

        }
    }
}
namespace ForNamespace
{
    public static class ExClass
    {
        public static int adder(this ext_methods, int a, int b)
        {
          int x = a + b;
           return x;
        }

    }
}