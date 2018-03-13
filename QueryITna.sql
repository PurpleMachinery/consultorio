USE MASTER;
DROP DATABASE ATVDB;
CREATE DATABASE ATVDB;
GO
USE ATVDB;

CREATE TABLE pacientes(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	nascimento DATE NOT NULL,
	cpf FLOAT NOT NULL,
	sexo CHAR(1) NOT NULL,
	telefone NVARCHAR(13),
	endereco NVARCHAR(100) 
)
CREATE TABLE medicos(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	nascimento DATE NOT NULL,
	cpf FLOAT NOT NULL,
	sexo CHAR(1) NOT NULL,
	telefone NVARCHAR(13),
	endereco NVARCHAR(100)
)
CREATE TABLE especializacoes(
	fk_Medico INT REFERENCES medicos(pk_id),
	nome NVARCHAR(80),
	registro NVARCHAR(40)
)
CREATE TABLE atendentes(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	nascimento DATE NOT NULL,
	cpf FLOAT NOT NULL,
	sexo CHAR(1) NOT NULL,
	telefone NVARCHAR(13),
	endereco NVARCHAR(100)
)
CREATE TABLE fichamentos(
	fk_Paciente INT REFERENCES pacientes(pk_id),
	fk_Medico INT REFERENCES medicos(pk_id),
	fk_Atendente INT REFERENCES atendentes(pk_id),
	observacao TEXT,
	data DATE NOT NULL,
	hora TIME NOT NULL,
	realizacao BIT NOT NULL DEFAULT '0'
)
GO
