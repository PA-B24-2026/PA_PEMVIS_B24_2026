-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2026 at 02:30 AM
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
(11, 'Aulus', 'Fighter', 'Deskripsi Aulus', 'Aulus.png'),
(12, 'Aurora', 'Mage', 'Deskripsi Aurora', 'Aurora.png'),
(13, 'Badang', 'Fighter', 'Deskripsi Badang', 'Badang.png'),
(14, 'Balmond', 'Fighter', 'Deskripsi Balmond', 'Balmond.png'),
(15, 'Bane', 'Fighter', 'Deskripsi Bane', 'Bane.png'),
(16, 'Barats', 'Tank', 'Deskripsi Barats', 'Barats.png'),
(17, 'Baxia', 'Tank', 'Deskripsi Baxia', 'Baxia.png'),
(18, 'Beatrix', 'Marksman', 'Deskripsi Beatrix', 'Beatrix.png'),
(19, 'Belerick', 'Tank', 'Deskripsi Belerick', 'Belerick.png'),
(20, 'Benedetta', 'Assasin', 'Deskripsi Benedetta', 'Benedetta.png'),
(21, 'Brody', 'Marksman', 'Deskripsi Brody', 'Brody.png'),
(22, 'Bruno', 'Marksman', 'Deskripsi Bruno', 'Bruno.png'),
(23, 'Carmilla', 'Support', 'Deskripsi Carmilla', 'Carmilla.png'),
(24, 'Cecilion', 'Mage', 'Deskripsi Cecilion', 'Cecilion.png'),
(25, 'Chang\'e', 'Mage', 'Deskripsi Chang\'e', 'Chang\'e.png'),
(26, 'Chip', 'Tank', 'Deskripsi Chip', 'Chip.png'),
(27, 'Chou', 'Fighter', 'Deskripsi Chou', 'Chou.png'),
(28, 'Cici', 'Fighter', 'Deskripsi Cici', 'Cici.png'),
(29, 'Claude', 'Marksman', 'Deskripsi Claude', 'Claude.png'),
(30, 'Clint', 'Marksman', 'Deskripsi Clint', 'Clint.png'),
(31, 'Cyclops', 'Mage', 'Deskripsi Cyclops', 'Cyclops.png'),
(32, 'Diggie', 'Support', 'Deskripsi Diggie', 'Diggie.png'),
(33, 'Dyrroth', 'Fighter', 'Deskripsi Dyrroth', 'Dyrroth.png'),
(34, 'Edith', 'Tank', 'Deskripsi Edith', 'Edith.png'),
(35, 'Esmeralda', 'Mage', 'Deskripsi Esmeralda', 'Esmeralda.png'),
(36, 'Estes', 'Support', 'Deskripsi Estes', 'Estes.png'),
(37, 'Eudora', 'Mage', 'Deskripsi Eudora', 'Eudora.png'),
(38, 'Fanny', 'Assasin', 'Deskripsi Fanny', 'Fanny.png'),
(39, 'Faramis', 'Support', 'Deskripsi Faramis', 'Faramis.png'),
(40, 'Floryn', 'Support', 'Deskripsi Floryn', 'Floryn.png'),
(41, 'Franco', 'Tank', 'Deskripsi Franco', 'Franco.png'),
(42, 'Fredrinn', 'Tank', 'Deskripsi Fredrinn', 'Fredrinn.png'),
(43, 'Freya', 'Fighter', 'Deskripsi Freya', 'Freya.png'),
(44, 'Gatotkaca', 'Tank', 'Deskripsi Gatotkaca', 'Gatotkaca.png'),
(45, 'Gloo', 'Tank', 'Deskripsi Gloo', 'Gloo.png'),
(46, 'Gord', 'Mage', 'Deskripsi Gord', 'Gord.png'),
(47, 'Granger', 'Marksman', 'Deskripsi Granger', 'Granger.png'),
(48, 'Grock', 'Tank', 'Deskripsi Grock', 'Grock.png'),
(49, 'Guinevere', 'Fighter', 'Deskripsi Guinevere', 'Guinevere.png'),
(50, 'Gusion', 'Assasin', 'Deskripsi Gusion', 'Gusion.png'),
(51, 'Hanabi', 'Marksman', 'Deskripsi Hanabi', 'Hanabi.png'),
(52, 'Hanzo', 'Assasin', 'Deskripsi Hanzo', 'Hanzo.png'),
(53, 'Harith', 'Mage', 'Deskripsi Harith', 'Harith.png'),
(54, 'Harley', 'Mage', 'Deskripsi Harley', 'Harley.png'),
(55, 'Hayabusa', 'Assasin', 'Deskripsi Hayabusa', 'Hayabusa.png'),
(56, 'Helcurt', 'Assasin', 'Deskripsi Helcurt', 'Helcurt.png'),
(57, 'Hilda', 'Fighter', 'Deskripsi Hilda', 'Hilda.png'),
(58, 'Hylos', 'Tank', 'Deskripsi Hylos', 'Hylos.png'),
(59, 'Irithel', 'Marksman', 'Deskripsi Irithel', 'Irithel.png'),
(60, 'Ixia', 'Marksman', 'Deskripsi Ixia', 'Ixia.png'),
(61, 'Jawhead', 'Fighter', 'Deskripsi Jawhead', 'Jawhead.png'),
(62, 'Johnson', 'Tank', 'Deskripsi Johnson', 'Johnson.png'),
(63, 'Joy', 'Assasin', 'Deskripsi Joy', 'Joy.png'),
(64, 'Julian', 'Fighter', 'Deskripsi Julian', 'Julian.png'),
(65, 'Kadita', 'Mage', 'Deskripsi Kadita', 'Kadita.png'),
(66, 'Kagura', 'Mage', 'Deskripsi Kagura', 'Kagura.png'),
(67, 'Kaja', 'Fighter', 'Deskripsi Kaja', 'Kaja.png'),
(68, 'Kalea', 'Support', 'Deskripsi Kalea', 'Kalea.png'),
(69, 'Karina', 'Assasin', 'Deskripsi Karina', 'Karina.png'),
(70, 'Karrie', 'Marksman', 'Deskripsi Karrie', 'Karrie.png'),
(71, 'Khaleed', 'Fighter', 'Deskripsi Khaleed', 'Khaleed.png'),
(72, 'Khufra', 'Tank', 'Deskripsi Khufra', 'Khufra.png'),
(73, 'Kimmy', 'Marksman', 'Deskripsi Kimmy', 'Kimmy.png'),
(74, 'Lancelot', 'Assasin', 'Deskripsi Lancelot', 'Lancelot.png'),
(75, 'Lapu-Lapu', 'Fighter', 'Deskripsi Lapu-Lapu', 'Lapu-Lapu.png'),
(76, 'Layla', 'Marksman', 'Deskripsi Layla', 'Layla.png'),
(77, 'Leomord', 'Fighter', 'Deskripsi Leomord', 'Leomord.png'),
(78, 'Lesley', 'Marksman', 'Deskripsi Lesley', 'Lesley.png'),
(79, 'Ling', 'Assasin', 'Deskripsi Ling', 'Ling.png'),
(80, 'Lolita', 'Tank', 'Deskripsi Lolita', 'Lolita.png'),
(81, 'Lukas', 'Fighter', 'Deskripsi Lukas', 'Lukas.png'),
(82, 'Lunox', 'Mage', 'Deskripsi Lunox', 'Lunox.png'),
(83, 'Luo Yi', 'Mage', 'Deskripsi Luo Yi', 'Luo Yi.png'),
(84, 'Lylia', 'Mage', 'Deskripsi Lylia', 'Lylia.png'),
(85, 'Marcel', 'Support', 'Deskripsi Marcel', 'Marcel.png'),
(86, 'Martis', 'Fighter', 'Deskripsi Martis', 'Martis.png'),
(87, 'Masha', 'Fighter', 'Deskripsi Masha', 'Masha.png'),
(88, 'Mathilda', 'Support', 'Deskripsi Mathilda', 'Mathilda.png'),
(89, 'Melissa', 'Marksman', 'Deskripsi Melissa', 'Melissa.png'),
(90, 'Minotaur', 'Tank', 'Deskripsi Minotaur', 'Minotaur.png'),
(91, 'Minsitthar', 'Fighter', 'Deskripsi Minsitthar', 'Minsitthar.png'),
(92, 'Miya', 'Marksman', 'Deskripsi Miya', 'Miya.png'),
(93, 'Moskov', 'Marksman', 'Deskripsi Moskov', 'Moskov.png'),
(94, 'Nana', 'Mage', 'Deskripsi Nana', 'Nana.png'),
(95, 'Natalia', 'Assasin', 'Deskripsi Natalia', 'Natalia.png'),
(96, 'Natan', 'Marksman', 'Deskripsi Natan', 'Natan.png'),
(97, 'Nolan', 'Assasin', 'Deskripsi Nolan', 'Nolan.png'),
(98, 'Novaria', 'Mage', 'Deskripsi Novaria', 'Novaria.png'),
(99, 'Obsidia', 'Marksman', 'Deskripsi Obsidia', 'Obsidia.png'),
(100, 'Odette', 'Mage', 'Deskripsi Odette', 'Odette.png'),
(101, 'Paquito', 'Fighter', 'Deskripsi Paquito', 'Paquito.png'),
(102, 'Pharsa', 'Mage', 'Deskripsi Pharsa', 'Pharsa.png'),
(103, 'Phoveus', 'Fighter', 'Deskripsi Phoveus', 'Phoveus.png'),
(104, 'Popol & Kupa', 'Marksman', 'Deskripsi Popol & Kupa', 'Popol & Kupa.png'),
(105, 'Rafaela', 'Support', 'Deskripsi Rafaela', 'Rafaela.png'),
(106, 'Roger', 'Fighter', 'Deskripsi Roger', 'Roger.png'),
(107, 'Ruby', 'Fighter', 'Deskripsi Ruby', 'Ruby.png'),
(108, 'Saber', 'Assasin', 'Deskripsi Saber', 'Saber.png'),
(109, 'Selena', 'Assasin', 'Deskripsi Selena', 'Selena.png'),
(110, 'Silvanna', 'Fighter', 'Deskripsi Silvanna', 'Silvanna.png'),
(111, 'Sora', 'Fighter', 'Deskripsi Sora', 'Sora.png'),
(112, 'Sun', 'Fighter', 'Deskripsi Sun', 'Sun.png'),
(113, 'Suyou', 'Assasin', 'Deskripsi Suyou', 'Suyou.png'),
(114, 'Terizla', 'Fighter', 'Deskripsi Terizla', 'Terizla.png'),
(115, 'Thamuz', 'Fighter', 'Deskripsi Thamuz', 'Thamuz.png'),
(116, 'Tigreal', 'Tank', 'Deskripsi Tigreal', 'Tigreal.png'),
(117, 'Uranus', 'Tank', 'Deskripsi Uranus', 'Uranus.png'),
(118, 'Vale', 'Mage', 'Deskripsi Vale', 'Vale.png'),
(119, 'Valentina', 'Mage', 'Deskripsi Valentina', 'Valentina.png'),
(120, 'Valir', 'Mage', 'Deskripsi Valir', 'Valir.png'),
(121, 'Vexana', 'Mage', 'Deskripsi Vexana', 'Vexana.png'),
(122, 'Wanwan', 'Marksman', 'Deskripsi Wanwan', 'Wanwan.png'),
(123, 'X.Borg', 'Fighter', 'Deskripsi X.Borg', 'X.Borg.png'),
(124, 'Xavier', 'Mage', 'Deskripsi Xavier', 'Xavier.png'),
(125, 'Yi Sun-shin', 'Marksman', 'Deskripsi Yi Sun-shin', 'Yi Sun-shin.png'),
(126, 'Yin', 'Fighter', 'Deskripsi Yin', 'Yin.png'),
(127, 'Yu Zhong', 'Fighter', 'Deskripsi Yu Zhong', 'Yu Zhong.png'),
(128, 'Yve', 'Mage', 'Deskripsi Yve', 'Yve.png'),
(129, 'Zetian', 'Mage', 'Deskripsi Zetian', 'Zetian.png'),
(130, 'Zhask', 'Mage', 'Deskripsi Zhask', 'Zhask.png'),
(131, 'Zhuxin', 'Mage', 'Deskripsi Zhuxin', 'Zhuxin.png'),
(132, 'Zilong', 'Fighter', 'Deskripsi Zilong', 'Zilong.png');

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
(1, 78, 'Jungle', 'S'),
(2, 1, 'Jungle', 'A'),
(3, 4, 'MidLane', 'S'),
(4, 92, 'GoldLane', 'B');

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
  MODIFY `id_hero` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=133;

--
-- AUTO_INCREMENT for table `tb_tierlist`
--
ALTER TABLE `tb_tierlist`
  MODIFY `id_tier` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
