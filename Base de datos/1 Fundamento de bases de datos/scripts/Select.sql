-- Ejemplos select
SELECT	*
FROM		posts;

SELECT	titulo, fecha_publicacion, estatus
FROM		posts;

SELECT	titulo AS encabezado, fecha_publicacion AS publicado, estatus AS estado
FROM		posts;

-- SELECT	posts.titulo, categorias.nombre_categoria;
SELECT	count(*)
FROM		posts;

SELECT	count(*) numero_posts
FROM		posts;