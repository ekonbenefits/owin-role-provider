using Owin;

namespace OwinRoleProviderMiddleware
{
    public static class AppBuilderExtensions
    {
        public static IAppBuilder UseOwinRoleProvider( this IAppBuilder app, IRoleProvider provider )
        {
            app.Use<OwinRoleProviderMiddleware>( provider );
            return app;
        }
    }
}
