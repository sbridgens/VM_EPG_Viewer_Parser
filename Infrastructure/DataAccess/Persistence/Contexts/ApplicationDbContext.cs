using System;
using System.Reflection;
using Application.DataAccess.Persistence.Contracts;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess.Persistence.Contexts
{
    public partial class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        {
        }

        public virtual DbSet<EpgScheduleFileHistory> DbSetEpgScheduleFileHistory { get; set; }
        public virtual DbSet<GroupInformationData> DbSetGroupInformationData { get; set; }
        public virtual DbSet<ProgramInformationData> DbSetProgramInformationData { get; set; }
        public virtual DbSet<ProgramScheduleData> DbSetProgramScheduleData { get; set; }
        public virtual DbSet<ServiceInformationData> DbSetServiceInformationData { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    $"Server=.,1433;" +
                    $"Database=EPG_data;" +
                    $"Trusted_Connection=True;",
                    opts => 
                        opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}