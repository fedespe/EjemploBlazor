using CRUDCodeFirstEF.Models;

namespace CRUDCodeFirstEF.Data
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookDetail(int id);
        Task<bool> InsertBook(Book book);
        Task<bool> UpdateBook(Book book);
        Task<bool> DeleteBook(int id);
        Task<bool> SaveBook(Book book);

    }
}
