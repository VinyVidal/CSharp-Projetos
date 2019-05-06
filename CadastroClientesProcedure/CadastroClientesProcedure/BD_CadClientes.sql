CREATE DATABASE BD_CadClientes
GO

USE BD_CadClientes
GO

CREATE TABLE Tbl_Clientes 
(
	idCliente int identity primary key,
	nomeCliente varchar(100) NOT NULL,
	telefoneCliente char(11) NOT NULL,
	emailCliente varchar(255),
)
GO

/* Criando stored procedure chamada insert_Cliente
*  Insere os dados do cliente na tabela Tbl_Clientes
*/

CREATE PROCEDURE insert_Cliente 
	@nome varchar(100),
	@telefone char(15),
	@email varchar(255) = null
AS
	INSERT INTO Tbl_Clientes(nomeCliente, telefoneCliente, emailCliente)
	VALUES (@nome, @telefone, @email)
GO


/* Criando stored procedure para atualizar os dados do cliente */
CREATE PROCEDURE update_Cliente
	@id int,
	@novoNome varchar(100),
	@novoTelefone char(15),
	@novoEmail varchar(255) = null
AS
	UPDATE Tbl_Clientes SET
		nomeCliente = @novoNome,
		telefoneCliente = @novoTelefone,
		emailCliente = @novoEmail
		WHERE idCliente = @id;
GO


/* Criando stored procedure para excluir um registro da Tbl_Clientes */
CREATE PROCEDURE delete_Cliente
	@id int
AS
	DELETE FROM Tbl_Clientes WHERE idCliente = @id;
GO


CREATE PROCEDURE SelectAll_Clientes
AS
	SELECT idCliente, nomeCliente, telefoneCliente, emailCliente FROM Tbl_Clientes 
GO

CREATE PROCEDURE SelectById_Cliente
	@id int
AS
	SELECT idCliente, nomeCliente, telefoneCliente, emailCliente FROM Tbl_Clientes WHERE idCliente = @id
GO


CREATE PROCEDURE SelectByName_Cliente
	@nome varchar(100)
AS
	SELECT idCliente, nomeCliente, telefoneCliente, emailCliente FROM Tbl_Clientes WHERE nomeCliente LIKE '%'+@nome+'%'
GO


/* INSERT DE DADOS*/
EXEC insert_Cliente
	@nome = 'Josenildo Alves',
	@telefone = '1145679883',
	@email = 'jose.nildo@hotmail.com'
GO

EXEC insert_Cliente
	@nome = 'Fatima Carvalho',
	@telefone = '11975678245'
GO

EXEC insert_Cliente
	@nome = 'Maria Souza',
	@telefone = '11912345678',
	@email = 'donamaria@outlook.com'
GO