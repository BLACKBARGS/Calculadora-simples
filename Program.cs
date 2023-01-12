using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string? operacao;

            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada, depois aperte ENTER duas vezes para obter o resultado (+, -, *, /):");
            operacao = Console.ReadLine();
            if (Console.ReadLine() is null)
                return;

            switch (operacao)
            {
                case "+":
                    Console.WriteLine("Resultado: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Resultado: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Resultado: " + num1 * num2);
                    break;
            }
        }
    }
}