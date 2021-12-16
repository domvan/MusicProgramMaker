-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 16, 2021 at 09:24 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `music`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`, `name`) VALUES
('kingofrock', 'eppassword', 'Elvis Presley'),
('mikejack', 'mjpassword', 'Michael Jackson');

-- --------------------------------------------------------

--
-- Table structure for table `can_view`
--

CREATE TABLE `can_view` (
  `guestUsername` varchar(50) NOT NULL,
  `pID` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `can_view`
--

INSERT INTO `can_view` (`guestUsername`, `pID`) VALUES
('LJames', '1'),
('SCurry', '2');

-- --------------------------------------------------------

--
-- Table structure for table `cellist`
--

CREATE TABLE `cellist` (
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cellist`
--

INSERT INTO `cellist` (`name`) VALUES
('John Smith');

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `classID` varchar(6) NOT NULL,
  `numberOfStudents` int(11) DEFAULT NULL,
  `tID` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`classID`, `numberOfStudents`, `tID`) VALUES
('1', 2, '1'),
('2', 3, '2');

-- --------------------------------------------------------

--
-- Table structure for table `composer`
--

CREATE TABLE `composer` (
  `cName` varchar(50) NOT NULL,
  `period` varchar(50) NOT NULL,
  `bio` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `composer`
--

INSERT INTO `composer` (`cName`, `period`, `bio`) VALUES
('Beethoven', '1800s', 'Beethoven was a composer'),
('Haydn', '1700s', 'Haydn was a composer'),
('J.S. Bach', '1700s', 'Bach was a composer'),
('Mozart', '1700s', 'Mozart was a composer');

-- --------------------------------------------------------

--
-- Table structure for table `composer_can_edit`
--

CREATE TABLE `composer_can_edit` (
  `adminUsername` varchar(50) NOT NULL,
  `cName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `composer_can_edit`
--

INSERT INTO `composer_can_edit` (`adminUsername`, `cName`) VALUES
('mikejack', 'J.S Bach'),
('kingofrock', 'Beethoven'),
('mikejack', 'Haydn'),
('kingofrock', 'Mozart');

-- --------------------------------------------------------

--
-- Table structure for table `group_can_edit`
--

CREATE TABLE `group_can_edit` (
  `adminUsername` varchar(50) NOT NULL,
  `gID` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `group_can_edit`
--

INSERT INTO `group_can_edit` (`adminUsername`, `gID`) VALUES
('mikejack', '1'),
('kingofrock', '2');

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `guest`
--

INSERT INTO `guest` (`username`, `password`, `name`) VALUES
('LJames', 'ljpassowrd', 'Lebron James'),
('SCurry', 'scpassword', 'Steph Curry');

-- --------------------------------------------------------

--
-- Table structure for table `knows`
--

CREATE TABLE `knows` (
  `performerName` varchar(50) NOT NULL,
  `pieceName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `knows`
--

INSERT INTO `knows` (`performerName`, `pieceName`) VALUES
('Bret Shilliday', 'Chaconne'),
('Dominic Vandekerkhove', 'Concerto');

-- --------------------------------------------------------

--
-- Table structure for table `level`
--

CREATE TABLE `level` (
  `levelID` varchar(6) NOT NULL,
  `yearsExperience` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `level`
--

INSERT INTO `level` (`levelID`, `yearsExperience`) VALUES
('1', 1),
('2', 2),
('3', 3),
('4', 4),
('5', 5);

-- --------------------------------------------------------

--
-- Table structure for table `manages`
--

CREATE TABLE `manages` (
  `adminUsername` varchar(50) NOT NULL,
  `classID` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manages`
--

INSERT INTO `manages` (`adminUsername`, `classID`) VALUES
('mikejack', '1'),
('kingofrock', '2');

-- --------------------------------------------------------

--
-- Table structure for table `performance`
--

CREATE TABLE `performance` (
  `perf_name` varchar(50) NOT NULL,
  `pID` varchar(6) NOT NULL,
  `piece_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `performance`
--

INSERT INTO `performance` (`perf_name`, `pID`, `piece_name`) VALUES
('Bret  plays Chaccone', '1', 'Chaconne'),
('Dom plays Concerto', '1', 'Concerto'),
('Quartet plays Emperor', '2', 'Emperor'),
('Trio plays Divertimento', '2', 'Divertimento');

-- --------------------------------------------------------

--
-- Table structure for table `performer`
--

CREATE TABLE `performer` (
  `name` varchar(50) NOT NULL,
  `age` int(11) NOT NULL,
  `bio` text NOT NULL,
  `classID` varchar(6) NOT NULL,
  `levelID` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `performer`
--

INSERT INTO `performer` (`name`, `age`, `bio`, `classID`, `levelID`) VALUES
('Bret Shilliday', 22, 'I am a Violinist in class 1', '1', '5'),
('Dominic Vandekerkhove', 20, 'I am another Violinist in class 1', '1', '4'),
('Jane Doe', 12, 'I am Pianist class 2', '2', '2'),
('John Smith', 10, 'I am a Cellist in class 2', '2', '2'),
('Michael Scott', 19, 'I am Violist class 2', '2', '5');

-- --------------------------------------------------------

--
-- Table structure for table `pianist`
--

CREATE TABLE `pianist` (
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pianist`
--

INSERT INTO `pianist` (`name`) VALUES
('Jane Doe');

-- --------------------------------------------------------

--
-- Table structure for table `piece`
--

CREATE TABLE `piece` (
  `pName` varchar(50) NOT NULL,
  `info` text NOT NULL,
  `date` varchar(4) DEFAULT NULL,
  `genre` varchar(50) NOT NULL,
  `musicSheetLink` varchar(50) DEFAULT NULL,
  `c_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `piece`
--

INSERT INTO `piece` (`pName`, `info`, `date`, `genre`, `musicSheetLink`, `c_name`) VALUES
('Chaconne', 'A violin piece by Bach', '1730', 'Classical', 'Some link', 'J.S. Bach'),
('Concerto', 'A violin piece by Beethoven', '1810', 'Classical', 'Some link', 'Beethoven'),
('Divertimento', 'A trio piece by Mozart', '1788', 'Classical', 'Some link', 'Mozart'),
('Emperor', 'A quartet piece by Haydn', '1765', 'Classical', 'Some link', 'Haydn');

-- --------------------------------------------------------

--
-- Table structure for table `program`
--

CREATE TABLE `program` (
  `pID` varchar(6) NOT NULL,
  `numberOfPerformances` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `program`
--

INSERT INTO `program` (`pID`, `numberOfPerformances`) VALUES
('1', 2),
('2', 2);

-- --------------------------------------------------------

--
-- Table structure for table `quartet`
--

CREATE TABLE `quartet` (
  `gID` varchar(6) NOT NULL,
  `firstViolin` varchar(50) NOT NULL,
  `secondViolin` varchar(50) NOT NULL,
  `cello` varchar(50) NOT NULL,
  `viola` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `quartet`
--

INSERT INTO `quartet` (`gID`, `firstViolin`, `secondViolin`, `cello`, `viola`) VALUES
('2', 'Bret Shilliday', 'Dominic Vandekerkhove', 'John Smith', 'Michael Scott');

-- --------------------------------------------------------

--
-- Table structure for table `solo_performs`
--

CREATE TABLE `solo_performs` (
  `name` varchar(50) NOT NULL,
  `pID` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `solo_performs`
--

INSERT INTO `solo_performs` (`name`, `pID`) VALUES
('Bret Shilliday', '1'),
('Dominic Vandekerkhove', '1');

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `tID` varchar(6) NOT NULL,
  `school` varchar(30) DEFAULT NULL,
  `bio` text NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`tID`, `school`, `bio`, `name`) VALUES
('1', 'Calgary Music Academy', 'I am teacher number 1', 'Michael Jackson'),
('2', 'Calgary Music Academy', 'I am teacher number 2', 'Prince'),
('3', 'Calgary School of Fine Arts', 'I am teacher number 3', 'Elvis Presley'),
('4', 'Calgary School of Fine Arts', 'I am teacher number 4', 'Bob Marley');

-- --------------------------------------------------------

--
-- Table structure for table `team`
--

CREATE TABLE `team` (
  `gID` varchar(6) NOT NULL,
  `age` int(11) NOT NULL,
  `bio` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `team`
--

INSERT INTO `team` (`gID`, `age`, `bio`) VALUES
('1', 20, 'We are group number 1'),
('2', 10, 'We are group number 2');

-- --------------------------------------------------------

--
-- Table structure for table `team_performs`
--

CREATE TABLE `team_performs` (
  `gID` varchar(6) NOT NULL,
  `pID` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `team_performs`
--

INSERT INTO `team_performs` (`gID`, `pID`) VALUES
('1', '2'),
('2', '2');

-- --------------------------------------------------------

--
-- Table structure for table `trio`
--

CREATE TABLE `trio` (
  `gID` varchar(6) NOT NULL,
  `violin` varchar(50) NOT NULL,
  `cello` varchar(50) NOT NULL,
  `piano` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `trio`
--

INSERT INTO `trio` (`gID`, `violin`, `cello`, `piano`) VALUES
('1', 'Bret Shilliday', 'John Smith', 'Jane Doe');

-- --------------------------------------------------------

--
-- Table structure for table `violinist`
--

CREATE TABLE `violinist` (
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `violinist`
--

INSERT INTO `violinist` (`name`) VALUES
('Bret Shilliday'),
('Dominic Vandekerkhove');

-- --------------------------------------------------------

--
-- Table structure for table `violist`
--

CREATE TABLE `violist` (
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `violist`
--

INSERT INTO `violist` (`name`) VALUES
('Michael Scott');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `can_view`
--
ALTER TABLE `can_view`
  ADD KEY `can_view_ibfk_1` (`guestUsername`),
  ADD KEY `can_view_ibfk_2` (`pID`);

--
-- Indexes for table `cellist`
--
ALTER TABLE `cellist`
  ADD PRIMARY KEY (`name`);

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`classID`),
  ADD KEY `class_ibfk_1` (`tID`);

--
-- Indexes for table `composer`
--
ALTER TABLE `composer`
  ADD PRIMARY KEY (`cName`);

--
-- Indexes for table `group_can_edit`
--
ALTER TABLE `group_can_edit`
  ADD KEY `group_can_edit_ibfk_1` (`adminUsername`),
  ADD KEY `group_can_edit_ibfk_2` (`gID`);

--
-- Indexes for table `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `knows`
--
ALTER TABLE `knows`
  ADD KEY `knows_ibfk_1` (`performerName`),
  ADD KEY `knows_ibfk_2` (`pieceName`);

--
-- Indexes for table `level`
--
ALTER TABLE `level`
  ADD PRIMARY KEY (`levelID`);

--
-- Indexes for table `manages`
--
ALTER TABLE `manages`
  ADD KEY `manages_ibfk_1` (`adminUsername`),
  ADD KEY `manages_ibfk_2` (`classID`);

--
-- Indexes for table `performance`
--
ALTER TABLE `performance`
  ADD PRIMARY KEY (`perf_name`),
  ADD KEY `performance_ibfk_1` (`pID`),
  ADD KEY `performance_ibfk_2` (`piece_name`);

--
-- Indexes for table `performer`
--
ALTER TABLE `performer`
  ADD PRIMARY KEY (`name`),
  ADD KEY `performer_ibfk_1` (`classID`),
  ADD KEY `performer_ibfk_2` (`levelID`);

--
-- Indexes for table `pianist`
--
ALTER TABLE `pianist`
  ADD PRIMARY KEY (`name`);

--
-- Indexes for table `piece`
--
ALTER TABLE `piece`
  ADD PRIMARY KEY (`pName`),
  ADD KEY `piece_ibfk_1` (`c_name`);

--
-- Indexes for table `program`
--
ALTER TABLE `program`
  ADD PRIMARY KEY (`pID`);

--
-- Indexes for table `quartet`
--
ALTER TABLE `quartet`
  ADD PRIMARY KEY (`gID`),
  ADD KEY `quartet_ibfk_2` (`firstViolin`),
  ADD KEY `quartet_ibfk_3` (`secondViolin`),
  ADD KEY `quartet_ibfk_4` (`viola`),
  ADD KEY `quartet_ibfk_5` (`cello`);

--
-- Indexes for table `solo_performs`
--
ALTER TABLE `solo_performs`
  ADD PRIMARY KEY (`name`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`tID`);

--
-- Indexes for table `team`
--
ALTER TABLE `team`
  ADD PRIMARY KEY (`gID`);

--
-- Indexes for table `trio`
--
ALTER TABLE `trio`
  ADD PRIMARY KEY (`gID`),
  ADD KEY `trio_ibfk_2` (`violin`),
  ADD KEY `trio_ibfk_3` (`cello`),
  ADD KEY `trio_ibfk_4` (`piano`);

--
-- Indexes for table `violinist`
--
ALTER TABLE `violinist`
  ADD PRIMARY KEY (`name`);

--
-- Indexes for table `violist`
--
ALTER TABLE `violist`
  ADD PRIMARY KEY (`name`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `can_view`
--
ALTER TABLE `can_view`
  ADD CONSTRAINT `can_view_ibfk_1` FOREIGN KEY (`guestUsername`) REFERENCES `guest` (`username`) ON DELETE CASCADE,
  ADD CONSTRAINT `can_view_ibfk_2` FOREIGN KEY (`pID`) REFERENCES `program` (`pID`) ON DELETE CASCADE;

--
-- Constraints for table `cellist`
--
ALTER TABLE `cellist`
  ADD CONSTRAINT `cellist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`) ON DELETE CASCADE;

--
-- Constraints for table `class`
--
ALTER TABLE `class`
  ADD CONSTRAINT `class_ibfk_1` FOREIGN KEY (`tID`) REFERENCES `teacher` (`tID`) ON DELETE CASCADE;

--
-- Constraints for table `group_can_edit`
--
ALTER TABLE `group_can_edit`
  ADD CONSTRAINT `group_can_edit_ibfk_1` FOREIGN KEY (`adminUsername`) REFERENCES `admin` (`username`) ON DELETE CASCADE,
  ADD CONSTRAINT `group_can_edit_ibfk_2` FOREIGN KEY (`gID`) REFERENCES `team` (`gID`) ON DELETE CASCADE;

--
-- Constraints for table `knows`
--
ALTER TABLE `knows`
  ADD CONSTRAINT `knows_ibfk_1` FOREIGN KEY (`performerName`) REFERENCES `performer` (`name`) ON DELETE CASCADE,
  ADD CONSTRAINT `knows_ibfk_2` FOREIGN KEY (`pieceName`) REFERENCES `piece` (`pName`) ON DELETE CASCADE;

--
-- Constraints for table `manages`
--
ALTER TABLE `manages`
  ADD CONSTRAINT `manages_ibfk_1` FOREIGN KEY (`adminUsername`) REFERENCES `admin` (`username`) ON DELETE CASCADE,
  ADD CONSTRAINT `manages_ibfk_2` FOREIGN KEY (`classID`) REFERENCES `class` (`classID`) ON DELETE CASCADE;

--
-- Constraints for table `performance`
--
ALTER TABLE `performance`
  ADD CONSTRAINT `performance_ibfk_1` FOREIGN KEY (`pID`) REFERENCES `program` (`pID`) ON DELETE CASCADE,
  ADD CONSTRAINT `performance_ibfk_2` FOREIGN KEY (`piece_name`) REFERENCES `piece` (`pName`) ON DELETE CASCADE;

--
-- Constraints for table `performer`
--
ALTER TABLE `performer`
  ADD CONSTRAINT `performer_ibfk_1` FOREIGN KEY (`classID`) REFERENCES `class` (`classID`) ON DELETE CASCADE,
  ADD CONSTRAINT `performer_ibfk_2` FOREIGN KEY (`levelID`) REFERENCES `level` (`levelID`) ON DELETE CASCADE;

--
-- Constraints for table `pianist`
--
ALTER TABLE `pianist`
  ADD CONSTRAINT `pianist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`) ON DELETE CASCADE;

--
-- Constraints for table `piece`
--
ALTER TABLE `piece`
  ADD CONSTRAINT `piece_ibfk_1` FOREIGN KEY (`c_name`) REFERENCES `composer` (`cName`) ON DELETE CASCADE;

--
-- Constraints for table `quartet`
--
ALTER TABLE `quartet`
  ADD CONSTRAINT `quartet_ibfk_1` FOREIGN KEY (`gID`) REFERENCES `team` (`gID`),
  ADD CONSTRAINT `quartet_ibfk_2` FOREIGN KEY (`firstViolin`) REFERENCES `violinist` (`name`) ON DELETE CASCADE,
  ADD CONSTRAINT `quartet_ibfk_3` FOREIGN KEY (`secondViolin`) REFERENCES `violinist` (`name`) ON DELETE CASCADE,
  ADD CONSTRAINT `quartet_ibfk_4` FOREIGN KEY (`viola`) REFERENCES `violist` (`name`) ON DELETE CASCADE,
  ADD CONSTRAINT `quartet_ibfk_5` FOREIGN KEY (`cello`) REFERENCES `cellist` (`name`) ON DELETE CASCADE;

--
-- Constraints for table `trio`
--
ALTER TABLE `trio`
  ADD CONSTRAINT `trio_ibfk_1` FOREIGN KEY (`gID`) REFERENCES `team` (`gID`) ON DELETE CASCADE,
  ADD CONSTRAINT `trio_ibfk_2` FOREIGN KEY (`violin`) REFERENCES `violinist` (`name`) ON DELETE CASCADE,
  ADD CONSTRAINT `trio_ibfk_3` FOREIGN KEY (`cello`) REFERENCES `cellist` (`name`) ON DELETE CASCADE,
  ADD CONSTRAINT `trio_ibfk_4` FOREIGN KEY (`piano`) REFERENCES `pianist` (`name`) ON DELETE CASCADE;

--
-- Constraints for table `violinist`
--
ALTER TABLE `violinist`
  ADD CONSTRAINT `violinist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`) ON DELETE CASCADE;

--
-- Constraints for table `violist`
--
ALTER TABLE `violist`
  ADD CONSTRAINT `violist_ibfk_1` FOREIGN KEY (`name`) REFERENCES `performer` (`name`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
