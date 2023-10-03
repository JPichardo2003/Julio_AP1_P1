using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Julio_AP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class _2damigraciondebidoacambioenmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Observacion",
                table: "Aportes",
                newName: "Observación");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Observación",
                table: "Aportes",
                newName: "Observacion");
        }
    }
}
