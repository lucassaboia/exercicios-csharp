using System;

namespace MeuAppp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha a operação: SOMA - SUBTRACAO - DIVISAO - MULTIPLICACAO");
            var escolha = Console.ReadLine();

            switch (escolha.ToLowerInvariant())
            {
                case "soma": Soma(); break;
                case "subtracao": Subtracao(); break;
                case "divisao": Divisao(); break;
                case "multiplicacao": Multiplicacao(); break;
                case "sair": System.Environment.Exit(0); break;
                default:
                    Console.WriteLine("Operação inválida"); Console.ReadKey(); Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();

            // Console.WriteLine($"O resultado da soma é  {v1 + v2}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }
    }
}


