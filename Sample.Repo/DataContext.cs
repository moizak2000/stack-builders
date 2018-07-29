using Microsoft.EntityFrameworkCore;
using Sample.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Repo
{
   public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


        public override int SaveChanges()
        {
            //TrackChanges();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            //TrackChanges();
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
