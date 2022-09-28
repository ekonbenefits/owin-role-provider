using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;

namespace OwinRoleProviderMiddleware
{
    public interface IRoleProvider
    {
        Task<IEnumerable<string>> GetRolesForUser( IPrincipal principal );
    }
}
