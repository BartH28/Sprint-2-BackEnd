USE inlock_games_TARDE
GO

SELECT * FROM ESTUDIO;
SELECT * FROM JOGOS;
SELECT * FROM USUARIO;
SELECT * FROM TIPO_DE_USUARIO;

SELECT nomeJogo, descri��o, dataLan�amento, valor, nomeEstudio FROM JOGOS
LEFT JOIN ESTUDIO
ON JOGOS.idEstudio = ESTUDIO.idEstudio
GO

SELECT nomeEstudio, nomeJogo as jogo FROM ESTUDIO
LEFT JOIN JOGOS
ON JOGOS.idEstudio = ESTUDIO.idEstudio
GO

SELECT nomeEstudio AS ESTUDIO, nomeJogo AS JOGO FROM JOGOS
RIGHT JOIN ESTUDIO
ON JOGOS.idEstudio = ESTUDIO.idEstudio
GO

SELECT * FROM USUARIO
WHERE email = 'admin@admin.com' and senha = 'admin'
GO

SELECT * FROM JOGOS
WHERE idJogo = 2
GO

SELECT * FROM ESTUDIO
WHERE idEstudio = 2
GO