
using System.Globalization;
namespace FuncaoMaximoMin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tecnica de interpolação

            int idade = 20;
            double saldo = 100.390;
            string nome = "Giovanni Finetto";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F0} reais", nome, idade, saldo);


            int idade1 = 28;
            double saldo1 = 50.000;
            string nome1 = "Renata";

            Console.WriteLine($"{nome1} tem {idade1} anos e tem saldo igual a {saldo1:F0} reais ");



        }
    }
}
