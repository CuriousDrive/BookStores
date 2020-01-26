using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class AuthorService : IAuthorService
    {   
        public List<Author> Authors { get; set; }

        public AuthorService()
        {
            //throw new Exception("AuthorServiceException");
            
            Authors = new List<Author>();

            Authors.Add(new Author(1, "Johnson", "White","johnson.white@gmail.com",11000,"4084967223", "Menlo Park"));
            Authors.Add(new Author(2, "Marjorie","Green","marjorie.green@gmail.com", 22000, "4159867020", "Oakland"));
            Authors.Add(new Author(3, "Cheryl", "Carson","cheryl.carson@gmail.com",39000, "4155487723", "Berkeley"));
            Authors.Add(new Author(4, "Michael", "O'Leary","michael.oleary@gmail.com",31000, "4082862428", "San Jose"));
            Authors.Add(new Author(5, "Dean", "Straight","dean.straight@gmail.com",29000, "4158342919", "Oakland"));
        }

        public async Task<List<Author>> GetAuthors()
        {
            return await Task.FromResult(Authors);
        }

        public async Task<Author> GetAuthorById(int authorId)
        {
            return await Task.FromResult(Authors.Where(auth => auth.AuthorId == authorId).FirstOrDefault());
        }
        
        public async Task<bool> SaveAuthor(Author author)
        {
            //author.AuthorId = GetNewAuthor();
            Authors.Add(author);
            return await Task.FromResult(true);
        }

        private string GetNewAuthor()
        {
            string id;
            Random random = new Random();
            id = random.Next(100, 1000).ToString() + "-";
            id += random.Next(10, 100).ToString() + "-";
            id += random.Next(1000, 10000).ToString();

            return id;
        }

        public async Task<bool> DeleteAuthor(string authorId)
        {
            return await Task.FromResult(true);
        }
    }
}
