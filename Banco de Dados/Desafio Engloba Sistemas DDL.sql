CREATE DATABASE EnglobaSistemas;
GO

Use EnglobaSistemas;
Go


CREATE TABLE Funcionario(
	IdFuncionario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL,
	CPF VARCHAR(20) UNIQUE NOT NULL,
	RG VARCHAR(20) UNIQUE NOT NULL,
	OrgaoEmissor VARCHAR(100) NOT NULL,
	TituloEleitor CHAR(12) UNIQUE NOT NULL,
	CNH CHAR(13) UNIQUE NOT NULL,
	ATIVO BIT NOT NULL,
	GESTOR BIT NOT NULL
);
GO

CREATE TABLE Endereco(
	IdEndereco INT PRIMARY KEY IDENTITY,
	endereco VARCHAR(100) NOT NULL,
	Numero CHAR(5) NOT NULL,
	Complemento VARCHAR(100),
	Bairro VARCHAR(35) NOT NULL,
	Cidade VARCHAR(25) NOT NULL,
	Referencia VARCHAR(25)
);
GO