INSERT INTO Especialidade(TituloEspecialidade)
VALUES ('Oftalmologista'),('Odontologista')

INSERT INTO TipoDeUsuario(TituloTipoUsuario)
VALUES ('Administrador'), ('Medico'), ('Paciente')

INSERT INTO Usuario(IdTipoDeUsuario, Email, Senha, Telefone, CPF)
VALUES  (1,'vinicius@gmail.com','1234','11990241751','54208653522'), (2,'eduardo@gmail.com','9876','11947234568','12345678901'), (3,'gustavo@gmail.com','3456','11987654322','24897525790'),(2,'matheus@gmail.com','gru123','11978913544','48140414104'), (3,'joaogono@gmail.com','gorro123','11947834756', '19413098475')

INSERT INTO Clinica(CNPJ,NomeFantasia,RazaoSocial,Endereco,HorarioAbertura,HorarioFechamento)
VALUES ('12345678900987','HC','HeathClinic','Rua Sao Gabriel 2373','12:00','20:00')

INSERT INTO Medico(IdUsuario, IdClinica, IdEspecialidade, Nome, CRM)
VALUES (2,1,1,'Eduardo','862468'), (4,1,2,'Matheus','874091')

INSERT INTO Paciente(IdUsuario, Nome, Idade)
VALUES (3,'Gustavo','20'), (5,'joao','19')

INSERT INTO Consulta(IdPaciente,IdMedico,IdProntuario,IdComentario,DataConsulta)
VALUES (1,1,1,1,'16/08/2023'), (2,2,2,2,'17/08/2023') 

INSERT INTO Comentario(Descricao)
VALUES ('Medico muito atencioso'), ('Consulta feita com muita excelencia')

insert into Prontuario(DescricaoProntuario)
values ('Paciente com grau de oculos errado'),('Paciente com carie nos dentes')

 SELECT
Consulta.IdConsulta ,
Consulta.DataConsulta,
Clinica.NomeFantasia AS Clinica,
Paciente.Nome AS Paciente,
Medico.Nome AS Medico,
Especialidade.TituloEspecialidade AS Especialidade,
Medico.CRM,
Prontuario.DescricaoProntuario AS Prontuario,
Comentario.Descricao AS Comentario

from
Consulta, Clinica, Paciente, Medico, Prontuario,Especialidade, Comentario

WHERE
Consulta.IdPaciente = Paciente.IdPaciente and
Consulta.IdMedico = Medico.IdMedico and
Consulta.IdProntuario = Prontuario.IdProntuario and
Consulta.IdComentario = Comentario.IdComentario and
Especialidade.IdEspecialidade = Medico.IdEspecialidade
