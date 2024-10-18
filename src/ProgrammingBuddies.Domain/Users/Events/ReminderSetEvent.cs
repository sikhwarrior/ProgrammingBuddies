using ProgrammingBuddies.Domain.Common;
using ProgrammingBuddies.Domain.Reminders;

namespace ProgrammingBuddies.Domain.Users.Events
{
    public record ReminderSetEvent(Reminder Reminder) : IDomainEvent;
}