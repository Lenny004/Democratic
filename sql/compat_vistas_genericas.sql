-- =============================================================================
-- Democratic — Vistas de compatibilidad (dominio genérico sobre tablas legacy)
-- =============================================================================
-- Base de datos: dbdemocratic
-- Propósito: exponer nombres genéricos SIN renombrar tablas ni columnas físicas.
-- Seguro de re-ejecutar: usa DROP VIEW IF EXISTS antes de cada CREATE.
--
-- Uso:
--   mysql -u root -p dbdemocratic < sql/compat_vistas_genericas.sql
--
-- NOTA: La app WinForms sigue consultando tablas legacy (tbcandidato, tbvoto, etc.).
--       Estas vistas son opcionales para reportes, BI y documentación SQL.
-- =============================================================================

USE `dbdemocratic`;

-- ---------------------------------------------------------------------------
-- Organización (legacy: tbtribunal)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_organizacion`;
CREATE VIEW `vw_organizacion` AS
SELECT
    `id_Tribunal`       AS `id_organizacion`,
    `Fundación`         AS `fecha_fundacion`,
    `Composición`       AS `descripcion`,
    `Imagen_Tribunal`   AS `imagen`,
    `Pais`              AS `pais`,
    `Tipo`              AS `tipo_organizacion`,
    `Jurisdicción`      AS `jurisdiccion`,
    `Sede`              AS `sede_principal`,
    `Correo_electronicoTribunal` AS `correo`,
    `Contra_Tribunal`   AS `contrasena_contacto`
FROM `tbtribunal`;

-- ---------------------------------------------------------------------------
-- Grupos de opciones (legacy: tbpartido_politico)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_grupos_opciones`;
CREATE VIEW `vw_grupos_opciones` AS
SELECT
    `id_Partido`        AS `id_grupo_opciones`,
    `Nombre_Partido`    AS `nombre_grupo`,
    `Imagen_Partido`    AS `imagen`,
    `Cantidad_Votos`    AS `total_votos`,
    `id_Estado_Partido` AS `id_estado_grupo`
FROM `tbpartido_politico`;

-- ---------------------------------------------------------------------------
-- Opciones (legacy: tbcandidato)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_opciones`;
CREATE VIEW `vw_opciones` AS
SELECT
    `id_Candidato`          AS `id_opcion`,
    `Nombre_Candidato`      AS `nombre`,
    `Apellido_Candidato`    AS `apellido`,
    `Género`                AS `genero`,
    `Imagen_Candidato`      AS `imagen`,
    `id_Partido`            AS `id_grupo_opciones`,
    `id_Estado_Candidato`   AS `id_estado_opcion`
FROM `tbcandidato`;

-- ---------------------------------------------------------------------------
-- Boletas (legacy: tbboleta)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_boletas`;
CREATE VIEW `vw_boletas` AS
SELECT
    `id_Boleta`         AS `id_boleta`,
    `Fecha_Votación`    AS `fecha_votacion`,
    `id_Estado_Boleta`  AS `id_estado_boleta`,
    `id_JRV`            AS `id_mesa`
FROM `tbboleta`;

-- ---------------------------------------------------------------------------
-- Votos (legacy: tbvoto)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_votos`;
CREATE VIEW `vw_votos` AS
SELECT
    `id_Voto`           AS `id_voto`,
    `id_Partido`        AS `id_grupo_opciones`,
    `id_Boleta`         AS `id_boleta`,
    `id_Estado_Voto`    AS `id_estado_voto`,
    `Fecha_Votación`    AS `fecha_votacion`,
    `Hora_Votacion`     AS `hora_votacion`
FROM `tbvoto`;

-- ---------------------------------------------------------------------------
-- Mesas (legacy: tbjrv)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_mesas`;
CREATE VIEW `vw_mesas` AS
SELECT
    `id_JRV`            AS `id_mesa`,
    `Correlativo_JRV`   AS `codigo_mesa`,
    `id_Centro_Votación` AS `id_sede`,
    `id_Estado_JRV`     AS `id_estado_mesa`
FROM `tbjrv`;

-- ---------------------------------------------------------------------------
-- Sedes (legacy: tbcentro_de_votación)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_sedes`;
CREATE VIEW `vw_sedes` AS
SELECT
    `id_Centro_Votación`    AS `id_sede`,
    `Nombre_Centro_Votación` AS `nombre_sede`,
    `id_Acta`               AS `id_registro_escrutinio`,
    `Cantidad_de_JRV`       AS `cantidad_mesas`,
    `id_Estado_CentroVotación` AS `id_estado_sede`,
    `id_Municipio`          AS `id_municipio`,
    `id_Tribunal`           AS `id_organizacion`
FROM `tbcentro_de_votación`;

-- ---------------------------------------------------------------------------
-- Registros de escrutinio (legacy: tbacta)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_registros_escrutinio`;
CREATE VIEW `vw_registros_escrutinio` AS
SELECT
    `id_Acta`           AS `id_registro_escrutinio`,
    `Cantidad_Boletas`  AS `cantidad_boletas`,
    `id_JRV`            AS `id_mesa`
FROM `tbacta`;

-- ---------------------------------------------------------------------------
-- Detalle de escrutinio (legacy: tbdetalle_acta)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_detalle_escrutinio`;
CREATE VIEW `vw_detalle_escrutinio` AS
SELECT
    `id_Detalle_Acta`   AS `id_detalle_escrutinio`,
    `Cantidad_Votos`    AS `cantidad_votos`,
    `id_Acta`           AS `id_registro_escrutinio`,
    `id_Partido`        AS `id_grupo_opciones`
FROM `tbdetalle_acta`;

-- ---------------------------------------------------------------------------
-- Participantes / padrón (legacy: tbmiembros)
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_participantes`;
CREATE VIEW `vw_participantes` AS
SELECT
    `id_Miembro`            AS `id_participante`,
    `Nombre_Miembro`        AS `nombre`,
    `Apellido_Miembro`      AS `apellido`,
    `DUI`                   AS `documento_identidad`,
    `OCR`                   AS `codigo_ocr`,
    `Imagen_Miembro`        AS `imagen`,
    `Fecha_de_nacimiento`   AS `fecha_nacimiento`,
    `Dirección_Usuario`     AS `direccion`,
    `Numero_Telefonico`     AS `telefono`,
    `id_Centro_Votación`    AS `id_sede`,
    `id_JRV`                AS `id_mesa`,
    `id_Estado_Miembros`    AS `id_estado_participante`
FROM `tbmiembros`;

-- ---------------------------------------------------------------------------
-- Usuarios y roles
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_usuarios`;
CREATE VIEW `vw_usuarios` AS
SELECT
    `id_Usuario`        AS `id_usuario`,
    `Usuario`           AS `nombre_usuario`,
    `Clave_Usuario`     AS `clave`,
    `intento`           AS `intentos_fallidos`,
    `id_Estado_Usuario` AS `id_estado_usuario`,
    `id_Tipo_Usuario`   AS `id_rol`,
    `id_JRV`            AS `id_mesa`,
    `id_Miembro`        AS `id_participante`,
    `id_Centro_Votación` AS `id_sede`,
    `HoraBlock`         AS `hora_bloqueo`,
    `HoraDesBlock`      AS `hora_desbloqueo`
FROM `tbusuario`;

DROP VIEW IF EXISTS `vw_roles`;
CREATE VIEW `vw_roles` AS
SELECT
    `id_Tipo_Usuario`   AS `id_rol`,
    `Tipo_Usuario`      AS `nombre_rol`
FROM `tbtipo_usuario`;

-- ---------------------------------------------------------------------------
-- Vista agregada: resultados por grupo (alimenta gráficas / reportes)
-- Equivalente a ModelResultados.ObtenerVotosPorGrupo y FrmGraficos.GrafVotos
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_resultados_por_grupo`;
CREATE VIEW `vw_resultados_por_grupo` AS
SELECT
    g.`id_grupo_opciones`,
    g.`nombre_grupo`,
    COUNT(v.`id_voto`) AS `total_votos`
FROM `vw_grupos_opciones` g
LEFT JOIN `vw_votos` v ON v.`id_grupo_opciones` = g.`id_grupo_opciones`
GROUP BY g.`id_grupo_opciones`, g.`nombre_grupo`;

-- ---------------------------------------------------------------------------
-- Vista agregada: opciones con nombre de grupo
-- ---------------------------------------------------------------------------
DROP VIEW IF EXISTS `vw_opciones_con_grupo`;
CREATE VIEW `vw_opciones_con_grupo` AS
SELECT
    o.`id_opcion`,
    o.`nombre`,
    o.`apellido`,
    o.`genero`,
    o.`imagen`,
    o.`id_estado_opcion`,
    g.`id_grupo_opciones`,
    g.`nombre_grupo`
FROM `vw_opciones` o
INNER JOIN `vw_grupos_opciones` g ON g.`id_grupo_opciones` = o.`id_grupo_opciones`;

-- =============================================================================
-- Comentarios opcionales en tablas legacy (MySQL 5.7+ / 8.x)
-- Descomentar si se desea documentar el esquema físico sin cambiar nombres.
-- Si una tabla no existe, el bloque fallará: ejecutar solo en BD ya provisionada.
-- =============================================================================

/*
ALTER TABLE `tbtribunal`
    COMMENT = 'Legacy: Organización del proceso de votación (dominio genérico)';

ALTER TABLE `tbpartido_politico`
    COMMENT = 'Legacy: Grupo de opciones votables';

ALTER TABLE `tbcandidato`
    COMMENT = 'Legacy: Opción concreta de la balota';

ALTER TABLE `tbboleta`
    COMMENT = 'Legacy: Boleta emitida en una mesa';

ALTER TABLE `tbvoto`
    COMMENT = 'Legacy: Voto registrado (id_Partido = id_grupo_opciones)';

ALTER TABLE `tbjrv`
    COMMENT = 'Legacy: Mesa de votación';

ALTER TABLE `tbcentro_de_votación`
    COMMENT = 'Legacy: Sede / centro del proceso';

ALTER TABLE `tbacta`
    COMMENT = 'Legacy: Registro de escrutinio por mesa';

ALTER TABLE `tbdetalle_acta`
    COMMENT = 'Legacy: Detalle de escrutinio por grupo de opciones';

ALTER TABLE `tbmiembros`
    COMMENT = 'Legacy: Participantes del padrón electoral';

ALTER TABLE `tbusuario`
    COMMENT = 'Legacy: Usuarios del sistema con rol y mesa asignada';

ALTER TABLE `tbtipo_usuario`
    COMMENT = 'Legacy: Catálogo de roles (nivel de acceso)';
*/

-- Fin del script
