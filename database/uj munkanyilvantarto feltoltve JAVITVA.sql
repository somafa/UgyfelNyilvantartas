-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Ápr 14. 11:34
-- Kiszolgáló verziója: 10.1.38-MariaDB
-- PHP verzió: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `munkanyilvantarto`
--

-- --------------------------------------------------------

--
-- A nézet helyettes szerkezete `dg_fooldal`
-- (Lásd alább az aktuális nézetet)
--
CREATE TABLE `dg_fooldal` (
`felvetel_datuma` date
,`u_nev` varchar(30)
,`leiras` varchar(100)
,`kiindulasi_nyelv` varchar(20)
,`celnyelv` varchar(20)
,`k_nev` varchar(30)
,`vegleges_ar` int(10)
,`hatarido` date
,`eddig_fizetett` int(10)
,`elkeszult_datum` date
,`statusz` enum('folyamatban','elkészült','letudva','')
);

-- --------------------------------------------------------

--
-- A nézet helyettes szerkezete `dg_ugyfel_ellenorzes`
-- (Lásd alább az aktuális nézetet)
--
CREATE TABLE `dg_ugyfel_ellenorzes` (
`felvetel_datuma` date
,`u_nev` varchar(30)
,`leiras` varchar(100)
,`forras_nyelv` varchar(20)
,`celnyelv` varchar(20)
,`vegleges_ar` int(10)
,`hatarido` date
,`eddig_fizetett` int(10)
,`eddig_fizetett_datuma` date
,`elkeszult_datum` date
,`statusz` enum('folyamatban','elkészült','letudva','')
);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kifizetesek`
--

CREATE TABLE `kifizetesek` (
  `ki` int(3) DEFAULT NULL,
  `kinek` int(3) DEFAULT NULL,
  `osszeg` int(11) DEFAULT NULL,
  `datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `kifizetesek`
--

INSERT INTO `kifizetesek` (`ki`, `kinek`, `osszeg`, `datum`) VALUES
(2, 1, 6000, '2019-08-02'),
(1, 7, 4500, '2019-08-10'),
(6, 1, 12000, '2020-01-10'),
(1, 9, 5000, '2020-01-15'),
(1, 6, 6000, '2020-02-20'),
(1, 8, 6000, '2020-03-03'),
(1, 10, 8000, '2020-03-03');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kollega`
--

CREATE TABLE `kollega` (
  `k_ID` int(3) NOT NULL,
  `k_nev` varchar(30) DEFAULT NULL,
  `k_telefonszam` varchar(30) DEFAULT NULL,
  `k_email` varchar(50) DEFAULT NULL,
  `k_mas` varchar(50) DEFAULT NULL,
  `k_adoszam` varchar(30) DEFAULT NULL,
  `k_cegjegyzekszam` varchar(30) DEFAULT NULL,
  `k_cim` varchar(100) DEFAULT NULL,
  `k_IBAN` varchar(50) DEFAULT NULL,
  `k_bank` varchar(30) DEFAULT NULL,
  `k_szemelyi_szam` varchar(20) DEFAULT NULL,
  `k_megjegyzes` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `kollega`
--

INSERT INTO `kollega` (`k_ID`, `k_nev`, `k_telefonszam`, `k_email`, `k_mas`, `k_adoszam`, `k_cegjegyzekszam`, `k_cim`, `k_IBAN`, `k_bank`, `k_szemelyi_szam`, `k_megjegyzes`) VALUES
(1, 'INSOLATIO', '740217144', 'insolatio@yahoo.com', NULL, '28377567', 'J30/354/2011', 'Csanálos 70', NULL, 'CEC Bank', NULL, 'mi vagyunk'),
(2, 'LegalTradTeam', '758976358', 'legaltrad@gmail.com', NULL, '12345678', NULL, 'Bukarest', NULL, 'ING Bank', NULL, 'Alexandra'),
(3, 'Angol Alpár', '788654832', 'alpi@angol.uk', NULL, NULL, NULL, 'Kolozsvár', NULL, NULL, NULL, NULL),
(4, 'Német Zoltán', '785698343', 'zoli@jo.de', NULL, NULL, NULL, 'Temesvár', NULL, NULL, NULL, NULL),
(5, 'Magyar Gyöngyi', '746357951', 'gyongyi@ke.hu', NULL, NULL, NULL, 'Zilah', NULL, NULL, NULL, NULL),
(6, 'Francia Johanna', '741258634', 'joan@tud.fr', NULL, NULL, NULL, 'Kolozsvár', NULL, NULL, NULL, NULL),
(7, 'Olasz Donna', '723684531', 'prego@ital.it', NULL, NULL, NULL, 'Borsa', NULL, NULL, NULL, NULL),
(8, 'Ruszki Józsi', '765846138', 'rusz@jozsi.ru', NULL, NULL, NULL, 'Sziget', NULL, NULL, NULL, NULL),
(9, 'Holland Karmella', '770640872', 'also@orszag.nl', NULL, NULL, NULL, 'Fenes', NULL, NULL, NULL, NULL),
(10, 'Móra András', '256784605', 'sved@bandi.sv', NULL, NULL, NULL, 'Brasso', NULL, NULL, NULL, 'norvégul is tud');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kollega_nyelv`
--

CREATE TABLE `kollega_nyelv` (
  `koll_ID` int(3) DEFAULT NULL,
  `ny_ID` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `kollega_nyelv`
--

INSERT INTO `kollega_nyelv` (`koll_ID`, `ny_ID`) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 5),
(4, 6),
(5, 5),
(6, 3),
(6, 10),
(7, 2),
(7, 7),
(8, 8),
(8, 12),
(9, 4),
(9, 6),
(10, 11);

-- --------------------------------------------------------

--
-- A nézet helyettes szerkezete `megrendeles`
-- (Lásd alább az aktuális nézetet)
--
CREATE TABLE `megrendeles` (
`munkaID` int(10)
,`felvetel_datuma` date
,`hatarido` date
,`vegleges_ar` int(10)
,`eddig_fizetett` int(10)
,`eddig_fizetett_datuma` date
,`peldanyszam` int(3)
,`leiras` varchar(100)
,`statusz` enum('folyamatban','elkészült','letudva','')
,`kiindulasi_nyelv` varchar(20)
,`celnyelv` varchar(20)
,`u_nev` varchar(30)
,`u_telefonszam` varchar(30)
,`u_email` varchar(50)
,`u_mas` varchar(50)
,`u_megjegyzes` varchar(100)
,`u_kategoria` enum('ügyfél','kolléga','VIP','')
,`k_nev` varchar(30)
,`kollega_dija` int(10)
,`hitelesites` int(10)
,`futar` int(10)
,`elkeszult_datum` date
);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `munka`
--

CREATE TABLE `munka` (
  `munkaID` int(10) NOT NULL,
  `felvetel_datuma` date DEFAULT NULL,
  `hatarido` date DEFAULT NULL,
  `vegleges_ar` int(10) DEFAULT NULL,
  `eddig_fizetett` int(10) DEFAULT NULL,
  `eddig_fizetett_datuma` date DEFAULT NULL,
  `ugyfel_ID` int(7) DEFAULT NULL,
  `leiras` varchar(100) DEFAULT NULL,
  `peldanyszam` int(3) DEFAULT NULL,
  `kiindulasi_nyelv_ID` int(3) DEFAULT NULL,
  `celnyelv_ID` int(3) DEFAULT NULL,
  `kollega_ID` int(3) DEFAULT NULL,
  `kollega_dija` int(10) DEFAULT NULL,
  `hitelesites` int(10) DEFAULT NULL,
  `futar` int(10) DEFAULT NULL,
  `statusz` enum('folyamatban','elkészült','letudva','') DEFAULT NULL,
  `elkeszult_datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `munka`
--

INSERT INTO `munka` (`munkaID`, `felvetel_datuma`, `hatarido`, `vegleges_ar`, `eddig_fizetett`, `eddig_fizetett_datuma`, `ugyfel_ID`, `leiras`, `peldanyszam`, `kiindulasi_nyelv_ID`, `celnyelv_ID`, `kollega_ID`, `kollega_dija`, `hitelesites`, `futar`, `statusz`, `elkeszult_datum`) VALUES
(1, '2019-02-12', '2019-02-15', 5000, 5000, '2019-02-15', 11, 'Anyakönyvi irat', 1, 2, 9, 7, 1500, 2000, NULL, 'letudva', '2019-02-14'),
(2, '2019-05-20', '2019-05-25', 5000, 5000, '2019-05-26', 10, 'Vezetői engedély', 1, 3, 9, 6, 1500, 2000, NULL, 'letudva', '2019-05-24'),
(3, '2019-06-30', '2019-07-31', 6000, 6000, '2019-08-02', 16, 'Levél', 2, 5, 9, 1, NULL, NULL, NULL, 'letudva', '2019-07-31'),
(4, '2019-08-04', '2019-08-04', 6000, NULL, NULL, 2, 'Anyakönyvi irat', 3, 9, 5, 1, NULL, NULL, NULL, 'elkészült', '2019-08-04'),
(5, '2019-11-07', '2019-11-10', 8500, 8500, '2019-11-10', 4, 'CV', 1, 9, 5, 1, NULL, 6000, NULL, 'letudva', '2019-11-10'),
(6, '2019-12-20', '2020-01-15', 10000, 10000, '2020-01-14', 5, 'Leirás', 1, 4, 9, 9, 5000, NULL, NULL, 'letudva', '2020-01-14'),
(7, '2020-01-05', '2020-01-05', 12000, 12000, '2020-01-05', 20, 'orvosi', 1, 5, 9, 1, NULL, NULL, NULL, 'letudva', '2020-01-05'),
(8, '2020-01-11', '2020-01-12', 8000, 8000, '2020-01-12', 6, 'EU papír', 1, 9, 6, 1, NULL, 4000, NULL, 'letudva', '2020-01-12'),
(9, '2020-02-16', '2020-02-17', 20000, 20000, '2020-02-17', 4, 'Anyakönyvi irat', 1, 9, 5, 1, NULL, 10000, NULL, 'letudva', '2020-02-17'),
(10, '2020-02-17', '2020-02-18', 15000, 15000, '2020-02-19', 7, 'igazolás', 1, 9, 3, 6, 4500, 6000, NULL, 'letudva', '2020-02-18'),
(11, '2020-02-18', NULL, NULL, NULL, NULL, 12, 'technikai', 1, 6, 9, 1, NULL, NULL, NULL, 'folyamatban', NULL),
(12, '2020-02-18', NULL, NULL, NULL, NULL, 12, 'szerződés', 1, 5, 9, 5, NULL, NULL, NULL, 'folyamatban', NULL),
(13, '2020-02-19', NULL, NULL, NULL, NULL, 12, 'banki', 1, 6, 9, 4, NULL, NULL, NULL, 'folyamatban', NULL),
(14, '2020-02-23', '2020-02-25', 15000, 5000, '2020-02-23', 13, 'Anyakönyvi irat', 1, 9, 10, 6, 4500, 6000, NULL, 'elkészült', '2020-02-25'),
(15, '2020-02-25', '2020-03-10', 10000, 10000, '2020-03-09', 3, 'iskolai papír', 1, 8, 9, 8, 6000, NULL, NULL, 'letudva', '2020-03-09'),
(16, '2020-03-01', '2020-03-02', 15000, 15000, '2020-03-02', 14, 'autó', 1, 11, 9, 10, 8000, NULL, NULL, 'letudva', '2020-03-02'),
(17, '2020-03-01', '2020-03-03', 22000, 5000, '2020-03-01', 15, 'pályázati iratok', 1, 6, 9, 4, 10000, 4000, NULL, 'elkészült', '2020-03-03'),
(18, '2020-03-02', '2020-03-30', NULL, NULL, NULL, 12, 'szerződés', 1, 6, 9, 1, NULL, NULL, NULL, 'folyamatban', NULL),
(19, '2020-03-03', '2020-03-10', 6000, NULL, NULL, 8, 'iskolai papír', 1, 9, 3, 6, 3000, NULL, NULL, 'elkészült', '2020-03-10'),
(20, '2020-03-04', '2020-03-05', 10000, NULL, NULL, 9, 'igazolás', 1, 7, 9, 7, 3000, 4000, NULL, 'elkészült', '2020-03-05'),
(21, '2020-03-04', NULL, NULL, NULL, NULL, 12, 'egyenleg', 1, 9, 6, 1, NULL, NULL, NULL, 'folyamatban', NULL);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `nyelvek`
--

CREATE TABLE `nyelvek` (
  `nyelv_ID` int(3) NOT NULL,
  `megnevezes` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `nyelvek`
--

INSERT INTO `nyelvek` (`nyelv_ID`, `megnevezes`) VALUES
(1, 'minden'),
(2, 'angol'),
(3, 'francia'),
(4, 'holland'),
(5, 'magyar'),
(6, 'német'),
(7, 'olasz'),
(8, 'orosz'),
(9, 'román'),
(10, 'spanyol'),
(11, 'svéd'),
(12, 'ukrán');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ugyfel`
--

CREATE TABLE `ugyfel` (
  `u_ID` int(7) NOT NULL,
  `u_nev` varchar(30) DEFAULT NULL,
  `u_telefonszam` varchar(30) DEFAULT NULL,
  `u_email` varchar(50) DEFAULT NULL,
  `u_mas` varchar(50) DEFAULT NULL,
  `u_adoszam` varchar(30) DEFAULT NULL,
  `u_cegjegyzekszam` varchar(30) DEFAULT NULL,
  `u_szekhely` varchar(100) DEFAULT NULL,
  `u_IBAN` varchar(50) DEFAULT NULL,
  `u_bank` varchar(30) DEFAULT NULL,
  `u_kategoria` enum('ügyfél','kolléga','VIP','') DEFAULT NULL,
  `u_megjegyzes` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `ugyfel`
--

INSERT INTO `ugyfel` (`u_ID`, `u_nev`, `u_telefonszam`, `u_email`, `u_mas`, `u_adoszam`, `u_cegjegyzekszam`, `u_szekhely`, `u_IBAN`, `u_bank`, `u_kategoria`, `u_megjegyzes`) VALUES
(1, 'INSOLATIO', '740217144', 'insolatio@yahoo.com', NULL, '28377567', 'J30/354/211', 'Csanálos 70', NULL, 'CEC Bank', 'kolléga', 'mi vagyunk'),
(2, 'Patta Nóra', '205637891', 'pattanora@jo.hu', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(3, 'Pár Zoltán', '304795678', 'parzoltan@vajon.ru', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(4, 'Pop Simon', '405678965', 'popsimon@ott.hu', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(5, 'Remek Elek', '507896543', 'remekelek@mit.ro', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(6, 'Beviz Elek', '601234567', 'bevizelek@jaj.de', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(7, 'Szalmon Ella', '704578123', 'szalmonella@vigya.fr', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(8, 'Techno Kolos', '807845932', 'technokol@rapid.no', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(9, 'Trab Antal', '108769123', 'trabantal@auto.uk', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(10, 'Ultra Viola', '206587493', 'ultraviola@nap.ch', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(11, 'Am Erika', '309564387', 'amerika@kapitany.com', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(12, 'TAPIXEL', '261876503', 'tapixel@kft.ro', NULL, '3687459', 'J30/11/2000', 'Nagykároly', NULL, 'Raiffeisen', 'VIP', NULL),
(13, 'Bac Ilus', '897546821', 'bac@ilus.sp', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(14, 'Citad Ella', '546954333', 'citadella@sved.su', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(15, 'Dil Emma', '364552674', 'dilemma@vajon.at', NULL, NULL, NULL, NULL, NULL, NULL, 'ügyfél', NULL),
(16, 'LegalTradTeam', '758976358', 'legaltrad@gmail.com', NULL, '12345678', NULL, 'Bukarest', NULL, 'ING Bank', 'kolléga', 'Alexandra'),
(17, 'Angol Alpár', '788654832', 'alpi@angol.uk', NULL, NULL, NULL, 'Kolozsvár', NULL, NULL, NULL, NULL),
(18, 'Német Zoltán', '785698343', 'zoli@jo.de', NULL, NULL, NULL, 'Temesvár', NULL, NULL, NULL, NULL),
(19, 'Magyar Gyöngyi', '746357951', 'gyongyi@ke.hu', NULL, NULL, NULL, 'Zilah', NULL, NULL, NULL, NULL),
(20, 'Francia Johanna', '741258634', 'joan@tud.fr', NULL, NULL, NULL, 'Kolozsvár', NULL, NULL, NULL, NULL),
(21, 'Olasz Donna', '723684531', 'prego@ital.it', NULL, NULL, NULL, 'Borsa', NULL, NULL, NULL, NULL),
(22, 'Ruszki Józsi', '765846138', 'rusz@jozsi.ru', NULL, NULL, NULL, 'Sziget', NULL, NULL, NULL, NULL),
(23, 'Holland Karmella', '770640872', 'also@orszag.nl', NULL, NULL, NULL, 'Fenes', NULL, NULL, NULL, NULL),
(24, 'Móra András', '256784605', 'sved@bandi.sv', NULL, NULL, NULL, 'Brasso', NULL, NULL, NULL, 'norvégul is tud');

-- --------------------------------------------------------

--
-- Nézet szerkezete `dg_fooldal`
--
DROP TABLE IF EXISTS `dg_fooldal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `dg_fooldal`  AS  select `munka`.`felvetel_datuma` AS `felvetel_datuma`,`ugyfel`.`u_nev` AS `u_nev`,`munka`.`leiras` AS `leiras`,`nyelvek`.`megnevezes` AS `kiindulasi_nyelv`,`cel`.`megnevezes` AS `celnyelv`,`kollega`.`k_nev` AS `k_nev`,`munka`.`vegleges_ar` AS `vegleges_ar`,`munka`.`hatarido` AS `hatarido`,`munka`.`eddig_fizetett` AS `eddig_fizetett`,`munka`.`elkeszult_datum` AS `elkeszult_datum`,`munka`.`statusz` AS `statusz` from ((((`munka` join `ugyfel` on((`munka`.`ugyfel_ID` = `ugyfel`.`u_ID`))) join `kollega` on((`munka`.`kollega_ID` = `kollega`.`k_ID`))) join `nyelvek` on((`munka`.`kiindulasi_nyelv_ID` = `nyelvek`.`nyelv_ID`))) join `nyelvek` `cel` on((`munka`.`celnyelv_ID` = `cel`.`nyelv_ID`))) ;

-- --------------------------------------------------------

--
-- Nézet szerkezete `dg_ugyfel_ellenorzes`
--
DROP TABLE IF EXISTS `dg_ugyfel_ellenorzes`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `dg_ugyfel_ellenorzes`  AS  select `munka`.`felvetel_datuma` AS `felvetel_datuma`,`ugyfel`.`u_nev` AS `u_nev`,`munka`.`leiras` AS `leiras`,`nyelvek`.`megnevezes` AS `forras_nyelv`,`cel`.`megnevezes` AS `celnyelv`,`munka`.`vegleges_ar` AS `vegleges_ar`,`munka`.`hatarido` AS `hatarido`,`munka`.`eddig_fizetett` AS `eddig_fizetett`,`munka`.`eddig_fizetett_datuma` AS `eddig_fizetett_datuma`,`munka`.`elkeszult_datum` AS `elkeszult_datum`,`munka`.`statusz` AS `statusz` from (((`munka` join `ugyfel` on((`munka`.`ugyfel_ID` = `ugyfel`.`u_ID`))) join `nyelvek` on((`munka`.`kiindulasi_nyelv_ID` = `nyelvek`.`nyelv_ID`))) join `nyelvek` `cel` on((`munka`.`celnyelv_ID` = `cel`.`nyelv_ID`))) ;

-- --------------------------------------------------------

--
-- Nézet szerkezete `megrendeles`
--
DROP TABLE IF EXISTS `megrendeles`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `megrendeles`  AS  select `munka`.`munkaID` AS `munkaID`,`munka`.`felvetel_datuma` AS `felvetel_datuma`,`munka`.`hatarido` AS `hatarido`,`munka`.`vegleges_ar` AS `vegleges_ar`,`munka`.`eddig_fizetett` AS `eddig_fizetett`,`munka`.`eddig_fizetett_datuma` AS `eddig_fizetett_datuma`,`munka`.`peldanyszam` AS `peldanyszam`,`munka`.`leiras` AS `leiras`,`munka`.`statusz` AS `statusz`,`nyelvek`.`megnevezes` AS `kiindulasi_nyelv`,`cel`.`megnevezes` AS `celnyelv`,`ugyfel`.`u_nev` AS `u_nev`,`ugyfel`.`u_telefonszam` AS `u_telefonszam`,`ugyfel`.`u_email` AS `u_email`,`ugyfel`.`u_mas` AS `u_mas`,`ugyfel`.`u_megjegyzes` AS `u_megjegyzes`,`ugyfel`.`u_kategoria` AS `u_kategoria`,`kollega`.`k_nev` AS `k_nev`,`munka`.`kollega_dija` AS `kollega_dija`,`munka`.`hitelesites` AS `hitelesites`,`munka`.`futar` AS `futar`,`munka`.`elkeszult_datum` AS `elkeszult_datum` from ((((`munka` join `ugyfel` on((`munka`.`ugyfel_ID` = `ugyfel`.`u_ID`))) join `kollega` on((`munka`.`kollega_ID` = `kollega`.`k_ID`))) join `nyelvek` on((`munka`.`kiindulasi_nyelv_ID` = `nyelvek`.`nyelv_ID`))) join `nyelvek` `cel` on((`munka`.`celnyelv_ID` = `cel`.`nyelv_ID`))) ;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `kifizetesek`
--
ALTER TABLE `kifizetesek`
  ADD KEY `ki` (`ki`),
  ADD KEY `kinek` (`kinek`);

--
-- A tábla indexei `kollega`
--
ALTER TABLE `kollega`
  ADD PRIMARY KEY (`k_ID`);

--
-- A tábla indexei `kollega_nyelv`
--
ALTER TABLE `kollega_nyelv`
  ADD KEY `koll_ID` (`koll_ID`),
  ADD KEY `ny_ID` (`ny_ID`);

--
-- A tábla indexei `munka`
--
ALTER TABLE `munka`
  ADD PRIMARY KEY (`munkaID`),
  ADD KEY `ugyfel_ID` (`ugyfel_ID`),
  ADD KEY `kiindulasi_nyelv_ID` (`kiindulasi_nyelv_ID`),
  ADD KEY `celnyelv_ID` (`celnyelv_ID`),
  ADD KEY `kollega_ID` (`kollega_ID`);

--
-- A tábla indexei `nyelvek`
--
ALTER TABLE `nyelvek`
  ADD PRIMARY KEY (`nyelv_ID`);

--
-- A tábla indexei `ugyfel`
--
ALTER TABLE `ugyfel`
  ADD PRIMARY KEY (`u_ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `munka`
--
ALTER TABLE `munka`
  MODIFY `munkaID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `kifizetesek`
--
ALTER TABLE `kifizetesek`
  ADD CONSTRAINT `fk_befizetes` FOREIGN KEY (`kinek`) REFERENCES `kollega` (`k_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_kifizetes` FOREIGN KEY (`ki`) REFERENCES `kollega` (`k_ID`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Megkötések a táblához `kollega_nyelv`
--
ALTER TABLE `kollega_nyelv`
  ADD CONSTRAINT `fk_nyelv_kollega` FOREIGN KEY (`koll_ID`) REFERENCES `kollega` (`k_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_nyelv_nyelv` FOREIGN KEY (`ny_ID`) REFERENCES `nyelvek` (`nyelv_ID`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Megkötések a táblához `munka`
--
ALTER TABLE `munka`
  ADD CONSTRAINT `fk_munka_celnyelv` FOREIGN KEY (`celnyelv_ID`) REFERENCES `nyelvek` (`nyelv_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_munka_ki_nyelv` FOREIGN KEY (`kiindulasi_nyelv_ID`) REFERENCES `nyelvek` (`nyelv_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_munka_kollega` FOREIGN KEY (`kollega_ID`) REFERENCES `kollega` (`k_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_munka_ugyfel` FOREIGN KEY (`ugyfel_ID`) REFERENCES `ugyfel` (`u_ID`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
