using System.Collections.Generic;
using System.Threading.Tasks;

namespace OwinRoleProviderMiddleware
{
    public interface IRoleProvider
    {
        Task<IEnumerable<string>> GetRolesForUser( string identifier );
    }
}
