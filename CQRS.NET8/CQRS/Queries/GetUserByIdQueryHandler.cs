using CQRS.NET8.DTOs;
using MediatR;

namespace CQRS.NET8.CQRS.Queries;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
{
    private readonly AppDbContext _context;

    public GetUserByIdQueryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.FindAsync(request.UserId);
        return new UserDto { Id = user.Id, Name = user.Name, Email = user.Email };
    }
}