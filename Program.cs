using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples");

            while (true)
            {
                Console.WriteLine("Escolha a operação:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("0. Sair");

                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 0)
                {
                    Console.WriteLine("Encerrando a calculadora.");
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (escolha)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        break;
                    case 4:
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Escolha inválida.");
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }
}
