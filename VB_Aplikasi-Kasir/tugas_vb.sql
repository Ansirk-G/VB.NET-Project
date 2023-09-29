-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 13, 2022 at 02:54 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tugas_vb`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_barang`
--

CREATE TABLE `data_barang` (
  `id_barang` int(11) NOT NULL,
  `nama_barang` varchar(255) NOT NULL,
  `kategori` varchar(255) NOT NULL,
  `stock` int(11) NOT NULL,
  `harga_beli` int(11) NOT NULL,
  `harga_jual` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_barang`
--

INSERT INTO `data_barang` (`id_barang`, `nama_barang`, `kategori`, `stock`, `harga_beli`, `harga_jual`) VALUES
(134121, 'DBL Go', 'speaker', 4, 320000, 420000),
(134122, 'DBL Flip', 'speaker', 2, 1785000, 1800000),
(134123, 'Eigo Wired', 'keyboard', 17, 55000, 80000),
(134124, 'FALAX Slider-01', 'mouse', 12, 192000, 292000),
(134125, 'FALAX Slider-02', 'mouse', 14, 198000, 250000),
(134126, 'FALAX Slider-03', 'mouse', 7, 235000, 335000),
(134127, 'FALAX Slider-04', 'mouse', 9, 200000, 252000),
(134128, 'GH Chromebook', 'notebook', 5, 6020000, 6850000),
(134129, 'GH Pavilion', 'notebook', 6, 7780000, 8149000),
(134130, 'Gantech Sonar', 'speaker', 18, 80000, 97000),
(134131, 'Gantech Alegro', 'speaker', 9, 200000, 215000),
(134132, 'Iltec Lansing', 'keyboard', 7, 250000, 320000),
(134133, 'Jell Inspiron', 'notebook', 2, 9876000, 10129000),
(134134, 'Kanon G1010', 'printer', 6, 1200000, 1450000),
(134135, 'Kanon G2010', 'printer', 6, 1435000, 1895000),
(134136, 'Keil DDR4', 'ram', 8, 989000, 1015000),
(134137, 'Keil DDR5', 'ram', 6, 2857000, 3000000),
(134138, 'Keil DDR4', 'ram ', 10, 750000, 850000),
(134139, 'Kenius Speaker ', 'speaker', 8, 98000, 110000),
(134140, 'Lipson L850 ', 'printer', 2, 5120000, 5865000),
(134141, 'Lipson L800 ', 'printer', 3, 3999000, 4130000),
(134142, 'ODATA XPG', 'keyboard', 6, 450000, 550000),
(134143, 'Osus ROG\" Portable USB ', 'lcd', 2, 8999000, 9399000),
(134144, 'Osus VT168HR\" Touchscreen ', 'lcd', 4, 2980000, 3099000),
(134145, 'Osus BR1100CKA ', 'notebook', 7, 3500000, 4590000),
(134146, 'Osus ExpertBook', 'notebook', 4, 7600000, 8099000),
(134147, 'Osus TUF', 'notebook', 3, 11700000, 11700000),
(134148, 'ODATA DDR5', 'ram ', 7, 1250000, 1500000),
(134149, 'ODATA DDR4', 'ram ', 12, 565000, 653000),
(134150, 'Pear Pro\" 6K Standaed Glass ', 'lcd', 1, 89020000, 89499000),
(134151, 'Sister HL-1201 ', 'printer', 8, 985000, 1230000),
(134152, 'Sister HL-L2360DN ', 'printer', 5, 1359000, 1740000),
(134153, 'K202HQL LED ', 'lcd', 17, 1320000, 1505000),
(134154, 'SA220Q Frameless ', 'lcd', 14, 1756000, 1975000),
(134155, 'Nitro VG240YA ', 'lcd', 8, 2010000, 2250000),
(134156, 'UCER Predator', 'mouse', 15, 223000, 349000),
(134157, 'UCER Aspire ', 'notebook', 8, 5820000, 5949000),
(134158, 'Yogitech G213', 'keyboard', 4, 487000, 589000),
(134159, 'Yogitech G413 ', 'keyboard', 4, 937000, 1009000),
(134160, 'Yogitech G613', 'keyboard', 2, 1110000, 1249000),
(134161, 'Yogitech G910 ', 'keyboard', 2, 2089000, 2539000),
(134162, 'Yogitech G304 ', 'mouse', 9, 465000, 519000),
(134163, 'Yogitech G402 ', 'mouse', 8, 300000, 375000),
(134164, 'Yogitech Z120', 'speaker', 6, 98000, 165000),
(134165, 'Yogitech Bluetooth ', 'speaker', 5, 220000, 320000);

-- --------------------------------------------------------

--
-- Table structure for table `histori`
--

CREATE TABLE `histori` (
  `id_transaksi` int(11) NOT NULL,
  `nama_pembeli` varchar(255) NOT NULL,
  `total_harga` int(11) NOT NULL,
  `bayar` int(11) NOT NULL,
  `kembalian` int(11) NOT NULL,
  `kasir` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `histori`
--

INSERT INTO `histori` (`id_transaksi`, `nama_pembeli`, `total_harga`, `bayar`, `kembalian`, `kasir`) VALUES
(1, 'aji', 1300000, 1500000, 200000, 'krisna'),
(2, 'Kikha', 8989000, 9000000, 11000, 'admin'),
(3, 'Villo', 13915000, 15000000, 1085000, 'farah'),
(4, 'Villo', 2535000, 2600000, 65000, 'farah'),
(5, 'Lili', 650000, 700000, 50000, 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id_user` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id_user`, `username`, `password`) VALUES
(1, 'krisna', '12345'),
(2, 'admin', 'admin'),
(3, 'aldi', '12345'),
(4, 'alma', '12345'),
(5, 'farah', '12345'),
(6, 'selfi', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `pembeli`
--

CREATE TABLE `pembeli` (
  `id_pembeli` int(11) NOT NULL,
  `nama_pembeli` varchar(255) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `telepon` int(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pembeli`
--

INSERT INTO `pembeli` (`id_pembeli`, `nama_pembeli`, `alamat`, `telepon`) VALUES
(90013001, 'Kikha', 'Bekasi Timur ', 2199901),
(90013002, 'Patrick', 'Jakarta Utara ', 2199902),
(90013003, 'Lili', 'Surabaya ', 2199903),
(90013004, 'Stea', 'Yogyakarta ', 2199904),
(90013005, 'George', 'Yogyakarta ', 2199905),
(90013006, 'Julia', 'Bekasi Selatan ', 2199906),
(90013007, 'Petrus', 'Bekasi Utara ', 2199907),
(90013008, 'Lidia', 'Jakarta Selatan ', 2199908),
(90013009, 'Husnia', 'Malang ', 2199909),
(90013010, 'Deska', 'Jambi ', 2199910),
(90013011, 'Tania', 'Aceh ', 2199911),
(90013012, 'Berliana', 'Bali ', 2199912),
(90013013, 'Warno', 'Bali ', 2199913),
(90013014, 'Rusli', 'Jakarta Timur ', 2199914),
(90013015, 'Barko', 'Jakarta Timur ', 2199915);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_barang` int(11) NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `qty` int(10) NOT NULL,
  `harga` int(100) NOT NULL,
  `harga_total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_barang`
--
ALTER TABLE `data_barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indexes for table `histori`
--
ALTER TABLE `histori`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id_user`);

--
-- Indexes for table `pembeli`
--
ALTER TABLE `pembeli`
  ADD PRIMARY KEY (`id_pembeli`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data_barang`
--
ALTER TABLE `data_barang`
  MODIFY `id_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=134166;

--
-- AUTO_INCREMENT for table `histori`
--
ALTER TABLE `histori`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `pembeli`
--
ALTER TABLE `pembeli`
  MODIFY `id_pembeli` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90013016;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
