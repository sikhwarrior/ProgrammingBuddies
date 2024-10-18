using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Permissions;
using ProgrammingBuddies.Application.Common.Security.Policies;
using ProgrammingBuddies.Application.Common.Security.Request;
using ProgrammingBuddies.Domain.Reminders;

namespace ProgrammingBuddies.Application.Reminders.Commands.SetReminder
{
    [Authorize(Permissions = Permission.Reminder.Set, Policies = Policy.SelfOrAdmin)]
    public record SetReminderCommand(Guid UserId, Guid SubscriptionId, string Text, DateTime DateTime)
        : IAuthorizeableRequest<ErrorOr<Reminder>>;
}