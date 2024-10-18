using MediatR;

namespace ProgrammingBuddies.Application.Common.Security.Request
{
    public interface IAuthorizeableRequest<T> : IRequest<T>
    {
        Guid UserId { get; }
    }
}