using System;
using System.Threading;

namespace Csharp_curso;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao cronômetro regressivo!");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("S = Segundos => 10s = 10 segundos");
        Console.WriteLine("M = Minutos => 1m = 1 minuto");
        Console.WriteLine("Quanto tempo deseja contar?");
        Console.WriteLine("0 = Sair");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        PreStart(time * multiplier);
        Console.WriteLine(type);
        Console.WriteLine(time);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Preparar...");
        Thread.Sleep(1000);
        Console.WriteLine("Apontar...");
        Thread.Sleep(1000);
        Console.WriteLine("JÁ!!!");
        Thread.Sleep(2000);
        Start(time);
    }
    static void Start(int time, int currentTime = 0)
    {
        while (time != currentTime)
        {
            Console.Clear();
            Console.WriteLine(time + "...");
            time--;
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Cronômetro finalizado.");
        Thread.Sleep(2500);
        Menu();
    }
}
