-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 24, 2021 at 05:13 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gc`
--

-- --------------------------------------------------------

--
-- Table structure for table `sell`
--

CREATE TABLE `sell` (
  `Seller_Name` varchar(50) NOT NULL,
  `Seller_Phone` varchar(50) NOT NULL,
  `zone` varchar(50) NOT NULL,
  `Amount` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT '1',
  `Buyer_Name` varchar(50) NOT NULL DEFAULT '0',
  `id` int(50) NOT NULL,
  `Buyer_Phone` varchar(50) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sell`
--

INSERT INTO `sell` (`Seller_Name`, `Seller_Phone`, `zone`, `Amount`, `status`, `Buyer_Name`, `id`, `Buyer_Phone`) VALUES
('imran md', '015', 'DHAKA', '11', '3', 'rakib khan', 1, '017'),
('imran md', '015', 'DHAKA', '12', '3', 'rakib khan', 2, '017'),
('imran md', '015', 'DHAKA', '15', '3', 'rakib khan', 5, '017'),
('imran md', '015', 'DHAKA', '11', '3', 'rakib khan', 6, '017'),
('imran md', '015', 'DHAKA', '30', '3', 'rakib khan', 7, '017'),
('imran md', '015', 'DHAKA', '22', '3', 'rakib khan', 8, '017'),
('imran md', '015', 'DHAKA', '35', '3', 'sab', 9, '016'),
('imran md', '015', 'DHAKA', '70', '3', 'sab', 10, '016'),
('imran md', '015', 'DHAKA', '100', '3', 'sab', 11, '016'),
('imran md', '015', 'DHAKA', '55', '3', 'sab', 12, '016'),
('asd', '0123', 'DHAKA', '55', '3', 'sab', 13, '016'),
('imran md', '015', 'DHAKA', '12', '3', 'sab', 14, '016'),
('imran md', '015', 'DHAKA', '59', '3', 'sab', 15, '016');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `name` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `zone` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`name`, `phone`, `pass`, `zone`, `type`) VALUES
('asd', '0123', '1234', 'DHAKA', 'Seller'),
('imran md', '015', '1234', 'DHAKA', 'Seller'),
('sab', '016', '12345', 'DHAKA', 'Buyer'),
('rakib khan', '017', '1234', 'DHAKA', 'Buyer'),
('tofael khan', '017790', '12345', 'CHITTAGONG', 'Seller'),
('Mahtab', '019', '1234', 'CHITTAGONG', 'Buyer');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `sell`
--
ALTER TABLE `sell`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`phone`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `sell`
--
ALTER TABLE `sell`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
