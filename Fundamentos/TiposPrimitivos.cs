using System;
using System.Runtime.InteropServices.ObjectiveC;

namespace Fundamentos 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char unicode = '\u03B2';
            char genero = 'M';
            bool completo = false;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 79.5;
            string nome = "Giovanni Finetto";
            object obj1 = "Elon musk";


            Console.WriteLine(obj1);
            Console.WriteLine(nome);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(unicode);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
