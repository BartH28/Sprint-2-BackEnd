USE T_Rental
GO

INSERT INTO MARCA (nomeMarca)
VALUES ('Volkswagen'), ('Chevrolet');
GO

INSERT INTO EMPRESA(nomeEmpresa)
VALUES ('UNIDAS');
GO

INSERT INTO CLIENTE(nomeCliente,Sobrenome, CNH)
VALUES ('Carlos','Araujo' ,'123'), ('Roberto','Gomes','456');
GO

INSERT INTO MODELO (idMarca,nomeModelo)
VALUES (1, 'Gol'), (2, 'Onix'), (2, 'Meriva');
GO

INSERT INTO VEICULOS(idModelo, Placa)
VALUES (3,'3A5'), (1,'4G9'), (2, '8K0');
GO

INSERT INTO ALUGUEL(idCliente, idVeiculos)
VALUES (1, 1), (1,2), (2,3);
GO

UPDATE EMPRESA
SET idVeiculos = 3
WHERE idEmpresa = 1

UPDATE CLIENTE
SET CNH = '527988023'
WHERE idCliente = 1

UPDATE CLIENTE
SET CNH = '988023527'
WHERE idCliente = 2

UPDATE VEICULOS
SET Placa = 'GEB-7R22'
WHERE idVeiculos = 1

UPDATE VEICULOS
SET Placa = 'UAJ-8Y41'
WHERE idVeiculos = 2

UPDATE VEICULOS
SET Placa = 'ZHL-2P67'
WHERE idVeiculos = 3

UPDATE ALUGUEL
SET DataEmissão = '20210805', DataDevolussao = '20210815'
WHERE idAluguel = 1

UPDATE ALUGUEL
SET DataEmissão = '20210815', DataDevolussao = '20210915'
WHERE idAluguel = 2

UPDATE ALUGUEL
SET DataEmissão = '20210806', DataDevolussao = '20210810'
WHERE idAluguel = 3