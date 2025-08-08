using BookStore.Book.Api.Domain.Model;

namespace BookStore.Book.Api.Repository
{
    public class BookRepository: IBookRepository
    {
        public Task<int> AddBookAsync(BookModel user)
        {
            throw new NotImplementedException(); 
        }

        public async Task<List<BookResponse>> GetAllBooksAsync()
        {
            var activeUsers = BookList.Users
            .Where(u => u.IsActive && !u.IsDeleted)
            .Select(u => new BookResponse
            {
                Id = u.Id,
                Name = u.Name
            })
            .ToList();
    
            return activeUsers;
        }

        public Task<BookResponse> GetBookByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
