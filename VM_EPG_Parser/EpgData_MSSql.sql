USE [EPG_data]
GO
/****** Object:  Table [dbo].[EpgScheduleFileHistory]    Script Date: 13-12-2020 10:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EpgScheduleFileHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EpgFilenameGZ] [varchar](45) NOT NULL,
	[EpgFilenameExtracted] [varchar](45) NOT NULL,
	[EpgOriginalFileSize] [varchar](10) NOT NULL,
	[EpgExtractedFileSize] [varchar](10) NOT NULL,
	[EpgDateTimeRetrieved] [datetime2](0) NOT NULL,
	[EpgDateTimeParsed] [datetime2](0) NOT NULL,
	[EpgDateTimeArchived] [datetime2](0) NOT NULL,
	[EpgArchiveLocation] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupInformationData]    Script Date: 13-12-2020 10:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupInformationData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Gid_GroupId] [varchar](45) NOT NULL,
	[Gid_ConnectorId] [varchar](20) NOT NULL,
	[Gid_Type] [varchar](45) NOT NULL,
	[Gid_SeriesTitle] [varchar](45) NOT NULL,
	[Gid_SeriesId] [varchar](15) NOT NULL,
	[Gid_SeriesNumber] [varchar](15) NOT NULL,
	[Gid_SeriesCrid] [varchar](45) NOT NULL,
	[Gid_Synopsis] [nvarchar](max) NOT NULL,
	[Gid_Genres] [nvarchar](max) NULL,
	[Gid_Language] [varchar](5) NULL,
	[Gid_CreditsList] [nvarchar](max) NULL,
	[Gid_SeriesImages] [nvarchar](max) NOT NULL,
	[Gid_ProductionYear] [varchar](45) NULL,
	[Gid_RowChanges] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramInformationData]    Script Date: 13-12-2020 10:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramInformationData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Pid_Crid] [varchar](45) NOT NULL,
	[Pid_TmsId] [varchar](45) NOT NULL,
	[Pid_RootId] [varchar](45) NOT NULL,
	[Pid_ImdbId] [varchar](15) NULL,
	[Pid_SeriesLink] [varchar](45) NULL,
	[Pid_EpisodeNumber] [varchar](4) NULL,
	[Pid_TitleMain] [varchar](120) NOT NULL,
	[Pid_EpisodeTitle] [varchar](120) NULL,
	[Pid_SynopsisShort] [varchar](250) NULL,
	[Pid_SynopsisMedium] [varchar](500) NULL,
	[Pid_SynopsisLong] [varchar](1000) NULL,
	[Pid_ProgramGenres] [varchar](1000) NULL,
	[Pid_ParentalGuidance] [nvarchar](max) NULL,
	[Pid_CreditsList] [nvarchar](max) NULL,
	[Pid_ProgramImages] [nvarchar](max) NOT NULL,
	[Pid_ProductionYear] [varchar](4) NULL,
	[Pid_ProductionLocation] [varchar](4) NULL,
	[Pid_RowChanges] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramScheduleData]    Script Date: 13-12-2020 10:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramScheduleData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Psd_ServiceIdReference] [varchar](10) NOT NULL,
	[Psd_ScheduleStart] [datetime2](0) NOT NULL,
	[Psd_ScheduleEnd] [datetime2](0) NOT NULL,
	[Psd_ScheduleDuration] [varchar](5) NOT NULL,
	[Psd_ProgramCrid] [varchar](45) NOT NULL,
	[Psd_ProgramImi] [varchar](20) NOT NULL,
	[Psd_PurchaseList] [nvarchar](max) NULL,
	[Psd_CaptionLanguage] [varchar](5) NULL,
	[Psd_AV_Attributes] [nvarchar](max) NULL,
	[Psd_TmsId] [varchar](20) NOT NULL,
	[Psd_ScheduledStartTime] [datetime2](0) NOT NULL,
	[Psd_ScheduledEndTime] [datetime2](0) NOT NULL,
	[Psd_EventDuration] [varchar](10) NOT NULL,
	[Psd_RowChange] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceInformationData]    Script Date: 13-12-2020 10:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceInformationData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Sid_ServiceName] [varchar](45) NULL,
	[Sid_VM_ServiceId] [varchar](10) NOT NULL,
	[Sid_Epg_ServiceId] [varchar](10) NOT NULL,
	[Sid_ServiceLogo] [varchar](250) NOT NULL,
	[Sid_ChannelResolution] [varchar](3) NOT NULL,
	[Sid_VM_ServiceGroup] [varchar](250) NOT NULL,
	[Sid_RowChanges] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GroupInformationData] ON 
GO
INSERT [dbo].[GroupInformationData] ([id], [Gid_GroupId], [Gid_ConnectorId], [Gid_Type], [Gid_SeriesTitle], [Gid_SeriesId], [Gid_SeriesNumber], [Gid_SeriesCrid], [Gid_Synopsis], [Gid_Genres], [Gid_Language], [Gid_CreditsList], [Gid_SeriesImages], [Gid_ProductionYear], [Gid_RowChanges]) VALUES (1, N'crid://gn.tv/10975868/SH012608630000', N'SH012608630000', N'series', N'New Tricks', N'451597', N'11', N'crid://gn.tv/451597/SH012608630000', N'[{"short": "Season 11 of `New Tricks returns to the Unsolved Crime and Open Case Squad, now lead by DCI Sasha Miller. Sasha finds herself forced to work alongside her ex-husband as the team investigate more unsolved crimes including the murder of a schoolgirl."}]', NULL, N'en', NULL, N'[{"imageUri": "file:///p10975868_i_h12_aa.jpg", "imageType": "High Res Landscape"]', N'2014', NULL)
GO
SET IDENTITY_INSERT [dbo].[GroupInformationData] OFF
GO
SET IDENTITY_INSERT [dbo].[ProgramInformationData] ON 
GO
INSERT [dbo].[ProgramInformationData] ([id], [Pid_Crid], [Pid_TmsId], [Pid_RootId], [Pid_ImdbId], [Pid_SeriesLink], [Pid_EpisodeNumber], [Pid_TitleMain], [Pid_EpisodeTitle], [Pid_SynopsisShort], [Pid_SynopsisMedium], [Pid_SynopsisLong], [Pid_ProgramGenres], [Pid_ParentalGuidance], [Pid_CreditsList], [Pid_ProgramImages], [Pid_ProductionYear], [Pid_ProductionLocation], [Pid_RowChanges]) VALUES (1, N'crid://gn.tv/11152768/EP012608630122', N'EP012608630122', N'11152768', N'11152768', N'crid://gn.tv/10975868/SH012608630000', N'10', N'New Tricks', N'The Queen''s Speech', N'A tape from 1983 is discovered containing the voice of a girl who was murdered shortly after it went into her school''s time capsule. Griffin is convinced that the girl is reading from a speech prepared for the Queen to broadcast during a nuclear war.', N'A tape from 1983 is discovered containing the voice of a girl who was murdered shortly after it went into her school''s time capsule. Griffin is convinced that the girl is reading from a speech prepared for the Queen to broadcast during a nuclear war', N'A tape from 1983 is discovered containing the voice of a girl who was murdered shortly after it went into her school''s time capsule. Griffin is convinced that the girl is reading from a speech prepared for the Queen to broadcast during a nuclear war.', N'Crime Drama,Comedy,Mystery', NULL, N'[{"idRef": "75619", "lastname": "Lawson", "firstname": "Denis", "characterName": "Steve McAndrew"}, {"idRef": "16464", "lastname": "Waterman", "firstname": "Dennis", "characterName": "Gerry Standing"}, {"idRef": "133533", "lastname": "Lyndhurst", "firstname": "Nicholas", "characterName": "Danny Griffin"}, {"idRef": "321907", "lastname": "Outhwaite", "firstname": "Tamzin", "characterName": "DCI Sasha Miller"}]', N'[{"imageUri": "file:///p451597_b_v8_av.jpg", "imageType": "High Res Portrait"}, {"imageUri": "file:///p11152768_e_h10_aa.jpg", "imageType": "HighRes Landscape Production Still"}, {"imageUri": "file:///p451597_ttn_h95_aa.png", "imageType": "Title Treatment"}]', N'2014', N'GB', NULL)
GO
SET IDENTITY_INSERT [dbo].[ProgramInformationData] OFF
GO
SET IDENTITY_INSERT [dbo].[ProgramScheduleData] ON 
GO
INSERT [dbo].[ProgramScheduleData] ([id], [Psd_ServiceIdReference], [Psd_ScheduleStart], [Psd_ScheduleEnd], [Psd_ScheduleDuration], [Psd_ProgramCrid], [Psd_ProgramImi], [Psd_PurchaseList], [Psd_CaptionLanguage], [Psd_AV_Attributes], [Psd_TmsId], [Psd_ScheduledStartTime], [Psd_ScheduledEndTime], [Psd_EventDuration], [Psd_RowChange]) VALUES (1, N'75803', CAST(N'2020-08-10T00:00:00.0000000' AS DateTime2), CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), N'15', N'crid="crid://gn.tv/11152768/EP012608630122"', N'imi:33105689', N'[{"PriceValue": "0", "PurchaseType": "urn:libertyglobal:metadata:cs:PurchaseTypeCS:2013:OTTMarker", "PriceCurrency": "EUR", "PurchaseDescription": "[OTTMarker.Data]RecordType=nDVR;PlayBackLicense=Onnet"}, {"PriceValue": "0", "PurchaseType": "urn:eventis:metadata:cs:PurchaseTypeCS:2013:TSTVMarker", "PriceCurrency": "EUR", "PurchaseDescription": "[TSTVMarker.Data]TemplateAdd=REPLAY;TemplateAdd=STARTOVER"}]', N'en', N'{"AVAttributes": {"AudioAttributes": [{"MixType": {"Name": {"lang": "en", "text": "Stereo"}, "href": "urn:eventis:metadata:cs:AudioPresentationCS:2010:3", "Definition": {"lang": "en", "text": "Stereographic sound"}}}, {"AudioLanguage": {"text": "en", "purpose": "urn:tva:metadata:cs:AudioPurposeCS:2007:6"}}, {"AudioLanguage": {"text": "en", "purpose": "urn:tva:metadata:cs:AudioPurposeCS:2007:1", "supplemental": "true"}}]}}', N'EP012608630122', CAST(N'2020-08-10T10:00:00.0000000' AS DateTime2), CAST(N'2020-08-10T11:00:00.0000000' AS DateTime2), N'PT01H00M', NULL)
GO
SET IDENTITY_INSERT [dbo].[ProgramScheduleData] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceInformationData] ON 
GO
INSERT [dbo].[ServiceInformationData] ([id], [Sid_ServiceName], [Sid_VM_ServiceId], [Sid_Epg_ServiceId], [Sid_ServiceLogo], [Sid_ChannelResolution], [Sid_VM_ServiceGroup], [Sid_RowChanges]) VALUES (1, N'Alibi HD', N'1600', N'75803', N'https://staticqbr-gb-prod.prod.cdn.dmdsdp.com/image-service/ImagesEPG/EventImages/alibi-hd.png', N'HD', N'crid://dtv.gb/sg/NGTV_HD_XL_Pack_(Tier_5),crid://dtv.gb/sg/NGTV_Drama_Pack_2019', NULL)
GO
SET IDENTITY_INSERT [dbo].[ServiceInformationData] OFF
GO
/****** Object:  Index [id_UNIQUE]    Script Date: 13-12-2020 10:59:49 ******/
ALTER TABLE [dbo].[EpgScheduleFileHistory] ADD  CONSTRAINT [id_UNIQUE] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [groupid_UNIQUE]    Script Date: 13-12-2020 10:59:49 ******/
ALTER TABLE [dbo].[GroupInformationData] ADD  CONSTRAINT [groupid_UNIQUE] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [programInformationId_UNIQUE]    Script Date: 13-12-2020 10:59:49 ******/
ALTER TABLE [dbo].[ProgramInformationData] ADD  CONSTRAINT [programInformationId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [programScheduleId_UNIQUE]    Script Date: 13-12-2020 10:59:49 ******/
ALTER TABLE [dbo].[ProgramScheduleData] ADD  CONSTRAINT [programScheduleId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [serviceInformationId_UNIQUE]    Script Date: 13-12-2020 10:59:49 ******/
ALTER TABLE [dbo].[ServiceInformationData] ADD  CONSTRAINT [serviceInformationId_UNIQUE] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GroupInformationData] ADD  DEFAULT (NULL) FOR [Gid_Genres]
GO
ALTER TABLE [dbo].[GroupInformationData] ADD  DEFAULT (NULL) FOR [Gid_Language]
GO
ALTER TABLE [dbo].[GroupInformationData] ADD  DEFAULT (NULL) FOR [Gid_CreditsList]
GO
ALTER TABLE [dbo].[GroupInformationData] ADD  DEFAULT (NULL) FOR [Gid_ProductionYear]
GO
ALTER TABLE [dbo].[GroupInformationData] ADD  DEFAULT (NULL) FOR [Gid_RowChanges]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_ImdbId]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_SeriesLink]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_EpisodeNumber]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_EpisodeTitle]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_SynopsisShort]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_SynopsisMedium]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_SynopsisLong]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_ProgramGenres]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_ParentalGuidance]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_CreditsList]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_ProductionYear]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_ProductionLocation]
GO
ALTER TABLE [dbo].[ProgramInformationData] ADD  DEFAULT (NULL) FOR [Pid_RowChanges]
GO
ALTER TABLE [dbo].[ProgramScheduleData] ADD  DEFAULT (NULL) FOR [Psd_PurchaseList]
GO
ALTER TABLE [dbo].[ProgramScheduleData] ADD  DEFAULT (NULL) FOR [Psd_CaptionLanguage]
GO
ALTER TABLE [dbo].[ProgramScheduleData] ADD  DEFAULT (NULL) FOR [Psd_AV_Attributes]
GO
ALTER TABLE [dbo].[ProgramScheduleData] ADD  DEFAULT (NULL) FOR [Psd_RowChange]
GO
ALTER TABLE [dbo].[ServiceInformationData] ADD  DEFAULT (NULL) FOR [Sid_ServiceName]
GO
ALTER TABLE [dbo].[ServiceInformationData] ADD  DEFAULT (NULL) FOR [Sid_RowChanges]
GO
