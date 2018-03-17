using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Auth_from_scratch.DataAccess
{
    public class Context : IdentityDbContext
    {
        public Context()
            : base("DefaultConnection")
        {

        }

        public static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUser>().ToTable("Usuario").Property(x => x.UserName).HasColumnName("UsuarioNombre");

            modelBuilder.Ignore<IdentityUserRole>();
            modelBuilder.Ignore<IdentityUserLogin>();
            modelBuilder.Ignore<IdentityUserClaim>();
            modelBuilder.Ignore<IdentityRole>();
        }
    }
}