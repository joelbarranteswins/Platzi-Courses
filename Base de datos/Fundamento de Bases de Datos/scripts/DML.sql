-- Insert
INSERT INTO people (last_name, first_name, address, city)
VALUES ('Hernández', 'Laura', 'Calle 21', 'Monterrey');

-- Update
UPDATE people
SET last_name = 'Chávez', city= 'Mérida'
WHERE person_id = 1;

UPDATE people
SET first_name = 'Juan'
WHERE city = 'Mérida';

UPDATE people
SET first_name = 'Juan';

-- Delete
DELETE FROM people 
WHERE person_id = 1;

DELETE FROM people;

-- Select
SELECT fist_name, last_name FROM people;

