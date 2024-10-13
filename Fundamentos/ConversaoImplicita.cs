namespace ConversaoImplicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 5;
            int d = 2;

            double resultado = (double)c / d; // Conversão explícita de 'int' para 'double'
            Console.WriteLine(resultado); // O resultado será 2.5

            /*
            int c = 5;

            double resultado = c;  // Conversão implícita de 'int' para 'double'
            Console.WriteLine(resultado); // O resultado será 5.0
            */

        }
    }
}
