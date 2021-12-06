using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ThinkSites.EntityFrameworkCore
{
    public static class ThinkSitesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ThinkSitesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ThinkSitesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
