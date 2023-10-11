using Blog.Models;
using Blog.Repositories;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog;

class Program
{
    private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1XfM4NeszwtckTP1bl4z!;TrustServerCertificate=true";
    static void Main(string[] args)
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();
        // ReadUsers(connection);
        ReadWithRoles(connection);
        // CreateUser(connection);
        // CreateTag(connection);
        // CreateRole(connection);
        // ReadTags(connection);
        // ReadRoles(connection);
        // ReadTags(connection);    
        // UpdateUser();
        // DeleteUser();
        connection.Close();
    }
    public static void ReadUsers(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var items = repository.Get();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
            foreach (var role in item.Roles)
            {
                Console.WriteLine(role.Name);
            }
        }
    }
    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
    public static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
    public static void CreateUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var user = new User
        {
            Bio = "Designer de UX/UI apaixonado por criar experiências intuitivas para os usuários",
            Email = "designer.jane@email.com",
            Image = "https://example.com/jane_doe.jpg",
            Name = "Jane Doe",
            Slug = "jane-doe",
            PasswordHash = "HASH456"
        };
        repository.Create(user);
    }
    public static void CreateRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var role = new Role
        {
            Name = "Escritor",
            Slug = "escriptor",
        };
        repository.Create(role);
    }
    public static void CreateTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var tag = new Tag
        {
            Name = "Jane Doe",
            Slug = "jane-doe",
        };
        repository.Create(tag);
    }
    private static void ReadWithRoles(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var users = repository.ReadWithRole();

        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
            foreach (var role in user.Roles) Console.WriteLine($" - {role.Slug}");
        }
    }
    // public static void CreateUser()
    // {
    //     using (var connection = new SqlConnection(CONNECTION_STRING))
    //     {
    //         var user = new User()
    //         {
    //             Bio = "4x Google Developer Expert",
    //             Email = "exemplo@email.com",
    //             Image = "https://exemplo.com/imagem.jpg",
    //             Name = "Exemplo Usuário",
    //             Slug = "exemplo-usuario",
    //             PasswordHash = "HASH"

    //         };
    //         connection.Insert<User>(user);
    //         Console.WriteLine("Cadastro realizado com sucesso!");
    //     }
    // }
    // public static void UpdateUser()
    // {
    //     using (var connection = new SqlConnection(CONNECTION_STRING))
    //     {
    //         var user = new User()
    //         {
    //             Id = 4,
    //             Bio = "3x MongoDB Certified Developer",
    //             Email = "joao.silva@email.com",
    //             Image = "https://exemplo.com/joaosilva.jpg",
    //             Name = "João Silva - MongoDB Enjoyer",
    //             Slug = "joao-silva",
    //             PasswordHash = "HASH"

    //         };
    //         connection.Update<User>(user);
    //         Console.WriteLine("Atualização de registro realizada com sucesso!");
    //     }
    // }
    // public static void DeleteUser()
    // {
    //     using (var connection = new SqlConnection(CONNECTION_STRING))
    //     {
    //         var user = connection.Get<User>(7);
    //         connection.Delete<User>(user);
    //         Console.WriteLine("Registro deletado com sucesso!");
    //     }
    // }

}
