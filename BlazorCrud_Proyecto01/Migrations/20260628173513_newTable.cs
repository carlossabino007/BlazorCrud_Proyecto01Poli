using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCrudProyecto01.Migrations;

/// <inheritdoc />
public partial class newTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropPrimaryKey(
            name: "PK_libro",
            table: "libro");

        migrationBuilder.RenameTable(
            name: "libro",
            newName: "Libro");

        migrationBuilder.AddColumn<int>(
            name: "IdTipoLibro",
            table: "Libro",
            type: "int",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddPrimaryKey(
            name: "PK_Libro",
            table: "Libro",
            column: "Id");

        migrationBuilder.CreateTable(
            name: "TipoLibro",
            columns: table => new
            {
                IdTipoLibro = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                Codigo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                Estado = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TipoLibro", x => x.IdTipoLibro);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "TipoLibro");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Libro",
            table: "Libro");

        migrationBuilder.DropColumn(
            name: "IdTipoLibro",
            table: "Libro");

        migrationBuilder.RenameTable(
            name: "Libro",
            newName: "libro");

        migrationBuilder.AddPrimaryKey(
            name: "PK_libro",
            table: "libro",
            column: "Id");
    }
}
