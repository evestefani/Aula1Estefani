insert into Usuarios
(Nome, Login, Senha) values ('Ella', 'Elia', 'Bruno')
GO
select * from Usuarios
GO
update Usuarios set Ativo = 0 
where Id in (10,12)