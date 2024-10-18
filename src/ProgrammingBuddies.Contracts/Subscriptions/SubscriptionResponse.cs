using ProgrammingBuddies.Contracts.Common;

namespace ProgrammingBuddies.Contracts.Subscriptions
{
    public record SubscriptionResponse(
        Guid Id,
        Guid UserId,
        SubscriptionType SubscriptionType);
}