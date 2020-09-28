using MyLibraryStore.Data;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbContext = null;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Book GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void CreateBook(Book book)
        {
            _dbContext.Add(book);
            _dbContext.SaveChanges();
        }

        public void UpdateBook(int? id, Book book)
        {
            var ub = _dbContext.Books.SingleOrDefault(x => x.Id == id.Value);
            ub.BookName = book.BookName;
            ub.Author = book.Author;
            ub.ISBN = book.ISBN;
            ub.PublishedDate = book.PublishedDate;
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int? id)
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

    }
}
