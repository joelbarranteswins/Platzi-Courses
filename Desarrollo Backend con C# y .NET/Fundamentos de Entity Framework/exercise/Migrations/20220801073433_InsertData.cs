using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Categoria_CategoriaID",
                table: "Tarea");

            migrationBuilder.RenameColumn(
                name: "CategoriaID",
                table: "Tarea",
                newName: "CategoriaId");

            migrationBuilder.RenameColumn(
                name: "TareaID",
                table: "Tarea",
                newName: "TareaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_CategoriaID",
                table: "Tarea",
                newName: "IX_Tarea_CategoriaId");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ac"), null, "Actividades pendientes", 20 });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ae"), null, "Actividades personales", 50 });

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Categoria_CategoriaId",
                table: "Tarea",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Categoria_CategoriaId",
                table: "Tarea");

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ac"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ae"));

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Tarea",
                newName: "CategoriaID");

            migrationBuilder.RenameColumn(
                name: "TareaId",
                table: "Tarea",
                newName: "TareaID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_CategoriaId",
                table: "Tarea",
                newName: "IX_Tarea_CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Categoria_CategoriaID",
                table: "Tarea",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
