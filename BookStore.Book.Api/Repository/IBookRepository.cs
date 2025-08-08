using BookStore.Book.Api.Domain.Model;

namespace BookStore.Book.Api.Repository
{
    public interface IBookRepository
    {
        Task<List<BookResponse>> GetAllBooksAsync();
        Task<BookResponse> GetBookByIdAsync();
        Task<int> AddBookAsync(BookModel user);
    }
}
