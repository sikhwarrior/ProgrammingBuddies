using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using ProgrammingBuddies.Application.Authentication.Queries.Login;
using ProgrammingBuddies.Application.Tokens.Queries.Generate;
using ProgrammingBuddies.Contracts.Common;
using ProgrammingBuddies.Contracts.Tokens;

using DomainSubscriptionType = ProgrammingBuddies.Domain.Users.SubscriptionType;

namespace ProgrammingBuddies.Api.Controllers
{
    [Route("tokens")]
    [AllowAnonymous]
    public class TokensController(ISender _mediator) : ApiController
    {
        [HttpPost("generate")]
        public async Task<IActionResult> GenerateToken(GenerateTokenRequest request)
        {
            if (!DomainSubscriptionType.TryFromName(request.SubscriptionType.ToString(), out var plan))
            {
                return Problem(
                    statusCode: StatusCodes.Status400BadRequest,
                    detail: "Invalid subscription type");
            }

            var query = new GenerateTokenQuery(
                request.Id,
                request.FirstName,
                request.LastName,
                request.Email,
                plan,
                request.Permissions,
                request.Roles);

            var result = await _mediator.Send(query);

            return result.Match(
                generateTokenResult => Ok(ToDto(generateTokenResult)),
                Problem);
        }

        private static TokenResponse ToDto(GenerateTokenResult authResult)
        {
            return new TokenResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                ToDto(authResult.SubscriptionType),
                authResult.Token);
        }

        private static SubscriptionType ToDto(DomainSubscriptionType subscriptionType) =>
            subscriptionType.Name switch
            {
                nameof(DomainSubscriptionType.Basic) => SubscriptionType.Basic,
                nameof(DomainSubscriptionType.Pro) => SubscriptionType.Pro,
                _ => throw new InvalidOperationException(),
            };
    }
}