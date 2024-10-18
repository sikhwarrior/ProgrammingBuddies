using Microsoft.AspNetCore.Builder;

using ProgrammingBuddies.Infrastructure.Common.Middleware;

namespace ProgrammingBuddies.Infrastructure
{
    public static class RequestPipeline
    {
        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseMiddleware<EventualConsistencyMiddleware>();
            return app;
        }
    }
}