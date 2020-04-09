-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Már 05. 19:22
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
-- Adatbázis: `ugyfelnyilvantarto`
--
CREATE DATABASE IF NOT EXISTS `ugyfelnyilvantarto` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `ugyfelnyilvantarto`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `fizetesek`
--

DROP TABLE IF EXISTS `fizetesek`;
CREATE TABLE `fizetesek` (
  `ki` int(11) NOT NULL,
  `kinek` int(11) NOT NULL,
  `osszeg` int(11) NOT NULL,
  `datum` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kollega`
--

DROP TABLE IF EXISTS `kollega`;
CREATE TABLE `kollega` (
  `K_ID` int(11) NOT NULL,
  `ugyfel_id` int(11) NOT NULL,
  `szemelyi_szam` int(13) DEFAULT NULL,
  `k_megjegyzes` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kollega_nyelv`
--

DROP TABLE IF EXISTS `kollega_nyelv`;
CREATE TABLE `kollega_nyelv` (
  `kollega_id` int(11) NOT NULL,
  `nyelv_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- A nézet helyettes szerkezete `kollega_view`
-- (Lásd alább az aktuális nézetet)
--
DROP VIEW IF EXISTS `kollega_view`;
CREATE TABLE `kollega_view` (
`ID` int(11)
,`nev` varchar(30)
,`telefonszam` varchar(25)
,`e-mail_cim` varchar(50)
,`mas_elerhetoseg` varchar(50)
,`adoszam` varchar(15)
,`cegjegyzekszam` varchar(15)
,`szekhely` varchar(100)
,`IBAN` varchar(50)
,`bank` varchar(30)
,`kategoria` varchar(10)
,`megjegyzes` varchar(200)
,`K_ID` int(11)
,`ugyfel_id` int(11)
,`szemelyi_szam` int(13)
,`k_megjegyzes` varchar(200)
);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `munka`
--

DROP TABLE IF EXISTS `munka`;
CREATE TABLE `munka` (
  `ID` int(11) NOT NULL,
  `felvetel_datuma` date NOT NULL,
  `hatarido` date NOT NULL,
  `vegleges_ar` int(10) DEFAULT NULL,
  `eddig_fizetett` int(10) DEFAULT NULL,
  `eddig_fizetett_datuma` date NOT NULL,
  `ugyfel_id` int(11) NOT NULL,
  `leiras` varchar(100) NOT NULL,
  `peldanyszam` int(3) NOT NULL DEFAULT '1',
  `kiindulasi-nyelv` varchar(30) NOT NULL,
  `celnyelv` varchar(30) NOT NULL,
  `kollega_id` int(11) NOT NULL,
  `kollega_dija` int(10) DEFAULT NULL,
  `hitelesites` int(10) DEFAULT NULL,
  `futar` int(10) DEFAULT NULL,
  `statusz` varchar(11) NOT NULL,
  `elkeszult_datum` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `nyelv`
--

DROP TABLE IF EXISTS `nyelv`;
CREATE TABLE `nyelv` (
  `id` int(11) NOT NULL,
  `megnev` varchar(17) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `nyelv`
--

INSERT INTO `nyelv` (`id`, `megnev`) VALUES
(1, 'angol'),
(2, 'francia'),
(3, 'magyar'),
(4, 'német'),
(5, 'olasz'),
(6, 'spanyol'),
(7, 'holland'),
(8, 'orosz'),
(9, 'ukrán'),
(10, 'svéd'),
(11, 'minden');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ugyfel`
--

DROP TABLE IF EXISTS `ugyfel`;
CREATE TABLE `ugyfel` (
  `ID` int(11) NOT NULL,
  `nev` varchar(30) NOT NULL,
  `telefonszam` varchar(25) DEFAULT NULL,
  `e-mail_cim` varchar(50) DEFAULT NULL,
  `mas_elerhetoseg` varchar(50) DEFAULT NULL,
  `adoszam` varchar(15) DEFAULT NULL,
  `cegjegyzekszam` varchar(15) DEFAULT NULL,
  `szekhely` varchar(100) DEFAULT NULL,
  `IBAN` varchar(50) DEFAULT NULL,
  `bank` varchar(30) DEFAULT NULL,
  `kategoria` varchar(10) DEFAULT NULL,
  `megjegyzes` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Nézet szerkezete `kollega_view`
--
DROP TABLE IF EXISTS `kollega_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `kollega_view`  AS  select `ugyfel`.`ID` AS `ID`,`ugyfel`.`nev` AS `nev`,`ugyfel`.`telefonszam` AS `telefonszam`,`ugyfel`.`e-mail_cim` AS `e-mail_cim`,`ugyfel`.`mas_elerhetoseg` AS `mas_elerhetoseg`,`ugyfel`.`adoszam` AS `adoszam`,`ugyfel`.`cegjegyzekszam` AS `cegjegyzekszam`,`ugyfel`.`szekhely` AS `szekhely`,`ugyfel`.`IBAN` AS `IBAN`,`ugyfel`.`bank` AS `bank`,`ugyfel`.`kategoria` AS `kategoria`,`ugyfel`.`megjegyzes` AS `megjegyzes`,`kollega`.`K_ID` AS `K_ID`,`kollega`.`ugyfel_id` AS `ugyfel_id`,`kollega`.`szemelyi_szam` AS `szemelyi_szam`,`kollega`.`k_megjegyzes` AS `k_megjegyzes` from (`ugyfel` join `kollega` on((`ugyfel`.`ID` = `kollega`.`ugyfel_id`))) ;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `fizetesek`
--
ALTER TABLE `fizetesek`
  ADD KEY `ki_fizet` (`ki`),
  ADD KEY `kinek_fizet` (`kinek`);

--
-- A tábla indexei `kollega`
--
ALTER TABLE `kollega`
  ADD PRIMARY KEY (`K_ID`),
  ADD KEY `ugfel_id` (`ugyfel_id`);

--
-- A tábla indexei `kollega_nyelv`
--
ALTER TABLE `kollega_nyelv`
  ADD KEY `nyelv_kollega` (`kollega_id`),
  ADD KEY `kollega_nyelv` (`nyelv_id`);

--
-- A tábla indexei `munka`
--
ALTER TABLE `munka`
  ADD KEY `munka_kollega` (`kollega_id`),
  ADD KEY `munka_ugyfel` (`ugyfel_id`);

--
-- A tábla indexei `nyelv`
--
ALTER TABLE `nyelv`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `ugyfel`
--
ALTER TABLE `ugyfel`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `nyelv`
--
ALTER TABLE `nyelv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT a táblához `ugyfel`
--
ALTER TABLE `ugyfel`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `fizetesek`
--
ALTER TABLE `fizetesek`
  ADD CONSTRAINT `ki_fizet` FOREIGN KEY (`ki`) REFERENCES `kollega` (`K_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `kinek_fizet` FOREIGN KEY (`kinek`) REFERENCES `kollega` (`K_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `kollega`
--
ALTER TABLE `kollega`
  ADD CONSTRAINT `kollega_ugyfel` FOREIGN KEY (`ugyfel_id`) REFERENCES `ugyfel` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `kollega_nyelv`
--
ALTER TABLE `kollega_nyelv`
  ADD CONSTRAINT `kollega_nyelv` FOREIGN KEY (`nyelv_id`) REFERENCES `nyelv` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `nyelv_kollega` FOREIGN KEY (`kollega_id`) REFERENCES `kollega` (`K_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `munka`
--
ALTER TABLE `munka`
  ADD CONSTRAINT `munka_kollega` FOREIGN KEY (`kollega_id`) REFERENCES `kollega` (`K_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `munka_ugyfel` FOREIGN KEY (`ugyfel_id`) REFERENCES `ugyfel` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
