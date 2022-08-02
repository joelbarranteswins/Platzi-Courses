using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class InsertDataTareas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"), new Guid("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ac"), null, new DateTime(2022, 8, 1, 3, 4, 23, 448, DateTimeKind.Local).AddTicks(9494), 1, "Pago de servicios publicos" });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb411"), new Guid("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ae"), null, new DateTime(2022, 8, 1, 3, 4, 23, 448, DateTimeKind.Local).AddTicks(9510), 2, "Terminar de ver pelicula en netflix" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb411"));
        }
    }
}
