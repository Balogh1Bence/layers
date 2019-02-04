-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2.1
-- http://www.phpmyadmin.net
--
-- Gép: localhost
-- Létrehozás ideje: 2019. Jan 27. 09:18
-- Kiszolgáló verziója: 5.7.24-0ubuntu0.16.04.1
-- PHP verzió: 7.0.32-4+ubuntu16.04.1+deb.sury.org+1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `pizza`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pvevo`
--

CREATE TABLE `pvevo` (
  `vazon` int(6) NOT NULL DEFAULT '0',
  `vnev` varchar(30) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `vcim` varchar(30) COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

--
-- A tábla adatainak kiíratása `pvevo`
--

INSERT INTO `pvevo` (`vazon`, `vnev`, `vcim`) VALUES
(1, 'Hapci', ''),
(2, 'Vidor', ''),
(3, 'Tudor', ''),
(4, 'Kuka', ''),
(5, 'Szende', ''),
(6, 'Szundi', ''),
(7, 'Morgó', '');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `pvevo`
--
ALTER TABLE `pvevo`
  ADD PRIMARY KEY (`vazon`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
