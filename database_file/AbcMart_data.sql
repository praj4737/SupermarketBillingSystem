CREATE DATABASE  IF NOT EXISTS `abcmartv2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `abcmartv2`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: abcmartv2
-- ------------------------------------------------------
-- Server version	8.1.0

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
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customer_id` varchar(15) NOT NULL,
  `customer_name` varchar(255) NOT NULL,
  `mobile_number` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('cus1','pranav raj','7061597110'),('cus2','pravin chandra singh','8789825561'),('cus3','pravin chandra singh','8789825561');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderitems`
--

DROP TABLE IF EXISTS `orderitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderitems` (
  `order_item_id` varchar(15) NOT NULL,
  `order_id` varchar(15) NOT NULL,
  `product_id` varchar(15) NOT NULL,
  `quantity` int DEFAULT NULL,
  `item_total` double DEFAULT NULL,
  PRIMARY KEY (`order_item_id`),
  KEY `orderitems_ibfk_1` (`order_id`),
  KEY `orderitems_ibfk_2` (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderitems`
--

LOCK TABLES `orderitems` WRITE;
/*!40000 ALTER TABLE `orderitems` DISABLE KEYS */;
INSERT INTO `orderitems` VALUES ('order_item_id1','ordr5','P72',5,50),('order_item_id10','ordr13','P72',10,100),('order_item_id11','ordr14','P59',2,80),('order_item_id12','ordr14','P72',1,80),('order_item_id13','ordr15','P59',1,55),('order_item_id14','ordr15','P72',2,55),('order_item_id15','ordr16','P59',1,35),('order_item_id16','ordr17','P59',1,35),('order_item_id17','ordr18','P59',1,35),('order_item_id18','ordr19','P59',1,35),('order_item_id19','ordr20','P59',1,45),('order_item_id2','ordr6','P72',8,80),('order_item_id20','ordr20','P72',1,45),('order_item_id21','ordr21','P59',1,35),('order_item_id22','ordr22','P59',1,35),('order_item_id23','ordr24','P73',1,284),('order_item_id24','ordr24','P72',1,284),('order_item_id25','ordr24','',0,284),('order_item_id26','ordr25','P72',3,573),('order_item_id27','ordr25','P73',2,573),('order_item_id28','ordr25','',0,573),('order_item_id3','ordr7','P72',5,50),('order_item_id4','ordr8','P72',3,30),('order_item_id5','ordr9','P72',1,10),('order_item_id6','ordr10','P72',1,20),('order_item_id7','ordr10','P72',1,20),('order_item_id8','ordr11','P72',1,10),('order_item_id9','ordr12','P72',2,20);
/*!40000 ALTER TABLE `orderitems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `order_id` varchar(15) NOT NULL,
  `customer_id` varchar(15) DEFAULT NULL,
  `order_date` date DEFAULT NULL,
  `total_amount` double DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  KEY `customer_id` (`customer_id`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES ('ordr1','cus1','2024-04-07',0),('ordr10','cus1','2024-04-28',20),('ordr11','cus1','2024-04-28',10),('ordr12','cus1','2024-04-28',20),('ordr13','cus1','2024-04-28',100),('ordr14','cus1','2024-05-29',80),('ordr15','cus1','2024-05-29',55),('ordr16','cus1','2024-05-29',35),('ordr17','cus1','2024-05-29',35),('ordr18','cus1','2024-05-29',35),('ordr19','cus2','2024-05-29',35),('ordr2','cus1','2024-04-07',0),('ordr20','cus1','2024-05-29',45),('ordr21','cus1','2024-05-29',35),('ordr22','cus1','2024-05-30',35),('ordr23','cus3','2024-05-30',5),('ordr24','cus1','2025-01-26',284),('ordr25','cus1','2025-02-17',573),('ordr3','cus1','2024-04-07',0),('ordr4','cus1','2024-04-07',0),('ordr5','cus1','2024-04-07',50),('ordr6','cus2','2024-04-07',80),('ordr7','cus1','2024-04-07',50),('ordr8','cus1','2024-04-12',30),('ordr9','cus1','2024-04-28',10);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `product_id` varchar(15) NOT NULL,
  `batch_id` varchar(15) DEFAULT NULL,
  `product_name` varchar(255) DEFAULT NULL,
  `category` varchar(255) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `manufacturer` varchar(255) DEFAULT NULL,
  `description` text,
  `mfg_date` date DEFAULT NULL,
  `exp_date` date DEFAULT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES ('P72','b102','parle g','eatery',150,5.00,'parle','','2024-04-06','2024-04-06'),('P73','12303','dove men','groomimg',50,279.00,'lbcp','','2025-01-26','2027-02-27');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_address`
--

DROP TABLE IF EXISTS `user_address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_address` (
  `address_id` varchar(15) NOT NULL,
  `address_line_1` text,
  `address_line_2` text,
  `address_line_3` text,
  `city` varchar(20) DEFAULT NULL,
  `pincode` varchar(10) DEFAULT NULL,
  `state` varchar(20) DEFAULT NULL,
  `country` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`address_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_address`
--

LOCK TABLES `user_address` WRITE;
/*!40000 ALTER TABLE `user_address` DISABLE KEYS */;
INSERT INTO `user_address` VALUES ('add1','vsddsv','vdsvd','ddd','','','','ddd'),('add2','esvfsedv','sdvsdv','svsdeev','','','','dvszvs'),('add3','patna','patna','patna','','','','patna'),('add4','sdvfsdv','dsvsdv','sdvsdv','','','','sdgvsdgf');
/*!40000 ALTER TABLE `user_address` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_contact`
--

DROP TABLE IF EXISTS `user_contact`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_contact` (
  `contact_id` varchar(15) NOT NULL,
  `contact_number` varchar(10) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`contact_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_contact`
--

LOCK TABLES `user_contact` WRITE;
/*!40000 ALTER TABLE `user_contact` DISABLE KEYS */;
INSERT INTO `user_contact` VALUES ('con1','234325','sdfcsdf'),('con2','sdvdsdv','vsdv'),('con3','2343543645','praj47347@hajk.von'),('con4','dfsdf','dfsdf');
/*!40000 ALTER TABLE `user_contact` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_creds`
--

DROP TABLE IF EXISTS `user_creds`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_creds` (
  `password` varchar(15) NOT NULL,
  `user_id` varchar(15) DEFAULT NULL,
  `cred_id` varchar(15) NOT NULL,
  PRIMARY KEY (`cred_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `user_creds_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_creds`
--

LOCK TABLES `user_creds` WRITE;
/*!40000 ALTER TABLE `user_creds` DISABLE KEYS */;
INSERT INTO `user_creds` VALUES ('pass','user1@abc','crd101'),('pass','usr2','crd102');
/*!40000 ALTER TABLE `user_creds` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` varchar(15) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `lname` varchar(255) DEFAULT NULL,
  `dob` date NOT NULL,
  `role_name` varchar(255) NOT NULL,
  `start_date` date NOT NULL,
  `end` date DEFAULT NULL,
  `address_id` varchar(15) DEFAULT NULL,
  `contact_id` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  KEY `address_id` (`address_id`),
  KEY `contact_id` (`contact_id`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`address_id`) REFERENCES `user_address` (`address_id`),
  CONSTRAINT `users_ibfk_2` FOREIGN KEY (`contact_id`) REFERENCES `user_contact` (`contact_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('user1@abc','Pranav','Raj','2005-01-14','admin','2024-04-05',NULL,NULL,NULL),('usr2','egsdg','sdvsdg','2024-04-07','sales','2024-04-07','0001-01-01','add4','con4');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-23 18:17:26
