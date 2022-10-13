-- --------------------------------------------------------
-- Host:                         184.175.77.148
-- Versión del servidor:         10.3.36-MariaDB - MariaDB Server
-- SO del servidor:              Linux
-- HeidiSQL Versión:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando datos para la tabla smartsof_inscripciondb.alumno: ~2 rows (aproximadamente)
INSERT INTO `alumno` (`Id`, `ApellidoNombre`, `DNI`, `Telefono`, `Email`) VALUES
	(1, 'Rogelio Buen Día', 25326070, '555', 'rogelioGoodMorning@gmail.com');

-- Volcando datos para la tabla smartsof_inscripciondb.aniocarrera: ~17 rows (aproximadamente)
INSERT INTO `aniocarrera` (`Id`, `Nombre`, `CarreraId`, `Carrera_Id`) VALUES
	(12, '1er Año', 0, 2),
	(13, '2do Año.', 0, 2),
	(14, '3er Año', 0, 2),
	(15, '1er Año', 0, 1),
	(16, '2do Año', 0, 1),
	(17, '3er Año', 0, 1),
	(18, '1er Año-', 0, 16),
	(19, '1er Año', 0, 17),
	(20, '2do Año-', 0, 16),
	(21, '2do Año', 0, 17),
	(22, '3er Año-', 0, 16),
	(23, '3er Año', 0, 17),
	(24, '4to Año', 0, 17),
	(25, '1er Año', 0, 18),
	(26, '1er Año', 0, 3),
	(27, '2do Año', 0, 3),
	(28, '2do Año', 0, 18),
	(29, '3er Año', 0, 18),
	(30, '4to Año', 0, 18);

-- Volcando datos para la tabla smartsof_inscripciondb.carrera: ~6 rows (aproximadamente)
INSERT INTO `carrera` (`Id`, `Nombre`) VALUES
	(1, 'Técnico Superior en Desarrollo de Software-'),
	(2, 'Profesorado de Educación Secundaria en Econom'),
	(3, 'Profesorado de Educación Inicial'),
	(16, 'Tecnicatura Superior en Soporte de Infraestructura en Tecnología de la Informaci'),
	(17, 'Profesorado de Educación Tecnológica'),
	(18, 'Profesorado de Educación Secundaria en Ciencias de la Administración');

-- Volcando datos para la tabla smartsof_inscripciondb.ciclolectivo: ~5 rows (aproximadamente)
INSERT INTO `ciclolectivo` (`Id`, `Nombre`) VALUES
	(2, '2022'),
	(3, '2019'),
	(4, '2017'),
	(5, '2021'),
	(8, '2020'),
	(9, '2018');

-- Volcando datos para la tabla smartsof_inscripciondb.materia: ~112 rows (aproximadamente)
INSERT INTO `materia` (`Id`, `Nombre`, `AnioCarreraId`, `AnioCarrera_Id`) VALUES
	(12, 'Matemática', NULL, 12),
	(13, 'Estadística', NULL, 12),
	(15, 'Pedagogía', NULL, 12),
	(17, 'Inglés Técnico I', NULL, 12),
	(18, 'UCCV Sociología', NULL, 12),
	(19, 'Comunicación (1° cuat.)', NULL, 12),
	(20, 'Administración ', NULL, 12),
	(21, 'Unidad de definición Institucional (2° cuat.)', NULL, 18),
	(22, 'Tecnología de la Información', NULL, 12),
	(24, 'Infraestructura de Redes I', NULL, 18),
	(25, 'Lógica y Estructura de Datos', NULL, 12),
	(26, 'Lógica y Programación  ', NULL, 18),
	(27, 'Ingeniería de Software I', NULL, 12),
	(28, 'Arquitectura de las Computadoras', NULL, 18),
	(29, 'Sistemas Operativos ', NULL, 12),
	(30, 'Inglés Técnico', NULL, 18),
	(31, 'Administración ', NULL, 18),
	(32, 'Física Aplicada a las Tecnologías de la Infor', NULL, 18),
	(33, 'Matemática', NULL, 18),
	(34, 'Pedagogía', NULL, 19),
	(35, 'Movimiento y Cuerpo', NULL, 19),
	(36, 'Práctica Docente I: Escenarios Educativos', NULL, 19),
	(37, 'Historia de la Tecnología', NULL, 19),
	(38, 'Diseño y Producción de la Tecnología I', NULL, 19),
	(39, 'Matemática', NULL, 19),
	(40, 'Física', NULL, 19),
	(41, 'Introducción a la Tecnología', NULL, 19),
	(42, 'Psicología de la Educación', NULL, 21),
	(43, 'Didáctica y Curriculum', NULL, 21),
	(44, 'Instituciones Educativas', NULL, 21),
	(45, 'Práctica Docente II: La Institución Escolar', NULL, 21),
	(46, 'Sujetos de la Educación I', NULL, 21),
	(47, 'Tics para la Enseñanza ', NULL, 21),
	(48, 'Procesos Productivos', NULL, 21),
	(49, 'Diseño y Producción Tecnológica II', NULL, 21),
	(50, 'Didáctica Específica I ', NULL, 21),
	(51, 'Filosofía y Educación', NULL, 23),
	(52, 'Historia Social de la Educación', NULL, 23),
	(53, 'Metodología de la Investigación', NULL, 23),
	(54, 'Práctica Docente III: La Clase', NULL, 23),
	(55, 'Sujetos de la Educación II', NULL, 23),
	(56, 'Materiales ', NULL, 23),
	(57, 'Química', NULL, 23),
	(58, 'Procesos de Control', NULL, 23),
	(59, 'Tecnologías Regionales', NULL, 23),
	(60, 'Diseño y Producción Tecnológica III', NULL, 23),
	(61, 'Didáctica Específica II ', NULL, 23),
	(62, 'Ética y Trabajo Docente', NULL, 24),
	(63, 'Educación Sexual Integral', NULL, 24),
	(64, 'Unidades de Definición Institucional I', NULL, 24),
	(65, 'Unidades de Definición Institucional II', NULL, 24),
	(66, 'Prácticas de Investigación', NULL, 24),
	(67, 'Práctica Docente IV: El Rol Docente y su Prác', NULL, 24),
	(68, 'Biotecnología ', NULL, 24),
	(69, 'Procesos de Comunicación', NULL, 24),
	(70, 'Problemáticas Sociotécnicas', NULL, 24),
	(71, 'Diseño y Producción Tecnológica IV', NULL, 24),
	(72, 'Taller de Producción Didáctica', NULL, 24),
	(73, 'Práctica Profesionalizante I ', NULL, 20),
	(74, 'Infraestructura de Datos II ', NULL, 20),
	(75, 'Base de Datos ', NULL, 20),
	(76, 'Algoritmos y Estructuras de Datos', NULL, 20),
	(77, 'Comunicación (1° cuat.)', NULL, 15),
	(78, 'Sistemas Operativos', NULL, 20),
	(79, 'Estadística', NULL, 20),
	(80, 'Innovación y Desarrollo Emprendedor', NULL, 20),
	(81, 'Unidad de definición Institucional (2° cuat.)', NULL, 20),
	(82, 'Problemáticas Socio Contemporáneas (1° cuat.)', NULL, 20),
	(83, 'Problemáticas Socio Contemporáneas (1° cuat.)', NULL, 16),
	(84, 'Unidad de definición Institucional (2° cuat.)', NULL, 16),
	(85, 'Inglés Técnico II', NULL, 16),
	(86, 'Innovación y Desarrollo Emprendedor', NULL, 16),
	(87, 'Estadística', NULL, 16),
	(88, 'Programación I', NULL, 16),
	(89, 'Ingeniería de Software II', NULL, 16),
	(90, 'Práctica Profesionalizante II ', NULL, 22),
	(91, 'Operativos y Redes ', NULL, 22),
	(92, 'Base de Datos I', NULL, 16),
	(93, 'Seguridad de los Sistemas ', NULL, 22),
	(94, 'Integridad y Migración de Datos ', NULL, 22),
	(95, 'Práctica Profesionalizante I', NULL, 16),
	(96, 'Administración de Base de Datos ', NULL, 22),
	(97, 'Ética y Responsabilidad Social', NULL, 17),
	(98, 'Derecho y Legislación Laboral ', NULL, 22),
	(99, 'Ética y Responsabilidad Social', NULL, 22),
	(100, 'Derecho y Legislación Laboral ', NULL, 17),
	(101, 'Redes y Comunicación', NULL, 17),
	(102, 'Programación II', NULL, 17),
	(103, 'Gestión de Proyectos de Software', NULL, 17),
	(104, 'Base de Datos II', NULL, 17),
	(105, 'Práctica Profesionalizante II ', NULL, 17),
	(106, 'Administración ', NULL, 15),
	(107, 'Pedagogía', NULL, 25),
	(108, 'UCCV Sociología', NULL, 25),
	(109, 'Administración General', NULL, 25),
	(110, 'Administración I', NULL, 25),
	(111, 'Sistema de Información Contable I', NULL, 25),
	(112, 'Construcción de Ciudadanía', NULL, 25),
	(113, 'Historia Económica', NULL, 25),
	(114, 'Matemática', NULL, 25),
	(115, 'Práctica Docente I', NULL, 25),
	(116, 'Instituciones Educativas', NULL, 28),
	(117, 'Didáctica y Curriculum', NULL, 28),
	(118, 'Psicología y Educación ', NULL, 28),
	(119, 'Administración II', NULL, 28),
	(120, 'Sistema de Información Contable II', NULL, 28),
	(121, 'Derecho I', NULL, 28),
	(122, 'Economía', NULL, 28),
	(123, 'Estadística Aplicada', NULL, 28),
	(124, 'Didáctica de la Administración I', NULL, 28),
	(125, 'Práctica Docencia II', NULL, 28),
	(126, 'Historia y Política de la Educación Argentina', NULL, 29),
	(127, 'Filosofía', NULL, 29),
	(128, 'Metodología de la Investigación', NULL, 29),
	(129, 'Administración III', NULL, 29),
	(130, 'Sistema de Información Contable III', NULL, 29),
	(131, 'Práctica Impositiva y Laboral', NULL, 29),
	(132, 'Derecho II', NULL, 29),
	(133, 'Didáctica de la Administración II', NULL, 29),
	(134, 'Práctica Docente III', NULL, 29),
	(135, 'Producción de los Recursos Didácticos I', NULL, 29);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
