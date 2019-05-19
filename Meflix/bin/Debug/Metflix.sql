DROP TABLE IF EXISTS [usuarios];
DROP TABLE IF EXISTS [membresias];
DROP TABLE IF EXISTS [generos];
DROP TABLE IF EXISTS [peliculas];
DROP TABLE IF EXISTS [registro_peliculas];
DROP TABLE IF EXISTS [calificaciones];


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
       duracion INTEGER NOT NULL); 
       
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
duracion) VALUES (1001, 'It', 1, 2017, 'Varios niños de una pequeña ciudad del estado de Maine se alían para combatir a una entidad diabólica que adopta la forma de un payaso y desde hace mucho tiempo emerge cada 27 años para saciarse de sangre infantil.','Imágenes\Portadas\250x300\It.jpg', 'B15', 135);  

--PELICULAS VISTAS
INSERT INTO registro_peliculas (usuario_id, pelicula_codigo) VALUES (0,1001);

--QUERYS

SELECT * FROM registro_peliculas rs WHERE rs.usuario_id = 0;

--Query para hallar las películas vistas por el usuario
SELECT pv.codigo AS codigo, pv.titulo AS titulo, pv.sinopsis AS sinopsis,
g.descripcion AS genero, pv.clasificacion AS clasificacion, 
pv.duracion AS duracion, pv.imagen AS imagen, pv.year AS year FROM generos g
INNER JOIN (
      SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis,
      p.genero_id AS genero_id, p.clasificacion AS clasificacion, 
      p.duracion AS duracion, p.imagen AS imagen, p.year AS year
      FROM peliculas p
      INNER JOIN (
              SELECT * FROM registro_peliculas rs WHERE rs.usuario_id = 0 
              ) rs ON (rs.pelicula_codigo = p.codigo)
                ) pv ON (pv.genero_id = g.id)
              
              
              
              
              
              
SELECT pv.codigo AS codigo, pv.titulo AS titulo, pv.sinopsis AS sinopsis,
                g.descripcion AS genero, pv.clasificacion AS clasificacion,
                pv.duracion AS duracion, pv.imagen AS imagen, pv.year AS year
                FROM generos g
                INNER JOIN(
                      SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis, 
                      p.genero_id AS genero_id, p.clasificacion AS clasificacion, 
                      p.duracion AS duracion, p.imagen AS imagen, p.year AS year 
                      FROM peliculas p
                      INNER JOIN( 
                              SELECT * FROM registro_peliculas rs WHERE rs.usuario_id = 0
                              ) rs ON(rs.pelicula_codigo = p.codigo)
                      ) pv ON(pv.genero_id = g.id)
    

