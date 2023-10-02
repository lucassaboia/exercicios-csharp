namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pessoaA = new Pessoa(1, "André Baltieri");
            var pessoaB = new Pessoa(1, "André Baltieri");

            Console.WriteLine(pessoaA.Equals(pessoaB));
        }
    }
    public class Pessoa : IEquatable<Pessoa>
    {
        public string Nome { get; set; }

        public int Id { get; set; }
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public bool Equals(Pessoa? pessoa)
        {
            return Id == pessoa.Id;
        }
    }
}