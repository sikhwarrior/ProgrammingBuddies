using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Permissions;
using ProgrammingBuddies.Application.Common.Security.Policies;
using ProgrammingBuddies.Application.Common.Security.Request;

namespace ProgrammingBuddies.Application.Reminders.Commands.DeleteReminder
{
    [Authorize(Permissions = Permission.Reminder.Delete, Policies = Policy.SelfOrAdmin)]
    public record DeleteReminderCommand(Guid UserId, Guid SubscriptionId, Guid ReminderId)
        : IAuthorizeableRequest<ErrorOr<Success>>;
}