using System;
using System.Globalization;

namespace ExercicioDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? R$ ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? $ ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
