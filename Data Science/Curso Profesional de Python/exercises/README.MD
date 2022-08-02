
# Fundamentos de Entity Framework

Packages:

* Microsoft.EntityFrameworkCore.Design

Instalar la herramient Entity framework
> dotnet tool install --global dotnet-ef

comando para crear una nueva migración usando dotnet CLI
> dotnet ef migrations add <Nombre de la migración>

Comando para remove una migracion antes de realizar una actualización de la base de datos
> dotnet ef migrations remove

comando que nos permite actualizar la base de datos y ejecutar todas las migraciones
> dotnet ef database update

