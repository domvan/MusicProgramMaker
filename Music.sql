/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT*/;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS*/;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION*/;
/*!40101 SET NAMES utf8mb4 */;

-- Database: `Music`


CREATE DATABASE IF NOT EXISTS `music`;
USE `music`;



-- ----------------------------------------------------------------


-- Table Structure for Performer


DROP TABLE IF EXISTS `performer`;
CREATE TABLE `performer` (
    `name` varchar(50) NOT NULL PRIMARY KEY,
    `age` int NOT NULL,
    `bio` text NOT NULL,
    `classID` varchar(6) NOT NULL,
    `levelID` varchar(6) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `performer` (`name`, `age`, `bio`, `classID`, `levelID`) VALUES
('Bret Shilliday', 22, 'I am a Violinist in class 1', '1', '5'),
('Dominic Vandekerkhove', 20, 'I am another Violinist in class 1', '1', '4'),
('John Smith', 10, 'I am a Cellist in class 2', '2', '2'),
('Jane Doe', 12, 'I am Pianist class 2', '2', '2'),
('Michael Scott', 19, 'I am Violist class 2', '2', '5');
COMMIT;


/*----------------------------------------------------------------*/

-- Table Structure for Violinist

-- 

DROP TABLE IF EXISTS `violinist`;
CREATE TABLE `violinist` (
    `name` varchar(50) NOT NULL PRIMARY KEY
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `violinist` (`name`) VALUES
('Bret Shilliday'),
('Dominic Vandekerkhove');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Violist


DROP TABLE IF EXISTS `violist`;
CREATE TABLE `violist` (
    `name` varchar(50) NOT NULL PRIMARY KEY
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `violist` (`name`) VALUES
('Michael Scott');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Cellist


DROP TABLE IF EXISTS `cellist`;
CREATE TABLE `cellist` (
    `name` varchar(50) NOT NULL PRIMARY KEY
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `cellist` (`name`) VALUES
('John Smith');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Pianist


DROP TABLE IF EXISTS `pianist`;
CREATE TABLE `pianist` (
    `name` varchar(50) NOT NULL PRIMARY KEY
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `pianist` (`name`) VALUES
('Jane Doe');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Group

DROP TABLE IF EXISTS `team`;
CREATE TABLE `team` (
    `teamID` varchar(6) NOT NULL PRIMARY KEY,
    `age` int(11) NOT NULL,
    `bio` text NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `team` (`teamID`, `age`, `bio`) VALUES
('1', 20, 'We are group number 1'),
('2', 10, 'We are group number 2');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Trio


DROP TABLE IF EXISTS `trio`;
CREATE TABLE `trio` (
    `teamID` varchar(6) NOT NULL PRIMARY KEY,
    `violin` varchar(50) NOT NULL,
    `cello` varchar(50) NOT NULL,
    `piano` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `trio` (`teamID`, `violin`, `cello`, `piano`) VALUES
('1', 'Bret Shilliday', 'John Smith', 'Jane Doe');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Quartet

DROP TABLE IF EXISTS `quartet`;
CREATE TABLE `quartet` (
    `teamID` varchar(6) NOT NULL PRIMARY KEY,
    `firstViolin` varchar(50) NOT NULL,
    `secondViolin` varchar(50) NOT NULL,
    `cello` varchar(50) NOT NULL,
    `viola` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `quartet` (`teamID`, `firstViolin`, `secondViolin`, `cello`, `viola`) VALUES
('2', 'Bret Shilliday', 'Dominic Vandekerkhove', 'John Smith', 'Michael Scott');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Teacher

DROP TABLE IF EXISTS `teacher`;
CREATE TABLE `teacher` (
    `tID` varchar(6) NOT NULL PRIMARY KEY,
    `school` varchar(30),
    `bio` text NOT NULL,
    `name` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `teacher` (`tID`, `school`, `bio`, `name`) VALUES
('1', 'Calgary Music Academy', 'I am teacher number 1', 'Michael Jackson'),
('2', 'Calgary Music Academy', 'I am teacher number 2', 'Prince'),
('3', 'Calgary School of Fine Arts', 'I am teacher number 3', 'Elvis Presley'),
('4', 'Calgary School of Fine Arts', 'I am teacher number 4', 'Bob Marley');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Piece


DROP TABLE IF EXISTS `piece`;
CREATE TABLE `piece` (
    `pName` varchar(50) NOT NULL PRIMARY KEY,
    `info` text NOT NULL,
    `date` varchar(4),
    `genre` varchar(50) NOT NULL,
    `musicSheetLink` varchar(50),
    `c_name` varchar(50)
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `piece` (`pName`, `info`, `date`, `genre`, `musicSheetLink`, `c_name`) VALUES
('Chaconne', 'A violin piece by Bach', '1730', 'Classical', 'Some link', 'J.S. Bach'),
('Concerto', 'A violin piece by Beethoven', '1810', 'Classical', 'Some link', 'Beethoven'),
('Divertimento', 'A trio piece by Mozart', '1788', 'Classical', 'Some link', 'Mozart'),
('Emperor', 'A quartet piece by Haydn', '1765', 'Classical', 'Some link', 'Haydn');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Composer

DROP TABLE IF EXISTS `composer`;
CREATE TABLE `composer` (
    `cName` varchar(50) NOT NULL PRIMARY KEY,
    `period` varchar(50) NOT NULL,
    `bio` text NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `composer` (`cName`, `period`, `bio`) VALUES
('J.S. Bach', '1700s', 'Bach was a composer'),
('Beethoven', '1800s', 'Beethoven was a composer'),
('Mozart', '1700s', 'Mozart was a composer'),
('Haydn', '1700s', 'Haydn was a composer');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Admin

DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin` (
    `username` varchar(50) NOT NULL PRIMARY KEY,
    `password` varchar(50) NOT NULL,
    `name` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `admin` (`username`, `password`, `name`) VALUES
('mikejack', 'mjpassword', 'Michael Jackson'),
('kingofrock', 'eppassword', 'Elvis Presley');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Guest

DROP TABLE IF EXISTS `guest`;
CREATE TABLE `guest` (
    `username` varchar(50) NOT NULL PRIMARY KEY,
    `password` varchar(50) NOT NULL,
    `name` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `guest` (`username`, `password`, `name`) VALUES
('LJames', 'ljpassowrd', 'Lebron James'),
('SCurry', 'scpassword', 'Steph Curry');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Program

DROP TABLE IF EXISTS `program`;
CREATE TABLE `program` (
    `pID` varchar(6) NOT NULL PRIMARY KEY,
    `numberOfPerformances` int NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `program` (`pID`, `numberOfPerformances`) VALUES
('1', 2),
('2', 2);
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Performance


DROP TABLE IF EXISTS `performance`;
CREATE TABLE `performance` (
    `perf_name` varchar(50) NOT NULL,
    `perfID` varchar(6) NOT NULL PRIMARY KEY,
    `pID` varchar(6) NOT NULL,
    `piece_name` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `performance` (`perf_name`, `perfID`, `pID`, `piece_name`) VALUES
('Bret  plays Chaccone', '1', '1', 'Chaconne'),
('Dom plays Concerto', '2', '1', 'Concerto'),
('Trio plays Divertimento', '3', '2', 'Divertimento'),
('Quartet plays Emperor', '4', '2', 'Emperor');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Class


DROP TABLE IF EXISTS `class`;
CREATE TABLE `class` (
    `classID` varchar(6) NOT NULL PRIMARY KEY,
    `numberOfStudents` int,
    `tID` varchar(6) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `class` (`classID`, `numberOfStudents`, `tID`) VALUES
('1', 2, '1'),
('2', 3, '2');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Level


DROP TABLE IF EXISTS `level`;
CREATE TABLE `level` (
    `levelID` varchar(6) NOT NULL PRIMARY KEY,
    `yearsExperience` int NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `level` (`levelID`, `yearsExperience`) VALUES
('1', 1),
('2', 2),
('3', 3),
('4', 4),
('5', 5);
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Group_can_edit

DROP TABLE IF EXISTS `team_can_edit`;
CREATE TABLE `team_can_edit` (
    `adminUsername` varchar(50) NOT NULL,
    `teamID` varchar(6) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `team_can_edit` (`adminUsername`, `teamID`) VALUES
('mikejack', '1'),
('kingofrock', '2');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Knows

DROP TABLE IF EXISTS `knows`;
CREATE TABLE `knows` (
    `performerName` varchar(50) NOT NULL,
    `pieceName` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `knows` (`performerName`, `pieceName`) VALUES
('Bret Shilliday', 'Chaconne'),
('Dominic Vandekerkhove', 'Concerto');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Manages

DROP TABLE IF EXISTS `manages`;
CREATE TABLE `manages` (
    `adminUsername` varchar(50) NOT NULL,
    `classID` varchar(6) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `manages` (`adminUsername`, `classID`) VALUES
('mikejack', '1'),
('kingofrock', '2');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Composer_can_edit 

DROP TABLE IF EXISTS `composer_can_edit`;
CREATE TABLE `composer_can_edit` (
    `adminUsername` varchar(50) NOT NULL,
    `cName` varchar(50) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `composer_can_edit` (`adminUsername`, `cName`) VALUES
('mikejack', 'J.S Bach'),
('kingofrock', 'Beethoven'),
('mikejack', 'Haydn'),
('kingofrock', 'Mozart');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Can_view 

DROP TABLE IF EXISTS `can_view`;
CREATE TABLE `can_view` (
    `guestUsername` varchar(50) NOT NULL,
    `pID` varchar(6) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `can_view` (`guestUsername`, `pID`) VALUES
('LJames', '1'),
('SCurry', '2');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Group_performs


DROP TABLE IF EXISTS `team_performs`;
CREATE TABLE `team_performs` (
    `teamID` varchar(6) NOT NULL,
    `perfID` varchar(6) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `team_performs` (`teamID`, `perfID`) VALUES
('1', '3'),
('2', '4');
COMMIT;

/*----------------------------------------------------------------*/

-- Table Structure for Solo_performs


DROP TABLE IF EXISTS `solo_performs`;
CREATE TABLE `solo_performs` (
    `name` varchar(50) NOT NULL,
    `perfID` varchar(6) NOT NULL PRIMARY KEY
) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `solo_performs` (`name`, `perfID`) VALUES
('Bret Shilliday', '1'),
('Dominic Vandekerkhove', '2');
COMMIT;

/*----------------------------------------------------------------*/

-- Constraints

ALTER TABLE `performer`
    ADD CONSTRAINT `performer_ibfk_1` FOREIGN KEY (`classID`) REFERENCES `class` (`classID`),
    ADD CONSTRAINT `performer_ibfk_2` FOREIGN KEY (`levelID`) REFERENCES `level` (`levelID`);

ALTER TABLE `violinist`
    ADD CONSTRAINT `violinist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`);

ALTER TABLE `violist`
    ADD CONSTRAINT `violist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`);

ALTER TABLE `cellist`
    ADD CONSTRAINT `cellist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`);

ALTER TABLE `pianist`
    ADD CONSTRAINT `pianist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`);

ALTER TABLE `trio`
    ADD CONSTRAINT `trio_ibfk_1` FOREIGN KEY (`teamID`) REFERENCES `team` (`teamID`),
    ADD CONSTRAINT `trio_ibfk_2` FOREIGN KEY (`violin`) REFERENCES `violinist` (`name`),
    ADD CONSTRAINT `trio_ibfk_3` FOREIGN KEY (`cello`) REFERENCES `cellist` (`name`),
    ADD CONSTRAINT `trio_ibfk_4` FOREIGN KEY (`piano`) REFERENCES `pianist` (`name`);

ALTER TABLE `quartet`
    ADD CONSTRAINT `quartet_ibfk_1` FOREIGN KEY (`teamID`) REFERENCES `team` (`teamID`),
    ADD CONSTRAINT `quartet_ibfk_2` FOREIGN KEY (`firstViolin`) REFERENCES `violinist` (`name`),
    ADD CONSTRAINT `quartet_ibfk_3` FOREIGN KEY (`secondViolin`) REFERENCES `violinist` (`name`),
    ADD CONSTRAINT `quartet_ibfk_4` FOREIGN KEY (`viola`) REFERENCES `violist` (`name`),
    ADD CONSTRAINT `quartet_ibfk_5` FOREIGN KEY (`cello`) REFERENCES `cellist` (`name`);

ALTER TABLE `piece`
    ADD CONSTRAINT `piece_ibfk_1` FOREIGN KEY (`c_name`) REFERENCES `composer` (`cName`);

ALTER TABLE `performance`
    ADD CONSTRAINT `performance_ibfk_1` FOREIGN KEY (`pID`) REFERENCES `program` (`pID`),
    ADD CONSTRAINT `performance_ibfk_2` FOREIGN KEY (`piece_name`) REFERENCES `piece` (`pName`);

ALTER TABLE `class`
    ADD CONSTRAINT `class_ibfk_1` FOREIGN KEY (`tID`) REFERENCES `teacher` (`tID`);

ALTER TABLE `team_can_edit`
    ADD CONSTRAINT `team_can_edit_ibfk_1` FOREIGN KEY (`adminUsername`) REFERENCES `admin` (`username`),
    ADD CONSTRAINT `team_can_edit_ibfk_2` FOREIGN KEY (`teamID`) REFERENCES `team` (`teamID`);

ALTER TABLE `knows`
    ADD CONSTRAINT `knows_ibfk_1` FOREIGN KEY (`performerName`) REFERENCES `performer` (`name`),
    ADD CONSTRAINT `knows_ibfk_2` FOREIGN KEY (`pieceName`) REFERENCES `piece` (`pName`);

ALTER TABLE `manages`
    ADD CONSTRAINT `manages_ibfk_1` FOREIGN KEY (`adminUsername`) REFERENCES `admin` (`username`),
    ADD CONSTRAINT `manages_ibfk_2` FOREIGN KEY (`classID`) REFERENCES `class` (`classID`);

ALTER TABLE `composer_can_edit`
    ADD CONSTRAINT `composer_can_edit_ibfk_1` FOREIGN KEY (`adminUsername`) REFERENCES `admin` (`username`),
    ADD CONSTRAINT `composer_can_edit_ibfk_2` FOREIGN KEY (`cName`) REFERENCES `composer` (`cName`);

ALTER TABLE `can_view`
    ADD CONSTRAINT `can_view_ibfk_1` FOREIGN KEY (`guestUsername`) REFERENCES `guest` (`username`),
    ADD CONSTRAINT `can_view_ibfk_2` FOREIGN KEY (`pID`) REFERENCES `program` (`pID`);

ALTER TABLE `team_performs`
    ADD CONSTRAINT `team_performs_ibfk_1` FOREIGN KEY (`teamID`) REFERENCES `team` (`teamID`),
    ADD CONSTRAINT `team_performs_ibfk_2` FOREIGN KEY (`perfID`) REFERENCES `performance` (`perfID`);

ALTER TABLE `solo_performs`
    ADD CONSTRAINT `solo_performs_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`),
    ADD CONSTRAINT `solo_performs_ibfk_2` FOREIGN KEY (`perfID`) REFERENCES `performance` (`perfID`);






/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT*/;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS*/;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION*/;