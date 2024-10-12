
using System.Globalization;
namespace FuncaoMaximoMin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 2590;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.264567;

            Console.WriteLine($"Produtos:\r\n{produto1}, cujo o preço é ${preco1}\r\n{produto2}, cujo o preço é ${preco2}\r\nRegistro: {idade}, código {codigo} e gênero: {genero}\r\nMedida com oito casas decimais: {medida:F8}\r\nArredondado (três casas decimais):{medida:F3}\r\nSeparador Decimal invariant culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}

