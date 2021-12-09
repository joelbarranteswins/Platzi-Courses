-- FROM
SELECT	*
FROM		posts;
    
SELECT	*
FROM	usuarios 
	LEFT JOIN posts on usuarios.id = posts.usuario_id;
    
SELECT	*
FROM	usuarios 
	LEFT JOIN posts on usuarios.id = posts.usuario_id
WHERE	posts.usuario_id IS NULL;

SELECT	*
FROM	usuarios 
	RIGHT JOIN posts on usuarios.id = posts.usuario_id;
    
SELECT	*
FROM	usuarios 
	RIGHT JOIN posts on usuarios.id = posts.usuario_id
WHERE	posts.usuario_id IS NULL;

SELECT	*
FROM	usuarios 
	INNER JOIN posts on usuarios.id = posts.usuario_id;
    
SELECT	*
FROM	usuarios 
	JOIN posts on usuarios.id = posts.usuario_id;
    
SELECT	*
FROM		usuarios 
	LEFT JOIN posts   ON usuarios.id = posts.usuario_id
UNION 
SELECT	*
FROM		usuarios 
	RIGHT JOIN posts ON usuarios.id = posts.usuario_id;
    
SELECT	*
FROM	usuarios 
	LEFT JOIN posts on usuarios.id = posts.usuario_id
WHERE	posts.usuario_id IS NULL
UNION
SELECT	*
FROM	usuarios 
	RIGHT JOIN posts on usuarios.id = posts.usuario_id
WHERE	posts.usuario_id IS NULL;