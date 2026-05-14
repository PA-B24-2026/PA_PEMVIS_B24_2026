-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2026 at 08:09 PM
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
  `deskripsi` text DEFAULT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_hero`
--

INSERT INTO `tb_hero` (`id_hero`, `nama_hero`, `role`, `deskripsi`, `gambar`) VALUES
(1, 'Aamon', 'Assasin', 'Deskripsi Aamon', 'Aamon.png'),
(2, 'Akai', 'Tank', 'Deskripsi Akai', 'Akai.png'),
(3, 'Aldous', 'Fighter', 'Deskripsi Aldous', 'Aldous.png'),
(4, 'Alice', 'Mage', 'Deskripsi Alice', 'Alice.png'),
(5, 'Alpha', 'Fighter', 'Deskripsi Alpha', 'Alpha.png'),
(6, 'Alucard', 'Fighter', 'Deskripsi Alucard', 'Alucard.png'),
(7, 'Angela', 'Support', 'Deskripsi Angela', 'Angela.png'),
(8, 'Argus', 'Fighter', 'Deskripsi Argus', 'Argus.png'),
(9, 'Arlott', 'Fighter', 'Deskripsi Arlott', 'Arlott.png'),
(10, 'Atlas', 'Tank', 'Deskripsi Atlas', 'Atlas.png'),
(11, 'Aurora', 'Mage', 'Deskripsi Aurora', 'Aurora.png'),
(12, 'Badang', 'Fighter', 'Deskripsi Badang', 'Badang.png'),
(13, 'Balmond', 'Fighter', 'Deskripsi Balmond', 'Balmond.png'),
(14, 'Bane', 'Fighter', 'Deskripsi Bane', 'Bane.png'),
(15, 'Barats', 'Tank', 'Deskripsi Barats', 'Barats.png'),
(16, 'Baxia', 'Tank', 'Deskripsi Baxia', 'Baxia.png'),
(17, 'Beatrix', 'Marksman', 'Deskripsi Beatrix', 'Beatrix.png'),
(18, 'Belerick', 'Tank', 'Deskripsi Belerick', 'Belerick.png'),
(19, 'Benedetta', 'Assasin', 'Deskripsi Benedetta', 'Benedetta.png'),
(20, 'Brody', 'Marksman', 'Deskripsi Brody', 'Brody.png'),
(21, 'Bruno', 'Marksman', 'Deskripsi Bruno', 'Bruno.png'),
(22, 'Carmilla', 'Support', 'Deskripsi Carmilla', 'Carmilla.png'),
(23, 'Cecilion', 'Mage', 'Deskripsi Cecilion', 'Cecilion.png'),
(24, 'Chang\'e', 'Mage', 'Deskripsi Chang\'e', 'Chang\'e.png'),
(25, 'Chip', 'Tank', 'Deskripsi Chip', 'Chip.png'),
(26, 'Chou', 'Fighter', 'Deskripsi Chou', 'Chou.png'),
(27, 'Cici', 'Fighter', 'Deskripsi Cici', 'Cici.png'),
(28, 'Claude', 'Marksman', 'Deskripsi Claude', 'Claude.png'),
(29, 'Clint', 'Marksman', 'Deskripsi Clint', 'Clint.png'),
(30, 'Cyclops', 'Mage', 'Deskripsi Cyclops', 'Cyclops.png'),
(31, 'Diggie', 'Support', 'Deskripsi Diggie', 'Diggie.png'),
(32, 'Dyroth', 'Fighter', 'Deskripsi Dyroth', 'Dyroth.png'),
(33, 'Esmeralda', 'Mage', 'Deskripsi Esmeralda', 'Esmeralda.png'),
(34, 'Estes', 'Support', 'Deskripsi Estes', 'Estes.png'),
(35, 'Eudora', 'Mage', 'Deskripsi Eudora', 'Eudora.png'),
(36, 'Faramis', 'Support', 'Deskripsi Faramis', 'Faramis.png'),
(37, 'Fanny', 'Assasin', 'Deskripsi Fanny', 'Fanny.png'),
(38, 'Franco', 'Tank', 'Deskripsi Franco', 'Franco.png'),
(39, 'Fredrinn', 'Tank', 'Deskripsi Fredrinn', 'Fredrinn.png'),
(40, 'Freya', 'Fighter', 'Deskripsi Freya', 'Freya.png'),
(41, 'Gatotkaca', 'Tank', 'Deskripsi Gatotkaca', 'Gatotkaca.png'),
(42, 'Gloo', 'Tank', 'Deskripsi Gloo', 'Gloo.png'),
(43, 'Gord', 'Mage', 'Deskripsi Gord', 'Gord.png'),
(44, 'Granger', 'Marksman', 'Deskripsi Granger', 'Granger.png'),
(45, 'Grock', 'Tank', 'Deskripsi Grock', 'Grock.png'),
(46, 'Guinevere', 'Fighter', 'Deskripsi Guinevere', 'Guinevere.png'),
(47, 'Gusion', 'Assasin', 'Deskripsi Gusion', 'Gusion.png'),
(48, 'Hanabi', 'Marksman', 'Deskripsi Hanabi', 'Hanabi.png'),
(49, 'Hanzo', 'Assasin', 'Deskripsi Hanzo', 'Hanzo.png'),
(50, 'Harley', 'Mage', 'Deskripsi Harley', 'Harley.png'),
(51, 'Harith', 'Mage', 'Deskripsi Harith', 'Harith.png'),
(52, 'Hayabusa', 'Assasin', 'Deskripsi Hayabusa', 'Hayabusa.png'),
(53, 'Helcurt', 'Assasin', 'Deskripsi Helcurt', 'Helcurt.png'),
(54, 'Hilda', 'Fighter', 'Deskripsi Hilda', 'Hilda.png'),
(55, 'Hylos', 'Tank', 'Deskripsi Hylos', 'Hylos.png'),
(56, 'Irithel', 'Marksman', 'Deskripsi Irithel', 'Irithel.png'),
(57, 'Ixia', 'Marksman', 'Deskripsi Ixia', 'Ixia.png'),
(58, 'Jawhead', 'Fighter', 'Deskripsi Jawhead', 'Jawhead.png'),
(59, 'Johnson', 'Tank', 'Deskripsi Johnson', 'Johnson.png'),
(60, 'Joy', 'Assasin', 'Deskripsi Joy', 'Joy.png'),
(61, 'Julian', 'Fighter', 'Deskripsi Julian', 'Julian.png'),
(62, 'Kadita', 'Mage', 'Deskripsi Kadita', 'Kadita.png'),
(63, 'Kagura', 'Mage', 'Deskripsi Kagura', 'Kagura.png'),
(64, 'Kaja', 'Fighter', 'Deskripsi Kaja', 'Kaja.png'),
(65, 'Karrie', 'Marksman', 'Deskripsi Karrie', 'Karrie.png'),
(66, 'Karina', 'Assasin', 'Deskripsi Karina', 'Karina.png'),
(67, 'Khaleed', 'Fighter', 'Deskripsi Khaleed', 'Khaleed.png'),
(68, 'Khufra', 'Tank', 'Deskripsi Khufra', 'Khufra.png'),
(69, 'Kimmy', 'Marksman', 'Deskripsi Kimmy', 'Kimmy.png'),
(70, 'Lancelot', 'Assasin', 'Deskripsi Lancelot', 'Lancelot.png'),
(71, 'Lapu-Lapu', 'Fighter', 'Deskripsi Lapu-Lapu', 'Lapu-Lapu.png'),
(72, 'Layla', 'Marksman', 'Deskripsi Layla', 'Layla.png'),
(73, 'Leomord', 'Fighter', 'Deskripsi Leomord', 'Leomord.png'),
(74, 'Lesley', 'Marksman', 'Deskripsi Lesley', 'Lesley.png'),
(75, 'Ling', 'Assasin', 'Deskripsi Ling', 'Ling.png'),
(76, 'Lolita', 'Tank', 'Deskripsi Lolita', 'Lolita.png'),
(77, 'Lunox', 'Mage', 'Deskripsi Lunox', 'Lunox.png'),
(78, 'Luo Yi', 'Mage', 'Deskripsi Luo Yi', 'Luo Yi.png'),
(79, 'Lylia', 'Mage', 'Deskripsi Lylia', 'Lylia.png'),
(80, 'Martis', 'Fighter', 'Deskripsi Martis', 'Martis.png'),
(81, 'Masha', 'Fighter', 'Deskripsi Masha', 'Masha.png'),
(82, 'Mathilda', 'Support', 'Deskripsi Mathilda', 'Mathilda.png'),
(83, 'Melissa', 'Marksman', 'Deskripsi Melissa', 'Melissa.png'),
(84, 'Minotaur', 'Tank', 'Deskripsi Minotaur', 'Minotaur.png'),
(85, 'Minsitthar', 'Fighter', 'Deskripsi Minsitthar', 'Minsitthar.png'),
(86, 'Miya', 'Marksman', 'Deskripsi Miya', 'Miya.png'),
(87, 'Moskov', 'Marksman', 'Deskripsi Moskov', 'Moskov.png'),
(88, 'Nana', 'Mage', 'Deskripsi Nana', 'Nana.png'),
(89, 'Natalia', 'Assasin', 'Deskripsi Natalia', 'Natalia.png'),
(90, 'Nathan', 'Marksman', 'Deskripsi Nathan', 'Nathan.png'),
(91, 'Nolan', 'Assasin', 'Deskripsi Nolan', 'Nolan.png'),
(92, 'Novaria', 'Mage', 'Deskripsi Novaria', 'Novaria.png'),
(93, 'Odette', 'Mage', 'Deskripsi Odette', 'Odette.png'),
(94, 'Paquito', 'Fighter', 'Deskripsi Paquito', 'Paquito.png'),
(95, 'Pharsa', 'Mage', 'Deskripsi Pharsa', 'Pharsa.png'),
(96, 'Phoveus', 'Fighter', 'Deskripsi Phoveus', 'Phoveus.png'),
(97, 'Popol & Kupa', 'Marksman', 'Deskripsi Popol & Kupa', 'Popol & Kupa.png'),
(98, 'Rafaela', 'Support', 'Deskripsi Rafaela', 'Rafaela.png'),
(99, 'Roger', 'Fighter', 'Deskripsi Roger', 'Roger.png'),
(100, 'Ruby', 'Fighter', 'Deskripsi Ruby', 'Ruby.png'),
(101, 'Saber', 'Assasin', 'Deskripsi Saber', 'Saber.png'),
(102, 'Selena', 'Assasin', 'Deskripsi Selena', 'Selena.png'),
(103, 'Silvanna', 'Fighter', 'Deskripsi Silvanna', 'Silvanna.png'),
(104, 'Sun', 'Fighter', 'Deskripsi Sun', 'Sun.png'),
(105, 'Terizla', 'Fighter', 'Deskripsi Terizla', 'Terizla.png'),
(106, 'Thamuz', 'Fighter', 'Deskripsi Thamuz', 'Thamuz.png'),
(107, 'Tigreal', 'Tank', 'Deskripsi Tigreal', 'Tigreal.png'),
(108, 'Uranus', 'Tank', 'Deskripsi Uranus', 'Uranus.png'),
(109, 'Vale', 'Mage', 'Deskripsi Vale', 'Vale.png'),
(110, 'Valentina', 'Mage', 'Deskripsi Valentina', 'Valentina.png'),
(111, 'Valir', 'Mage', 'Deskripsi Valir', 'Valir.png'),
(112, 'Vexana', 'Mage', 'Deskripsi Vexana', 'Vexana.png'),
(113, 'Wanwan', 'Marksman', 'Deskripsi Wanwan', 'Wanwan.png'),
(114, 'Xavier', 'Mage', 'Deskripsi Xavier', 'Xavier.png'),
(115, 'X.Borg', 'Fighter', 'Deskripsi X.Borg', 'X.Borg.png'),
(116, 'Yi Sun-shin', 'Marksman', 'Deskripsi Yi Sun-shin', 'Yi Sun-shin.png'),
(117, 'Yin', 'Fighter', 'Deskripsi Yin', 'Yin.png'),
(118, 'Yu Zhong', 'Fighter', 'Deskripsi Yu Zhong', 'Yu Zhong.png'),
(119, 'Yve', 'Mage', 'Deskripsi Yve', 'Yve.png'),
(120, 'Zhask', 'Mage', 'Deskripsi Zhask', 'Zhask.png'),
(121, 'Zhuxin', 'Mage', 'Deskripsi Zhuxin', 'Zhuxin.png');

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
(1, 74, 'Jungle', 'S'),
(2, 1, 'Jungle', 'A'),
(3, 4, 'MidLane', 'S'),
(4, 86, 'GoldLane', 'B');

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
  ADD KEY `fk_hero` (`id_hero`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_hero`
--
ALTER TABLE `tb_hero`
  MODIFY `id_hero` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=124;

--
-- AUTO_INCREMENT for table `tb_tierlist`
--
ALTER TABLE `tb_tierlist`
  MODIFY `id_tier` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_tierlist`
--
ALTER TABLE `tb_tierlist`
  ADD CONSTRAINT `fk_hero_tierlist` FOREIGN KEY (`id_hero`) REFERENCES `tb_hero` (`id_hero`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
