-- ORDER BY
SELECT	*
FROM		posts
ORDER BY fecha_publicacion ASC;

SELECT	*
FROM		posts
ORDER BY fecha_publicacion DESC;

SELECT	*
FROM		posts
ORDER BY titulo ASC;

SELECT	*
FROM		posts
ORDER BY titulo DESC;

SELECT	*
FROM		posts
ORDER BY usuario_id ASC
LIMIT 5;

SELECT	MONTHNAME(fecha_publicacion) AS post_month, estatus, COUNT(*) AS post_quantity
FROM		posts
GROUP BY estatus, post_month
ORDER BY post_month;

-- HAVING
SELECT	MONTHNAME(fecha_publicacion) AS post_month, estatus, COUNT(*) AS post_quantity
FROM		posts
WHERE post_quantity > 1
GROUP BY estatus, post_month
ORDER BY post_month;

SELECT	MONTHNAME(fecha_publicacion) AS post_month, estatus, COUNT(*) AS post_quantity
FROM		posts
GROUP BY estatus, post_month
HAVING post_quantity > 1
ORDER BY post_month;