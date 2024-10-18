using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Permissions;
using ProgrammingBuddies.Application.Common.Security.Policies;
using ProgrammingBuddies.Application.Common.Security.Request;
using ProgrammingBuddies.Domain.Reminders;

namespace ProgrammingBuddies.Application.Reminders.Queries.ListReminders
{
    [Authorize(Permissions = Permission.Reminder.Get, Policies = Policy.SelfOrAdmin)]
    public record ListRemindersQuery(Guid UserId, Guid SubscriptionId) : IAuthorizeableRequest<ErrorOr<List<Reminder>>>;
}