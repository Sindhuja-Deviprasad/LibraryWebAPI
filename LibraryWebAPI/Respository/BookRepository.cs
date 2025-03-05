using LibraryWebAPI.Models;

namespace LibraryWebAPI.Respository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext db;

        public BookRepository(LibraryContext db)
        {
            this.db = db;
        }

        public int AddBook(Book book)
        {
            db.BooksT.Add(book);
            return db.SaveChanges();
        }

        public void  DeleteBook(int id)
        {
            Book c = db.BooksT.Where(x => x.BookId == id).FirstOrDefault();
            db.BooksT.Remove(c);
            db.SaveChanges();
            return;
        }

        public Book GetBook(int id)
        {
            return db.BooksT.Where(x => x.BookId == id).FirstOrDefault();

        }

        public List<Book> GetBooks()
        {
            return db.BooksT.ToList();
        }

        public void UpdateBook(int id,Book book)
        {
            Book c = db.BooksT.Where(x => x.BookId == id).FirstOrDefault();
            c.Title = book.Title;
            c.Author = book.Author;
            c.Genre = book.ISBN;
            c.YearPulished = book.YearPulished;
            db.Entry<Book>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return;
        }
    }
}
