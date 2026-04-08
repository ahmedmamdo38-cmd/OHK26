-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 08, 2026 at 07:22 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerId` int(25) NOT NULL,
  `FirstName` varchar(25) NOT NULL,
  `Surname` varchar(35) NOT NULL,
  `Address` varchar(30) NOT NULL,
  `PostOffice` varchar(35) NOT NULL,
  `PostalCode` varchar(15) NOT NULL,
  `Username` varchar(15) NOT NULL,
  `Password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerId`, `FirstName`, `Surname`, `Address`, `PostOffice`, `PostalCode`, `Username`, `Password`) VALUES
(18082006, 'Ahmed', 'Mamdo', 'Koskenmäki', 'Tuusula', '04300', 'ahmed.mamdo', '2305'),
(18082008, 'Jyri', 'Lindroos', 'Keskikatu', 'Kereva', '04200', 'jyrlind', '1243'),
(18082009, 'Haben', 'Tsequ', 'Keravankatu', 'Kerava', '04200', 'habteq', '20343'),
(18082010, 'jfebefe', 'jfjefje', 'ejhejfjef', 'jjfjdd', '8669', 'idfwiohf', '7979'),
(18082011, 'dfffv', 'svvedasv', 'vsfavs', ' vsbf', '23423', 'dsgfv', '32343');

-- --------------------------------------------------------

--
-- Table structure for table `resevertion`
--

CREATE TABLE `resevertion` (
  `ResevertionId` int(25) NOT NULL,
  `RoomNro` int(25) NOT NULL,
  `CustomerId` varchar(35) NOT NULL,
  `ResevertionStart` datetime(6) NOT NULL,
  `ResevertionFinish` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `roomcategory`
--

CREATE TABLE `roomcategory` (
  `CategoryId` int(25) NOT NULL,
  `RoomType` varchar(25) NOT NULL,
  `Price` int(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `roomcategory`
--

INSERT INTO `roomcategory` (`CategoryId`, `RoomType`, `Price`) VALUES
(1, 'For One Person', 120),
(2, 'For Two Persons', 90),
(3, 'Family', 150),
(4, 'Sviitti', 300);

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `RoomId` int(25) NOT NULL,
  `RoomType` int(25) NOT NULL,
  `Phone` varchar(35) NOT NULL,
  `Free` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`RoomId`, `RoomType`, `Phone`, `Free`) VALUES
(1122334455, 1, '1123048', 'Yes');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerId`);

--
-- Indexes for table `resevertion`
--
ALTER TABLE `resevertion`
  ADD PRIMARY KEY (`ResevertionId`);

--
-- Indexes for table `roomcategory`
--
ALTER TABLE `roomcategory`
  ADD PRIMARY KEY (`CategoryId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerId` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18082012;

--
-- AUTO_INCREMENT for table `resevertion`
--
ALTER TABLE `resevertion`
  MODIFY `ResevertionId` int(25) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
