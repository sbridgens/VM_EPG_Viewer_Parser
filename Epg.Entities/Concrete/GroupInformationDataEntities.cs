using System;
using Epg.Core.Entities;

namespace Epg.Entities.Concrete
{
    public class GroupInformationDataEntities : IEntity
    {
        public int Id { get; set; }
        public string Gid_GroupId { get; set; }

        public string Gid_ConnectorId { get; set; }

        public string Gid_Type { get; set; }

        public string Gid_SeriesTitle { get; set; }

        public string Gid_SeriesId { get; set; }

        public string Gid_SeriesNumber { get; set; }

        public string Gid_SeriesCrid { get; set; }

        public string Gid_Synopsis { get; set; }

        public string Gid_Genres { get; set; }

        public string Gid_Language { get; set; }

        public string Gid_CreditsList { get; set; }

        public string Gid_SeriesImages { get; set; }

        public string Gid_ProductionYear { get; set; }

        public string Gid_RowChanges { get; set; }
    }
}
