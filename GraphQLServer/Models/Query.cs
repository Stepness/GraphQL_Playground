using HotChocolate.Types;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLServer
{
    public class Query
    {
        public List<Book> GetBook() => new List<Book> 
        {
            new Book {Title = "Test", Id = 1, Price = 10 },
            new Book {Title = "Test2", Id = 2, Price = 112 },
            new Book {Title = "Test3", Id = 3, Price = 13 },
            new Book {Title = "Test4", Id = 4, Price = 14 },
        };
    }
}