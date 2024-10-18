using ProgrammingBuddies.Contracts.Common;

namespace ProgrammingBuddies.Contracts.Subscriptions
{
    public record CreateSubscriptionRequest(
        string FirstName,
        string LastName,
        string Email,
        SubscriptionType SubscriptionType);
}