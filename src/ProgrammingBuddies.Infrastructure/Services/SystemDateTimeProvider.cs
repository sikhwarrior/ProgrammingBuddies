using ProgrammingBuddies.Application.Common.Interfaces;

namespace ProgrammingBuddies.Infrastructure.Services
{
    public class SystemDateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
