using BookStore.Book.Api.Domain.Model;
using BookStore.Book.Api.Service;
using MediatR;

namespace BookStore.Book.Api.Logic.Query
{
    public record GetAllBooksQuery() : IRequest<List<BookResponse>>;

    public class GetAllUsersHandler : IRequestHandler<GetAllBooksQuery, List<BookResponse>>
    {
        private readonly IBookService _service;
        public GetAllUsersHandler(IBookService service) => _service = service;

        public Task<List<BookResponse>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = _service.GetAllBooksAsync();
            return books;
        }
    }
}
