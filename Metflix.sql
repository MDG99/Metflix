DROP TABLE IF EXISTS [usuarios];
DROP TABLE IF EXISTS [membresias];
DROP TABLE IF EXISTS [generos];
DROP TABLE IF EXISTS [peliculas];
DROP TABLE IF EXISTS [registro_peliculas];
DROP TABLE IF EXISTS [calificaciones];


CREATE TABLE [usuarios](
       id INTEGER PRIMARY KEY,
       username TEXT NOT NULL UNIQUE,
       password TEXT NOT NULL,
       name TEXT NOT NULL,
       lastname TEXT NOT NULL,
       membresia_id INTEGER NOT NULL,
       UNIQUE ([name], [lastname]),
       UNIQUE ([name], [lastname], [username]));

CREATE TABLE [membresias](
       id INTEGER PRIMARY KEY,
       descripcion TEXT NOT NULL UNIQUE);
       
CREATE TABLE [generos](
       id TEXT PRIMARY KEY,
       description TEXT NOT NULL UNIQUE);
       
CREATE TABLE [peliculas](
       codigo INTEGER PRIMARY KEY,
       titulo TEXT NOT NULL UNIQUE,
       genero_id TEXT NOT NULL,
       year INTEGER NOT NULL,
       sinopsis TEXT NOT NULL UNIQUE,
       imagen BLOB NOT NULL UNIQUE,
       clasificacion TEXT NOT NULL,
       duracion INTEGER NOT NULL); 
       
CREATE TABLE [registro_peliculas](
       usuario_id INTEGER PRIMARY KEY,
       pelicula_codigo INTEGER NOT NULL,
       UNIQUE ([usuario_id], [pelicula_codigo]);
       
CREATE TABLE [calificaciones] (
       estatus INTEGER NOT NULL,
       puntaje INTEGER,
       opinion TEXT,
       usuario_id INTEGER NOT NULL,
       pelicula_codigo INTEGER NOT NULL,
       UNIQUE ([usuario_id], [pelicula_codigo]);
       
       