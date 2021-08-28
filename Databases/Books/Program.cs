using System;
using Books.Models;

namespace Books
{
    class Program
    { //pm  scaffold-dbcontext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Server=(localdb)\MSSQLLocalDB;Database=C:\CS236-projects\databases\databases\Books\Books.mdf;Trusted_Connection=True;” -OutputDir Models

        static void Main(string[] args)
        {
            var context = new CCS236projectsdatabasesdatabasesBooksBooksmdfContext();
            foreach (var contextAuthor in context.Authors)
            {
                Console.WriteLine(contextAuthor.FirstName);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
