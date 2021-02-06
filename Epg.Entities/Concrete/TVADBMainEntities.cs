using System;
using System.Collections.Generic;
using System.Text;

namespace Epg.Entities.Concrete
{
    public class TVADBMainEntities
    {
        public EpgScheduleFileHistoryEntities ScheduleFileHistory = new EpgScheduleFileHistoryEntities();
        public List<ProgramInformationDataEntities> Programs = new List<ProgramInformationDataEntities>();
        public List<GroupInformationDataEntities> Groups = new List<GroupInformationDataEntities>();
        public List<ProgramScheduleDataEntities> ProgramSchedules = new List<ProgramScheduleDataEntities>();
        public List<ServiceInformationDataEntities> Services = new List<ServiceInformationDataEntities>();
    }
}
