/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 10.1.21-MariaDB : Database - db_toko_sepatu
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_toko_sepatu` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_toko_sepatu`;

/*Table structure for table `barang` */

DROP TABLE IF EXISTS `barang`;

CREATE TABLE `barang` (
  `kode_barang` varchar(10) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `kategori` varchar(25) NOT NULL,
  `kode_merk` varchar(15) NOT NULL,
  `harga_beli` int(10) unsigned DEFAULT NULL,
  `harga_jual` int(11) unsigned DEFAULT NULL,
  `kode_warna` varchar(10) NOT NULL,
  `kode_size` varchar(10) NOT NULL,
  `stok` int(11) DEFAULT NULL,
  `kode_satuan` varchar(25) NOT NULL,
  PRIMARY KEY (`kode_barang`,`nama_barang`),
  KEY `barang_ibfk_1` (`kode_satuan`),
  KEY `barang_ibfk_2` (`kategori`),
  KEY `size` (`kode_size`),
  KEY `merk_fk` (`kode_merk`),
  KEY `warna_fk` (`kode_warna`),
  CONSTRAINT `kategor_fk` FOREIGN KEY (`kategori`) REFERENCES `kategori` (`kode_kategori`) ON UPDATE CASCADE,
  CONSTRAINT `merk_fk` FOREIGN KEY (`kode_merk`) REFERENCES `merk` (`kode_merk`) ON UPDATE CASCADE,
  CONSTRAINT `warna_fk` FOREIGN KEY (`kode_warna`) REFERENCES `warna` (`kode_warna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `barang` */

insert  into `barang`(`kode_barang`,`nama_barang`,`kategori`,`kode_merk`,`harga_beli`,`harga_jual`,`kode_warna`,`kode_size`,`stok`,`kode_satuan`) values ('SPT-001','NIKE AIR MEN','KTG-001','MRK-002',90000,150000,'WRN-004','SZE-041',457,'STN-002'),('SPT-002','ADIDAS GAZELLE','KTG-001','MRK-001',90000,120000,'WRN-001','SZE-037',400,'STN-001'),('SPT-003','EQT SUPPORT RF SHOES','KTG-005','MRK-001',110000,250000,'WRN-004','SZE-042',286,'STN-001'),('SPT-004','Converse Chuck Taylor All','KTG-001','MRK-004',350000,550000,'WRN-004','SZE-042',476,'STN-002'),('SPT-005','Adidas Stefan Edberg','KTG-001','MRK-001',500000,750000,'WRN-001','SZE-043',121,'STN-002'),('SPT-006','Adidas Lucas Puig','KTG-001','MRK-001',350000,700000,'WRN-004','SZE-043',199,'STN-001'),('SPT-007','Nike Air Max Tavas [BLK]','KTG-001','MRK-002',500000,1500000,'WRN-004','SZE-042',245,'STN-002'),('SPT-008','Nike Air Force 1 [WHT]','KTG-001','MRK-002',350000,900000,'WRN-001','SZE-042',210,'STN-002'),('SPT-009','Nike Eastham Sneakers [BLK]','KTG-001','MRK-002',400000,1200000,'WRN-018','SZE-043',516,'STN-002'),('SPT-010','Nike GTS 16 TXT','KTG-001','MRK-002',500000,750000,'WRN-018','SZE-042',68,'STN-002'),('SPT-011','Nike Air Jordan 5 Retro [BLK/WHT]','KTG-001','MRK-002',750000,1500000,'WRN-002','SZE-042',50,'STN-001'),('SPT-012','Nike Kaishi 2.0 Mens Runn','KTG-001','MRK-002',750000,1500000,'WRN-002','SZE-037',225,'STN-002'),('SPT-013','Air Jordan Pro XII','KTG-001','MRK-002',500000,1500000,'WRN-007','SZE-038',200,'STN-002'),('SPT-014','Mens Jordan Extra Fly Bas','KTG-008','MRK-002',1250000,2100000,'WRN-004','SZE-043',50,'STN-002'),('SPT-015','AF1 Ultra Flyknit Low QS ','KTG-008','MRK-002',1250000,2500000,'WRN-003','SZE-043',50,'STN-002'),('SPT-016','Mens Jordan Eclipse Shoes','KTG-008','MRK-002',1252000,2252000,'WRN-003','SZE-043',49,'STN-002'),('SPT-017','Adidas Yezzy','KTG-001','MRK-001',750000,1500000,'WRN-003','SZE-043',252,'STN-002'),('SPT-018','Adidas Ultra Boost Triple','KTG-001','MRK-001',3000000,5000000,'WRN-004','SZE-043',91,'STN-002'),('SPT-019','Adidas NMD XR1 PK Triple ','KTG-001','MRK-001',1755000,3755000,'WRN-004','SZE-042',59,'STN-002'),('SPT-020','Adidas NMD R2 PK Blue Black','KTG-001','MRK-001',1250000,3250000,'WRN-020','SZE-037',69,'STN-002'),('SPT-021','Adidas Unisex Originals Stan Smith M20326 Shoes Ex','KTG-001','MRK-001',1650000,2500000,'WRN-001','SZE-043',48,'STN-002'),('SPT-022','NIKE MEN KYRIE 3 EP BASKETBALL','KTG-008','MRK-002',1085000,1785000,'WRN-004','SZE-044',50,'STN-002'),('SPT-023','NIKE MEN AIR MAX INFURIATE LOW EP','KTG-008','MRK-002',1500000,3500000,'WRN-019','SZE-042',45,'STN-002'),('SPT-024','NIKE MEN ZOOM WITNESS EP BASKETBALL','KTG-008','MRK-002',1082000,1582000,'WRN-004','SZE-042',50,'STN-002'),('SPT-025','NIKE MEN AIR MAX INFURIATE LOW EP BASKETBALL','KTG-008','MRK-002',1535000,3750000,'WRN-003','SZE-042',46,'STN-002'),('SPT-026','Puma Pacer Evo Running Shoes','KTG-008','MRK-003',1570000,2575000,'WRN-007','SZE-042',49,'STN-002'),('SPT-027','Puma Flare 2 Mono Mens Running Shoes','KTG-008','MRK-003',1550000,2150000,'WRN-008','SZE-042',50,'STN-002'),('SPT-028','Puma Meteor Mens Running Shoes','KTG-008','MRK-003',481900,699000,'WRN-019','SZE-043',48,'STN-002'),('SPT-029','Adidas Sepatu Running Galaxy 3 M','KTG-001','MRK-001',350000,750000,'WRN-004','SZE-041',391,'STN-002');

/*Table structure for table `detail_trans_beli` */

DROP TABLE IF EXISTS `detail_trans_beli`;

CREATE TABLE `detail_trans_beli` (
  `kode_trans_beli` varchar(15) NOT NULL,
  `kode_barang` varchar(15) NOT NULL,
  `nama_barang` varchar(25) DEFAULT NULL,
  `harga_beli` float unsigned DEFAULT '0',
  `jumlah` float unsigned DEFAULT '0',
  `sub_total` float unsigned DEFAULT '0',
  `warna` varchar(15) DEFAULT NULL,
  `size` varchar(15) DEFAULT NULL,
  KEY `detail_trans_beli_ibfk_2` (`kode_barang`),
  KEY `detail_trans_beli_ibfk_1` (`kode_trans_beli`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `detail_trans_beli` */

insert  into `detail_trans_beli`(`kode_trans_beli`,`kode_barang`,`nama_barang`,`harga_beli`,`jumlah`,`sub_total`,`warna`,`size`) values ('2017-07-14-002','SPT-010','Nike GTS 16 TXT',500000,50,25000000,'WRN-018','SZE-042'),('2017-07-14-003','SPT-013','Air Jordan Pro XII',500000,150,75000000,'WRN-007','SZE-038'),('2017-07-14-003','SPT-005','Adidas Stefan Edberg',500000,100,50000000,'WRN-001','SZE-043'),('2017-07-15-004','SPT-006','Adidas Lucas Puig',350000,150,52500000,'WRN-004','SZE-043'),('2017-07-15-004','SPT-017','Adidas Yezzy',750000,7,5250000,'WRN-003','SZE-043'),('2017-07-15-004','SPT-018','Adidas Ultra Boost Triple',3000000,88,264000000,'WRN-004','SZE-043'),('2017-07-15-004','SPT-019','Adidas NMD XR1 PK Triple ',1755000,9,15795000,'WRN-004','SZE-042'),('2017-07-16-005','SPT-007','Nike Air Max Tavas [BLK]',500000,200,100000000,'WRN-004','SZE-042'),('2017-07-16-005','SPT-028','Puma Meteor Mens Running ',481900,2,963800,'WRN-019','SZE-043');

/*Table structure for table `detail_trans_jual` */

DROP TABLE IF EXISTS `detail_trans_jual`;

CREATE TABLE `detail_trans_jual` (
  `kode_trans_jual` varchar(15) NOT NULL,
  `kode_barang` varchar(15) NOT NULL,
  `nama_barang` varchar(25) DEFAULT NULL,
  `harga_jual` float unsigned DEFAULT '0',
  `jumlah` float unsigned DEFAULT '0',
  `sub_total` float unsigned DEFAULT '0',
  `warna` varchar(15) DEFAULT NULL,
  `size` varchar(15) DEFAULT NULL,
  KEY `detail_trans_jual_ibfk_1` (`kode_barang`),
  KEY `detail_trans_jual_ibfk_2` (`kode_trans_jual`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `detail_trans_jual` */

insert  into `detail_trans_jual`(`kode_trans_jual`,`kode_barang`,`nama_barang`,`harga_jual`,`jumlah`,`sub_total`,`warna`,`size`) values ('2017-07-14-001','SPT-001','NIKE AIR MEN',150000,2,300000,'WRN-002','SZE-041'),('2017-07-14-001','SPT-003','EQT SUPPORT RF SHOES',250000,9,2250000,'WRN-004','SZE-042'),('2017-07-14-001','SPT-004','Converse Chuck Taylor All',550000,8,4400000,'WRN-004','SZE-042'),('2017-07-14-001','SPT-004','Converse Chuck Taylor All',550000,9,4950000,'WRN-002','SZE-042'),('2017-07-14-002','SPT-011','Nike Kaishi 2.0 Mens Runn',1500000,4,6000000,'WRN-002','SZE-042'),('2017-07-14-002','SPT-008','Nike Air Force 1 [WHT]',900000,5,4500000,'WRN-001','SZE-042'),('2017-07-14-002','SPT-008','Nike Air Force 1 [WHT]',900000,5,4500000,'WRN-001','SZE-042'),('2017-07-14-002','SPT-007','Nike Air Max Tavas [BLK]',1500000,5,7500000,'WRN-004','SZE-042'),('2017-07-14-002','SPT-009','Nike Eastham Sneakers [BL',1200000,4,4800000,'WRN-018','SZE-043'),('2017-07-14-003','SPT-004','Converse Chuck Taylor All',550000,3,1650000,'WRN-004','SZE-042'),('2017-07-15-004','SPT-027','Puma Meteor Mens Running ',699000,1,699000,'WRN-019','SZE-043'),('2017-07-15-005','SPT-017','Adidas Yezzy',1500000,2,3000000,'WRN-003','SZE-043'),('2017-07-15-005','SPT-018','Adidas Ultra Boost Triple',5000000,2,10000000,'WRN-004','SZE-043'),('2017-07-16-006','SPT-028','Puma Meteor Mens Running ',699000,3,2097000,'WRN-019','SZE-043'),('2017-07-16-006','SPT-025','NIKE MEN AIR MAX INFURIAT',3750000,2,7500000,'WRN-003','SZE-042'),('2017-07-16-006','SPT-029','Adidas Sepatu Running Gal',750000,4,3000000,'WRN-004','SZE-041'),('2017-07-16-006','SPT-021','Adidas Unisex Originals S',2500000,1,2500000,'WRN-001','SZE-043'),('2017-07-16-006','SPT-001','NIKE AIR MEN',150000,1,150000,'WRN-004','SZE-041'),('2017-07-16-007','SPT-025','NIKE MEN AIR MAX INFURIAT',3750000,2,7500000,'WRN-003','SZE-042'),('2017-07-16-007','SPT-029','Adidas Sepatu Running Gal',750000,5,3750000,'WRN-004','SZE-041'),('2017-07-16-008','SPT-005','Adidas Stefan Edberg',750000,2,1500000,'WRN-001','SZE-043'),('2017-07-16-008','SPT-004','Converse Chuck Taylor All',550000,2,1100000,'WRN-004','SZE-042'),('2017-07-16-009','SPT-010','Nike GTS 16 TXT',750000,2,1500000,'WRN-018','SZE-042'),('2017-07-17-010','SPT-005','Adidas Stefan Edberg',750000,2,1500000,'WRN-001','SZE-043'),('2017-07-17-010','SPT-006','Adidas Lucas Puig',700000,1,700000,'WRN-004','SZE-043'),('2017-07-17-011','SPT-017','Adidas Yezzy',1500000,2,3000000,'WRN-003','SZE-043'),('2017-07-17-011','SPT-018','Adidas Ultra Boost Triple',5000000,1,5000000,'WRN-004','SZE-043'),('2017-07-17-012','SPT-021','Adidas Unisex Originals S',2500000,1,2500000,'WRN-001','SZE-043'),('2017-07-17-012','SPT-017','Adidas Yezzy',1500000,1,1500000,'WRN-003','SZE-043'),('2017-07-17-012','SPT-016','Mens Jordan Eclipse Shoes',2252000,1,2252000,'WRN-003','SZE-043'),('2017-07-17-013','SPT-001','NIKE AIR MEN',150000,2,300000,'WRN-004','SZE-041'),('2017-07-17-013','SPT-026','Puma Pacer Evo Running Sh',2575000,1,2575000,'WRN-007','SZE-042');

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `jenis_kelamin` varchar(15) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_telepon` varchar(15) DEFAULT NULL,
  `tanggal_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`nik`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `karyawan` */

insert  into `karyawan`(`nik`,`nama`,`jenis_kelamin`,`tempat_lahir`,`tanggal_lahir`,`alamat`,`no_telepon`,`tanggal_update`) values ('NIK-001','Gede Adi Putra','Laki-Laki','Dili','1993-08-10','Gianyar','081337353585','2017-07-05 15:54:48'),('NIK-002','Eka Pramana','Laki-Laki','London','1993-08-10','Jalan Jalan Ke Gunung Agung naik becak Istimewa :)','081992992828','2017-07-06 15:04:32'),('NIK-005','Nita','Perempuan','Semarang','1995-06-11','Jln Pulau Bali\n\n\n\n\n\n\n\n','53333','2017-07-06 17:07:58'),('NIK-006','Rooney','Laki-Laki','London','1993-07-06','Jl. Pulau Papua','081992828281','2017-07-06 19:05:40'),('NIK-007','Putra Adi','Laki-Laki','Gianyar','2003-03-10','Lingkungan Bulkit Jangkrik, Samplangan, Gianyar\r\n','0817738878281','2017-07-14 12:31:22');

/*Table structure for table `kategori` */

DROP TABLE IF EXISTS `kategori`;

CREATE TABLE `kategori` (
  `kode_kategori` varchar(15) NOT NULL,
  `nama_kategori` varchar(25) NOT NULL,
  PRIMARY KEY (`kode_kategori`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `kategori` */

insert  into `kategori`(`kode_kategori`,`nama_kategori`) values ('KTG-001','Sneakers'),('KTG-002','Boots'),('KTG-003','Cone'),('KTG-004','Curved'),('KTG-005','Flat Shoes'),('KTG-006','High Heels'),('KTG-007','Sepatu Kasual.'),('KTG-008','Sepatu Olahraga'),('KTG-009','Slip In & Loafers'),('KTG-010','Aksesoris Sepatu'),('KTG-011','Spool'),('KTG-012','Stiletto'),('KTG-013','Sandal');

/*Table structure for table `merk` */

DROP TABLE IF EXISTS `merk`;

CREATE TABLE `merk` (
  `kode_merk` varchar(15) NOT NULL,
  `nama_merk` varchar(20) NOT NULL,
  PRIMARY KEY (`kode_merk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `merk` */

insert  into `merk`(`kode_merk`,`nama_merk`) values ('MRK-001','ADIDAS'),('MRK-002','NIKE'),('MRK-003','PUMA'),('MRK-004','CONVERSE'),('MRK-005','NEW BALANCE'),('MRK-006','MACBETH'),('MRK-007','AIRWALK'),('MRK-008','DIADORA'),('MRK-009','GLOBE'),('MRK-010','DR. MARTENS'),('MRK-011','FILA'),('MRK-012','DC'),('MRK-013','REEBOOK');

/*Table structure for table `satuan` */

DROP TABLE IF EXISTS `satuan`;

CREATE TABLE `satuan` (
  `kode_satuan` varchar(25) NOT NULL,
  `keterangan` varchar(15) NOT NULL,
  PRIMARY KEY (`kode_satuan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `satuan` */

insert  into `satuan`(`kode_satuan`,`keterangan`) values ('STN-001','PCS'),('STN-002','PASANG'),('STN-003','LUSIN');

/*Table structure for table `size` */

DROP TABLE IF EXISTS `size`;

CREATE TABLE `size` (
  `kode_size` varchar(10) NOT NULL,
  `nama_size` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`kode_size`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `size` */

insert  into `size`(`kode_size`,`nama_size`) values ('SZE-037','37'),('SZE-038','38'),('SZE-039','39'),('SZE-040','40'),('SZE-041','41'),('SZE-042','42'),('SZE-043','43'),('SZE-044','44'),('SZE-045','45'),('SZE-046','46');

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `kode_supplier` varchar(15) NOT NULL,
  `nama_supplier` varchar(25) DEFAULT NULL,
  `alamat` varchar(25) DEFAULT NULL,
  `telepon` varchar(15) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `website` varchar(15) DEFAULT NULL,
  `tanggal_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`kode_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `supplier` */

insert  into `supplier`(`kode_supplier`,`nama_supplier`,`alamat`,`telepon`,`email`,`website`,`tanggal_update`) values ('SPL-001','ShoesShop.ID','Panjer','88888888','im@shoeshop.id','shoeshop.id','2017-07-09 01:40:35'),('SPL-002','Shopee','Jakarta','99999999','market@Shopee.id','Shopee.id','2017-07-09 01:41:32'),('SPL-003','Lazada','Bangkok','77777777','sales@lazada.co.id','lazada.co.id','2017-07-12 10:28:59'),('SPL-004','Tokopedia','Jl. MH Tamrin, Jakarta','11112222','reseller@toped.id','tokopedia.com','2017-07-13 22:41:47'),('SPL-005','BukaLapak','Denpasar','232357679','shoes@bukalapak.id','bukalapak.com','2017-07-13 22:42:33');

/*Table structure for table `trans_beli` */

DROP TABLE IF EXISTS `trans_beli`;

CREATE TABLE `trans_beli` (
  `kode_trans_beli` varchar(15) NOT NULL,
  `kode_supplier` varchar(15) DEFAULT NULL,
  `username` varchar(20) NOT NULL,
  `total` float unsigned NOT NULL DEFAULT '0',
  `tanggal_trans_beli` varchar(10) DEFAULT NULL,
  `tanggal_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`kode_trans_beli`),
  KEY `trans_beli_ibfk_1` (`username`),
  KEY `trans_beli_ibfk_2` (`kode_supplier`),
  CONSTRAINT `trans_beli_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `trans_beli` */

insert  into `trans_beli`(`kode_trans_beli`,`kode_supplier`,`username`,`total`,`tanggal_trans_beli`,`tanggal_update`) values ('2017-07-14-002','SPL-004','gedeadi',25000000,'2017-07-14','2017-07-14 12:46:49'),('2017-07-14-003','SPL-003','gedeadi',125000000,'2017-07-14','2017-07-14 12:54:41'),('2017-07-15-004','SPL-001','gedeadi',337545000,'2017-07-15','2017-07-15 16:50:58'),('2017-07-16-005','SPL-003','gedeadi',100964000,'2017-07-16','2017-07-16 15:46:09');

/*Table structure for table `trans_jual` */

DROP TABLE IF EXISTS `trans_jual`;

CREATE TABLE `trans_jual` (
  `kode_trans_jual` varchar(15) NOT NULL,
  `pembeli` varchar(25) DEFAULT NULL,
  `username` varchar(20) DEFAULT NULL,
  `total_belanja` float unsigned NOT NULL,
  `diskon` float unsigned NOT NULL,
  `total_akhir` float DEFAULT NULL,
  `bayar` float DEFAULT NULL,
  `kembalian` float DEFAULT NULL,
  `tanggal_trans_jual` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`kode_trans_jual`),
  KEY `trans_jual_ibfk_1` (`username`),
  CONSTRAINT `trans_jual_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `trans_jual` */

insert  into `trans_jual`(`kode_trans_jual`,`pembeli`,`username`,`total_belanja`,`diskon`,`total_akhir`,`bayar`,`kembalian`,`tanggal_trans_jual`) values ('2017-07-14-001','Gede','gedeadi',6650000,4987500,1662500,1700000,37500,'2017-07-14'),('2017-07-14-002','Gede Surya','gedeadi',27300000,27027000,273000,300000,27000,'2017-07-14'),('2017-07-14-003','Gede Adi','gedeadi',1650000,1633500,16500,17000,500,'2017-07-14'),('2017-07-15-004','Gede Adi Eka','gedeadi',699000,216690,482310,500000,17690,'2017-07-15'),('2017-07-15-005','gEDE','gedeadi',13000000,12870000,130000,135000,5000,'2017-07-15'),('2017-07-16-006','Gede Putra Adi','gedeadi',15247000,12197600,3049400,3100000,50600,'2017-07-16'),('2017-07-16-007','Dinda Kanya Bieber','gedeadi',11250000,8662500,2587500,2600000,12500,'2017-07-16'),('2017-07-16-008','Nita','gedeadi',2600000,1300000,1300000,1500000,200000,'2017-07-16'),('2017-07-16-009','Nita','gedeadi',1500000,750000,750000,800000,50000,'2017-07-16'),('2017-07-17-010','Google','gedeadi',2200000,0,2200000,2250000,50000,'2017-07-17'),('2017-07-17-011','Putra','gedeadi',8000000,4000000,4000000,4000000,0,'2017-07-17'),('2017-07-17-012','Nova','gedeadi',6252000,1250400,5001600,5002000,400,'2017-07-17'),('2017-07-17-013','Boy','admin',2875000,143750,2731250,2800000,68750,'2017-07-17');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `nik` varchar(11) NOT NULL,
  `level_user` varchar(10) DEFAULT 'user',
  `tanggal_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`username`),
  UNIQUE KEY `kunci_unik_user` (`username`,`nik`),
  KEY `user_ibfk_1` (`nik`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`nik`) REFERENCES `karyawan` (`nik`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user` */

insert  into `user`(`username`,`password`,`nik`,`level_user`,`tanggal_update`) values ('admin','admin','NIK-002','user','2017-07-12 11:24:41'),('gedeadi','gedeadi','NIK-001','user','2017-07-05 15:58:13');

/*Table structure for table `warna` */

DROP TABLE IF EXISTS `warna`;

CREATE TABLE `warna` (
  `kode_warna` varchar(10) NOT NULL,
  `nama_warna` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kode_warna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `warna` */

insert  into `warna`(`kode_warna`,`nama_warna`) values ('WRN-001','White'),('WRN-002','Grey'),('WRN-003','Light Grey'),('WRN-004','Black'),('WRN-005','Cream'),('WRN-006','Dark Brown'),('WRN-007','Blue'),('WRN-008','Dark Green'),('WRN-009','Light Green'),('WRN-010','Yellow'),('WRN-011','Pink'),('WRN-012','Dark Grey'),('WRN-013','Grey/White'),('WRN-014','Navy-White'),('WRN-015','Grey-Sail'),('WRN-016','Green-White'),('WRN-017','Dark Grey-White-Wolf Grey-Anth'),('WRN-018','Black/White'),('WRN-019','Midnight Navy / White'),('WRN-020','Blue/Black');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
