using ErrorOr;

using MediatR;

using ProgrammingBuddies.Application.Authentication.Queries.Login;
using ProgrammingBuddies.Domain.Users;

namespace ProgrammingBuddies.Application.Tokens.Queries.Generate
{
    public record GenerateTokenQuery(
        Guid? Id,
        string FirstName,
        string LastName,
        string Email,
        SubscriptionType SubscriptionType,
        List<string> Permissions,
        List<string> Roles) : IRequest<ErrorOr<GenerateTokenResult>>;
}