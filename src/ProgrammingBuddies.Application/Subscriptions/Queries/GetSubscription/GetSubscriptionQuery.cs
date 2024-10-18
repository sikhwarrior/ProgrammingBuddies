using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Permissions;
using ProgrammingBuddies.Application.Common.Security.Policies;
using ProgrammingBuddies.Application.Common.Security.Request;
using ProgrammingBuddies.Application.Subscriptions.Common;

namespace ProgrammingBuddies.Application.Subscriptions.Queries.GetSubscription
{
    [Authorize(Permissions = Permission.Subscription.Get, Policies = Policy.SelfOrAdmin)]
    public record GetSubscriptionQuery(Guid UserId)
        : IAuthorizeableRequest<ErrorOr<SubscriptionResult>>;
}