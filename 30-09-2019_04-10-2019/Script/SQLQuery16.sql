update -- Palavra reservada que atualiza informações 
livros -- Nossa tabela que será alterada a informação
set -- set inicializa a primeira alteração em nosso SQL
ativo = 0 -- Expressão que vai ser alterada
where -- Palavra qUe iniciliza as condições para esta alteração
id = 
(select id from livros where ativo = 1 order by id desc -- ordena na ordem descrescente o ID
offset 0 rows fetch next 1 rows only) -- mostra somente a linha que queremos e nesse caso seria a penultima linha