using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Permissions;
using ProgrammingBuddies.Application.Common.Security.Policies;
using ProgrammingBuddies.Application.Common.Security.Request;

namespace ProgrammingBuddies.Application.Reminders.Commands.DismissReminder
{
    [Authorize(Permissions = Permission.Reminder.Dismiss, Policies = Policy.SelfOrAdmin)]
    public record DismissReminderCommand(Guid UserId, Guid SubscriptionId, Guid ReminderId)
        : IAuthorizeableRequest<ErrorOr<Success>>;
}