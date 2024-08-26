------------------------------------------------------------------------
--Criação do banco de dados TestesEntity
------------------------------------------------------------------------
USE [TestesEntity]
GO
DROP TABLE Grupo;
GO
DROP TABLE Produto;
GO
DROP TABLE Usuario;
GO
------------------------------------------------------------------------
-- Criação das tabelas
------------------------------------------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NOT NULL,	
	[especificacao] [varchar](250),
	[tipo] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[grupoId] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[especificacao] [varchar](250) NOT NULL,
	[unidade] [varchar](20) NOT NULL,
	[preco] [decimal](18, 2) NOT NULL,
	[quantidade] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
FOREIGN KEY (grupoId) REFERENCES Grupo(id)
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[senha] [varchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[dataCadastro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Grupo] ON 
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (1, 'Alimentos', 'Cereais, Grãos, Óleos, Condimentos, Açucares', 'A')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (2, 'Bebidas', 'Lácteas, Refrigerantes, Alcólicas', 'B')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (3, 'Panificação', 'Farinhas, Fermentos', 'P')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (4, 'Massas', 'Massas e Molhos em geral', 'M')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (5, 'Limpeza', 'Sabão, Detergentes, Desinfetantes', 'L')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (6, 'Higiene', 'Creme Dental, Shampoo, Papel Higiênico', 'H')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (7, 'Carnes', 'Bovina, Suína, Aves, Peixes', 'C')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (8, 'Laticínios', 'Leite, Ovos, Iogurte', 'T')
GO
INSERT INTO [dbo].[Grupo] ([id], [descricao], [especificacao], [tipo]) VALUES (9, 'Hortifruti', 'Frutas, Verduras, Tubérculos', 'H')
GO
SET IDENTITY_INSERT [dbo].[Grupo] OFF
GO
SET IDENTITY_INSERT [dbo].[Produto] ON 
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (1, 1, N'Arroz', N'Tipo 1, Branco', N'kg', CAST(29.99 AS Decimal(18, 2)), 50)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (2, 1, N'Feijão', N'Preto, Tipo 1', N'kg', CAST(9.50 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (3, 1, N'Óleo de Soja', N'900ml', N'litro', CAST(7.00 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (4, 1, N'Sal', N'Refinado', N'kg', CAST(2.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (5, 1, N'Açúcar', N'Refinado', N'kg', CAST(5.50 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (6, 1, N'Café', N'Torrado e Moído', N'kg', CAST(15.90 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (7, 8, N'Leite', N'Integral, UHT', N'litro', CAST(4.30 AS Decimal(18, 2)), 6)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (8, 3, N'Farinha de Trigo', N'Tipo 1', N'kg', CAST(3.50 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (9, 4, N'Macarrão', N'Espaguete', N'pacote', CAST(6.20 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (10, 4, N'Molho de Tomate', N'Tradicional', N'frasco', CAST(3.20 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (11, 5, N'Sabão em Pó', N'2 kg', N'pacote', CAST(10.50 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (12, 5, N'Detergente', N'Neutro, 500ml', N'unidade', CAST(2.50 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (13, 6, N'Papel Higiênico', N'Folha dupla', N'pacote', CAST(15.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (14, 7, N'Carne Bovina', N'Corte Músculo', N'kg', CAST(45.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (15, 7, N'Frango', N'Corte Peito', N'kg', CAST(20.00 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (16, 8, N'Ovos', N'Brancos, dúzia', N'dúzia', CAST(12.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (17, 8, N'Manteiga', N'Com Sal', N'kg', CAST(5.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (18, 8, N'Queijo', N'Mussarela', N'kg', CAST(30.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (19, 9, N'Batata', N'Inglesa', N'kg', CAST(3.00 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Produto] ([id], [grupoId], [nome], [especificacao], [unidade], [preco], [quantidade]) VALUES (20, 9, N'Banana', N'Nanica', N'kg', CAST(4.00 AS Decimal(18, 2)), 6)
GO
SET IDENTITY_INSERT [dbo].[Produto] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (1, N'Lucas', N'1A3B5C7D9E0F1A2B3C4D5E6F7A8B9C', N'lucas@example.com', CAST(N'2015-04-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (2, N'Julia', N'0F1A2B3C4D5E6F7A8B9C0D1A2B3C4D', N'julia@example.com', CAST(N'2012-06-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (3, N'Carlos', N'9E8F7D6C5B4A3E2F1D0C9B8A7E6D5C', N'carlos@example.com', CAST(N'2017-03-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (4, N'Sofia', N'2F3E4D5C6B7A8E9F0C1D2B3A4C5D6E', N'sofia@example.com', CAST(N'2020-01-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (5, N'Pedro', N'4E5F6A7B8C9D0E1F2A3B4C5D6E7F8G', N'pedro@example.com', CAST(N'2011-08-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (6, N'Laura', N'7F8E9D0C1A2B3C4D5E6F7G8H9I0J1K', N'laura@example.com', CAST(N'2019-01-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (7, N'Mateus', N'0C1D2E3F4A5B6C7D8E9F0A1B2C3D4E', N'mateus@example.com', CAST(N'2016-02-11T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (8, N'Fabia', N'3A4B5C6D7E8F9G0H1I2J3K4L5M6N7O', N'fabia@example.com', CAST(N'2018-05-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (9, N'Ricardo', N'6C7D8E9F0A1B2C3D4E5F6G7H8I9J0K', N'ricardo@example.com', CAST(N'2021-09-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuario] ([id], [nome], [senha], [email], [dataCadastro]) VALUES (10, N'Beatriz', N'9F0A1B2C3D4E5F6G7H8I9J0K1L2M3N', N'beatriz@example.com', CAST(N'2013-07-18T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO

------------------------------------------------------------------------
--Comados em geral
------------------------------------------------------------------------
--SELECT * FROM Grupo;
--DELETE FROM Grupo;
--DBCC CHECKIDENT ('Grupo', RESEED, 0);

--SELECT * FROM Produto;
--DELETE FROM Produto;
--DBCC CHECKIDENT ('Produto', RESEED, 0);

--SELECT * FROM Usuario;
--DELETE FROM Usuario;
--DBCC CHECKIDENT ('Usuario', RESEED, 0);