using BookStore.Book.Api.Domain.Model;
using BookStore.Book.Api.Logic.Query;
using BookStore.User.Api.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Book.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator) => _mediator = mediator;

        [HttpGet("all")]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = await _mediator.Send(new GetAllBooksQuery());
            return Ok(new Response<List<BookResponse>>(result != null, result,  result.Count == 0 ? "No data found" : ""));
        }
    }
}
