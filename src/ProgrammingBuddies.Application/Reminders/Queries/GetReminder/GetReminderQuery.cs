using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Permissions;
using ProgrammingBuddies.Application.Common.Security.Policies;
using ProgrammingBuddies.Application.Common.Security.Request;
using ProgrammingBuddies.Domain.Reminders;

namespace ProgrammingBuddies.Application.Reminders.Queries.GetReminder
{
    [Authorize(Permissions = Permission.Reminder.Get, Policies = Policy.SelfOrAdmin)]
    public record GetReminderQuery(Guid UserId, Guid SubscriptionId, Guid ReminderId) : IAuthorizeableRequest<ErrorOr<Reminder>>;
}