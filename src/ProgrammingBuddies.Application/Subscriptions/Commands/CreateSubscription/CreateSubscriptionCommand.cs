using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Permissions;
using ProgrammingBuddies.Application.Common.Security.Policies;
using ProgrammingBuddies.Application.Common.Security.Request;
using ProgrammingBuddies.Application.Subscriptions.Common;
using ProgrammingBuddies.Domain.Users;

namespace ProgrammingBuddies.Application.Subscriptions.Commands.CreateSubscription
{
    [Authorize(Permissions = Permission.Subscription.Create, Policies = Policy.SelfOrAdmin)]
    public record CreateSubscriptionCommand(
        Guid UserId,
        string FirstName,
        string LastName,
        string Email,
        SubscriptionType SubscriptionType)
        : IAuthorizeableRequest<ErrorOr<SubscriptionResult>>;
}