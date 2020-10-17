using RazorPagesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesDemo.Data
{
    public interface IRepository
    {
        List<Book> GetAllBooks();

        Book GetById(int id);

        void AddBook(Book book);

        void DeleteBook(Book book);

        void UpdateBook(Book book);

    }
}
