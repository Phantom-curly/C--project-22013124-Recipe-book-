-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 14, 2023 at 10:42 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csharpproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `recipes`
--

CREATE TABLE `recipes` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Ingredients` text NOT NULL,
  `Description` text NOT NULL,
  `Tags` text NOT NULL,
  `Image` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `recipes`
--

INSERT INTO `recipes` (`ID`, `Name`, `Ingredients`, `Description`, `Tags`, `Image`) VALUES
(1, 'Burger', 'meat, bread, lettuce', 'al together ', 'lunch, dinner', ''),
(2, 'burger', 'sss', 'sss', 'sss', ''),
(3, 'burger2', 'bulka, kotleta', 'kotleta mej bulok', 'lunch, dinner', 0x53797374656d2e427974655b5d),
(4, 'fried eggs', 'eggs 2\r\nolive oil 15ml', 'preheat oil on a pan and fry the eggs on both sides for about 3 mins', 'breakfast', 0x53797374656d2e427974655b5d),
(5, 'fried eggs', 'eggs \r\noil', 'cook eggs in oil', 'breakfast', 0x53797374656d2e427974655b5d);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(15) UNSIGNED NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Surname` varchar(30) NOT NULL,
  `login` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `Name`, `Surname`, `login`, `password`) VALUES
(1, '', '', 'Dilmurod', '123'),
(2, 'Gordon', 'Ramsy', 'Ramsy', '123'),
(4, 'Dilmurod', 'Toshtemirov', 'Dilmurod123', '123'),
(5, 'Dilmurod', 'Tosh', 'tosh123', '123'),
(6, 'd', 't', 'dt', 'dt'),
(7, 'dilmurod', 'toshtemirov', 'user', 'user'),
(8, 'dilmurod', 'toshtemirov', 'murmur', 'murmur');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `recipes`
--
ALTER TABLE `recipes`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `recipes`
--
ALTER TABLE `recipes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
