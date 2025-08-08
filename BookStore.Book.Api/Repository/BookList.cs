using BookStore.Book.Api.Domain.Model;

namespace BookStore.Book.Api.Repository
{
    public class BookList
    {
            public static List<BookModel> Users = new List<BookModel>()
            { 
                new BookModel { Id = 101,Name = "Book-1",IsActive = true, IsDeleted=false, CreatedBy = 1, CreatedDate = DateTime.Now, UpdatedBy = 1, UpdatedDate = DateTime.Now },
                new BookModel { Id = 102,Name = "Book-2",IsActive = true, IsDeleted=false, CreatedBy = 1, CreatedDate = DateTime.Now, UpdatedBy = 1, UpdatedDate = DateTime.Now },
            };
    }
}
