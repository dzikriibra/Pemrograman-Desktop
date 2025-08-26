-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: dbperpustakaan
-- ------------------------------------------------------
-- Server version	8.0.42

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
-- Table structure for table `tbanggota`
--

DROP TABLE IF EXISTS `tbanggota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbanggota` (
  `IDAnggota` varchar(10) NOT NULL,
  `NamaAnggota` varchar(30) NOT NULL,
  `Alamat` varchar(30) NOT NULL,
  `Telepon` varchar(15) NOT NULL,
  PRIMARY KEY (`IDAnggota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbanggota`
--

LOCK TABLES `tbanggota` WRITE;
/*!40000 ALTER TABLE `tbanggota` DISABLE KEYS */;
INSERT INTO `tbanggota` VALUES ('124032','Dzikri Ibrahim W','Kab.Bandung Banjaran','087708894309');
/*!40000 ALTER TABLE `tbanggota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbbuku`
--

DROP TABLE IF EXISTS `tbbuku`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbbuku` (
  `KodeBuku` varchar(8) NOT NULL,
  `JudulBuku` varchar(50) NOT NULL,
  `Pengarang` varchar(50) NOT NULL,
  `Penerbit` varchar(50) NOT NULL,
  PRIMARY KEY (`KodeBuku`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbbuku`
--

LOCK TABLES `tbbuku` WRITE;
/*!40000 ALTER TABLE `tbbuku` DISABLE KEYS */;
INSERT INTO `tbbuku` VALUES ('BK0001','The Intelligent Investor','Benjamin Graham','HarperBusiness'),('BK0002','Rich Dad Poor Dad','Robert T. Kiyosaki','Plata Publishing'),('BK0003','Your Money Your Life','Vicki Robin dan Joe Dominguez','Penguin Books'),('BK0004','The Millionaire Next Door','Thomas J. Stanley dan William D. Danko','Taylor Trade Publishing'),('BK0005','Think and Grow Rich','Napoleon Hill','The Ralston Society');
/*!40000 ALTER TABLE `tbbuku` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbdetailpinjam`
--

DROP TABLE IF EXISTS `tbdetailpinjam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbdetailpinjam` (
  `KodePinjam` varchar(10) NOT NULL,
  `KodeBuku` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbdetailpinjam`
--

LOCK TABLES `tbdetailpinjam` WRITE;
/*!40000 ALTER TABLE `tbdetailpinjam` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbdetailpinjam` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbpetugas`
--

DROP TABLE IF EXISTS `tbpetugas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbpetugas` (
  `Status` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  PRIMARY KEY (`Status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbpetugas`
--

LOCK TABLES `tbpetugas` WRITE;
/*!40000 ALTER TABLE `tbpetugas` DISABLE KEYS */;
INSERT INTO `tbpetugas` VALUES ('admin','admin123');
/*!40000 ALTER TABLE `tbpetugas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbpinjam`
--

DROP TABLE IF EXISTS `tbpinjam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbpinjam` (
  `KodePinjam` varchar(10) NOT NULL,
  `IDAnggota` varchar(4) NOT NULL,
  `TanggalPinjam` date NOT NULL,
  PRIMARY KEY (`KodePinjam`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbpinjam`
--

LOCK TABLES `tbpinjam` WRITE;
/*!40000 ALTER TABLE `tbpinjam` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbpinjam` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-02 17:31:32
