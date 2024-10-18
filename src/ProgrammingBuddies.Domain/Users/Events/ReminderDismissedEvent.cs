using ProgrammingBuddies.Domain.Common;

namespace ProgrammingBuddies.Domain.Users.Events
{
    public record ReminderDismissedEvent(Guid ReminderId) : IDomainEvent;
}