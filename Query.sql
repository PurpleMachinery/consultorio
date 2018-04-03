USE master;
DROP DATABASE tbdsii;
GO
CREATE DATABASE tbdsii;
GO
USE tbdsii;
GO
CREATE TABLE medicos(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
    nome NVARCHAR(60) NOT NULL,
    cpf BIGINT NOT NULL,
    nascimento DATE NOT NULL,
    sexo NVARCHAR(1) NOT NULL,	
	telefone NVARCHAR(13),
	endereco NVARCHAR(100),	
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
    nome NVARCHAR(60) NOT NULL,
    cpf BIGINT NOT NULL,
    nascimento DATE NOT NULL,
    sexo NVARCHAR(1) NOT NULL,	
	telefone NVARCHAR(13),
	endereco NVARCHAR(100)
);

CREATE TABLE atendentes(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
    nome NVARCHAR(60) NOT NULL,
    cpf BIGINT NOT NULL,
    nascimento DATE NOT NULL,
    sexo NVARCHAR(1) NOT NULL,	
	telefone NVARCHAR(13),
	endereco NVARCHAR(100)   
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
	fk_idAtendente INT REFERENCES atendentes(pk_id),
	data DATETIME NOT NULL,
);

CREATE TABLE historico(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	fk_idAgendamento INT REFERENCES agendamentos(pk_id),
	observacoes TEXT
);
GO
USE tbdsii
SELECT * FROM medicos
SELECT * FROM pacientes
SELECT * FROM atendentes

GO

insert into especialidades values ('teste');
insert into medicos (nome, cpf, nascimento, sexo, registroMedicina, telefone, endereco) 
values 
('wesley', '4900', '08-09-1999', 'm', '4545', '11958192633', 'av va')
insert into especializacoes (fk_idMedico, fk_idEspecialidade) 
values
(1,1) 

select especialidades.nome from especialidades
join especializacoes on especialidades.pk_id = especializacoes.fk_idEspecialidade 
join medicos on medicos.pk_id = especializacoes.fk_idMedico 
