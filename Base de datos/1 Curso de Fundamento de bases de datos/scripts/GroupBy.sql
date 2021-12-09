-- GROUP BY
SELECT	estatus, COUNT(*) AS post_number
FROM		posts
GROUP BY estatus;

SELECT	YEAR(fecha_publicacion) AS post_year, COUNT(*) AS post_number
FROM		posts
GROUP BY post_year;

SELECT	MONTHNAME(fecha_publicacion) AS post_month, COUNT(*) AS post_number
FROM		posts
GROUP BY post_month;

SELECT	estatus, MONTHNAME(fecha_publicacion) AS post_date, COUNT(*) AS post_number
FROM		posts
GROUP BY estatus, post_date;
