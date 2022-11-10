using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using real_time_chat.Models;


namespace real_time_chat.Data
{
    public class DataDbContext : IdentityDbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options):base(options)
        {
        }
        public DbSet<AppUser> AppUsers;
        public DbSet<Message> Messages;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>().HasOne<AppUser>(x => x.Sender).WithMany(y => y.Messages).HasForeignKey(x => x.UserId);
        }
    }
}
