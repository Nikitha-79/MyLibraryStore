using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1,BookName="Fairy Tales",Author="Nikitha",ISBN="IS1234",PublishedDate=Convert.ToDateTime("02/03/2000")},
                new Book{Id=2,BookName="Wings Of Fire",Author="APJ Kalam",ISBN="IS4567",PublishedDate=Convert.ToDateTime("22/09/2010")},
                new Book{Id=3,BookName="World India",Author="Rufson",ISBN="IS1357",PublishedDate=Convert.ToDateTime("06/04/2004")},
                new Book{Id=4,BookName="2 States",Author="Sravani",ISBN="IS2468",PublishedDate=Convert.ToDateTime("15/04/1999")},
            };
        }

        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(int? id, Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
