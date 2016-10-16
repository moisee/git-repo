using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicKeyWord
{
    class Program
    {
        static void ImplicitlyTypeVariable()
        {
            var a = new List<int>();
            a.Add(90);
            //a = "Hello";
        }
        static void PrintThreeStrings()
        {
            var s1 = "Greetings";
            object s2 = "From";
            dynamic s3 = "Mineapolis";
            Console.WriteLine("s1 is of type: {0}", s1.GetType());
            Console.WriteLine("s2 is of type: {0}", s2.GetType());
            Console.WriteLine("s3 is of type: {0}", s3.GetType());
        }
        static void Main(string[] args)
        {
            PrintThreeStrings();
            Console.ReadKey();   
        }
    }
}