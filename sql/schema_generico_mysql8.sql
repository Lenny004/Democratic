-- Democratic — Esquema generico MySQL 8.x
-- Uso: mysql -u root -p < sql/schema_generico_mysql8.sql

SET NAMES utf8mb4;
SET collation_connection = 'utf8mb4_unicode_ci';

CREATE DATABASE IF NOT EXISTS `dbdemocratic`
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE `dbdemocratic`;

SET FOREIGN_KEY_CHECKS = 0;

DROP TABLE IF EXISTS `tb_detalle_participante`;
DROP TABLE IF EXISTS `tb_voto`;
DROP TABLE IF EXISTS `tb_boleta`;
DROP TABLE IF EXISTS `tb_detalle_escrutinio`;
DROP TABLE IF EXISTS `tb_registro_escrutinio`;
DROP TABLE IF EXISTS `tb_opcion`;
DROP TABLE IF EXISTS `tb_participante`;
DROP TABLE IF EXISTS `tb_usuario`;
DROP TABLE IF EXISTS `tb_mesa`;
DROP TABLE IF EXISTS `tb_sede`;
DROP TABLE IF EXISTS `tb_grupo_opciones`;
DROP TABLE IF EXISTS `tb_organizacion`;
DROP TABLE IF EXISTS `tb_municipio`;
DROP TABLE IF EXISTS `tb_rol`;
DROP TABLE IF EXISTS `tb_estado_usuario`;
DROP TABLE IF EXISTS `tb_estado_participante`;
DROP TABLE IF EXISTS `tb_estado_voto`;
DROP TABLE IF EXISTS `tb_estado_boleta`;
DROP TABLE IF EXISTS `tb_estado_mesa`;
DROP TABLE IF EXISTS `tb_estado_sede`;
DROP TABLE IF EXISTS `tb_estado_opcion`;
DROP TABLE IF EXISTS `tb_estado_grupo`;

SET FOREIGN_KEY_CHECKS = 1;

CREATE TABLE `tb_rol` (
  `id_rol` INT NOT NULL AUTO_INCREMENT,
  `nombre_rol` VARCHAR(80) NOT NULL,
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_grupo` (
  `id_estado_grupo` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_grupo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_opcion` (
  `id_estado_opcion` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_opcion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_sede` (
  `id_estado_sede` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_sede`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_mesa` (
  `id_estado_mesa` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_mesa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_boleta` (
  `id_estado_boleta` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_boleta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_voto` (
  `id_estado_voto` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_voto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_participante` (
  `id_estado_participante` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_participante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_estado_usuario` (
  `id_estado_usuario` INT NOT NULL AUTO_INCREMENT,
  `nombre_estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_municipio` (
  `id_municipio` INT NOT NULL AUTO_INCREMENT,
  `nombre_municipio` VARCHAR(120) NOT NULL,
  PRIMARY KEY (`id_municipio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_organizacion` (
  `id_organizacion` INT NOT NULL AUTO_INCREMENT,
  `fecha_fundacion` VARCHAR(120) NULL,
  `descripcion` TEXT NULL,
  `imagen` LONGTEXT NULL,
  `pais` VARCHAR(120) NULL,
  `tipo_organizacion` VARCHAR(120) NULL,
  `jurisdiccion` VARCHAR(120) NULL,
  `sede_principal` VARCHAR(120) NULL,
  `correo` VARCHAR(120) NULL,
  `contrasena_contacto` VARCHAR(120) NULL,
  PRIMARY KEY (`id_organizacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_grupo_opciones` (
  `id_grupo_opciones` INT NOT NULL AUTO_INCREMENT,
  `nombre_grupo` VARCHAR(120) NOT NULL,
  `imagen` LONGTEXT NULL,
  `total_votos` INT NOT NULL DEFAULT 0,
  `id_estado_grupo` INT NOT NULL,
  PRIMARY KEY (`id_grupo_opciones`),
  KEY `fk_grupo_estado` (`id_estado_grupo`),
  CONSTRAINT `fk_grupo_estado` FOREIGN KEY (`id_estado_grupo`) REFERENCES `tb_estado_grupo` (`id_estado_grupo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_opcion` (
  `id_opcion` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(120) NOT NULL,
  `apellido` VARCHAR(120) NULL,
  `genero` VARCHAR(30) NULL,
  `imagen` LONGTEXT NULL,
  `id_grupo_opciones` INT NOT NULL,
  `id_estado_opcion` INT NOT NULL,
  PRIMARY KEY (`id_opcion`),
  KEY `fk_opcion_grupo` (`id_grupo_opciones`),
  KEY `fk_opcion_estado` (`id_estado_opcion`),
  CONSTRAINT `fk_opcion_grupo` FOREIGN KEY (`id_grupo_opciones`) REFERENCES `tb_grupo_opciones` (`id_grupo_opciones`),
  CONSTRAINT `fk_opcion_estado` FOREIGN KEY (`id_estado_opcion`) REFERENCES `tb_estado_opcion` (`id_estado_opcion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_registro_escrutinio` (
  `id_registro_escrutinio` INT NOT NULL AUTO_INCREMENT,
  `cantidad_boletas` INT NOT NULL DEFAULT 0,
  `id_mesa` INT NULL,
  PRIMARY KEY (`id_registro_escrutinio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_sede` (
  `id_sede` INT NOT NULL AUTO_INCREMENT,
  `nombre_sede` VARCHAR(120) NOT NULL,
  `id_registro_escrutinio` INT NULL,
  `cantidad_mesas` INT NOT NULL DEFAULT 0,
  `id_estado_sede` INT NOT NULL,
  `id_municipio` INT NULL,
  `id_organizacion` INT NULL,
  PRIMARY KEY (`id_sede`),
  KEY `fk_sede_estado` (`id_estado_sede`),
  KEY `fk_sede_municipio` (`id_municipio`),
  KEY `fk_sede_organizacion` (`id_organizacion`),
  KEY `fk_sede_registro` (`id_registro_escrutinio`),
  CONSTRAINT `fk_sede_estado` FOREIGN KEY (`id_estado_sede`) REFERENCES `tb_estado_sede` (`id_estado_sede`),
  CONSTRAINT `fk_sede_municipio` FOREIGN KEY (`id_municipio`) REFERENCES `tb_municipio` (`id_municipio`),
  CONSTRAINT `fk_sede_organizacion` FOREIGN KEY (`id_organizacion`) REFERENCES `tb_organizacion` (`id_organizacion`),
  CONSTRAINT `fk_sede_registro` FOREIGN KEY (`id_registro_escrutinio`) REFERENCES `tb_registro_escrutinio` (`id_registro_escrutinio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_mesa` (
  `id_mesa` INT NOT NULL AUTO_INCREMENT,
  `codigo_mesa` VARCHAR(50) NOT NULL,
  `id_sede` INT NOT NULL,
  `id_estado_mesa` INT NOT NULL,
  PRIMARY KEY (`id_mesa`),
  KEY `fk_mesa_sede` (`id_sede`),
  KEY `fk_mesa_estado` (`id_estado_mesa`),
  CONSTRAINT `fk_mesa_sede` FOREIGN KEY (`id_sede`) REFERENCES `tb_sede` (`id_sede`),
  CONSTRAINT `fk_mesa_estado` FOREIGN KEY (`id_estado_mesa`) REFERENCES `tb_estado_mesa` (`id_estado_mesa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

ALTER TABLE `tb_registro_escrutinio`
  ADD CONSTRAINT `fk_registro_mesa` FOREIGN KEY (`id_mesa`) REFERENCES `tb_mesa` (`id_mesa`);

CREATE TABLE `tb_boleta` (
  `id_boleta` INT NOT NULL AUTO_INCREMENT,
  `fecha_votacion` VARCHAR(20) NOT NULL,
  `id_estado_boleta` INT NOT NULL,
  `id_mesa` INT NOT NULL,
  PRIMARY KEY (`id_boleta`),
  KEY `fk_boleta_estado` (`id_estado_boleta`),
  KEY `fk_boleta_mesa` (`id_mesa`),
  CONSTRAINT `fk_boleta_estado` FOREIGN KEY (`id_estado_boleta`) REFERENCES `tb_estado_boleta` (`id_estado_boleta`),
  CONSTRAINT `fk_boleta_mesa` FOREIGN KEY (`id_mesa`) REFERENCES `tb_mesa` (`id_mesa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_voto` (
  `id_voto` INT NOT NULL AUTO_INCREMENT,
  `id_grupo_opciones` INT NOT NULL,
  `id_boleta` INT NOT NULL,
  `id_estado_voto` INT NOT NULL,
  `fecha_votacion` VARCHAR(20) NOT NULL,
  `hora_votacion` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id_voto`),
  KEY `fk_voto_grupo` (`id_grupo_opciones`),
  KEY `fk_voto_boleta` (`id_boleta`),
  KEY `fk_voto_estado` (`id_estado_voto`),
  CONSTRAINT `fk_voto_grupo` FOREIGN KEY (`id_grupo_opciones`) REFERENCES `tb_grupo_opciones` (`id_grupo_opciones`),
  CONSTRAINT `fk_voto_boleta` FOREIGN KEY (`id_boleta`) REFERENCES `tb_boleta` (`id_boleta`),
  CONSTRAINT `fk_voto_estado` FOREIGN KEY (`id_estado_voto`) REFERENCES `tb_estado_voto` (`id_estado_voto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_participante` (
  `id_participante` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(120) NOT NULL,
  `apellido` VARCHAR(120) NULL,
  `documento_identidad` VARCHAR(30) NOT NULL,
  `codigo_ocr` VARCHAR(30) NULL,
  `imagen` LONGTEXT NULL,
  `fecha_nacimiento` VARCHAR(20) NULL,
  `direccion` VARCHAR(255) NULL,
  `telefono` VARCHAR(30) NULL,
  `id_sede` INT NULL,
  `id_mesa` INT NULL,
  `id_estado_participante` INT NOT NULL,
  PRIMARY KEY (`id_participante`),
  UNIQUE KEY `uk_participante_dui` (`documento_identidad`),
  KEY `fk_participante_sede` (`id_sede`),
  KEY `fk_participante_mesa` (`id_mesa`),
  KEY `fk_participante_estado` (`id_estado_participante`),
  CONSTRAINT `fk_participante_sede` FOREIGN KEY (`id_sede`) REFERENCES `tb_sede` (`id_sede`),
  CONSTRAINT `fk_participante_mesa` FOREIGN KEY (`id_mesa`) REFERENCES `tb_mesa` (`id_mesa`),
  CONSTRAINT `fk_participante_estado` FOREIGN KEY (`id_estado_participante`) REFERENCES `tb_estado_participante` (`id_estado_participante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_usuario` (
  `id_usuario` INT NOT NULL AUTO_INCREMENT,
  `nombre_usuario` VARCHAR(80) NOT NULL,
  `clave` VARCHAR(120) NOT NULL,
  `intentos_fallidos` INT NOT NULL DEFAULT 0,
  `id_estado_usuario` INT NOT NULL,
  `id_rol` INT NOT NULL,
  `id_mesa` INT NULL,
  `id_participante` INT NULL,
  `id_sede` INT NULL,
  `hora_bloqueo` VARCHAR(20) NULL,
  `hora_desbloqueo` VARCHAR(20) NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `uk_usuario_nombre` (`nombre_usuario`),
  KEY `fk_usuario_estado` (`id_estado_usuario`),
  KEY `fk_usuario_rol` (`id_rol`),
  KEY `fk_usuario_mesa` (`id_mesa`),
  KEY `fk_usuario_participante` (`id_participante`),
  KEY `fk_usuario_sede` (`id_sede`),
  CONSTRAINT `fk_usuario_estado` FOREIGN KEY (`id_estado_usuario`) REFERENCES `tb_estado_usuario` (`id_estado_usuario`),
  CONSTRAINT `fk_usuario_rol` FOREIGN KEY (`id_rol`) REFERENCES `tb_rol` (`id_rol`),
  CONSTRAINT `fk_usuario_mesa` FOREIGN KEY (`id_mesa`) REFERENCES `tb_mesa` (`id_mesa`),
  CONSTRAINT `fk_usuario_participante` FOREIGN KEY (`id_participante`) REFERENCES `tb_participante` (`id_participante`),
  CONSTRAINT `fk_usuario_sede` FOREIGN KEY (`id_sede`) REFERENCES `tb_sede` (`id_sede`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_detalle_escrutinio` (
  `id_detalle_escrutinio` INT NOT NULL AUTO_INCREMENT,
  `cantidad_votos` INT NOT NULL DEFAULT 0,
  `id_registro_escrutinio` INT NOT NULL,
  `id_grupo_opciones` INT NOT NULL,
  PRIMARY KEY (`id_detalle_escrutinio`),
  KEY `fk_detalle_registro` (`id_registro_escrutinio`),
  KEY `fk_detalle_grupo` (`id_grupo_opciones`),
  CONSTRAINT `fk_detalle_registro` FOREIGN KEY (`id_registro_escrutinio`) REFERENCES `tb_registro_escrutinio` (`id_registro_escrutinio`),
  CONSTRAINT `fk_detalle_grupo` FOREIGN KEY (`id_grupo_opciones`) REFERENCES `tb_grupo_opciones` (`id_grupo_opciones`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `tb_detalle_participante` (
  `id_detalle` INT NOT NULL AUTO_INCREMENT,
  `detalle` VARCHAR(255) NULL,
  `id_participante` INT NOT NULL,
  `id_mesa` INT NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_det_participante` (`id_participante`),
  KEY `fk_det_mesa` (`id_mesa`),
  CONSTRAINT `fk_det_participante` FOREIGN KEY (`id_participante`) REFERENCES `tb_participante` (`id_participante`),
  CONSTRAINT `fk_det_mesa` FOREIGN KEY (`id_mesa`) REFERENCES `tb_mesa` (`id_mesa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `tb_rol` (`id_rol`, `nombre_rol`) VALUES
  (1, 'Superadministrador'),
  (2, 'Votante'),
  (3, 'Supervisor'),
  (4, 'Auditor'),
  (5, 'Representante de grupo'),
  (6, 'Operador de mesa'),
  (7, 'Administrador');

INSERT INTO `tb_estado_grupo` (`nombre_estado`) VALUES ('Activo'), ('Inactivo');
INSERT INTO `tb_estado_opcion` (`nombre_estado`) VALUES ('Activo'), ('Inactivo');
INSERT INTO `tb_estado_sede` (`nombre_estado`) VALUES ('Activo'), ('Inactivo');
INSERT INTO `tb_estado_mesa` (`nombre_estado`) VALUES ('Activo'), ('Inactivo');
INSERT INTO `tb_estado_boleta` (`nombre_estado`) VALUES ('Emitida'), ('Anulada');
INSERT INTO `tb_estado_voto` (`nombre_estado`) VALUES ('Valido'), ('Anulado');
INSERT INTO `tb_estado_participante` (`nombre_estado`) VALUES ('Activo'), ('Inactivo');
INSERT INTO `tb_estado_usuario` (`nombre_estado`) VALUES ('Activo'), ('Bloqueado'), ('Inactivo');

INSERT INTO `tb_municipio` (`nombre_municipio`) VALUES ('Municipio demo');
