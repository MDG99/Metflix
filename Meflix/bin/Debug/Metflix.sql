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

INSERT INTO usuarios (id, name, lastname, username, password, membresia_id, expiracion) VALUES (0, 'Ignacio', 'Isaac', 'MDG99', 'Isaac1234', 1, '2019-06-25');

--MEMBRESIAS

INSERT INTO membresias (id, descripcion) VALUES(0, 'Básica');
INSERT INTO membresias (id, descripcion) VALUES(1, 'Premium');     

--GENEROS

INSERT INTO generos (id, descripcion) VALUES (1, 'Terror');
INSERT INTO generos (id, descripcion) VALUES (2, 'Acción');
INSERT INTO generos (id, descripcion) VALUES (3, 'Comedia');
INSERT INTO generos (id, descripcion) VALUES (4, 'Drama');

--PELICULAS

INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1001, 'It', 1, 2017, 'Varios niños de una pequeña ciudad del estado de Maine se alían para combatir a una entidad diabólica que adopta la forma de un payaso y desde hace mucho tiempo emerge cada 27 años para saciarse de sangre infantil.', '250x300\\It.jpg', 'B15', 135, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1002, 'REC', 1, 2007, 'Una reportera y su camarógrafo graban la terrible epidemia de una enfermedad que transforma a los humanos en caníbales en un edificio de vecinos.', '250x300\\REC.jpg', 'B15', 78, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1003, 'El Despertar del Diablo', 1, 1981, 'Adolescentes en una cabaña remota accidentalmente resucitan a unas fuerzas demoníacas con un conjuro grabado y el Libro de la Muerte.', '250x300\\EDD.jpg', 'C', 117, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1004, 'El Resplandor', 1, 1980, 'Jack Torrance se convierte el cuidador de invierno del desolado Hotel Overlook, en Colorado con la esperanza de curar su bloqueo de escritor. Se instala en el hotel junto con su esposa, Wendy, y su hijo, Danny, que está plagado de premoniciones psíquicas. Como la escritura de Jack va a ninguna parte y las visiones de Danny se vuelven más preocupantes, Jack descubre oscuros secretos del hotel y comienza por convertirse en un maníaco homicida, empeñado en aterrorizar a su familia.', '250x300\\Resplandor.jpg', 'B15', 146, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1005, 'Scream: grita antes de morir', 1, 1996, 'Un asesino psicópata ataca a la hija de una de sus víctimas del pasado, mientras que una reportera de televisión investiga su identidad.', '250x300\\Scream.jpg', 'B15', 111, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1006, 'Babadook', 1, 2014, 'Una viuda con problemas descubre que su hijo está diciendo la verdad acerca de un monstruo que entró a su casa a través de las páginas de un libro infantil.', '250x300\\Babadook.jpg', 'B15', 95, 0 );
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1007, 'El Descenso', 1, 2005, 'Un año después de un severo trauma emocional, Sarah viaja a Carolina del Norte para pasar unos días explorando unas cuevas con sus amigas; después de descender bajo tierra, las amigas hallan unas pinturas extrañas y evidencias de una expedición anterior, luego descubren que no están solas. Depredadores subterráneos habitan el lugar y a ellos les gusta mucho la carne humana.', '250x300\\Descenso.jpg', 'B15', 100, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1008, 'La Bruja', 1, 2015, 'Nueva Inglaterra, 1630. Una familia compuesta por un matrimonio de colonos cristianos, padres de cinco hijos, vive cerca de un bosque al que la leyenda popular atribuye un carácter demoníaco. La convivencia estalla y la familia se desgarra al sospechar que su hija mayor practica la brujería, debido a que las cosechas no crecen y su bebé ha desaparecido.', '250x300\\Bruja.jpg', 'C', 93, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1009, 'El legado del diablo', 1, 2018, 'Después de la muerte de la matriarca de la familia Graham, su hija, Annie, se muda a la casa con su familia. Annie espera olvidar los problemas que tuvo en su infancia allá, pero todo se tuerce cuando su hija empieza a ver figuras fantasmales.', '250x300\\ELDD.jpg', 'B15', 127, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1010, 'Avengers: Infinity War', 2, 2018, 'Los superhéroes se alían para vencer al poderoso Thanos, el peor enemigo al que se han enfrentado. Si Thanos logra reunir las seis gemas del infinito: poder, tiempo, alma, realidad, mente y espacio, nadie podrá detenerlo.', '250x300\\AIW.jpg', 'B15', 160, 1);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1011, 'Isla de perros', 3, 2018, 'El alcalde de una ciudad japonesa decreta que, con motivo de una epidemia de gripe canina, todos los perros deben quedar confinados en una isla. Un niño de 12 años emprende una aventura para llegar hasta la isla y rescatar a su mascota.', '250x300\\IP.jpg', 'B', 105, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1012, 'Pantera Negra', 2, 2018, 'Después de morir su padre, T´Challa regresa a su nación, Wakanda. Una vez allí, descubre que tiene un nuevo y terrible enemigo, y T´Challa asume la personalidad de Pantera Negra para salvar no solo al reino de Wakanda, sino a toda la humanidad.', '250x300\\BP.jpg', 'B15', 135, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1013, 'Un lugar en silencio', 1, 2018, 'En el año 2020, unas criaturas misteriosas con un sentido auditivo extraordinario han diezmado a la población mundial. Una familia se oculta en una cabaña y se comunica mediante la lengua de signos para no ser cazados por estos monstruos.', '250x300\\SP.jpg', 'B15', 91, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1014, 'Aniquilación', 1, 2018, 'Lena, bióloga y antigua soldado, se une a la misión que busca a su esposo, desaparecido en una región de acceso restringido. Mientras recorren el área comprueban que está poblada por criaturas terroríficas, tan hermosas como mortíferas.', '250x300\\Aniquilacion.jpg', 'B15', 120, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1015, 'Spiderman: un nuevo universo', 2, 2018, 'Luego de ser mordido por una araña radioactiva, el joven Miles Morales desarrolla misteriosos poderes que lo transforman en el Hombre Araña. Ahora deberá usar sus nuevas habilidades ante el malvado Kingpin, un enorme demente que puede abrir portales hacia otros universos.', '250x300\\SM.jpg', 'B15', 116, 1);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1016, 'Los Increíbles 2', 2, 2018, 'Helen es reclutada para ayudar a que la acción vuelva a la vida de los Súper, mientras Bob se enfrenta a la rutina de su vida diaria "normal" en el hogar. En casa debe lidiar con un bebé que está a punto de descubrir sus superpoderes...', '250x300\\LI2.jpg', 'AA', 125, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1017, 'Misión Imposible: Repercusión', 2, 2018, 'Un traficante de armas y un grupo de terroristas pretenden realizar un triple ataque nuclear con tres artefactos de plutonio, los cuales se pierden. Ethan Hunt y su equipo tendrán que recuperarlos antes de que caigan en las manos equivocadas.', '250x300\\MIR.jpg', 'B15', 148, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1018, 'Ready Player One: Comienza el juego', 2, 2018, 'Año 2045: el adolescente Wade Watts es solo una de las millones de personas que se evaden del sombrío mundo real para sumergirse en un mundo utópico virtual donde todo es posible: OASIS. Wade participa en la búsqueda del tesoro que el creador de este mundo imaginario dejó oculto en su obra...', '250x300\\RPO.jpg', 'B15', 139, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1019, 'El Reino', 4, 2018, 'Manuel es un político muy querido pero que también es corrupto. Cuando sale a la luz un caso de corrupción que salpica a un compañero, Manuel intenta encubrirlo pero comete un error y es él el que queda expuesto...', '250x300\\ER.jpg', 'B15', 132, 0);
INSERT INTO peliculas (codigo, titulo, genero_id, year, sinopsis, imagen, clasificacion, duracion, membresia_id)
VALUES (1020, 'Deadpool 2', 2, 2018, 'Deadpool debe proteger a Russell, un adolescente mutante, de Cable, un soldado del futuro genéticamente modificado. Deadpool se alía con otros superhéroes para poder derrotar al poderoso Cable.', '250x300\\DP2.jpg', 'B15', 134, 0);

--PELICULAS VISTAS
INSERT INTO registro_peliculas (usuario_id, pelicula_codigo) VALUES (0,1001);

--QUERYS

SELECT * FROM registro_peliculas rs WHERE rs.usuario_id = 0;

SELECT * FROM membresias;

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