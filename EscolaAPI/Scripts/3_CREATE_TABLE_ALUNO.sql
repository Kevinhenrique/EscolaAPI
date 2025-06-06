USE [Escola]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ALUNO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](255) NULL,
	[CPF] [varchar](11) NULL,
	[DATA_NASCIMENTO] [date] NULL,
	[EMAIL] [varchar](255) NULL,
	[SEXO] [char](1) NULL,
	[TELEFONE] [varchar](11) NULL,
	[ENDERECO] [varchar](255) NULL,
	[BAIRRO] [varchar](180) NULL,
	[RUA] [varchar](180) NULL,
	[COMPLEMENTO] [varchar](180) NULL,
	[ESTADO] [varchar](180) NULL,
	[CIDADE] [varchar](180) NULL,
	[ID_CLASSE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ALUNO]  WITH CHECK ADD  CONSTRAINT [fk_CLASSE] FOREIGN KEY([ID_CLASSE])
REFERENCES [dbo].[CLASSE] ([ID])
GO

ALTER TABLE [dbo].[ALUNO] CHECK CONSTRAINT [fk_CLASSE]
GO


