
## Implementacion SQL Server

<u>By Joel Barrantes</u>

## Instalación

Usar el siguiente link para instalar SQL Server:
> [link de pagina](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)

Usar el siguiente link para instalar SQL Server Management Studio (SSMS)

> [link de pagina](https://docs.microsoft.com/es-es/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver15)

## Comandos introductorios

```sql
--quien soy???
SELECT suser_sname();

--A que servidor estoy conectado???
SELECT @@SERVERNAME;

--Cual es la fecha y hora del servidor??
SELECT GETDATE();

--Con que version estoy trabajando???
SELECT @@VERSION;

--Microsoft SQL Server 2017 (RTM) - 14.0.1000.169 (X64)   
--Aug 22 2017 17:04:49   Copyright (C) 2017 Microsoft Corporation  
--Developer Edition (64-bit) on Windows Server 2012 R2 Standard 6.3 <X64> (Build 9600: ) 
--(Hypervisor) 

-- que BDs existen en el servidor???
SELECT * FROM sys.databases

--master --> info del servidor, BDs
--tempdb --> administrar Colas de Espera
--model  --> plantilla para la creacion de BD
--msdb   --> JOBs, backups realizados
```
<div style="page-break-after: always;"></div>

## Creando una Base de Datos
1. Primera Forma 

```SQL
--Creando una Base de datos
CREATE DATABASE UNI00 ;

--Vista de lista de Base de Datos
SELECT * FROM sys.databases;

--muestra la informacion de una base de satos especificada o de todas las base de datos sino se especifica ninguna base de datos
EXEC sp_helpdb UNI00;
```

2. Segunda Forma

* **size**: es el tamaño minimo del archivo de datos
* **maxsize**: es el tamaño maximo del archivo de datos
*  **filegrowth**: es el facto de crecimiento, puede ser en **MB** o **%**  (tener en cuenta que el crecimiento es de forma aritmetica)

```SQL
USE MASTER

IF EXISTS (SELECT NAME FROM sys.databases WHERE NAME='UNI00')
	DROP DATABASE UNI00


CREATE DATABASE UNI00
ON (name=UNI00_data, filename='c:\disco1\UNI00_data.mdf',
	SIZE=10, maxsize=unlimited, filegrowth=10)
LOG ON(name=UNI00_log, filename='c:\disco2\UNI00_log.ldf',
	size=7, maxsize=300, filegrowth=50%)

--validando la base de datos creada
EXEC sp_helpdb UNI00
```

tener en cuenta que el archivo **.mdf** guarda las transacciones:

## Antes de Todo debemos ingresar a la base de datos

Se debe poner en modo de uso la base de datos
```SQL
-- ingresar a la BD
USE UNI00
```
## Creando Tablas en nuestra Base de Datos

```sql
--usando otros tipo de datos
CREATE TABLE Persona (
	codPer INT IDENTITY PRIMARY KEY,
	nomPer VARCHAR(80) NOT NULL,
	dniPer CHAR(8) NOT NULL UNIQUE,
	fecNaci DATE,
	sexo CHAR(1) DEFAULT 'F' CHECK(sexo IN ('F','M')),
	edad AS DATEDIFF(YEAR, fecNaci, GETDATE()),
	nroHijos TINYINT,
	sueldo MONEY DEFAULT 930 CHECK(sueldo>=930));

CREATE TABLE Distrito (
	codDis CHAR(3) PRIMARY KEY,
	nomDis VARCHAR(80) NOT NULL UNIQUE);
```

## Introduciendo valores en nuestras tablas

1. Primera Forma
```sql
--insertando valores a la tabla Persona
INSERT Persona VALUES('Perico Perez', '12345678','1994-05-14','M',0,2300);

--insertando valores a la tabla Distrito
INSERT Distrito VALUES('L01', 'Lima');
INSERT Distrito VALUES('L21', 'Ancon');
INSERT Distrito VALUES('L32', 'SJM');
INSERT Distrito VALUES('L27', 'San Isidro');
INSERT Distrito VALUES('L18', 'Miraflores');
```

2. Segunda Forma
```sql
INSERT INTO Persona VALUES('Perico Perez' , '40302010' , '1994-05-14','M' , 0 , 2300)
```

## Creando un Foreign Key
```SQL
--modificando la tabla
ALTER TABLE Persona
ADD codPostal CHAR(3) REFERENCES Distrito;
```
<div style="page-break-after: always;"></div>

## visualizar toda la tabla
```sql
SELECT * FROM Persona;
```
