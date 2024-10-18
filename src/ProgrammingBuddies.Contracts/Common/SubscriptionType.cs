using System.Text.Json.Serialization;

namespace ProgrammingBuddies.Contracts.Common
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubscriptionType
    {
        Basic,
        Pro,
    }
}