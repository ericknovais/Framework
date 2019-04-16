CREATE PROCEDURE [dbo].[InsertCliente]
	@NomeCliente varchar(max),
	@Email varchar(max)
AS
BEGIN
	INSERT INTO CLIENTES(NomeCliente,Email) VALUES(@NomeCliente,@Email)
END
