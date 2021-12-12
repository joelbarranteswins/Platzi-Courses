/*
semana 01
autor: Daniel Alexis Ramos Castañeda
*/

--quien soy???
select suser_sname()
go

--A que servidor estoy conectado???
select @@SERVERNAME
go

--Cual es la fecha y hora del servidor??
select GETDATE()
go

--Con que version estoy trabajando???
select @@VERSION
go

--Microsoft SQL Server 2017 (RTM) - 14.0.1000.169 (X64)   
--Aug 22 2017 17:04:49   Copyright (C) 2017 Microsoft Corporation  
--Developer Edition (64-bit) on Windows Server 2012 R2 Standard 6.3 <X64> (Build 9600: ) 
--(Hypervisor) 

-- que BDs existen en el servidor???
select * from sys.databases
go
--master --> info del servidor, BDs
--tempdb --> administrar Colas de Espera
--model  --> plantilla para la creacion de BD
--msdb   --> JOBs, backups realizados

/*
creando una BD
*/
create database UNI00
go
--luego
select * from sys.databases
go
--
exec sp_helpdb uni00
go
-- otra forma
use master
go
if exists (select name from sys.databases where name='UNI00')
	drop database UNI00
go
create database UNI00
on (name=UNI00_data, filename='c:\disco1\UNI00_data.mdf',
	size=10, maxsize=unlimited, filegrowth=10)
log on(name=UNI00_log, filename='c:\disco2\UNI00_log.ldf',
	size=7, maxsize=300, filegrowth=50% )
go
--validando
exec sp_helpdb uni00
;
-- ingresar a la BD
use UNI00
go
--verificando
select db_name()
go
--listando las tablas existentes
select * from sys.tables
;

--crear tablas
create table demo10 (
codigo int,
dato varchar(50) )
;
-- insertando datos
insert demo10 values(1,'hola')
insert demo10 values(2,'mundo')
;
insert into demo10 values(1,'hola')
insert into demo10 values(2,'mundo')

-- listando sus datos
select * from demo10
;
create table demo11 (
codigo int primary key,
dato varchar(50) not null unique )
;
-- insertando datos
insert demo11 values(1,'hola')
insert demo11 values(2,'mundo')
;
insert into demo11 values(3,'hola')
insert into demo11 values(4,'mundo')
--evitando los errores
insert into demo11 values(3,'hola mundo')
insert into demo11 values(4,'mundo te quiero')

select * from demo11
;
-- usando otros tipos de datos
create table Persona (
codPer int identity primary key,
nomPer varchar(80) not null,
dniPer char(8) not null unique,
fecNaci date,
sexo char(1) default 'F' check(sexo in('F','M')),
edad as datediff(year,fecNaci,getdate()),
nroHijos tinyint,
sueldo money default 930 check(sueldo>=930) )
;
insert Persona values('Perico Perez' , '40302010' , '1994-05-14','M' , 0 , 2300)

insert Persona(nomPer,dniPer,nroHijos) values('Rosita Rios' , '44332211' , 0)

select * from Persona

--
create table Distrito (
codDis char(3) primary key,
nomDis varchar(80) not null unique )
;
--
insert Distrito values('L01','Lima');
insert Distrito values('L02','Ancon');
insert Distrito values('L36','SJL');
insert Distrito values('L27','San Isidro');
insert Distrito values('L18','Miraflores');

--luego
select * from Distrito

--modificando la tabla
alter table Persona
add codPostal char(3) references Distrito
;

select * from Persona

insert Persona(nomPer,dniPer,nroHijos,codpostal) 
values('Pedrito Navaja2' , '78332211' , 0,'L99')

insert Persona(nomPer,dniPer,nroHijos,codpostal) 
values('Pedrito Navaja' , '77332211' , 0,'L02')














