using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NewsAdMS.Entity;


namespace NewsAdMS.DAL.Data
{
    internal class AdvDbContext : DbContext
    {
        public AdvDbContext (DbContextOptions<AdvDbContext>options) : base(options)
        {

        }
        public DbSet<UserDetails> users { get; set; }
        public DbSet<AdvertisementDetails> advertisements { get; set; }
    }
}
