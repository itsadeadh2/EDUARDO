alter table sessoes alter column horaInicio datetime
alter table sessoes alter column horaFim datetime
alter table medico drop cidadeEstado
alter table medico add cidade varchar(15)
alter table medico add estado varchar(15)
alter table cliente drop cidadeEstado
alter table cliente add cidade varchar(15)
alter table cliente add estado varchar(15)
alter table responsavel drop cidadeEstado
alter table medico add cidade varchar(15)
alter table medico add estado varchar(15)
