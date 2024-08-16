using DTO;
using MediatR;

namespace WonderfulLibrary.Application.Query;

#region Query
public class GetBooksQuery: IRequest<List<Book>>
{

}
#endregion

#region Query Handler

public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, List<Book>>
{
    public Task<List<Book>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        var books = new List<Book>();
        books.Add(new Book() { Author = "Thomas Martin", Code = "A123", Name = "se", Price = 200, Rating = 4 });
        books.Add(new Book() { Author = "Thomas Scholz", Code = "A456", Name = "mhf", Price = 200, Rating = 4 });
        return Task.FromResult(books);
    }
}

#endregion
