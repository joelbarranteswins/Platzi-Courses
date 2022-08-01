-- Lo que quieres mostrar = SELECT
-- De donde voy a tomar los datos = FROM
-- Los filtros de los datos que quieres mostrar = WHERE
-- Los rubros por los que me interesa agrupar mi información = GROUP BY
-- El orden en que quiero presentar mi información ORDER BY
-- Los filtros que quiero que mis datos agrupados tengan HAVING

-- ¿Cuántos tags tienen cada post?
SELECT  posts.titulo, COUNT(*) AS num_etiquetas
FROM    posts
    INNER JOIN posts_etiquetas ON posts.id = posts_etiquetas.post_id
    INNER JOIN etiquetas ON etiquetas.id = posts_etiquetas.etiqueta_id
GROUP BY posts.id;

-- ¿Cuál es el tag que mas se repite?
SELECT  etiquetas.nombre_etiqueta, COUNT(*) AS ocurrencias
FROM etiquetas
    INNER JOIN posts_etiquetas ON etiquetas.id = posts_etiquetas.etiqueta_id
GROUP BY etiquetas.id
ORDER BY ocurrencias DESC;

-- Los tags que tiene un post separados por comas
SELECT  posts.titulo, GROUP_CONCAT(nombre_etiqueta)
FROM    posts
    INNER JOIN posts_etiquetas ON posts.id = posts_etiquetas.post_id
    INNER JOIN etiquetas ON etiquetas.id = posts_etiquetas.etiqueta_id
GROUP BY posts.id;

-- ¿Que etiqueta no tiene ningun post asociado?
SELECT	*
FROM	etiquetas 
	LEFT JOIN posts_etiquetas on etiquetas.id = posts_etiquetas.etiqueta_id
WHERE	posts_etiquetas.etiqueta_id IS NULL;

-- Las categorías ordenadas por numero de posts
SELECT c.nombre_categoria, COUNT(*) AS cant_posts
FROM    categorias AS c
    INNER JOIN posts AS p on c.id = p.categoria_id
GROUP BY c.id
ORDER BY cant_posts DESC;

-- ¿Cuál es la categoría que tiene mas posts?
SELECT c.nombre_categoria, COUNT(*) AS cant_posts
FROM    categorias AS c
    INNER JOIN posts AS p on c.id = p.categoria_id
GROUP BY c.id
ORDER BY cant_posts DESC
LIMIT 1;

-- ¿Que usuario ha contribuido con mas post?
SELECT u.nickname, COUNT(*) AS cant_posts
FROM    usuarios AS u
    INNER JOIN posts AS p on u.id = p.usuario_id
GROUP BY u.id
ORDER BY cant_posts DESC
LIMIT 1;

-- ¿De que categorías escribe cada usuario?
SELECT u.nickname, COUNT(*) AS cant_posts,  GROUP_CONCAT(nombre_categoria)
FROM    usuarios AS u
    INNER JOIN posts AS p ON u.id = p.usuario_id
    INNER JOIN categorias AS c ON c.id = p.categoria_id
GROUP BY u.id;

-- ¿Que usuario no tiene ningun post asociado?
SELECT	*
FROM	usuarios 
	LEFT JOIN posts on usuarios.id = posts.usuario_id
WHERE	posts.usuario_id IS NULL