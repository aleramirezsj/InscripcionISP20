-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 18-08-2022 a las 17:18:40
-- Versión del servidor: 10.4.10-MariaDB
-- Versión de PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inscripciondb`
--
CREATE SCHEMA IF NOT EXISTS `inscripcionDB` DEFAULT CHARACTER SET utf8 ;
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumno`
--

DROP TABLE IF EXISTS `alumno`;
CREATE TABLE IF NOT EXISTS `alumno` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ApellidoNombre` varchar(60) DEFAULT NULL,
  `DNI` int(11) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Email` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aniocarrera`
--

DROP TABLE IF EXISTS `aniocarrera`;
CREATE TABLE IF NOT EXISTS `aniocarrera` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `CarreraId` int(11) DEFAULT NULL,
  `Carrera_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_AnioCarrera_Carrera1_idx` (`Carrera_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carrera`
--

DROP TABLE IF EXISTS `carrera`;
CREATE TABLE IF NOT EXISTS `carrera` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciclolectivo`
--

DROP TABLE IF EXISTS `ciclolectivo`;
CREATE TABLE IF NOT EXISTS `ciclolectivo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inscripcion`
--

DROP TABLE IF EXISTS `inscripcion`;
CREATE TABLE IF NOT EXISTS `inscripcion` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AlumnoId` int(11) DEFAULT NULL,
  `MateriaCicloLectivoId` int(11) DEFAULT NULL,
  `Alumno_Id` int(11) NOT NULL,
  `MateriasCicloLectivo_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Inscripcion_Alumno1_idx` (`Alumno_Id`),
  KEY `fk_Inscripcion_MateriasCicloLectivo1_idx` (`MateriasCicloLectivo_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia`
--

DROP TABLE IF EXISTS `materia`;
CREATE TABLE IF NOT EXISTS `materia` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `AnioCarreraId` int(11) DEFAULT NULL,
  `AnioCarrera_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Materia_AnioCarrera1_idx` (`AnioCarrera_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materiasciclolectivo`
--

DROP TABLE IF EXISTS `materiasciclolectivo`;
CREATE TABLE IF NOT EXISTS `materiasciclolectivo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CicloLectivoId` int(11) DEFAULT NULL,
  `MateriaId` int(11) DEFAULT NULL,
  `CicloLectivo_Id` int(11) NOT NULL,
  `Materia_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_MateriasCicloLectivo_CicloLectivo1_idx` (`CicloLectivo_Id`),
  KEY `fk_MateriasCicloLectivo_Materia1_idx` (`Materia_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aniocarrera`
--
ALTER TABLE `aniocarrera`
  ADD CONSTRAINT `fk_AnioCarrera_Carrera1` FOREIGN KEY (`Carrera_Id`) REFERENCES `carrera` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `inscripcion`
--
ALTER TABLE `inscripcion`
  ADD CONSTRAINT `fk_Inscripcion_Alumno1` FOREIGN KEY (`Alumno_Id`) REFERENCES `alumno` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Inscripcion_MateriasCicloLectivo1` FOREIGN KEY (`MateriasCicloLectivo_Id`) REFERENCES `materiasciclolectivo` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `materia`
--
ALTER TABLE `materia`
  ADD CONSTRAINT `fk_Materia_AnioCarrera1` FOREIGN KEY (`AnioCarrera_Id`) REFERENCES `aniocarrera` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `materiasciclolectivo`
--
ALTER TABLE `materiasciclolectivo`
  ADD CONSTRAINT `fk_MateriasCicloLectivo_CicloLectivo1` FOREIGN KEY (`CicloLectivo_Id`) REFERENCES `ciclolectivo` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_MateriasCicloLectivo_Materia1` FOREIGN KEY (`Materia_Id`) REFERENCES `materia` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
