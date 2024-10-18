using ErrorOr;

using MediatR;

using ProgrammingBuddies.Application.Common.Interfaces;
using ProgrammingBuddies.Application.Subscriptions.Common;
using ProgrammingBuddies.Domain.Users;

namespace ProgrammingBuddies.Application.Subscriptions.Queries.GetSubscription
{
    public class GetSubscriptionQueryHandler(IUsersRepository _usersRepository)
        : IRequestHandler<GetSubscriptionQuery, ErrorOr<SubscriptionResult>>
    {
        public async Task<ErrorOr<SubscriptionResult>> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
        {
            return await _usersRepository.GetByIdAsync(request.UserId, cancellationToken) is User user
                ? SubscriptionResult.FromUser(user)
                : Error.NotFound(description: "Subscription not found.");
        }
    }
}
