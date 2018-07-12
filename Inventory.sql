-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Jul 12, 2018 at 05:31 PM
-- Server version: 5.6.35
-- PHP Version: 7.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Inventory`
--
CREATE DATABASE IF NOT EXISTS `Inventory` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `Inventory`;

-- --------------------------------------------------------

--
-- Table structure for table `wines`
--

CREATE TABLE `wines` (
  `Id` int(11) NOT NULL,
  `Wine` varchar(255) NOT NULL,
  `yacht_id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `wines`
--

INSERT INTO `wines` (`Id`, `Wine`, `yacht_id`) VALUES
(12, 'Whatever', ''),
(13, 'chard', 'apple'),
(14, 'THE best', 'dingy');

-- --------------------------------------------------------

--
-- Table structure for table `yachts`
--

CREATE TABLE `yachts` (
  `Id` int(11) NOT NULL,
  `yacht` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `yachts`
--

INSERT INTO `yachts` (`Id`, `yacht`) VALUES
(22, 'yacht'),
(23, 'winer'),
(24, 'yacht'),
(25, 'yaaaacht'),
(26, 'apple');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `wines`
--
ALTER TABLE `wines`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `yachts`
--
ALTER TABLE `yachts`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `wines`
--
ALTER TABLE `wines`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `yachts`
--
ALTER TABLE `yachts`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
