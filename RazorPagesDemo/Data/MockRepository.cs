using RazorPagesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesDemo.Data
{
    public class MockRepository : IRepository
    {
        private List<Book> books;

        public MockRepository()
        {
            books = new List<Book> { new Book { Id = 1, Author = "Mark Twain", Category = "Fantasy", DateOfPublish = DateTime.Now, Description = "coś tam", ISBN = "232-3232-45", Title = "Book1", Stock = 10  } };
            

        }
        void IRepository.AddBook(Book book)
        {
            books.Add(book);
        }

        void IRepository.DeleteBook(Book book)
        {
            books.Remove(book);
        }

        List<Book> IRepository.GetAllBooks()
        {
            return books;
        }

        Book IRepository.GetById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        void IRepository.UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
