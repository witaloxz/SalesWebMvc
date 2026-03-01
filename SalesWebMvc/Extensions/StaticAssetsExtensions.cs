using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Builder
{
    public static class StaticAssetsExtensions
    {
        // Enables static file serving (wwwroot) and default files.
        public static WebApplication MapStaticAssets(this WebApplication app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            return app;
        }

        // No-op extension so route builders can be chained when project expects this method.
        public static ControllerActionEndpointConventionBuilder WithStaticAssets(this ControllerActionEndpointConventionBuilder builder)
        {
            return builder;
        }
    }
}
