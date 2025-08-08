using BookStore.Book.Api.Domain.Model;
using BookStore.Book.Api.Repository;

namespace BookStore.Book.Api.Service
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo) => _repo = repo;

        public Task<int> AddBookAsync(BookModel user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookResponse>> GetAllBooksAsync()
        {
           return await _repo.GetAllBooksAsync();
        }

        public Task<BookResponse> GetBookByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
