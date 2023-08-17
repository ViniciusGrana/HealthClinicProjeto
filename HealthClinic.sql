CREATE DATABASE HealthClinicManha

Use HealthClinicManha


Create Table Especialidade
(
IdEspecialidade INT PRIMARY KEY IDENTITY,
TituloEspecialidade VARCHAR(50) NOT NULL
)

CREATE TABLE TipoDeUsuario
(
IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
TituloTipoUsuario VARCHAR (100) NOT NUll
)

CREATE TABLE Usuario
(
IdUsuario INT PRIMARY KEY IDENTITY,
IdTipoDeUsuario INT FOREIGN KEY REFERENCES TipoDeUsuario(IdTipoDeUsuario),
Email VARCHAR (100) NOT NULL,
Senha VarChar (100) NOT NULL,
Telefone CHAR (11) Not NULL,
CPF Char (11) NOT Null
)


CREATE TABLE Clinica
(
IdClinica INT PRIMARY KEY IDENTITY,
CNPJ CHAR (14) NOT NULL,
NomeFantasia VARCHAR (30) NOT NULL,
RazaoSocial VARCHAR (50) NOT NULL,
Endereco VARCHAR (50) NOT NULL,
HorarioAbertura VARCHAR (5) NOT NULL,
HorarioFechamento VARCHAR (5) NOT NULL
)

CREATE TABLE Medico
(
IdMedico INT PRIMARY KEY IDENTITY,
IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
IdClinica Int FOREIGN KEY REFERENCES Clinica(IdClinica),
IdEspecialidade INT FOREIGN KEY REFERENCES Especialidade(IdEspecialidade),
Nome VarCHar(30) NOT NULL,
CRM CHAR (6) NOT NULL
)

CREATE TABLE Paciente
(
IdPaciente INT PRIMARY KEY IDENTITY,
IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
Nome VARCHAR (50) NOT NULL,
Idade VARCHAR (3) NOT NULL
)

CREATE TABLE Consulta
(
IdConsulta INT PRIMARY KEY IDENTITY,
IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente),
IdMedico INT FOREIGN KEY REFERENCES Medico(IdMedico),
IdProntuario INT FOREIGN KEY REFERENCES Prontuario(IdProntuario),
IdComentario INT FOREIGN KEY REFERENCES Comentario(IdComentario),
DataConsulta DATETIME
)

CREATE TABLE Comentario
(
IdComentario INT PRIMARY KEY IDENTITY,
Descricao VARCHAR (100) NOT NULL
)

CREATE TABLE Prontuario
(
IdProntuario INT PRIMARY KEY IDENTITY,
DescricaoProntuario VARCHAR (100) NOT NULL
)

DROP DATABASE HealthClinicManha