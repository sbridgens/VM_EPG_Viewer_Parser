using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        //
        // dotnet ef migrations add Initial --context "Infrastructure.DataAccess.Persistence.Contexts.EPG_dataContext"
        // -o "Migrations"
        // --project Infrastructure
        // --startup-project VM_EPG_PARSER
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EpgScheduleFileHistory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpgFilenameGZ = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    EpgFilenameExtracted = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    EpgOriginalFileSize = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    EpgExtractedFileSize = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    EpgDateTimeRetrieved = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    EpgDateTimeParsed = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    EpgDateTimeArchived = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    EpgArchiveLocation = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpgScheduleFileHistory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GroupInformationData",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gid_GroupId = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Gid_ConnectorId = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Gid_Type = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Gid_SeriesTitle = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Gid_SeriesId = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Gid_SeriesNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Gid_SeriesCrid = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Gid_Synopsis = table.Column<string>(nullable: false),
                    Gid_Genres = table.Column<string>(nullable: true),
                    Gid_Language = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Gid_CreditsList = table.Column<string>(nullable: true),
                    Gid_SeriesImages = table.Column<string>(nullable: false),
                    Gid_ProductionYear = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    Gid_RowChanges = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupInformationData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramInformationData",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pid_Crid = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Pid_TmsId = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Pid_RootId = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Pid_ImdbId = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Pid_SeriesLink = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    Pid_EpisodeNumber = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Pid_TitleMain = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    Pid_EpisodeTitle = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    Pid_SynopsisShort = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Pid_SynopsisMedium = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Pid_SynopsisLong = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    Pid_ProgramGenres = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    Pid_ParentalGuidance = table.Column<string>(nullable: true),
                    Pid_CreditsList = table.Column<string>(nullable: true),
                    Pid_ProgramImages = table.Column<string>(nullable: false),
                    Pid_ProductionYear = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Pid_ProductionLocation = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Pid_RowChanges = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramInformationData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramScheduleData",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Psd_ServiceIdReference = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Psd_ScheduleStart = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    Psd_ScheduleEnd = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    Psd_ScheduleDuration = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Psd_ProgramCrid = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Psd_ProgramImi = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Psd_PurchaseList = table.Column<string>(nullable: true),
                    Psd_CaptionLanguage = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Psd_AV_Attributes = table.Column<string>(nullable: true),
                    Psd_TmsId = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Psd_ScheduledStartTime = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    Psd_ScheduledEndTime = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    Psd_EventDuration = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Psd_RowChange = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramScheduleData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceInformationData",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sid_ServiceName = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    Sid_VM_ServiceId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Sid_Epg_ServiceId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Sid_ServiceLogo = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    Sid_ChannelResolution = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    Sid_VM_ServiceGroup = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    Sid_RowChanges = table.Column<string>(unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceInformationData", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "EpgScheduleFileHistory",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "groupid_UNIQUE",
                table: "GroupInformationData",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "programInformationId_UNIQUE",
                table: "ProgramInformationData",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "programScheduleId_UNIQUE",
                table: "ProgramScheduleData",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "serviceInformationId_UNIQUE",
                table: "ServiceInformationData",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EpgScheduleFileHistory");

            migrationBuilder.DropTable(
                name: "GroupInformationData");

            migrationBuilder.DropTable(
                name: "ProgramInformationData");

            migrationBuilder.DropTable(
                name: "ProgramScheduleData");

            migrationBuilder.DropTable(
                name: "ServiceInformationData");
        }
    }
}
