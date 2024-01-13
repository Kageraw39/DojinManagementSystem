CREATE DATABASE  IF NOT EXISTS `db_dojinbooks` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_dojinbooks`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 192.168.5.3    Database: db_dojinbooks
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `t_book_inf`
--

DROP TABLE IF EXISTS `t_book_inf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_book_inf` (
  `book_id` int NOT NULL AUTO_INCREMENT COMMENT '同人誌ID',
  `book_name` varchar(100) NOT NULL COMMENT 'タイトル',
  `series_no` int DEFAULT NULL COMMENT 'シリーズ巻数',
  `first_name` varchar(100) DEFAULT NULL COMMENT '初刊名',
  `first_id` int DEFAULT NULL COMMENT '初刊ID',
  `circle_id` int DEFAULT NULL COMMENT '発行サークルID',
  `author` varchar(20) DEFAULT NULL COMMENT '作者',
  `event_id` int DEFAULT NULL COMMENT 'イベントID',
  `publish_date` datetime DEFAULT NULL COMMENT '発行日',
  `genre_id` int DEFAULT NULL COMMENT 'ジャンルID',
  `original_id` int DEFAULT NULL COMMENT '原作ID',
  `flg_r18` tinyint(1) NOT NULL COMMENT 'R18フラグ',
  `flg_omnibus` tinyint(1) NOT NULL COMMENT '総集編フラグ',
  `flg_joint` tinyint(1) NOT NULL COMMENT '合同誌フラグ',
  `flg_copy` tinyint(1) NOT NULL COMMENT 'コピー誌フラグ',
  `size_id` int DEFAULT NULL COMMENT 'サイズID',
  `buy_date` datetime DEFAULT NULL COMMENT '購入日',
  `price` int DEFAULT NULL COMMENT '値段',
  `buyway_id` int DEFAULT NULL COMMENT '購入方法ID',
  `memo` text COMMENT 'メモ',
  `flg_delete` tinyint(1) NOT NULL COMMENT '削除フラグ',
  `create_date` datetime NOT NULL COMMENT '情報作成日',
  `update_date` datetime NOT NULL COMMENT '情報更新日',
  PRIMARY KEY (`book_id`)
) ENGINE=InnoDB AUTO_INCREMENT=419 DEFAULT CHARSET=utf8mb3 COMMENT='同人誌情報';
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-13 20:07:39
