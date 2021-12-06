using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ThinkSites.Authorization.Roles;
using ThinkSites.Authorization.Users;
using ThinkSites.MultiTenancy;

namespace ThinkSites.EntityFrameworkCore
{
    public class ThinkSitesDbContext : AbpZeroDbContext<Tenant, Role, User, ThinkSitesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ThinkSitesDbContext(DbContextOptions<ThinkSitesDbContext> options)
            : base(options)
        {
        }
    }
}
