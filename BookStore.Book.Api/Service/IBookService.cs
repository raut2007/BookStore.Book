using BookStore.Book.Api.Domain.Model;

namespace BookStore.Book.Api.Service
{
    public interface IBookService
    {
        Task<List<BookResponse>> GetAllBooksAsync();
        Task<BookResponse> GetBookByIdAsync();
        Task<int> AddBookAsync(BookModel user);
    }
}
