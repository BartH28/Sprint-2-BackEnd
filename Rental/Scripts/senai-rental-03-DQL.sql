USE T_Rental
GO
SELECT * FROM MARCA
SELECT * FROM EMPRESA
SELECT * FROM CLIENTE
SELECT * FROM MODELO
SELECT * FROM VEICULOS
SELECT * FROM ALUGUEL

SELECT  idVeiculos,  nomeModelo, Placa FROM ALUGUEL
LEFT JOIN 
WHERE idAluguel = @idAluguel

SELECT idVeiculos, nomeModelo, Placa FROM VEICULOS LEFT JOIN MODELO ON VEICULOS.idModelo = MODELO.idModelo WHERE idModelo = @idModelo

