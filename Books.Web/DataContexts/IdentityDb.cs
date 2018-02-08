using Books.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Books.Web.DataContexts
{
    // PM> get-help entityframework
    // PM> get-help enable-migrations
    // PM> Enable-Migrations -ContextTypeName Books.Web.DataContexts.IdentityDb -MigrationsDirectory DataContexts\IdentityMigrations
    // PM> get-help add-migration
    // PM> Add-Migration -Name InitialCreate -ConfigurationTypeName Books.Web.DataContexts.IdentityMigrations.Configuration
    // PM> get-help update-database
    // PM> Update-Database -ConfigurationTypeName Books.Web.DataContexts.IdentityMigrations.Configuration
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}
