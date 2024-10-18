using ErrorOr;

using ProgrammingBuddies.Application.Common.Security.Request;
using ProgrammingBuddies.Infrastructure.Security.CurrentUserProvider;

namespace ProgrammingBuddies.Infrastructure.Security.PolicyEnforcer
{
    public interface IPolicyEnforcer
    {
        public ErrorOr<Success> Authorize<T>(
            IAuthorizeableRequest<T> request,
            CurrentUser currentUser,
            string policy);
    }
}