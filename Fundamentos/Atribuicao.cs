namespace OperadoresAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int a = 10;
             Console.WriteLine(a);
             a += 2;
             Console.WriteLine(a);
             a-=2;
             Console.WriteLine(a);
             a *= 2;
             Console.WriteLine(a);

             string s = "ABC";

             Console.WriteLine(s);

             s += "DEF";

             Console.WriteLine(s);
            */

            int a = 10;
            
            int b = a++; // primeiro ele vai atribuir o valor de a no b e depois vai fazer a + 1,
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = ++a;
            Console.WriteLine(b);


        }
    }
}
