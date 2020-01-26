using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    interface IAuthorService
    {
        Task<List<Author>> GetAuthors();
        Task<Author> GetAuthorById(int authorId);
        Task<bool> SaveAuthor(Author author);
        Task<bool> DeleteAuthor(string authorId);
    }
}
