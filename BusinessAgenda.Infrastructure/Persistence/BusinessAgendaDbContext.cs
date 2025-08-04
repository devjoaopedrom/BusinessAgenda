using System.Reflection.Emit;
using BusinessAgenda.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessAgenda.Infrastructure.Persistence
{
    public class BusinessAgendaDbContext : DbContext
    {
        public BusinessAgendaDbContext(DbContextOptions<BusinessAgendaDbContext> options)
            : base(options)
        {

        }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<User> Users{ get; private set; }
        public DbSet<Skill> Skills { get; private set; }
        public DbSet<Client> Clients { get; private set; }
        public DbSet<UserSkill> UserSkills { get; private set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Meeting>(e =>
                {
                    e.HasKey(m => m.Id);

                    e.HasOne(m => m.Client)
                     .WithMany()
                     .HasForeignKey(m => m.ClientId)
                     .OnDelete(DeleteBehavior.Restrict);

                    e.HasOne(m => m.Manager)
                     .WithMany(u => u.ManagerMeetings)
                     .HasForeignKey(m => m.ClientId)
                     .OnDelete(DeleteBehavior.Restrict);
                });

            builder
                .Entity<User>(e =>
                {
                    e.HasKey(u => u.Id);

                    e.HasMany(u => u.Skills)
                        .WithOne(us => us.User)
                        .HasForeignKey(us => us.IdUser)
                        .OnDelete(DeleteBehavior.Restrict);
                });

            builder
                .Entity<Agenda>(e =>
                {
                    e.HasKey(a => a.Id);

                    e.HasOne(a => a.User)
                      .WithOne(u => u.Agenda)
                      .HasForeignKey<Agenda>(a => a.UserId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Restrict);
                });
            builder
                .Entity<Skill>(e =>
                {
                    e.HasKey(s => s.Id);
                });
            builder
               .Entity<UserSkill>(e =>
               {
                   e.HasKey(us => us.Id);
                   e.HasOne(u => u.Skill)
                     .WithMany(u => u.UserSkills)
                     .HasForeignKey(s => s.IdSkill)
                     .OnDelete(DeleteBehavior.Restrict);
               });
            builder
              .Entity<Client>(e =>
              {
                  e.HasKey(c => c.Id);
              });

            base.OnModelCreating(builder);

            builder
                .Entity<MeetingComment>(e =>
            {
                e.HasKey(mc => mc.Id);

                e.HasOne(mc => mc.Meeting)
                    .WithMany(m => m.Comments)
                    .HasForeignKey(mc => mc.MeetingId);
            });
        }
    }
}
