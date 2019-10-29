--Informamos a tabela que vamos registrar o valor
insert into Usuarios
--As colunas que vamos carregas as informações
(Nome) 
--Informamos que os valores estarão logo a seguir
values 
--Nossas informações na ordem das colunas
('Estefani')
GO
insert into Usuarios
(Nome,Login,Senha)
values
('Estefani','sol','090909')
GO
select * from Usuarios