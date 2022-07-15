using System;

namespace Calculadora_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome? ");
            String nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual sua idade? ");
            float idade = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual sua altura? ");
            float alt = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual seu peso? ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            float imc = peso / (alt * alt);

            Console.WriteLine("Seu IMC é " + Math.Round (imc,1) + ".");
        }
    }
}
