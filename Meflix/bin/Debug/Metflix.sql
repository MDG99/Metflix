DROP TABLE IF EXISTS [registro_peliculas];
DROP TABLE IF EXISTS [calificaciones];
DROP TABLE IF EXISTS [peliculas];
DROP TABLE IF EXISTS [generos];
DROP TABLE IF EXISTS [membresias];
DROP TABLE IF EXISTS [usuarios];


CREATE TABLE [usuarios](
       id INTEGER PRIMARY KEY,
       name TEXT NOT NULL,
       lastname TEXT NOT NULL,
       username TEXT NOT NULL UNIQUE,
       password TEXT NOT NULL,
       membresia_id INTEGER NOT NULL,
       expiracion TEXT NOT NULL,
       UNIQUE ([name], [lastname]),
       UNIQUE ([name], [lastname], [username]));

CREATE TABLE [membresias](
       id INTEGER PRIMARY KEY,
       descripcion TEXT NOT NULL UNIQUE);
       
CREATE TABLE [generos](
       id TEXT PRIMARY KEY,
       descripcion TEXT NOT NULL UNIQUE);
       
CREATE TABLE [peliculas](
       codigo INTEGER PRIMARY KEY,
       titulo TEXT NOT NULL UNIQUE,
       genero_id TEXT NOT NULL REFERENCES generos([id]),
       year INTEGER NOT NULL,
       sinopsis TEXT NOT NULL UNIQUE,
       imagen TEXT NOT NULL UNIQUE,
       clasificacion TEXT NOT NULL,
       duracion INTEGER NOT NULL,
       membresia_id INTEGER NOT NULL REFERENCES membresias([id])); 
       
CREATE TABLE [registro_peliculas](
       usuario_id INTEGER PRIMARY KEY REFERENCES usuarios([id]),
       pelicula_codigo INTEGER NOT NULL REFERENCES peliculas([codigo]),
       UNIQUE ([usuario_id], [pelicula_codigo]));
       
CREATE TABLE [calificaciones] (
       estatus INTEGER NOT NULL,
       puntaje INTEGER,
       opinion TEXT,
       usuario_id INTEGER NOT NULL,
       pelicula_codigo INTEGER NOT NULL,
       UNIQUE ([usuario_id], [pelicula_codigo]));
       
-- Contenido de las tablas

--USUARIOS
INSERT INTO usuarios (id, name, lastname, username, password, membresia_id, expiracion) VALUES (0, 'Ignacio', 'Isaac', 'MDG99','Isaac1234',
1,'2019-06-25');

--MEMBRESIAS
INSERT INTO membresias (id, descripcion) VALUES(0, 'Básica');
INSERT INTO membresias (id, descripcion) VALUES(1, 'Premium');     

--GENEROS
INSERT INTO generos (id, descripcion) VALUES (1,'Terror');

--PELICULAS
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion,
duracion, membresia_id) VALUES (1001, 'It', 1, 2017, 'Varios niños de una pequeña ciudad del estado de Maine se alían para combatir a una entidad diabólica que adopta la forma de un payaso y desde hace mucho tiempo emerge cada 27 años para saciarse de sangre infantil.','C:\\Users\\Sandra\\source\\repos\\Metflix\\Imágenes\Portadas\\250x300\\It.jpg', 'B15', 135, 0);  

--PELICULAS VISTAS
INSERT INTO registro_peliculas (usuario_id, pelicula_codigo) VALUES (0,1001);

--QUERYS

SELECT * FROM registro_peliculas rs WHERE rs.usuario_id = 0;

--Query para hallar las películas vistas por el usuario
SELECT pv.codigo AS codigo, pv.titulo AS titulo, pv.sinopsis AS sinopsis,
pv.genero AS genero, pv.clasificacion AS clasificacion, 
pv.duracion AS duracion, pv.imagen AS imagen, pv.year AS year,
pv.membresia AS membresia
FROM (
      SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis,
      p.genero AS genero, p.clasificacion AS clasificacion, 
      p.duracion AS duracion, p.imagen AS imagen, p.year AS year,
      m.descripcion AS membresia
      FROM membresias m
      INNER JOIN (
            SELECT pg.codigo AS codigo, pg.titulo AS titulo, pg.sinopsis AS sinopsis,
              g.descripcion AS genero, pg.clasificacion AS clasificacion, 
              pg.duracion AS duracion, pg.imagen AS imagen, pg.year AS year,
              pg.membresia_id AS membresia 
              FROM peliculas pg
              INNER JOIN generos g ON (g.id = pg.genero_id)
            ) p ON (p.membresia = m.id)
     ) pv
INNER JOIN (
      SELECT * FROM registro_peliculas r WHERE r.usuario_id = 0
      ) rs ON(rs.pelicula_codigo = pv.codigo)





--Query para hallar pelicula por género
SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis,
p.genero AS genero, p.clasificacion AS clasificacion, 
p.duracion AS duracion, p.imagen AS imagen, p.year AS year,
m.descripcion AS membresia
FROM membresias m
INNER JOIN (
              SELECT pg.codigo AS codigo, pg.titulo AS titulo, pg.sinopsis AS sinopsis,
              g.descripcion AS genero, pg.clasificacion AS clasificacion, 
              pg.duracion AS duracion, pg.imagen AS imagen, pg.year AS year,
              pg.membresia_id AS membresia 
              FROM peliculas pg
              INNER JOIN generos g ON (g.id = pg.genero_id)
            ) p ON (p.membresia = m.id)
GROUP BY p.codigo
HAVING (p.genero = 'Terror')

--Query para hallar pelicula por año        
SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis,
p.genero AS genero, p.clasificacion AS clasificacion, 
p.duracion AS duracion, p.imagen AS imagen, p.year AS year,
m.descripcion AS membresia
FROM membresias m
INNER JOIN (
              SELECT pg.codigo AS codigo, pg.titulo AS titulo, pg.sinopsis AS sinopsis,
              g.descripcion AS genero, pg.clasificacion AS clasificacion, 
              pg.duracion AS duracion, pg.imagen AS imagen, pg.year AS year,
              pg.membresia_id AS membresia 
              FROM peliculas pg
              INNER JOIN generos g ON (g.id = pg.genero_id)
            ) p ON (p.membresia = m.id)
GROUP BY p.codigo
HAVING (p.year = 2017)

--Query para hallar pelicula por clasificación 
SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis,
p.genero AS genero, p.clasificacion AS clasificacion, 
p.duracion AS duracion, p.imagen AS imagen, p.year AS year,
m.descripcion AS membresia
FROM membresias m
INNER JOIN (
              SELECT pg.codigo AS codigo, pg.titulo AS titulo, pg.sinopsis AS sinopsis,
              g.descripcion AS genero, pg.clasificacion AS clasificacion, 
              pg.duracion AS duracion, pg.imagen AS imagen, pg.year AS year,
              pg.membresia_id AS membresia 
              FROM peliculas pg
              INNER JOIN generos g ON (g.id = pg.genero_id)
            ) p ON (p.membresia = m.id)
GROUP BY p.codigo
HAVING (p.clasificacion = 'B15')

--Query para hallar pelicula por tipo de membresia
SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis,
p.genero AS genero, p.clasificacion AS clasificacion, 
p.duracion AS duracion, p.imagen AS imagen, p.year AS year,
m.descripcion AS membresia
FROM membresias m
INNER JOIN (
              SELECT pg.codigo AS codigo, pg.titulo AS titulo, pg.sinopsis AS sinopsis,
              g.descripcion AS genero, pg.clasificacion AS clasificacion, 
              pg.duracion AS duracion, pg.imagen AS imagen, pg.year AS year,
              pg.membresia_id AS membresia 
              FROM peliculas pg
              INNER JOIN generos g ON (g.id = pg.genero_id)
            ) p ON (p.membresia = m.id)
GROUP BY p.codigo
HAVING (m.descripcion = 'Básica')


--Query para sacar años
SELECT year FROM peliculas;

--Query para scar generos
SELECT descripcion FROM generos;

--Query para sacar Clasificaciones
SELECT clasificacion FROM peliculas