using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancellationTokenApp.Desktop.Data
{
    public class MyDbContext : DbContext
    {
        DbSet<EmailModel> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailModel>(user =>
            {
                user.Property(i => i.Id).HasValueGenerator<InMemoryIntegerValueGenerator<Guid>>();
            });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("InMemoryDbName");
            }
        }


        public async Task<IEnumerable<EmailModel>> GetAllMails(CancellationToken token)
        {
            var list = await Emails
                .Where(i => i.WaitingForSent)
                .ToListAsync(token);

            await Task.Delay(20000, token);

            return list;
        }
    }
}
