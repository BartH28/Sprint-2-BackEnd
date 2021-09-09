CREATE DATABASE inlock_games_TARDE
GO

USE inlock_games_TARDE
GO

CREATE TABLE ESTUDIO (
idEstudio SMALLINT	PRIMARY KEY IDENTITY(1,1),
nomeEstudio VARCHAR(20) NOT NULL 
);
GO

CREATE TABLE JOGOS (
idJogo SMALLINT	PRIMARY KEY IDENTITY(1,1),
nomeJogo VARCHAR(40) NOT NULL,
descri��o VARCHAR(120) NOT NULL,
dataLan�amento DATE,
valor SMALLMONEY NOT NULL,
idEstudio SMALLINT FOREIGN KEY REFERENCES ESTUDIO(idEstudio)
);
GO

CREATE TABLE TIPO_DE_USUARIO (
idTipoUsuario SMALLINT PRIMARY KEY IDENTITY(1,1),
Titulo VARCHAR(15) NOT NULL
);
GO

CREATE TABLE USUARIO (
idUsuario SMALLINT PRIMARY KEY IDENTITY(1,1),
email VARCHAR(256) NOT NULL,
senha VARCHAR(15) NOT NULL,
idTipoUsuario SMALLINT FOREIGN KEY REFERENCES TIPO_DE_USUARIO(idTipoUsuario)
);
GO