using ProgrammingBuddies.Domain.Common;

namespace ProgrammingBuddies.Domain.Users.Events
{
    public record ReminderDeletedEvent(Guid ReminderId) : IDomainEvent;
}