-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Des 2023 pada 09.59
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kantin`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `checkout`
--

CREATE TABLE `checkout` (
  `Items` varchar(50) NOT NULL,
  `Price` varchar(24) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `id` int(3) NOT NULL,
  `username` varchar(50) NOT NULL,
  `phone_number` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`id`, `username`, `phone_number`) VALUES
(3, 'Jordan', '01824123'),
(4, 'chan', '082249739983');

-- --------------------------------------------------------

--
-- Struktur dari tabel `menu`
--

CREATE TABLE `menu` (
  `id` int(3) NOT NULL,
  `username` varchar(50) NOT NULL,
  `Orders` varchar(500) NOT NULL,
  `Table_Num` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `menu`
--

INSERT INTO `menu` (`id`, `username`, `Orders`, `Table_Num`) VALUES
(3, 'Jordan', 'Mie Cakalang x3, Rp.36000', 'D3'),
(4, 'chan', 'Ayam Geprek x1, Rp.15000 + Nasi Goreng x1, Rp.15000 + Nutri Sari x2, Rp.10000', NULL);

-- --------------------------------------------------------

--
-- Struktur dari tabel `order`
--

CREATE TABLE `order` (
  `ID` int(3) NOT NULL,
  `Nama` varchar(24) NOT NULL,
  `PhoneNum` varchar(16) NOT NULL,
  `TableNum` varchar(4) NOT NULL,
  `Items` varchar(300) NOT NULL,
  `Total` varchar(32) NOT NULL,
  `Payment` varchar(32) NOT NULL,
  `Kembalian` varchar(32) NOT NULL,
  `Date` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `order`
--

INSERT INTO `order` (`ID`, `Nama`, `PhoneNum`, `TableNum`, `Items`, `Total`, `Payment`, `Kembalian`, `Date`) VALUES
(12, 'jordy', '0812312312', 'B1', 'Nasi Goreng x2 Rp.30000 + Mie Cakalang x2 Rp.24000 + Air Mineral x2 Rp.10000', 'Rp.64000', 'Rp.100000', 'Rp.36000', '23/11/2023'),
(22, 'sky', '090909', 'D1', 'Mie Cakalang x2 Rp.24000 + Nutri Sari x2 Rp.10000 + Ayam Geprek x1 Rp.15000 + Nasi Goreng x1 Rp.15000 + Mie Kuah x1 Rp.10000 + Mie Cakalang x1 Rp.12000 + Air Mineral x1 Rp.5000 + Nutri Sari x1 Rp.5000', 'Rp.96000', 'Rp.100000', 'Rp.4000', '23/11/2023'),
(123, 'cc', '08123456', 'B3', 'Ayam Geprek x1 Rp.15000 + Mie Cakalang x1 Rp.12000 + Nutri Sari x1 Rp.5000 + Mie Cakalang x3 Rp.36000 + Air Mineral x2 Rp.10000', 'Rp.78000', 'Rp.100000', 'Rp.22000', '23/11/2023');

-- --------------------------------------------------------

--
-- Struktur dari tabel `signup`
--

CREATE TABLE `signup` (
  `username` varchar(16) NOT NULL,
  `first_name` varchar(24) DEFAULT NULL,
  `last_name` varchar(24) DEFAULT NULL,
  `phone_number` varchar(15) DEFAULT NULL,
  `Date_of_Birth` varchar(10) DEFAULT NULL,
  `Age` int(2) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Password` varchar(24) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `signup`
--

INSERT INTO `signup` (`username`, `first_name`, `last_name`, `phone_number`, `Date_of_Birth`, `Age`, `Email`, `Password`) VALUES
('', '', '', '', 'Kamis, 09 ', 0, '', ''),
('admin', 'Chandra', 'Waturandang', '082747182', 'Selasa, 31', 20, 'Channy@gmail.com', 'admin'),
('chan', 'chan', 'waturandang', '082248739983', 'Senin, 22 ', 20, 'chanwaturandang22@gmail.com', 'chan2003');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`ID`);

--
-- Indeks untuk tabel `signup`
--
ALTER TABLE `signup`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
