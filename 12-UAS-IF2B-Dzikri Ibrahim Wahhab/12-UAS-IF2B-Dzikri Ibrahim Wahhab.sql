-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: dbrentalkendaraan
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
-- Table structure for table `tb_mobil`
--

DROP TABLE IF EXISTS `tb_mobil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_mobil` (
  `id_mobil` int NOT NULL AUTO_INCREMENT,
  `nama_mobil` varchar(100) NOT NULL,
  `merk` varchar(50) NOT NULL,
  `plat_nomor` varchar(45) NOT NULL,
  `tahun` int NOT NULL,
  `harga_sewa` decimal(10,2) NOT NULL,
  `status` enum('Tersedia','Disewa') NOT NULL DEFAULT 'Tersedia',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_mobil`),
  UNIQUE KEY `plat_nomor_UNIQUE` (`plat_nomor`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_mobil`
--

LOCK TABLES `tb_mobil` WRITE;
/*!40000 ALTER TABLE `tb_mobil` DISABLE KEYS */;
INSERT INTO `tb_mobil` VALUES (1,'Avanza G','Toyota','D 1234 AB',2021,350000.00,'Tersedia','2025-06-21 15:16:21'),(2,'Xpander Ultimate','Mitsubishi','D 4321 BC',2022,400000.00,'Tersedia','2025-06-21 15:24:46'),(3,'Ertiga GX','Suzuki','D 5678 CD',2020,330000.00,'Disewa','2025-06-21 15:25:55'),(4,'Mobilio RS','Honda','D 8765 DE',2021,360000.00,'Disewa','2025-06-21 15:27:01'),(5,'Fortuner VRZ','Toyota','D 1956 EF',2023,700000.00,'Tersedia','2025-06-21 15:27:38'),(6,'Pajero Sport Dakar','Mitsubishi','D 2949 FG',2022,750000.00,'Tersedia','2025-06-21 15:28:30'),(7,'Innova Zenix Hybrid','Toyota','D 3085 GH',2023,650000.00,'Tersedia','2025-06-21 15:29:02'),(8,'BR-V E CVT','Honda','D 4296 HI',2021,380000.00,'Disewa','2025-06-21 15:30:48'),(9,'Rush GR Sport','Toyota','D 5158 IJ',2022,390000.00,'Tersedia','2025-06-21 15:41:50'),(10,'Calya E MT','Toyota','D 6143 JK',2020,300000.00,'Tersedia','2025-06-21 15:43:03'),(12,' GR Supra 3.0L AT','Toyota','D 8080 ZX',2023,2500000.00,'Tersedia','2025-06-23 21:30:19');
/*!40000 ALTER TABLE `tb_mobil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pelanggan`
--

DROP TABLE IF EXISTS `tb_pelanggan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_pelanggan` (
  `id_pelanggan` int NOT NULL AUTO_INCREMENT,
  `nama_pelanggan` varchar(100) NOT NULL,
  `no_ktp` varchar(20) NOT NULL,
  `no_hp` varchar(20) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `jenis_kelamin` enum('Laki-laki','Perempuan') NOT NULL,
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_pelanggan`),
  UNIQUE KEY `no_ktp_UNIQUE` (`no_ktp`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pelanggan`
--

LOCK TABLES `tb_pelanggan` WRITE;
/*!40000 ALTER TABLE `tb_pelanggan` DISABLE KEYS */;
INSERT INTO `tb_pelanggan` VALUES (1,'Dzikri Ibrahim Wahhab','3204440805060001','087708894309','Jln Gg. Hj Karsoma\r\nCiluncat Kec.Cangkuang\r\nKab.Bandung','Laki-laki','2025-06-21 17:37:24'),(2,'Bariq Wahhab','3204442204120001','085137200703','Jln Gg. Hj Karsoma\r\nCiluncat Kec.Cangkuang\r\nKab.Bandung','Laki-laki','2025-06-21 17:43:45'),(3,'Nadya Mustafidzah','3204441606030001','088224533901','Jln Soreang Banjaran\r\nCiluncat Kec.Cangkuang\r\nKab.Bandung','Perempuan','2025-06-22 19:23:21');
/*!40000 ALTER TABLE `tb_pelanggan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_transaksi`
--

DROP TABLE IF EXISTS `tb_transaksi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_transaksi` (
  `id_transaksi` int NOT NULL AUTO_INCREMENT,
  `id_pelanggan` int NOT NULL,
  `id_mobil` int NOT NULL,
  `tgl_sewa` date NOT NULL,
  `tgl_kembali` date NOT NULL,
  `lama_sewa` int NOT NULL,
  `harga_per_hari` decimal(10,2) NOT NULL,
  `total_harga` decimal(12,2) NOT NULL,
  `denda` decimal(10,2) NOT NULL,
  `total_bayar` decimal(10,2) NOT NULL,
  `tgl_harus_kembali` date DEFAULT NULL,
  `status` enum('Disewa','Kembali') NOT NULL DEFAULT 'Disewa',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_transaksi`,`id_pelanggan`,`id_mobil`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_transaksi`
--

LOCK TABLES `tb_transaksi` WRITE;
/*!40000 ALTER TABLE `tb_transaksi` DISABLE KEYS */;
INSERT INTO `tb_transaksi` VALUES (1,2,3,'2025-06-22','2025-06-26',4,330000.00,1320000.00,0.00,0.00,NULL,'Disewa','2025-06-22 10:02:06'),(2,1,4,'2025-06-22','2025-06-25',3,360000.00,1080000.00,0.00,0.00,NULL,'Disewa','2025-06-22 10:12:44'),(3,1,10,'2025-06-22','2025-06-29',7,300000.00,2100000.00,0.00,2100000.00,'2025-06-29','Kembali','2025-06-22 10:24:43'),(4,3,8,'2025-06-22','2025-06-24',2,380000.00,760000.00,0.00,760000.00,NULL,'Disewa','2025-06-22 21:25:41');
/*!40000 ALTER TABLE `tb_transaksi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_users`
--

DROP TABLE IF EXISTS `tb_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_users` (
  `id_user` int NOT NULL AUTO_INCREMENT,
  `full_name` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(150) NOT NULL,
  `email` varchar(100) NOT NULL,
  `role` enum('admin','customer') NOT NULL DEFAULT 'customer',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_user`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_users`
--

LOCK TABLES `tb_users` WRITE;
/*!40000 ALTER TABLE `tb_users` DISABLE KEYS */;
INSERT INTO `tb_users` VALUES (1,'Administrator','admin','admin123','admin@gmail.com','admin','2025-06-21 11:47:03'),(2,'Dzikri Ibrahim Wahhab','dzikriibra','dzikriibra124032','wahhab.dzikri@gmail,com','customer','2025-06-21 11:59:53'),(3,'nadyam','mona','mona1234','mona123@gmail.com','customer','2025-06-22 11:16:34'),(4,'Nadya Mustafidzah','nadyam','nadyam12345','mustafidzah.nadya@gmail.com','customer','2025-06-22 19:20:20');
/*!40000 ALTER TABLE `tb_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'dbrentalkendaraan'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-23 21:45:24
