/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50142
Source Host           : localhost:3306
Source Database       : clinica

Target Server Type    : MYSQL
Target Server Version : 50142
File Encoding         : 65001

Date: 2017-11-09 10:01:43
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `cita`
-- ----------------------------
DROP TABLE IF EXISTS `cita`;
CREATE TABLE `cita` (
  `id_cita` int(11) NOT NULL AUTO_INCREMENT,
  `id_tratamiento` int(11) NOT NULL,
  `id_medico` int(11) NOT NULL,
  `id_paciente` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `turno` varchar(10) DEFAULT NULL,
  `status` varchar(5) DEFAULT NULL,
  `motivo_consulta` text,
  PRIMARY KEY (`id_cita`),
  KEY `id_medico` (`id_medico`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_tratamiento` (`id_tratamiento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cita
-- ----------------------------

-- ----------------------------
-- Table structure for `clinica`
-- ----------------------------
DROP TABLE IF EXISTS `clinica`;
CREATE TABLE `clinica` (
  `id_clinica` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_clinica` varchar(50) NOT NULL,
  `RFC` varchar(20) NOT NULL,
  `num_consultorio` int(11) NOT NULL,
  `ciudad` varchar(20) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `email` varchar(20) NOT NULL,
  `web` text NOT NULL,
  `logotipo` text NOT NULL,
  PRIMARY KEY (`id_clinica`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of clinica
-- ----------------------------
INSERT INTO `clinica` VALUES ('1', 'integriza', 'd', '3', 'xocche', 'sdf', 'fds', 'sd', 'sd', 'sfd');

-- ----------------------------
-- Table structure for `especialidad`
-- ----------------------------
DROP TABLE IF EXISTS `especialidad`;
CREATE TABLE `especialidad` (
  `id_especialidad` int(11) NOT NULL AUTO_INCREMENT,
  `especialidad` varchar(20) NOT NULL,
  PRIMARY KEY (`id_especialidad`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of especialidad
-- ----------------------------
INSERT INTO `especialidad` VALUES ('1', 'PSICOLOGÍA');
INSERT INTO `especialidad` VALUES ('2', 'NUTRIOLOGÍA');

-- ----------------------------
-- Table structure for `medico`
-- ----------------------------
DROP TABLE IF EXISTS `medico`;
CREATE TABLE `medico` (
  `id_medico` int(11) NOT NULL AUTO_INCREMENT,
  `id_especialidad` int(11) NOT NULL,
  `nombre` varchar(35) NOT NULL,
  `apellido_pat` varchar(35) NOT NULL,
  `apellido_mat` varchar(35) NOT NULL,
  `cedula_prof` varchar(40) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `edad` int(11) NOT NULL,
  `genero` varchar(2) NOT NULL,
  `curp` varchar(18) NOT NULL,
  `RFC` varchar(20) NOT NULL,
  `direccion` varchar(30) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `email` varchar(35) NOT NULL,
  `status` varchar(2) NOT NULL DEFAULT 'A',
  `logo` text NOT NULL,
  PRIMARY KEY (`id_medico`),
  KEY `id_especialidad` (`id_especialidad`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of medico
-- ----------------------------
INSERT INTO `medico` VALUES ('1', '1', 'jose', 'paredes', 'lara', '', '2017-10-31', '34', '', '', '', '', '', '', 'A', '');
INSERT INTO `medico` VALUES ('2', '1', 'MARTIN ', 'CUELLO', 'VELA', 'SMD4', '2017-11-11', '45', 'M', 'FD', 'FD', 'H', 'H', 'H', 'A', 'F');

-- ----------------------------
-- Table structure for `paciente`
-- ----------------------------
DROP TABLE IF EXISTS `paciente`;
CREATE TABLE `paciente` (
  `id_paciente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  `apellido_pat` varchar(15) NOT NULL,
  `apellido_mat` varchar(15) NOT NULL,
  `genero` varchar(2) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `ciudad` varchar(40) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `tel_cel` varchar(15) NOT NULL,
  `correo` text NOT NULL,
  `fecha_registro` date NOT NULL,
  `tipo_sangre` varchar(10) NOT NULL,
  `foto` text NOT NULL,
  `status` varchar(2) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id_paciente`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of paciente
-- ----------------------------
INSERT INTO `paciente` VALUES ('1', 'sdsdf', 'sdsfsd', 'sdsdf', 'M', '2017-10-27', 'sdfds', 'sdsd', '434', 'sdc', '2017-10-13', 'F', 'C:UsersMARTINPictures30e7d6eb9b943acf1ad034fb54c4dbd3.jpg', 'A');
INSERT INTO `paciente` VALUES ('2', '', '', '', '', '2017-11-08', '', '', '', '', '2017-11-08', '', '', 'A');

-- ----------------------------
-- Table structure for `signos_vitales`
-- ----------------------------
DROP TABLE IF EXISTS `signos_vitales`;
CREATE TABLE `signos_vitales` (
  `id_signos` int(11) NOT NULL AUTO_INCREMENT,
  `peso` varchar(5) DEFAULT NULL,
  `estatura` varchar(5) DEFAULT NULL,
  `temperatura` varchar(10) DEFAULT NULL,
  `presion` varchar(10) DEFAULT NULL,
  `edad` varchar(5) DEFAULT NULL,
  `arlergias` text,
  PRIMARY KEY (`id_signos`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of signos_vitales
-- ----------------------------

-- ----------------------------
-- Table structure for `tratamiento`
-- ----------------------------
DROP TABLE IF EXISTS `tratamiento`;
CREATE TABLE `tratamiento` (
  `id_tratamiento` int(11) NOT NULL AUTO_INCREMENT,
  `id_signos` int(11) NOT NULL,
  `id_paciente` int(11) NOT NULL,
  `hora` varchar(20) NOT NULL,
  `fecha` date NOT NULL,
  `dosis` text NOT NULL,
  `indicaciones` text NOT NULL,
  PRIMARY KEY (`id_tratamiento`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_signos` (`id_signos`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tratamiento
-- ----------------------------

-- ----------------------------
-- Table structure for `usuario`
-- ----------------------------
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `id_clinica` int(11) NOT NULL,
  `id_medico` int(11) NOT NULL,
  `nickname` varchar(35) NOT NULL,
  `password` varchar(40) NOT NULL,
  `status` varchar(6) NOT NULL DEFAULT 'ACTIVO',
  `nivel` varchar(15) NOT NULL DEFAULT 'ADMINISTRADOR',
  PRIMARY KEY (`id_usuario`),
  KEY `id_medico` (`id_medico`),
  KEY `id_clinica` (`id_clinica`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuario
-- ----------------------------
INSERT INTO `usuario` VALUES ('1', '1', '1', 'pato', '12345', 'ACTIVO', 'ADMINISTRADOR');
INSERT INTO `usuario` VALUES ('2', '1', '2', 'JOSE', '12345', 'ACTIVO', 'ADMINISTRADOR');
