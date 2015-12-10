using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace OwinRoleProviderMiddleware
{
    public class OwinRoleProviderMiddleware : OwinMiddleware
    {
        private readonly IRoleProvider _provider;

        public OwinRoleProviderMiddleware( OwinMiddleware next, IRoleProvider provider )
            : base( next )
        {
            _provider = provider;
        }

        public override async Task Invoke( IOwinContext context )
        {
            var user = context.Request.User.Identity as ClaimsIdentity;
            if ( user != null && user.IsAuthenticated )
            {
                var roles = await _provider.GetRolesForUser( user.Name );
                var claims = roles.Select( r => new Claim( ClaimTypes.Role, r ) );
                user.AddClaims( claims );
            }
            await Next.Invoke( context );
        }
    }
}
