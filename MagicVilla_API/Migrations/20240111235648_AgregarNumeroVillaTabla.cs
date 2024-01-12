using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNumeroVillaTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NumerosVillas",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    DetalleEspecial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumerosVillas", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_NumerosVillas_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 1, 11, 20, 56, 46, 336, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 1, 11, 20, 56, 46, 336, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 1, 11, 20, 56, 46, 336, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 1, 11, 20, 56, 46, 336, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.CreateIndex(
                name: "IX_NumerosVillas_VillaId",
                table: "NumerosVillas",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumerosVillas");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 9, 48, 210, DateTimeKind.Local).AddTicks(5104), new DateTime(2024, 1, 11, 14, 9, 48, 210, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 9, 48, 210, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 1, 11, 14, 9, 48, 210, DateTimeKind.Local).AddTicks(5106) });
        }
    }
}
