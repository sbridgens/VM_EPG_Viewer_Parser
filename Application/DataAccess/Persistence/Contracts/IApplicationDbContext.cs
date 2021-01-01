using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Application.DataAccess.Persistence.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<EpgScheduleFileHistory> DbSetEpgScheduleFileHistory { get; set; }
        DbSet<GroupInformationData> DbSetGroupInformationData { get; set; }
        DbSet<ProgramInformationData> DbSetProgramInformationData { get; set; }
        DbSet<ProgramScheduleData> DbSetProgramScheduleData { get; set; }
        DbSet<ServiceInformationData> DbSetServiceInformationData { get; set; }
        int SaveChanges();
    }
}