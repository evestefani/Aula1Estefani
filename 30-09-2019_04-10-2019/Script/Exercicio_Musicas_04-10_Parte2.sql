
SELECT gen.Nome AS 'Genero', art.Nome AS 'Artista', can.Nome AS 'Canção'
FROM Generos gen 
inner join Artistas art ON gen.Id = art.GeneroId
inner join Cancoes can ON art.Id = can.ArtistasId

SELECT gen.Nome AS 'Genero',
COUNT(art.Nome) AS 'Quantidade de artistas'
FROM Generos gen
inner join Artistas art ON gen.Id = art.GeneroId
GROUP BY gen.Nome

SELECT gen.Nome AS 'Genero',
COUNT(can.Nome) AS 'Quantidade de cancções'
FROM Generos gen
inner join Artistas art ON gen.Id = art.GeneroId
inner join Cancoes can ON art.Id = can.ArtistasId
GROUP BY gen.Nome

