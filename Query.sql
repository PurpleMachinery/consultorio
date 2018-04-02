USE master;
--DROP DATABASE dsii;

CREATE DATABASE dsii;
GO
USE dsii;
GO

CREATE TABLE pessoas(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
    nome NVARCHAR(60) NOT NULL,
    cpf BIGINT NOT NULL,
    nascimento DATE NOT NULL,
    sexo NVARCHAR(1) NOT NULL,	
	telefone NVARCHAR(13),
	endereco NVARCHAR(100)
)
select * from pessoas;

CREATE TABLE medicos(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idPessoa INT REFERENCES pessoas(pk_id),
    registroMedicina NVARCHAR(30) NOT NULL
);

CREATE TABLE especialidades(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(80) NOT NULL,
);

CREATE TABLE especializacoes(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idMedico INT REFERENCES medicos(pk_id),
	fk_idEspecialidade INT REFERENCES especialidades(pk_id)
)

CREATE TABLE pacientes(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idPessoa INT REFERENCES pessoas(pk_id)
);

CREATE TABLE atendentes(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idPessoa INT REFERENCES pessoas(pk_id)    
);

CREATE TABLE funcionarios(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idMedico INT REFERENCES medicos(pk_id),
	fk_idAtendente INT REFERENCES atendentes(pk_id),
	numeroFuncionario BIGINT NOT NULL
);


CREATE TABLE dsLogin(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idFuncionario INT NOT NULL,
	userLogin NVARCHAR(30) NOT NULL,
	userPass NVARCHAR(30) NOT NULL,
	userEmail NVARCHAR(100) NOT NULL
);

CREATE TABLE agendamentos(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idPaciente INT REFERENCES pacientes(pk_id),
	fk_idMedico INT REFERENCES medicos(pk_id),
	data DATETIME NOT NULL,
);

CREATE TABLE historico(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idAgendamento INT REFERENCES agendamentos(pk_id),
	observacoes TEXT
);