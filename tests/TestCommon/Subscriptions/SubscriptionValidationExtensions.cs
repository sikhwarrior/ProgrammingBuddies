using FluentAssertions;

using ProgrammingBuddies.Application.Subscriptions.Commands.CreateSubscription;
using ProgrammingBuddies.Application.Subscriptions.Common;

namespace TestCommon.Subscriptions
{
    public static class SubscriptionValidationExtensions
    {
        public static void AssertCreatedFrom(this SubscriptionResult subscriptionType, CreateSubscriptionCommand command)
        {
            subscriptionType.SubscriptionType.Should().Be(command.SubscriptionType);
            subscriptionType.UserId.Should().Be(command.UserId);
        }
    }
}