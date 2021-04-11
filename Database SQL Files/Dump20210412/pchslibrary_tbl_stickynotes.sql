-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pchslibrary
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `tbl_stickynotes`
--

DROP TABLE IF EXISTS `tbl_stickynotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_stickynotes` (
  `stickynoteID` int NOT NULL AUTO_INCREMENT,
  `text` varchar(8000) DEFAULT NULL,
  `location` varchar(20) NOT NULL,
  `size` varchar(20) NOT NULL,
  `librarianID` int NOT NULL,
  PRIMARY KEY (`stickynoteID`),
  KEY `librarianID_idx` (`librarianID`),
  CONSTRAINT `librarianID` FOREIGN KEY (`librarianID`) REFERENCES `tbl_librarians` (`librarianID`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stickynotes`
--

LOCK TABLES `tbl_stickynotes` WRITE;
/*!40000 ALTER TABLE `tbl_stickynotes` DISABLE KEYS */;
INSERT INTO `tbl_stickynotes` VALUES (66,'{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Century Gothic;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\b\\f0\\fs20 PROTOTYPE  v0.6\\b0\\par\r\n\\par\r\n\\b Version Updates:\\par\r\n\r\n\\pard{\\pntext\\f1\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf1\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225\\b0 Integrated The Database System\\par\r\n\r\n\\pard\\par\r\n\\b Final parts to ADDED\\par\r\n\\b0\\par\r\n\r\n\\pard{\\pntext\\f1\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf1\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225 View User Account, Update, Remove\\par\r\n{\\pntext\\f1\\\'B7\\tab}View and Remove Publishers\\par\r\n{\\pntext\\f1\\\'B7\\tab}View and Remove Authors\\par\r\n{\\pntext\\f1\\\'B7\\tab}View and Remove\\par\r\n{\\pntext\\f1\\\'B7\\tab}Save Sticky  Note Color to database \\par\r\n{\\pntext\\f1\\\'B7\\tab}Clean Code\\par\r\n\r\n\\pard\\par\r\n\\par\r\n\\b Known Errors to FIX\\b0\\par\r\n\r\n\\pard{\\pntext\\f1\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf1\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225 stickynote save Image Error\\par\r\n\r\n\\pard\\par\r\n\\par\r\n\\b Estimated Finish Time: \\b0 12 - 24 Hrs\\ul\\par\r\n\\ulnone\\par\r\nPrototype Deadline: 4/12/2021\\par\r\n\\par\r\n\\par\r\n\\par\r\n\\b Final Version Deadline:\\par\r\n \\b0\\par\r\nLast Week of April\\par\r\n}\r\n','8,32','279,588',7312002),(67,'{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Century Gothic;}{\\f1\\fnil Century Gothic;}{\\f2\\fnil\\fcharset2 Symbol;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\b\\f0\\fs20 Past Versions:\\par\r\n\\par\r\nv0.5\\par\r\n\r\n\\pard{\\pntext\\f2\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf2\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225\\b0 Added Sticky Notes\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Added Dashboard\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Added Manager: Book Showcases\\b\\par\r\n\r\n\\pard\\par\r\nv0.4\\b0\\f1\\par\r\n\r\n\\pard{\\pntext\\f2\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf2\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225\\f0 Added All Functions\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Added Manager Splash Screen\\b\\par\r\n\r\n\\pard\\par\r\nv0.3\\b0\\f1\\par\r\n\r\n\\pard{\\pntext\\f2\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf2\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225\\f0 Added The Dataviewer\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Borrow or View Form\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Booklist\\b\\par\r\n\r\n\\pard\\par\r\nv0.2\\par\r\n\r\n\\pard{\\pntext\\f2\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf2\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225\\b0 Added Inventory\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Borrows\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Inventory\\b\\par\r\n{\\pntext\\f2\\\'B7\\tab}\\b0 Staff\\b\\par\r\n\r\n\\pard\\par\r\nv0.1\\b0\\par\r\n\r\n\\pard{\\pntext\\f2\\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf2\\pnindent0{\\pntxtb\\\'B7}}\\fi-75\\li225 Created Main Page Gui\\par\r\n{\\pntext\\f2\\\'B7\\tab}Created Manager GUI\\par\r\n\r\n\\pard\\b\\par\r\n\\b0\\par\r\n}\r\n','310,30','241,586',7312002);
/*!40000 ALTER TABLE `tbl_stickynotes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-12  5:43:32
