using CQRS.NET8.DTOs;
using MediatR;

namespace CQRS.NET8.CQRS.Queries;

public class GetUserByIdQuery : IRequest<UserDto>
{
    public Guid UserId { get; set; }
}