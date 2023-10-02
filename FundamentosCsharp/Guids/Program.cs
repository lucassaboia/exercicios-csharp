namespace Guids;

class Program
{
    static void Main(string[] args)
    {
        var id = Guid.NewGuid();
        id.ToString();

        id = new Guid("9f13477e-075c-439b-acb6-6719b7bb8716");
        Console.WriteLine(id.ToString().Substring(0, 8));
    }
}
