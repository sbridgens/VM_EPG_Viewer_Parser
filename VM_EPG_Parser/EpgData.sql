-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: vm_epg_data
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `epgschedulefilehistory`
--

DROP TABLE IF EXISTS `epgschedulefilehistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `epgschedulefilehistory` (
  `id` int NOT NULL AUTO_INCREMENT,
  `EpgFilenameGZ` varchar(45) NOT NULL,
  `EpgFilenameExtracted` varchar(45) NOT NULL,
  `EpgOriginalFileSize` varchar(10) NOT NULL,
  `EpgExtractedFileSize` varchar(10) NOT NULL,
  `EpgDateTimeRetrieved` datetime NOT NULL,
  `EpgDateTimeParsed` datetime NOT NULL,
  `EpgDateTimeArchived` datetime NOT NULL,
  `EpgArchiveLocation` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `epgschedulefilehistory`
--

LOCK TABLES `epgschedulefilehistory` WRITE;
/*!40000 ALTER TABLE `epgschedulefilehistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `epgschedulefilehistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `groupinformationdata`
--

DROP TABLE IF EXISTS `groupinformationdata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `groupinformationdata` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Gid_GroupId` varchar(45) NOT NULL,
  `Gid_ConnectorId` varchar(20) NOT NULL,
  `Gid_Type` varchar(45) NOT NULL,
  `Gid_SeriesTitle` varchar(45) NOT NULL,
  `Gid_SeriesId` varchar(15) NOT NULL,
  `Gid_SeriesNumber` varchar(15) NOT NULL,
  `Gid_SeriesCrid` varchar(45) NOT NULL,
  `Gid_Synopsis` json NOT NULL,
  `Gid_Genres` json DEFAULT NULL,
  `Gid_Language` varchar(5) DEFAULT NULL,
  `Gid_CreditsList` json DEFAULT NULL,
  `Gid_SeriesImages` json NOT NULL,
  `Gid_ProductionYear` varchar(45) DEFAULT NULL,
  `Gid_RowChanges` json DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groupinformationdata`
--

LOCK TABLES `groupinformationdata` WRITE;
/*!40000 ALTER TABLE `groupinformationdata` DISABLE KEYS */;
INSERT INTO `groupinformationdata` VALUES (1,'crid://gn.tv/10975868/SH012608630000','SH012608630000','series','New Tricks','451597','11','crid://gn.tv/451597/SH012608630000','[{\"short\": \"Season 11 of `New Tricks\' returns to the Unsolved Crime and Open Case Squad, now lead by DCI Sasha Miller. Sasha finds herself forced to work alongside her ex-husband as the team investigate more unsolved crimes including the murder of a schoolgirl.\"}]',NULL,'en',NULL,'[{\"imageUri\": \"file:///p10975868_i_h12_aa.jpg\", \"imageType\": \"High Res Landscape\"}]','2014',NULL);
/*!40000 ALTER TABLE `groupinformationdata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programinformationdata`
--

DROP TABLE IF EXISTS `programinformationdata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programinformationdata` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Pid_Crid` varchar(45) NOT NULL,
  `Pid_TmsId` varchar(45) NOT NULL,
  `Pid_RootId` varchar(45) NOT NULL,
  `Pid_ImdbId` varchar(15) DEFAULT NULL,
  `Pid_SeriesLink` varchar(45) DEFAULT NULL,
  `Pid_EpisodeNumber` varchar(4) DEFAULT NULL,
  `Pid_TitleMain` varchar(120) NOT NULL,
  `Pid_EpisodeTitle` varchar(120) DEFAULT NULL,
  `Pid_SynopsisShort` varchar(250) DEFAULT NULL,
  `Pid_SynopsisMedium` varchar(500) DEFAULT NULL,
  `Pid_SynopsisLong` varchar(1000) DEFAULT NULL,
  `Pid_ProgramGenres` varchar(1000) DEFAULT NULL,
  `Pid_ParentalGuidance` json DEFAULT NULL,
  `Pid_CreditsList` json DEFAULT NULL,
  `Pid_ProgramImages` json NOT NULL,
  `Pid_ProductionYear` varchar(4) DEFAULT NULL,
  `Pid_ProductionLocation` varchar(4) DEFAULT NULL,
  `Pid_RowChanges` json DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programinformationdata`
--

LOCK TABLES `programinformationdata` WRITE;
/*!40000 ALTER TABLE `programinformationdata` DISABLE KEYS */;
INSERT INTO `programinformationdata` VALUES (1,'crid://gn.tv/11152768/EP012608630122','EP012608630122','11152768','11152768','crid://gn.tv/10975868/SH012608630000','10','New Tricks','The Queen\'s Speech','A tape from 1983 is discovered containing the voice of a girl who was murdered shortly after it went into her school\'s time capsule. Griffin is convinced that the girl is reading from a speech prepared for the Queen to broadcast during a nuclear war.','A tape from 1983 is discovered containing the voice of a girl who was murdered shortly after it went into her school\'s time capsule. Griffin is convinced that the girl is reading from a speech prepared for the Queen to broadcast during a nuclear war','A tape from 1983 is discovered containing the voice of a girl who was murdered shortly after it went into her school\'s time capsule. Griffin is convinced that the girl is reading from a speech prepared for the Queen to broadcast during a nuclear war.','Crime Drama,Comedy,Mystery',NULL,'[{\"idRef\": \"75619\", \"lastname\": \"Lawson\", \"firstname\": \"Denis\", \"characterName\": \"Steve McAndrew\"}, {\"idRef\": \"16464\", \"lastname\": \"Waterman\", \"firstname\": \"Dennis\", \"characterName\": \"Gerry Standing\"}, {\"idRef\": \"133533\", \"lastname\": \"Lyndhurst\", \"firstname\": \"Nicholas\", \"characterName\": \"Danny Griffin\"}, {\"idRef\": \"321907\", \"lastname\": \"Outhwaite\", \"firstname\": \"Tamzin\", \"characterName\": \"DCI Sasha Miller\"}]','[{\"imageUri\": \"file:///p451597_b_v8_av.jpg\", \"imageType\": \"High Res Portrait\"}, {\"imageUri\": \"file:///p11152768_e_h10_aa.jpg\", \"imageType\": \"HighRes Landscape Production Still\"}, {\"imageUri\": \"file:///p451597_ttn_h95_aa.png\", \"imageType\": \"Title Treatment\"}]','2014','GB',NULL);
/*!40000 ALTER TABLE `programinformationdata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programscheduledata`
--

DROP TABLE IF EXISTS `programscheduledata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programscheduledata` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Psd_ServiceIdReference` varchar(10) NOT NULL,
  `Psd_ScheduleStart` datetime NOT NULL,
  `Psd_ScheduleEnd` datetime NOT NULL,
  `Psd_ScheduleDuration` varchar(5) NOT NULL,
  `Psd_ProgramCrid` varchar(45) NOT NULL,
  `Psd_ProgramImi` varchar(20) NOT NULL,
  `Psd_PurchaseList` json DEFAULT NULL,
  `Psd_CaptionLanguage` varchar(5) DEFAULT NULL,
  `Psd_AV_Attributes` json DEFAULT NULL,
  `Psd_TmsId` varchar(20) NOT NULL,
  `Psd_ScheduledStartTime` datetime NOT NULL,
  `Psd_ScheduledEndTime` datetime NOT NULL,
  `Psd_EventDuration` varchar(10) NOT NULL,
  `Psd_RowChange` json DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programscheduledata`
--

LOCK TABLES `programscheduledata` WRITE;
/*!40000 ALTER TABLE `programscheduledata` DISABLE KEYS */;
INSERT INTO `programscheduledata` VALUES (1,'75803','2020-08-10 00:00:00','2020-08-25 00:00:00','15','crid=\"crid://gn.tv/11152768/EP012608630122\"','imi:33105689','[{\"PriceValue\": \"0\", \"PurchaseType\": \"urn:libertyglobal:metadata:cs:PurchaseTypeCS:2013:OTTMarker\", \"PriceCurrency\": \"EUR\", \"PurchaseDescription\": \"[OTTMarker.Data]RecordType=nDVR;PlayBackLicense=Onnet\"}, {\"PriceValue\": \"0\", \"PurchaseType\": \"urn:eventis:metadata:cs:PurchaseTypeCS:2013:TSTVMarker\", \"PriceCurrency\": \"EUR\", \"PurchaseDescription\": \"[TSTVMarker.Data]TemplateAdd=REPLAY;TemplateAdd=STARTOVER\"}]','en','{\"AVAttributes\": {\"AudioAttributes\": [{\"MixType\": {\"Name\": {\"lang\": \"en\", \"text\": \"Stereo\"}, \"href\": \"urn:eventis:metadata:cs:AudioPresentationCS:2010:3\", \"Definition\": {\"lang\": \"en\", \"text\": \"Stereographic sound\"}}}, {\"AudioLanguage\": {\"text\": \"en\", \"purpose\": \"urn:tva:metadata:cs:AudioPurposeCS:2007:6\"}}, {\"AudioLanguage\": {\"text\": \"en\", \"purpose\": \"urn:tva:metadata:cs:AudioPurposeCS:2007:1\", \"supplemental\": \"true\"}}]}}','EP012608630122','2020-08-10 10:00:00','2020-08-10 11:00:00','PT01H00M',NULL);
/*!40000 ALTER TABLE `programscheduledata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serviceinformationdata`
--

DROP TABLE IF EXISTS `serviceinformationdata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serviceinformationdata` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Sid_ServiceName` varchar(45) DEFAULT NULL,
  `Sid_VM_ServiceId` varchar(10) NOT NULL,
  `Sid_Epg_ServiceId` varchar(10) NOT NULL,
  `Sid_ServiceLogo` varchar(250) NOT NULL,
  `Sid_ChannelResolution` varchar(3) NOT NULL,
  `Sid_VM_ServiceGroup` varchar(250) NOT NULL,
  `Sid_RowChanges` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviceinformationdata`
--

LOCK TABLES `serviceinformationdata` WRITE;
/*!40000 ALTER TABLE `serviceinformationdata` DISABLE KEYS */;
INSERT INTO `serviceinformationdata` VALUES (1,'Alibi HD','1600','75803','https://staticqbr-gb-prod.prod.cdn.dmdsdp.com/image-service/ImagesEPG/EventImages/alibi-hd.png','HD','crid://dtv.gb/sg/NGTV_HD_XL_Pack_(Tier_5),crid://dtv.gb/sg/NGTV_Drama_Pack_2019',NULL);
/*!40000 ALTER TABLE `serviceinformationdata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'vm_epg_data'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-02 12:03:31
