-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 08, 2026 at 08:37 AM
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
-- Database: `dbml`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_hero`
--

CREATE TABLE `tb_hero` (
  `id_hero` int(11) NOT NULL,
  `nama_hero` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL,
  `counter` varchar(255) NOT NULL,
  `sinergi` varchar(255) NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_hero`
--

INSERT INTO `tb_hero` (`id_hero`, `nama_hero`, `role`, `counter`, `sinergi`, `gambar`) VALUES
(1, 'Dapa', 'Starategis', 'egsgs', 'sgsegsegs', 'C:\\\\Users\\\\ADMIN\\\\OneDrive\\\\Pictures\\\\tes\\\\ukkukukuku.jpg'),
(2, 'Ling', 'Assasin', 'Aamon, Akai, Aldous', 'Dyroth, Eudora, Franco', 'C:\\\\\\\\\\\\\\\\Users\\\\\\\\\\\\\\\\ADMIN\\\\\\\\\\\\\\\\OneDrive\\\\\\\\\\\\\\\\Pictures\\\\\\\\\\\\\\\\tes\\\\\\\\\\\\\\\\ukkukukuku.jpg'),
(4, 'Ling', 'Assasin', 'Aamon, Akai, Aldous', 'Dyroth, Eudora, Franco', 'C:\\\\\\\\\\\\\\\\Users\\\\\\\\\\\\\\\\ADMIN\\\\\\\\\\\\\\\\OneDrive\\\\\\\\\\\\\\\\Pictures\\\\\\\\\\\\\\\\tes\\\\\\\\\\\\\\\\ukkukukuku.jpg'),
(5, 'Gloo', 'Tank', 'Aldous, Alucard, Angela', 'Aldous, Alice, Arlott', 'C:\\\\Users\\\\ADMIN\\\\Downloads\\\\gloo.png'),
(6, 'Hanabi', 'Marksman', 'Gusion, Miya', 'Tigreal, Vexana', 'C:\\Images\\Hanabi.png'),
(7, 'Miya', 'Marksman', 'Gusion, Suyou', 'Tigreal, Hanabi', 'C:\\Images\\Miya.png'),
(8, 'Zetian', 'Mage', 'Gusion, Suyou', 'Tigreal, Vexana', 'C:\\Images\\Zetian.png'),
(9, 'Tigreal', 'Tank, Support', 'Vexana, Gusion', 'Hanabi, Miya', 'C:\\Images\\Tigreal.png'),
(10, 'Vexana', 'Mage', 'Gusion, Suyou', 'Tigreal, Zetian', 'C:\\Images\\Vexana.png'),
(11, 'Suyou', 'Assasin, Fighter', 'Tigreal, Vexana', 'Gusion, Miya', 'C:\\Images\\Suyou.png'),
(12, 'Gusion', 'Assasin, Mage', 'Tigreal, Zetian', 'Suyou, Vexana', 'C:\\Images\\Gusion.png');

-- --------------------------------------------------------

--
-- Table structure for table `tb_tierlist`
--

CREATE TABLE `tb_tierlist` (
  `id_tier` int(11) NOT NULL,
  `id_hero` int(11) NOT NULL,
  `lane` varchar(50) NOT NULL,
  `grade_tier` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_tierlist`
--

INSERT INTO `tb_tierlist` (`id_tier`, `id_hero`, `lane`, `grade_tier`) VALUES
(1, 0, 'Jungle', 'S'),
(2, 2, 'Jungle', 'S'),
(4, 4, 'ExpLane', 'C'),
(5, 5, 'ExpLane', 'A'),
(6, 6, 'GoldLane', 'B'),
(7, 7, 'GoldLane', 'C'),
(8, 8, 'MidLane', 'S'),
(9, 9, 'Roam', 'A'),
(10, 10, 'MidLane', 'A'),
(11, 11, 'ExpLane', 'S'),
(12, 12, 'Jungle', 'A');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_hero`
--
ALTER TABLE `tb_hero`
  ADD PRIMARY KEY (`id_hero`);

--
-- Indexes for table `tb_tierlist`
--
ALTER TABLE `tb_tierlist`
  ADD PRIMARY KEY (`id_tier`),
  ADD KEY `idHero` (`id_hero`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_hero`
--
ALTER TABLE `tb_hero`
  MODIFY `id_hero` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tb_tierlist`
--
ALTER TABLE `tb_tierlist`
  MODIFY `id_tier` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_tierlist`
--
ALTER TABLE `tb_tierlist`
  ADD CONSTRAINT `idHero` FOREIGN KEY (`id_hero`) REFERENCES `tb_hero` (`id_hero`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
