using LibraryWebAPI.Models;
namespace LibraryWebAPI.Respository
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        int AddBook(int id);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}
