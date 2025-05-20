using MediatR;

namespace CQRS.NET8.CQRS.Commands;

public class CreateUserCommand : IRequest<Guid>
{
    public string Name { get; set; }
    public string Email { get; set; }
}