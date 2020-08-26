using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace alpha.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            // Shorten key length for Identity
			builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser>(entity => entity.Property(m => m.Id).HasMaxLength(127));
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser>(entity => entity.Property(m => m.UserName).HasMaxLength(191));
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(191));
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser>(entity => entity.Property(m => m.Email).HasMaxLength(191));
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(191));
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityRole>(entity => entity.Property(m => m.Name).HasMaxLength(191));
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(191));  
        }
    }
}
