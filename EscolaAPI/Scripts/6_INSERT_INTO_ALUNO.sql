USE [Escola]
GO

INSERT INTO [dbo].[ALUNO]
           ([NOME]
           ,[CPF]
           ,[DATA_NASCIMENTO]
           ,[EMAIL]
           ,[SEXO]
           ,[TELEFONE]
           ,[ENDERECO]
           ,[BAIRRO]
           ,[RUA]
           ,[COMPLEMENTO]
           ,[ESTADO]
           ,[CIDADE]
           ,[ID_CLASSE])
     VALUES
           ('João Henrique de Souza'
           ,'35552645081'
           ,'2007-03-31'
           ,'joaozinho12@teste.com'
           ,'M'
           ,'11971374580'
           ,'06160201'
           ,'Bandeiras'
           ,'Avenida Zumbi dos Palmares'
           ,'Apt. Bandeiras, nº20A'
           ,'SP'
           ,'OSASCO'
           ,2)


INSERT INTO [dbo].[ALUNO]
           ([NOME]
           ,[CPF]
           ,[DATA_NASCIMENTO]
           ,[EMAIL]
           ,[SEXO]
           ,[TELEFONE]
           ,[ENDERECO]
           ,[BAIRRO]
           ,[RUA]
           ,[COMPLEMENTO]
           ,[ESTADO]
           ,[CIDADE]
           ,[ID_CLASSE])
     VALUES
           ('Maria dos Santos'
           ,'20706638093'
           ,'2008-06-09'
           ,'maria_santos@teste.com'
           ,'F'
           ,'11992574089'
           ,'06180000'
           ,'Pestana'
           ,'Rua General Newton Estilac Leal'
           ,'85'
           ,'SP'
           ,'OSASCO'
           ,1)
GO