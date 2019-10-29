SELECT Genero,COUNT(Artista) FROM Playlist
GROUP BY Genero 
-- o Group By pega todas as informações repetidas (neste caso no genero) da sua lista e agrupa elas
-- o Count contou quantos artistas eu tive por genero

SELECT Artista,COUNT(Nome) FROM Playlist
GROUP BY Artista

