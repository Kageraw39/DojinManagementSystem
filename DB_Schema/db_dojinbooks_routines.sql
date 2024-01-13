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
-- Temporary view structure for view `v_full_book_inf`
--

DROP TABLE IF EXISTS `v_full_book_inf`;
/*!50001 DROP VIEW IF EXISTS `v_full_book_inf`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_full_book_inf` AS SELECT 
 1 AS `book_id`,
 1 AS `book_name`,
 1 AS `series_no`,
 1 AS `first_name`,
 1 AS `first_id`,
 1 AS `circle_id`,
 1 AS `author`,
 1 AS `event_id`,
 1 AS `publish_date`,
 1 AS `genre_id`,
 1 AS `original_id`,
 1 AS `flg_r18`,
 1 AS `flg_omnibus`,
 1 AS `flg_joint`,
 1 AS `flg_copy`,
 1 AS `size_id`,
 1 AS `buy_date`,
 1 AS `price`,
 1 AS `buyway_id`,
 1 AS `memo`,
 1 AS `flg_delete`,
 1 AS `create_date`,
 1 AS `update_date`,
 1 AS `original_name`,
 1 AS `circle_name`,
 1 AS `genre_name`,
 1 AS `buy_way`,
 1 AS `event_name`,
 1 AS `size_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_full_book_inf`
--

/*!50001 DROP VIEW IF EXISTS `v_full_book_inf`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`sa`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_full_book_inf` AS select `info`.`book_id` AS `book_id`,`info`.`book_name` AS `book_name`,`info`.`series_no` AS `series_no`,`info`.`first_name` AS `first_name`,`info`.`first_id` AS `first_id`,`info`.`circle_id` AS `circle_id`,`info`.`author` AS `author`,`info`.`event_id` AS `event_id`,`info`.`publish_date` AS `publish_date`,`info`.`genre_id` AS `genre_id`,`info`.`original_id` AS `original_id`,`info`.`flg_r18` AS `flg_r18`,`info`.`flg_omnibus` AS `flg_omnibus`,`info`.`flg_joint` AS `flg_joint`,`info`.`flg_copy` AS `flg_copy`,`info`.`size_id` AS `size_id`,`info`.`buy_date` AS `buy_date`,`info`.`price` AS `price`,`info`.`buyway_id` AS `buyway_id`,`info`.`memo` AS `memo`,`info`.`flg_delete` AS `flg_delete`,`info`.`create_date` AS `create_date`,`info`.`update_date` AS `update_date`,`org`.`original_name` AS `original_name`,`circle`.`circle_name` AS `circle_name`,`genre`.`genre_name` AS `genre_name`,`buy`.`buy_way` AS `buy_way`,`event`.`event_name` AS `event_name`,`size`.`size_name` AS `size_name` from ((((((`t_book_inf` `info` left join `ms_original` `org` on((`info`.`original_id` = `org`.`id`))) left join `ms_circle` `circle` on((`info`.`circle_id` = `circle`.`id`))) left join `ms_genre` `genre` on((`info`.`genre_id` = `genre`.`id`))) left join `ms_buy_way` `buy` on((`info`.`buyway_id` = `buy`.`id`))) left join `ms_event` `event` on((`info`.`event_id` = `event`.`id`))) left join `ms_size` `size` on((`info`.`size_id` = `size`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-13 20:07:40
