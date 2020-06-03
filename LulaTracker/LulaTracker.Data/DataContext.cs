using LulaTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LulaTracker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<TicketComment> TicketComments { get; set; }
        public DbSet<TicketAttachment> TicketAttachments { get; set; }
    }
}