using System;

namespace MeuApp
{
    class Program
    {
        static void Main (string[] args)
        {

            // Tipos primitivos

            int idade = 20;   // int representa o conjunto dos numero inteiros
            string nome = "Giovanni"; // string é um conjunto de caracteres, ou conjunto de chars
            double altura = 1.84; // double é o conjunto dos numeros reais a
            //Console.WriteLine($"Olá {nome} anos, um {altura} de altura e {idade} anos, correto?");

            
            int? idade2 = null; // é uma variavel declarada como nula- nullabel types

            int inteiro = 100;
            float real = 25.5f;

            //real = inteiro; // conversão explicita, variavel passa a valer 100.0f
            //inteiro = (int)real; // outa maneira de converter 

            inteiro = int.Parse("255"); // converter para strig
            Console.WriteLine(inteiro);




        }
    }
}
