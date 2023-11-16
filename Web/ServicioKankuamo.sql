CREATE DATABASE IF NOT EXISTS ServicioKankuamo;

USE ServicioKankuamo;

CREATE TABLE IF NOT EXISTS Usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombres VARCHAR(255) NOT NULL,
    apellidos VARCHAR(255) NOT NULL,
    correo VARCHAR(255) NOT NULL,
    desea_habilitar_servicio BOOLEAN NOT NULL
);