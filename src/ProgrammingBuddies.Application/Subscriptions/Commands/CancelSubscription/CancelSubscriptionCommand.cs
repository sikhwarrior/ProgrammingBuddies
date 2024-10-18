using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Request;
using ProgrammingBuddies.Application.Common.Security.Roles;

namespace ProgrammingBuddies.Application.Subscriptions.Commands.CancelSubscription
{
    [Authorize(Roles = Role.Admin)]
    public record CancelSubscriptionCommand(Guid UserId, Guid SubscriptionId) : IAuthorizeableRequest<ErrorOr<Success>>;
}