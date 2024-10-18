using ProgrammingBuddies.Domain.Common;

namespace ProgrammingBuddies.Domain.Users.Events
{
    public record SubscriptionCanceledEvent(User User, Guid SubscriptionId) : IDomainEvent;
}