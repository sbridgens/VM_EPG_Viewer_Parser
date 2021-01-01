﻿// <auto-generated />
using System;
using Infrastructure.DataAccess.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class EPG_dataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.EpgScheduleFileHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EpgArchiveLocation")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<DateTime>("EpgDateTimeArchived")
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("EpgDateTimeParsed")
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("EpgDateTimeRetrieved")
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("EpgExtractedFileSize")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("EpgFilenameExtracted")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("EpgFilenameGz")
                        .IsRequired()
                        .HasColumnName("EpgFilenameGZ")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("EpgOriginalFileSize")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("id_UNIQUE");

                    b.ToTable("EpgScheduleFileHistory");
                });

            modelBuilder.Entity("Domain.Entities.GroupInformationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GidConnectorId")
                        .IsRequired()
                        .HasColumnName("Gid_ConnectorId")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("GidCreditsList")
                        .HasColumnName("Gid_CreditsList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GidGenres")
                        .HasColumnName("Gid_Genres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GidGroupId")
                        .IsRequired()
                        .HasColumnName("Gid_GroupId")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("GidLanguage")
                        .HasColumnName("Gid_Language")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("GidProductionYear")
                        .HasColumnName("Gid_ProductionYear")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("GidRowChanges")
                        .HasColumnName("Gid_RowChanges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GidSeriesCrid")
                        .IsRequired()
                        .HasColumnName("Gid_SeriesCrid")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("GidSeriesId")
                        .IsRequired()
                        .HasColumnName("Gid_SeriesId")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("GidSeriesImages")
                        .IsRequired()
                        .HasColumnName("Gid_SeriesImages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GidSeriesNumber")
                        .IsRequired()
                        .HasColumnName("Gid_SeriesNumber")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("GidSeriesTitle")
                        .IsRequired()
                        .HasColumnName("Gid_SeriesTitle")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("GidSynopsis")
                        .IsRequired()
                        .HasColumnName("Gid_Synopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GidType")
                        .IsRequired()
                        .HasColumnName("Gid_Type")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("groupid_UNIQUE");

                    b.ToTable("GroupInformationData");
                });

            modelBuilder.Entity("Domain.Entities.ProgramInformationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PidCreditsList")
                        .HasColumnName("Pid_CreditsList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PidCrid")
                        .IsRequired()
                        .HasColumnName("Pid_Crid")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("PidEpisodeNumber")
                        .HasColumnName("Pid_EpisodeNumber")
                        .HasColumnType("varchar(4)")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("PidEpisodeTitle")
                        .HasColumnName("Pid_EpisodeTitle")
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120)
                        .IsUnicode(false);

                    b.Property<string>("PidImdbId")
                        .HasColumnName("Pid_ImdbId")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("PidParentalGuidance")
                        .HasColumnName("Pid_ParentalGuidance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PidProductionLocation")
                        .HasColumnName("Pid_ProductionLocation")
                        .HasColumnType("varchar(4)")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("PidProductionYear")
                        .HasColumnName("Pid_ProductionYear")
                        .HasColumnType("varchar(4)")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("PidProgramGenres")
                        .HasColumnName("Pid_ProgramGenres")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<string>("PidProgramImages")
                        .IsRequired()
                        .HasColumnName("Pid_ProgramImages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PidRootId")
                        .IsRequired()
                        .HasColumnName("Pid_RootId")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("PidRowChanges")
                        .HasColumnName("Pid_RowChanges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PidSeriesLink")
                        .HasColumnName("Pid_SeriesLink")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("PidSynopsisLong")
                        .HasColumnName("Pid_SynopsisLong")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<string>("PidSynopsisMedium")
                        .HasColumnName("Pid_SynopsisMedium")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("PidSynopsisShort")
                        .HasColumnName("Pid_SynopsisShort")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("PidTitleMain")
                        .IsRequired()
                        .HasColumnName("Pid_TitleMain")
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120)
                        .IsUnicode(false);

                    b.Property<string>("PidTmsId")
                        .IsRequired()
                        .HasColumnName("Pid_TmsId")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("programInformationId_UNIQUE");

                    b.ToTable("ProgramInformationData");
                });

            modelBuilder.Entity("Domain.Entities.ProgramScheduleData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PsdAvAttributes")
                        .HasColumnName("Psd_AV_Attributes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PsdCaptionLanguage")
                        .HasColumnName("Psd_CaptionLanguage")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("PsdEventDuration")
                        .IsRequired()
                        .HasColumnName("Psd_EventDuration")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("PsdProgramCrid")
                        .IsRequired()
                        .HasColumnName("Psd_ProgramCrid")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("PsdProgramImi")
                        .IsRequired()
                        .HasColumnName("Psd_ProgramImi")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("PsdPurchaseList")
                        .HasColumnName("Psd_PurchaseList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PsdRowChange")
                        .HasColumnName("Psd_RowChange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PsdScheduleDuration")
                        .IsRequired()
                        .HasColumnName("Psd_ScheduleDuration")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<DateTime>("PsdScheduleEnd")
                        .HasColumnName("Psd_ScheduleEnd")
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("PsdScheduleStart")
                        .HasColumnName("Psd_ScheduleStart")
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("PsdScheduledEndTime")
                        .HasColumnName("Psd_ScheduledEndTime")
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("PsdScheduledStartTime")
                        .HasColumnName("Psd_ScheduledStartTime")
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("PsdServiceIdReference")
                        .IsRequired()
                        .HasColumnName("Psd_ServiceIdReference")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("PsdTmsId")
                        .IsRequired()
                        .HasColumnName("Psd_TmsId")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("programScheduleId_UNIQUE");

                    b.ToTable("ProgramScheduleData");
                });

            modelBuilder.Entity("Domain.Entities.ServiceInformationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SidChannelResolution")
                        .IsRequired()
                        .HasColumnName("Sid_ChannelResolution")
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("SidEpgServiceId")
                        .IsRequired()
                        .HasColumnName("Sid_Epg_ServiceId")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("SidRowChanges")
                        .HasColumnName("Sid_RowChanges")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("SidServiceLogo")
                        .IsRequired()
                        .HasColumnName("Sid_ServiceLogo")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("SidServiceName")
                        .HasColumnName("Sid_ServiceName")
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("SidVmServiceGroup")
                        .IsRequired()
                        .HasColumnName("Sid_VM_ServiceGroup")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("SidVmServiceId")
                        .IsRequired()
                        .HasColumnName("Sid_VM_ServiceId")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("serviceInformationId_UNIQUE");

                    b.ToTable("ServiceInformationData");
                });
#pragma warning restore 612, 618
        }
    }
}
