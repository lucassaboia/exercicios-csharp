namespace Interpolacao;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int[] meuArray = new int[15] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, };

        foreach (var item in meuArray)
        {
            Console.WriteLine(item);
        }

    }
}
