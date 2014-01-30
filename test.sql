-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 28. Januar 2014 um 15:00
-- Server Version: 5.5.8
-- PHP-Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `test`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `person`
--

CREATE TABLE IF NOT EXISTS `person` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `passwort` varchar(255) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Daten für Tabelle `person`
--

INSERT INTO `person` (`uid`, `name`, `passwort`) VALUES
(1, 'admin', 'password'),
(2, 'test', 'test');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `termin`
--

CREATE TABLE IF NOT EXISTS `termin` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `ort` varchar(255) NOT NULL,
  `start` date NOT NULL,
  `ende` date NOT NULL,
  `typ` int(11) NOT NULL,
  `person` int(11) NOT NULL,
  `beschreibung` text NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=39 ;

--
-- Daten für Tabelle `termin`
--

INSERT INTO `termin` (`uid`, `title`, `ort`, `start`, `ende`, `typ`, `person`, `beschreibung`) VALUES
(19, 'Termin 1', 'Ort', '2014-01-27', '2014-01-17', 1, 1, ''),
(20, 'TEST', 'TEEEEST', '2014-01-27', '2014-01-31', 1, 1, ''),
(21, 'TASD', 'ADASDASDASD', '2014-01-27', '2014-01-31', 3, 2, ''),
(22, 'test', 'tdsrsad', '2014-01-27', '2014-01-27', 1, 2, ''),
(23, 'URLAUB', 'WEG!', '2014-01-25', '2014-01-30', 3, 1, ''),
(24, 'TEST', 'rasd', '2014-01-02', '2014-01-14', 3, 1, ''),
(25, 'DASDASD', 'AsdSDASD', '2014-02-13', '2014-03-14', 4, 1, ''),
(26, 'TTTTESDASDASDASD', 'ASDASDASD', '2014-01-31', '2014-04-18', 1, 1, ''),
(27, '13123123', '3123123123123', '2014-01-28', '2014-04-04', 4, 1, ''),
(28, 'dasdasdasd', 'asdasdasdasd', '2014-01-30', '2014-02-15', 3, 1, ''),
(29, '23r234243423', '32423243243243', '2014-01-28', '2014-01-28', 2, 1, ''),
(30, 'a123123', '23123123123123', '2014-04-11', '2014-08-09', 2, 1, ''),
(31, 'this is shit', 'hier', '2014-01-28', '2014-01-28', 2, 1, ''),
(32, 'bkjkhkj', 'kjlklj', '2014-01-28', '2014-01-28', 2, 1, ''),
(33, 'gdf', 'gdh', '2014-01-28', '2014-01-28', 2, 1, ''),
(34, 'AAAAAAAAAAA', 'AAAAAAAAAAAAAA', '2014-01-28', '2014-01-28', 4, 1, ''),
(35, 'hello', 'this is shit', '2014-01-01', '2014-01-18', 3, 1, ''),
(36, 'asdasdasdasd', 'asdasdasdasd', '2014-01-28', '2014-01-31', 3, 1, ''),
(37, 'hell ohelopo asjdakd', 'helloo hello hgelooo ', '2014-01-30', '2014-02-06', 3, 1, ''),
(38, 'getto geogeogeogoego', 'lalalalalalalalalalalala', '2014-01-29', '2014-01-31', 1, 1, '');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `termintyp`
--

CREATE TABLE IF NOT EXISTS `termintyp` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Daten für Tabelle `termintyp`
--

INSERT INTO `termintyp` (`uid`, `title`) VALUES
(1, 'Schulung'),
(2, 'Meeting'),
(3, 'Urlaub'),
(4, 'ToDo');
