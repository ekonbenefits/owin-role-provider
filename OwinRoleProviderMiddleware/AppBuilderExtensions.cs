using Owin;

namespace OwinRoleProviderMiddleware
{
    public static class JsRoleProviderExtensions
    {
        public static IAppBuilder UseJsRoleProvider( this IAppBuilder app, IRoleProvider provider )
        {
            app.Use<OwinRoleProviderMiddleware>( provider );
            return app;
        }
    }
}
